using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class InventorySite
    {
        public InventorySite()
        {
            BillLineItems = new HashSet<BillLineItem>();
            BuildAssemblies = new HashSet<BuildAssembly>();
            BuildAssemblyLineItemComponentItemLineRetInventorySiteRefLists = new HashSet<BuildAssemblyLineItem>();
            BuildAssemblyLineItemInventorySiteRefLists = new HashSet<BuildAssemblyLineItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCreditLineItems = new HashSet<CreditCardCreditLineItem>();
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            EstimateLineItems = new HashSet<EstimateLineItem>();
            InventoryAdjustmentLineItems = new HashSet<InventoryAdjustmentLineItem>();
            InventoryAdjustments = new HashSet<InventoryAdjustment>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            ItemSites = new HashSet<ItemSite>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            TransferInventoryFromInventorySiteRefLists = new HashSet<TransferInventory>();
            TransferInventoryLineItemFromInventorySiteRefLists = new HashSet<TransferInventoryLineItem>();
            TransferInventoryLineItemToInventorySiteRefLists = new HashSet<TransferInventoryLineItem>();
            TransferInventoryToInventorySiteRefLists = new HashSet<TransferInventory>();
            VendorCreditLineItems = new HashSet<VendorCreditLineItem>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? SiteDesc { get; set; }
        public string? Contact { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? SiteAddressAddr1 { get; set; }
        public string? SiteAddressAddr2 { get; set; }
        public string? SiteAddressAddr3 { get; set; }
        public string? SiteAddressAddr4 { get; set; }
        public string? SiteAddressAddr5 { get; set; }
        public string? SiteAddressCity { get; set; }
        public string? SiteAddressState { get; set; }
        public string? SiteAddressPostalCode { get; set; }
        public string? SiteAddressCountry { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public bool? IsDefaultSite { get; set; }

        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<BuildAssembly> BuildAssemblies { get; set; }
        public virtual ICollection<BuildAssemblyLineItem> BuildAssemblyLineItemComponentItemLineRetInventorySiteRefLists { get; set; }
        public virtual ICollection<BuildAssemblyLineItem> BuildAssemblyLineItemInventorySiteRefLists { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual ICollection<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; }
        public virtual ICollection<InventoryAdjustment> InventoryAdjustments { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<ItemSite> ItemSites { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<TransferInventory> TransferInventoryFromInventorySiteRefLists { get; set; }
        public virtual ICollection<TransferInventoryLineItem> TransferInventoryLineItemFromInventorySiteRefLists { get; set; }
        public virtual ICollection<TransferInventoryLineItem> TransferInventoryLineItemToInventorySiteRefLists { get; set; }
        public virtual ICollection<TransferInventory> TransferInventoryToInventorySiteRefLists { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItems { get; set; }
    }
}
