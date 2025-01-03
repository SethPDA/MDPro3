using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Friend
{
	public class FriendListWidget : ElementWidgetBehaviourBase<FriendListWidget>
	{
		private readonly string k_ELabelEmptyText;

		private readonly int k_TemplateIdxPlayer;

		private readonly int k_TemplateIdxPinLine;

		private InfinityScrollView m_ScrollView;

		private ScrollRect m_ScrollRect;

		private Selector m_Selector;

		private Dictionary<GameObject, FriendWidget> m_EntityWidgetMap;

		public string nameFilter;

		public bool followStateVisible;

		public bool isUsePinLine;

		public string emptyMessage;

		public string filteredEmptyMessage;

		public string filteredMessage;

		private IReadOnlyList<IPlayerContext> m_FriendContexts;

		private List<IPlayerContext> m_DisplayFriendContexts;

		private List<int> m_TemplateIdxs;

		private List<IPlayerContext> m_SearchPlayerList;

		private bool m_IsContainPin;

		public bool dumpPos;

		public Selector selector => null;

		public IReadOnlyList<IPlayerContext> friendContexts => null;

		public IReadOnlyList<IPlayerContext> displayFriendContexts => null;

		public InfinityScrollView scrollView => null;

		public ScrollRect scrollRect => null;

		public int defaultIdx
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool scrollEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<IPlayerContext> onClickEntityEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, IPlayerContext> onSelectedEntityEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool> onOpenCloseEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onUpdateDataCountEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onReachScrollHeadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onReachScrollTailEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static FriendListWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void Initialize(IReadOnlyList<IPlayerContext> friendContexts, Action callback)
		{
		}

		public IReadOnlyList<IPlayerContext> SearchInnerViewportPlayers()
		{
			return null;
		}

		private bool Filter(IPlayerContext playerContext)
		{
			return false;
		}

		public void UpdateDataCount()
		{
		}

		public void UpdateData()
		{
		}

		public long GetSelectedPcode()
		{
			return 0L;
		}

		public bool TrySelectInViewportPcode(long pcode, bool focus = false, bool isIniitialSelect = false)
		{
			return false;
		}

		public bool FocusPlayer(long pcode, bool isIniitialSelect = false)
		{
			return false;
		}

		public void ImmediateApplyMovement()
		{
		}

		public void FixEntitiesSelectedTween()
		{
		}

		public void OpenOrClose(bool isOn)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		protected bool IsSelectableDataIndex(int dataindex)
		{
			return false;
		}

		protected void OnCreatedEntity(GameObject gob)
		{
		}

		protected void OnUpdateEntity(GameObject gob, int dataindex)
		{
		}

		private void OnScrollValueChanged(Vector2 normalizedPos)
		{
		}

		private void OnClickedEntityWidget(FriendWidget clickedWidget)
		{
		}

		private void OnSelectedEntityWidget(FriendWidget selectedWidget)
		{
		}

		public FriendListWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
