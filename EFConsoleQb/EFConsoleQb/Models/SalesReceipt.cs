using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class SalesReceipt
    {
        public SalesReceipt()
        {
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
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
        public DateTime? DueDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Message { get; set; }
        public string? MessageId { get; set; }
        public string? SalesRep { get; set; }
        public string? SalesRepId { get; set; }
        public string? Template { get; set; }
        public string? TemplateId { get; set; }
        public float? ExchangeRate { get; set; }
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
        public bool? IsPending { get; set; }
        public bool? IsToBePrinted { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public bool? IsToBeEmailed { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public string? CheckNumber { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentMethodId { get; set; }
        public string? DepositAccount { get; set; }
        public string? DepositAccountId { get; set; }
        public string? CustomerTaxCode { get; set; }
        public string? CustomerTaxCodeId { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? ClassNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual SalesTaxCode? CustomerTaxCodeNavigation { get; set; }
        public virtual Account? DepositAccountNavigation { get; set; }
        public virtual CustomerMessage? MessageNavigation { get; set; }
        public virtual PaymentMethod? PaymentMethodNavigation { get; set; }
        public virtual SalesRep? SalesRepNavigation { get; set; }
        public virtual ShippingMethod? ShipMethodNavigation { get; set; }
        public virtual SalesTaxItem? TaxItemNavigation { get; set; }
        public virtual Template? TemplateNavigation { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
    }
}
