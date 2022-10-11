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
    [NavigationItem("Quickbooks Data")]
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
        private String _ReceivePaymentId;
        [Size(300)]
        public String ReceivePaymentId
        {
            get => _ReceivePaymentId;
            set => SetPropertyValue(nameof(ReceivePaymentId), ref _ReceivePaymentId, value);
        }  
        private String _ReferenceNumber;
        [Size(300)]
        public String ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private Int32? _TxnNumber;
        public Int32? TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private Decimal? _UnusedPayment;
        public Decimal? UnusedPayment
        {
            get => _UnusedPayment;
            set => SetPropertyValue(nameof(UnusedPayment), ref _UnusedPayment, value);
        }  
        private Decimal? _Amount;
        public Decimal? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String _AccountsReceivableName;
        [Size(300)]
        public String AccountsReceivableName
        {
            get => _AccountsReceivableName;
            set => SetPropertyValue(nameof(AccountsReceivableName), ref _AccountsReceivableName, value);
        }  
        private String _AccountsReceivableId;
        [Size(300)]
        public String AccountsReceivableId
        {
            get => _AccountsReceivableId;
            set => SetPropertyValue(nameof(AccountsReceivableId), ref _AccountsReceivableId, value);
        }  
        private String _CustomerName;
        [Size(300)]
        public String CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private String _DepositToAccountName;
        [Size(300)]
        public String DepositToAccountName
        {
            get => _DepositToAccountName;
            set => SetPropertyValue(nameof(DepositToAccountName), ref _DepositToAccountName, value);
        }  
        private String _DepositToAccountId;
        [Size(300)]
        public String DepositToAccountId
        {
            get => _DepositToAccountId;
            set => SetPropertyValue(nameof(DepositToAccountId), ref _DepositToAccountId, value);
        }  
        private String _PaymentMethodName;
        [Size(300)]
        public String PaymentMethodName
        {
            get => _PaymentMethodName;
            set => SetPropertyValue(nameof(PaymentMethodName), ref _PaymentMethodName, value);
        }  
        private String _PaymentMethodId;
        [Size(300)]
        public String PaymentMethodId
        {
            get => _PaymentMethodId;
            set => SetPropertyValue(nameof(PaymentMethodId), ref _PaymentMethodId, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private Decimal? _TotalAmountInHomeCurrency;
        public Decimal? TotalAmountInHomeCurrency
        {
            get => _TotalAmountInHomeCurrency;
            set => SetPropertyValue(nameof(TotalAmountInHomeCurrency), ref _TotalAmountInHomeCurrency, value);
        }  
        private String _AutoApply;
        [Size(300)]
        public String AutoApply
        {
            get => _AutoApply;
            set => SetPropertyValue(nameof(AutoApply), ref _AutoApply, value);
        }  
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String _AppliedToRefId;
        [Size(300)]
        public String AppliedToRefId
        {
            get => _AppliedToRefId;
            set => SetPropertyValue(nameof(AppliedToRefId), ref _AppliedToRefId, value);
        }  
        private Decimal? _AppliedToAmount;
        public Decimal? AppliedToAmount
        {
            get => _AppliedToAmount;
            set => SetPropertyValue(nameof(AppliedToAmount), ref _AppliedToAmount, value);
        }  
        private Single? _AppliedToBalanceRemaining;
        public Single? AppliedToBalanceRemaining
        {
            get => _AppliedToBalanceRemaining;
            set => SetPropertyValue(nameof(AppliedToBalanceRemaining), ref _AppliedToBalanceRemaining, value);
        }  
        private Decimal? _AppliedToCreditAppliedAmount;
        public Decimal? AppliedToCreditAppliedAmount
        {
            get => _AppliedToCreditAppliedAmount;
            set => SetPropertyValue(nameof(AppliedToCreditAppliedAmount), ref _AppliedToCreditAppliedAmount, value);
        }  
        private String _AppliedToCreditMemoId;
        [Size(300)]
        public String AppliedToCreditMemoId
        {
            get => _AppliedToCreditMemoId;
            set => SetPropertyValue(nameof(AppliedToCreditMemoId), ref _AppliedToCreditMemoId, value);
        }  
        private String _AppliedToDiscountAccountName;
        [Size(300)]
        public String AppliedToDiscountAccountName
        {
            get => _AppliedToDiscountAccountName;
            set => SetPropertyValue(nameof(AppliedToDiscountAccountName), ref _AppliedToDiscountAccountName, value);
        }  
        private String _AppliedToDiscountAccountId;
        [Size(300)]
        public String AppliedToDiscountAccountId
        {
            get => _AppliedToDiscountAccountId;
            set => SetPropertyValue(nameof(AppliedToDiscountAccountId), ref _AppliedToDiscountAccountId, value);
        }  
        private Decimal? _AppliedToDiscountAmount;
        public Decimal? AppliedToDiscountAmount
        {
            get => _AppliedToDiscountAmount;
            set => SetPropertyValue(nameof(AppliedToDiscountAmount), ref _AppliedToDiscountAmount, value);
        }  
        private Decimal? _AppliedToPaymentAmount;
        public Decimal? AppliedToPaymentAmount
        {
            get => _AppliedToPaymentAmount;
            set => SetPropertyValue(nameof(AppliedToPaymentAmount), ref _AppliedToPaymentAmount, value);
        }  
        private String _AppliedToReferenceNumber;
        [Size(300)]
        public String AppliedToReferenceNumber
        {
            get => _AppliedToReferenceNumber;
            set => SetPropertyValue(nameof(AppliedToReferenceNumber), ref _AppliedToReferenceNumber, value);
        }  
        private DateTime? _AppliedToTxnDate;
        public DateTime? AppliedToTxnDate
        {
            get => _AppliedToTxnDate;
            set => SetPropertyValue(nameof(AppliedToTxnDate), ref _AppliedToTxnDate, value);
        }  
        private String _AppliedToTxnType;
        [Size(300)]
        public String AppliedToTxnType
        {
            get => _AppliedToTxnType;
            set => SetPropertyValue(nameof(AppliedToTxnType), ref _AppliedToTxnType, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }
        public const string QueryableProperties="Id,ReceivePaymentId,ReferenceNumber,TxnNumber,Date,UnusedPayment,Amount,AccountsReceivableName,AccountsReceivableId,CustomerName,CustomerId,DepositToAccountName,DepositToAccountId,PaymentMethodName,PaymentMethodId,Memo,ExchangeRate,TotalAmountInHomeCurrency,AutoApply,CustomFields,AppliedToRefId,AppliedToAmount,AppliedToBalanceRemaining,AppliedToCreditAppliedAmount,AppliedToCreditMemoId,AppliedToDiscountAccountName,AppliedToDiscountAccountId,AppliedToDiscountAmount,AppliedToPaymentAmount,AppliedToReferenceNumber,AppliedToTxnDate,AppliedToTxnType,TimeModified,TimeCreated";
        public const string QuickbooksTableName="ReceivePaymentsAppliedTo";
    }
}