
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace EFExample
{
    class Program   
    {
        public static Product Product { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public Order Order { get; set; }
        public Category Category { get; set; }

        public static string QuerySwitch;
        static void Main(string[] args)
        {
        var config = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables()
                .Build();

            var dataService = new DataService(config["connectionString"]);

              foreach (var elem in dataService.GetOrders())
                 {
                QuerySwitch = "1";
            
                Console.WriteLine(elem);
                  
            }

            foreach (var elem in dataService.GetOrders())
            {
                QuerySwitch = "2";
                Console.WriteLine(elem);
       
            }  
 
        } 
         
        }

         


}

