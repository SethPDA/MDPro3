using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Card;

namespace YgomGame.Shop
{
	public class ProductContextCollection : List<ProductContext>
	{
		public readonly ShopSettings m_ShopSettings;

		public readonly CardCategoryData m_CardCategoryData;

		public readonly int categoryId;

		public readonly ShopDef.ShowcaseCategory category;

		public readonly List<ProductContext> m_ImportedContexts;

		private readonly List<int> m_ImportedSubCategories;

		public string filterProductName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<int> subCategories => null;

		public IReadOnlyList<ProductContext> importedContexts => null;

		public event Action onUpdatedEvent
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

		public bool IsEmpty()
		{
			return false;
		}

		public ProductContextCollection(ShopDef.ShowcaseCategory category, ShopSettings shopSettings, CardCategoryData cardCategoryData)
		{
			//((List<T>)(object)this)._002Ector();
		}

		public void Import(Dictionary<string, object> productDatas)
		{
		}

		public void Filter()
		{
		}

		private static int SortAsPack(ProductContext a, ProductContext b)
		{
			return 0;
		}

		private static int SortAsStructure(ProductContext a, ProductContext b)
		{
			return 0;
		}

		private static int SortAsAccessory(ProductContext a, ProductContext b)
		{
			return 0;
		}

		private static int SortAsSpecial(ProductContext a, ProductContext b)
		{
			return 0;
		}
	}
}
