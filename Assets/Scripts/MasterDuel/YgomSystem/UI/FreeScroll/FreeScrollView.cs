using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.FreeScroll
{
	public class FreeScrollView : MonoBehaviour
	{
		private Canvas m_ScrollRectCanvas;

		private SelectionItem m_ScrollRectSelectionItem;

		private ScrollRect m_ScrollRect;

		private List<SelectionItem> m_ContainSelections;

		private List<SelectionItem> m_InnerViewPortSelections;

		private List<SelectionItem> m_SortTargetSelections;

		private Dictionary<SelectionItem, float> m_SortAmounts;

		private bool m_DirtyViewPort;

		private Vector2 m_LastInputAnalogMain;

		private Vector2 m_LastInputAnalogSub;

		private float m_LastSelectByAnalogTime;

		private float m_RepeatSelectByAnalogCnt;

		public void AddSelections(IReadOnlyList<SelectionItem> selections)
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void Update()
		{
		}

		private void ResetAnalogSelectTime()
		{
		}

		public void TrySelectDefault(bool initializeSelection)
		{
		}

		private void ScrollMovement(Vector2 dir, bool byAnalog = false, bool initializeSelection = false)
		{
		}

		private void OnScroll(Vector2 vec)
		{
		}

		private void OnInputAnalog(Vector2 vec, bool isMain)
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
