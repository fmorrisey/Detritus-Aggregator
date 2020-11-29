using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollectorWebApp.Models;
using TrashCollectorWebApp.Models.Calendar;

namespace TrashCollectorWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Day> Days { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            
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
                   Line_1 = "2643 N Downer Ave",
                   City = "Milwaukee",
                   State = "WI",
                   Zip = 53211,
                   Latitude = 43.066935,
                   Longitude = -87.878068,
                   Balance = 20,
                   //Customer_PickUp_OneTime = 1,
                   IsEnrolled = true

               });

            modelBuilder.Entity<Employee>()
               .HasData(
               new Employee
               {
                   Employee_ID = 1,
                   FirstName = "Detritus",
                   LastName = "Aggregator",
                   Title = "Sanitation Extraordinare"
               });
            
           
            modelBuilder.Entity<Day>()
               .HasData(
               new Day
               {
                   Id = 1,
                   WeekDay = "Monday"
               }, new Day
               {
                   Id = 2,
                   WeekDay = "Tuesday"
               }, new Day
               {
                   Id = 3,
                   WeekDay = "Wednesday"
               }, new Day
               {
                   Id = 4,
                   WeekDay = "Thursday"
               }, new Day
               {
                   Id = 5,
                   WeekDay = "Friday"
               });
            
        }


       


            


    }
}
