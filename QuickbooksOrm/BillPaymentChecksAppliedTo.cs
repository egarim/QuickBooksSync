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
    public class BillPaymentChecksAppliedTo : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public BillPaymentChecksAppliedTo(Session session)
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
        private String _BillPaymentId;
        [Size(300)]
        public String BillPaymentId
        {
            get => _BillPaymentId;
            set => SetPropertyValue(nameof(BillPaymentId), ref _BillPaymentId, value);
        }  
        private String _PayeeName;
        [Size(300)]
        public String PayeeName
        {
            get => _PayeeName;
            set => SetPropertyValue(nameof(PayeeName), ref _PayeeName, value);
        }  
        private String _PayeeId;
        [Size(300)]
        public String PayeeId
        {
            get => _PayeeId;
            set => SetPropertyValue(nameof(PayeeId), ref _PayeeId, value);
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
        private String _AccountsPayable;
        [Size(300)]
        public String AccountsPayable
        {
            get => _AccountsPayable;
            set => SetPropertyValue(nameof(AccountsPayable), ref _AccountsPayable, value);
        }  
        private String _AccountsPayableId;
        [Size(300)]
        public String AccountsPayableId
        {
            get => _AccountsPayableId;
            set => SetPropertyValue(nameof(AccountsPayableId), ref _AccountsPayableId, value);
        }  
        private String _BankAccountId;
        [Size(300)]
        public String BankAccountId
        {
            get => _BankAccountId;
            set => SetPropertyValue(nameof(BankAccountId), ref _BankAccountId, value);
        }  
        private String _BankAccountName;
        [Size(300)]
        public String BankAccountName
        {
            get => _BankAccountName;
            set => SetPropertyValue(nameof(BankAccountName), ref _BankAccountName, value);
        }  
        private Boolean? _IsToBePrinted;
        public Boolean? IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
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
        private Single? _AmountInHomeCurrency;
        public Single? AmountInHomeCurrency
        {
            get => _AmountInHomeCurrency;
            set => SetPropertyValue(nameof(AmountInHomeCurrency), ref _AmountInHomeCurrency, value);
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
        private Decimal? _AppliedToBalanceRemaining;
        public Decimal? AppliedToBalanceRemaining
        {
            get => _AppliedToBalanceRemaining;
            set => SetPropertyValue(nameof(AppliedToBalanceRemaining), ref _AppliedToBalanceRemaining, value);
        }  
        private Decimal? _AppliedToCreditAmount;
        public Decimal? AppliedToCreditAmount
        {
            get => _AppliedToCreditAmount;
            set => SetPropertyValue(nameof(AppliedToCreditAmount), ref _AppliedToCreditAmount, value);
        }  
        private String _AppliedToCreditMemoId;
        [Size(300)]
        public String AppliedToCreditMemoId
        {
            get => _AppliedToCreditMemoId;
            set => SetPropertyValue(nameof(AppliedToCreditMemoId), ref _AppliedToCreditMemoId, value);
        }  
        private String _AppliedToDiscountAccountId;
        [Size(300)]
        public String AppliedToDiscountAccountId
        {
            get => _AppliedToDiscountAccountId;
            set => SetPropertyValue(nameof(AppliedToDiscountAccountId), ref _AppliedToDiscountAccountId, value);
        }  
        private String _AppliedToDiscountAccountName;
        [Size(300)]
        public String AppliedToDiscountAccountName
        {
            get => _AppliedToDiscountAccountName;
            set => SetPropertyValue(nameof(AppliedToDiscountAccountName), ref _AppliedToDiscountAccountName, value);
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
        public const string QueryableProperties="Id,BillPaymentId,PayeeName,PayeeId,ReferenceNumber,TxnNumber,Date,AccountsPayable,AccountsPayableId,BankAccountId,BankAccountName,IsToBePrinted,Memo,ExchangeRate,AmountInHomeCurrency,CustomFields,AppliedToRefId,AppliedToAmount,AppliedToBalanceRemaining,AppliedToCreditAmount,AppliedToCreditMemoId,AppliedToDiscountAccountId,AppliedToDiscountAccountName,AppliedToDiscountAmount,AppliedToPaymentAmount,AppliedToReferenceNumber,AppliedToTxnDate,AppliedToTxnType,TimeModified,TimeCreated";
        public const string QuickbooksTableName="BillPaymentChecksAppliedTo";
    }
}