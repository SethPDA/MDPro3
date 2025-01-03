using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team
{
	public class TeamNameSelectViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
	{
		private class CardListArea
		{
			private const string LABEL_IMGCARD = "ImageCard";

			private const string LABEL_SELECT_TOGGLE = "SelectedStateToggle";

			private readonly TeamNameSelectViewController _vc;

			private readonly InfinityScrollView _infinityScroll;

			private readonly Selector _selector;

			private readonly GridLayoutGroup _gridlayout;

			private GameObject _selectedCardObj;

			internal List<CardBaseData> cardData
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal CardListArea(TeamNameSelectViewController vc, InfinityScrollView v)
			{
			}

			internal void Initialize(List<CardBaseData> data)
			{
			}

			internal void Refresh()
			{
			}

			private void OnEntityUpdate(GameObject obj, int index)
			{
			}

			private void OnEntityDeactivate(GameObject obj)
			{
			}

			private void SetupShortcuts()
			{
			}
		}

		public static readonly string ARG_ONRESULT;

		private CardListArea _cardArea;

		private Action<int> _onResult;

		private const string LABEL_BTNCANCEL = "ButtonCancel";

		[SerializeField]
		private KeyConfigContainer _keyConfig;

		private ElementObjectManager _contentView;

		private ElementObjectManager _cardCollectionView;

		private ElementObjectManager _cardScrollTop;

		private InputFieldWidget _cardSearchField;

		private ExtendedTextMeshProUGUI _teamName;

		private BindingTextMeshProUGUI _title;

		private SelectionButton _cancelBtn;

		private SelectionButton _decideBtn;

		private List<CardBaseData> _allCardData;

		private int _selectedCardId;

		private bool _backSent;

		protected override Type[] textIds => null;

		public bool initialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void ExecInit()
		{
		}

		private void Close()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator LoadAllCardIDs()
		{
			return null;
		}

		private IEnumerator SortCardsFirst()
		{
			return null;
		}

		private void Filter(string searchText)
		{
		}

		private bool OnCardSelected(int cardId)
		{
			return false;
		}
	}
}
