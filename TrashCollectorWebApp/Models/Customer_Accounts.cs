using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class Customer_Accounts
    {
        [Key]
        public int Account_ID { get; set; }

        [ForeignKey("Customer_ID")]
        public string Customer_ID { get; set; }

        [Column(TypeName = "decimal(18,2)")] //https://stackoverflow.com/a/56494920
        [Display(Name = "Balance Due")]
        public decimal Balance { get; set; }

        


    }
}
