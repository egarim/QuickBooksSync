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
    public class Currency : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Currency(Session session)
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
        private String _Name;
        [Size(300)]
        public String Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String _CurrencyCode;
        [Size(300)]
        public String CurrencyCode
        {
            get => _CurrencyCode;
            set => SetPropertyValue(nameof(CurrencyCode), ref _CurrencyCode, value);
        }  
        private String _CurrencyFormatThousandSeparator;
        [Size(300)]
        public String CurrencyFormatThousandSeparator
        {
            get => _CurrencyFormatThousandSeparator;
            set => SetPropertyValue(nameof(CurrencyFormatThousandSeparator), ref _CurrencyFormatThousandSeparator, value);
        }  
        private String _CurrencyFormatThousandSeparatorGrouping;
        [Size(300)]
        public String CurrencyFormatThousandSeparatorGrouping
        {
            get => _CurrencyFormatThousandSeparatorGrouping;
            set => SetPropertyValue(nameof(CurrencyFormatThousandSeparatorGrouping), ref _CurrencyFormatThousandSeparatorGrouping, value);
        }  
        private String _CurrencyFormatDecimalPlaces;
        [Size(300)]
        public String CurrencyFormatDecimalPlaces
        {
            get => _CurrencyFormatDecimalPlaces;
            set => SetPropertyValue(nameof(CurrencyFormatDecimalPlaces), ref _CurrencyFormatDecimalPlaces, value);
        }  
        private String _CurrencyFormatDecimalSeparator;
        [Size(300)]
        public String CurrencyFormatDecimalSeparator
        {
            get => _CurrencyFormatDecimalSeparator;
            set => SetPropertyValue(nameof(CurrencyFormatDecimalSeparator), ref _CurrencyFormatDecimalSeparator, value);
        }  
        private Boolean? _IsUserDefinedCurrency;
        public Boolean? IsUserDefinedCurrency
        {
            get => _IsUserDefinedCurrency;
            set => SetPropertyValue(nameof(IsUserDefinedCurrency), ref _IsUserDefinedCurrency, value);
        }  
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private DateTime? _AsOfDate;
        public DateTime? AsOfDate
        {
            get => _AsOfDate;
            set => SetPropertyValue(nameof(AsOfDate), ref _AsOfDate, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }
        public const string QueryableProperties="Id,Name,IsActive,CurrencyCode,CurrencyFormatThousandSeparator,CurrencyFormatThousandSeparatorGrouping,CurrencyFormatDecimalPlaces,CurrencyFormatDecimalSeparator,IsUserDefinedCurrency,ExchangeRate,AsOfDate,EditSequence,TimeCreated,TimeModified";
        public const string QuickbooksTableName="Currency";
    }
}