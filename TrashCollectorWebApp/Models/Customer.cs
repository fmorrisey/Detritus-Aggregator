﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrashCollectorWebApp.Models.Calendar;

namespace TrashCollectorWebApp.Models
{
    public class Customer
    {
        public Customer()
        {
            
        }
        
        [Key]
        public int Customer_ID { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [Display(Name = "Street")]
        public string Line_1 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public int Zip { get; set; }

        [Display(Name = "Longitude")]
        public double Longitude  { get; set; }

        [Display(Name = "Latitude")]
        public double Latitude { get; set; }

        [Display(Name = "Weekly Pick Up Day (M-F)")]
        public DayOfWeek? Customer_PickUp_Reccuring { get; set; }
        public Day Day { get; set; }

        [NotMapped]
        public List<Day> DayOfWeeks { get; set; }
        
        public bool IsEnrolled { get; set; }
        
        [Display(Name = "One Time Pick Up")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Customer_PickUp_OneTime { get; set; }

        public bool OneTimePickUp { get; set; }

        [Display(Name = "Suspend Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Customer_PickUp_Temp_Start { get; set; }

        [Display(Name = "Suspend End Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Customer_PickUp_Temp_End { get; set; }
        
        [Display(Name = "Balance Due")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public bool ConfirmPickUp { get; set; }

        [NotMapped]
        
        public virtual ICollection<Customer> Customers { get; set; }





    }
}
