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
    public class UnitOfMeasure : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public UnitOfMeasure(Session session)
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
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String _UnitOfMeasureType;
        [Size(300)]
        public String UnitOfMeasureType
        {
            get => _UnitOfMeasureType;
            set => SetPropertyValue(nameof(UnitOfMeasureType), ref _UnitOfMeasureType, value);
        }  
        private String _BaseUnitName;
        [Size(300)]
        public String BaseUnitName
        {
            get => _BaseUnitName;
            set => SetPropertyValue(nameof(BaseUnitName), ref _BaseUnitName, value);
        }  
        private String _BaseUnitAbbreviation;
        [Size(300)]
        public String BaseUnitAbbreviation
        {
            get => _BaseUnitAbbreviation;
            set => SetPropertyValue(nameof(BaseUnitAbbreviation), ref _BaseUnitAbbreviation, value);
        }  
        private String _RelatedUnitAggregate;
        [Size(300)]
        public String RelatedUnitAggregate
        {
            get => _RelatedUnitAggregate;
            set => SetPropertyValue(nameof(RelatedUnitAggregate), ref _RelatedUnitAggregate, value);
        }  
        private String _DefaultUnitAggregate;
        [Size(300)]
        public String DefaultUnitAggregate
        {
            get => _DefaultUnitAggregate;
            set => SetPropertyValue(nameof(DefaultUnitAggregate), ref _DefaultUnitAggregate, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }
        public const string QueryableProperties="Id,Name,IsActive,UnitOfMeasureType,BaseUnitName,BaseUnitAbbreviation,RelatedUnitAggregate,DefaultUnitAggregate,EditSequence,TimeCreated,TimeModified";
    }
}