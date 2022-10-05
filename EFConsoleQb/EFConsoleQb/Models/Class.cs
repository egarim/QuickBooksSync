using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Class
    {
        public Class()
        {
            BillExpenseItems = new HashSet<BillExpenseItem>();
            BillLineItems = new HashSet<BillLineItem>();
            CheckExpenseItems = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            CreditCardChargeExpenseItems = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCreditExpenseItems = new HashSet<CreditCardCreditExpenseItem>();
            CreditCardCreditLineItems = new HashSet<CreditCardCreditLineItem>();
            CreditMemoLineItemClassNavigations = new HashSet<CreditMemoLineItem>();
            CreditMemoLineItemItemClassNavigations = new HashSet<CreditMemoLineItem>();
            CreditMemos = new HashSet<CreditMemo>();
            DepositLineItems = new HashSet<DepositLineItem>();
            Employees = new HashSet<Employee>();
            EstimateLineItemClassNavigations = new HashSet<EstimateLineItem>();
            EstimateLineItemItemClassNavigations = new HashSet<EstimateLineItem>();
            Estimates = new HashSet<Estimate>();
            InventoryAdjustmentLineItems = new HashSet<InventoryAdjustmentLineItem>();
            InventoryAdjustments = new HashSet<InventoryAdjustment>();
            InverseParentRefList = new HashSet<Class>();
            InvoiceLineItemClassNavigations = new HashSet<InvoiceLineItem>();
            InvoiceLineItemItemClassNavigations = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            ItemReceiptExpenseItems = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            Items = new HashSet<Item>();
            JournalEntryLines = new HashSet<JournalEntryLine>();
            PurchaseOrderLineItemClassNavigations = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrderLineItemItemClassNavigations = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrderLineItemClassNavigations = new HashSet<SalesOrderLineItem>();
            SalesOrderLineItemItemClassNavigations = new HashSet<SalesOrderLineItem>();
            SalesOrders = new HashSet<SalesOrder>();
            SalesReceiptLineItemClassNavigations = new HashSet<SalesReceiptLineItem>();
            SalesReceiptLineItemItemClassNavigations = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
            SalesTaxItems = new HashSet<SalesTaxItem>();
            StatementCharges = new HashSet<StatementCharge>();
            TimeTrackings = new HashSet<TimeTracking>();
            Transfers = new HashSet<Transfer>();
            VehicleMileages = new HashSet<VehicleMileage>();
            VendorCreditExpenseItems = new HashSet<VendorCreditExpenseItem>();
            VendorCreditLineItems = new HashSet<VendorCreditLineItem>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public bool? IsActive { get; set; }
        public string? ParentRefFullName { get; set; }
        public string? ParentRefListId { get; set; }
        public int? Sublevel { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual Class? ParentRefList { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItems { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItems { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
        public virtual ICollection<CreditCardCreditExpenseItem> CreditCardCreditExpenseItems { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItemClassNavigations { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItemItemClassNavigations { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItems { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItemClassNavigations { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItemItemClassNavigations { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; }
        public virtual ICollection<InventoryAdjustment> InventoryAdjustments { get; set; }
        public virtual ICollection<Class> InverseParentRefList { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemClassNavigations { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemItemClassNavigations { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItems { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItemClassNavigations { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItemItemClassNavigations { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItemClassNavigations { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItemItemClassNavigations { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItemClassNavigations { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItemItemClassNavigations { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
        public virtual ICollection<SalesTaxItem> SalesTaxItems { get; set; }
        public virtual ICollection<StatementCharge> StatementCharges { get; set; }
        public virtual ICollection<TimeTracking> TimeTrackings { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual ICollection<VehicleMileage> VehicleMileages { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItems { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItems { get; set; }
    }
}
