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
        private String _TxnType;
        [Size(300)]
        public String TxnType
        {
            get => _TxnType;
            set => SetPropertyValue(nameof(TxnType), ref _TxnType, value);
        }  
        private String _TxnLineId;
        [Size(300)]
        public String TxnLineId
        {
            get => _TxnLineId;
            set => SetPropertyValue(nameof(TxnLineId), ref _TxnLineId, value);
        }  
        private String _CustomerRefListId;
        [Size(300)]
        public String CustomerRefListId
        {
            get => _CustomerRefListId;
            set => SetPropertyValue(nameof(CustomerRefListId), ref _CustomerRefListId, value);
        }  
        private String _CustomerRefFullName;
        [Size(300)]
        public String CustomerRefFullName
        {
            get => _CustomerRefFullName;
            set => SetPropertyValue(nameof(CustomerRefFullName), ref _CustomerRefFullName, value);
        }  
        private DateTime? _TxnDate;
        public DateTime? TxnDate
        {
            get => _TxnDate;
            set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
        }  
        private String _RefNumber;
        [Size(300)]
        public String RefNumber
        {
            get => _RefNumber;
            set => SetPropertyValue(nameof(RefNumber), ref _RefNumber, value);
        }  
        private Decimal? _Amount;
        public Decimal? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String _CurrencyId;
        [Size(300)]
        public String CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private String _CurrencyName;
        [Size(300)]
        public String CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
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
        public const string QueryableProperties="Id,TxnType,TxnLineId,CustomerRefListId,CustomerRefFullName,TxnDate,RefNumber,Amount,CurrencyId,CurrencyName,ExchangeRate,AmountInHomeCurrency";
    }
}