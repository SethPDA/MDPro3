using System;
using YgomGame.TextIDs;

namespace YgomGame.Menu
{
	public class LanguageSelectParameter
	{
		public IDS_SYS decisionButtonTextID;

		public bool disableBackButton;

		public int selectorPriority;

		public Action<string> resultCallback;
	}
}
