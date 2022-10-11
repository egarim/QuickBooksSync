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
    public class SalesTaxCode : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public SalesTaxCode(Session session)
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
        private String _Description;
        [Size(300)]
        public String Description
        {
            get => _Description;
            set => SetPropertyValue(nameof(Description), ref _Description, value);
        }  
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private Boolean? _IsTaxable;
        public Boolean? IsTaxable
        {
            get => _IsTaxable;
            set => SetPropertyValue(nameof(IsTaxable), ref _IsTaxable, value);
        }  
        private String _ItemPurchaseTaxRefFullName;
        [Size(300)]
        public String ItemPurchaseTaxRefFullName
        {
            get => _ItemPurchaseTaxRefFullName;
            set => SetPropertyValue(nameof(ItemPurchaseTaxRefFullName), ref _ItemPurchaseTaxRefFullName, value);
        }  
        private String _ItemPurchaseTaxRefListId;
        [Size(300)]
        public String ItemPurchaseTaxRefListId
        {
            get => _ItemPurchaseTaxRefListId;
            set => SetPropertyValue(nameof(ItemPurchaseTaxRefListId), ref _ItemPurchaseTaxRefListId, value);
        }  
        private String _ItemSalesTaxRefFullName;
        [Size(300)]
        public String ItemSalesTaxRefFullName
        {
            get => _ItemSalesTaxRefFullName;
            set => SetPropertyValue(nameof(ItemSalesTaxRefFullName), ref _ItemSalesTaxRefFullName, value);
        }  
        private String _ItemSalesTaxRefListId;
        [Size(300)]
        public String ItemSalesTaxRefListId
        {
            get => _ItemSalesTaxRefListId;
            set => SetPropertyValue(nameof(ItemSalesTaxRefListId), ref _ItemSalesTaxRefListId, value);
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
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }
        public const string QueryableProperties="Id,Name,Description,IsActive,IsTaxable,ItemPurchaseTaxRefFullName,ItemPurchaseTaxRefListId,ItemSalesTaxRefFullName,ItemSalesTaxRefListId,TimeCreated,TimeModified,EditSequence";
        public const string QuickbooksTableName="SalesTaxCodes";
    }
}