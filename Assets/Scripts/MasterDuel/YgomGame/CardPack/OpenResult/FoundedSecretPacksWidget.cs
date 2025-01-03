using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Shop;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardPack.OpenResult
{
	public class FoundedSecretPacksWidget : ElementWidgetBase
	{
		private readonly string k_ELabelScrollView;

		private readonly InfinityScrollView m_ScrollView;

		private readonly Dictionary<GameObject, ProductWidget> m_EntityWidgetMap;

		public readonly List<ProductContext> productContexts;

		public List<object> extraPackGroupsWork;

		public InfinityScrollView scrollView => null;

		public event Action<ProductContext> onClickPackEvent
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

		public FoundedSecretPacksWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void ActivateScroll(Action onConplete)
		{
		}

		public void OnCreatedEntity(GameObject gob)
		{
		}

		public void OnUpdateEntity(GameObject gob, int dataindex)
		{
		}

		public void OpenClickPackWidget(ProductWidget packWidget)
		{
		}

		public void SelectBottomEntity()
		{
		}
	}
}
