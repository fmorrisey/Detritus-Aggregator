using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashCollectorWebApp.Models;

namespace TrashCollectorWebApp.Services
{
    public class GeocodingService
    {
        public string GetGeoCodingURL(Customer customer)
        {
            return $"http://maps.google.com/maps/api/geocode/json?address={customer.Line_1}+{customer.City}+{customer.State}++{customer.Zip}+&keys="
                + AuthKeys.AuthKeys.Google_API_Key;
        }



    }

    
}
