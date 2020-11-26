using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Section16ExtensionMethods.Extensions
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else if (duration.TotalDays < 7)
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
            else
            {
                double s = duration.TotalDays / 7;
                return s.ToString("F1", CultureInfo.InvariantCulture) + " weeks";
            }
        }
    }
}
