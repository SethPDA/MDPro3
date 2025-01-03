using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Shop
{
	public class ProductWidgetController
	{
		private readonly AssetContainer m_ProductWidgetContainer;

		internal const string k_MapLabel_ProductHeader = "Product_Header";

		internal const string k_MapLabel_ProductEmpty = "Product_Empty";

		internal const string k_MapLabel_ProductDefault = "Product_M";

		private const string k_MapLabel_ProductContainer = "Product_Container";

		private List<GameObject> m_TemplateList;

		private Dictionary<string, int> m_TemplateIdxMap;

		private Dictionary<float, int> m_ContainerTemplateIdxMap;

		private Dictionary<string, GameObject> m_WidgetPrefMap;

		private Dictionary<string, Vector2> m_ProductSizeMap;

		private Dictionary<string, Stack<ProductWidget>> m_ProductWidgetReserves;

		public List<GameObject> templateList => null;

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

		public float containerWidth
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RectOffset containerPadding
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

		public float containerSpacing
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsContainerTemplateIdx(int templateIdx)
		{
			return false;
		}

		public int GetContainerTemplateIdx(float productHeight)
		{
			return 0;
		}

		public Vector2 GetProductSize(string productWidgetLabel)
		{
			return default(Vector2);
		}

		public bool IsReservedProductWidget(ProductWidget productWidget)
		{
			return false;
		}

		public ProductWidgetController(AssetContainer productWidgetMap)
		{
		}

		public void CreateTemplates(Transform parent)
		{
		}

		private void AssignTemplate(GameObject pref, string label = null)
		{
		}

		private void AssignProductTemplate(string label, Transform parent, GameObject pref)
		{
		}

		private GameObject CreateContainerTemplate(Transform parent, float height)
		{
			return null;
		}

		public ProductWidget RentProductWidget(string label, Transform parent)
		{
			return null;
		}

		public void ReturnProductWidget(ProductWidget widget)
		{
		}
	}
}
