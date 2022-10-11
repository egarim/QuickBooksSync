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
    public class JournalEntryLine : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public JournalEntryLine(Session session)
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
        private String _JournalEntryId;
        [Size(300)]
        public String JournalEntryId
        {
            get => _JournalEntryId;
            set => SetPropertyValue(nameof(JournalEntryId), ref _JournalEntryId, value);
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
        private Int32? _CreditLineCount;
        public Int32? CreditLineCount
        {
            get => _CreditLineCount;
            set => SetPropertyValue(nameof(CreditLineCount), ref _CreditLineCount, value);
        }  
        private Int32? _DebitLineCount;
        public Int32? DebitLineCount
        {
            get => _DebitLineCount;
            set => SetPropertyValue(nameof(DebitLineCount), ref _DebitLineCount, value);
        }  
        private String _LineId;
        [Size(300)]
        public String LineId
        {
            get => _LineId;
            set => SetPropertyValue(nameof(LineId), ref _LineId, value);
        }  
        private String _LineType;
        [Size(300)]
        public String LineType
        {
            get => _LineType;
            set => SetPropertyValue(nameof(LineType), ref _LineType, value);
        }  
        private String _LineAccount;
        [Size(300)]
        public String LineAccount
        {
            get => _LineAccount;
            set => SetPropertyValue(nameof(LineAccount), ref _LineAccount, value);
        }  
        private String _LineAccountId;
        [Size(300)]
        public String LineAccountId
        {
            get => _LineAccountId;
            set => SetPropertyValue(nameof(LineAccountId), ref _LineAccountId, value);
        }  
        private Decimal? _LineAmount;
        public Decimal? LineAmount
        {
            get => _LineAmount;
            set => SetPropertyValue(nameof(LineAmount), ref _LineAmount, value);
        }  
        private String _LineEntityName;
        [Size(300)]
        public String LineEntityName
        {
            get => _LineEntityName;
            set => SetPropertyValue(nameof(LineEntityName), ref _LineEntityName, value);
        }  
        private String _LineEntityId;
        [Size(300)]
        public String LineEntityId
        {
            get => _LineEntityId;
            set => SetPropertyValue(nameof(LineEntityId), ref _LineEntityId, value);
        }  
        private String _LineMemo;
        [Size(300)]
        public String LineMemo
        {
            get => _LineMemo;
            set => SetPropertyValue(nameof(LineMemo), ref _LineMemo, value);
        }  
        private String _LineClass;
        [Size(300)]
        public String LineClass
        {
            get => _LineClass;
            set => SetPropertyValue(nameof(LineClass), ref _LineClass, value);
        }  
        private String _LineClassId;
        [Size(300)]
        public String LineClassId
        {
            get => _LineClassId;
            set => SetPropertyValue(nameof(LineClassId), ref _LineClassId, value);
        }  
        private String _LineStatus;
        [Size(300)]
        public String LineStatus
        {
            get => _LineStatus;
            set => SetPropertyValue(nameof(LineStatus), ref _LineStatus, value);
        }  
        private String _LineTaxItem;
        [Size(300)]
        public String LineTaxItem
        {
            get => _LineTaxItem;
            set => SetPropertyValue(nameof(LineTaxItem), ref _LineTaxItem, value);
        }  
        private String _LineTaxItemId;
        [Size(300)]
        public String LineTaxItemId
        {
            get => _LineTaxItemId;
            set => SetPropertyValue(nameof(LineTaxItemId), ref _LineTaxItemId, value);
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
        private Boolean? _IsHomeCurrencyAdjustment;
        public Boolean? IsHomeCurrencyAdjustment
        {
            get => _IsHomeCurrencyAdjustment;
            set => SetPropertyValue(nameof(IsHomeCurrencyAdjustment), ref _IsHomeCurrencyAdjustment, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        public const string QueryableProperties="Id,JournalEntryId,ReferenceNumber,TxnNumber,Date,CreditLineCount,DebitLineCount,LineId,LineType,LineAccount,LineAccountId,LineAmount,LineEntityName,LineEntityId,LineMemo,LineClass,LineClassId,LineStatus,LineTaxItem,LineTaxItemId,CurrencyName,CurrencyId,ExchangeRate,IsHomeCurrencyAdjustment,EditSequence,TimeModified,TimeCreated";
        public const string QuickbooksTableName="JournalEntryLines";
    }
}