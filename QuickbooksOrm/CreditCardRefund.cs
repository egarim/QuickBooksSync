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
    public class CreditCardRefund : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CreditCardRefund(Session session)
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
        private DateTime _TxnDate;
        public DateTime TxnDate
        {
            get => _TxnDate;
            set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
        }  
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String? _RefNumber;
        public String? RefNumber
        {
            get => _RefNumber;
            set => SetPropertyValue(nameof(RefNumber), ref _RefNumber, value);
        }  
        private String? _CustomerRefListId;
        public String? CustomerRefListId
        {
            get => _CustomerRefListId;
            set => SetPropertyValue(nameof(CustomerRefListId), ref _CustomerRefListId, value);
        }  
        private String? _CustomerRefFullName;
        public String? CustomerRefFullName
        {
            get => _CustomerRefFullName;
            set => SetPropertyValue(nameof(CustomerRefFullName), ref _CustomerRefFullName, value);
        }  
        private String? _RefundFromAccountRefListId;
        public String? RefundFromAccountRefListId
        {
            get => _RefundFromAccountRefListId;
            set => SetPropertyValue(nameof(RefundFromAccountRefListId), ref _RefundFromAccountRefListId, value);
        }  
        private String? _RefundFromAccountRefFullName;
        public String? RefundFromAccountRefFullName
        {
            get => _RefundFromAccountRefFullName;
            set => SetPropertyValue(nameof(RefundFromAccountRefFullName), ref _RefundFromAccountRefFullName, value);
        }  
        private String? _AraccountRefListId;
        public String? AraccountRefListId
        {
            get => _AraccountRefListId;
            set => SetPropertyValue(nameof(AraccountRefListId), ref _AraccountRefListId, value);
        }  
        private String? _AraccountRefFullName;
        public String? AraccountRefFullName
        {
            get => _AraccountRefFullName;
            set => SetPropertyValue(nameof(AraccountRefFullName), ref _AraccountRefFullName, value);
        }  
        private Decimal _TotalAmount;
        public Decimal TotalAmount
        {
            get => _TotalAmount;
            set => SetPropertyValue(nameof(TotalAmount), ref _TotalAmount, value);
        }  
        private Decimal _TotalAmountInHomeCurrency;
        public Decimal TotalAmountInHomeCurrency
        {
            get => _TotalAmountInHomeCurrency;
            set => SetPropertyValue(nameof(TotalAmountInHomeCurrency), ref _TotalAmountInHomeCurrency, value);
        }  
        private String? _AddressAddr1;
        public String? AddressAddr1
        {
            get => _AddressAddr1;
            set => SetPropertyValue(nameof(AddressAddr1), ref _AddressAddr1, value);
        }  
        private String? _AddressAddr2;
        public String? AddressAddr2
        {
            get => _AddressAddr2;
            set => SetPropertyValue(nameof(AddressAddr2), ref _AddressAddr2, value);
        }  
        private String? _AddressAddr3;
        public String? AddressAddr3
        {
            get => _AddressAddr3;
            set => SetPropertyValue(nameof(AddressAddr3), ref _AddressAddr3, value);
        }  
        private String? _AddressAddr4;
        public String? AddressAddr4
        {
            get => _AddressAddr4;
            set => SetPropertyValue(nameof(AddressAddr4), ref _AddressAddr4, value);
        }  
        private String? _AddressAddr5;
        public String? AddressAddr5
        {
            get => _AddressAddr5;
            set => SetPropertyValue(nameof(AddressAddr5), ref _AddressAddr5, value);
        }  
        private String? _AddressCity;
        public String? AddressCity
        {
            get => _AddressCity;
            set => SetPropertyValue(nameof(AddressCity), ref _AddressCity, value);
        }  
        private String? _AddressState;
        public String? AddressState
        {
            get => _AddressState;
            set => SetPropertyValue(nameof(AddressState), ref _AddressState, value);
        }  
        private String? _AddressPostalCode;
        public String? AddressPostalCode
        {
            get => _AddressPostalCode;
            set => SetPropertyValue(nameof(AddressPostalCode), ref _AddressPostalCode, value);
        }  
        private String? _AddressCountry;
        public String? AddressCountry
        {
            get => _AddressCountry;
            set => SetPropertyValue(nameof(AddressCountry), ref _AddressCountry, value);
        }  
        private String? _AddressNote;
        public String? AddressNote
        {
            get => _AddressNote;
            set => SetPropertyValue(nameof(AddressNote), ref _AddressNote, value);
        }  
        private String? _PaymentMethodRefListId;
        public String? PaymentMethodRefListId
        {
            get => _PaymentMethodRefListId;
            set => SetPropertyValue(nameof(PaymentMethodRefListId), ref _PaymentMethodRefListId, value);
        }  
        private String? _PaymentMethodRefFullName;
        public String? PaymentMethodRefFullName
        {
            get => _PaymentMethodRefFullName;
            set => SetPropertyValue(nameof(PaymentMethodRefFullName), ref _PaymentMethodRefFullName, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String? _RefundAppliedToTxnAggregate;
        public String? RefundAppliedToTxnAggregate
        {
            get => _RefundAppliedToTxnAggregate;
            set => SetPropertyValue(nameof(RefundAppliedToTxnAggregate), ref _RefundAppliedToTxnAggregate, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber), ref _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber, value);
        }  
        private Int32 _CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth;
        public Int32 CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth), ref _CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth, value);
        }  
        private Int32 _CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear;
        public Int32 CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear), ref _CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard), ref _CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress), ref _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode), ref _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode), ref _CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode), ref _CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType;
        public String? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType
        {
            get => _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType), ref _CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType, value);
        }  
        private Int32 _CreditCardTxnInfoCreditCardTxnResultInfoResultCode;
        public Int32 CreditCardTxnInfoCreditCardTxnResultInfoResultCode
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoResultCode;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoResultCode), ref _CreditCardTxnInfoCreditCardTxnResultInfoResultCode, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoResultMessage;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoResultMessage
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoResultMessage;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoResultMessage), ref _CreditCardTxnInfoCreditCardTxnResultInfoResultMessage, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId), ref _CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber), ref _CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode), ref _CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet), ref _CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoAvszip;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoAvszip
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoAvszip;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoAvszip), ref _CreditCardTxnInfoCreditCardTxnResultInfoAvszip, value);
        }  
        private String? _CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch;
        public String? CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch), ref _CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch, value);
        }  
        private DateTime _CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime;
        public DateTime CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime
        {
            get => _CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime;
            set => SetPropertyValue(nameof(CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime), ref _CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String? _CurrencyRefListId;
        public String? CurrencyRefListId
        {
            get => _CurrencyRefListId;
            set => SetPropertyValue(nameof(CurrencyRefListId), ref _CurrencyRefListId, value);
        }  
        private String? _CurrencyRefName;
        public String? CurrencyRefName
        {
            get => _CurrencyRefName;
            set => SetPropertyValue(nameof(CurrencyRefName), ref _CurrencyRefName, value);
        }  
        private Decimal _ExchangeRate;
        public Decimal ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private DateTime _TimeCreated;
        public DateTime TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime _TimeModified;
        public DateTime TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }  
        private string _AraccountRefList;
        public string AraccountRefList
        {
            get => _AraccountRefList;
            set => SetPropertyValue(nameof(AraccountRefList), ref _AraccountRefList, value);
        }  
        private string _CustomerRefList;
        public string CustomerRefList
        {
            get => _CustomerRefList;
            set => SetPropertyValue(nameof(CustomerRefList), ref _CustomerRefList, value);
        }  
        private string _PaymentMethodRefList;
        public string PaymentMethodRefList
        {
            get => _PaymentMethodRefList;
            set => SetPropertyValue(nameof(PaymentMethodRefList), ref _PaymentMethodRefList, value);
        }  
        private string _RefundFromAccountRefList;
        public string RefundFromAccountRefList
        {
            get => _RefundFromAccountRefList;
            set => SetPropertyValue(nameof(RefundFromAccountRefList), ref _RefundFromAccountRefList, value);
        }
        public const string QueriableProperties="Id,TxnDate,TxnNumber,RefNumber,CustomerRefListId,CustomerRefFullName,RefundFromAccountRefListId,RefundFromAccountRefFullName,AraccountRefListId,AraccountRefFullName,TotalAmount,TotalAmountInHomeCurrency,AddressAddr1,AddressAddr2,AddressAddr3,AddressAddr4,AddressAddr5,AddressCity,AddressState,AddressPostalCode,AddressCountry,AddressNote,PaymentMethodRefListId,PaymentMethodRefFullName,Memo,RefundAppliedToTxnAggregate,CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber,CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth,CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear,CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard,CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress,CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode,CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode,CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode,CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType,CreditCardTxnInfoCreditCardTxnResultInfoResultCode,CreditCardTxnInfoCreditCardTxnResultInfoResultMessage,CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId,CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber,CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode,CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet,CreditCardTxnInfoCreditCardTxnResultInfoAvszip,CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch,CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime,CustomFields,CurrencyRefListId,CurrencyRefName,ExchangeRate,TimeCreated,TimeModified,EditSequence,AraccountRefList,CustomerRefList,PaymentMethodRefList,RefundFromAccountRefList";
    }
}