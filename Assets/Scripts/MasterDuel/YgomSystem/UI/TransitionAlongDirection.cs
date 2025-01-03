using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TransitionAlongDirection : MonoBehaviour
	{
		[Serializable]
		public class Setting
		{
			[SerializeField]
			[EnumFlags]
			protected DirectionFlag m_Directions;

			[SerializeField]
			private List<string> m_ReserveGroup;

			[SerializeField]
			private List<string> m_IgnoreGroup;

			[SerializeField]
			private bool m_ContainGoThrough;

			[SerializeField]
			private bool m_MaskSelectorRect;

			[SerializeField]
			public SelectTarget[] m_SelectTargetOrder;

			[SerializeField]
			private float m_SelectionAngle;

			public List<string> reserveGroup => null;

			public List<string> ignoreGroup => null;

			public bool containGoThrough => false;

			public SelectTarget[] selectTargetOrder => null;

			public float selectionAngle => 0f;

			public bool maskSelectorRect => false;

			public void Import(Setting other)
			{
			}

			public bool IsDirection(PadInputDirection direction)
			{
				return false;
			}

			public void SetDirection(PadInputDirection direction)
			{
			}

			public void UnsetDirection(PadInputDirection direction)
			{
			}
		}

		public enum DirectionFlag
		{
			Up = 1,
			Down = 2,
			Left = 4,
			Right = 8
		}

		public enum SelectTarget
		{
			Item = 0,
			Selector = 1,
			Clustor = 2
		}

		private class NearItemSearcher
		{
			private List<SelectionItem> m_SearchItemList;

			private Dictionary<SelectionItem, float> m_SearchDistanceMap;

			public void Clear()
			{
			}

			public List<SelectionItem> Search(SelectionItem fromItem, Setting setting, Vector2 dir)
			{
				return null;
			}
		}

		[SerializeField]
		private Setting m_Setting;

		protected SelectionItem m_SelectionItem;

		private NearItemSearcher m_NearItemSearcher;

		public Setting setting => null;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void ApplyTransition()
		{
		}

		public bool TrySelectInput(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		protected virtual void OnInputUp()
		{
		}

		protected virtual void OnInputDown()
		{
		}

		protected virtual void OnInputLeft()
		{
		}

		protected virtual void OnInputRight()
		{
		}

		protected bool TrySelectNearItem(Vector2 dir)
		{
			return false;
		}

		protected bool TrySelectNearItem(SelectionItem selectionItem, Vector2 dir)
		{
			return false;
		}

		private bool TryProvisinalSelectItem(SelectionItem item)
		{
			return false;
		}

		private bool TryProvisinalSelectSelector(Selector selector)
		{
			return false;
		}

		private bool TryProvisinalSelectClustor(SelectorCluster cluster)
		{
			return false;
		}
	}
}
