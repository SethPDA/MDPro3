using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Deck
{
	public class DeckEditFooter
	{
		public enum FooterType
		{
			CursorJump = 0,
			OptionL1 = 1,
			OptionR1 = 2,
			AddDeckCard = 3,
			RemoveDeckCard = 4,
			CardDetail = 5,
			ChangeActiveWindow = 6
		}

		private class DisplayRequest
		{
			public bool display;
		}

		private ElementObjectManager template;

		private Transform parent;

		private KeyConfigContainer keyConfig;

		private Dictionary<FooterType, GameObject> footerList;

		private Dictionary<FooterType, DisplayRequest> dispRequest;

		private bool requestUpdateDisplay;

		public void Setup(ElementObjectManager template, Transform parent, KeyConfigContainer keyConfig)
		{
		}

		public void CreateFooterDescription(FooterType footerType, string keyLabel, string text)
		{
		}

		public void CreateFooterDescription(FooterType footerType, SelectorManager.KeyType keyType, string text)
		{
		}

		public void CreateFooterDescription(FooterType footerType, int buttonID, string text)
		{
		}

		private void SetDisp(FooterType footerType, bool disp)
		{
		}

		public void Update()
		{
		}

		public void RequestDisplay(FooterType footerType, bool disp)
		{
		}

		public void RequestHideAll()
		{
		}
	}
}
