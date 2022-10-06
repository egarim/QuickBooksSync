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
    public class SalesTaxItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public SalesTaxItem(Session session)
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
        private String? _ClassRefFullName;
        public String? ClassRefFullName
        {
            get => _ClassRefFullName;
            set => SetPropertyValue(nameof(ClassRefFullName), ref _ClassRefFullName, value);
        }  
        private String? _ClassRefListId;
        public String? ClassRefListId
        {
            get => _ClassRefListId;
            set => SetPropertyValue(nameof(ClassRefListId), ref _ClassRefListId, value);
        }  
        private String? _ItemDesc;
        public String? ItemDesc
        {
            get => _ItemDesc;
            set => SetPropertyValue(nameof(ItemDesc), ref _ItemDesc, value);
        }  
        private Single _TaxRate;
        public Single TaxRate
        {
            get => _TaxRate;
            set => SetPropertyValue(nameof(TaxRate), ref _TaxRate, value);
        }  
        private String? _TaxVendorRefFullName;
        public String? TaxVendorRefFullName
        {
            get => _TaxVendorRefFullName;
            set => SetPropertyValue(nameof(TaxVendorRefFullName), ref _TaxVendorRefFullName, value);
        }  
        private String? _TaxVendorRefListId;
        public String? TaxVendorRefListId
        {
            get => _TaxVendorRefListId;
            set => SetPropertyValue(nameof(TaxVendorRefListId), ref _TaxVendorRefListId, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        private string _ClassRefList;
        public string ClassRefList
        {
            get => _ClassRefList;
            set => SetPropertyValue(nameof(ClassRefList), ref _ClassRefList, value);
        }  
        private string _TaxVendorRefList;
        public string TaxVendorRefList
        {
            get => _TaxVendorRefList;
            set => SetPropertyValue(nameof(TaxVendorRefList), ref _TaxVendorRefList, value);
        }
        public const string QueriableProperties="Id,Name,IsActive,ClassRefFullName,ClassRefListId,ItemDesc,TaxRate,TaxVendorRefFullName,TaxVendorRefListId,CustomFields,EditSequence,TimeModified,TimeCreated,ClassRefList,TaxVendorRefList";
    }
}