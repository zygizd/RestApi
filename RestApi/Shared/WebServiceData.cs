using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace RestApi.Shared
{
    public class WebServiceData
    {
        public static ExchangeRates GetDataFromWebService(string date)
        {
            try
            {
                var ws = new ExchangeRatesService.ExchangeRatesSoapClient("ExchangeRatesSoap");
                var xmlDoc = ws.getExchangeRatesByDate(date);
                var stringXml = xmlDoc.OuterXml;
                var serializer = new Serializer();
                var deserializedObject = serializer.Deserialize<ExchangeRates>(stringXml);
                return deserializedObject;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    [XmlRoot("ExchangeRates")]
    public class ExchangeRates
    {
        [XmlElement("item")]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [XmlElement("date")]
        public string date { get; set; }
        [XmlElement("currency")]
        public string currency { get; set; }
        [XmlElement("quantity")]
        public int quantity { get; set; }
        [XmlElement("rate")]
        public decimal rate { get; set; }
        [XmlElement("unit")]
        public string unit { get; set; }
        [XmlElement("difference")]
        public decimal difference { get; set; }
    }
}