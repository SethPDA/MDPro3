using System.Collections.Generic;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Colosseum
{
	public class ColosseumDeckWidget : ElementWidgetBehaviourBase<ColosseumDeckWidget>
	{
		public class ButtonInfo
		{
			public bool isSetDeck;

			public bool cantUseDeck;

			public bool duelInteractable;

			public string duelLabel;

			public string deckLabel;

			public string tabLabel;

			public int rentalState;

			public ColosseumDeckManager deckManager;

			public UnityAction onClickDeck;

			public UnityAction onClickDuel;

			public UnityAction onClickDuelInactive;

			public ButtonInfo(ColosseumPathManager pathManager, bool isSetDeck, bool cantUseDeck, bool duelInteractable, string duelLabel, string deckLabel, string tabLabel, int rentalState = 0)
			{
			}

			public ButtonInfo(ColosseumDeckManager deckManager, bool isSetDeck, bool cantUseDeck, bool duelInteractable, string duelLabel, string deckLabel, string tabLabel, int rentalState = 0)
			{
			}
		}

		public class ColosseumDeck
		{
			public ButtonInfo buttonInfo;

			public ElementObjectManager tabEom;

			public ElementObjectManager btnEom;

			private DeckCaseWidget deckCase;

			public ColosseumDeck(ButtonInfo buttonInfo, ElementObjectManager tabEom, ElementObjectManager btnEom)
			{
			}

			public void UpdateDisp()
			{
			}

			public void SelectDeckButton()
			{
			}
		}

		private const string E_TabGroup = "TabGroup";

		private const string E_IconL = "IconL";

		private const string E_IconR = "IconR";

		private const string E_TemplateTab = "TemplateTab";

		private const string E_TextOff = "TextOff";

		private const string E_TextOn = "TextOn";

		private const string E_TemplateDeckButton = "TemplateDeckButton";

		private const string E_ButtonDeck = "ButtonDeck";

		private const string E_ButtonPlay = "ButtonPlay";

		private const string E_ImageDeck = "ImageDeck";

		public const string E_ImageDeckBg = "ImageDeckBg";

		private const string E_ImageDeckDisabled = "ImageDeckDisabled";

		private const string E_ImageDeckEmpty = "ImageDeckEmpty";

		private const string E_TextDeck = "TextDeck";

		private const string E_TextPlay = "TextPlay";

		private const string E_ImageBack = "ImageBack";

		private DirectionalToggleGroupWidget toggleGroup;

		private List<ColosseumDeck> colosseumDecks;

		public static ColosseumDeckWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void Initialize(Selector parentSelector, List<ButtonInfo> buttonInfos)
		{
		}

		public void UpdateDisp(List<ButtonInfo> buttonInfos)
		{
		}

		public void SelectDeckButton()
		{
		}

		private void SetShortcutLRDeck(bool isSet)
		{
		}

		public bool IsSetDeck(int index, bool defaultValue = false)
		{
			return false;
		}

		public void MoveIdxToggle(int index)
		{
		}

		public List<ColosseumDeck> GetColosseumDecks()
		{
			return null;
		}

		public ColosseumDeckWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
