namespace OutlookProductivity
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Class used for moving messages and inspecting messages if they need to be handled
	/// </summary>
	public static class MailMessageManager
	{
		/// <summary>
		/// Store a file in a custom folder location
		/// </summary>
		/// <param name="conversationId"></param>
		public static void IgnoreConversation(string conversationId)
		{

		}

		/// <summary>
		/// Check if file exists to return true/false for ignoring a conversation
		/// </summary>
		/// <param name="conversationId"></param>
		/// <returns></returns>
		public static bool ShouldConversationBeIgnored(string conversationId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Method to delete the file which is equivalent of undo of ignore
		/// </summary>
		/// <param name="conversationId"></param>
		public static void UndoIgnoreConversation(string conversationId)
		{

		}
	}
}
