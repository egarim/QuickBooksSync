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
    public class Account : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Account(Session session)
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
        private String? _Name;
        public String? Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String? _FullName;
        public String? FullName
        {
            get => _FullName;
            set => SetPropertyValue(nameof(FullName), ref _FullName, value);
        }  
        private String? _Type;
        public String? Type
        {
            get => _Type;
            set => SetPropertyValue(nameof(Type), ref _Type, value);
        }  
        private String? _SpecialType;
        public String? SpecialType
        {
            get => _SpecialType;
            set => SetPropertyValue(nameof(SpecialType), ref _SpecialType, value);
        }  
        private String? _Number;
        public String? Number
        {
            get => _Number;
            set => SetPropertyValue(nameof(Number), ref _Number, value);
        }  
        private Single _Balance;
        public Single Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
        }  
        private Single _AccountBalance;
        public Single AccountBalance
        {
            get => _AccountBalance;
            set => SetPropertyValue(nameof(AccountBalance), ref _AccountBalance, value);
        }  
        private String? _BankAccount;
        public String? BankAccount
        {
            get => _BankAccount;
            set => SetPropertyValue(nameof(BankAccount), ref _BankAccount, value);
        }  
        private String? _Description;
        public String? Description
        {
            get => _Description;
            set => SetPropertyValue(nameof(Description), ref _Description, value);
        }  
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String? _ParentName;
        public String? ParentName
        {
            get => _ParentName;
            set => SetPropertyValue(nameof(ParentName), ref _ParentName, value);
        }  
        private String? _ParentId;
        public String? ParentId
        {
            get => _ParentId;
            set => SetPropertyValue(nameof(ParentId), ref _ParentId, value);
        }  
        private Int32 _Sublevel;
        public Int32 Sublevel
        {
            get => _Sublevel;
            set => SetPropertyValue(nameof(Sublevel), ref _Sublevel, value);
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
        private String? _CashFlowClassification;
        public String? CashFlowClassification
        {
            get => _CashFlowClassification;
            set => SetPropertyValue(nameof(CashFlowClassification), ref _CashFlowClassification, value);
        }  
        private String? _TaxLineName;
        public String? TaxLineName
        {
            get => _TaxLineName;
            set => SetPropertyValue(nameof(TaxLineName), ref _TaxLineName, value);
        }  
        private String? _TaxLineId;
        public String? TaxLineId
        {
            get => _TaxLineId;
            set => SetPropertyValue(nameof(TaxLineId), ref _TaxLineId, value);
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
        private string _Parent;
        public string Parent
        {
            get => _Parent;
            set => SetPropertyValue(nameof(Parent), ref _Parent, value);
        }
       
    }
}