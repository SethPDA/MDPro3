using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class GenericCardListController : MonoBehaviour, IGenericScrollViewSupport
	{
		public enum ListType
		{
			NONE = 0,
			EXTRA_TEAM0 = 1,
			EXTRA_TEAM1 = 2,
			GRAVE_TEAM0 = 3,
			GRAVE_TEAM1 = 4,
			EXCLUDED_TEAM0 = 5,
			EXCLUDED_TEAM1 = 6,
			OVERLAYMATLIST_TEAM0 = 7,
			OVERLAYMATLIST_TEAM1 = 8,
			INHERITEFFECTLIST = 9
		}

		public enum ListStatue
		{
			OPEN = 0,
			OPENING = 1,
			UPDATING = 2,
			CLOSE = 3,
			CLOSING = 4
		}

		private const string PREHAB_PATH = "Prefabs/Duel/UI/GenericCardList";

		private const string PREHAB_PATH_MOBILE = "Prefabs/Duel/UI/GenericCardList_Mobile";

		private const string LABEL_EO_SCROLLVIEW = "ScrollView";

		private const string LABEL_EO_LISTTYPEICON = "ListTypeIcon";

		private const string LABEL_EO_SCROLLUP = "ScrollUp";

		private const string LABEL_EO_SCROLLDOWN = "ScrollDown";

		private const string LABEL_EO_CARDIMAGE = "CardImage";

		private const string LABEL_EO_CARDMASK = "CardMask";

		private const string LABEL_EO_STATUEROOT = "StatueRoot";

		private const string LABEL_EO_FROMEXTRAICON = "FromExtraIcon";

		private const string LABEL_EO_STATUEICON = "Icon";

		private const string LABEL_EO_LINKMARKERS = "LinkMarkers";

		private const string LABEL_EO_STATUETEXT = "Text";

		private const string LABEL_EO_TEXTTOTALCOUNT = "TextTotalCount";

		private const string LABEL_EO_WINDOW = "Window";

		private const string LABEL_TWEEN_SHOW = "Show";

		private const string LABEL_TWEEN_HIDE = "Hide";

		private const string LABEL_TWEEN_CHANGELIST = "ChangeList";

		private const string LABEL_TWEEN_MOVEIN = "MoveIn";

		private const string LABEL_TWEEN_MOVEOUT = "MoveOut";

		private const string LABEL_TWEEN_CHANGELISTSTEP1 = "ChangeList_Step1";

		private const string LABEL_TWEEN_CHANGELISTSTEP0 = "ChangeList_Step0";

		private ListType m_Type;

		private ElementObjectManager m_Eom;

		private GenericScrollView m_Gsv;

		private Tween m_TweenClose;

		private Tween m_TweenOpen;

		private GameObject m_Window;

		private Dictionary<ListType, List<int>> m_DataListTable;

		private Dictionary<int, int> m_CardSourceTable;

		private int m_TargetUniqueId;

		private DuelClient m_Host;

		private bool m_CloseDuelLog;

		public ListStatue Statue
		{
			[CompilerGenerated]
			get
			{
				return default(ListStatue);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isOpen => false;

		private List<int> m_CurrentDataList => null;

		public static void Create(Transform parent, DuelClient host, UnityAction<GenericCardListController> onFinish)
		{
		}

		public void UpdateList(int team, int position)
		{
		}

		public void UpdateAsEffectList(int team, int position)
		{
		}

		public bool Show()
		{
			return false;
		}

		public bool Close()
		{
			return false;
		}

		public void SetAlpha(float alpha)
		{
		}

		public void ChangeList()
		{
		}

		public void ChangeListImpl()
		{
		}

		public void UpdateContent()
		{
		}

		public void SetShortkeyIconVisible(bool visible)
		{
		}

		private void InitComponent()
		{
		}

		private void InitDataListTable()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateDataList()
		{
		}

		private void Open()
		{
		}

		private (int, int) GetOwnerAndLocateByListType(ListType type)
		{
			return default((int, int));
		}

		private ListType GetListTypeByOwnerAndLocate(int owner, int locate)
		{
			return default(ListType);
		}

		private void SetUidCard(int dataindex, GameObject gob)
		{
		}

		private void SetCidCard(int dataindex, GameObject gob)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void OnGsvStanby()
		{
		}

		private void SetStatues(ElementObjectManager eom, int cardid)
		{
		}

		private void SetCardPicture(RawImage cardpicture, GameObject cardmask, int uid)
		{
		}

		private void SetLinkMarkers(ElementObjectManager eom, int linkmask, int linknum)
		{
		}

		private void SetLevel(ElementObjectManager eom, int level)
		{
		}

		private void SetRank(ElementObjectManager eom, int rank)
		{
		}

		public void UpdateCardSourceTable(int uid, int pos)
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnItemExit(GameObject gob, int dataindex)
		{
		}

		protected void Initialize()
		{
		}
	}
}
