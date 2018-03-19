using System.Collections.Generic;
using System.Linq;

namespace RestApi.Shared
{
    public class SortList
    {
        public static List<Item> SortedList(string date)
        {
            ParseDate.CheckDate(date);
            var results = CachedData.GetCachedData(date);
            var firstObject = GetDataFromXml.GetDataFromXmlNode(results[0]);
            var secondObject = GetDataFromXml.GetDataFromXmlNode(results[1]);
            foreach (var item in firstObject.Items)
            {
                var matching = secondObject.Items.Find(q => q.Currency == item.Currency);
                item.Difference = item.Rate - matching.Rate;
            }
            var sortedlist = firstObject.Items.OrderByDescending(o => o.Difference).ToList();
            return sortedlist;
        }
    }
}