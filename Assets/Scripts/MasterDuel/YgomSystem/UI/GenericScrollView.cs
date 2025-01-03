using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI
{
	public class GenericScrollView : MonoBehaviour
	{
		protected enum Alignment
		{
			Begin = 0,
			Center = 1,
			End = 2
		}

		private const string LABEL_EO_TEMPLATE = "template";

		[SerializeField]
		protected GridLayoutGroup.Axis m_ScrollMode;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected RectOffset m_Padding;

		[SerializeField]
		protected Alignment m_Alignment;

		[SerializeField]
		protected int m_ConstraintCount;

		protected IGenericScrollViewSupport m_IGsvHelper;

		protected Selector m_Selector;

		protected ElementObjectManager m_EOManager;

		protected RectTransform m_ContentRT;

		protected Vector2 m_ViewportSize;

		protected ExtendedScrollRect m_ScrollRect;

		protected GridLayoutGroup m_LayoutGroup;

		protected Dictionary<SelectionItem, int> m_ItemDataIndexTable;

		protected Dictionary<SelectionItem, GameObject> m_SIGOTable;

		protected Stack<SelectionItem> m_FreeItemStack;

		protected List<SelectionItem> m_ActiveItemList;

		protected int m_DataCount;

		protected Vector2 m_UnitSize;

		protected int m_WaitForSelectDataIndex;

		protected bool m_IsStandby;

		protected IEnumerator m_yMoveContentImpl;

		protected GameObject m_Template;

		private int m_WaitCount;

		public int ConstraintCount => 0;

		public int DataIndexOfItemBegin => 0;

		public int DataIndexOfItemEnd => 0;

		public int CurrentItemIndex => 0;

		public int CurrentDataIndex => 0;

		public int ItemCount => 0;

		public Vector2 UnitSize => default(Vector2);

		public Selector selector => null;

		public ScrollRect scrollrect => null;

		public bool isMoving => false;

		protected int m_LastLineItemCount => 0;

		protected int m_LastLineItemCountInView => 0;

		protected bool m_IsHorizontalScroll => false;

		protected float m_CurrentContentPos => 0f;

		protected float m_ViewSizeAlongScrollDirection => 0f;

		protected float m_UnitSizeAlongScrollDirection => 0f;

		protected float m_SpacingAlongScrollDirection => 0f;

		protected SelectionItem m_CurrentItem => null;

		protected RectTransform m_CurrentItemRT => null;

		protected int m_DataIndexOfListBegin => 0;

		protected int m_VerticalOffset => 0;

		protected int m_HorizontalOffset => 0;

		protected int m_DataIndexOfListEnd => 0;

		protected int m_PaddingBias => 0;

		protected int m_PaddingBegin => 0;

		protected int m_PaddingEnd => 0;

		protected bool m_IsMoving => false;

		public bool isStandby => false;

		public void Initialzize(IGenericScrollViewSupport igsvsupport, string templateLabelName = null)
		{
		}

		public virtual void UpdateDataCount(int dataCount)
		{
		}

		public void UpdateData()
		{
		}

		public SelectionItem GetItemByListPos(int x, int y)
		{
			return null;
		}

		public (int, int) GetListPosByItemIndex(int itemIndex)
		{
			return default((int, int));
		}

		public int GetItemIndexByListPos(int x, int y)
		{
			return 0;
		}

		public int GetDataIndexByItemIndex(int itemIndex)
		{
			return 0;
		}

		public int GetDataIndexByListPos(int x, int y)
		{
			return 0;
		}

		public int GetItemIndexByDataIndex(int dataindex)
		{
			return 0;
		}

		public SelectionItem GetItemByDataIndex(int dataindex)
		{
			return null;
		}

		public T GetItemByDataIndex<T>(int dataindex)
		{
			return default(T);
		}

		public bool SelectItemByDataIndex(int dataindex, bool forcemovetofirst = false, bool forceInitializeSelect = false)
		{
			return false;
		}

		public void ResetContentPosition()
		{
		}

		public float GetContentPosByDataLine(int index)
		{
			return 0f;
		}

		public float GetItemPosByDataLine(int index)
		{
			return 0f;
		}

		public void DeltaMove(float deltamove)
		{
		}

		protected void InitContentRT()
		{
		}

		protected IEnumerator ReadRectSize(string templateLabelName = "template")
		{
			return null;
		}

		protected void InstantiateTemplate()
		{
		}

		private IEnumerator InstantiateImpl(int itemcount)
		{
			return null;
		}

		protected void InitLayout()
		{
		}

		protected bool AddTopItem()
		{
			return false;
		}

		protected bool AddBottomItem()
		{
			return false;
		}

		protected bool RemoveTopItem()
		{
			return false;
		}

		protected bool RemoveBottomItem()
		{
			return false;
		}

		protected void UpdateContentPos()
		{
		}

		protected void CheckWaitForSelectData()
		{
		}

		protected int GetDataLineByContentPos(float pos)
		{
			return 0;
		}

		protected bool AddItem(int dataindex, int posInHierachy)
		{
			return false;
		}

		protected bool RemoveItem(int itemindex)
		{
			return false;
		}

		protected void RemoveAllItem()
		{
		}

		protected void ChangeContentSize()
		{
		}

		protected virtual void PadInputCallBack(PadInputDirection direction)
		{
		}

		protected void PadInputCallBackUp()
		{
		}

		protected void PadInputCallBackDown()
		{
		}

		protected void PadInputCallBackLeft()
		{
		}

		protected void PadInputCallBackRight()
		{
		}

		protected int GetNextDataIndexByPadInput(PadInputDirection direction)
		{
			return 0;
		}

		protected bool IsIndexInSameLine(int index0, int index1)
		{
			return false;
		}

		protected bool CheckItemIndexCorrect(int itemindex)
		{
			return false;
		}

		protected bool CheckDataIndexCorrect(int dataindex)
		{
			return false;
		}

		protected bool CheckItemInViewByDataIndex(int dataindex)
		{
			return false;
		}

		protected void MoveContent(float targetpos)
		{
		}

		protected bool MoveContentToFitDataPos(int dataindex, bool forcemovetofirst)
		{
			return false;
		}

		protected virtual void SetItemTransitionMode(ref SelectionItem item, int dataindex)
		{
		}

		protected virtual void InnerItemInitialize(int itemindex, SelectionItem selectionItem)
		{
		}

		protected virtual void InnerItemActivate(SelectionItem selitem)
		{
		}

		protected virtual void InnerItemDeactivate(SelectionItem selitem)
		{
		}
	}
}
