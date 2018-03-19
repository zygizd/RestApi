using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace RestApi.Shared
{
    public class GetDataFromXml
    {
        public static ExchangeRates GetDataFromXmlNode(XmlNode xml)
        {
            try
            {
                var xmlDoc = xml;
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
        public string Date { get; set; }
        [XmlElement("currency")]
        public string Currency { get; set; }
        [XmlElement("quantity")]
        public int Quantity { get; set; }
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        [XmlElement("unit")]
        public string Unit { get; set; }
        [XmlElement("difference")]
        public decimal Difference { get; set; }
    }
}