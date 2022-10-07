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
    public class CreditMemo : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CreditMemo(Session session)
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
        private String _AccountsReceivable;
        [Size(300)]
        public String AccountsReceivable
        {
            get => _AccountsReceivable;
            set => SetPropertyValue(nameof(AccountsReceivable), ref _AccountsReceivable, value);
        }  
        private String _AccountsReceivableId;
        [Size(300)]
        public String AccountsReceivableId
        {
            get => _AccountsReceivableId;
            set => SetPropertyValue(nameof(AccountsReceivableId), ref _AccountsReceivableId, value);
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
        private Boolean? _IsPending;
        public Boolean? IsPending
        {
            get => _IsPending;
            set => SetPropertyValue(nameof(IsPending), ref _IsPending, value);
        }  
        private Boolean? _IsToBeEmailed;
        public Boolean? IsToBeEmailed
        {
            get => _IsToBeEmailed;
            set => SetPropertyValue(nameof(IsToBeEmailed), ref _IsToBeEmailed, value);
        }  
        private Boolean? _IsToBePrinted;
        public Boolean? IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
        }  
        private Boolean? _IsTaxIncluded;
        public Boolean? IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String _Ponumber;
        [Size(300)]
        public String Ponumber
        {
            get => _Ponumber;
            set => SetPropertyValue(nameof(Ponumber), ref _Ponumber, value);
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
        private Single? _CreditRemaining;
        public Single? CreditRemaining
        {
            get => _CreditRemaining;
            set => SetPropertyValue(nameof(CreditRemaining), ref _CreditRemaining, value);
        }  
        private DateTime? _DueDate;
        public DateTime? DueDate
        {
            get => _DueDate;
            set => SetPropertyValue(nameof(DueDate), ref _DueDate, value);
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
        private String _CustomerSalesTax;
        [Size(300)]
        public String CustomerSalesTax
        {
            get => _CustomerSalesTax;
            set => SetPropertyValue(nameof(CustomerSalesTax), ref _CustomerSalesTax, value);
        }  
        private String _CustomerSalesTaxId;
        [Size(300)]
        public String CustomerSalesTaxId
        {
            get => _CustomerSalesTaxId;
            set => SetPropertyValue(nameof(CustomerSalesTaxId), ref _CustomerSalesTaxId, value);
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
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private Int32? _ItemCount;
        public Int32? ItemCount
        {
            get => _ItemCount;
            set => SetPropertyValue(nameof(ItemCount), ref _ItemCount, value);
        }  
        private String _ItemAggregate;
        [Size(300)]
        public String ItemAggregate
        {
            get => _ItemAggregate;
            set => SetPropertyValue(nameof(ItemAggregate), ref _ItemAggregate, value);
        }  
        private Int32? _TransactionCount;
        public Int32? TransactionCount
        {
            get => _TransactionCount;
            set => SetPropertyValue(nameof(TransactionCount), ref _TransactionCount, value);
        }  
        private String _TransactionAggregate;
        [Size(300)]
        public String TransactionAggregate
        {
            get => _TransactionAggregate;
            set => SetPropertyValue(nameof(TransactionAggregate), ref _TransactionAggregate, value);
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
        public const string QueryableProperties="Id,ReferenceNumber,TxnNumber,Date,CustomerName,CustomerId,AccountsReceivable,AccountsReceivableId,ShipMethod,ShipMethodId,ShipDate,Memo,Amount,Message,MessageId,SalesRep,SalesRepId,Fob,BillingAddress,BillingLine1,BillingLine2,BillingLine3,BillingLine4,BillingLine5,BillingCity,BillingState,BillingPostalCode,BillingCountry,BillingNote,ShippingAddress,ShippingLine1,ShippingLine2,ShippingLine3,ShippingLine4,ShippingLine5,ShippingCity,ShippingState,ShippingPostalCode,ShippingCountry,ShippingNote,Subtotal,Tax,TaxItem,TaxItemId,TaxPercent,IsPending,IsToBeEmailed,IsToBePrinted,IsTaxIncluded,Ponumber,Terms,TermsId,CreditRemaining,DueDate,Template,TemplateId,CustomerSalesTax,CustomerSalesTaxId,Class,ClassId,ExchangeRate,ItemCount,ItemAggregate,TransactionCount,TransactionAggregate,CustomFields,EditSequence,TimeModified,TimeCreated";
    }
}