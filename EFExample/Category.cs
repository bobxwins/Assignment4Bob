using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFExample
{
    public class Category
    {
        [Key]
        public int  Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"CategoryId = {Id}, CategoryName = {CategoryName}, Description = {Description}";
        }
    }
}
