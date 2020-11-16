using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollectorWebApp.Models;

namespace TrashCollectorWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          
        }

        //public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });

            modelBuilder.Entity<IdentityRole>()
               .HasData(
               new IdentityRole
               {
                   Name = "Customer",
                   NormalizedName = "CUSTOMER"
               });

            modelBuilder.Entity<IdentityRole>()
               .HasData(
               new IdentityRole
               {
                   Name = "Employee",
                   NormalizedName = "EMPLOYEE"
               });

            modelBuilder.Entity<Customer>()
               .HasData(
               new Customer
               {
                   Customer_ID = 1,
                   FirstName = "Timmy",
                   LastName = "Test",

               });
            modelBuilder.Entity<Customer_Accounts>()
               .HasData(
               new Customer_Accounts
               {
                   Account_ID = 1,
                   Customer_ID = 1,
                   Balance = 0,

               });

            modelBuilder.Entity<Employee>()
               .HasData(
               new Employee
               {
                   Employee_ID = 1,
                   FirstName = "Detritus",
                   LastName = "Aggregator",
               });
        }

        public DbSet<TrashCollectorWebApp.Models.Addresses> Addresses { get; set; }

            


    }
}
