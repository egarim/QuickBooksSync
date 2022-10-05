using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class SalesTaxItem
    {
        public SalesTaxItem()
        {
            CreditMemoLineItemItemTaxCodeNavigations = new HashSet<CreditMemoLineItem>();
            CreditMemoLineItemTaxItemNavigations = new HashSet<CreditMemoLineItem>();
            CreditMemos = new HashSet<CreditMemo>();
            Customers = new HashSet<Customer>();
            EstimateLineItems = new HashSet<EstimateLineItem>();
            Estimates = new HashSet<Estimate>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            Items = new HashSet<Item>();
            JournalEntryLines = new HashSet<JournalEntryLine>();
            Preferences = new HashSet<Preference>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesOrders = new HashSet<SalesOrder>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
            SalesTaxCodes = new HashSet<SalesTaxCode>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? ClassRefFullName { get; set; }
        public string? ClassRefListId { get; set; }
        public string? ItemDesc { get; set; }
        public float? TaxRate { get; set; }
        public string? TaxVendorRefFullName { get; set; }
        public string? TaxVendorRefListId { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? ClassRefList { get; set; }
        public virtual Vendor? TaxVendorRefList { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItemItemTaxCodeNavigations { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItemTaxItemNavigations { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
        public virtual ICollection<SalesTaxCode> SalesTaxCodes { get; set; }
    }
}
