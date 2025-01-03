using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal interface ICustomButtonAction
		{
			void OnCustomClick(ViewControllerManager manager, Action onFailed);
		}

		internal abstract class ColosseumMenuBase
		{
			protected readonly string BTN_LABEL;

			protected readonly string ROOT_RANK_LABEL;

			protected readonly string ROOT_FREE_LABEL;

			protected readonly string IMG_LABEL;

			protected readonly string TXT_TIME_LIMIT_LABEL;

			protected readonly string TXT_LABEL;

			protected readonly string TXT_NAME_LABEL;

			protected readonly string IMG_BG_LABEL;

			internal virtual void Init(ElementObjectManager m_View, ViewControllerManager manager)
			{
			}

			internal abstract void Update();

			internal abstract ColosseumUtil.PlayMode GetPlayMode();
		}

		protected internal class ButtonInfo
		{
			internal string name;

			internal readonly int identifier;

			internal readonly ColosseumUtil.PlayMode playMode;

			internal ButtonInfo(string name, ColosseumUtil.PlayMode playMode, int identifier = 0)
			{
			}
		}

		internal abstract class ButtonEvent : ButtonInfo
		{
			public enum TemplateType
			{
				NORMAL = 0,
				REGULATION = 1,
				DUELTRIAL = 2
			}

			protected readonly string TXT_BEFORE_LABEL;

			protected readonly string TXT_AFTER_LABEL;

			protected readonly string TXT_OPEN_LABEL;

			protected readonly string TXT_TIME_LABEL;

			protected readonly string IMG_BEFORE_LABEL;

			protected readonly string IMG_AFTER_LABEL;

			protected readonly string IMG_OPEN_LABEL;

			protected readonly string IMG_LOGO_LABEL;

			protected readonly string IMG_LOGO_BG_LABEL;

			protected readonly string IMG_ATTENTION_LABEL;

			protected readonly string IMG_TIME_LABEL;

			protected readonly string IMG_EVENT_CATEGORY;

			public TemplateType type;

			private string vcPrefabPath;

			internal string endDate;

			internal string startDate;

			internal int sort;

			public string VcPrefabPath
			{
				get
				{
					return null;
				}
				protected set
				{
				}
			}

			internal ButtonEvent(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
				: base(null, default(ColosseumUtil.PlayMode))
			{
			}

			internal abstract void SetStatus(ElementObjectManager eom);

			internal abstract void SetLogo(ElementObjectManager eom);

			internal abstract void SetStatusText(ElementObjectManager eom);

			internal virtual Dictionary<string, object> GetAdditionalArgs()
			{
				return null;
			}

			protected virtual string GetEventCategoryPath()
			{
				return null;
			}
		}

		internal class ColosseumMenuManager
		{
			private List<ColosseumMenuBase> menuBases;

			internal List<ButtonEvent> eventList;

			internal ColosseumMenuManager()
			{
			}

			internal void Init(ElementObjectManager m_View, ViewControllerManager manager)
			{
			}

			internal void Update()
			{
			}
		}

		internal abstract class ColosseumMenuEventDuel : ColosseumMenuBase
		{
			internal List<ButtonEvent> eventList;
		}

		internal class ColosseumMenuExhibition : ColosseumMenuEventDuel
		{
			internal class ButtonExhibition : ButtonEvent
			{
				internal ColosseumUtil.StatusExhibition status;

				internal int logoId;

				internal bool isReward;

				internal ButtonExhibition(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}

				internal void SetInfo(ColosseumUtil.StatusExhibition status, int logoId, string startDate, string endDate, bool isReward)
				{
				}

				internal override void SetStatus(ElementObjectManager eom)
				{
				}

				internal override void SetLogo(ElementObjectManager eom)
				{
				}

				internal override void SetStatusText(ElementObjectManager eom)
				{
				}
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Update()
			{
			}
		}

		internal class ColosseumMenuTournament : ColosseumMenuEventDuel
		{
			internal class ButtonTournament : ButtonEvent
			{
				internal ColosseumUtil.StatusTournament status;

				internal ColosseumUtil.StatusTournamentHolding statusHolding;

				internal int logoId;

				internal ButtonTournament(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}

				internal void SetInfo(ColosseumUtil.StatusTournament status, ColosseumUtil.StatusTournamentHolding statusHolding, int logoId, string startDate, string endDate)
				{
				}

				internal override void SetStatus(ElementObjectManager eom)
				{
				}

				internal override void SetLogo(ElementObjectManager eom)
				{
				}

				internal override void SetStatusText(ElementObjectManager eom)
				{
				}
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Update()
			{
			}
		}

		internal class ColosseumMenuRegulationDuel : ColosseumMenuEventDuel
		{
			internal class ButtonRankEvent : ButtonEvent
			{
				internal ColosseumUtil.StatusRankEvent status;

				internal int logoId;

				internal bool isReward;

				internal ButtonRankEvent(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}

				internal void SetInfo(ColosseumUtil.StatusRankEvent status, int logoId, string startDate, string endDate, bool isReward)
				{
				}

				internal override void SetStatus(ElementObjectManager eom)
				{
				}

				internal override void SetLogo(ElementObjectManager eom)
				{
				}

				internal override void SetStatusText(ElementObjectManager eom)
				{
				}
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Update()
			{
			}
		}

		internal class ColosseumMenuCup : ColosseumMenuEventDuel
		{
			internal class ButtonDuelistCup : ButtonEvent
			{
				internal ColosseumUtil.StatusDuelistCup status;

				internal int logoId;

				internal int stage;

				internal ButtonDuelistCup(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}

				internal void SetInfo(ColosseumUtil.StatusDuelistCup status, int logoId, string startDate, string endDate, int stage)
				{
				}

				internal override void SetStatus(ElementObjectManager eom)
				{
				}

				internal override void SetLogo(ElementObjectManager eom)
				{
				}

				internal override void SetStatusText(ElementObjectManager eom)
				{
				}
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal virtual string GetIDPath()
			{
				return null;
			}

			internal override void Update()
			{
			}

			protected virtual void AddEventList(int cid, string eventName, int logoId, ColosseumUtil.StatusDuelistCup status, int stage, string startDate, string endDate, int sort)
			{
			}
		}

		internal class ColosseumMenuWCS : ColosseumMenuCup
		{
			internal class ButtonWCS : ButtonDuelistCup
			{
				internal ButtonWCS(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}
			}

			internal override string GetIDPath()
			{
				return null;
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			protected override void AddEventList(int cid, string eventName, int logoId, ColosseumUtil.StatusDuelistCup status, int stage, string startDate, string endDate, int sort)
			{
			}
		}

		internal class ColosseumMenuDuelTrial : ColosseumMenuEventDuel
		{
			internal class ButtonDuelTrial : ButtonEvent
			{
				internal ColosseumUtil.StatusDuelTrial status;

				internal int logoId;

				internal bool isReward;

				internal ButtonDuelTrial(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}

				internal void SetInfo(ColosseumUtil.StatusDuelTrial status, int logoId, string startDate, string endDate, bool isReward)
				{
				}

				internal override void SetStatus(ElementObjectManager eom)
				{
				}

				internal override void SetLogo(ElementObjectManager eom)
				{
				}

				internal override void SetStatusText(ElementObjectManager eom)
				{
				}
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Update()
			{
			}
		}

		internal class ColosseumMenuVersus : ColosseumMenuEventDuel
		{
			internal class ButtonVersus : ButtonEvent//, ICustomButtonAction
			{
				internal ColosseumUtil.StatusVersus status;

				internal int logoId;

				internal bool isReward;

				internal ButtonVersus(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
					: base(null, default(ColosseumUtil.PlayMode))
				{
				}

				internal void SetInfo(ColosseumUtil.StatusVersus status, int logoId, string startDate, string endDate, bool isReward)
				{
				}

				internal override void SetStatus(ElementObjectManager eom)
				{
				}

				internal override void SetLogo(ElementObjectManager eom)
				{
				}

				internal override void SetStatusText(ElementObjectManager eom)
				{
				}

				private void YgomGame_002EColosseum_002EColosseumViewController_002EICustomButtonAction_002EOnCustomClick(ViewControllerManager manager, Action onFailed)
				{
				}
			}

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Update()
			{
			}
		}

		internal abstract class ColosseumMenuFreeDuel : ColosseumMenuBase
		{
			protected GameObject selfGo;

			protected SelectionButton selfBtn;
		}

		internal class ColosseumMenuRoom : ColosseumMenuFreeDuel
		{
			private readonly string E_RoomImageOn;

			private readonly string E_RoomImageOff;

			private readonly string SCROLL_LABEL;

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
			{
			}

			internal override void Update()
			{
			}
		}

		internal class ColosseumMenuFree : ColosseumMenuFreeDuel
		{
			private readonly string BTN_FREE_LABEL;

			private readonly string OBJ_FREE_STATE_LABEL;

			private readonly string SCROLL_LABEL;

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
			{
			}

			internal override void Update()
			{
			}
		}

		internal class ColosseumMenuTeam : ColosseumMenuFreeDuel
		{
			private readonly string BTN_TEAM_LABEL;

			private readonly string OBJ_TEAM_STATE_LABEL;

			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
			{
			}

			internal override void Update()
			{
			}
		}

		internal abstract class ColosseumMenuRankDuel : ColosseumMenuBase
		{
			protected GameObject selfGo;

			protected SelectionButton selfBtn;
		}

		internal class ColosseumMenuStandard : ColosseumMenuRankDuel
		{
			internal override ColosseumUtil.PlayMode GetPlayMode()
			{
				return default(ColosseumUtil.PlayMode);
			}

			internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
			{
			}

			internal override void Update()
			{
			}
		}

		private readonly string BTN_LABEL;

		private readonly string ROOT_EMPTY_EVENTS_LABEL;

		private readonly string IMG_EMPTY_EVENTS_LABEL;

		private readonly string TXT_NAME_LABEL;

		private readonly string SCROLL_LABEL;

		private InfinityScrollView isv;

		private ColosseumMenuManager colosseumManager;

		private bool isFirstFade;

		private bool isStackWcsBG;

		protected override Type[] textIds => null;

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		private void UpdateWcsBG(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void CallAPIDuelMenuInfo(Action onSuccess = null)
		{
		}

		private void UpdateMenu()
		{
		}

		internal void OnItemSetData(GameObject go, int index)
		{
		}
	}
}
