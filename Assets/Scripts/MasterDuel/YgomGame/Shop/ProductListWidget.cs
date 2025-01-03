using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Shop
{
	public class ProductListWidget : ElementWidgetBase
	{
		private const string k_ELabelProductList = "ProductList";

		private const string k_ELabelInFilterMessageText = "InFilterMessageText";

		private const string k_ELabelEmptyMessageText = "EmptyMessageText";

		public readonly Selector selector;

		private readonly InfinityScrollView m_ScrollView;

		private readonly GameObject m_InFilterMessageText;

		private readonly TMP_Text m_EmptyMessageText;

		private ExtendedScrollRect m_ScrollRectCache;

		private IProductListWidgetHandler m_Handler;

		private IProductListWidgetListener m_Listener;

		private readonly Dictionary<GameObject, ProductGroupHeaderWidget> m_HeaderWidgetMap;

		private readonly Dictionary<GameObject, ProductContainerWidget> m_ContainerWidgetMap;

		private readonly List<float> m_EntityVirtualPositions;

		private RectOffset m_BasePadding;

		private RectOffset m_Padding;

		private float m_Spacing;

		private bool m_EntityVirtualPositionsDirty;

		private readonly List<int> m_TemplateIdxList;

		private readonly List<string> m_HeaderLabels;

		private readonly List<ProductContainerWidget.Context> m_ProductContainerCtxs;

		private readonly Dictionary<int, Dictionary<int, Dictionary<int, int>>> m_HeaderDataIdxMap;

		public bool filteredVisible;

		public string emptyMessageText;

		private int m_PreSelectedDataIdx;

		private int m_PreSelectedContentIdx;

		private ExtendedScrollRect scrollRect => null;

		private List<float> entityVirtualPositions => null;

		public bool isReady => false;

		public bool isMoving => false;

		public List<ProductContainerWidget.Context> productContainerCtxs => null;

		private int GetHeaderIdx(int categoryId, int subCategoryId, int sectionId)
		{
			return 0;
		}

		private (int, int) GetProductIdx(int shopId)
		{
			return default((int, int));
		}

		private int GetHeadProductId(int categoryId, int subCategoryId = 0, int sectionId = 0)
		{
			return 0;
		}

		public ProductContext GetProductContextByDataIdx(int dataIdx, int containerIdx)
		{
			return null;
		}

		public ProductWidget TryGetProductWidgetByDataIdx(int dataIdx, int containerIdx)
		{
			return null;
		}

		public (int, int, int) GetIdByCurrentPos()
		{
			return default((int, int, int));
		}

		public ProductListWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(IProductListWidgetHandler handler, IProductListWidgetListener listener, int reservePerFrame = 0, Action onComplete = null)
		{
		}

		public void ResetPreIdx()
		{
		}

		public void UpdateDataCount(int asyncCnt = 0, bool resetPos = true, Action onComplete = null)
		{
		}

		public void UpdateContentPos()
		{
		}

		public void UpdateData()
		{
		}

		private void UpdatePadding()
		{
		}

		private void CalcCheckEntityVirtualPositions()
		{
		}

		private void SetEntityVirtualPositions(int idx, float value)
		{
		}

		public void SetScrollEnable(bool enable)
		{
		}

		public bool FocusProduct(int shopId, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
		{
			return false;
		}

		public bool FocusHeadProduct(int categoryId, int subCategoryId = 0, int sectionId = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
		{
			return false;
		}

		public bool FocusDataIndex(int dataIdx, int contentIdx = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
		{
			return false;
		}

		public bool FocusHeader(int categoryId, int subCategoryId, int sectionId, bool immediate = false)
		{
			return false;
		}

		private bool FocusPreSelectedProduct(bool selectItem = true, bool isInitializeSelect = false)
		{
			return false;
		}

		public void JumpToDirection(PadInputDirection dir)
		{
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

		public bool SelectorSelect(bool isInitializeSelect = false)
		{
			return false;
		}

		private (bool, float) MoveContentToFitDataPos(int dataIndex)
		{
			return default((bool, float));
		}

		private bool IsSelectableEntityIndex(int dataIndex)
		{
			return false;
		}

		private void OnUpdateEntity(GameObject entity, int dataIdx)
		{
		}

		private void OnSelectedContainersProduct(int dataIdx, int contentIdx)
		{
		}
	}
}
