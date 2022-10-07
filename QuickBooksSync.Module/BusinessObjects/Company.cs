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
using XafWinBackgroundWorker.Module.BusinessObjects;

namespace QuickBooksSync.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Configuration")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Company : BaseObject, IReportProgress
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string syncTime;
        int max;
        int progress;
        ScheduleBase schedule;
        string targetDb;
        string filePath;
        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }


        public string FilePath
        {
            get => filePath;
            set => SetPropertyValue(nameof(FilePath), ref filePath, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SyncTime
        {
            get => syncTime;
            set => SetPropertyValue(nameof(SyncTime), ref syncTime, value);
        }
        //[ModelDefault("RowCount","3")]
        [Size(100)]
        public string TargetDb
        {
            get => targetDb;
            set => SetPropertyValue(nameof(TargetDb), ref targetDb, value);
        }

        public ScheduleBase Schedule
        {
            get => schedule;
            set => SetPropertyValue(nameof(Schedule), ref schedule, value);
        }
        [ModelDefault(nameof(IModelCommonMemberViewItem.PropertyEditorType), "XafWinBackgroundWorker.Module.Win.Editors.ProgressBarPropertyEditor")]
        public int Progress
        {
            get => progress;
            set => SetPropertyValue(nameof(Progress), ref progress, value);
        }
        [Browsable(false)]
        [NonPersistent()]
        public int Max
        {
            get => max;
            set => SetPropertyValue(nameof(Max), ref max, value);
        }

        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}