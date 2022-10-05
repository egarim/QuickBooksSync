using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class SalesRep
    {
        public SalesRep()
        {
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            CreditMemos = new HashSet<CreditMemo>();
            Customers = new HashSet<Customer>();
            EstimateLineItems = new HashSet<EstimateLineItem>();
            Estimates = new HashSet<Estimate>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesOrders = new HashSet<SalesOrder>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
        }

        public string Id { get; set; } = null!;
        public string? Initial { get; set; }
        public bool? IsActive { get; set; }
        public string? SalesRepEntityRefFullName { get; set; }
        public string? SalesRepEntityRefListId { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
    }
}
