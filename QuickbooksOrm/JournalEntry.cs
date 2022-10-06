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
    public class JournalEntry : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public JournalEntry(Session session)
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
        private Int32 _CreditLineCount;
        public Int32 CreditLineCount
        {
            get => _CreditLineCount;
            set => SetPropertyValue(nameof(CreditLineCount), ref _CreditLineCount, value);
        }  
        private Int32 _DebitLineCount;
        public Int32 DebitLineCount
        {
            get => _DebitLineCount;
            set => SetPropertyValue(nameof(DebitLineCount), ref _DebitLineCount, value);
        }  
        private String? _FirstCreditAccount;
        public String? FirstCreditAccount
        {
            get => _FirstCreditAccount;
            set => SetPropertyValue(nameof(FirstCreditAccount), ref _FirstCreditAccount, value);
        }  
        private Decimal _FirstCreditAmount;
        public Decimal FirstCreditAmount
        {
            get => _FirstCreditAmount;
            set => SetPropertyValue(nameof(FirstCreditAmount), ref _FirstCreditAmount, value);
        }  
        private String? _FirstCreditMemo;
        public String? FirstCreditMemo
        {
            get => _FirstCreditMemo;
            set => SetPropertyValue(nameof(FirstCreditMemo), ref _FirstCreditMemo, value);
        }  
        private String? _FirstCreditEntityName;
        public String? FirstCreditEntityName
        {
            get => _FirstCreditEntityName;
            set => SetPropertyValue(nameof(FirstCreditEntityName), ref _FirstCreditEntityName, value);
        }  
        private String? _FirstCreditEntityId;
        public String? FirstCreditEntityId
        {
            get => _FirstCreditEntityId;
            set => SetPropertyValue(nameof(FirstCreditEntityId), ref _FirstCreditEntityId, value);
        }  
        private String? _FirstDebitAccount;
        public String? FirstDebitAccount
        {
            get => _FirstDebitAccount;
            set => SetPropertyValue(nameof(FirstDebitAccount), ref _FirstDebitAccount, value);
        }  
        private Decimal _FirstDebitAmount;
        public Decimal FirstDebitAmount
        {
            get => _FirstDebitAmount;
            set => SetPropertyValue(nameof(FirstDebitAmount), ref _FirstDebitAmount, value);
        }  
        private String? _FirstDebitMemo;
        public String? FirstDebitMemo
        {
            get => _FirstDebitMemo;
            set => SetPropertyValue(nameof(FirstDebitMemo), ref _FirstDebitMemo, value);
        }  
        private String? _FirstDebitEntityName;
        public String? FirstDebitEntityName
        {
            get => _FirstDebitEntityName;
            set => SetPropertyValue(nameof(FirstDebitEntityName), ref _FirstDebitEntityName, value);
        }  
        private String? _FirstDebitEntityId;
        public String? FirstDebitEntityId
        {
            get => _FirstDebitEntityId;
            set => SetPropertyValue(nameof(FirstDebitEntityId), ref _FirstDebitEntityId, value);
        }  
        private String? _LineAggregate;
        public String? LineAggregate
        {
            get => _LineAggregate;
            set => SetPropertyValue(nameof(LineAggregate), ref _LineAggregate, value);
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
        private Boolean _IsHomeCurrencyAdjustment;
        public Boolean IsHomeCurrencyAdjustment
        {
            get => _IsHomeCurrencyAdjustment;
            set => SetPropertyValue(nameof(IsHomeCurrencyAdjustment), ref _IsHomeCurrencyAdjustment, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }
       
    }
}