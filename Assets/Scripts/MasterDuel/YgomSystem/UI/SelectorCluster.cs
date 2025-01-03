using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectorCluster
	{
		public int priority;

		public List<SelectorGroup> groups;

		private SelectionItem preSelectedItem;

		protected PadInputDirection currentPadDirection;

		protected float padInputContinueTime;

		protected static Vector2 directionUp;

		protected static Vector2 directionUpRight;

		protected static Vector2 directionRight;

		protected static Vector2 directionDownRight;

		protected static Vector2 directionDown;

		protected static Vector2 directionDownLeft;

		protected static Vector2 directionLeft;

		protected static Vector2 directionUpLeft;

		public bool goThrough => false;

		public int goThroughCounter
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

		public SelectionItem currentItem
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

		public Selector currentSelector => null;

		public bool activated
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

		public bool protectActivation
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

		public SelectorCluster(int priority)
		{
		}

		public void AddGroup(SelectorGroup group)
		{
		}

		public void RemoveGroup(SelectorGroup group)
		{
		}

		public SelectionItem.UpdateItemStatus UpdateAllGroups()
		{
			return default(SelectionItem.UpdateItemStatus);
		}

		public SelectorGroup GetGroup(string label)
		{
			return null;
		}

		public bool SelectItem(SelectionItem item, bool initializeSelection = false, bool force = false)
		{
			return false;
		}

		public void DeselectCurrentItem(bool savePreSelectedItem)
		{
		}

		public SelectionItem GetSelectionItem(Vector2 view_position)
		{
			return null;
		}

		public SelectionItem GetHighestPrioritySelectableItem()
		{
			return null;
		}

		public bool SelectHighestPriorityItem()
		{
			return false;
		}

		public void ChangeSelectionItem(Vector2 position, Vector2 normalized_direction, bool check_loop, float angle, bool igonre_current_item)
		{
		}

		public (SelectionItem, float) GetSelectionItem(Vector2 position, Vector2 normalized_direction, bool check_loop, float angle, SelectionItem ignore_item = null)
		{
			return default((SelectionItem, float));
		}

		public SelectionItem GetDefaultItem()
		{
			return null;
		}

		public bool SelectDefaultItem()
		{
			return false;
		}

		public SelectionItem GetPreSelectedItem()
		{
			return null;
		}

		public bool SelectPreSelectedItem()
		{
			return false;
		}

		private Vector2 GetScreenEdge(Vector2 position, Vector2 ray_direction)
		{
			return default(Vector2);
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void Refresh()
		{
		}
	}
}
