using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.InfinityScroll
{
	public class EntitySelectorController
	{
		private EntitySelectorSettings m_SelectorSettings;

		private InfinityScrollView m_Owner;

		private Selector m_Selector;

		private GridLayoutGroup.Axis m_ScrollAxis;

		private readonly Dictionary<SelectionItem, int> m_SelectionItemXMap;

		private readonly Dictionary<SelectionItem, int> m_SelectionItemYMap;

		private readonly Dictionary<GameObject, List<SelectionItem>> m_EntitySelectionItemsMap;

		private List<SelectionItem> m_TmpSearchSelectionItems;

		private List<SelectionItem> m_InitializedSelectionItems;

		public Func<GameObject, IReadOnlyList<(SelectionItem, int, int)>> customCollectSelectionItemsFunc;

		public Func<int, bool> isSelectableDataIndexFunc;

		public Func<SelectionItem, PadInputDirection, bool> customEdgeTransitionFunc;

		public Func<SelectionItem, PadInputDirection, bool> customInnerTransitionFunc;

		public Func<GameObject, int, bool, bool> customOnFocusSelectFunc;

		public Func<Vector2, Vector2, bool> m_DragStarterFunc;

		public Func<bool> m_OnSelectorSelectedFunc;

		public Dictionary<SelectionItem, int> SelectionItemXMap => null;

		public Dictionary<SelectionItem, int> SelectionItemYMap => null;

		public bool isReady => false;

		public GameObject selectedEntity => null;

		public int selectedEntityIndex => 0;

		public Func<Vector2, Vector2, bool> dragStarterFunc
		{
			set
			{
			}
		}

		public Func<bool> onSelectorSelectoredFunc
		{
			set
			{
			}
		}

		public int defaultIdx
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int currentIdx
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

		public int currentSubIdxX
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

		public int currentSubIdxY
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

		public void Initialize(EntitySelectorSettings selectorSettings, InfinityScrollView owner, Selector selector, Action onComplete = null, GridLayoutGroup.Axis axis = GridLayoutGroup.Axis.Vertical)
		{
		}

		public void OnCreateEntity(GameObject entity)
		{
		}

		public void OnActivateEntity(GameObject entity)
		{
		}

		public void OnUpdateEntity(GameObject entity, int dataindex)
		{
		}

		public void OnFocusEntity(GameObject entity, int dataindex, bool selectItem, bool isInitializeSelect = false)
		{
		}

		public void OnDeactivateEntity(GameObject entity)
		{
		}

		private void SetTransitionModeAsEdge(SelectionItem selectionItem, PadInputDirection direction)
		{
		}

		private void SetTransitionModeAsFraction(SelectionItem selectionItem, PadInputDirection direction)
		{
		}

		private void SetTransitionModeAsInner(SelectionItem selectionItem, PadInputDirection direction)
		{
		}

		private void OnSelectedItem(SelectionItem selectionItem)
		{
		}

		private bool OnSelectorSelected()
		{
			return false;
		}

		private void OnEntityPadInput(SelectionItem selectionItem, PadInputDirection direction)
		{
		}

		public void ResetContentPosition()
		{
		}

		public bool IsSelectableDataIndex(int dataIndex)
		{
			return false;
		}

		public int GetSelectableSideIndex(int dataIndex, PadInputDirection direction)
		{
			return 0;
		}

		public bool IsEdgeSelectionItem(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		public GameObject GetEntityBySelectionItem(SelectionItem selectionItem)
		{
			return null;
		}

		public List<SelectionItem> GetSelectionItemsByEntity(GameObject entity)
		{
			return null;
		}

		public bool TrySelectIdx(int dataIdx, int xPos = 0, int yPos = 0, bool initializeSelection = false)
		{
			return false;
		}

		public bool JumpToDirection(PadInputDirection direction, bool selectItem = true, bool isInitializeSelect = false, int jumpLength = 0)
		{
			return false;
		}

		public bool IsRegistedSelectionItem(SelectionItem selectionItem)
		{
			return false;
		}

		private void InitSelectionItems(SelectionItem selectionItem)
		{
		}

		public void RegistSelectionItem(GameObject entity, SelectionItem selectionItem, int xPos, int yPos, int dataindex = -1)
		{
		}

		public void UnregistSelectionItem(GameObject entity = null, SelectionItem selectionItem = null)
		{
		}
	}
}
