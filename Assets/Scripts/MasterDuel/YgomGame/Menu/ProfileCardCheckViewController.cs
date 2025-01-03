using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class ProfileCardCheckViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string k_ELabelProfileCardRoot;

		private readonly string k_ELabelBackButton;

		public const string k_ArgKeyPcode = "pcode";

		public const string k_ArgKeyCallAPI = "callAPI";

		private GameObject m_ProfileCardParent;

		private SelectionButton m_BackButton;

		private long pcode;

		private bool callAPI;

		private Dictionary<string, object> profileDic;

		public override void NotificationStackEntry()
		{
		}

		public static void Open(Dictionary<string, object> args = null)
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator DelayedInvokeCallback(Action action)
		{
			return null;
		}
	}
}
