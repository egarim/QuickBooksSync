using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using QuickBooksSync.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBooksSync.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class SyncController : ViewController
    {
        SimpleAction ActiveALl;
        SimpleAction GenerateEntities;
        SimpleAction Sybc;
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public SyncController()
        {
            InitializeComponent();
            Sybc = new SimpleAction(this, "Sync", "View");
            Sybc.Execute += Sybc_Execute;
            GenerateEntities = new SimpleAction(this, "GenerateEntites", "View");
            GenerateEntities.Execute += GenerateEntities_Execute;

            ActiveALl = new SimpleAction(this, "SelectAll", "View");
            ActiveALl.Execute += ActiveALl_Execute;
            


            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        private void ActiveALl_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }
        private void GenerateEntities_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\manu_\\source\\repos\\QuickBooksSync\\EFConsoleQb\\EFConsoleQb\\Models");
            var Files=directoryInfo.GetFiles();
            foreach (FileInfo fileInfo in Files)
            {
                CompanyEntity entity = this.View.ObjectSpace.CreateObject<CompanyEntity>();
                entity.Name = fileInfo.Name.Replace(".cs","");
            }
            this.View.ObjectSpace.CommitChanges();

            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }
        private void Sybc_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
