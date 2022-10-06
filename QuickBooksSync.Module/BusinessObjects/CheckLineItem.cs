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
    public class CheckLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CheckLineItem(Session session)
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
        private String? _CheckId;
        public String? CheckId
        {
            get => _CheckId;
            set => SetPropertyValue(nameof(CheckId), ref _CheckId, value);
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
        private String? _Account;
        public String? Account
        {
            get => _Account;
            set => SetPropertyValue(nameof(Account), ref _Account, value);
        }  
        private String? _AccountId;
        public String? AccountId
        {
            get => _AccountId;
            set => SetPropertyValue(nameof(AccountId), ref _AccountId, value);
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
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private Decimal _Amount;
        public Decimal Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String? _Address;
        public String? Address
        {
            get => _Address;
            set => SetPropertyValue(nameof(Address), ref _Address, value);
        }  
        private String? _Line1;
        public String? Line1
        {
            get => _Line1;
            set => SetPropertyValue(nameof(Line1), ref _Line1, value);
        }  
        private String? _Line2;
        public String? Line2
        {
            get => _Line2;
            set => SetPropertyValue(nameof(Line2), ref _Line2, value);
        }  
        private String? _Line3;
        public String? Line3
        {
            get => _Line3;
            set => SetPropertyValue(nameof(Line3), ref _Line3, value);
        }  
        private String? _Line4;
        public String? Line4
        {
            get => _Line4;
            set => SetPropertyValue(nameof(Line4), ref _Line4, value);
        }  
        private String? _Line5;
        public String? Line5
        {
            get => _Line5;
            set => SetPropertyValue(nameof(Line5), ref _Line5, value);
        }  
        private String? _City;
        public String? City
        {
            get => _City;
            set => SetPropertyValue(nameof(City), ref _City, value);
        }  
        private String? _State;
        public String? State
        {
            get => _State;
            set => SetPropertyValue(nameof(State), ref _State, value);
        }  
        private String? _PostalCode;
        public String? PostalCode
        {
            get => _PostalCode;
            set => SetPropertyValue(nameof(PostalCode), ref _PostalCode, value);
        }  
        private String? _Country;
        public String? Country
        {
            get => _Country;
            set => SetPropertyValue(nameof(Country), ref _Country, value);
        }  
        private String? _Note;
        public String? Note
        {
            get => _Note;
            set => SetPropertyValue(nameof(Note), ref _Note, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String? _ItemLineId;
        public String? ItemLineId
        {
            get => _ItemLineId;
            set => SetPropertyValue(nameof(ItemLineId), ref _ItemLineId, value);
        }  
        private String? _ItemLineNumber;
        public String? ItemLineNumber
        {
            get => _ItemLineNumber;
            set => SetPropertyValue(nameof(ItemLineNumber), ref _ItemLineNumber, value);
        }  
        private String? _ItemName;
        public String? ItemName
        {
            get => _ItemName;
            set => SetPropertyValue(nameof(ItemName), ref _ItemName, value);
        }  
        private String? _ItemId;
        public String? ItemId
        {
            get => _ItemId;
            set => SetPropertyValue(nameof(ItemId), ref _ItemId, value);
        }  
        private String? _ItemGroup;
        public String? ItemGroup
        {
            get => _ItemGroup;
            set => SetPropertyValue(nameof(ItemGroup), ref _ItemGroup, value);
        }  
        private String? _ItemGroupId;
        public String? ItemGroupId
        {
            get => _ItemGroupId;
            set => SetPropertyValue(nameof(ItemGroupId), ref _ItemGroupId, value);
        }  
        private String? _ItemDescription;
        public String? ItemDescription
        {
            get => _ItemDescription;
            set => SetPropertyValue(nameof(ItemDescription), ref _ItemDescription, value);
        }  
        private Single _ItemQuantity;
        public Single ItemQuantity
        {
            get => _ItemQuantity;
            set => SetPropertyValue(nameof(ItemQuantity), ref _ItemQuantity, value);
        }  
        private String? _ItemUnitOfMeasure;
        public String? ItemUnitOfMeasure
        {
            get => _ItemUnitOfMeasure;
            set => SetPropertyValue(nameof(ItemUnitOfMeasure), ref _ItemUnitOfMeasure, value);
        }  
        private Single _ItemCost;
        public Single ItemCost
        {
            get => _ItemCost;
            set => SetPropertyValue(nameof(ItemCost), ref _ItemCost, value);
        }  
        private Decimal _ItemAmount;
        public Decimal ItemAmount
        {
            get => _ItemAmount;
            set => SetPropertyValue(nameof(ItemAmount), ref _ItemAmount, value);
        }  
        private String? _ItemBillableStatus;
        public String? ItemBillableStatus
        {
            get => _ItemBillableStatus;
            set => SetPropertyValue(nameof(ItemBillableStatus), ref _ItemBillableStatus, value);
        }  
        private String? _ItemCustomer;
        public String? ItemCustomer
        {
            get => _ItemCustomer;
            set => SetPropertyValue(nameof(ItemCustomer), ref _ItemCustomer, value);
        }  
        private String? _ItemCustomerId;
        public String? ItemCustomerId
        {
            get => _ItemCustomerId;
            set => SetPropertyValue(nameof(ItemCustomerId), ref _ItemCustomerId, value);
        }  
        private String? _ItemClass;
        public String? ItemClass
        {
            get => _ItemClass;
            set => SetPropertyValue(nameof(ItemClass), ref _ItemClass, value);
        }  
        private String? _ItemClassId;
        public String? ItemClassId
        {
            get => _ItemClassId;
            set => SetPropertyValue(nameof(ItemClassId), ref _ItemClassId, value);
        }  
        private String? _ItemInventorySiteId;
        public String? ItemInventorySiteId
        {
            get => _ItemInventorySiteId;
            set => SetPropertyValue(nameof(ItemInventorySiteId), ref _ItemInventorySiteId, value);
        }  
        private String? _ItemInventorySiteName;
        public String? ItemInventorySiteName
        {
            get => _ItemInventorySiteName;
            set => SetPropertyValue(nameof(ItemInventorySiteName), ref _ItemInventorySiteName, value);
        }  
        private String? _ItemInventorySiteLocationId;
        public String? ItemInventorySiteLocationId
        {
            get => _ItemInventorySiteLocationId;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationId), ref _ItemInventorySiteLocationId, value);
        }  
        private String? _ItemInventorySiteLocationName;
        public String? ItemInventorySiteLocationName
        {
            get => _ItemInventorySiteLocationName;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationName), ref _ItemInventorySiteLocationName, value);
        }  
        private String? _ItemTaxCode;
        public String? ItemTaxCode
        {
            get => _ItemTaxCode;
            set => SetPropertyValue(nameof(ItemTaxCode), ref _ItemTaxCode, value);
        }  
        private String? _ItemTaxCodeId;
        public String? ItemTaxCodeId
        {
            get => _ItemTaxCodeId;
            set => SetPropertyValue(nameof(ItemTaxCodeId), ref _ItemTaxCodeId, value);
        }  
        private String? _ItemCustomFields;
        public String? ItemCustomFields
        {
            get => _ItemCustomFields;
            set => SetPropertyValue(nameof(ItemCustomFields), ref _ItemCustomFields, value);
        }  
        private Boolean _IsToBePrinted;
        public Boolean IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
        }  
        private Boolean _IsTaxIncluded;
        public Boolean IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
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
        private string _AccountNavigation;
        public string AccountNavigation
        {
            get => _AccountNavigation;
            set => SetPropertyValue(nameof(AccountNavigation), ref _AccountNavigation, value);
        }  
        private string _Check;
        public string Check
        {
            get => _Check;
            set => SetPropertyValue(nameof(Check), ref _Check, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }  
        private string _Item;
        public string Item
        {
            get => _Item;
            set => SetPropertyValue(nameof(Item), ref _Item, value);
        }  
        private string _ItemClassNavigation;
        public string ItemClassNavigation
        {
            get => _ItemClassNavigation;
            set => SetPropertyValue(nameof(ItemClassNavigation), ref _ItemClassNavigation, value);
        }  
        private string _ItemCustomerNavigation;
        public string ItemCustomerNavigation
        {
            get => _ItemCustomerNavigation;
            set => SetPropertyValue(nameof(ItemCustomerNavigation), ref _ItemCustomerNavigation, value);
        }  
        private string _ItemGroupNavigation;
        public string ItemGroupNavigation
        {
            get => _ItemGroupNavigation;
            set => SetPropertyValue(nameof(ItemGroupNavigation), ref _ItemGroupNavigation, value);
        }  
        private string _ItemInventorySite;
        public string ItemInventorySite
        {
            get => _ItemInventorySite;
            set => SetPropertyValue(nameof(ItemInventorySite), ref _ItemInventorySite, value);
        }  
        private string _ItemTaxCodeNavigation;
        public string ItemTaxCodeNavigation
        {
            get => _ItemTaxCodeNavigation;
            set => SetPropertyValue(nameof(ItemTaxCodeNavigation), ref _ItemTaxCodeNavigation, value);
        }  
        private string _PayeeNavigation;
        public string PayeeNavigation
        {
            get => _PayeeNavigation;
            set => SetPropertyValue(nameof(PayeeNavigation), ref _PayeeNavigation, value);
        }
       
    }
}