using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class Selector : MonoBehaviour
	{
		public enum OverAreaDirectionMode
		{
			Clamp = 0,
			Loop = 1
		}

		public enum InputMode
		{
			Select = 1,
			Callback = 2
		}

		public delegate void InputCallback();

		public delegate void SelectedCallback(SelectionItem item);

		public enum MaskMode
		{
			None = 0,
			RectTransformArea = 1,
			RectTransformAreaAllPoints = 2
		}

		public enum MaskOperation
		{
			ScreenInput = 1,
			KeyInput = 2
		}

		public enum RegistStatus
		{
			None = 0,
			Previsional = 1,
			Registed = 2
		}

		private List<SelectionItem> items;

		private SelectionItem preSelectedItem;

		[SerializeField]
		private string _groupLabel;

		[SerializeField]
		private int storedGroupPriority;

		private int storedGroupPriorityInCluster;

		private Camera _viewCamera;

		[SerializeField]
		protected OverAreaDirectionMode _overAreaDirectionMode;

		[SerializeField]
		private InputMode upInputMode;

		[SerializeField]
		private InputMode downInputMode;

		[SerializeField]
		private InputMode rightInputMode;

		[SerializeField]
		private InputMode leftInputMode;

		[SerializeField]
		private MaskMode _maskMode;

		[SerializeField]
		private MaskOperation _maskOperation;

		private Vector3[] rectWorldCorners;

		private RaycastHit _currentRaycastHit;

		private UnityEvent onActivatedCallback;

		private UnityEvent onDeactivatedCallback;

		public Selector selectionParentSelector;

		public List<Selector> selectionChildrenSelector;

		[SerializeField]
		private SelectionItem selectionTargetItem;

		private RegistStatus registStatus;

		public string groupLabel => null;

		public SelectorGroup group
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

		public int groupPriority => 0;

		public Camera viewCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isDisabledDepthCheck
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public OverAreaDirectionMode overAreaDrectionMode => default(OverAreaDirectionMode);

		public MaskMode maskMode
		{
			get
			{
				return default(MaskMode);
			}
			set
			{
			}
		}

		public MaskOperation maskOperation
		{
			get
			{
				return default(MaskOperation);
			}
			set
			{
			}
		}

		public RaycastHit currentRaycastHit => default(RaycastHit);

		public bool isRaycastHit
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int hierarchyIndexCache
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

		private bool isDirty
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isActivated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Func<bool> onSelectorSelectoredFunc
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

		public event InputCallback upInputCallback
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

		public event InputCallback downInputCallback
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

		public event InputCallback rightInputCallback
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

		public event InputCallback leftInputCallback
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

		public event SelectedCallback selectedCallback
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

		public event SelectedCallback deselectedCallback
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void AddItem(SelectionItem item)
		{
		}

		public void RemoveItem(SelectionItem item)
		{
		}

		public SelectionItem.UpdateItemStatus UpdateAllItems()
		{
			return default(SelectionItem.UpdateItemStatus);
		}

		public (SelectionItem, float) GetSelectionItem(Vector2 current_position, Vector2 direction, float angle, SelectionItem ignore_item = null)
		{
			return default((SelectionItem, float));
		}

		public SelectionItem GetHiestPrioritySelectableItem()
		{
			return null;
		}

		public (SelectionItem, float) GetSelectionItem(Vector2 view_position)
		{
			return default((SelectionItem, float));
		}

		public bool ContainCurrentItem()
		{
			return false;
		}

		private bool IsContainsItem(GameObject obj)
		{
			return false;
		}

		private SelectionItem GetItem(GameObject obj)
		{
			return null;
		}

		private bool GetViewRect(out Vector2 rect_point0, out Vector2 rect_point1, out Vector2 rect_point2, out Vector2 rect_point3)
		{
			rect_point0 = default(Vector2);
			rect_point1 = default(Vector2);
			rect_point2 = default(Vector2);
			rect_point3 = default(Vector2);
			return false;
		}

		private bool IsContainsPoint(Vector2 point)
		{
			return false;
		}

		public void SetDefaultItem(SelectionItem item)
		{
		}

		public void SetViewCamera(Camera view_camera)
		{
		}

		public Vector2 GetViewPosition(Vector3 item_position)
		{
			return default(Vector2);
		}

		public bool Select(SelectionItem selection_item, bool initializeSelection = false, bool force = false)
		{
			return false;
		}

		public bool Select(bool initializeSelection = false)
		{
			return false;
		}

		public bool SelectPreSelectedItem(bool initializeSelection = false)
		{
			return false;
		}

		public bool SelectDeufaltItem(bool initializeSelection = false)
		{
			return false;
		}

		public bool SelectParentSelector(bool initializeSelection = false)
		{
			return false;
		}

		public bool SelectChildSelector(bool initializeSelection = false)
		{
			return false;
		}

		public void SetGroupPriority(int group_priority)
		{
		}

		public void SetGroupPriorityInCluster(int priority_in_cluster)
		{
		}

		public void ChangeGroupLabel(string group_label)
		{
		}

		public InputMode GetInputMode(PadInputDirection direction)
		{
			return default(InputMode);
		}

		public void SetInputMode(PadInputDirection direction, InputMode mode)
		{
		}

		public void InvokeInputCallback(PadInputDirection direction)
		{
		}

		public void AddInputCallback(PadInputDirection direction, InputCallback callback)
		{
		}

		public void RemoveInputCallback(PadInputDirection direction, InputCallback callback)
		{
		}

		public void RemoveInputCallbackAll(PadInputDirection direction)
		{
		}

		public void InvokeSelectedCallback(SelectionItem item)
		{
		}

		public void InvokeDeselectedCallback(SelectionItem item)
		{
		}

		public SelectionItem GetSelectedItem()
		{
			return null;
		}

		public bool IsSelected()
		{
			return false;
		}

		public SelectionItem GetDefaultItem()
		{
			return null;
		}

		public void SetAsDefaultItem(SelectionItem target)
		{
		}

		public void SetAsSelectionTargetItem(SelectionItem target)
		{
		}

		public void SetupItemDepth(bool force = false)
		{
		}

		public void SetupItemDepth(SelectionItem targetItem)
		{
		}

		public void SetDirty()
		{
		}

		public void AddClusterActivateCallback(UnityAction callback)
		{
		}

		public void RemoveClusterActivateCallback(UnityAction callback)
		{
		}

		public void RemoveAllClusterActivateCallback()
		{
		}

		public void AddClusterDeactivateCallback(UnityAction callback)
		{
		}

		public void RemoveClusterDeactivateCallback(UnityAction callback)
		{
		}

		public void RemoveAllClusterDeactivateCallback(UnityAction callback)
		{
		}

		public void InvokeClusterActivateCallback()
		{
		}

		public void InvokeClusterDeactivateCallback()
		{
		}

		public void SetResistStatus(RegistStatus regist_status)
		{
		}

		public List<SelectionItem> GetItems()
		{
			return null;
		}
	}
}
