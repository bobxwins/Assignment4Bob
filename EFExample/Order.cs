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
       
    //    [Column("orderid")]
        [Key]
        public int OrderId { get; set; }
      public string CustomerId { get; set; }

        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
       
        public DateTime? ShippedDate { get; set; } // add a questionmark after the datatype so it's nullable
       

        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
       
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

         public override string ToString()
        {
            return $"OrderId = {OrderId}, CustomerId = {CustomerId}, EmployeeId = {EmployeeId}, OrderDate = {OrderDate}, RequiredDate = {RequiredDate}, ShippedDate = {ShippedDate}, Freight = {Freight}, ShipName = {ShipName}, ShipCity= {ShipCity}, ShipPostalCode = {ShipPostalCode}, ShipCountry = {ShipCountry} ";
        }
     
         
    }
}

