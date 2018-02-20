using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Shared
{
    public class SortList
    {
        public static List<Item> SortedList(string date)
        {
            ParseDate.CheckDate(date);
            var firstObject = WebServiceData.GetDataFromWebService(date);
            var secondObject = WebServiceData.GetDataFromWebService(ParseDate.GetYesterdayDate(date));
            foreach (var item in firstObject.Items)
            {
                var matching = secondObject.Items.Find(q => q.currency == item.currency);
                item.difference = item.rate - matching.rate;
            }
            var sortedlist = firstObject.Items.OrderByDescending(o => o.difference).ToList();

            var ExchangeRatesObject = new ExchangeRates();
            return sortedlist;
        }
    }
}