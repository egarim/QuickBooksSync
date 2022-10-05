using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            CreditCardRefunds = new HashSet<CreditCardRefund>();
            Customers = new HashSet<Customer>();
            DepositLineItems = new HashSet<DepositLineItem>();
            Items = new HashSet<Item>();
            ReceivePayments = new HashSet<ReceivePayment>();
            ReceivePaymentsAppliedTos = new HashSet<ReceivePaymentsAppliedTo>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? PaymentMethodType { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual ICollection<CreditCardRefund> CreditCardRefunds { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItems { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<ReceivePayment> ReceivePayments { get; set; }
        public virtual ICollection<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedTos { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
    }
}
