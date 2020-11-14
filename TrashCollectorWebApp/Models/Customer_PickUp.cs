using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class Customer_PickUp
    {
        [Key]
        public int PickUp_ID { get; set; }
    }
}
