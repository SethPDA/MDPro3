using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Duel;
using YgomGame.Effect;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class DuelResultViewController : BaseMenuViewController
	{
		private class ClassChange : TweenResultPlayer
		{
			private readonly string k_MessageTextLabel;

			private readonly string k_NextRankTextLabel;

			private readonly string k_RankChangeInfoTextLabel;

			private readonly string k_RankIconBeforeLabel;

			private readonly string k_RankIconAfterLabel;

			private bool m_IsFinish;

			private PlayableDirector m_Timeline;

			protected override bool isFinish => false;

			public override IEnumerator Play()
			{
				return null;
			}

			protected override void OnClickClose()
			{
			}

			public override void ImportWork(object workData)
			{
			}

			internal void SetTimeline(PlayableDirector timeline)
			{
			}

			private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
			{
				return null;
			}
		}

		private class CommonDialogResultPlayer : IResultPlayer
		{
			private IEntryData[] m_DialogEntries;

			private bool m_IsFinish;

			public static CommonDialogResultPlayer CreateConfirm(string title, string message, string buttonLabel)
			{
				return null;
			}

			public IEnumerator Play()
			{
				return null;
			}

			private void DialogCallback()
			{
			}
		}

		private class DLvChange : TweenResultPlayer
		{
			private readonly string TEXT_MESSAGE_LABEL;

			private readonly string TEXT_RANK_BEFORE_LABEL;

			private readonly string TEXT_RANK_AFTER_LABEL;

			private bool m_IsFinish;

			private PlayableDirector m_Timeline;

			private Util.GameMode mode;

			private string modeName;

			protected override bool isFinish => false;

			public override IEnumerator Play()
			{
				return null;
			}

			protected override void OnClickClose()
			{
			}

			internal void SetTimeline(PlayableDirector timeline)
			{
			}

			public override void ImportWork(object workData)
			{
			}

			public void SetGameMode(Util.GameMode gameMode)
			{
			}

			private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
			{
				return null;
			}
		}

		[Serializable]
		private class GetScoreReward : TweenResultPlayer
		{
			[SerializeField]
			private float m_OpenChestIntervalSeconds;

			[SerializeField]
			private BezierMotionContainer bezierCraftCreate;

			private readonly string k_PrefabPathTrailEffect;

			private readonly string k_EImgTotalChest;

			private readonly string k_ETextEmpty;

			private int m_TotalScore;

			private readonly int m_NeedScore;

			private ResultInfoItems m_ResultInfoItem;

			private ChainedBezierMotion motion;

			private EffectHandler m_EffectTrail;

			private Transform m_OriginTrans;

			private Dictionary<int, object> m_RewardMap;

			private bool m_isFinish;

			protected override bool isFinish => false;

			protected override Selector selector => null;

			public override void Initialize(ElementObjectManager eom, int selectorGroupPriority)
			{
			}

			public override void ImportWork(object workData)
			{
			}

			public override IEnumerator Play()
			{
				return null;
			}

			protected override void OnClickClose()
			{
			}
		}

		public interface IResultPlayer
		{
			IEnumerator Play();
		}

		private class ItemReceiveDialogResultPlayer : IResultPlayer
		{
			private bool m_IsFinish;

			private string title;

			private EntryItemListData receiveItemListData;

			private bool isSendPresent;

			public static ItemReceiveDialogResultPlayer CreateItemReceive(string title, EntryItemListData receiveItemListData, bool isSendPresent)
			{
				return null;
			}

			public IEnumerator Play()
			{
				return null;
			}

			private void DialogCallback()
			{
			}
		}

		[Serializable]
		private class LevelUpPlayer : TweenResultPlayer
		{
			[SerializeField]
			private float m_GaugeSpeedPerUnitLevel;

			private float m_increasedExpAmount;

			private int m_bLevel;

			private float m_bExpPercent;

			private int m_aLevel;

			private int m_aExp;

			private int m_aNeedExp;

			private bool m_isFinish;

			protected override bool isFinish => false;

			protected override Selector selector => null;

			public override void Initialize(ElementObjectManager eom, int selectorGroupPriority)
			{
			}

			public override void ImportWork(object workData)
			{
			}

			public override IEnumerator Play()
			{
				return null;
			}

			protected override void OnClickClose()
			{
			}
		}

		private class RankChange : TweenResultPlayer
		{
			private readonly string k_MessageTextLabel;

			private readonly string k_NextRankTextLabel;

			private readonly string k_RankChangeInfoTextLabel;

			private readonly string k_RankIconBeforeLabel;

			private readonly string k_RankIconAfterLabel;

			private bool m_IsFinish;

			private PlayableDirector m_Timeline;

			protected override bool isFinish => false;

			public override IEnumerator Play()
			{
				return null;
			}

			protected override void OnClickClose()
			{
			}

			public override void ImportWork(object workData)
			{
			}

			internal void SetTimeline(PlayableDirector timeline)
			{
			}

			private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
			{
				return null;
			}
		}

		public class ResultInfoItems
		{
			public enum ChestType
			{
				NORMAL = 1,
				RARE = 2
			}

			public enum ChestStatus
			{
				INVISIBLE = 0,
				UNOPEN = 1,
				OPEN = 2
			}

			public class Entity
			{
				public int m_Num;

				public int m_ItemId;

				public readonly ChestType m_Type;

				public ChestStatus m_Status;

				public Entity(int num, int itemId, ChestType type)
				{
				}
			}

			private readonly string k_ItemNumLabel;

			private readonly string k_ItemIconLabel;

			private readonly string k_ItemOpenLabel;

			private readonly string k_ItemUnopenLabel;

			private readonly string k_ScrollLabel;

			private readonly string k_BtnLabel;

			private readonly string k_PrefabPathDispEffect;

			private readonly string k_PrefabPathOpenEffect;

			private ElementObjectManager m_Eom;

			private InfinityScrollView m_Isv;

			private List<Entity> m_EntityList;

			private int m_DispCount;

			private int m_OpenCount;

			private bool isMobile;

			public void Initialize(ElementObjectManager eom)
			{
			}

			private void InitializeScroll()
			{
			}

			private void OnCreatedEntity(GameObject go)
			{
			}

			private void OnUpdateEntity(GameObject go, int index)
			{
			}

			public void SetItems(List<Entity> entitys)
			{
			}

			public Vector3 GetCurrentEntityPosition(int correctionValue = 0)
			{
				return default(Vector3);
			}

			public Quaternion GetCurrentEntityRotation(int correctionValue = 0)
			{
				return default(Quaternion);
			}

			public int GetEntityCount()
			{
				return 0;
			}

			public void DispChest()
			{
			}

			public void DispRemainChest()
			{
			}

			public void OpenChest()
			{
			}

			public void OpenRemainChest()
			{
			}

			public void ScrollFirstIndex()
			{
			}
		}

		public class ResultInfoScores
		{
			public class Entity
			{
				public string label;

				public int point;

				public Color color;

				public Entity(string label, int point)
				{
				}

				public Entity(string label, int point, Color color)
				{
				}
			}

			private readonly string k_TotalPointLabel;

			private readonly string k_TotalPointTextLabel;

			private readonly string k_ScrollLabel;

			private readonly string k_ItemPointLabel;

			private readonly string k_ItemTextLabel;

			private ElementObjectManager m_Eom;

			private InfinityScrollView m_Isv;

			private List<Entity> m_EntityList;

			public void Initialize(ElementObjectManager eom)
			{
			}

			private void InitializeScroll()
			{
			}

			private void OnUpdateEntity(GameObject go, int index)
			{
			}

			public void SetTotalPoint(int point)
			{
			}

			public void SetOtherPoints(List<Entity> entitys)
			{
			}
		}

		private class ReviewResultPlayer : IResultPlayer
		{
			private bool m_IsFinish;

			public static ReviewResultPlayer OpenReview()
			{
				return null;
			}

			public IEnumerator Play()
			{
				return null;
			}
		}

		private abstract class TweenResultPlayer : IResultPlayer
		{
			protected readonly string k_TweenOpenKey;

			protected readonly string k_TweenCloseKey;

			protected readonly string k_CloseButtonLabel;

			protected ElementObjectManager m_Eom;

			protected virtual Selector selector => null;

			protected virtual bool isFinish => false;

			public virtual void Initialize(ElementObjectManager eom, int selectorGroupPriority)
			{
			}

			public abstract void ImportWork(object workData);

			public virtual IEnumerator Play()
			{
				return null;
			}

			protected virtual void OnClickClose()
			{
			}
		}

		private readonly string AVATARMODEL_ROOT_LABEL;

		private readonly string LEVELINFO_LABEL;

		private readonly string RESULTINFO_SCORE_REWARD_LABEL;

		private readonly string ROOT_RANK_LABEL;

		private readonly string BTN_RETRY_LABEL;

		private readonly string BTN_SAVE_LABEL;

		private readonly string BTN_BACK_LABEL;

		private readonly string SCROLLREWARD_LABEL;

		private readonly string TEMPLATENORMAL_LABEL;

		private readonly string TEMPLATERARE_LABEL;

		[SerializeField]
		private LevelUpPlayer m_LevelupPlayer;

		[SerializeField]
		private GetScoreReward m_GetScoreReward;

		private Transform m_AvatarModelRoot;

		private Character2D m_AvatarModel;

		private SelectionButton RetryButton;

		private SelectionButton SaveButton;

		private SelectionButton BackButton;

		private IEnumerator yAnimateRank;

		private Util.GameMode m_GameMode;

		private static IEnumerator coroutine;

		private int remainAddRangeCount;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		private int GetRemainAddRange()
		{
			return 0;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		public IEnumerator StartResult()
		{
			return null;
		}

		private void ToRetryDuel(Util.GameMode gameMode, int tid = 0)
		{
		}

		private void ToRetryMatching(PvpMenuDefine.MatchingType matchingType, int tid = 0)
		{
		}

		public void OnClickRetry(Util.GameMode gameMode, int tournamentId)
		{
		}

		public void OnClickSave(Util.GameMode mode, long did, int eventID)
		{
		}
	}
}
