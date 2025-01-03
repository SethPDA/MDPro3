using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class SubTabListWidget : ElementWidgetBase
	{
		public class TabContext
		{
			public IDuelLiveProductGruopData groupData;

			public string label;

			public bool badge;

			public List<TabContext> children;

			public bool hasChildren => false;

			public TabContext(IDuelLiveProductGruopData groupData, string label)
			{
			}

			public TabContext(IDuelLiveProductGruopData setting, string label, List<TabContext> children)
			{
			}
		}

		internal const int k_TemplateId_Single = 0;

		internal const int k_TemplateId_Group = 1;

		private const string k_ELabelTabsList = "TabsList";

		private const string k_ELabelSearchInputField = "SearchInputField";

		private readonly DuelLiveRootWidget m_Owner;

		private readonly ElementEntityFactory m_EntityFactory;

		private readonly InputFieldWidget m_SearchNameInputWidget;

		private readonly SnapScrollView m_ScrollView;

		private Dictionary<GameObject, ISubTabWidget> m_TabWidgetMap;

		private Dictionary<GameObject, bool> m_AcordionMap;

		private int m_Idx;

		private int m_SectionIdx;

		private List<TabContext> m_ContextDatas;

		private List<int> m_TemplateIds;

		public int defaultIdx;

		public int defaultSectionIdx;

		public readonly Selector selector;

		public bool isPopWallPaper;

		private bool m_PreSelectedGroupParent;

		public int idx => 0;

		public int sectionIdx => 0;

		public bool exists => false;

		public InputFieldWidget searchNameInputWidget => null;

		public ElementEntityFactory entityFactory => null;

		public SnapScrollView scrollView => null;

		public UnityEvent<string> onSubmitSearchField => null;

		public event Action<int, int, int, int> onPreChangeIdxEvent
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

		public event Action<int, int> onChangedIdxEvent
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

		public event Action<int> onClickSubCategory
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

		public event Action<int> onClickedSubCategoryGroup
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

		public event Action<int, int> onClickedSubCategorySection
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

		public bool GetAcordionByDataIdx(int dataIdx)
		{
			return false;
		}

		public bool SetAcordionByDataIdx(int dataIdx, bool value)
		{
			return false;
		}

		public ISubTabWidget SearchSubTabWidgetBySelectionItem(SelectionItem item)
		{
			return null;
		}

		public bool IsSectionButton(SelectionItem selectionItem)
		{
			return false;
		}

		public SubTabGroupWidget GetGroupWidgetByDataIdx(int dataIdx)
		{
			return null;
		}

		public SubTabListWidget(ElementObjectManager eom, DuelLiveRootWidget owner)
			: base(null)
		{
		}

		public void Init(List<TabContext> contextDatas)
		{
		}

		public void ExpandAcordionImmediate()
		{
		}

		public void CheckSectionIdxByCurrentPos()
		{
		}

		public bool SetIdx(int idx, int sectionIdx = 0)
		{
			return false;
		}

		public bool SelectCurrentIdx(bool initializeSelection = false, bool selectSection = false)
		{
			return false;
		}

		public bool FocusCurrentIdx(bool containSection = false, bool selectItem = false, bool initializeSelection = false)
		{
			return false;
		}

		private void OnCreatedEntity(GameObject entity, int templateIdx, SubTabGroupWidget parentGroup = null)
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
