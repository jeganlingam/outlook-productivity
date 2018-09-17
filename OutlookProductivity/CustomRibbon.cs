using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;
using System.Diagnostics;

namespace OutlookProductivity
{
	public partial class CustomRibbon
	{
		private void CustomRibbon_Load(object sender, RibbonUIEventArgs e)
		{
			// Load special words into the textbox
			var specialWords = MailMessageManager.GetWordsToUndoIgnore();
			if (specialWords != null)
			{
				TxtSpecialWords.Text = string.Join(",", specialWords);
			}
		}

		private void BtnIgnore_Click(object sender, RibbonControlEventArgs e)
		{
			MailItem mailItem = GetCurrentMailItem();
			if (mailItem != null)
			{
				MailMessageManager.IgnoreConversation(mailItem.ConversationID);
			}
		}

		private void BtnTest_Click(object sender, RibbonControlEventArgs e)
		{
			MailItem mailItem = GetCurrentMailItem();
			if (mailItem != null)
			{
				bool shouldIgnore = MailMessageManager.ShouldConversationBeIgnored(mailItem.ConversationID, mailItem.Body);
				MessageBox.Show($"Should ignore = {shouldIgnore}");
			}
		}

		private MailItem GetCurrentMailItem()
		{
			Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();
			if (explorer != null && explorer.Selection != null && explorer.Selection.Count > 0)
			{
				object item = explorer.Selection[1];
				if (item is MailItem)
				{
					MailItem mailItem = item as MailItem;
					return mailItem;
				}
			}

			return null;
		}

		private void BtnUndoIgnore_Click(object sender, RibbonControlEventArgs e)
		{
			MailItem mailItem = GetCurrentMailItem();
			if (mailItem != null)
			{
				MailMessageManager.UndoIgnoreConversation(mailItem.ConversationID);
			}
		}

		private void TxtSpecialWords_TextChanged(object sender, RibbonControlEventArgs e)
		{
			MailMessageManager.SetWordsToUndoIgnore(TxtSpecialWords.Text);
		}
	}
}