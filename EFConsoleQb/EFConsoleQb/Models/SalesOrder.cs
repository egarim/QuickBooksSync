using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesOrderLinkedTransactions = new HashSet<SalesOrderLinkedTransaction>();
        }

        public string Id { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string? ShipMethod { get; set; }
        public string? ShipMethodId { get; set; }
        public DateTime? ShipDate { get; set; }
        public string? Memo { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Message { get; set; }
        public string? MessageId { get; set; }
        public string? SalesRep { get; set; }
        public string? SalesRepId { get; set; }
        public string? Template { get; set; }
        public string? TemplateId { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public decimal? TotalAmountInHomeCurrency { get; set; }
        public string? Fob { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingLine1 { get; set; }
        public string? BillingLine2 { get; set; }
        public string? BillingLine3 { get; set; }
        public string? BillingLine4 { get; set; }
        public string? BillingLine5 { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }
        public string? BillingPostalCode { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingNote { get; set; }
        public string? ShippingAddress { get; set; }
        public string? ShippingLine1 { get; set; }
        public string? ShippingLine2 { get; set; }
        public string? ShippingLine3 { get; set; }
        public string? ShippingLine4 { get; set; }
        public string? ShippingLine5 { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingState { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? ShippingCountry { get; set; }
        public string? ShippingNote { get; set; }
        public decimal? Subtotal { get; set; }
        public float? Tax { get; set; }
        public string? TaxItem { get; set; }
        public string? TaxItemId { get; set; }
        public float? TaxPercent { get; set; }
        public string? Ponumber { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? TransactionCount { get; set; }
        public string? TransactionAggregate { get; set; }
        public string? CustomerTaxCode { get; set; }
        public string? CustomerTaxCodeId { get; set; }
        public bool? IsPrinted { get; set; }
        public string? IsManuallyClosed { get; set; }
        public bool? IsFullyInvoiced { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public bool? IsToBePrinted { get; set; }
        public bool? IsToBeEmailed { get; set; }
        public string? Other { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? ClassNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual SalesTaxCode? CustomerTaxCodeNavigation { get; set; }
        public virtual CustomerMessage? MessageNavigation { get; set; }
        public virtual SalesRep? SalesRepNavigation { get; set; }
        public virtual ShippingMethod? ShipMethodNavigation { get; set; }
        public virtual SalesTaxItem? TaxItemNavigation { get; set; }
        public virtual Template? TemplateNavigation { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesOrderLinkedTransaction> SalesOrderLinkedTransactions { get; set; }
    }
}
