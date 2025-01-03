using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.CardPack.Open.Actor;
using YgomGame.CardPack.Open.Sequence;
using YgomGame.HeaderFooter;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open
{
	public class CardPackOpenViewController : BaseMenuViewController
	{
		private const string k_PrefPath = "CardPack/CardPackOpen";

		private readonly string k_ELabelRoot3D;

		private readonly string k_ELabelRootCanvas;

		private readonly string k_ELabelRootUI;

		private readonly string k_ELabelRenderTextureCamera;

		private readonly string k_ELabelBackKey;

		private Dictionary<string, object> m_GachaDrawInfoWork;

		private int m_DrawPackTotal;

		private CardPackRootActorContainer m_RootActorContainer;

		private OutGameFooter m_Footer;

		private SequenceController m_SequenceController;

		private Selector m_Selector3D;

		private int m_OverridedCullingMaskBefore;

		private Camera m_OverridedCullingMaskCamera;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		public static void Open(ViewController swapTarget = null)
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

		private void Update()
		{
		}

		private void UpdateSequence()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void ToResult()
		{
		}

		private void Skip()
		{
		}

		private void OnClickSkip()
		{
		}

		private void OnClickOk()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
