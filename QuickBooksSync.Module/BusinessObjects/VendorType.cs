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
    public class VendorType : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public VendorType(Session session)
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
        private String? _FullName;
        public String? FullName
        {
            get => _FullName;
            set => SetPropertyValue(nameof(FullName), ref _FullName, value);
        }  
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String? _ParentRefFullName;
        public String? ParentRefFullName
        {
            get => _ParentRefFullName;
            set => SetPropertyValue(nameof(ParentRefFullName), ref _ParentRefFullName, value);
        }  
        private String? _ParentRefListId;
        public String? ParentRefListId
        {
            get => _ParentRefListId;
            set => SetPropertyValue(nameof(ParentRefListId), ref _ParentRefListId, value);
        }  
        private Int32 _Sublevel;
        public Int32 Sublevel
        {
            get => _Sublevel;
            set => SetPropertyValue(nameof(Sublevel), ref _Sublevel, value);
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
        private string _ParentRefList;
        public string ParentRefList
        {
            get => _ParentRefList;
            set => SetPropertyValue(nameof(ParentRefList), ref _ParentRefList, value);
        }
       
    }
}