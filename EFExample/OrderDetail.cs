using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;

namespace EFExample
{
    public class OrderDetail  
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        [Key]
        [Column(Order = 1)]

        //[ForeignKey("orderid")]

        public int  OrderId { get; set; }
    public  Order Order { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public Product Product { get; set; }

         public override string ToString()
        {
            return $"OrderId = {OrderId}, ProductName= {Product.ProductName}, UnitPrice = {UnitPrice}, Quantity = {Quantity},Discount= {Discount} ";
        }
         
    }
}

