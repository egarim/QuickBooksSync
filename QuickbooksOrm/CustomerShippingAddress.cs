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
    public class CustomerShippingAddress : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CustomerShippingAddress(Session session)
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
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
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
        private String _ShipToName;
        [Size(300)]
        public String ShipToName
        {
            get => _ShipToName;
            set => SetPropertyValue(nameof(ShipToName), ref _ShipToName, value);
        }  
        private String _ShipToAddr1;
        [Size(300)]
        public String ShipToAddr1
        {
            get => _ShipToAddr1;
            set => SetPropertyValue(nameof(ShipToAddr1), ref _ShipToAddr1, value);
        }  
        private String _ShipToAddr2;
        [Size(300)]
        public String ShipToAddr2
        {
            get => _ShipToAddr2;
            set => SetPropertyValue(nameof(ShipToAddr2), ref _ShipToAddr2, value);
        }  
        private String _ShipToAddr3;
        [Size(300)]
        public String ShipToAddr3
        {
            get => _ShipToAddr3;
            set => SetPropertyValue(nameof(ShipToAddr3), ref _ShipToAddr3, value);
        }  
        private String _ShipToAddr4;
        [Size(300)]
        public String ShipToAddr4
        {
            get => _ShipToAddr4;
            set => SetPropertyValue(nameof(ShipToAddr4), ref _ShipToAddr4, value);
        }  
        private String _ShipToAddr5;
        [Size(300)]
        public String ShipToAddr5
        {
            get => _ShipToAddr5;
            set => SetPropertyValue(nameof(ShipToAddr5), ref _ShipToAddr5, value);
        }  
        private String _ShipToCity;
        [Size(300)]
        public String ShipToCity
        {
            get => _ShipToCity;
            set => SetPropertyValue(nameof(ShipToCity), ref _ShipToCity, value);
        }  
        private String _ShipToState;
        [Size(300)]
        public String ShipToState
        {
            get => _ShipToState;
            set => SetPropertyValue(nameof(ShipToState), ref _ShipToState, value);
        }  
        private String _ShipToPostalCode;
        [Size(300)]
        public String ShipToPostalCode
        {
            get => _ShipToPostalCode;
            set => SetPropertyValue(nameof(ShipToPostalCode), ref _ShipToPostalCode, value);
        }  
        private String _ShipToCountry;
        [Size(300)]
        public String ShipToCountry
        {
            get => _ShipToCountry;
            set => SetPropertyValue(nameof(ShipToCountry), ref _ShipToCountry, value);
        }  
        private String _ShipToNote;
        [Size(300)]
        public String ShipToNote
        {
            get => _ShipToNote;
            set => SetPropertyValue(nameof(ShipToNote), ref _ShipToNote, value);
        }  
        private Boolean? _ShipToDefaultShipTo;
        public Boolean? ShipToDefaultShipTo
        {
            get => _ShipToDefaultShipTo;
            set => SetPropertyValue(nameof(ShipToDefaultShipTo), ref _ShipToDefaultShipTo, value);
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
        public const string QueryableProperties="Id,CustomerId,Name,FullName,ShipToName,ShipToAddr1,ShipToAddr2,ShipToAddr3,ShipToAddr4,ShipToAddr5,ShipToCity,ShipToState,ShipToPostalCode,ShipToCountry,ShipToNote,ShipToDefaultShipTo,EditSequence,TimeModified,TimeCreated";
        public const string QuickbooksTableName="CustomerShippingAddresses";
    }
}