using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CheckExpenseItem
    {
        public string Id { get; set; } = null!;
        public string? CheckId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public string? Account { get; set; }
        public string? AccountId { get; set; }
        public string? Payee { get; set; }
        public string? PayeeId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public string? Memo { get; set; }
        public string? Address { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? Line4 { get; set; }
        public string? Line5 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Note { get; set; }
        public string? CustomFields { get; set; }
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
        public string? ExpenseTaxCode { get; set; }
        public string? ExpenseTaxCodeId { get; set; }
        public string? ExpenseMemo { get; set; }
        public string? ExpenseCustomFields { get; set; }
        public bool? IsToBePrinted { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Check? Check { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Account? ExpenseAccountNavigation { get; set; }
        public virtual Class? ExpenseClassNavigation { get; set; }
        public virtual Customer? ExpenseCustomerNavigation { get; set; }
        public virtual SalesTaxCode? ExpenseTaxCodeNavigation { get; set; }
        public virtual Vendor? PayeeNavigation { get; set; }
    }
}
