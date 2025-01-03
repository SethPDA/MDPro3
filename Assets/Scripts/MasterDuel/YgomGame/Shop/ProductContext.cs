using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Card;
using YgomGame.CardPack;

namespace YgomGame.Shop
{
	public class ProductContext : IComparable<ProductContext>
	{
		protected Dictionary<string, object> m_ProductData;

		private int m_SectionId;

		private bool m_IsNew;

		private readonly BindingShopProductThumb.Context m_ThumbContext;

		private readonly List<PriceContext> m_PriceContexts;

		private PriceContext m_ListButtonPrice;

		private readonly List<HighlightContext> m_HighlightContexts;

		private List<string> m_FilterNames;

		private Dictionary<string, object> m_Decoration;

		public int shopId => 0;

		public int productTypeId => 0;

		public ShopDef.ProductType productType => default(ShopDef.ProductType);

		public int targetCategory => 0;

		public int targetId => 0;

		public bool targetIsPeriod => false;

		public int categoryId => 0;

		public int sectionId => 0;

		public ShopDef.ShowcaseCategory category => default(ShopDef.ShowcaseCategory);

		public int subCategoryId => 0;

		public virtual string productName => null;

		public virtual string descTextFull => null;

		public virtual string descTextShort => null;

		public string listDescText => null;

		public bool isNew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool workIsNew => false;

		public bool sendNew => false;

		public bool isLimitedDate => false;

		public long limitTs => 0L;

		public string limitDate => null;

		public string limitDateShort => null;

		public bool isLimitedBuyCount => false;

		public int limitBuyCount => 0;

		public int nowBuyCount => 0;

		public bool isSoldOut => false;

		public List<object> confirmTextIds => null;

		public List<object> setItems => null;

		public bool hasSetItems => false;

		public long sort => 0L;

		public int packId => 0;

		public int packTypeId => 0;

		public CardPackDef.PackType packType => default(CardPackDef.PackType);

		public int structureId => 0;

		public bool isPeriod => false;

		public int itemCategory => 0;

		public int itemId => 0;

		public int packNormalCardPoolId => 0;

		public int packPickupCardPoolId => 0;

		public int destructive => 0;

		public int handling => 0;

		public int difficult => 0;

		public Dictionary<string, object> duelpassreward => null;

		public BindingShopProductThumb.Context thumbContext => null;

		public ShopDef.ListButtonType listButtonType => default(ShopDef.ListButtonType);

		public List<PriceContext> priceContexts => null;

		public PriceContext listButtonPrice => null;

		public List<HighlightContext> highlightContexts => null;

		public HighlightContext headHighlightContext => null;

		public object chartData => null;

		public string deckCaseImagePath => null;

		public List<string> filterNames => null;

		public ShopSettings shopSettings
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

		public CardCategoryData cardCategoryData
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

		public int limitAlertSec => 0;

		public int highlightStyleType => 0;

		public string productWidgetLabel => null;

		public string headLabelText => null;

		public int bgId => 0;

		public string informButtonLabel => null;

		public ShopDef.HighlightType highlightType => default(ShopDef.HighlightType);

		public string productSubLabel => null;

		public ShopDef.ViewerLoopType viewerLoopType => default(ShopDef.ViewerLoopType);

		public bool hideSummonPlay => false;

		public bool isSoldOutSort => false;

		public bool isShortPayAmountSort => false;

		public bool FindBoolSetting(string key, bool defaultValue = false)
		{
			return false;
		}

		public int FindIntSetting(string key, int defaultValue = 0)
		{
			return 0;
		}

		private string FindStringSetting(string key, string defaultValue = null)
		{
			return null;
		}

		public void Import(Dictionary<string, object> productData)
		{
		}

		public void SetSectionId(int sectionId)
		{
		}

		public int Compare(ProductContext a, ProductContext b)
		{
			return 0;
		}

		public int CompareTo(ProductContext other)
		{
			return 0;
		}

		private bool IsItemProduct()
		{
			return false;
		}

		public string GetPushMessage(bool isDetail = false)
		{
			return null;
		}

		public virtual string GetOwnedText()
		{
			return null;
		}

		public int SearchContainItemId(bool isPeriod, int itemCategory)
		{
			return 0;
		}

		public (int, int, int, int) SearchFieldSetItems()
		{
			return default((int, int, int, int));
		}
	}
}
