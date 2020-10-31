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

            //Orders ord = new Orders();
            var ctx = new NorthWindContext(_connectionString);
            var OrderQuery1= ctx.Orders
                    //  .Include(x => x.OrderDetail)
                    .Include("OrderDetail.Product.Category")

                   .Where(b => b.Id == 10747)

            .ToList();

            var OrderQuery2 = ctx.Orders
                    //  .Include(x => x.OrderDetail)
                    .Include("OrderDetail.Product.Category")

                   .Where(b => b.ShipName == "LILA-Supermercado")

            .ToList();

            switch (Program.QuerySwitch)
            {
                case "1":

                    return OrderQuery1;

                case "2":

                    return OrderQuery2;

              /*  case "3": Dont really understand what we are supposed to do with Order Task 3
                    return Query3; */ 

            }




            return ctx.Orders
                    //  .Include(x => x.OrderDetail)
                    .Include("OrderDetail.Product.Category")

                   .Where(b => b.Id == 10747)
                  
            .ToList();



            /*   .Select(x => new Order
                   {
                       Id = x.Id,
                        OrderDetail = x.ProcessID,
                       UserName = x.Username
                   }).ToList(); */
        }

        public IList<OrderDetail> GetOrderDetails()
        {
            using (var ctx = new NorthWindContext(_connectionString))
 
            {
               var ordert1 = ctx.OrderDetails
 
             .Include(x => x.Order)
               .Include("Product.Category")
              
                   .ToList();
                 
                return ordert1;
 
            }
 
        }
        }
    }

