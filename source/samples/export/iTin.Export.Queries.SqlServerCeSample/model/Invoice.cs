using System;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    [Serializable]
    public class Invoice
    {
        public const string InvoiceQuery = @"SELECT 
                                                [IVC].[INVOICEID] AS [ID], 
                                             [IVC].[INVOICEDATE] AS [DATE], 
                                             [CST].[FIRSTNAME] AS [CUSTOMERFIRSTNAME], 
                                             [CST].[LASTNAME] AS [CUSTOMERLASTNAME], 
                                             [CST].[PHONE] AS [CUSTOMERPHONE],
                                             [CST].[EMAIL] AS [CUSTOMEREMAIL],
                                             [IVC].[BILLINGADDRESS] AS [BILLINGADDRESS], 
                                             [IVC].[BILLINGCITY] AS [BILLINGCITY], 
                                             [IVC].[BILLINGSTATE] AS [BILLINGSTATE], 
                                             [IVC].[BILLINGCOUNTRY] AS [BILLINGCOUNTRY],  
                                             [IVC].[BILLINGPOSTALCODE] AS [BILLINGPOSTALCODE], 
                                             [IVC].[TOTAL] AS [TOTAL]
                                             FROM [INVOICE] [IVC]
                                             INNER JOIN [CUSTOMER] [CST] ON [IVC].[CUSTOMERID] = [CST].[CUSTOMERID]";

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }
}
