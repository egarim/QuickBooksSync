using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ItemLineItem
    {
        public string Id { get; set; } = null!;
        public string? ItemId { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? Type { get; set; }
        public string? Barcode { get; set; }
        public string? Account { get; set; }
        public string? AccountId { get; set; }
        public string? Cogsaccount { get; set; }
        public string? CogsaccountId { get; set; }
        public string? AssetAccount { get; set; }
        public string? AssetAccountId { get; set; }
        public int? LineItemNumber { get; set; }
        public string? LineItemId { get; set; }
        public string? LineItemName { get; set; }
        public float? LineItemQuantity { get; set; }
        public string? LineItemUnitOfMeasure { get; set; }
        public string? ParentName { get; set; }
        public string? ParentId { get; set; }
        public string? Description { get; set; }
        public float? Price { get; set; }
        public float? AverageCost { get; set; }
        public bool? IsActive { get; set; }
        public float? PurchaseCost { get; set; }
        public string? PurchaseDescription { get; set; }
        public string? PreferredVendor { get; set; }
        public string? PreferredVendorId { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxCodeId { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Account? AssetAccountNavigation { get; set; }
        public virtual Account? CogsaccountNavigation { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Item? LineItem { get; set; }
        public virtual Item? Parent { get; set; }
        public virtual Vendor? PreferredVendorNavigation { get; set; }
        public virtual SalesTaxCode? TaxCodeNavigation { get; set; }
    }
}
