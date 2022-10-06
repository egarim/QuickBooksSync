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
    public class ItemLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ItemLineItem(Session session)
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
        private String? _ItemId;
        public String? ItemId
        {
            get => _ItemId;
            set => SetPropertyValue(nameof(ItemId), ref _ItemId, value);
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
        private String? _Barcode;
        public String? Barcode
        {
            get => _Barcode;
            set => SetPropertyValue(nameof(Barcode), ref _Barcode, value);
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
        private String? _Cogsaccount;
        public String? Cogsaccount
        {
            get => _Cogsaccount;
            set => SetPropertyValue(nameof(Cogsaccount), ref _Cogsaccount, value);
        }  
        private String? _CogsaccountId;
        public String? CogsaccountId
        {
            get => _CogsaccountId;
            set => SetPropertyValue(nameof(CogsaccountId), ref _CogsaccountId, value);
        }  
        private String? _AssetAccount;
        public String? AssetAccount
        {
            get => _AssetAccount;
            set => SetPropertyValue(nameof(AssetAccount), ref _AssetAccount, value);
        }  
        private String? _AssetAccountId;
        public String? AssetAccountId
        {
            get => _AssetAccountId;
            set => SetPropertyValue(nameof(AssetAccountId), ref _AssetAccountId, value);
        }  
        private Int32 _LineItemNumber;
        public Int32 LineItemNumber
        {
            get => _LineItemNumber;
            set => SetPropertyValue(nameof(LineItemNumber), ref _LineItemNumber, value);
        }  
        private String? _LineItemId;
        public String? LineItemId
        {
            get => _LineItemId;
            set => SetPropertyValue(nameof(LineItemId), ref _LineItemId, value);
        }  
        private String? _LineItemName;
        public String? LineItemName
        {
            get => _LineItemName;
            set => SetPropertyValue(nameof(LineItemName), ref _LineItemName, value);
        }  
        private Single _LineItemQuantity;
        public Single LineItemQuantity
        {
            get => _LineItemQuantity;
            set => SetPropertyValue(nameof(LineItemQuantity), ref _LineItemQuantity, value);
        }  
        private String? _LineItemUnitOfMeasure;
        public String? LineItemUnitOfMeasure
        {
            get => _LineItemUnitOfMeasure;
            set => SetPropertyValue(nameof(LineItemUnitOfMeasure), ref _LineItemUnitOfMeasure, value);
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
        private String? _Description;
        public String? Description
        {
            get => _Description;
            set => SetPropertyValue(nameof(Description), ref _Description, value);
        }  
        private Single _Price;
        public Single Price
        {
            get => _Price;
            set => SetPropertyValue(nameof(Price), ref _Price, value);
        }  
        private Single _AverageCost;
        public Single AverageCost
        {
            get => _AverageCost;
            set => SetPropertyValue(nameof(AverageCost), ref _AverageCost, value);
        }  
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private Single _PurchaseCost;
        public Single PurchaseCost
        {
            get => _PurchaseCost;
            set => SetPropertyValue(nameof(PurchaseCost), ref _PurchaseCost, value);
        }  
        private String? _PurchaseDescription;
        public String? PurchaseDescription
        {
            get => _PurchaseDescription;
            set => SetPropertyValue(nameof(PurchaseDescription), ref _PurchaseDescription, value);
        }  
        private String? _PreferredVendor;
        public String? PreferredVendor
        {
            get => _PreferredVendor;
            set => SetPropertyValue(nameof(PreferredVendor), ref _PreferredVendor, value);
        }  
        private String? _PreferredVendorId;
        public String? PreferredVendorId
        {
            get => _PreferredVendorId;
            set => SetPropertyValue(nameof(PreferredVendorId), ref _PreferredVendorId, value);
        }  
        private String? _TaxCode;
        public String? TaxCode
        {
            get => _TaxCode;
            set => SetPropertyValue(nameof(TaxCode), ref _TaxCode, value);
        }  
        private String? _TaxCodeId;
        public String? TaxCodeId
        {
            get => _TaxCodeId;
            set => SetPropertyValue(nameof(TaxCodeId), ref _TaxCodeId, value);
        }  
        private Boolean _IsTaxIncluded;
        public Boolean IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        private string _AssetAccountNavigation;
        public string AssetAccountNavigation
        {
            get => _AssetAccountNavigation;
            set => SetPropertyValue(nameof(AssetAccountNavigation), ref _AssetAccountNavigation, value);
        }  
        private string _CogsaccountNavigation;
        public string CogsaccountNavigation
        {
            get => _CogsaccountNavigation;
            set => SetPropertyValue(nameof(CogsaccountNavigation), ref _CogsaccountNavigation, value);
        }  
        private string _Item;
        public string Item
        {
            get => _Item;
            set => SetPropertyValue(nameof(Item), ref _Item, value);
        }  
        private string _LineItem;
        public string LineItem
        {
            get => _LineItem;
            set => SetPropertyValue(nameof(LineItem), ref _LineItem, value);
        }  
        private string _Parent;
        public string Parent
        {
            get => _Parent;
            set => SetPropertyValue(nameof(Parent), ref _Parent, value);
        }  
        private string _PreferredVendorNavigation;
        public string PreferredVendorNavigation
        {
            get => _PreferredVendorNavigation;
            set => SetPropertyValue(nameof(PreferredVendorNavigation), ref _PreferredVendorNavigation, value);
        }  
        private string _TaxCodeNavigation;
        public string TaxCodeNavigation
        {
            get => _TaxCodeNavigation;
            set => SetPropertyValue(nameof(TaxCodeNavigation), ref _TaxCodeNavigation, value);
        }
        public const string QueriableProperties="Id,ItemId,Name,FullName,Type,Barcode,Account,AccountId,Cogsaccount,CogsaccountId,AssetAccount,AssetAccountId,LineItemNumber,LineItemId,LineItemName,LineItemQuantity,LineItemUnitOfMeasure,ParentName,ParentId,Description,Price,AverageCost,IsActive,PurchaseCost,PurchaseDescription,PreferredVendor,PreferredVendorId,TaxCode,TaxCodeId,IsTaxIncluded,CustomFields,TimeModified,TimeCreated,AccountNavigation,AssetAccountNavigation,CogsaccountNavigation,Item,LineItem,Parent,PreferredVendorNavigation,TaxCodeNavigation";
    }
}