using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace RestApi.Shared
{
    public static class ParseDate
    {
        public static string GetYesterdayDate(string date)
        {
            DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            var yd = dt.AddDays(-1);
            var yesterdayDate = yd.ToString();
            return yesterdayDate;
        }
        public static void CheckDate(string date)
        {
            try
            {
                var dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var badDate = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                if (dt >= badDate)
                    throw new FormatException();
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Please enter the date in format yyyy-MM-dd", e);
            }
            catch (FormatException e)
            {
                throw new FormatException("Date should be smaller than 2015-01-01 and in format yyyy-MM-dd", e);
            }
            catch (Exception e)
            {
                throw new Exception("Error", e);
            }
        }
    }
}