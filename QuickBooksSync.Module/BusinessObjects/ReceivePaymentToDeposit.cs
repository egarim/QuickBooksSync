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
    public class ReceivePaymentToDeposit : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ReceivePaymentToDeposit(Session session)
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
        private String? _TxnType;
        public String? TxnType
        {
            get => _TxnType;
            set => SetPropertyValue(nameof(TxnType), ref _TxnType, value);
        }  
        private String? _TxnLineId;
        public String? TxnLineId
        {
            get => _TxnLineId;
            set => SetPropertyValue(nameof(TxnLineId), ref _TxnLineId, value);
        }  
        private String? _CustomerRefListId;
        public String? CustomerRefListId
        {
            get => _CustomerRefListId;
            set => SetPropertyValue(nameof(CustomerRefListId), ref _CustomerRefListId, value);
        }  
        private String? _CustomerRefFullName;
        public String? CustomerRefFullName
        {
            get => _CustomerRefFullName;
            set => SetPropertyValue(nameof(CustomerRefFullName), ref _CustomerRefFullName, value);
        }  
        private DateTime _TxnDate;
        public DateTime TxnDate
        {
            get => _TxnDate;
            set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
        }  
        private String? _RefNumber;
        public String? RefNumber
        {
            get => _RefNumber;
            set => SetPropertyValue(nameof(RefNumber), ref _RefNumber, value);
        }  
        private Decimal _Amount;
        public Decimal Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String? _CurrencyId;
        public String? CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private String? _CurrencyName;
        public String? CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private Single _ExchangeRate;
        public Single ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private Single _AmountInHomeCurrency;
        public Single AmountInHomeCurrency
        {
            get => _AmountInHomeCurrency;
            set => SetPropertyValue(nameof(AmountInHomeCurrency), ref _AmountInHomeCurrency, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }  
        private string _CustomerRefList;
        public string CustomerRefList
        {
            get => _CustomerRefList;
            set => SetPropertyValue(nameof(CustomerRefList), ref _CustomerRefList, value);
        }
       
    }
}