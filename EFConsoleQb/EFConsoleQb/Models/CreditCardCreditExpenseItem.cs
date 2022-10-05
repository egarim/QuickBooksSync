using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CreditCardCreditExpenseItem
    {
        public string Id { get; set; } = null!;
        public string? CccreditId { get; set; }
        public DateTime? Date { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountName { get; set; }
        public string? AccountId { get; set; }
        public string? Memo { get; set; }
        public string? PayeeName { get; set; }
        public string? PayeeId { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? ExpenseLineId { get; set; }
        public string? ExpenseLineNumber { get; set; }
        public string? ExpenseAccount { get; set; }
        public string? ExpenseAccountId { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public string? ExpenseBillableStatus { get; set; }
        public string? ExpenseCustomer { get; set; }
        public string? ExpenseCustomerId { get; set; }
        public string? ExpenseClass { get; set; }
        public string? ExpenseClassId { get; set; }
        public string? ExpenseMemo { get; set; }
        public string? ExpenseTaxCode { get; set; }
        public string? ExpenseTaxCodeId { get; set; }
        public float? ExchangeRate { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? Account { get; set; }
        public virtual CreditCardCredit? Cccredit { get; set; }
        public virtual Account? ExpenseAccountNavigation { get; set; }
        public virtual Class? ExpenseClassNavigation { get; set; }
        public virtual Customer? ExpenseCustomerNavigation { get; set; }
        public virtual SalesTaxCode? ExpenseTaxCodeNavigation { get; set; }
        public virtual Vendor? Payee { get; set; }
    }
}
