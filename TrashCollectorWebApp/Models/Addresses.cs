using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class Addresses
    {
        [Key]
        public int Address_ID { get; set; }

        public string Line_1 { get; set; }
        public string Line_2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }


    }
}
