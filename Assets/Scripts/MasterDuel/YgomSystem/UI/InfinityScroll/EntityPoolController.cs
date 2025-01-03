using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.InfinityScroll
{
	public class EntityPoolController
	{
		public class WaitFocusData
		{
			public bool isExists => false;

			public int dataIndex
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public SelectionItem currentItem
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isSelectItem
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

			public bool isInitializeSelect
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

			public Action onComplete
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public WaitFocusData Clone()
			{
				return null;
			}

			public void Clear()
			{
			}

			public void Assign(int dataIndex, bool isSelectItem, bool isInitializeSelect, Action onComplete, SelectionItem currentItem)
			{
			}
		}

		private enum LayoutType
		{
			Grid = 0,
			Horizontal = 1,
			Vertical = 2
		}

		private InfinityScrollView m_Owner;

		private GridLayoutGroup.Axis m_ScrollAxis;

		private RectOffset m_Padding;

		private Vector2 m_ViewportSize;

		private ExtendedScrollRect m_ScrollRect;

		private GridLayoutGroup m_LayoutGroup;

		private HorizontalLayoutGroup m_HorizontalLayoutGroup;

		private VerticalLayoutGroup m_VerticallLayoutGroup;

		private LayoutType m_LayoutType;

		private int m_ConstraintCount;

		private Vector2 m_Spacing;

		private List<GameObject> m_Templates;

		private int m_NumTemplates;

		private List<int> m_TemplateList;

		private List<int> m_PrevTemplateList;

		private List<Vector2> m_UnitSize;

		private Dictionary<GameObject, int> m_EntityDataIndexTable;

		private List<Stack<GameObject>> m_FreeEntityStack;

		private List<GameObject> m_ActiveEntityList;

		private int m_DataCount;

		private bool m_IsReady;

		private WaitFocusData m_WaitFocusData;

		public bool useViewportSize;

		private Action<GameObject> m_OnCreatedEntityCallback;

		private Action<GameObject> m_OnActivateEntityCallback;

		private Action<GameObject, int> m_OnUpdateEntityCallback;

		private Action<GameObject, int, bool, bool> m_OnFocusEntityCallback;

		private Action<GameObject> m_OnDeactivateEntityCallback;

		private Action<GameObject, int, bool> m_OnRemoveEntityCallback;

		private Func<int, (bool, float)> m_CustomMoveContentToFitDataFunc;

		private bool m_IsInstantiateAllTemplates;

		private List<int> itemCount;

		private List<int> itemLimmit;

		protected int m_LastLineItemCountInViewCache;

		private IEnumerator m_ReserveTemplateRoutine;

		private IEnumerator m_UpdateDataCountAsync;

		private IEnumerator m_UpdateDataAsync;

		public WaitFocusData waitFocusData => null;

		public bool isExistsFocusWaitData => false;

		public int dataCount => 0;

		protected int m_LastLineItemCount => 0;

		protected int m_LastLineItemCountInView => 0;

		protected bool m_IsHorizontalScroll => false;

		public bool isHorizontalScroll => false;

		protected float m_CurrentContentPos => 0f;

		protected float m_ViewSizeAlongScrollDirection => 0f;

		protected float m_SpacingAlongScrollDirection => 0f;

		public int beginDataIndex => 0;

		protected int m_DataIndexOfListBegin => 0;

		protected int m_VerticalOffset => 0;

		protected int m_HorizontalOffset => 0;

		public int endDataIndex => 0;

		protected int m_DataIndexOfListEnd => 0;

		protected int m_PaddingBias => 0;

		protected int m_PaddingBegin => 0;

		protected int m_PaddingEnd => 0;

		public bool isReady => false;

		public bool isCompletedReserve => false;

		public bool isMoving => false;

		public IReadOnlyList<GameObject> activeEntityList => null;

		public int activeEntityLineCount => 0;

		public int DataIndexOfItemBegin => 0;

		public int DataIndexOfItemEnd => 0;

		public int constraintCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int contentCount => 0;

		public Action<GameObject> onCreatedEntityCallback
		{
			set
			{
			}
		}

		public Action<GameObject> onActivateEntityCallback
		{
			set
			{
			}
		}

		public Action<GameObject, int> onUpdateEntityCallback
		{
			set
			{
			}
		}

		public Action<GameObject, int, bool, bool> onFocusEntityCallback
		{
			set
			{
			}
		}

		public Action<GameObject> onDeactivateEntityCallback
		{
			set
			{
			}
		}

		public Action<GameObject, int, bool> onRemoveEntityCallback
		{
			set
			{
			}
		}

		public Func<int, (bool, float)> customMoveContentToFitDataFunc
		{
			set
			{
			}
		}

		protected float m_UnitSizeAlongScrollDirection(int templateIdx)
		{
			return 0f;
		}

		public void Initialize(EntityPoolSettings entityPoolSettings, InfinityScrollView owner, ExtendedScrollRect scrollRect, List<GameObject> templates, Action onCompleteCallback = null)
		{
		}

		public void ReserveTemplate(int templateIdx = 0, int asyncPerFrame = 0, Action onComplete = null)
		{
		}

		public void TerminateReserve()
		{
		}

		private IEnumerator yReserveTemplate(int templateIdx = 0, int asyncPerFrame = 0, Action onComplete = null)
		{
			return null;
		}

		public void UpdatePaddingSize()
		{
		}

		public void UpdateViewportRectSize()
		{
		}

		protected void InitContentRT(EntityPoolSettings entityPoolSettings)
		{
		}

		protected IEnumerator ReadRectSize(EntityPoolSettings entityPoolSettings, List<GameObject> templates, Action onCompleteCallback = null)
		{
			return null;
		}

		private void OnScrollValueChanged(Vector2 bias)
		{
		}

		protected void InstantiateTemplate(GameObject template, int templateIdx = 0)
		{
		}

		protected bool AddTemplateInstantance(int templateIdx)
		{
			return false;
		}

		protected void InitLayout(EntityPoolSettings entityPoolSettings, object layout)
		{
		}

		protected void RemakeLayout(GridLayoutGroup gridLayoutGroup)
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

		public void UpdateContentPos()
		{
		}

		public void CheckWaitFocusData()
		{
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

		protected bool MoveContentToFitDataPos(int dataindex)
		{
			return false;
		}

		public void CancelMoving()
		{
		}

		protected void MoveContent(float targetpos)
		{
		}

		private int ClampDataIndex(int index)
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

		protected float GetContentPosByDataLine(int lineindex)
		{
			return 0f;
		}

		protected int GetDataLineByContentPos(float pos)
		{
			return 0;
		}

		public virtual void UpdateDataCount(int dataCount, List<int> templateList = null)
		{
		}

		public virtual void UpdateDataCountAsync(int dataCount, List<int> templateList = null, int updatePerFrame = 1, Action onComplete = null)
		{
		}

		private void InnerUpdateDataCount(int dataCount, List<int> templateList = null)
		{
		}

		private IEnumerator yInnerUpdateDataCountAsync(int dataCount, List<int> templateList = null, int updatePerFrame = 1, Action onComplete = null)
		{
			return null;
		}

		public void UpdateData()
		{
		}

		public void UpdateDataAsync(int updatePerFrame, Action onComplete)
		{
		}

		private IEnumerator yUpdateDataAsync(int updatePerFrame, Action onComplete)
		{
			return null;
		}

		public bool FocusItemByDataIndex(int dataindex, bool selectItem = true, bool isInitializeSelect = false, Action onComplete = null)
		{
			return false;
		}

		public bool TryFocusInnerViewport(bool selectItem, bool isInitializeSelect = false, Action onComplete = null)
		{
			return false;
		}

		public void ResetContentPosition()
		{
		}

		public void ImmediateApplyMovement()
		{
		}

		public float GetTemplateSizeAlongScrollDirection(int templateIdx)
		{
			return 0f;
		}

		public GameObject GetItemByListPos(int x, int y)
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

		public int GetEntityIndexByDataIndex(int dataindex)
		{
			return 0;
		}

		public int GetLineByDataIndex(int dataindex)
		{
			return 0;
		}

		public GameObject GetEntityByDataIndex(int dataindex)
		{
			return null;
		}

		public T GetEntityByDataIndex<T>(int dataindex)
		{
			return default(T);
		}

		public int GetDataIndexByEntity(GameObject entity)
		{
			return 0;
		}

		public int GetTemplateIndexByDataIndex(int dataindex)
		{
			return 0;
		}

		public int GetTemplateIndexByEntity(GameObject entity)
		{
			return 0;
		}

		public string GetTemplateLabelByDataIndex(int dataindex)
		{
			return null;
		}

		public string GetTemplateLabelByTemplateIndex(int templateindex)
		{
			return null;
		}

		public int GetSideIndex(int baseIdx, PadInputDirection direction)
		{
			return 0;
		}

		public int GetSideIndexUp(int baseIdx)
		{
			return 0;
		}

		public int GetSideIndexDown(int baseIdx)
		{
			return 0;
		}

		public int GetSideIndexLeft(int baseIdx)
		{
			return 0;
		}

		public int GetSideIndexRight(int baseIdx)
		{
			return 0;
		}

		public bool IsEdgeByDataIndex(int dataindex, PadInputDirection checkDirection)
		{
			return false;
		}

		public bool IsEdgeLeftDataIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeRightDataIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeUpDataIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeDownDataIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeHeadItemIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeTailItemIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeStartSideItemIndex(int dataindex)
		{
			return false;
		}

		public bool IsEdgeEndSideItemIndex(int dataindex)
		{
			return false;
		}

		public bool IsFractionItemIndex(int dataindex)
		{
			return false;
		}
	}
}
