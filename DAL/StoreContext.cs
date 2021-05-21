using System;
using Databases_2_Project2_Grocery_store.Models;
using Microsoft.EntityFrameworkCore;


namespace Databases_2_Project2_Grocery_store.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Employee>().ToTable("Employees");


            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 2, FirstName = "Bob", LastName = "Belcher", 
                    Birthday = DateTime.Parse("1977-01-23"), LoyaltyProgram = true },
                new Client { Id = 3, FirstName = "Hank", LastName = "Hill", 
                    Birthday = DateTime.Parse("1954-04-19"), LoyaltyProgram = false }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee {Id = 1, FirstName = "Jace", LastName = "Beleren", 
                    Birthday = DateTime.Parse("1980-02-23"), Location = "Poznan", 
                    HireDate = DateTime.Parse("2021-05-01") }
            );
            modelBuilder.Entity<Food>().HasData(
                new Food { Id = 2, Name = "PanPiek", Type = "Bread", Price = 3, Available = true, Weight = 0.4 },
                new Food { Id = 5, Name = "Red Apple", Type = "Fruit", Price = 2.5, Available = true, Weight = 1 }
            );
            modelBuilder.Entity<Drink>().HasData(
                new Drink { Id = 1, Name = "Tassay", Type = "Water", Price = 2, Available = true, Volume = 0.5 },
                new Drink { Id = 3, Name = "Polmlek", Type = "Milk", Price = 2.5, Available = true, Volume = 1 },
                new Drink { Id = 4, Name = "Orange Juice", Type = "Juice", Price = 4, Available = true, Volume = 1 }
            );

        }
    }
}
