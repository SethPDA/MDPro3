using System;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;

namespace YgomGame.CardPack
{
	public class SecretPackObtainViewController : BaseMenuViewController
	{
		private const string k_ArgKeyIsExtend = "isExtend";

		private const string k_ArgKeyNameTextId = "nameTextId";

		private const string k_ArgKeyThumbType = "thumbType";

		private const string k_ArgKeyThumbData = "thumbData";

		private const string k_ArgKeyCallback = "callback";

		private readonly string k_ELabelBG3D;

		private readonly string k_ELabelFoundTextLabel;

		private readonly string k_ELabelPackThumbRoot;

		private readonly string k_ELabelPackThumbHolder;

		private readonly string k_ELabelPackNameTMP;

		private readonly string k_ELabelBackShortcutButton;

		private readonly string k_ELabelSmallBand;

		private readonly string k_ELabelLargeBand;

		private GameObject m_View3D;

		private string m_PackName;

		protected override Type[] textIds => null;

		public static void Open(bool isExtend, Action callback = null)
		{
		}

		public static void Open(bool isExtend, string packNameTextId, int thumbType, string thumbData, Action callback = null)
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

		private void OnTMPaused(PlayableDirector director)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
