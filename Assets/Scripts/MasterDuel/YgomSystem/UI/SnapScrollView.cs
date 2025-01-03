using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class SnapScrollView : MonoBehaviour
	{
		private class SearchNearPtCalculator
		{
			private class PointDiffData : IComparable<PointDiffData>
			{
				public readonly float fromPoint;

				public readonly float toPoint;

				public float diff => 0f;

				public PointDiffData(float fromPoint, float toPoint)
				{
				}

				public int CompareTo(PointDiffData other)
				{
					return 0;
				}
			}

			private List<PointDiffData> m_PointDiffs;

			public (Vector2, Vector2) SearchNearPtPair(Bounds fromBounds, Bounds toBounds)
			{
				return default((Vector2, Vector2));
			}
		}

		[SerializeField]
		private SelectionTransitionSetting m_UpEdgeTransition;

		[SerializeField]
		private SelectionTransitionSetting m_DownEdgeTransition;

		[SerializeField]
		private SelectionTransitionSetting m_RightEdgeTransition;

		[SerializeField]
		private SelectionTransitionSetting m_LeftEdgeTransition;

		[SerializeField]
		public bool m_ScrollAnalogMain;

		[SerializeField]
		public bool m_ScrollAnalogSub;

		[SerializeField]
		public float m_ThresInput;

		private Selector m_MainSelectorCache;

		private List<Selector> m_Selectors;

		private ExtendedScrollRect m_ScrollRectCache;

		private RectOffset m_PaddingCache;

		private List<SelectionItem> m_AssignedItems;

		private bool m_TransitionBlocker;

		private List<SelectionItem> m_SortTargetSelections;

		private Dictionary<SelectionItem, float> m_SortAmounts;

		private SelectionItem m_LastSelectedItem;

		private SearchNearPtCalculator m_SearchNearPtCalculator;

		public Func<bool> customSelectorSelectedFunc;

		public Func<PadInputDirection, bool> customInputDirectionFunc;

		public RectOffset padding => null;

		public ExtendedScrollRect scrollRect => null;

		public Selector mainSelector => null;

		private bool ContainsItem(SelectionItem selectionItem)
		{
			return false;
		}

		private SelectionTransitionSetting GetDirectionSetting(PadInputDirection direction)
		{
			return null;
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void AssignSelector(Selector selector)
		{
		}

		public void RefreshSelectionItems()
		{
		}

		public void ResetContentPosition()
		{
		}

		public void FocusBySelectionItem(SelectionItem selectionItem, bool selectItem = true, bool isInitializeSelect = false)
		{
		}

		public void ImmediateApplyMovement()
		{
		}

		public void StopAutoScroll()
		{
		}

		public Vector2 CalcFitNormalize(RectTransform target)
		{
			return default(Vector2);
		}

		private Vector2 CheckRectToFitDiff(RectTransform target)
		{
			return default(Vector2);
		}

		public void InputAnalogDirection(Vector2 analogValue)
		{
		}

		public void InputDirection(PadInputDirection direction)
		{
		}

		private void OnScrollValueChanged(Vector2 bias)
		{
		}

		private bool OnMainSelectorSelected()
		{
			return false;
		}

		private void OnSelectedItem()
		{
		}

		private void OnInputUp()
		{
		}

		private void OnInputDown()
		{
		}

		private void OnInputLeft()
		{
		}

		private void OnInputRight()
		{
		}
	}
}
