using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class PickUp
    {

        [Key]
        public int PickUP_ID { get; set; }
        
        [ForeignKey("Customer_ID")]
        public int Customer_ID { get; set; }
        public Customer customer { get; set; }

        [Display(Name = "Weekly Pick Up Day (M-F)")] 
        public string Customer_PickUp_Reccuring { get; set; }

        [Display(Name = "Suspend Pick Up Start Date")]
        public DateTime? Customer_PickUp_Temp_Start { get; set; }

        [Display(Name = "Suspend Pick Up End Date")]
        public DateTime? Customer_PickUp_Temp_End { get; set; }

    }

}
