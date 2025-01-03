using System;
using UnityEngine;

namespace YgomSystem.UI
{
	public class AnalogDirectionListener : MonoBehaviour
	{
		private readonly float k_Threshhold;

		private readonly int k_IntervalStepMax;

		[SerializeField]
		private SelectionItem m_SelectionItem;

		[SerializeField]
		private bool m_OnlySelected;

		[SerializeField]
		private SelectorManager.AnalogType[] m_AnalogTypes;

		private PadInputDirection m_CurrentInputDir;

		private SelectorManager.AnalogType m_CurrentAnalogType;

		private int m_IntervalStep;

		private float m_InputIntervalTime;

		private Action<SelectorManager.AnalogType, PadInputDirection> m_OnInputCallback;

		public SelectionItem selectionItem => null;

		public PadInputDirection currentInputDir => default(PadInputDirection);

		public SelectorManager.AnalogType currentAnalogType => default(SelectorManager.AnalogType);

		public Action<SelectorManager.AnalogType, PadInputDirection> onInputCallback
		{
			set
			{
			}
		}

		public static AnalogDirectionListener Assign(GameObject owner, SelectionItem selectionItem, bool onlySelected = false, Action<SelectorManager.AnalogType, PadInputDirection> onInputCallback = null, params SelectorManager.AnalogType[] analogTypes)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Clear()
		{
		}

		private void ResetInterval()
		{
		}

		private float GetInputIntervalTime(int intervalStep)
		{
			return 0f;
		}

		private PadInputDirection VecToDirection(Vector2 vec)
		{
			return default(PadInputDirection);
		}

		private bool OnAnalogInput(Vector2 vec, SelectorManager.AnalogType analogType)
		{
			return false;
		}
	}
}
