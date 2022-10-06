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
    public class InventorySite : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public InventorySite(Session session)
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
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String? _SiteDesc;
        public String? SiteDesc
        {
            get => _SiteDesc;
            set => SetPropertyValue(nameof(SiteDesc), ref _SiteDesc, value);
        }  
        private String? _Contact;
        public String? Contact
        {
            get => _Contact;
            set => SetPropertyValue(nameof(Contact), ref _Contact, value);
        }  
        private String? _Phone;
        public String? Phone
        {
            get => _Phone;
            set => SetPropertyValue(nameof(Phone), ref _Phone, value);
        }  
        private String? _Fax;
        public String? Fax
        {
            get => _Fax;
            set => SetPropertyValue(nameof(Fax), ref _Fax, value);
        }  
        private String? _Email;
        public String? Email
        {
            get => _Email;
            set => SetPropertyValue(nameof(Email), ref _Email, value);
        }  
        private String? _SiteAddressAddr1;
        public String? SiteAddressAddr1
        {
            get => _SiteAddressAddr1;
            set => SetPropertyValue(nameof(SiteAddressAddr1), ref _SiteAddressAddr1, value);
        }  
        private String? _SiteAddressAddr2;
        public String? SiteAddressAddr2
        {
            get => _SiteAddressAddr2;
            set => SetPropertyValue(nameof(SiteAddressAddr2), ref _SiteAddressAddr2, value);
        }  
        private String? _SiteAddressAddr3;
        public String? SiteAddressAddr3
        {
            get => _SiteAddressAddr3;
            set => SetPropertyValue(nameof(SiteAddressAddr3), ref _SiteAddressAddr3, value);
        }  
        private String? _SiteAddressAddr4;
        public String? SiteAddressAddr4
        {
            get => _SiteAddressAddr4;
            set => SetPropertyValue(nameof(SiteAddressAddr4), ref _SiteAddressAddr4, value);
        }  
        private String? _SiteAddressAddr5;
        public String? SiteAddressAddr5
        {
            get => _SiteAddressAddr5;
            set => SetPropertyValue(nameof(SiteAddressAddr5), ref _SiteAddressAddr5, value);
        }  
        private String? _SiteAddressCity;
        public String? SiteAddressCity
        {
            get => _SiteAddressCity;
            set => SetPropertyValue(nameof(SiteAddressCity), ref _SiteAddressCity, value);
        }  
        private String? _SiteAddressState;
        public String? SiteAddressState
        {
            get => _SiteAddressState;
            set => SetPropertyValue(nameof(SiteAddressState), ref _SiteAddressState, value);
        }  
        private String? _SiteAddressPostalCode;
        public String? SiteAddressPostalCode
        {
            get => _SiteAddressPostalCode;
            set => SetPropertyValue(nameof(SiteAddressPostalCode), ref _SiteAddressPostalCode, value);
        }  
        private String? _SiteAddressCountry;
        public String? SiteAddressCountry
        {
            get => _SiteAddressCountry;
            set => SetPropertyValue(nameof(SiteAddressCountry), ref _SiteAddressCountry, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        private Boolean _IsDefaultSite;
        public Boolean IsDefaultSite
        {
            get => _IsDefaultSite;
            set => SetPropertyValue(nameof(IsDefaultSite), ref _IsDefaultSite, value);
        }
       
    }
}