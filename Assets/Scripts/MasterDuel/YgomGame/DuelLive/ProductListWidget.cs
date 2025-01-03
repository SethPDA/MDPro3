using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DuelLive
{
	public class ProductListWidget : ElementWidgetBase
	{
		public class Context
		{
			public List<int> templateIdxList;

			public readonly List<string> headerLabels;

			public readonly List<IProductContext[]> productContainers;

			public readonly List<IProductContext> productCtxs;

			public string emptyMessageText;

			public bool hasHeader => false;

			public bool hasProduct => false;
		}

		private const string k_ELabelGroupHeaderWidget = "ProductGroupHeader";

		private const string k_ELabelGroupEmptyWidget = "ProductGroupEmpty";

		private const string k_ELabelProductContainer = "ProductContainer";

		private const string k_ELabelProductList = "ProductList";

		private const string k_ELabelInFilterMessageText = "InFilterMessageText";

		private const string k_ELabelEmptyMessageText = "EmptyMessageText";

		private readonly DuelLiveRootWidget m_Owner;

		public readonly Selector selector;

		private readonly InfinityScrollView m_ScrollView;

		private readonly TMP_Text m_EmptyMessageText;

		private ExtendedScrollRect m_ScrollRectCache;

		private float m_GroupHeaderHeight;

		private float m_GroupEmptyHeight;

		private float m_ProductContainerHeight;

		private ElementObjectManager m_ProductWidgetPref;

		private ElementObjectManager m_ProductRandomWidgetPref;

		private ElementObjectManager m_ProductVSWidgetPref;

		private ElementObjectManager m_ProductEventWidgetPref;

		private ElementObjectManager m_ProductOfficialAccountWidgetPref;

		private ElementObjectManager m_ProductCommingSoonWidgetPref;

		private readonly Dictionary<GameObject, ProductGroupHeaderWidget> m_HeaderWidgetMap;

		private readonly Dictionary<GameObject, ProductContainerWidget> m_ContainerWidgetMap;

		private readonly Dictionary<GameObject, ProductWidget> m_ProductWidgetMap;

		private readonly List<float> m_EntityVirtualPositions;

		private RectOffset m_BasePadding;

		private RectOffset m_Padding;

		private float m_Spacing;

		private Context m_Context;

		private bool m_EntityVirtualPositionsDirty;

		private int m_PreSelectedDataIdx;

		private int m_PreSelectedSectionDataIdx;

		private Coroutine m_FocusProductRoutine;

		public ExtendedScrollRect scrollRect => null;

		public int containerLength
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

		public int largeItemContainerLength
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

		public int productTemplateIdx
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

		public int containerTemplateIdx
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

		public int headerTemplateIdx
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

		public int emptyTemplateIdx
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

		public int randomTemplateIdx
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

		public int vsTemplateIdx
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

		public int eventTemplateIdx
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

		public int officialAccountTemplateIdx
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

		public int commingSoonTemplateIdx
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

		public List<float> entityVirtualPositions => null;

		public RectOffset padding => null;

		public float spacing => 0f;

		public bool isContainerList => false;

		public InfinityScrollView scrollView => null;

		public event Action<ProductWidget> onClickedProductEvent
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

		public int GetHeaderIndexByCurrentPos()
		{
			return 0;
		}

		public int GetHeaderIndexByDataIdx(int dataIdx)
		{
			return 0;
		}

		public ProductWidget SearchProductWidget(int dataIdx, int sectionDataIdx = 0)
		{
			return null;
		}

		public ProductListWidget(ElementObjectManager eom, DuelLiveRootWidget owner, bool frag = false)
			: base(null)
		{
		}

		public void Initialize(GameObject productContainerWidgetPref, GameObject productGroupHeaderPref, GameObject productGroupEmptyPref, GameObject productWidgetPref, GameObject productRandomWidgetPref, GameObject productVSWidgetPref, GameObject productEventWidgetPref, GameObject productOfficialAccountWidgetPref, GameObject productCommingSoonWidgetPref, int reservePerFrame = 0, Action onComplete = null)
		{
		}

		public void ResetPreIdx()
		{
		}

		public void SetZeroProducts(int asyncCnt = 0, bool resetPos = true, Action onComplete = null)
		{
		}

		public void SetProducts(Context ctx, int asyncCnt = 0, bool resetPos = true, Action onComplete = null)
		{
		}

		private void UpdatePadding()
		{
		}

		private void CalcCheckEntityVirtualPositions()
		{
		}

		private GameObject AssginPref(GameObject pref)
		{
			return null;
		}

		private float ReadTemplateHeight(GameObject pref)
		{
			return 0f;
		}

		private void SetEntityVirtualPositions(int idx, float value)
		{
		}

		public void JumpToDirection(PadInputDirection dir)
		{
		}

		public bool TrySelectHeadProduct(bool isInitializeSelect = false, bool immediate = false)
		{
			return false;
		}

		private void OnCreatedEntity(GameObject entity)
		{
		}

		private void OnActivateEntity(GameObject entity)
		{
		}

		private void OnDeactivateEntity(GameObject entity)
		{
		}

		private bool OnFocusSelectEntity(GameObject entity, int dataIndex, bool isInitializeSelect = false)
		{
			return false;
		}

		public bool OnSelectorSelectored()
		{
			return false;
		}

		public bool IsExistsCurrentProduct(bool checkSectionIdx = false)
		{
			return false;
		}

		public int SearchHeaderDataIdx(int headerIdx)
		{
			return 0;
		}

		public int SearchHeadProductDataIdx()
		{
			return 0;
		}

		public void FocusHeader(int headerIdx, bool immediate = false)
		{
		}

		public SelectionItem SearchPreSelectedProduct()
		{
			return null;
		}

		public void FocusProduct(int dataIdx, int sectionDataIdx = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
		{
		}

		private (bool, float) MoveContentToFitDataPos(int dataIndex)
		{
			return default((bool, float));
		}

		private IEnumerator yFocusProduct(int dataIdx, int sectionDataIdx = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
		{
			return null;
		}

		public bool TryFocusPreSelectedProduct(bool selectItem = true, bool isInitializeSelect = false)
		{
			return false;
		}

		public bool TryFocusHeadProduct(bool selectItem = true, bool isInitializeSelect = false)
		{
			return false;
		}

		private bool IsSelectableEntityIndex(int dataIndex)
		{
			return false;
		}

		private IReadOnlyList<(SelectionItem, int, int)> CollectSelectionItems(GameObject entity)
		{
			return null;
		}

		private void OnUpdateEntity(GameObject entity, int dataIdx)
		{
		}

		private void OnClickContainersWidget(ProductContainerWidget containerWidget, ProductWidget productWidget)
		{
		}

		private void OnClickWidget(ProductWidget productWidget)
		{
		}

		private void OnSelectedProduct(int dataIdx, int sectionIdx)
		{
		}
	}
}
