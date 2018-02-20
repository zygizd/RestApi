﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestApi.ExchangeRatesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.lb.lt/ExchangeRates", ConfigurationName="ExchangeRatesService.ExchangeRatesSoap")]
    public interface ExchangeRatesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getListOfCurrencies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getListOfCurrencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getListOfCurrencies", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getListOfCurrenciesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getCurrentExchangeRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        decimal getCurrentExchangeRate(string Currency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getCurrentExchangeRate", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> getCurrentExchangeRateAsync(string Currency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        decimal getExchangeRate(string Currency, string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRate", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> getExchangeRateAsync(string Currency, string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByDate_XmlString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getExchangeRatesByDate_XmlString(string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByDate_XmlString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getExchangeRatesByDate_XmlStringAsync(string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByCurrency_XmlString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getExchangeRatesByCurrency_XmlString(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByCurrency_XmlString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getExchangeRatesByCurrency_XmlStringAsync(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getExchangeRatesByDate(string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByDate", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByDateAsync(string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesXmlSchema", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getExchangeRatesXmlSchema();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesXmlSchema", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getExchangeRatesXmlSchemaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByCurrency", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getExchangeRatesByCurrency(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByCurrency", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByCurrencyAsync(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeAvgRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getExchangeAvgRate(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeAvgRate", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeAvgRateAsync(string Currency, string DateLow, string DateHigh);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExchangeRatesSoapChannel : RestApi.ExchangeRatesService.ExchangeRatesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExchangeRatesSoapClient : System.ServiceModel.ClientBase<RestApi.ExchangeRatesService.ExchangeRatesSoap>, RestApi.ExchangeRatesService.ExchangeRatesSoap {
        
        public ExchangeRatesSoapClient() {
        }
        
        public ExchangeRatesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExchangeRatesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeRatesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeRatesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Xml.XmlNode getListOfCurrencies() {
            return base.Channel.getListOfCurrencies();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getListOfCurrenciesAsync() {
            return base.Channel.getListOfCurrenciesAsync();
        }
        
        public decimal getCurrentExchangeRate(string Currency) {
            return base.Channel.getCurrentExchangeRate(Currency);
        }
        
        public System.Threading.Tasks.Task<decimal> getCurrentExchangeRateAsync(string Currency) {
            return base.Channel.getCurrentExchangeRateAsync(Currency);
        }
        
        public decimal getExchangeRate(string Currency, string Date) {
            return base.Channel.getExchangeRate(Currency, Date);
        }
        
        public System.Threading.Tasks.Task<decimal> getExchangeRateAsync(string Currency, string Date) {
            return base.Channel.getExchangeRateAsync(Currency, Date);
        }
        
        public string getExchangeRatesByDate_XmlString(string Date) {
            return base.Channel.getExchangeRatesByDate_XmlString(Date);
        }
        
        public System.Threading.Tasks.Task<string> getExchangeRatesByDate_XmlStringAsync(string Date) {
            return base.Channel.getExchangeRatesByDate_XmlStringAsync(Date);
        }
        
        public string getExchangeRatesByCurrency_XmlString(string Currency, string DateLow, string DateHigh) {
            return base.Channel.getExchangeRatesByCurrency_XmlString(Currency, DateLow, DateHigh);
        }
        
        public System.Threading.Tasks.Task<string> getExchangeRatesByCurrency_XmlStringAsync(string Currency, string DateLow, string DateHigh) {
            return base.Channel.getExchangeRatesByCurrency_XmlStringAsync(Currency, DateLow, DateHigh);
        }
        
        public System.Xml.XmlNode getExchangeRatesByDate(string Date) {
            return base.Channel.getExchangeRatesByDate(Date);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByDateAsync(string Date) {
            return base.Channel.getExchangeRatesByDateAsync(Date);
        }
        
        public string getExchangeRatesXmlSchema() {
            return base.Channel.getExchangeRatesXmlSchema();
        }
        
        public System.Threading.Tasks.Task<string> getExchangeRatesXmlSchemaAsync() {
            return base.Channel.getExchangeRatesXmlSchemaAsync();
        }
        
        public System.Xml.XmlNode getExchangeRatesByCurrency(string Currency, string DateLow, string DateHigh) {
            return base.Channel.getExchangeRatesByCurrency(Currency, DateLow, DateHigh);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByCurrencyAsync(string Currency, string DateLow, string DateHigh) {
            return base.Channel.getExchangeRatesByCurrencyAsync(Currency, DateLow, DateHigh);
        }
        
        public System.Xml.XmlNode getExchangeAvgRate(string Currency, string DateLow, string DateHigh) {
            return base.Channel.getExchangeAvgRate(Currency, DateLow, DateHigh);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeAvgRateAsync(string Currency, string DateLow, string DateHigh) {
            return base.Channel.getExchangeAvgRateAsync(Currency, DateLow, DateHigh);
        }
    }
}
