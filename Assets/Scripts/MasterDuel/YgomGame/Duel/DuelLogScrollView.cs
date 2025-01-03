using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
//using UnityEngine.EventSystems;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DuelLogScrollView : MonoBehaviour//, IBeginDragHandler, IEventSystemHandler
	{
		public class OnItemUpdate : UnityEvent<GameObject, int>
		{
			public OnItemUpdate()
			{
				//((UnityEvent<T0, T1>)(object)this)._002Ector();
			}
		}

		[HideInInspector]
		public Dictionary<string, GetInt> m_DataNumDict;

		public OnItemUpdate onItemUpdate;

		public UnityEvent onReady;

		public bool autoScroll;

		protected Dictionary<string, Stack<Transform>> m_ItemStackDict;

		protected Dictionary<string, GameObject> m_PrehabDict;

		protected List<string> m_TemplateLabelList;

		protected List<float> m_ItemBiaslList;

		protected List<GameObject> m_UsedItemQueue;

		protected List<SelectionItemPair> m_SbtnPairList;

		protected ElementObjectManager m_EOManager;

		protected RectTransform m_ContentRT;

		protected RectTransform m_ViewportRT;

		protected RectTransform m_ScrollViewRT;

		protected Selector m_Selector;

		protected ExtendedScrollRect m_ScrollRect;

		protected DuelClient m_Host;

		private const string LABEL_EO_CONTENT = "content";

		private const string LABEL_EO_VIEWPORT = "viewport";

		private const string LABEL_EO_HIDDENPORT = "hiddenport";

		private const string LABEL_EO_PANEL = "AutoScrollPanel";

		private const string LABEL_EO_STATUE = "AutoScrollStatue";

		private const string LABEL_EO_SCROLLBAR = "ScrollBar";

		private int m_InitialTopPadding;

		private int m_TopitemDataindex;

		public int topitemDataindex => 0;

		public int bottomitemDataindex => 0;

		public Selector selector => null;

		public ExtendedScrollRect scrollrect => null;

		public List<string> m_DataLabelList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected float m_Spacing => 0f;

		private int m_BottomitemDataindex => 0;

		private SelectionItem[] m_TopSelectionItems => null;

		private SelectionItem[] m_BottomSelectionItems => null;

		public void Initialzize(ref List<string> templateLabelList, DuelClient host)
		{
		}

		public bool IsTopItem(SelectionItem item)
		{
			return false;
		}

		public bool IsBottomItem(SelectionItem item)
		{
			return false;
		}

		public void AddDataLabel(string label)
		{
		}

		public RectTransform GetTopItemRT()
		{
			return null;
		}

		public RectTransform GetBottomItemRT()
		{
			return null;
		}

		public SelectionItem GetBottomSItem()
		{
			return null;
		}

		public SelectionItem GetTopSItem()
		{
			return null;
		}

		public void UpdateContent()
		{
		}

		protected void SetSbtnPairRightTransition(SelectionItemPair sbtnpair)
		{
		}

		protected void SetSbtnPairLeftTransition(SelectionItemPair sbtnpair)
		{
		}

		protected void SetSbtnPairVerticalTransition(SelectionItemPair sbtnpair0, SelectionItemPair sbtnpair1)
		{
		}

		protected (int, int, float) GetDataIndexRange()
		{
			return default((int, int, float));
		}

		protected int GetDataIndexByPos(float pos)
		{
			return 0;
		}

		private void HideItem(GameObject obj)
		{
		}

		private void ShowItem(GameObject obj, bool istop)
		{
		}

		private Transform GetFreeItemByLabel(string label)
		{
			return null;
		}

		private bool AddItem(int index, bool top)
		{
			return false;
		}

		private bool RemoveItem(bool top)
		{
			return false;
		}

		private void RemoveAllItem()
		{
		}

		private void ChangeContentSize()
		{
		}

		private void Update()
		{
		}

		private bool AddTopItem()
		{
			return false;
		}

		private bool AddBottomItem()
		{
			return false;
		}

		private bool RemoveTopItem()
		{
			return false;
		}

		private bool RemoveBottomItem()
		{
			return false;
		}

		public void MoveUp()
		{
		}

		public void MoveDown()
		{
		}

		public void MoveToLastLabel(string targetlabel)
		{
		}

		public void MoveToNextLabel(string targetlabel)
		{
		}

		//public void OnBeginDrag(PointerEventData eventData)
		//{
		//}

		private void MoveToTargetData(int dataindex, bool ontop = true)
		{
		}

		private void MoveToPosition(Vector3 targetpos)
		{
		}
	}
}
