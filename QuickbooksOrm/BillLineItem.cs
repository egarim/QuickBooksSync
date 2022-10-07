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
    public class BillLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public BillLineItem(Session session)
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
        private String _BillId;
        [Size(300)]
        public String BillId
        {
            get => _BillId;
            set => SetPropertyValue(nameof(BillId), ref _BillId, value);
        }  
        private String _VendorName;
        [Size(300)]
        public String VendorName
        {
            get => _VendorName;
            set => SetPropertyValue(nameof(VendorName), ref _VendorName, value);
        }  
        private String _VendorId;
        [Size(300)]
        public String VendorId
        {
            get => _VendorId;
            set => SetPropertyValue(nameof(VendorId), ref _VendorId, value);
        }  
        private String _ReferenceNumber;
        [Size(300)]
        public String ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private Int32? _TxnNumber;
        public Int32? TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private DateTime? _DueDate;
        public DateTime? DueDate
        {
            get => _DueDate;
            set => SetPropertyValue(nameof(DueDate), ref _DueDate, value);
        }  
        private String _Terms;
        [Size(300)]
        public String Terms
        {
            get => _Terms;
            set => SetPropertyValue(nameof(Terms), ref _Terms, value);
        }  
        private String _TermsId;
        [Size(300)]
        public String TermsId
        {
            get => _TermsId;
            set => SetPropertyValue(nameof(TermsId), ref _TermsId, value);
        }  
        private String _AccountsPayable;
        [Size(300)]
        public String AccountsPayable
        {
            get => _AccountsPayable;
            set => SetPropertyValue(nameof(AccountsPayable), ref _AccountsPayable, value);
        }  
        private String _AccountsPayableId;
        [Size(300)]
        public String AccountsPayableId
        {
            get => _AccountsPayableId;
            set => SetPropertyValue(nameof(AccountsPayableId), ref _AccountsPayableId, value);
        }  
        private Decimal? _Amount;
        public Decimal? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Boolean? _IsPaid;
        public Boolean? IsPaid
        {
            get => _IsPaid;
            set => SetPropertyValue(nameof(IsPaid), ref _IsPaid, value);
        }  
        private Boolean? _IsTaxIncluded;
        public Boolean? IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String _ItemLineId;
        [Size(300)]
        public String ItemLineId
        {
            get => _ItemLineId;
            set => SetPropertyValue(nameof(ItemLineId), ref _ItemLineId, value);
        }  
        private String _ItemLineNumber;
        [Size(300)]
        public String ItemLineNumber
        {
            get => _ItemLineNumber;
            set => SetPropertyValue(nameof(ItemLineNumber), ref _ItemLineNumber, value);
        }  
        private String _ItemName;
        [Size(300)]
        public String ItemName
        {
            get => _ItemName;
            set => SetPropertyValue(nameof(ItemName), ref _ItemName, value);
        }  
        private String _ItemId;
        [Size(300)]
        public String ItemId
        {
            get => _ItemId;
            set => SetPropertyValue(nameof(ItemId), ref _ItemId, value);
        }  
        private String _ItemGroup;
        [Size(300)]
        public String ItemGroup
        {
            get => _ItemGroup;
            set => SetPropertyValue(nameof(ItemGroup), ref _ItemGroup, value);
        }  
        private String _ItemGroupId;
        [Size(300)]
        public String ItemGroupId
        {
            get => _ItemGroupId;
            set => SetPropertyValue(nameof(ItemGroupId), ref _ItemGroupId, value);
        }  
        private String _ItemDescription;
        [Size(300)]
        public String ItemDescription
        {
            get => _ItemDescription;
            set => SetPropertyValue(nameof(ItemDescription), ref _ItemDescription, value);
        }  
        private Single? _ItemQuantity;
        public Single? ItemQuantity
        {
            get => _ItemQuantity;
            set => SetPropertyValue(nameof(ItemQuantity), ref _ItemQuantity, value);
        }  
        private String _ItemUnitOfMeasure;
        [Size(300)]
        public String ItemUnitOfMeasure
        {
            get => _ItemUnitOfMeasure;
            set => SetPropertyValue(nameof(ItemUnitOfMeasure), ref _ItemUnitOfMeasure, value);
        }  
        private Single? _ItemCost;
        public Single? ItemCost
        {
            get => _ItemCost;
            set => SetPropertyValue(nameof(ItemCost), ref _ItemCost, value);
        }  
        private Decimal? _ItemAmount;
        public Decimal? ItemAmount
        {
            get => _ItemAmount;
            set => SetPropertyValue(nameof(ItemAmount), ref _ItemAmount, value);
        }  
        private String _ItemBillableStatus;
        [Size(300)]
        public String ItemBillableStatus
        {
            get => _ItemBillableStatus;
            set => SetPropertyValue(nameof(ItemBillableStatus), ref _ItemBillableStatus, value);
        }  
        private String _ItemCustomer;
        [Size(300)]
        public String ItemCustomer
        {
            get => _ItemCustomer;
            set => SetPropertyValue(nameof(ItemCustomer), ref _ItemCustomer, value);
        }  
        private String _ItemCustomerId;
        [Size(300)]
        public String ItemCustomerId
        {
            get => _ItemCustomerId;
            set => SetPropertyValue(nameof(ItemCustomerId), ref _ItemCustomerId, value);
        }  
        private String _ItemInventorySiteId;
        [Size(300)]
        public String ItemInventorySiteId
        {
            get => _ItemInventorySiteId;
            set => SetPropertyValue(nameof(ItemInventorySiteId), ref _ItemInventorySiteId, value);
        }  
        private String _ItemInventorySiteName;
        [Size(300)]
        public String ItemInventorySiteName
        {
            get => _ItemInventorySiteName;
            set => SetPropertyValue(nameof(ItemInventorySiteName), ref _ItemInventorySiteName, value);
        }  
        private String _ItemInventorySiteLocationId;
        [Size(300)]
        public String ItemInventorySiteLocationId
        {
            get => _ItemInventorySiteLocationId;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationId), ref _ItemInventorySiteLocationId, value);
        }  
        private String _ItemInventorySiteLocationName;
        [Size(300)]
        public String ItemInventorySiteLocationName
        {
            get => _ItemInventorySiteLocationName;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationName), ref _ItemInventorySiteLocationName, value);
        }  
        private String _ItemSerialNumber;
        [Size(300)]
        public String ItemSerialNumber
        {
            get => _ItemSerialNumber;
            set => SetPropertyValue(nameof(ItemSerialNumber), ref _ItemSerialNumber, value);
        }  
        private String _ItemLotNumber;
        [Size(300)]
        public String ItemLotNumber
        {
            get => _ItemLotNumber;
            set => SetPropertyValue(nameof(ItemLotNumber), ref _ItemLotNumber, value);
        }  
        private String _ItemClass;
        [Size(300)]
        public String ItemClass
        {
            get => _ItemClass;
            set => SetPropertyValue(nameof(ItemClass), ref _ItemClass, value);
        }  
        private String _ItemClassId;
        [Size(300)]
        public String ItemClassId
        {
            get => _ItemClassId;
            set => SetPropertyValue(nameof(ItemClassId), ref _ItemClassId, value);
        }  
        private String _ItemTaxCode;
        [Size(300)]
        public String ItemTaxCode
        {
            get => _ItemTaxCode;
            set => SetPropertyValue(nameof(ItemTaxCode), ref _ItemTaxCode, value);
        }  
        private String _ItemTaxCodeId;
        [Size(300)]
        public String ItemTaxCodeId
        {
            get => _ItemTaxCodeId;
            set => SetPropertyValue(nameof(ItemTaxCodeId), ref _ItemTaxCodeId, value);
        }  
        private String _ItemCustomFields;
        [Size(300)]
        public String ItemCustomFields
        {
            get => _ItemCustomFields;
            set => SetPropertyValue(nameof(ItemCustomFields), ref _ItemCustomFields, value);
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
        private Decimal? _ExchangeRate;
        public Decimal? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
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
        private Decimal? _OpenAmount;
        public Decimal? OpenAmount
        {
            get => _OpenAmount;
            set => SetPropertyValue(nameof(OpenAmount), ref _OpenAmount, value);
        }
        public const string QueryableProperties="Id,BillId,VendorName,VendorId,ReferenceNumber,Date,TxnNumber,DueDate,Terms,TermsId,AccountsPayable,AccountsPayableId,Amount,Memo,IsPaid,IsTaxIncluded,ItemLineId,ItemLineNumber,ItemName,ItemId,ItemGroup,ItemGroupId,ItemDescription,ItemQuantity,ItemUnitOfMeasure,ItemCost,ItemAmount,ItemBillableStatus,ItemCustomer,ItemCustomerId,ItemInventorySiteId,ItemInventorySiteName,ItemInventorySiteLocationId,ItemInventorySiteLocationName,ItemSerialNumber,ItemLotNumber,ItemClass,ItemClassId,ItemTaxCode,ItemTaxCodeId,ItemCustomFields,CurrencyName,CurrencyId,ExchangeRate,TimeModified,TimeCreated,OpenAmount";
    }
}