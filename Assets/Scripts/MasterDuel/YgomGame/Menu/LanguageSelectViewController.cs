using System;
using System.Collections.Generic;
using TMPro;

namespace YgomGame.Menu
{
	public class LanguageSelectViewController : CommonScreenViewController
	{
		private List<string> m_langCodeList;

		private List<string> m_langNameList;

		private int m_currentIndex;

		private TMP_Text m_currentLangText;

		private Action<string> m_resultCallback;

		protected override Type[] textIds => null;

		private void createLanguageList()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}
	}
}
