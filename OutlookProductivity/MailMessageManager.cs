namespace OutlookProductivity
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Class used for moving messages and inspecting messages if they need to be handled
	/// </summary>
	public static class MailMessageManager
	{
		private static List<string> _wordsToUndoIgnore;

		public static List<string> GetWordsToUndoIgnore()
		{
			if (_wordsToUndoIgnore == null)
			{
				string fileContents = File.ReadAllText(GetSettingsFile());
				if (fileContents != null)
				{
					_wordsToUndoIgnore = fileContents.Split(',').ToList();
				}
			}

			return _wordsToUndoIgnore;
		}

		public static void SetWordsToUndoIgnore(string words)
		{
			File.WriteAllText(GetSettingsFile(), words);

			// Reload words
			_wordsToUndoIgnore = null;
			GetWordsToUndoIgnore();
		}

		/// <summary>
		/// Store a file in a custom folder location
		/// </summary>
		/// <param name="conversationId"></param>
		public static void IgnoreConversation(string conversationId)
		{
			File.Create($"{GetIgnoreFolder()}/{conversationId}");
		}

		/// <summary>
		/// Check if file exists to return true/false for ignoring a conversation
		/// </summary>
		/// <param name="conversationId"></param>
		/// <returns></returns>
		public static bool ShouldConversationBeIgnored(string conversationId, string body)
		{
			// 1. Check if it is a ignore conversation
			string file = $"{GetIgnoreFolder()}/{conversationId}";
			if (File.Exists(file))
			{
				if(!string.IsNullOrEmpty(body))
				{
					body = GetStrippedBody(body);

					if (_wordsToUndoIgnore != null)
					{
						foreach (var specialWord in _wordsToUndoIgnore)
						{
							if (body.IndexOf(specialWord, StringComparison.OrdinalIgnoreCase) >= 0)
							{
								return false;
							}
						}
					}

					return true;
				}
			}

			return false;
		}

		private static string GetStrippedBody(string body)
		{
			while(true)
			{
				int startIndex = body.IndexOf("From:");
				int endIndex = body.IndexOf("Subject:");

				if (startIndex >0 && endIndex >0)
				{
					string replaceString = body.Substring(startIndex, endIndex - startIndex + "Subject:".Length);
					body = body.Replace(replaceString, "#");
				}
				else
				{
					break;
				}
			}

			return body;
		}

		/// <summary>
		/// Method to delete the file which is equivalent of undo of ignore
		/// </summary>
		/// <param name="conversationId"></param>
		public static void UndoIgnoreConversation(string conversationId)
		{
			string file = $"{GetIgnoreFolder()}/{conversationId}";
			if (File.Exists(file))
			{
				File.Delete(file);
			}
		}

		// Check if add-in folder exists, if not create it.
		private static string GetAddinFolder()
		{
			string addInFolder = $"{Path.GetTempPath()}/OutlookProductivity";
			if (!Directory.Exists(addInFolder))
			{
				Directory.CreateDirectory(addInFolder);
			}

			return addInFolder;
		}

		private static string GetSettingsFile()
		{
			string settingsFile = $"{GetAddinFolder()}/settings.json";
			if (!File.Exists(settingsFile))
			{
				File.Create(settingsFile);
			}

			return settingsFile;
		}

		private static string GetIgnoreFolder()
		{
			string ignoreFolder = $"{GetAddinFolder()}/Ignore";
			if (!Directory.Exists(ignoreFolder))
			{
				Directory.CreateDirectory(ignoreFolder);
			}

			return ignoreFolder;
		}
	}
}
