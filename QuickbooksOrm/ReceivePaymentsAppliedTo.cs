using BitFwks.Scheduler.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QuickBooksSync.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ReceivePaymentsAppliedTo : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ReceivePaymentsAppliedTo(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
         
        private string _Id;
        [Key(false)]
        public string Id
        {
            get => _Id;
            set => SetPropertyValue(nameof(Id), ref _Id, value);
        }  
        private String? _ReceivePaymentId;
        public String? ReceivePaymentId
        {
            get => _ReceivePaymentId;
            set => SetPropertyValue(nameof(ReceivePaymentId), ref _ReceivePaymentId, value);
        }  
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private Decimal _UnusedPayment;
        public Decimal UnusedPayment
        {
            get => _UnusedPayment;
            set => SetPropertyValue(nameof(UnusedPayment), ref _UnusedPayment, value);
        }  
        private Decimal _Amount;
        public Decimal Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String? _AccountsReceivableName;
        public String? AccountsReceivableName
        {
            get => _AccountsReceivableName;
            set => SetPropertyValue(nameof(AccountsReceivableName), ref _AccountsReceivableName, value);
        }  
        private String? _AccountsReceivableId;
        public String? AccountsReceivableId
        {
            get => _AccountsReceivableId;
            set => SetPropertyValue(nameof(AccountsReceivableId), ref _AccountsReceivableId, value);
        }  
        private String? _CustomerName;
        public String? CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String? _CustomerId;
        public String? CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private String? _DepositToAccountName;
        public String? DepositToAccountName
        {
            get => _DepositToAccountName;
            set => SetPropertyValue(nameof(DepositToAccountName), ref _DepositToAccountName, value);
        }  
        private String? _DepositToAccountId;
        public String? DepositToAccountId
        {
            get => _DepositToAccountId;
            set => SetPropertyValue(nameof(DepositToAccountId), ref _DepositToAccountId, value);
        }  
        private String? _PaymentMethodName;
        public String? PaymentMethodName
        {
            get => _PaymentMethodName;
            set => SetPropertyValue(nameof(PaymentMethodName), ref _PaymentMethodName, value);
        }  
        private String? _PaymentMethodId;
        public String? PaymentMethodId
        {
            get => _PaymentMethodId;
            set => SetPropertyValue(nameof(PaymentMethodId), ref _PaymentMethodId, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Single _ExchangeRate;
        public Single ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private Decimal _TotalAmountInHomeCurrency;
        public Decimal TotalAmountInHomeCurrency
        {
            get => _TotalAmountInHomeCurrency;
            set => SetPropertyValue(nameof(TotalAmountInHomeCurrency), ref _TotalAmountInHomeCurrency, value);
        }  
        private String? _AutoApply;
        public String? AutoApply
        {
            get => _AutoApply;
            set => SetPropertyValue(nameof(AutoApply), ref _AutoApply, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String? _AppliedToRefId;
        public String? AppliedToRefId
        {
            get => _AppliedToRefId;
            set => SetPropertyValue(nameof(AppliedToRefId), ref _AppliedToRefId, value);
        }  
        private Decimal _AppliedToAmount;
        public Decimal AppliedToAmount
        {
            get => _AppliedToAmount;
            set => SetPropertyValue(nameof(AppliedToAmount), ref _AppliedToAmount, value);
        }  
        private Single _AppliedToBalanceRemaining;
        public Single AppliedToBalanceRemaining
        {
            get => _AppliedToBalanceRemaining;
            set => SetPropertyValue(nameof(AppliedToBalanceRemaining), ref _AppliedToBalanceRemaining, value);
        }  
        private Decimal _AppliedToCreditAppliedAmount;
        public Decimal AppliedToCreditAppliedAmount
        {
            get => _AppliedToCreditAppliedAmount;
            set => SetPropertyValue(nameof(AppliedToCreditAppliedAmount), ref _AppliedToCreditAppliedAmount, value);
        }  
        private String? _AppliedToCreditMemoId;
        public String? AppliedToCreditMemoId
        {
            get => _AppliedToCreditMemoId;
            set => SetPropertyValue(nameof(AppliedToCreditMemoId), ref _AppliedToCreditMemoId, value);
        }  
        private String? _AppliedToDiscountAccountName;
        public String? AppliedToDiscountAccountName
        {
            get => _AppliedToDiscountAccountName;
            set => SetPropertyValue(nameof(AppliedToDiscountAccountName), ref _AppliedToDiscountAccountName, value);
        }  
        private String? _AppliedToDiscountAccountId;
        public String? AppliedToDiscountAccountId
        {
            get => _AppliedToDiscountAccountId;
            set => SetPropertyValue(nameof(AppliedToDiscountAccountId), ref _AppliedToDiscountAccountId, value);
        }  
        private Decimal _AppliedToDiscountAmount;
        public Decimal AppliedToDiscountAmount
        {
            get => _AppliedToDiscountAmount;
            set => SetPropertyValue(nameof(AppliedToDiscountAmount), ref _AppliedToDiscountAmount, value);
        }  
        private Decimal _AppliedToPaymentAmount;
        public Decimal AppliedToPaymentAmount
        {
            get => _AppliedToPaymentAmount;
            set => SetPropertyValue(nameof(AppliedToPaymentAmount), ref _AppliedToPaymentAmount, value);
        }  
        private String? _AppliedToReferenceNumber;
        public String? AppliedToReferenceNumber
        {
            get => _AppliedToReferenceNumber;
            set => SetPropertyValue(nameof(AppliedToReferenceNumber), ref _AppliedToReferenceNumber, value);
        }  
        private DateTime _AppliedToTxnDate;
        public DateTime AppliedToTxnDate
        {
            get => _AppliedToTxnDate;
            set => SetPropertyValue(nameof(AppliedToTxnDate), ref _AppliedToTxnDate, value);
        }  
        private String? _AppliedToTxnType;
        public String? AppliedToTxnType
        {
            get => _AppliedToTxnType;
            set => SetPropertyValue(nameof(AppliedToTxnType), ref _AppliedToTxnType, value);
        }  
        private DateTime _TimeModified;
        public DateTime TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private DateTime _TimeCreated;
        public DateTime TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private string _AccountsReceivable;
        public string AccountsReceivable
        {
            get => _AccountsReceivable;
            set => SetPropertyValue(nameof(AccountsReceivable), ref _AccountsReceivable, value);
        }  
        private string _AppliedToCreditMemo;
        public string AppliedToCreditMemo
        {
            get => _AppliedToCreditMemo;
            set => SetPropertyValue(nameof(AppliedToCreditMemo), ref _AppliedToCreditMemo, value);
        }  
        private string _AppliedToDiscountAccount;
        public string AppliedToDiscountAccount
        {
            get => _AppliedToDiscountAccount;
            set => SetPropertyValue(nameof(AppliedToDiscountAccount), ref _AppliedToDiscountAccount, value);
        }  
        private string _Customer;
        public string Customer
        {
            get => _Customer;
            set => SetPropertyValue(nameof(Customer), ref _Customer, value);
        }  
        private string _DepositToAccount;
        public string DepositToAccount
        {
            get => _DepositToAccount;
            set => SetPropertyValue(nameof(DepositToAccount), ref _DepositToAccount, value);
        }  
        private string _PaymentMethod;
        public string PaymentMethod
        {
            get => _PaymentMethod;
            set => SetPropertyValue(nameof(PaymentMethod), ref _PaymentMethod, value);
        }  
        private string _ReceivePayment;
        public string ReceivePayment
        {
            get => _ReceivePayment;
            set => SetPropertyValue(nameof(ReceivePayment), ref _ReceivePayment, value);
        }
        public const string QueriableProperties="Id,ReceivePaymentId,ReferenceNumber,TxnNumber,Date,UnusedPayment,Amount,AccountsReceivableName,AccountsReceivableId,CustomerName,CustomerId,DepositToAccountName,DepositToAccountId,PaymentMethodName,PaymentMethodId,Memo,ExchangeRate,TotalAmountInHomeCurrency,AutoApply,CustomFields,AppliedToRefId,AppliedToAmount,AppliedToBalanceRemaining,AppliedToCreditAppliedAmount,AppliedToCreditMemoId,AppliedToDiscountAccountName,AppliedToDiscountAccountId,AppliedToDiscountAmount,AppliedToPaymentAmount,AppliedToReferenceNumber,AppliedToTxnDate,AppliedToTxnType,TimeModified,TimeCreated,AccountsReceivable,AppliedToCreditMemo,AppliedToDiscountAccount,Customer,DepositToAccount,PaymentMethod,ReceivePayment";
    }
}