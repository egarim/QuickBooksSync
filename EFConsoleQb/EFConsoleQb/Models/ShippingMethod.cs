using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            CreditMemos = new HashSet<CreditMemo>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            Preferences = new HashSet<Preference>();
            PurchaseOrderLineItems = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesOrders = new HashSet<SalesOrder>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
    }
}
