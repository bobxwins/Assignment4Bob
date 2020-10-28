
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var config = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables()
                .Build();

            var dataService = new DataService(config["connectionString"]);


           /* foreach (var elem in dataService.GetProducts())
            { 
                 
                    Console.WriteLine(elem);
            }*/


            foreach (var elem2 in dataService.GetOrderDetails())
            {
                Console.WriteLine(elem2);

            }


            //using var ctx = new NorthWindContext();

            //foreach (var product in ctx.Products.Include(x => x.Category))
            //{
            //    Console.WriteLine(product);
            //}


            //var cat = ctx.Categories.Find(9);

            //ctx.Categories.Remove(cat);

            ////cat.Name = "UpdateTest";
            ////cat.Description = "fdsjfsldkjfsdlkf";

            ////var maxId = ctx.Categories.Max(x => x.Id);

            ////ctx.Categories.Add(new Category {Id = maxId + 1, Name = "Testing"});

            //ctx.SaveChanges();

            //foreach (var category in ctx.Categories)
            //{
            //    Console.WriteLine(category);
            //}
        }
    }
}
