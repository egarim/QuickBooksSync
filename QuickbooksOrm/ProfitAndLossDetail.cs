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
    public class ProfitAndLossDetail : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ProfitAndLossDetail(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
         
        private String _Label;
        [Size(300)]
        public String Label
        {
            get => _Label;
            set => SetPropertyValue(nameof(Label), ref _Label, value);
        }  
        private String _Type;
        [Size(300)]
        public String Type
        {
            get => _Type;
            set => SetPropertyValue(nameof(Type), ref _Type, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String _Num;
        [Size(300)]
        public String Num
        {
            get => _Num;
            set => SetPropertyValue(nameof(Num), ref _Num, value);
        }  
        private String _Name;
        [Size(300)]
        public String Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String _Class;
        [Size(300)]
        public String Class
        {
            get => _Class;
            set => SetPropertyValue(nameof(Class), ref _Class, value);
        }  
        private String _Clr;
        [Size(300)]
        public String Clr
        {
            get => _Clr;
            set => SetPropertyValue(nameof(Clr), ref _Clr, value);
        }  
        private String _Split;
        [Size(300)]
        public String Split
        {
            get => _Split;
            set => SetPropertyValue(nameof(Split), ref _Split, value);
        }  
        private Single? _Amount;
        public Single? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private Single? _Balance;
        public Single? Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
        }  
        private String _RowType;
        [Size(300)]
        public String RowType
        {
            get => _RowType;
            set => SetPropertyValue(nameof(RowType), ref _RowType, value);
        }
        public const string QueryableProperties="Label,Type,Date,Num,Name,Memo,Class,Clr,Split,Amount,Balance,RowType";
    }
}