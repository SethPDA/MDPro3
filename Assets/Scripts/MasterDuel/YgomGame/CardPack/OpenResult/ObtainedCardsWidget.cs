using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardPack.OpenResult
{
	public class ObtainedCardsWidget : ElementWidgetBase
	{
		private class AutoSelectHelper
		{
			private List<SelectionItem> m_SortTargetSelections;

			private Dictionary<SelectionItem, float> m_SortAmounts;

			public bool TrySelect(SelectionItem fromItem, Vector2 dir, Selector[] ignoreSelectors = null)
			{
				return false;
			}
		}

		private const string k_ELabelScrollView = "ScrollView";

		private const string k_ELabel_Entity_PackCardTemplate = "ScrollView/PackCardGroupTemplate/PackCardTemplate";

		private const string k_OLabel_Template_Default = "Default";

		private const string k_OLabel_Template_Expand = "Expand";

		private readonly ToggleWidget m_ShowOwnedNumToggle;

		private readonly InfinityScrollView m_ScrollView;

		private readonly Dictionary<GameObject, CardWidget[]> m_CardWidgetGroupMap;

		private readonly List<int> m_SecretShopIdsCache;

		private List<object> m_ListDatas;

		private List<object> m_DrawListDatas;

		private List<int> m_TemplateIdxs;

		public readonly List<object> workDrawDatas;

		public List<object> workExtraGroupDatas;

		public bool workIsSendGift;

		public bool isExpand;

		public bool pulldownSecretsEnable;

		private ElementObjectManager m_PackCardTemplatePref;

		private CardWidget m_SelectedPulldownOwner;

		private AutoSelectHelper m_AutoSelectHelper;

		private Selector[] m_AutoSelectIgnoreSelectors;

		private List<object> m_CardDetailMrksCache;

		private List<object> m_CardDetailPremiumsCache;

		public InfinityScrollView scrollView => null;

		public ObtainedCardsWidget(ElementObjectManager eom, ElementObjectManager showOwnedNumEom)
			: base(null)
		{
		}

		public void ActivateScroll(Action onComplete)
		{
		}

		private void InitLayout(List<string> headerLabels, bool dispSendGift)
		{
		}

		private void OnCreatedEntity(GameObject gob)
		{
		}

		private IReadOnlyList<(SelectionItem, int, int)> OnCollectEntitySelectionItems(GameObject entity)
		{
			return null;
		}

		private void OnUpdateEntity(GameObject gob, int dataindex)
		{
		}

		private bool IsSelectableDataIndex(int dataIndex)
		{
			return false;
		}

		private bool OnCustomDirectionTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		private void OnCreatedObtainWidget(CardWidget cardWidget)
		{
		}

		private void SetObtainCardWidget(CardWidget cardWidget, int dataindex, bool isDefaultItem)
		{
		}

		private void CloseSelectedPulldown()
		{
		}

		private void OpenSelectedPulldown()
		{
		}

		private void OnClickCard(CardWidget cardWidget)
		{
		}

		private void OnClickPulldown(CardWidget cardWidget)
		{
		}

		private void OnSelectedCard(CardWidget cardWidget)
		{
		}

		private void OnSelectedPulldown(CardWidget cardWidget)
		{
		}

		private void OnDeselectedCard(CardWidget cardWidget)
		{
		}

		private void OnDeselectedPulldown(CardWidget cardWidget)
		{
		}

		public void JumpToDirection(PadInputDirection direction)
		{
		}
	}
}
