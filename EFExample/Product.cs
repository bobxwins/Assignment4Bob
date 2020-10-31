using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EFExample
{
    public class Product
    {
        [Key]
        public int  ProductId { get; set; }
       
        public string ProductName { get; set; }

        public int SupplierId { get; set; }
        public int UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }

        
         
        public int CategoryId { get; set; }
        public Category Category { get; set; }

         
        public override string ToString()
        {
            return $"ProductId = {ProductId} , ProductName = {ProductName} , CategoryName = {Category.CategoryName} , SupplierId={SupplierId} , UnitPrice={UnitPrice} , QuantityPerUnit = {QuantityPerUnit} , UnitInStock = {UnitsInStock}";
        }
    }
}

