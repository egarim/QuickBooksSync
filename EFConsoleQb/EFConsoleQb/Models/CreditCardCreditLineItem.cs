using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CreditCardCreditLineItem
    {
        public string Id { get; set; } = null!;
        public string? CccreditId { get; set; }
        public DateTime? Date { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountName { get; set; }
        public string? AccountId { get; set; }
        public string? Memo { get; set; }
        public string? PayeeName { get; set; }
        public string? PayeeId { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? ItemLineId { get; set; }
        public string? ItemLineNumber { get; set; }
        public string? ItemName { get; set; }
        public string? ItemId { get; set; }
        public string? ItemGroup { get; set; }
        public string? ItemGroupId { get; set; }
        public string? ItemDescription { get; set; }
        public float? ItemQuantity { get; set; }
        public string? ItemUnitOfMeasure { get; set; }
        public float? ItemCost { get; set; }
        public decimal? ItemAmount { get; set; }
        public string? ItemBillableStatus { get; set; }
        public string? ItemCustomer { get; set; }
        public string? ItemCustomerId { get; set; }
        public string? ItemClass { get; set; }
        public string? ItemClassId { get; set; }
        public string? ItemTaxCode { get; set; }
        public string? ItemTaxCodeId { get; set; }
        public string? ItemInventorySiteId { get; set; }
        public string? ItemInventorySiteName { get; set; }
        public string? ItemInventorySiteLocationId { get; set; }
        public string? ItemInventorySiteLocationName { get; set; }
        public float? ExchangeRate { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? Account { get; set; }
        public virtual CreditCardCredit? Cccredit { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Class? ItemClassNavigation { get; set; }
        public virtual Customer? ItemCustomerNavigation { get; set; }
        public virtual Item? ItemGroupNavigation { get; set; }
        public virtual InventorySite? ItemInventorySite { get; set; }
        public virtual SalesTaxCode? ItemTaxCodeNavigation { get; set; }
        public virtual Vendor? Payee { get; set; }
    }
}
