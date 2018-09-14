using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace OutlookProductivity
{
	public partial class ThisAddIn
    {
		//private Outlook.NameSpace _outlookNameSpace;
		//private Outlook.MAPIFolder _inbox;
		//private Outlook.Items _items;

		private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
			//_outlookNameSpace = this.Application.GetNamespace("MAPI");
			//_inbox = _outlookNameSpace.GetDefaultFolder(
			//		Microsoft.Office.Interop.Outlook.
			//		OlDefaultFolders.olFolderInbox);

			//_items = _inbox.Items;
			//_items.ItemAdd +=
			//	new Outlook.ItemsEvents_ItemAddEventHandler(items_ItemAdd);
		}

		//void items_ItemAdd(object Item)
		//{
		//	string filter = "USED CARS";
		//	Outlook.MailItem mail = (Outlook.MailItem)Item;
		//	if (Item != null)
		//	{
		//		if (mail.MessageClass == "IPM.Note" &&
		//				   mail.Subject.ToUpper().Contains(filter.ToUpper()))
		//		{
		//			mail.Move(_outlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderJunk));
		//		}
		//	}
		//}

		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
