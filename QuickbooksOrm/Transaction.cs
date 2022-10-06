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
    public class Transaction : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Transaction(Session session)
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
        private String? _TxnLineId;
        public String? TxnLineId
        {
            get => _TxnLineId;
            set => SetPropertyValue(nameof(TxnLineId), ref _TxnLineId, value);
        }  
        private String? _Type;
        public String? Type
        {
            get => _Type;
            set => SetPropertyValue(nameof(Type), ref _Type, value);
        }  
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String? _Entity;
        public String? Entity
        {
            get => _Entity;
            set => SetPropertyValue(nameof(Entity), ref _Entity, value);
        }  
        private String? _EntityId;
        public String? EntityId
        {
            get => _EntityId;
            set => SetPropertyValue(nameof(EntityId), ref _EntityId, value);
        }  
        private String? _AccountName;
        public String? AccountName
        {
            get => _AccountName;
            set => SetPropertyValue(nameof(AccountName), ref _AccountName, value);
        }  
        private String? _AccountId;
        public String? AccountId
        {
            get => _AccountId;
            set => SetPropertyValue(nameof(AccountId), ref _AccountId, value);
        }  
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private Decimal _Amount;
        public Decimal Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
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
        private Decimal _AmountInHomeCurrency;
        public Decimal AmountInHomeCurrency
        {
            get => _AmountInHomeCurrency;
            set => SetPropertyValue(nameof(AmountInHomeCurrency), ref _AmountInHomeCurrency, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
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
        private string _Account;
        public string Account
        {
            get => _Account;
            set => SetPropertyValue(nameof(Account), ref _Account, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }
       
    }
}