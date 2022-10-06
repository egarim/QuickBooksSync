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
    public class ReceivePayment : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ReceivePayment(Session session)
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
        private String? _AppliedToAggregate;
        public String? AppliedToAggregate
        {
            get => _AppliedToAggregate;
            set => SetPropertyValue(nameof(AppliedToAggregate), ref _AppliedToAggregate, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        public const string QueriableProperties="Id,ReferenceNumber,TxnNumber,Date,UnusedPayment,Amount,AccountsReceivableName,AccountsReceivableId,CustomerName,CustomerId,DepositToAccountName,DepositToAccountId,PaymentMethodName,PaymentMethodId,Memo,ExchangeRate,TotalAmountInHomeCurrency,AppliedToAggregate,CustomFields,TimeModified,TimeCreated,AccountsReceivable,Customer,DepositToAccount,PaymentMethod";
    }
}