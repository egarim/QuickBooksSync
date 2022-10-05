using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class SalesTaxCode
    {
        public SalesTaxCode()
        {
            BillExpenseItems = new HashSet<BillExpenseItem>();
            BillLineItems = new HashSet<BillLineItem>();
            CheckExpenseItems = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            CreditCardChargeExpenseItems = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCreditExpenseItems = new HashSet<CreditCardCreditExpenseItem>();
            CreditCardCreditLineItems = new HashSet<CreditCardCreditLineItem>();
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            CreditMemos = new HashSet<CreditMemo>();
            Customers = new HashSet<Customer>();
            EstimateLineItemCustomerSalesTaxes = new HashSet<EstimateLineItem>();
            EstimateLineItemItemTaxCodeNavigations = new HashSet<EstimateLineItem>();
            Estimates = new HashSet<Estimate>();
            InvoiceLineItemCustomerTaxCodeNavigations = new HashSet<InvoiceLineItem>();
            InvoiceLineItemItemTaxCodeNavigations = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            ItemLineItems = new HashSet<ItemLineItem>();
            ItemPurchaseTaxCodeNavigations = new HashSet<Item>();
            ItemReceiptExpenseItems = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            ItemTaxCodeNavigations = new HashSet<Item>();
            PreferenceSalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefLists = new HashSet<Preference>();
            PreferenceSalesTaxPreferencesDefaultTaxableSalesTaxCodeRefLists = new HashSet<Preference>();
            PurchaseOrderLineItems = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrderLineItemCustomerTaxCodeNavigations = new HashSet<SalesOrderLineItem>();
            SalesOrderLineItemItemTaxCodeNavigations = new HashSet<SalesOrderLineItem>();
            SalesOrders = new HashSet<SalesOrder>();
            SalesReceiptLineItemCustomerTaxCodeNavigations = new HashSet<SalesReceiptLineItem>();
            SalesReceiptLineItemItemTaxCodeNavigations = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
            VendorCreditExpenseItemExpenseTaxCodeNavigations = new HashSet<VendorCreditExpenseItem>();
            VendorCreditExpenseItemTaxCodeNavigations = new HashSet<VendorCreditExpenseItem>();
            VendorCreditLineItemItemTaxCodeNavigations = new HashSet<VendorCreditLineItem>();
            VendorCreditLineItemTaxCodeNavigations = new HashSet<VendorCreditLineItem>();
            VendorCredits = new HashSet<VendorCredit>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxable { get; set; }
        public string? ItemPurchaseTaxRefFullName { get; set; }
        public string? ItemPurchaseTaxRefListId { get; set; }
        public string? ItemSalesTaxRefFullName { get; set; }
        public string? ItemSalesTaxRefListId { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual SalesTaxItem? ItemSalesTaxRefList { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItems { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItems { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
        public virtual ICollection<CreditCardCreditExpenseItem> CreditCardCreditExpenseItems { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItemCustomerSalesTaxes { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItemItemTaxCodeNavigations { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemCustomerTaxCodeNavigations { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemItemTaxCodeNavigations { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItems { get; set; }
        public virtual ICollection<Item> ItemPurchaseTaxCodeNavigations { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItems { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<Item> ItemTaxCodeNavigations { get; set; }
        public virtual ICollection<Preference> PreferenceSalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefLists { get; set; }
        public virtual ICollection<Preference> PreferenceSalesTaxPreferencesDefaultTaxableSalesTaxCodeRefLists { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItemCustomerTaxCodeNavigations { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItemItemTaxCodeNavigations { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItemCustomerTaxCodeNavigations { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItemItemTaxCodeNavigations { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItemExpenseTaxCodeNavigations { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItemTaxCodeNavigations { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItemItemTaxCodeNavigations { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItemTaxCodeNavigations { get; set; }
        public virtual ICollection<VendorCredit> VendorCredits { get; set; }
    }
}
