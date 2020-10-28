using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExample
{
    public class OrderDetails
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        [Key]

         [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            return $"OrderId = {Order.OrderId}, ProductName= {Product.ProductName}, UnitPrice = {UnitPrice}, Quantity = {Quantity},Discount= {Discount} ";
        }

    }
}

