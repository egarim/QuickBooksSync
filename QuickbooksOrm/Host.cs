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
    public class Host : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Host(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
         
        private String _ProductName;
        [Size(300)]
        public String ProductName
        {
            get => _ProductName;
            set => SetPropertyValue(nameof(ProductName), ref _ProductName, value);
        }  
        private String _MajorVersion;
        [Size(300)]
        public String MajorVersion
        {
            get => _MajorVersion;
            set => SetPropertyValue(nameof(MajorVersion), ref _MajorVersion, value);
        }  
        private String _MinorVersion;
        [Size(300)]
        public String MinorVersion
        {
            get => _MinorVersion;
            set => SetPropertyValue(nameof(MinorVersion), ref _MinorVersion, value);
        }  
        private String _Country;
        [Size(300)]
        public String Country
        {
            get => _Country;
            set => SetPropertyValue(nameof(Country), ref _Country, value);
        }  
        private String _SupportedQbxmlversion;
        [Size(300)]
        public String SupportedQbxmlversion
        {
            get => _SupportedQbxmlversion;
            set => SetPropertyValue(nameof(SupportedQbxmlversion), ref _SupportedQbxmlversion, value);
        }  
        private Boolean? _IsAutomaticLogin;
        public Boolean? IsAutomaticLogin
        {
            get => _IsAutomaticLogin;
            set => SetPropertyValue(nameof(IsAutomaticLogin), ref _IsAutomaticLogin, value);
        }  
        private String _QbfileMode;
        [Size(300)]
        public String QbfileMode
        {
            get => _QbfileMode;
            set => SetPropertyValue(nameof(QbfileMode), ref _QbfileMode, value);
        }
        public const string QueryableProperties="ProductName,MajorVersion,MinorVersion,Country,SupportedQbxmlversion,IsAutomaticLogin,QbfileMode";
        public const string QuickbooksTableName="Host";
    }
}