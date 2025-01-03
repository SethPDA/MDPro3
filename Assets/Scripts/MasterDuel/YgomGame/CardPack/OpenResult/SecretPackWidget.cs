using System;
using TMPro;
using YgomGame.Shop;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.OpenResult
{
	public class SecretPackWidget : ElementWidgetBehaviourBase<SecretPackWidget>
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelNameText;

		private readonly string k_ELabelThumbHolder;

		private int m_ShopId;

		private SelectionButton m_SelectionButton;

		private TMP_Text m_NameText;

		private BindingShopProductThumb m_BindingShopProductThumb;

		public Action<SecretPackWidget> onClickCallback;

		public int shopId => 0;

		public SelectionButton selectionButton => null;

		public TMP_Text nameText => null;

		public BindingShopProductThumb bindingShopProductThumb => null;

		public static SecretPackWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		public void Binding(int shopId, string name, BindingShopProductThumb.Context thumbContext)
		{
		}

		private void OnClick()
		{
		}

		public SecretPackWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
