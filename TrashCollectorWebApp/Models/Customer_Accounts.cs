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

        [ForeignKey("Id")]
        public string Customer_ID { get; set; }
        public Customer customer { get; set; }
    }
}
