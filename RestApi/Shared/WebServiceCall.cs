using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Xml;

namespace RestApi.Shared
{
    public class WebServiceCall
    {
        public static async Task<List<XmlNode>> WebServiceCallAsync(string date)
        {
            var ws = new ExchangeRatesService.ExchangeRatesSoapClient("ExchangeRatesSoap");
            var xmlDoc1 = ws.getExchangeRatesByDateAsync(date);
            var xmlDoc2 = ws.getExchangeRatesByDateAsync(ParseDate.GetYesterdayDate(date));
            await Task.WhenAll(xmlDoc1, xmlDoc2).ConfigureAwait(false);
            List<XmlNode> results = new List<XmlNode>
            {
                xmlDoc1.Result,
                xmlDoc2.Result
            };
            return results;
        }

    }
}