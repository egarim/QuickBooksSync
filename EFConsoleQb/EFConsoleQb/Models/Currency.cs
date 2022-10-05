using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Accounts = new HashSet<Account>();
            BillLineItems = new HashSet<BillLineItem>();
            Bills = new HashSet<Bill>();
            CheckExpenseItems = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            Checks = new HashSet<Check>();
            Customers = new HashSet<Customer>();
            DepositLineItems = new HashSet<DepositLineItem>();
            Deposits = new HashSet<Deposit>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            JournalEntries = new HashSet<JournalEntry>();
            JournalEntryLines = new HashSet<JournalEntryLine>();
            Preferences = new HashSet<Preference>();
            PriceLevelPerItems = new HashSet<PriceLevelPerItem>();
            PriceLevels = new HashSet<PriceLevel>();
            PurchaseOrderLineItems = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            ReceivePaymentToDeposits = new HashSet<ReceivePaymentToDeposit>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesOrders = new HashSet<SalesOrder>();
            Transactions = new HashSet<Transaction>();
            Vendors = new HashSet<Vendor>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyFormatThousandSeparator { get; set; }
        public string? CurrencyFormatThousandSeparatorGrouping { get; set; }
        public string? CurrencyFormatDecimalPlaces { get; set; }
        public string? CurrencyFormatDecimalSeparator { get; set; }
        public bool? IsUserDefinedCurrency { get; set; }
        public float? ExchangeRate { get; set; }
        public DateTime? AsOfDate { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItems { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItems { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
        public virtual ICollection<PriceLevelPerItem> PriceLevelPerItems { get; set; }
        public virtual ICollection<PriceLevel> PriceLevels { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<ReceivePaymentToDeposit> ReceivePaymentToDeposits { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
