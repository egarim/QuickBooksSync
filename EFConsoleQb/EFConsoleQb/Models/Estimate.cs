using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Estimate
    {
        public Estimate()
        {
            EstimateLineItems = new HashSet<EstimateLineItem>();
            EstimateLinkedTransactions = new HashSet<EstimateLinkedTransaction>();
        }

        public string Id { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string? Memo { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Message { get; set; }
        public string? MessageId { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public string? SalesRep { get; set; }
        public string? SalesRepId { get; set; }
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
        public bool? IsActive { get; set; }
        public bool? IsToBeEmailed { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? Ponumber { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public string? Template { get; set; }
        public string? TemplateId { get; set; }
        public string? CustomerSalesTaxName { get; set; }
        public string? CustomerSalesTaxId { get; set; }
        public float? ExchangeRate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Other { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? TransactionCount { get; set; }
        public string? TransactionAggregate { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? ClassNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual SalesTaxCode? CustomerSalesTax { get; set; }
        public virtual CustomerMessage? MessageNavigation { get; set; }
        public virtual SalesRep? SalesRepNavigation { get; set; }
        public virtual SalesTaxItem? TaxItemNavigation { get; set; }
        public virtual Template? TemplateNavigation { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual ICollection<EstimateLinkedTransaction> EstimateLinkedTransactions { get; set; }
    }
}
