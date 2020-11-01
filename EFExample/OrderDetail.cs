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

       
        [Key]
        [Column(Order = 2)]
        public  int  OrderId { get;  set; }
        public   Order Order { get; set; }

     
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public Product Product { get; set; }
         
         public   override string  ToString()
          {
            // if (String.IsNullOrEmpty(format)) format = "Queery1";
            string[] OrderDetailsQuery = new string[4];
            OrderDetailsQuery[0] = $" ProductId = {Product.ProductId}, UnitPrice = {UnitPrice}, Quantity = {Quantity}";

 

            switch (Program.QuerySwitch)
            {
                case "1":
                     
                    return OrderDetailsQuery[0];

                case "2":
                    OrderDetailsQuery[1] = $"  ProductId= {Product.ProductId}, OrderDate = {Order.OrderDate}, UnitPrice = {UnitPrice}, Quantity = {Quantity}";
                    return OrderDetailsQuery[1];

                case "3": return "scooobyDOOOOO";
                    
                     
            }
            

            return $"Something is wrong bro"; 
              }
          }  
         

    }
 