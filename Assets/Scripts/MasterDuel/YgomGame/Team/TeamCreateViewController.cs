using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team
{
	public class TeamCreateViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class ConfigData
		{
			internal int memberNum
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal int regulationSetIdx
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal int mrkForTeamName
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal int regulationIDToJoin
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal TeamUtil.RegulationSet selectedRegulationSet
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
		}

		public enum Mode
		{
			CREATE = 0,
			SEARCH = 1,
			UNKNOWN = 2
		}

		private ConfigData _config;

		private const string VC_PATH = "Team/TeamCreate";

		public static readonly string ARG_MODE;

		private const string ARG_REGSET_DATA = "REGSET_DATA";

		private const string ARG_CONFIG_DATA = "CONFIG_DATA";

		private static bool c_TextLoadInOpen;

		private ElementObjectManager _searchInputField;

		private ExtendedTextMeshProUGUI _titleText;

		private InfinityScrollView _scrollView;

		private ElementObjectManager _memberNumItem;

		private ElementObjectManager _regulationSetItem;

		private ElementObjectManager _teamCardNameItem;

		private ElementObjectManager _regulationToJoinItem;

		private ElementObjectManager _usingDeckItem;

		private SelectionButton _memberNumBtn;

		private SelectionButton _regulationSetBtn;

		private SelectionButton _teamCardNameBtn;

		private SelectionButton _regulationToJoinBtn;

		private SelectionButton _usingDeckBtn;

		private DeckCaseWidget _deckCaseWidget;

		private SelectionButton _decideBtn;

		private Mode mode
		{
			[CompilerGenerated]
			get
			{
				return default(Mode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override Type[] textIds => null;

		private SortedDictionary<int, List<TeamUtil.RegulationSet>> regulationSetDic
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

		public static void Open(ViewControllerManager manager)
		{
		}

		private static SortedDictionary<int, List<TeamUtil.RegulationSet>> LoadRegulationSetData(ref int minimumTeamNum)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void InitScrollAsync(Action onEnd)
		{
		}

		private void SetupView()
		{
		}

		private void LoadData()
		{
		}

		private void UpdateMemberNum()
		{
		}

		private void UpdateRegulationSet()
		{
		}

		private void UpdateTeamNameCard()
		{
		}

		private void UpdateRegulationToJoin()
		{
		}

		private void UpdateUsingDeck(Dictionary<string, object> deckInfo = null)
		{
		}

		private void OnTeamMemberNumChanging(int num)
		{
		}

		private void OnRegulationSetSelecting(int index)
		{
		}

		private void OnRegulationToJoinSelecting(int regulationID, bool deckCheck = true)
		{
		}

		private void OnCardIdSelected(int cardId)
		{
		}

		private void CallAPI_TeamCreate(Action onSuccess)
		{
		}

		private static void ShowFatalError()
		{
		}
	}
}
