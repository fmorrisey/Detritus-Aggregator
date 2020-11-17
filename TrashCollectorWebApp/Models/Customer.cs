using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }

        public IdentityRole IdentityRole { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        [Display(Name = "Street")]
        public string Line_1 { get; set; }

        [Display(Name = "Apartment")]
        public string Line_2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public int Zip { get; set; }

        [Display(Name = "Customer Address")]
        public string Customer_Address
        {
            get
            {
                return Line_1 + " " + Line_2 + " " + City + " " + State + " " + Zip;
            }
        }

        [ForeignKey("PickUp_ID")]
        public Customer_PickUp Customer_PickUp { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        

    }
}
