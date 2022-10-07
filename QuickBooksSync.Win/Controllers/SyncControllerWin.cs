using DevExpress.Utils.Helpers;
using QuickBooksSync.Module.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBooksSync.Win.Controllers
{
    public class SyncControllerWin:SyncController
    {
        protected override void ExecuteDoEvents()
        {
            System.Windows.Forms.Application.DoEvents();
            Debug.WriteLine("DoEvents");
        }
        protected override void backgroundWorker_ProgressChanged(object RP_sender, ProgressChangedEventArgs RP_e)
        {
            base.backgroundWorker_ProgressChanged(RP_sender, RP_e);
            System.Windows.Forms.Application.DoEvents();
        }
    }
}
