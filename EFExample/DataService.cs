using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;

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

        public IList<Order> GetOrders()
        {
            using var ctx = new NorthWindContext(_connectionString);

            return ctx.Orders.
                ToList();
                
        }

        public IList<Product> GetProducts()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return ctx.Products
               // .Where(b => b.ProductName == "Chai")
                .Include(x => x.Category)
                .ToList();
        }

        public IList<OrderDetail> GetOrderDetails()
        {
            using var ctx = new NorthWindContext(_connectionString); 

            
                return ctx.OrderDetails

             .Include(x => x.Order)
               .Include("Product.Category")
                //.Include(x => x.Product)
                   .ToList()
            
            ;
            
            
        }
        
    }
}
