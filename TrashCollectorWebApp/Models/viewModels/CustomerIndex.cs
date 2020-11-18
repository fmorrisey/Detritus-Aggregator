using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models.viewModels
{
    public class CustomerIndex
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}
