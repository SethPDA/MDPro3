using System;
using System.Collections;
using UnityEngine;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu
{
	public class StructureDeckObtainViewController : InformDialogViewControllerBase<int, Action>
	{
		[SerializeField]
		private float m_AlphaMessageWaitSec;

		private readonly string k_ELabelDeckBox;

		private StructureBoxWidget m_DeckWidget;

		private const string ANDROID_BACK_KEY_LABEL = "AndroidBackKey";

		protected override Type[] textIds => null;

		protected override int arg1 => 0;

		protected override Action arg2 => null;

		public static void Open(int structureDeckId, Action callback)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public StructureDeckObtainViewController()
		{
			//((InformDialogViewControllerBase<, >)(object)this)._002Ector();
		}
	}
}
