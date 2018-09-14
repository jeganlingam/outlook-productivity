using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;

namespace OutlookProductivity
{
	public partial class CustomRibbon
	{
		private void CustomRibbon_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void BtnIgnore_Click(object sender, RibbonControlEventArgs e)
		{
			Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();
			if (explorer != null && explorer.Selection != null && explorer.Selection.Count > 0)
			{
				object item = explorer.Selection[1];
				if (item is MailItem)
				{
					MailItem mailItem = item as MailItem;
					var subject = mailItem.Subject;
					var body = mailItem.Body;
				}
			}
		}
	}
}