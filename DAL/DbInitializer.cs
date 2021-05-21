using Databases_2_Project2_Grocery_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_2_Project2_Grocery_store.DAL
{
    public class DbInitializer
    {
        public static void Initialize (StoreContext context)
        {
            context.Database.EnsureCreated();

            if(context.Products.Any())
            {
                return;
            }
            var products = new Product[]
            {
                new Drink { Name = "Tassay", Type = "Water", Price = 2, Available = true, Volume = 0.5},
                new Food { Name = "PanPiek", Type = "Bread", Price = 3, Available = true, Weight = 0.4},
                new Drink { Name = "Polmlek", Type = "Milk", Price = 2.5, Available = true, Volume = 1},
                new Drink { Name = "Orange Juice", Type = "Juice", Price = 4, Available = true, Volume = 1 },
                new Food {Name = "Red Apple", Type = "Fruit", Price = 2.5, Available = true, Weight = 1 }
            };

            foreach(Product p in products)
            {
                context.Products.Add(p);
            }

            var people = new Person[]
            {
                new Employee {FirstName = "John", LastName = "Doe", Birthday = DateTime.Parse("1/1/2000"), HireDate = DateTime.Parse("1/2/2020"), Location = "Poznan"}
            };

            foreach (Person p in people)
            {
                context.People.Add(p);
            }

            context.SaveChanges();
        }
    }
}
