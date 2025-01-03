using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class InformButtonGroupWidget : ElementWidgetBase
	{
		private readonly int k_TemplateIdx_Normal;

		private readonly int k_TemplateIdx_Small;

		private readonly int k_TemplateIdx_SmallMB;

		private readonly int k_TemplateIdx_Highlight;

		private readonly string k_ELabelText;

		private readonly ElementEntityFactory m_Factory;

		private readonly List<(string, Action)> m_DataList;

		private readonly List<int> m_TemplateIdList;

		private ShopSettings m_ShopSettings;

		private ProductContext m_ProductContext;

		public bool blockPurchase;

		public bool setDefaultButton;

		private int GetTemplateIdxByStyle(ShopInformButtonData.ButtonStyle buttonStyle)
		{
			return 0;
		}

		private string GetButtonLabel(ShopInformButtonData buttonData)
		{
			return null;
		}

		private Action GetBehaviourCallback(ShopInformButtonData buttonData)
		{
			return null;
		}

		public InformButtonGroupWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		private void OnCreatedEntity(GameObject entity, int templateIdx)
		{
		}

		private void OnActivateEntity(GameObject entity)
		{
		}

		private void OnDeactivateEntity(GameObject entity)
		{
		}

		private void OnUpdateEntity(GameObject entity, int dataIdx)
		{
		}

		private void OnClickEntity(GameObject entity)
		{
		}

		public void SetContext(ShopSettings shopSettings, ProductContext productContext)
		{
		}

		public void SelectHeadButton()
		{
		}

		public void SelectBottomButton()
		{
		}

		private void OpenItemPreview(ProductContext productContext)
		{
		}
	}
}
