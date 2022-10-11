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
    public class DepositLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public DepositLineItem(Session session)
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
        private String _DepositId;
        [Size(300)]
        public String DepositId
        {
            get => _DepositId;
            set => SetPropertyValue(nameof(DepositId), ref _DepositId, value);
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
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String _ItemLineId;
        [Size(300)]
        public String ItemLineId
        {
            get => _ItemLineId;
            set => SetPropertyValue(nameof(ItemLineId), ref _ItemLineId, value);
        }  
        private String _ItemAccount;
        [Size(300)]
        public String ItemAccount
        {
            get => _ItemAccount;
            set => SetPropertyValue(nameof(ItemAccount), ref _ItemAccount, value);
        }  
        private String _ItemAccountId;
        [Size(300)]
        public String ItemAccountId
        {
            get => _ItemAccountId;
            set => SetPropertyValue(nameof(ItemAccountId), ref _ItemAccountId, value);
        }  
        private Decimal? _ItemAmount;
        public Decimal? ItemAmount
        {
            get => _ItemAmount;
            set => SetPropertyValue(nameof(ItemAmount), ref _ItemAmount, value);
        }  
        private String _ItemCheckNumber;
        [Size(300)]
        public String ItemCheckNumber
        {
            get => _ItemCheckNumber;
            set => SetPropertyValue(nameof(ItemCheckNumber), ref _ItemCheckNumber, value);
        }  
        private String _ItemClass;
        [Size(300)]
        public String ItemClass
        {
            get => _ItemClass;
            set => SetPropertyValue(nameof(ItemClass), ref _ItemClass, value);
        }  
        private String _ItemClassId;
        [Size(300)]
        public String ItemClassId
        {
            get => _ItemClassId;
            set => SetPropertyValue(nameof(ItemClassId), ref _ItemClassId, value);
        }  
        private String _ItemEntityName;
        [Size(300)]
        public String ItemEntityName
        {
            get => _ItemEntityName;
            set => SetPropertyValue(nameof(ItemEntityName), ref _ItemEntityName, value);
        }  
        private String _ItemEntityId;
        [Size(300)]
        public String ItemEntityId
        {
            get => _ItemEntityId;
            set => SetPropertyValue(nameof(ItemEntityId), ref _ItemEntityId, value);
        }  
        private String _ItemMemo;
        [Size(300)]
        public String ItemMemo
        {
            get => _ItemMemo;
            set => SetPropertyValue(nameof(ItemMemo), ref _ItemMemo, value);
        }  
        private String _ItemPaymentMethod;
        [Size(300)]
        public String ItemPaymentMethod
        {
            get => _ItemPaymentMethod;
            set => SetPropertyValue(nameof(ItemPaymentMethod), ref _ItemPaymentMethod, value);
        }  
        private String _ItemPaymentMethodId;
        [Size(300)]
        public String ItemPaymentMethodId
        {
            get => _ItemPaymentMethodId;
            set => SetPropertyValue(nameof(ItemPaymentMethodId), ref _ItemPaymentMethodId, value);
        }  
        private String _ItemPaymentId;
        [Size(300)]
        public String ItemPaymentId
        {
            get => _ItemPaymentId;
            set => SetPropertyValue(nameof(ItemPaymentId), ref _ItemPaymentId, value);
        }  
        private String _ItemPaymentLineId;
        [Size(300)]
        public String ItemPaymentLineId
        {
            get => _ItemPaymentLineId;
            set => SetPropertyValue(nameof(ItemPaymentLineId), ref _ItemPaymentLineId, value);
        }  
        private String _ItemRefId;
        [Size(300)]
        public String ItemRefId
        {
            get => _ItemRefId;
            set => SetPropertyValue(nameof(ItemRefId), ref _ItemRefId, value);
        }  
        private String _ItemTxnType;
        [Size(300)]
        public String ItemTxnType
        {
            get => _ItemTxnType;
            set => SetPropertyValue(nameof(ItemTxnType), ref _ItemTxnType, value);
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
        public const string QueryableProperties="Id,DepositId,TxnNumber,Date,CashBackAccount,CashBackAccountId,CashBackAmount,CashBackId,CashBackMemo,DepositToAccount,DepositToAccountId,Memo,TotalDeposit,CustomFields,ItemLineId,ItemAccount,ItemAccountId,ItemAmount,ItemCheckNumber,ItemClass,ItemClassId,ItemEntityName,ItemEntityId,ItemMemo,ItemPaymentMethod,ItemPaymentMethodId,ItemPaymentId,ItemPaymentLineId,ItemRefId,ItemTxnType,CurrencyName,CurrencyId,ExchangeRate,TimeModified,TimeCreated,Payee,PayeeId";
        public const string QuickbooksTableName="DepositLineItems";
    }
}