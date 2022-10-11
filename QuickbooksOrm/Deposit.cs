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
        private String _CashBackAccount;
        [Size(300)]
        public String CashBackAccount
        {
            get => _CashBackAccount;
            set => SetPropertyValue(nameof(CashBackAccount), ref _CashBackAccount, value);
        }  
        private String _CashBackAccountId;
        [Size(300)]
        public String CashBackAccountId
        {
            get => _CashBackAccountId;
            set => SetPropertyValue(nameof(CashBackAccountId), ref _CashBackAccountId, value);
        }  
        private Decimal? _CashBackAmount;
        public Decimal? CashBackAmount
        {
            get => _CashBackAmount;
            set => SetPropertyValue(nameof(CashBackAmount), ref _CashBackAmount, value);
        }  
        private String _CashBackId;
        [Size(300)]
        public String CashBackId
        {
            get => _CashBackId;
            set => SetPropertyValue(nameof(CashBackId), ref _CashBackId, value);
        }  
        private String _CashBackMemo;
        [Size(300)]
        public String CashBackMemo
        {
            get => _CashBackMemo;
            set => SetPropertyValue(nameof(CashBackMemo), ref _CashBackMemo, value);
        }  
        private String _DepositToAccount;
        [Size(300)]
        public String DepositToAccount
        {
            get => _DepositToAccount;
            set => SetPropertyValue(nameof(DepositToAccount), ref _DepositToAccount, value);
        }  
        private String _DepositToAccountId;
        [Size(300)]
        public String DepositToAccountId
        {
            get => _DepositToAccountId;
            set => SetPropertyValue(nameof(DepositToAccountId), ref _DepositToAccountId, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Single? _TotalDeposit;
        public Single? TotalDeposit
        {
            get => _TotalDeposit;
            set => SetPropertyValue(nameof(TotalDeposit), ref _TotalDeposit, value);
        }  
        private Int32? _ItemCount;
        public Int32? ItemCount
        {
            get => _ItemCount;
            set => SetPropertyValue(nameof(ItemCount), ref _ItemCount, value);
        }  
        private String _ItemAggregate;
        [Size(300)]
        public String ItemAggregate
        {
            get => _ItemAggregate;
            set => SetPropertyValue(nameof(ItemAggregate), ref _ItemAggregate, value);
        }  
        private String _CurrencyName;
        [Size(300)]
        public String CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private String _CurrencyId;
        [Size(300)]
        public String CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        private String _Payee;
        [Size(300)]
        public String Payee
        {
            get => _Payee;
            set => SetPropertyValue(nameof(Payee), ref _Payee, value);
        }  
        private String _PayeeId;
        [Size(300)]
        public String PayeeId
        {
            get => _PayeeId;
            set => SetPropertyValue(nameof(PayeeId), ref _PayeeId, value);
        }
        public const string QueryableProperties="Id,TxnNumber,Date,CashBackAccount,CashBackAccountId,CashBackAmount,CashBackId,CashBackMemo,DepositToAccount,DepositToAccountId,Memo,TotalDeposit,ItemCount,ItemAggregate,CurrencyName,CurrencyId,ExchangeRate,CustomFields,TimeModified,TimeCreated,Payee,PayeeId";
        public const string QuickbooksTableName="Deposits";
    }
}