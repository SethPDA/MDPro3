using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectorGroup
	{
		public enum Direction
		{
			None = 0,
			Up = 1,
			Right = 2,
			Down = 3,
			Left = 4
		}

		public string groupLabel;

		public List<Selector> selectors;

		private bool isDirty;

		public int selectorNum => 0;

		public int groupPriority => 0;

		public SelectionItem currentItem => null;

		public int priorityInCluster
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

		public SelectorGroup(string group_label)
		{
		}

		public void AddSelector(Selector selector)
		{
		}

		public void RemoveSelector(Selector selector)
		{
		}

		public SelectionItem.UpdateItemStatus UpdateAllSelectors()
		{
			return default(SelectionItem.UpdateItemStatus);
		}

		public (SelectionItem, float) GetSelectionItem(Vector2 position, Vector2 normalized_direction, float angle, SelectionItem ignore_item = null)
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

		public void SetDefaultItem(SelectionItem item)
		{
		}

		public SelectionItem GetDefaultItem()
		{
			return null;
		}

		public bool SelectItem(SelectionItem item, bool initializeSelection = false, bool force = false)
		{
			return false;
		}

		public void SetGroupPriority(int group_priority, bool refresh_active_group)
		{
		}

		public void SetPriorityInCluster(int priority_in_cluster)
		{
		}

		private void UpdateSelectorDepth()
		{
		}

		public void InvokeClusterActivateCallback()
		{
		}

		public void InvokeClusterDeactivateCallback()
		{
		}

		public List<Selector> GetSelectors()
		{
			return null;
		}
	}
}
