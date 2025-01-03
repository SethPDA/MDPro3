using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class SubTabListWidget : ElementWidgetBase
	{
		public class TabContext
		{
			public IShopProductGruopData groupData;

			public string label;

			public bool badge;

			public List<TabContext> children;

			public bool hasChildren => false;

			public TabContext(IShopProductGruopData groupData, string label)
			{
			}

			public TabContext(IShopProductGruopData setting, string label, List<TabContext> children)
			{
			}
		}

		internal const int k_TemplateId_Single = 0;

		internal const int k_TemplateId_Group = 1;

		private const string k_ELabelTabsList = "TabsList";

		private const string k_TLabel_ShowNext = "ShowNext";

		private const string k_TLabel_ShowBack = "ShowBack";

		private readonly ElementEntityFactory m_EntityFactory;

		private readonly SnapScrollView m_ScrollView;

		private Dictionary<GameObject, ISubTabWidget> m_TabWidgetMap;

		private Dictionary<int, Dictionary<int, bool>> m_AcordionValueMap;

		private Dictionary<int, Dictionary<int, bool>> m_AcordionManualMap;

		private ISubTabListWidgetHandler m_Handler;

		private ISubTabListWidgetListener m_Listener;

		private List<int> m_TemplateIds;

		public readonly Selector selector;

		private bool m_PreSelectedGroupParent;

		public int dataCount => 0;

		public bool GetAcordionValue(int categoryId, int subCategoryId)
		{
			return false;
		}

		public void SetAcordionValue(int categoryId, int subCategoryId, bool value)
		{
		}

		public bool GetAcordionManualFlag(int categoryId, int subCategoryId)
		{
			return false;
		}

		public void SetAcordionManualFlag(int categoryId, int subCategoryId, bool value)
		{
		}

		public ISubTabWidget GetSubTabWidget(int dataIdx)
		{
			return null;
		}

		public SubTabGroupWidget GetGroupWidgetByDataIdx(int dataIdx)
		{
			return null;
		}

		public SubTabSingleWidget GetSectionWidget(SubTabGroupWidget groupWidget, int sectionIdx)
		{
			return null;
		}

		public SubTabListWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Init(ISubTabListWidgetHandler handler, ISubTabListWidgetListener listener)
		{
		}

		public void StopMovement()
		{
		}

		public void ResetPos()
		{
		}

		public void UpdateDataCount()
		{
		}

		public void UpdateData()
		{
		}

		public void PlayShow(bool isNext)
		{
		}

		public bool SelectCurrentIdx(bool isInitializeSelect = false, bool selectSection = false)
		{
			return false;
		}

		public bool FocusCurrentIdx(bool containSection = false, bool selectItem = false, bool initializeSelection = false, bool immediate = false)
		{
			return false;
		}

		public bool CheckRecoverSelectItem()
		{
			return false;
		}

		private void OnCreatedEntity(GameObject entity, int templateIdx, SubTabGroupWidget parentGroup = null)
		{
		}

		private void OnActivateEntity(GameObject entity)
		{
		}

		private void OnDeactivateEntity(GameObject entity)
		{
		}

		private SubTabSingleWidget OnCreatedEntitySingle(GameObject entity, SubTabGroupWidget parentGroup = null)
		{
			return null;
		}

		private SubTabGroupWidget OnCreatedEntityGroup(GameObject entity)
		{
			return null;
		}

		private void OnUpdateEntity(GameObject entity, int dataIdx)
		{
		}

		private void OnUpdateEntitySignle(SubTabSingleWidget widget, int dataIdx)
		{
		}

		private void OnUpdateEntityGroup(SubTabGroupWidget widget, int dataIdx)
		{
		}

		private void OnCreatedEntityGroupSection(GameObject sectionEntity, SubTabGroupWidget parentGroup = null)
		{
		}

		private void OnUpdateEntityGroupSection(GameObject sectionEntity, int dataIdx, int sectionDataIdx)
		{
		}

		private bool OnInputDirection(PadInputDirection direction)
		{
			return false;
		}

		private void OnGroupParentSelected()
		{
		}

		private void OnGroupSectionSelected()
		{
		}

		private bool OnSelectorSelected()
		{
			return false;
		}
	}
}
