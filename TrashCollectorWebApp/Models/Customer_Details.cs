using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class Customer_Details
    {
        public Customer Customer { get; set; }
        public Customer_Accounts Customer_Accounts { get; set; }
        public Customer_PickUp Customer_PickUp { get; set; }
    }
}
