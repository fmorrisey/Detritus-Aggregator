using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Services
{
    public static class DateAndTime
    {
        static string dateString = "6/11/2007";
        static DateTime dateValue;
        static DateTimeOffset dateOffsetValue;
        static DateTimeFormatInfo dateTimeFormats;

        // Convert date representation to a date value
        // dateValue = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
        // dateOffsetValue = new DateTimeOffset(dateValue,TimeZoneInfo.Local.GetUtcOffset(dateValue));
    }
}
