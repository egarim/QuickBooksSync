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
    public class Item : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Item(Session session)
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
        private String _FullName;
        [Size(300)]
        public String FullName
        {
            get => _FullName;
            set => SetPropertyValue(nameof(FullName), ref _FullName, value);
        }  
        private String _Type;
        [Size(300)]
        public String Type
        {
            get => _Type;
            set => SetPropertyValue(nameof(Type), ref _Type, value);
        }  
        private String _Account;
        [Size(300)]
        public String Account
        {
            get => _Account;
            set => SetPropertyValue(nameof(Account), ref _Account, value);
        }  
        private String _AccountId;
        [Size(300)]
        public String AccountId
        {
            get => _AccountId;
            set => SetPropertyValue(nameof(AccountId), ref _AccountId, value);
        }  
        private String _Cogsaccount;
        [Size(300)]
        public String Cogsaccount
        {
            get => _Cogsaccount;
            set => SetPropertyValue(nameof(Cogsaccount), ref _Cogsaccount, value);
        }  
        private String _CogsaccountId;
        [Size(300)]
        public String CogsaccountId
        {
            get => _CogsaccountId;
            set => SetPropertyValue(nameof(CogsaccountId), ref _CogsaccountId, value);
        }  
        private String _AssetAccount;
        [Size(300)]
        public String AssetAccount
        {
            get => _AssetAccount;
            set => SetPropertyValue(nameof(AssetAccount), ref _AssetAccount, value);
        }  
        private String _AssetAccountId;
        [Size(300)]
        public String AssetAccountId
        {
            get => _AssetAccountId;
            set => SetPropertyValue(nameof(AssetAccountId), ref _AssetAccountId, value);
        }  
        private String _Class;
        [Size(300)]
        public String Class
        {
            get => _Class;
            set => SetPropertyValue(nameof(Class), ref _Class, value);
        }  
        private String _ClassId;
        [Size(300)]
        public String ClassId
        {
            get => _ClassId;
            set => SetPropertyValue(nameof(ClassId), ref _ClassId, value);
        }  
        private DateTime? _DateSold;
        public DateTime? DateSold
        {
            get => _DateSold;
            set => SetPropertyValue(nameof(DateSold), ref _DateSold, value);
        }  
        private DateTime? _PurchaseDate;
        public DateTime? PurchaseDate
        {
            get => _PurchaseDate;
            set => SetPropertyValue(nameof(PurchaseDate), ref _PurchaseDate, value);
        }  
        private Int32? _ItemCount;
        public Int32? ItemCount
        {
            get => _ItemCount;
            set => SetPropertyValue(nameof(ItemCount), ref _ItemCount, value);
        }  
        private String _ParentName;
        [Size(300)]
        public String ParentName
        {
            get => _ParentName;
            set => SetPropertyValue(nameof(ParentName), ref _ParentName, value);
        }  
        private String _ParentId;
        [Size(300)]
        public String ParentId
        {
            get => _ParentId;
            set => SetPropertyValue(nameof(ParentId), ref _ParentId, value);
        }  
        private String _Description;
        [Size(300)]
        public String Description
        {
            get => _Description;
            set => SetPropertyValue(nameof(Description), ref _Description, value);
        }  
        private Single? _Price;
        public Single? Price
        {
            get => _Price;
            set => SetPropertyValue(nameof(Price), ref _Price, value);
        }  
        private Single? _PricePercent;
        public Single? PricePercent
        {
            get => _PricePercent;
            set => SetPropertyValue(nameof(PricePercent), ref _PricePercent, value);
        }  
        private Single? _AverageCost;
        public Single? AverageCost
        {
            get => _AverageCost;
            set => SetPropertyValue(nameof(AverageCost), ref _AverageCost, value);
        }  
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private Single? _PurchaseCost;
        public Single? PurchaseCost
        {
            get => _PurchaseCost;
            set => SetPropertyValue(nameof(PurchaseCost), ref _PurchaseCost, value);
        }  
        private String _PurchaseDescription;
        [Size(300)]
        public String PurchaseDescription
        {
            get => _PurchaseDescription;
            set => SetPropertyValue(nameof(PurchaseDescription), ref _PurchaseDescription, value);
        }  
        private String _ExpenseAccount;
        [Size(300)]
        public String ExpenseAccount
        {
            get => _ExpenseAccount;
            set => SetPropertyValue(nameof(ExpenseAccount), ref _ExpenseAccount, value);
        }  
        private String _ExpenseAccountId;
        [Size(300)]
        public String ExpenseAccountId
        {
            get => _ExpenseAccountId;
            set => SetPropertyValue(nameof(ExpenseAccountId), ref _ExpenseAccountId, value);
        }  
        private String _PreferredVendor;
        [Size(300)]
        public String PreferredVendor
        {
            get => _PreferredVendor;
            set => SetPropertyValue(nameof(PreferredVendor), ref _PreferredVendor, value);
        }  
        private String _PreferredVendorId;
        [Size(300)]
        public String PreferredVendorId
        {
            get => _PreferredVendorId;
            set => SetPropertyValue(nameof(PreferredVendorId), ref _PreferredVendorId, value);
        }  
        private Single? _QuantityOnHand;
        public Single? QuantityOnHand
        {
            get => _QuantityOnHand;
            set => SetPropertyValue(nameof(QuantityOnHand), ref _QuantityOnHand, value);
        }  
        private Single? _QuantityOnOrder;
        public Single? QuantityOnOrder
        {
            get => _QuantityOnOrder;
            set => SetPropertyValue(nameof(QuantityOnOrder), ref _QuantityOnOrder, value);
        }  
        private Single? _QuantityOnSalesOrder;
        public Single? QuantityOnSalesOrder
        {
            get => _QuantityOnSalesOrder;
            set => SetPropertyValue(nameof(QuantityOnSalesOrder), ref _QuantityOnSalesOrder, value);
        }  
        private DateTime? _InventoryDate;
        public DateTime? InventoryDate
        {
            get => _InventoryDate;
            set => SetPropertyValue(nameof(InventoryDate), ref _InventoryDate, value);
        }  
        private Single? _ReorderPoint;
        public Single? ReorderPoint
        {
            get => _ReorderPoint;
            set => SetPropertyValue(nameof(ReorderPoint), ref _ReorderPoint, value);
        }  
        private String _Barcode;
        [Size(300)]
        public String Barcode
        {
            get => _Barcode;
            set => SetPropertyValue(nameof(Barcode), ref _Barcode, value);
        }  
        private String _TaxCode;
        [Size(300)]
        public String TaxCode
        {
            get => _TaxCode;
            set => SetPropertyValue(nameof(TaxCode), ref _TaxCode, value);
        }  
        private String _TaxCodeId;
        [Size(300)]
        public String TaxCodeId
        {
            get => _TaxCodeId;
            set => SetPropertyValue(nameof(TaxCodeId), ref _TaxCodeId, value);
        }  
        private Boolean? _IsTaxIncluded;
        public Boolean? IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String _PurchaseTaxCode;
        [Size(300)]
        public String PurchaseTaxCode
        {
            get => _PurchaseTaxCode;
            set => SetPropertyValue(nameof(PurchaseTaxCode), ref _PurchaseTaxCode, value);
        }  
        private String _PurchaseTaxCodeId;
        [Size(300)]
        public String PurchaseTaxCodeId
        {
            get => _PurchaseTaxCodeId;
            set => SetPropertyValue(nameof(PurchaseTaxCodeId), ref _PurchaseTaxCodeId, value);
        }  
        private String _PartNumber;
        [Size(300)]
        public String PartNumber
        {
            get => _PartNumber;
            set => SetPropertyValue(nameof(PartNumber), ref _PartNumber, value);
        }  
        private String _PaymentMethodName;
        [Size(300)]
        public String PaymentMethodName
        {
            get => _PaymentMethodName;
            set => SetPropertyValue(nameof(PaymentMethodName), ref _PaymentMethodName, value);
        }  
        private String _PaymentMethodId;
        [Size(300)]
        public String PaymentMethodId
        {
            get => _PaymentMethodId;
            set => SetPropertyValue(nameof(PaymentMethodId), ref _PaymentMethodId, value);
        }  
        private Single? _TaxRate;
        public Single? TaxRate
        {
            get => _TaxRate;
            set => SetPropertyValue(nameof(TaxRate), ref _TaxRate, value);
        }  
        private String _TaxVendorName;
        [Size(300)]
        public String TaxVendorName
        {
            get => _TaxVendorName;
            set => SetPropertyValue(nameof(TaxVendorName), ref _TaxVendorName, value);
        }  
        private String _TaxVendorId;
        [Size(300)]
        public String TaxVendorId
        {
            get => _TaxVendorId;
            set => SetPropertyValue(nameof(TaxVendorId), ref _TaxVendorId, value);
        }  
        private String _SpecialItemType;
        [Size(300)]
        public String SpecialItemType
        {
            get => _SpecialItemType;
            set => SetPropertyValue(nameof(SpecialItemType), ref _SpecialItemType, value);
        }  
        private String _VendorOrPayeeName;
        [Size(300)]
        public String VendorOrPayeeName
        {
            get => _VendorOrPayeeName;
            set => SetPropertyValue(nameof(VendorOrPayeeName), ref _VendorOrPayeeName, value);
        }  
        private Boolean? _IsPrintItemsInGroup;
        public Boolean? IsPrintItemsInGroup
        {
            get => _IsPrintItemsInGroup;
            set => SetPropertyValue(nameof(IsPrintItemsInGroup), ref _IsPrintItemsInGroup, value);
        }  
        private String _SalesExpense;
        [Size(300)]
        public String SalesExpense
        {
            get => _SalesExpense;
            set => SetPropertyValue(nameof(SalesExpense), ref _SalesExpense, value);
        }  
        private String _AssetAcquiredAs;
        [Size(300)]
        public String AssetAcquiredAs
        {
            get => _AssetAcquiredAs;
            set => SetPropertyValue(nameof(AssetAcquiredAs), ref _AssetAcquiredAs, value);
        }  
        private String _AssetDescription;
        [Size(300)]
        public String AssetDescription
        {
            get => _AssetDescription;
            set => SetPropertyValue(nameof(AssetDescription), ref _AssetDescription, value);
        }  
        private String _AssetLocation;
        [Size(300)]
        public String AssetLocation
        {
            get => _AssetLocation;
            set => SetPropertyValue(nameof(AssetLocation), ref _AssetLocation, value);
        }  
        private String _AssetPonumber;
        [Size(300)]
        public String AssetPonumber
        {
            get => _AssetPonumber;
            set => SetPropertyValue(nameof(AssetPonumber), ref _AssetPonumber, value);
        }  
        private String _AssetSerialNumber;
        [Size(300)]
        public String AssetSerialNumber
        {
            get => _AssetSerialNumber;
            set => SetPropertyValue(nameof(AssetSerialNumber), ref _AssetSerialNumber, value);
        }  
        private DateTime? _AssetWarrantyExpires;
        public DateTime? AssetWarrantyExpires
        {
            get => _AssetWarrantyExpires;
            set => SetPropertyValue(nameof(AssetWarrantyExpires), ref _AssetWarrantyExpires, value);
        }  
        private String _AssetNotes;
        [Size(300)]
        public String AssetNotes
        {
            get => _AssetNotes;
            set => SetPropertyValue(nameof(AssetNotes), ref _AssetNotes, value);
        }  
        private String _AssetNumber;
        [Size(300)]
        public String AssetNumber
        {
            get => _AssetNumber;
            set => SetPropertyValue(nameof(AssetNumber), ref _AssetNumber, value);
        }  
        private Decimal? _AssetCostBasis;
        public Decimal? AssetCostBasis
        {
            get => _AssetCostBasis;
            set => SetPropertyValue(nameof(AssetCostBasis), ref _AssetCostBasis, value);
        }  
        private Single? _AssetDepreciation;
        public Single? AssetDepreciation
        {
            get => _AssetDepreciation;
            set => SetPropertyValue(nameof(AssetDepreciation), ref _AssetDepreciation, value);
        }  
        private Single? _AssetBookValue;
        public Single? AssetBookValue
        {
            get => _AssetBookValue;
            set => SetPropertyValue(nameof(AssetBookValue), ref _AssetBookValue, value);
        }  
        private String _UnitOfMeasure;
        [Size(300)]
        public String UnitOfMeasure
        {
            get => _UnitOfMeasure;
            set => SetPropertyValue(nameof(UnitOfMeasure), ref _UnitOfMeasure, value);
        }  
        private String _UnitOfMeasureId;
        [Size(300)]
        public String UnitOfMeasureId
        {
            get => _UnitOfMeasureId;
            set => SetPropertyValue(nameof(UnitOfMeasureId), ref _UnitOfMeasureId, value);
        }  
        private Int32? _Sublevel;
        public Int32? Sublevel
        {
            get => _Sublevel;
            set => SetPropertyValue(nameof(Sublevel), ref _Sublevel, value);
        }  
        private String _LineAggregate;
        [Size(300)]
        public String LineAggregate
        {
            get => _LineAggregate;
            set => SetPropertyValue(nameof(LineAggregate), ref _LineAggregate, value);
        }  
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        public const string QueryableProperties="Id,Name,FullName,Type,Account,AccountId,Cogsaccount,CogsaccountId,AssetAccount,AssetAccountId,Class,ClassId,DateSold,PurchaseDate,ItemCount,ParentName,ParentId,Description,Price,PricePercent,AverageCost,IsActive,PurchaseCost,PurchaseDescription,ExpenseAccount,ExpenseAccountId,PreferredVendor,PreferredVendorId,QuantityOnHand,QuantityOnOrder,QuantityOnSalesOrder,InventoryDate,ReorderPoint,Barcode,TaxCode,TaxCodeId,IsTaxIncluded,PurchaseTaxCode,PurchaseTaxCodeId,PartNumber,PaymentMethodName,PaymentMethodId,TaxRate,TaxVendorName,TaxVendorId,SpecialItemType,VendorOrPayeeName,IsPrintItemsInGroup,SalesExpense,AssetAcquiredAs,AssetDescription,AssetLocation,AssetPonumber,AssetSerialNumber,AssetWarrantyExpires,AssetNotes,AssetNumber,AssetCostBasis,AssetDepreciation,AssetBookValue,UnitOfMeasure,UnitOfMeasureId,Sublevel,LineAggregate,CustomFields,EditSequence,TimeModified,TimeCreated";
    }
}