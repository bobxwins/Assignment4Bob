using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Immutable;

namespace EFExample
{
    public class DataService
    {
        private readonly string _connectionString;

        public DataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<Category> GetCategories()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return ctx.Categories.ToList();
        }

        public IList<Product> GetProducts()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return ctx.Products
                // .Where(b => b.ProductName == "Chai")
                .Include(x => x.Category)
                .ToList();
        }
        public IList<Order> GetOrders()
        { 
            var ctx = new NorthWindContext(_connectionString);
            var OrderQuery1 = ctx.Orders
                     
                    .Include("OrderDetail.Product.Category")

                   .Where(b => b.Id == 10747)

            .ToList();

           

            switch (Program.QuerySwitch)
            {
                case "2":

                    return OrderQuery1;

                case "1":
                    var OrderQuery2 = ctx.Orders

            .Include("OrderDetail.Product.Category")

           .Where(b => b.ShipName == "LILA-Supermercado")

    .ToList();

                    return OrderQuery2;

                    /*  case "3": Dont really understand what we are supposed to do with Order Task 3
                          return Query3; */

            }
             
            return ctx.Orders
                    //  .Include(x => x.OrderDetail)
                    .Include("OrderDetail.Product.Category")

                   .Where(b => b.Id == 10747)

            .ToList();

        }
         
        public IList<OrderDetail> GetOrderDetails()
            {
                using (var ctx = new NorthWindContext(_connectionString))

                {
                    switch (Program.QuerySwitch)
                    {
                        case "1":
                            var OrderDetailsQuery1 = ctx.OrderDetails

          .Include(x => x.Order)
              .Include(x => x.Product).
              Where(X => X.ProductId == 69).ToList();

                            return OrderDetailsQuery1;

                        case "2":
                            var OrderDetailsQuery2 = ctx.OrderDetails

              .Include("Product")
              .Where(b => b.OrderId == 10747).ToList();


                            return OrderDetailsQuery2;
 
                    }

                    return ctx.OrderDetails.ToList();


                }

            }
        }
    }


