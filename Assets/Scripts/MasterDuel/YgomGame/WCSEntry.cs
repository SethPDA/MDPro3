using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame
{
	public class WCSEntry : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class DeckObject
		{
			private ElementObjectManager Eom;

			public DeckSelectViewController2.DeckReference deckRef;

			private int wcsID;

			private int memberIdx;

			public int slotNum;

			private bool valid;

			private List<int> cardIDs;

			private ElementObjectManager body;

			private GameObject tornamentGroup;

			private GameObject iconAddDeck;

			private ExtendedTextMeshProUGUI textBaseDeckName;

			private SelectionButton button;

			public bool Usable
			{
				get
				{
					return false;
				}
				private set
				{
				}
			}

			private bool IsSet
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public UnityAction OnClick
			{
				set
				{
				}
			}

			public DeckObject(ElementObjectManager eom, DeckSelectViewController2.DeckReference reference, int wcsId, int slot, int memIdx)
			{
			}

			public void UpdateDeckData()
			{
			}

			public bool IsContainCard(int shareCardId)
			{
				return false;
			}
		}

		private class Player
		{
			public int index;

			private List<DeckObject> decks;

			private ElementObjectManager playerEom;

			private ExtendedTextMeshProUGUI nameText;

			private ExtendedTextMeshProUGUI IdText;

			public string name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string id
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public List<DeckObject> Decks => null;

			public Action<int, int, DeckSelectViewController2.DeckReference> deckClickAction
			{
				set
				{
				}
			}

			public Player(ElementObjectManager eom, int idx, int wcsId)
			{
			}

			private DeckSelectViewController2.DeckReference GetDeckReference(int slot)
			{
				return null;
			}

			public bool IsContainInDecks(int cardID)
			{
				return false;
			}
		}

		private class ShareCard
		{
			private int index;

			private ElementObjectManager eom;

			private SelectionButton button;

			private GameObject selectedCursor;

			public int cardID;

			private RawImage imageCard;

			private Action<int, int> SaveShareCard;

			public Action<int, int> SaveShareCards
			{
				set
				{
				}
			}

			public ShareCard(ElementObjectManager manager, int index, bool isSelectable)
			{
			}

			private void onClick()
			{
			}

			public void SetShareCard(int id)
			{
			}
		}

		private bool m_firstFocusPassed;

		private ElementObjectManager m_ShareCardEom;

		private static string k_ELabelButtonCaution;

		private static string k_ELabelTextDate;

		private static string k_ELabelButtonCheckRegulation;

		private static string k_ELabelButtonEntry;

		private static string k_ELabelShareCards;

		private static string k_ELabelImageCard;

		private int m_wcsId;

		private bool m_IsRegistered;

		private bool m_IsOverDate;

		private SelectionButton m_ButtonCaution;

		private SelectionButton m_ButtonCheckRegulation;

		private SelectionButton m_ButtonEntry;

		private ExtendedTextMeshProUGUI m_ButtonText;

		private SelectionButton m_ButtonResetShareCards;

		private ExtendedTextMeshProUGUI m_HeaderText;

		private List<Tween> m_HideTween;

		private List<Tween> m_ShowTween;

		private List<Player> m_Players;

		private List<ShareCard> m_ShareCards;

		private string actionSheetName;

		private List<string> m_DeckActionDialogButtonLabels;

		private Dictionary<string, Action<int, int>> m_DeckActionDialogCallBacks;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void InitializeElement()
		{
		}

		private void InitializePlayers()
		{
		}

		private void InitializeShareCards()
		{
		}

		private void OpenCautiun()
		{
		}

		private void OnClick(int index, int slot, DeckSelectViewController2.DeckReference deckRef)
		{
		}

		private void OpenConfirmBrowser(int index, int slot, DeckSelectViewController2.DeckReference deckRef)
		{
		}

		private void SaveShareCard(int index, int cardID, bool isFirst = false)
		{
		}

		private void ResetShareCards()
		{
		}

		private bool CheckShareCard(int cardID)
		{
			return false;
		}

		private void CheckRegulation()
		{
		}

		private void Entry()
		{
		}

		private void ResetEntryData()
		{
		}

		private void OpenRegErrorDialogue(Dictionary<string, object> overLimitDic, Action action = null)
		{
		}

		private void OpenMyDeck(int index, int slot)
		{
		}

		private void OpenNeuronDeckSearch(int index, int slot, bool isFirst = false)
		{
		}

		public void GetNeuronToken(int index, int slot)
		{
		}

		public static void Open(Dictionary<string, object> args = null)
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}
	}
}
