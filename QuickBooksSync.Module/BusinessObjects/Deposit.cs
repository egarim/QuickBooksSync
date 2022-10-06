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
    public class Deposit : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Deposit(Session session)
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
        private String? _CashBackAccount;
        public String? CashBackAccount
        {
            get => _CashBackAccount;
            set => SetPropertyValue(nameof(CashBackAccount), ref _CashBackAccount, value);
        }  
        private String? _CashBackAccountId;
        public String? CashBackAccountId
        {
            get => _CashBackAccountId;
            set => SetPropertyValue(nameof(CashBackAccountId), ref _CashBackAccountId, value);
        }  
        private Decimal _CashBackAmount;
        public Decimal CashBackAmount
        {
            get => _CashBackAmount;
            set => SetPropertyValue(nameof(CashBackAmount), ref _CashBackAmount, value);
        }  
        private String? _CashBackId;
        public String? CashBackId
        {
            get => _CashBackId;
            set => SetPropertyValue(nameof(CashBackId), ref _CashBackId, value);
        }  
        private String? _CashBackMemo;
        public String? CashBackMemo
        {
            get => _CashBackMemo;
            set => SetPropertyValue(nameof(CashBackMemo), ref _CashBackMemo, value);
        }  
        private String? _DepositToAccount;
        public String? DepositToAccount
        {
            get => _DepositToAccount;
            set => SetPropertyValue(nameof(DepositToAccount), ref _DepositToAccount, value);
        }  
        private String? _DepositToAccountId;
        public String? DepositToAccountId
        {
            get => _DepositToAccountId;
            set => SetPropertyValue(nameof(DepositToAccountId), ref _DepositToAccountId, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Single _TotalDeposit;
        public Single TotalDeposit
        {
            get => _TotalDeposit;
            set => SetPropertyValue(nameof(TotalDeposit), ref _TotalDeposit, value);
        }  
        private Int32 _ItemCount;
        public Int32 ItemCount
        {
            get => _ItemCount;
            set => SetPropertyValue(nameof(ItemCount), ref _ItemCount, value);
        }  
        private String? _ItemAggregate;
        public String? ItemAggregate
        {
            get => _ItemAggregate;
            set => SetPropertyValue(nameof(ItemAggregate), ref _ItemAggregate, value);
        }  
        private String? _CurrencyName;
        public String? CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private String? _CurrencyId;
        public String? CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private Single _ExchangeRate;
        public Single ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
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
        private String? _Payee;
        public String? Payee
        {
            get => _Payee;
            set => SetPropertyValue(nameof(Payee), ref _Payee, value);
        }  
        private String? _PayeeId;
        public String? PayeeId
        {
            get => _PayeeId;
            set => SetPropertyValue(nameof(PayeeId), ref _PayeeId, value);
        }  
        private string _CashBackAccountNavigation;
        public string CashBackAccountNavigation
        {
            get => _CashBackAccountNavigation;
            set => SetPropertyValue(nameof(CashBackAccountNavigation), ref _CashBackAccountNavigation, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }  
        private string _DepositToAccountNavigation;
        public string DepositToAccountNavigation
        {
            get => _DepositToAccountNavigation;
            set => SetPropertyValue(nameof(DepositToAccountNavigation), ref _DepositToAccountNavigation, value);
        }  
        private string _PayeeNavigation;
        public string PayeeNavigation
        {
            get => _PayeeNavigation;
            set => SetPropertyValue(nameof(PayeeNavigation), ref _PayeeNavigation, value);
        }
       
    }
}