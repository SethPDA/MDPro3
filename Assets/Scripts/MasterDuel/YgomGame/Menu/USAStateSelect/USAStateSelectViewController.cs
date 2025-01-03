using System;
using System.Collections.Generic;
using TMPro;

namespace YgomGame.Menu.USAStateSelect
{
	public class USAStateSelectViewController : CommonScreenViewController
	{
		private Action<int> m_resultCallback;

		private IReadOnlyList<int> m_codeList;

		private IReadOnlyList<string> m_nameList;

		private int m_currentIndex;

		private TMP_Text m_currentNameText;

		private void createList(int defaultState)
		{
		}

		private void updateButonText()
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
