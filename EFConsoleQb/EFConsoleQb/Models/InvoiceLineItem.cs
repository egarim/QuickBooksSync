using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class InvoiceLineItem
    {
        public string Id { get; set; } = null!;
        public string? InvoiceId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public string? Account { get; set; }
        public string? AccountId { get; set; }
        public DateTime? Date { get; set; }
        public string? ShipMethod { get; set; }
        public string? ShipMethodId { get; set; }
        public DateTime? ShipDate { get; set; }
        public string? Memo { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public decimal? Amount { get; set; }
        public string? Message { get; set; }
        public string? MessageId { get; set; }
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
        public string? Ponumber { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public string? CustomFields { get; set; }
        public string? ItemLineId { get; set; }
        public string? ItemLineNumber { get; set; }
        public string? ItemName { get; set; }
        public string? ItemId { get; set; }
        public string? ItemGroup { get; set; }
        public string? ItemGroupId { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemUnitOfMeasure { get; set; }
        public float? ItemQuantity { get; set; }
        public float? ItemRate { get; set; }
        public float? ItemRatePercent { get; set; }
        public string? ItemTaxCode { get; set; }
        public string? ItemTaxCodeId { get; set; }
        public decimal? ItemAmount { get; set; }
        public string? ItemClass { get; set; }
        public string? ItemClassId { get; set; }
        public DateTime? ItemServiceDate { get; set; }
        public string? ItemInventorySiteId { get; set; }
        public string? ItemInventorySiteName { get; set; }
        public string? ItemInventorySiteLocationId { get; set; }
        public string? ItemInventorySiteLocationName { get; set; }
        public string? ItemSerialNumber { get; set; }
        public string? ItemLotNumber { get; set; }
        public string? ItemOther1 { get; set; }
        public string? ItemOther2 { get; set; }
        public string? ItemCustomFields { get; set; }
        public string? ItemUomsetFullName { get; set; }
        public string? ItemUomsetListId { get; set; }
        public string? ItemIsGetPrintItemsInGroup { get; set; }
        public decimal? AppliedAmount { get; set; }
        public decimal? Balance { get; set; }
        public string? CustomerTaxCode { get; set; }
        public string? CustomerTaxCodeId { get; set; }
        public bool? IsToBePrinted { get; set; }
        public bool? IsToBeEmailed { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public bool? IsPending { get; set; }
        public string? IsFinanceCharge { get; set; }
        public string? Template { get; set; }
        public string? TemplateId { get; set; }
        public decimal? SuggestedDiscountAmount { get; set; }
        public DateTime? SuggestedDiscountDate { get; set; }
        public float? ExchangeRate { get; set; }
        public float? BalanceInHomeCurrency { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public string? Other { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Class? ClassNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual SalesTaxCode? CustomerTaxCodeNavigation { get; set; }
        public virtual Invoice? Invoice { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Class? ItemClassNavigation { get; set; }
        public virtual Item? ItemGroupNavigation { get; set; }
        public virtual InventorySite? ItemInventorySite { get; set; }
        public virtual SalesTaxCode? ItemTaxCodeNavigation { get; set; }
        public virtual UnitOfMeasure? ItemUomsetList { get; set; }
        public virtual CustomerMessage? MessageNavigation { get; set; }
        public virtual SalesRep? SalesRepNavigation { get; set; }
        public virtual ShippingMethod? ShipMethodNavigation { get; set; }
        public virtual SalesTaxItem? TaxItemNavigation { get; set; }
        public virtual Template? TemplateNavigation { get; set; }
    }
}
