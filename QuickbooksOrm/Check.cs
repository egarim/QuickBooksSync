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
    public class Check : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Check(Session session)
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
        private String _Payee;
        [Size(300)]
        public String Payee
        {
            get => _Payee;
            set => SetPropertyValue(nameof(Payee), ref _Payee, value);
        }  
        private String _PayeeId;
        [Size(300)]
        public String PayeeId
        {
            get => _PayeeId;
            set => SetPropertyValue(nameof(PayeeId), ref _PayeeId, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
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
        private String _Address;
        [Size(300)]
        public String Address
        {
            get => _Address;
            set => SetPropertyValue(nameof(Address), ref _Address, value);
        }  
        private String _Line1;
        [Size(300)]
        public String Line1
        {
            get => _Line1;
            set => SetPropertyValue(nameof(Line1), ref _Line1, value);
        }  
        private String _Line2;
        [Size(300)]
        public String Line2
        {
            get => _Line2;
            set => SetPropertyValue(nameof(Line2), ref _Line2, value);
        }  
        private String _Line3;
        [Size(300)]
        public String Line3
        {
            get => _Line3;
            set => SetPropertyValue(nameof(Line3), ref _Line3, value);
        }  
        private String _Line4;
        [Size(300)]
        public String Line4
        {
            get => _Line4;
            set => SetPropertyValue(nameof(Line4), ref _Line4, value);
        }  
        private String _Line5;
        [Size(300)]
        public String Line5
        {
            get => _Line5;
            set => SetPropertyValue(nameof(Line5), ref _Line5, value);
        }  
        private String _City;
        [Size(300)]
        public String City
        {
            get => _City;
            set => SetPropertyValue(nameof(City), ref _City, value);
        }  
        private String _State;
        [Size(300)]
        public String State
        {
            get => _State;
            set => SetPropertyValue(nameof(State), ref _State, value);
        }  
        private String _PostalCode;
        [Size(300)]
        public String PostalCode
        {
            get => _PostalCode;
            set => SetPropertyValue(nameof(PostalCode), ref _PostalCode, value);
        }  
        private String _Country;
        [Size(300)]
        public String Country
        {
            get => _Country;
            set => SetPropertyValue(nameof(Country), ref _Country, value);
        }  
        private String _Note;
        [Size(300)]
        public String Note
        {
            get => _Note;
            set => SetPropertyValue(nameof(Note), ref _Note, value);
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
        private Int32? _ExpenseItemCount;
        public Int32? ExpenseItemCount
        {
            get => _ExpenseItemCount;
            set => SetPropertyValue(nameof(ExpenseItemCount), ref _ExpenseItemCount, value);
        }  
        private String _ExpenseItemAggregate;
        [Size(300)]
        public String ExpenseItemAggregate
        {
            get => _ExpenseItemAggregate;
            set => SetPropertyValue(nameof(ExpenseItemAggregate), ref _ExpenseItemAggregate, value);
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
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        public const string QueryableProperties="Id,ReferenceNumber,TxnNumber,Account,AccountId,Payee,PayeeId,Date,Amount,Memo,Address,Line1,Line2,Line3,Line4,Line5,City,State,PostalCode,Country,Note,ItemCount,ItemAggregate,ExpenseItemCount,ExpenseItemAggregate,IsToBePrinted,IsTaxIncluded,CurrencyName,CurrencyId,ExchangeRate,CustomFields,TimeModified,TimeCreated";
    }
}