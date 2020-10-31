using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace EFExample
{

    public class OrderDetail //:IFormattable
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        
         

        //[ForeignKey("orderid")]
        [Key]
        [Column(Order = 1)]
        public int  OrderId 
        { get; 
            
            set; }
        public Order Order { get; set; }

     
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //public Category Category { get; set; }

        /*public   override string  ToString()
          {
              // if (String.IsNullOrEmpty(format)) format = "Queery1";
              

              String[] format2 = new String[4];

              string Query1 = $"OrderId = {OrderId}, CustomerId = {Order.CustomerId}, EmployeeId = {Order.EmployeeId}, OrderDate = {Order.OrderDate}, RequiredDate = {Order.RequiredDate}, ShippedDate = {Order.ShippedDate}, Freight = {Order.Freight}, ShipName = {Order.ShipName}, ShipCity= {Order.ShipCity}, ShipPostalCode = {Order.ShipPostalCode}, ShipCountry = {Order.ShipCountry} UnitPrice = {UnitPrice}, Quantity = {Quantity}, Discount = {Discount}, CategoryId = {Product.CategoryId}, CategoryName = {Product.Category.CategoryName}, Description = {Product.Category.Description} ";

              string Query2 = $"OrderId = {OrderId}";

            switch (Program.QuerySwitch)
            {
                case "1":
                    Program.QuerySwitch = "1";
                    return  Query1;
                 
                case "2":
                    Program.QuerySwitch = "1"; return Query2;

                case "3": return "scooobyDOOOOO";
                    
                     
            }
            

            return $"Something is wrong bro"; 
              }
          }  
        */


    }

}
 
