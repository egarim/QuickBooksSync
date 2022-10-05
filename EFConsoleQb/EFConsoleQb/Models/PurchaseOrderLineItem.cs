using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class PurchaseOrderLineItem
    {
        public string Id { get; set; } = null!;
        public string? PurchaseOrderId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public string? VendorMessage { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DueDate { get; set; }
        public string? ShipMethod { get; set; }
        public string? ShipMethodId { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public string? Memo { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Template { get; set; }
        public string? TemplateId { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public string? CustomFields { get; set; }
        public string? ItemLineId { get; set; }
        public string? ItemLineNumber { get; set; }
        public string? ItemName { get; set; }
        public string? ItemId { get; set; }
        public string? ItemGroup { get; set; }
        public string? ItemGroupId { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemCustomer { get; set; }
        public string? ItemCustomerId { get; set; }
        public string? ItemUnitOfMeasure { get; set; }
        public float? ItemQuantity { get; set; }
        public float? ItemRate { get; set; }
        public decimal? ItemAmount { get; set; }
        public float? ItemReceivedQuantity { get; set; }
        public string? ItemClass { get; set; }
        public string? ItemClassId { get; set; }
        public string? ItemInventorySiteLocationId { get; set; }
        public string? ItemInventorySiteLocationName { get; set; }
        public string? ItemIsManuallyClosed { get; set; }
        public string? ItemPartNumber { get; set; }
        public DateTime? ItemServiceDate { get; set; }
        public string? ItemOther1 { get; set; }
        public string? ItemOther2 { get; set; }
        public string? ItemCustomFields { get; set; }
        public bool? IsFullyReceived { get; set; }
        public string? IsManuallyClosed { get; set; }
        public bool? IsToBePrinted { get; set; }
        public bool? IsToBeEmailed { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? SalesTaxCodeName { get; set; }
        public string? SalesTaxCodeId { get; set; }
        public string? Fob { get; set; }
        public string? VendorAddress { get; set; }
        public string? VendorLine1 { get; set; }
        public string? VendorLine2 { get; set; }
        public string? VendorLine3 { get; set; }
        public string? VendorLine4 { get; set; }
        public string? VendorLine5 { get; set; }
        public string? VendorCity { get; set; }
        public string? VendorState { get; set; }
        public string? VendorPostalCode { get; set; }
        public string? VendorCountry { get; set; }
        public string? VendorNote { get; set; }
        public string? ShipToEntityId { get; set; }
        public string? ShipToEntityName { get; set; }
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
        public float? ExchangeRate { get; set; }
        public string? Other1 { get; set; }
        public string? Other2 { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? ClassNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Class? ItemClassNavigation { get; set; }
        public virtual Customer? ItemCustomerNavigation { get; set; }
        public virtual Item? ItemGroupNavigation { get; set; }
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
        public virtual SalesTaxCode? SalesTaxCode { get; set; }
        public virtual ShippingMethod? ShipMethodNavigation { get; set; }
        public virtual Template? TemplateNavigation { get; set; }
        public virtual Vendor? Vendor { get; set; }
    }
}
