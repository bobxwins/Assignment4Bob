using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections;

using System.ComponentModel.DataAnnotations.Schema;
namespace EFExample
{
   public class Order
    {
   
      
        [Key]
        public int Id { get; set; }
      public string CustomerId { get; set; }


        public OrderDetail OrderDetail { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
       
        public DateTime? ShippedDate { get; set; } 
        // add a questionmark after the datatype so it's nullable
       

        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
       
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public override string ToString()
        {
            // if (String.IsNullOrEmpty(format)) format = "Queery1";
             
            //String[] format2 = new String[4];

            string Query1 = $"  OrderId = {Id}, ProductId = {OrderDetail.Product.ProductId}, ProductName ={OrderDetail.Product.ProductName}, CustomerId = {CustomerId}, EmployeeId = {EmployeeId}, OrderDate = {OrderDate}, RequiredDate = {RequiredDate}, ShippedDate = {ShippedDate}, Freight = {Freight}, ShipName = {ShipName}, ShipCity= {ShipCity}, ShipPostalCode = {ShipPostalCode}, ShipCountry = {ShipCountry} UnitPrice = {OrderDetail.UnitPrice}, Quantity = {OrderDetail.Quantity}, Discount = {OrderDetail.Discount}, CategoryId = {OrderDetail.Product.CategoryId}, CategoryName = {OrderDetail.Product.Category.CategoryName}, Description = {OrderDetail.Product.Category.Description} ";

            string Query2 = $"  OrderId = {Id},ShippedDate = {ShippedDate}, ShipName = {ShipName} ,ShipCity = {ShipCity} " ;

           // string Query3 = $"  ProductId = {OrderDetail.Product.ProductId},OrderDate = {OrderDate}, UnitPrice = {OrderDetail.UnitPrice} , Quantity = {OrderDetail.Quantity} ";
            switch (Program.QuerySwitch)
            {
                case "1": 


                    return Query1;

                case "2":
                
                    return Query2;
                case "3": break;
               //     return Query3;
                 
 
            }
 
            return  "Something is wrong bro Scooby Doo";
        }
    }




}

