﻿using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ItemReceiptLinkedTransaction
    {
        public string Id { get; set; } = null!;
        public string? ItemReceiptId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public DateTime? Date { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public string? Memo { get; set; }
        public decimal? Amount { get; set; }
        public int? TxnNumber { get; set; }
        public float? ExchangeRate { get; set; }
        public string? TransactionId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TransactionReferenceNumber { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionLinkType { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual ItemReceipt? ItemReceipt { get; set; }
        public virtual PurchaseOrder? Transaction { get; set; }
        public virtual Vendor? Vendor { get; set; }
    }
}
