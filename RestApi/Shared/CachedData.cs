using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Xml;

namespace RestApi.Shared
{
    public class CachedData
    {
        public static List<XmlNode> GetCachedData(string date)
        {
            if (HttpRuntime.Cache.Get("cachedCurrencyRates") == null)
            {
                var results = WebServiceCall.WebServiceCallAsync(date).Result;
                HttpRuntime.Cache.Add("cachedCurrencyRates", results, null, DateTime.Now.AddDays(1), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                return results;
            }
            else
            {
                var results = (List<XmlNode>)HttpRuntime.Cache.Get("cachedCurrencyRates");
                return results;
            }
        }
    }
}