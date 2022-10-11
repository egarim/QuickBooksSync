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
    public class InvoiceLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public InvoiceLineItem(Session session)
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
        private String _InvoiceId;
        [Size(300)]
        public String InvoiceId
        {
            get => _InvoiceId;
            set => SetPropertyValue(nameof(InvoiceId), ref _InvoiceId, value);
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
        private String _CustomerName;
        [Size(300)]
        public String CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
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
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String _ShipMethod;
        [Size(300)]
        public String ShipMethod
        {
            get => _ShipMethod;
            set => SetPropertyValue(nameof(ShipMethod), ref _ShipMethod, value);
        }  
        private String _ShipMethodId;
        [Size(300)]
        public String ShipMethodId
        {
            get => _ShipMethodId;
            set => SetPropertyValue(nameof(ShipMethodId), ref _ShipMethodId, value);
        }  
        private DateTime? _ShipDate;
        public DateTime? ShipDate
        {
            get => _ShipDate;
            set => SetPropertyValue(nameof(ShipDate), ref _ShipDate, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
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
        private Decimal? _Amount;
        public Decimal? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String _Message;
        [Size(300)]
        public String Message
        {
            get => _Message;
            set => SetPropertyValue(nameof(Message), ref _Message, value);
        }  
        private String _MessageId;
        [Size(300)]
        public String MessageId
        {
            get => _MessageId;
            set => SetPropertyValue(nameof(MessageId), ref _MessageId, value);
        }  
        private String _SalesRep;
        [Size(300)]
        public String SalesRep
        {
            get => _SalesRep;
            set => SetPropertyValue(nameof(SalesRep), ref _SalesRep, value);
        }  
        private String _SalesRepId;
        [Size(300)]
        public String SalesRepId
        {
            get => _SalesRepId;
            set => SetPropertyValue(nameof(SalesRepId), ref _SalesRepId, value);
        }  
        private String _Fob;
        [Size(300)]
        public String Fob
        {
            get => _Fob;
            set => SetPropertyValue(nameof(Fob), ref _Fob, value);
        }  
        private String _BillingAddress;
        [Size(300)]
        public String BillingAddress
        {
            get => _BillingAddress;
            set => SetPropertyValue(nameof(BillingAddress), ref _BillingAddress, value);
        }  
        private String _BillingLine1;
        [Size(300)]
        public String BillingLine1
        {
            get => _BillingLine1;
            set => SetPropertyValue(nameof(BillingLine1), ref _BillingLine1, value);
        }  
        private String _BillingLine2;
        [Size(300)]
        public String BillingLine2
        {
            get => _BillingLine2;
            set => SetPropertyValue(nameof(BillingLine2), ref _BillingLine2, value);
        }  
        private String _BillingLine3;
        [Size(300)]
        public String BillingLine3
        {
            get => _BillingLine3;
            set => SetPropertyValue(nameof(BillingLine3), ref _BillingLine3, value);
        }  
        private String _BillingLine4;
        [Size(300)]
        public String BillingLine4
        {
            get => _BillingLine4;
            set => SetPropertyValue(nameof(BillingLine4), ref _BillingLine4, value);
        }  
        private String _BillingLine5;
        [Size(300)]
        public String BillingLine5
        {
            get => _BillingLine5;
            set => SetPropertyValue(nameof(BillingLine5), ref _BillingLine5, value);
        }  
        private String _BillingCity;
        [Size(300)]
        public String BillingCity
        {
            get => _BillingCity;
            set => SetPropertyValue(nameof(BillingCity), ref _BillingCity, value);
        }  
        private String _BillingState;
        [Size(300)]
        public String BillingState
        {
            get => _BillingState;
            set => SetPropertyValue(nameof(BillingState), ref _BillingState, value);
        }  
        private String _BillingPostalCode;
        [Size(300)]
        public String BillingPostalCode
        {
            get => _BillingPostalCode;
            set => SetPropertyValue(nameof(BillingPostalCode), ref _BillingPostalCode, value);
        }  
        private String _BillingCountry;
        [Size(300)]
        public String BillingCountry
        {
            get => _BillingCountry;
            set => SetPropertyValue(nameof(BillingCountry), ref _BillingCountry, value);
        }  
        private String _BillingNote;
        [Size(300)]
        public String BillingNote
        {
            get => _BillingNote;
            set => SetPropertyValue(nameof(BillingNote), ref _BillingNote, value);
        }  
        private String _ShippingAddress;
        [Size(300)]
        public String ShippingAddress
        {
            get => _ShippingAddress;
            set => SetPropertyValue(nameof(ShippingAddress), ref _ShippingAddress, value);
        }  
        private String _ShippingLine1;
        [Size(300)]
        public String ShippingLine1
        {
            get => _ShippingLine1;
            set => SetPropertyValue(nameof(ShippingLine1), ref _ShippingLine1, value);
        }  
        private String _ShippingLine2;
        [Size(300)]
        public String ShippingLine2
        {
            get => _ShippingLine2;
            set => SetPropertyValue(nameof(ShippingLine2), ref _ShippingLine2, value);
        }  
        private String _ShippingLine3;
        [Size(300)]
        public String ShippingLine3
        {
            get => _ShippingLine3;
            set => SetPropertyValue(nameof(ShippingLine3), ref _ShippingLine3, value);
        }  
        private String _ShippingLine4;
        [Size(300)]
        public String ShippingLine4
        {
            get => _ShippingLine4;
            set => SetPropertyValue(nameof(ShippingLine4), ref _ShippingLine4, value);
        }  
        private String _ShippingLine5;
        [Size(300)]
        public String ShippingLine5
        {
            get => _ShippingLine5;
            set => SetPropertyValue(nameof(ShippingLine5), ref _ShippingLine5, value);
        }  
        private String _ShippingCity;
        [Size(300)]
        public String ShippingCity
        {
            get => _ShippingCity;
            set => SetPropertyValue(nameof(ShippingCity), ref _ShippingCity, value);
        }  
        private String _ShippingState;
        [Size(300)]
        public String ShippingState
        {
            get => _ShippingState;
            set => SetPropertyValue(nameof(ShippingState), ref _ShippingState, value);
        }  
        private String _ShippingPostalCode;
        [Size(300)]
        public String ShippingPostalCode
        {
            get => _ShippingPostalCode;
            set => SetPropertyValue(nameof(ShippingPostalCode), ref _ShippingPostalCode, value);
        }  
        private String _ShippingCountry;
        [Size(300)]
        public String ShippingCountry
        {
            get => _ShippingCountry;
            set => SetPropertyValue(nameof(ShippingCountry), ref _ShippingCountry, value);
        }  
        private String _ShippingNote;
        [Size(300)]
        public String ShippingNote
        {
            get => _ShippingNote;
            set => SetPropertyValue(nameof(ShippingNote), ref _ShippingNote, value);
        }  
        private Decimal? _Subtotal;
        public Decimal? Subtotal
        {
            get => _Subtotal;
            set => SetPropertyValue(nameof(Subtotal), ref _Subtotal, value);
        }  
        private Single? _Tax;
        public Single? Tax
        {
            get => _Tax;
            set => SetPropertyValue(nameof(Tax), ref _Tax, value);
        }  
        private String _TaxItem;
        [Size(300)]
        public String TaxItem
        {
            get => _TaxItem;
            set => SetPropertyValue(nameof(TaxItem), ref _TaxItem, value);
        }  
        private String _TaxItemId;
        [Size(300)]
        public String TaxItemId
        {
            get => _TaxItemId;
            set => SetPropertyValue(nameof(TaxItemId), ref _TaxItemId, value);
        }  
        private Single? _TaxPercent;
        public Single? TaxPercent
        {
            get => _TaxPercent;
            set => SetPropertyValue(nameof(TaxPercent), ref _TaxPercent, value);
        }  
        private String _Ponumber;
        [Size(300)]
        public String Ponumber
        {
            get => _Ponumber;
            set => SetPropertyValue(nameof(Ponumber), ref _Ponumber, value);
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
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        private String _ItemUnitOfMeasure;
        [Size(300)]
        public String ItemUnitOfMeasure
        {
            get => _ItemUnitOfMeasure;
            set => SetPropertyValue(nameof(ItemUnitOfMeasure), ref _ItemUnitOfMeasure, value);
        }  
        private Single? _ItemQuantity;
        public Single? ItemQuantity
        {
            get => _ItemQuantity;
            set => SetPropertyValue(nameof(ItemQuantity), ref _ItemQuantity, value);
        }  
        private Single? _ItemRate;
        public Single? ItemRate
        {
            get => _ItemRate;
            set => SetPropertyValue(nameof(ItemRate), ref _ItemRate, value);
        }  
        private Single? _ItemRatePercent;
        public Single? ItemRatePercent
        {
            get => _ItemRatePercent;
            set => SetPropertyValue(nameof(ItemRatePercent), ref _ItemRatePercent, value);
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
        private Decimal? _ItemAmount;
        public Decimal? ItemAmount
        {
            get => _ItemAmount;
            set => SetPropertyValue(nameof(ItemAmount), ref _ItemAmount, value);
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
        private DateTime? _ItemServiceDate;
        public DateTime? ItemServiceDate
        {
            get => _ItemServiceDate;
            set => SetPropertyValue(nameof(ItemServiceDate), ref _ItemServiceDate, value);
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
        private String _ItemOther1;
        [Size(300)]
        public String ItemOther1
        {
            get => _ItemOther1;
            set => SetPropertyValue(nameof(ItemOther1), ref _ItemOther1, value);
        }  
        private String _ItemOther2;
        [Size(300)]
        public String ItemOther2
        {
            get => _ItemOther2;
            set => SetPropertyValue(nameof(ItemOther2), ref _ItemOther2, value);
        }  
        private String _ItemCustomFields;
        [Size(300)]
        public String ItemCustomFields
        {
            get => _ItemCustomFields;
            set => SetPropertyValue(nameof(ItemCustomFields), ref _ItemCustomFields, value);
        }  
        private String _ItemUomsetFullName;
        [Size(300)]
        public String ItemUomsetFullName
        {
            get => _ItemUomsetFullName;
            set => SetPropertyValue(nameof(ItemUomsetFullName), ref _ItemUomsetFullName, value);
        }  
        private String _ItemUomsetListId;
        [Size(300)]
        public String ItemUomsetListId
        {
            get => _ItemUomsetListId;
            set => SetPropertyValue(nameof(ItemUomsetListId), ref _ItemUomsetListId, value);
        }  
        private String _ItemIsGetPrintItemsInGroup;
        [Size(300)]
        public String ItemIsGetPrintItemsInGroup
        {
            get => _ItemIsGetPrintItemsInGroup;
            set => SetPropertyValue(nameof(ItemIsGetPrintItemsInGroup), ref _ItemIsGetPrintItemsInGroup, value);
        }  
        private Decimal? _AppliedAmount;
        public Decimal? AppliedAmount
        {
            get => _AppliedAmount;
            set => SetPropertyValue(nameof(AppliedAmount), ref _AppliedAmount, value);
        }  
        private Decimal? _Balance;
        public Decimal? Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
        }  
        private String _CustomerTaxCode;
        [Size(300)]
        public String CustomerTaxCode
        {
            get => _CustomerTaxCode;
            set => SetPropertyValue(nameof(CustomerTaxCode), ref _CustomerTaxCode, value);
        }  
        private String _CustomerTaxCodeId;
        [Size(300)]
        public String CustomerTaxCodeId
        {
            get => _CustomerTaxCodeId;
            set => SetPropertyValue(nameof(CustomerTaxCodeId), ref _CustomerTaxCodeId, value);
        }  
        private Boolean? _IsToBePrinted;
        public Boolean? IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
        }  
        private Boolean? _IsToBeEmailed;
        public Boolean? IsToBeEmailed
        {
            get => _IsToBeEmailed;
            set => SetPropertyValue(nameof(IsToBeEmailed), ref _IsToBeEmailed, value);
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
        private Boolean? _IsPending;
        public Boolean? IsPending
        {
            get => _IsPending;
            set => SetPropertyValue(nameof(IsPending), ref _IsPending, value);
        }  
        private String _IsFinanceCharge;
        [Size(300)]
        public String IsFinanceCharge
        {
            get => _IsFinanceCharge;
            set => SetPropertyValue(nameof(IsFinanceCharge), ref _IsFinanceCharge, value);
        }  
        private String _Template;
        [Size(300)]
        public String Template
        {
            get => _Template;
            set => SetPropertyValue(nameof(Template), ref _Template, value);
        }  
        private String _TemplateId;
        [Size(300)]
        public String TemplateId
        {
            get => _TemplateId;
            set => SetPropertyValue(nameof(TemplateId), ref _TemplateId, value);
        }  
        private Decimal? _SuggestedDiscountAmount;
        public Decimal? SuggestedDiscountAmount
        {
            get => _SuggestedDiscountAmount;
            set => SetPropertyValue(nameof(SuggestedDiscountAmount), ref _SuggestedDiscountAmount, value);
        }  
        private DateTime? _SuggestedDiscountDate;
        public DateTime? SuggestedDiscountDate
        {
            get => _SuggestedDiscountDate;
            set => SetPropertyValue(nameof(SuggestedDiscountDate), ref _SuggestedDiscountDate, value);
        }  
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private Single? _BalanceInHomeCurrency;
        public Single? BalanceInHomeCurrency
        {
            get => _BalanceInHomeCurrency;
            set => SetPropertyValue(nameof(BalanceInHomeCurrency), ref _BalanceInHomeCurrency, value);
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
        private String _Other;
        [Size(300)]
        public String Other
        {
            get => _Other;
            set => SetPropertyValue(nameof(Other), ref _Other, value);
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
        public const string QueryableProperties="Id,InvoiceId,ReferenceNumber,TxnNumber,CustomerName,CustomerId,Account,AccountId,Date,ShipMethod,ShipMethodId,ShipDate,Memo,Class,ClassId,Amount,Message,MessageId,SalesRep,SalesRepId,Fob,BillingAddress,BillingLine1,BillingLine2,BillingLine3,BillingLine4,BillingLine5,BillingCity,BillingState,BillingPostalCode,BillingCountry,BillingNote,ShippingAddress,ShippingLine1,ShippingLine2,ShippingLine3,ShippingLine4,ShippingLine5,ShippingCity,ShippingState,ShippingPostalCode,ShippingCountry,ShippingNote,Subtotal,Tax,TaxItem,TaxItemId,TaxPercent,Ponumber,DueDate,Terms,TermsId,CustomFields,ItemLineId,ItemLineNumber,ItemName,ItemId,ItemGroup,ItemGroupId,ItemDescription,ItemUnitOfMeasure,ItemQuantity,ItemRate,ItemRatePercent,ItemTaxCode,ItemTaxCodeId,ItemAmount,ItemClass,ItemClassId,ItemServiceDate,ItemInventorySiteId,ItemInventorySiteName,ItemInventorySiteLocationId,ItemInventorySiteLocationName,ItemSerialNumber,ItemLotNumber,ItemOther1,ItemOther2,ItemCustomFields,ItemUomsetFullName,ItemUomsetListId,ItemIsGetPrintItemsInGroup,AppliedAmount,Balance,CustomerTaxCode,CustomerTaxCodeId,IsToBePrinted,IsToBeEmailed,IsPaid,IsTaxIncluded,IsPending,IsFinanceCharge,Template,TemplateId,SuggestedDiscountAmount,SuggestedDiscountDate,ExchangeRate,BalanceInHomeCurrency,CurrencyName,CurrencyId,Other,EditSequence,TimeModified,TimeCreated";
        public const string QuickbooksTableName="InvoiceLineItems";
    }
}