using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Account
    {
        public Account()
        {
            BillExpenseItemAccountsPayableNavigations = new HashSet<BillExpenseItem>();
            BillExpenseItemExpenseAccountNavigations = new HashSet<BillExpenseItem>();
            BillLineItems = new HashSet<BillLineItem>();
            BillPaymentCheckAccountsPayableNavigations = new HashSet<BillPaymentCheck>();
            BillPaymentCheckBankAccounts = new HashSet<BillPaymentCheck>();
            BillPaymentCreditCards = new HashSet<BillPaymentCreditCard>();
            BillPaymentCreditCardsAppliedToAccountsPayableNavigations = new HashSet<BillPaymentCreditCardsAppliedTo>();
            BillPaymentCreditCardsAppliedToAppliedToDiscountAccounts = new HashSet<BillPaymentCreditCardsAppliedTo>();
            Bills = new HashSet<Bill>();
            CheckExpenseItemAccountNavigations = new HashSet<CheckExpenseItem>();
            CheckExpenseItemExpenseAccountNavigations = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            Checks = new HashSet<Check>();
            CreditCardChargeExpenseItemAccounts = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeExpenseItemExpenseAccountNavigations = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCharges = new HashSet<CreditCardCharge>();
            CreditCardCreditExpenseItemAccounts = new HashSet<CreditCardCreditExpenseItem>();
            CreditCardCreditExpenseItemExpenseAccountNavigations = new HashSet<CreditCardCreditExpenseItem>();
            CreditCardCreditLineItems = new HashSet<CreditCardCreditLineItem>();
            CreditCardCredits = new HashSet<CreditCardCredit>();
            CreditCardRefundAraccountRefLists = new HashSet<CreditCardRefund>();
            CreditCardRefundRefundFromAccountRefLists = new HashSet<CreditCardRefund>();
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            CreditMemos = new HashSet<CreditMemo>();
            DepositCashBackAccountNavigations = new HashSet<Deposit>();
            DepositDepositToAccountNavigations = new HashSet<Deposit>();
            DepositLineItemCashBackAccountNavigations = new HashSet<DepositLineItem>();
            DepositLineItemDepositToAccountNavigations = new HashSet<DepositLineItem>();
            DepositLineItemItemAccountNavigations = new HashSet<DepositLineItem>();
            InventoryAdjustmentLineItems = new HashSet<InventoryAdjustmentLineItem>();
            InventoryAdjustments = new HashSet<InventoryAdjustment>();
            InverseParent = new HashSet<Account>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            InvoiceLinkedTransactions = new HashSet<InvoiceLinkedTransaction>();
            Invoices = new HashSet<Invoice>();
            ItemAccountNavigations = new HashSet<Item>();
            ItemAssetAccountNavigations = new HashSet<Item>();
            ItemCogsaccountNavigations = new HashSet<Item>();
            ItemExpenseAccountNavigations = new HashSet<Item>();
            ItemLineItemAccountNavigations = new HashSet<ItemLineItem>();
            ItemLineItemAssetAccountNavigations = new HashSet<ItemLineItem>();
            ItemLineItemCogsaccountNavigations = new HashSet<ItemLineItem>();
            ItemReceiptExpenseItemAccountsPayableNavigations = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptExpenseItemExpenseAccountNavigations = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            ItemReceiptLinkedTransactions = new HashSet<ItemReceiptLinkedTransaction>();
            ItemReceipts = new HashSet<ItemReceipt>();
            JournalEntryLines = new HashSet<JournalEntryLine>();
            PayrollNonWageItemExpenseAccountRefLists = new HashSet<PayrollNonWageItem>();
            PayrollNonWageItemLiabilityAccountRefLists = new HashSet<PayrollNonWageItem>();
            PayrollWageItems = new HashSet<PayrollWageItem>();
            PreferenceFinanceChargePreferencesFinanceChargeAccountRefLists = new HashSet<Preference>();
            PreferencePurchasesAndVendorsPreferencesDefaultDiscountAccountRefLists = new HashSet<Preference>();
            ReceivePaymentAccountsReceivables = new HashSet<ReceivePayment>();
            ReceivePaymentDepositToAccounts = new HashSet<ReceivePayment>();
            ReceivePaymentsAppliedToAccountsReceivables = new HashSet<ReceivePaymentsAppliedTo>();
            ReceivePaymentsAppliedToAppliedToDiscountAccounts = new HashSet<ReceivePaymentsAppliedTo>();
            ReceivePaymentsAppliedToDepositToAccounts = new HashSet<ReceivePaymentsAppliedTo>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
            StatementCharges = new HashSet<StatementCharge>();
            Transactions = new HashSet<Transaction>();
            TransferTransferFromAccountRefLists = new HashSet<Transfer>();
            TransferTransferToAccountRefLists = new HashSet<Transfer>();
            VendorCreditExpenseItemAccountsPayableNavigations = new HashSet<VendorCreditExpenseItem>();
            VendorCreditExpenseItemExpenseAccountNavigations = new HashSet<VendorCreditExpenseItem>();
            VendorCreditLineItems = new HashSet<VendorCreditLineItem>();
            VendorCredits = new HashSet<VendorCredit>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? Type { get; set; }
        public string? SpecialType { get; set; }
        public string? Number { get; set; }
        public float? Balance { get; set; }
        public float? AccountBalance { get; set; }
        public string? BankAccount { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public string? ParentName { get; set; }
        public string? ParentId { get; set; }
        public int? Sublevel { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public string? CashFlowClassification { get; set; }
        public string? TaxLineName { get; set; }
        public string? TaxLineId { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual Account? Parent { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItemAccountsPayableNavigations { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<BillPaymentCheck> BillPaymentCheckAccountsPayableNavigations { get; set; }
        public virtual ICollection<BillPaymentCheck> BillPaymentCheckBankAccounts { get; set; }
        public virtual ICollection<BillPaymentCreditCard> BillPaymentCreditCards { get; set; }
        public virtual ICollection<BillPaymentCreditCardsAppliedTo> BillPaymentCreditCardsAppliedToAccountsPayableNavigations { get; set; }
        public virtual ICollection<BillPaymentCreditCardsAppliedTo> BillPaymentCreditCardsAppliedToAppliedToDiscountAccounts { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItemAccountNavigations { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItemAccounts { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
        public virtual ICollection<CreditCardCharge> CreditCardCharges { get; set; }
        public virtual ICollection<CreditCardCreditExpenseItem> CreditCardCreditExpenseItemAccounts { get; set; }
        public virtual ICollection<CreditCardCreditExpenseItem> CreditCardCreditExpenseItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; }
        public virtual ICollection<CreditCardCredit> CreditCardCredits { get; set; }
        public virtual ICollection<CreditCardRefund> CreditCardRefundAraccountRefLists { get; set; }
        public virtual ICollection<CreditCardRefund> CreditCardRefundRefundFromAccountRefLists { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<Deposit> DepositCashBackAccountNavigations { get; set; }
        public virtual ICollection<Deposit> DepositDepositToAccountNavigations { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItemCashBackAccountNavigations { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItemDepositToAccountNavigations { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItemItemAccountNavigations { get; set; }
        public virtual ICollection<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; }
        public virtual ICollection<InventoryAdjustment> InventoryAdjustments { get; set; }
        public virtual ICollection<Account> InverseParent { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<InvoiceLinkedTransaction> InvoiceLinkedTransactions { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Item> ItemAccountNavigations { get; set; }
        public virtual ICollection<Item> ItemAssetAccountNavigations { get; set; }
        public virtual ICollection<Item> ItemCogsaccountNavigations { get; set; }
        public virtual ICollection<Item> ItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItemAccountNavigations { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItemAssetAccountNavigations { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItemCogsaccountNavigations { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItemAccountsPayableNavigations { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<ItemReceiptLinkedTransaction> ItemReceiptLinkedTransactions { get; set; }
        public virtual ICollection<ItemReceipt> ItemReceipts { get; set; }
        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; }
        public virtual ICollection<PayrollNonWageItem> PayrollNonWageItemExpenseAccountRefLists { get; set; }
        public virtual ICollection<PayrollNonWageItem> PayrollNonWageItemLiabilityAccountRefLists { get; set; }
        public virtual ICollection<PayrollWageItem> PayrollWageItems { get; set; }
        public virtual ICollection<Preference> PreferenceFinanceChargePreferencesFinanceChargeAccountRefLists { get; set; }
        public virtual ICollection<Preference> PreferencePurchasesAndVendorsPreferencesDefaultDiscountAccountRefLists { get; set; }
        public virtual ICollection<ReceivePayment> ReceivePaymentAccountsReceivables { get; set; }
        public virtual ICollection<ReceivePayment> ReceivePaymentDepositToAccounts { get; set; }
        public virtual ICollection<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedToAccountsReceivables { get; set; }
        public virtual ICollection<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedToAppliedToDiscountAccounts { get; set; }
        public virtual ICollection<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedToDepositToAccounts { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
        public virtual ICollection<StatementCharge> StatementCharges { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transfer> TransferTransferFromAccountRefLists { get; set; }
        public virtual ICollection<Transfer> TransferTransferToAccountRefLists { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItemAccountsPayableNavigations { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItemExpenseAccountNavigations { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItems { get; set; }
        public virtual ICollection<VendorCredit> VendorCredits { get; set; }
    }
}
