using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Item
    {
        public Item()
        {
            BillLineItemItemGroupNavigations = new HashSet<BillLineItem>();
            BillLineItemItems = new HashSet<BillLineItem>();
            BuildAssemblies = new HashSet<BuildAssembly>();
            BuildAssemblyLineItemComponentItemLineRetItemRefLists = new HashSet<BuildAssemblyLineItem>();
            BuildAssemblyLineItemItemInventoryAssemblyRefLists = new HashSet<BuildAssemblyLineItem>();
            CheckLineItemItemGroupNavigations = new HashSet<CheckLineItem>();
            CheckLineItemItems = new HashSet<CheckLineItem>();
            CreditCardChargeLineItemItemGroupNavigations = new HashSet<CreditCardChargeLineItem>();
            CreditCardChargeLineItemItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCreditLineItemItemGroupNavigations = new HashSet<CreditCardCreditLineItem>();
            CreditCardCreditLineItemItems = new HashSet<CreditCardCreditLineItem>();
            CreditMemoLineItemItemGroupNavigations = new HashSet<CreditMemoLineItem>();
            CreditMemoLineItemItems = new HashSet<CreditMemoLineItem>();
            EstimateLineItemItemGroupNavigations = new HashSet<EstimateLineItem>();
            EstimateLineItemItems = new HashSet<EstimateLineItem>();
            InventoryAdjustmentLineItems = new HashSet<InventoryAdjustmentLineItem>();
            InverseParent = new HashSet<Item>();
            InvoiceLineItemItemGroupNavigations = new HashSet<InvoiceLineItem>();
            InvoiceLineItemItems = new HashSet<InvoiceLineItem>();
            ItemLineItemItems = new HashSet<ItemLineItem>();
            ItemLineItemLineItems = new HashSet<ItemLineItem>();
            ItemLineItemParents = new HashSet<ItemLineItem>();
            ItemReceiptLineItemItemGroupNavigations = new HashSet<ItemReceiptLineItem>();
            ItemReceiptLineItemItems = new HashSet<ItemReceiptLineItem>();
            ItemSiteItemInventoryAssemblyRefLists = new HashSet<ItemSite>();
            ItemSiteItemInventoryRefLists = new HashSet<ItemSite>();
            PriceLevelPerItems = new HashSet<PriceLevelPerItem>();
            PurchaseOrderLineItemItemGroupNavigations = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrderLineItemItems = new HashSet<PurchaseOrderLineItem>();
            SalesOrderLineItemItemGroupNavigations = new HashSet<SalesOrderLineItem>();
            SalesOrderLineItemItems = new HashSet<SalesOrderLineItem>();
            SalesReceiptLineItemItemGroupNavigations = new HashSet<SalesReceiptLineItem>();
            SalesReceiptLineItemItems = new HashSet<SalesReceiptLineItem>();
            StatementCharges = new HashSet<StatementCharge>();
            TimeTrackings = new HashSet<TimeTracking>();
            TransferInventoryLineItems = new HashSet<TransferInventoryLineItem>();
            VehicleMileages = new HashSet<VehicleMileage>();
            VendorCreditLineItemItemGroupNavigations = new HashSet<VendorCreditLineItem>();
            VendorCreditLineItemItems = new HashSet<VendorCreditLineItem>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? Type { get; set; }
        public string? Account { get; set; }
        public string? AccountId { get; set; }
        public string? Cogsaccount { get; set; }
        public string? CogsaccountId { get; set; }
        public string? AssetAccount { get; set; }
        public string? AssetAccountId { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public DateTime? DateSold { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? ItemCount { get; set; }
        public string? ParentName { get; set; }
        public string? ParentId { get; set; }
        public string? Description { get; set; }
        public float? Price { get; set; }
        public float? PricePercent { get; set; }
        public float? AverageCost { get; set; }
        public bool? IsActive { get; set; }
        public float? PurchaseCost { get; set; }
        public string? PurchaseDescription { get; set; }
        public string? ExpenseAccount { get; set; }
        public string? ExpenseAccountId { get; set; }
        public string? PreferredVendor { get; set; }
        public string? PreferredVendorId { get; set; }
        public float? QuantityOnHand { get; set; }
        public float? QuantityOnOrder { get; set; }
        public float? QuantityOnSalesOrder { get; set; }
        public DateTime? InventoryDate { get; set; }
        public float? ReorderPoint { get; set; }
        public string? Barcode { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxCodeId { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? PurchaseTaxCode { get; set; }
        public string? PurchaseTaxCodeId { get; set; }
        public string? PartNumber { get; set; }
        public string? PaymentMethodName { get; set; }
        public string? PaymentMethodId { get; set; }
        public float? TaxRate { get; set; }
        public string? TaxVendorName { get; set; }
        public string? TaxVendorId { get; set; }
        public string? SpecialItemType { get; set; }
        public string? VendorOrPayeeName { get; set; }
        public bool? IsPrintItemsInGroup { get; set; }
        public string? SalesExpense { get; set; }
        public string? AssetAcquiredAs { get; set; }
        public string? AssetDescription { get; set; }
        public string? AssetLocation { get; set; }
        public string? AssetPonumber { get; set; }
        public string? AssetSerialNumber { get; set; }
        public DateTime? AssetWarrantyExpires { get; set; }
        public string? AssetNotes { get; set; }
        public string? AssetNumber { get; set; }
        public decimal? AssetCostBasis { get; set; }
        public float? AssetDepreciation { get; set; }
        public float? AssetBookValue { get; set; }
        public string? UnitOfMeasure { get; set; }
        public string? UnitOfMeasureId { get; set; }
        public int? Sublevel { get; set; }
        public string? LineAggregate { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Account? AssetAccountNavigation { get; set; }
        public virtual Class? ClassNavigation { get; set; }
        public virtual Account? CogsaccountNavigation { get; set; }
        public virtual Account? ExpenseAccountNavigation { get; set; }
        public virtual Item? Parent { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual Vendor? PreferredVendorNavigation { get; set; }
        public virtual SalesTaxCode? PurchaseTaxCodeNavigation { get; set; }
        public virtual SalesTaxCode? TaxCodeNavigation { get; set; }
        public virtual SalesTaxItem? TaxVendor { get; set; }
        public virtual UnitOfMeasure? UnitOfMeasureNavigation { get; set; }
        public virtual ICollection<BillLineItem> BillLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<BillLineItem> BillLineItemItems { get; set; }
        public virtual ICollection<BuildAssembly> BuildAssemblies { get; set; }
        public virtual ICollection<BuildAssemblyLineItem> BuildAssemblyLineItemComponentItemLineRetItemRefLists { get; set; }
        public virtual ICollection<BuildAssemblyLineItem> BuildAssemblyLineItemItemInventoryAssemblyRefLists { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItemItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItemItems { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItemItems { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItemItems { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItemItems { get; set; }
        public virtual ICollection<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; }
        public virtual ICollection<Item> InverseParent { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemItems { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItemItems { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItemLineItems { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItemParents { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItemItems { get; set; }
        public virtual ICollection<ItemSite> ItemSiteItemInventoryAssemblyRefLists { get; set; }
        public virtual ICollection<ItemSite> ItemSiteItemInventoryRefLists { get; set; }
        public virtual ICollection<PriceLevelPerItem> PriceLevelPerItems { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItemItems { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItemItems { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItemItems { get; set; }
        public virtual ICollection<StatementCharge> StatementCharges { get; set; }
        public virtual ICollection<TimeTracking> TimeTrackings { get; set; }
        public virtual ICollection<TransferInventoryLineItem> TransferInventoryLineItems { get; set; }
        public virtual ICollection<VehicleMileage> VehicleMileages { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItemItemGroupNavigations { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItemItems { get; set; }
    }
}
