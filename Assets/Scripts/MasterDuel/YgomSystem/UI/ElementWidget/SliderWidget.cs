using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget
{
	public class SliderWidget : ElementWidgetBehaviourBase<SliderWidget>
	{
		[SerializeField]
		private string k_ELabelSlider;

		[SerializeField]
		private string k_ELabelInputButton;

		private Slider m_SliderCache;

		private SelectionButton m_InputButtonCache;

		private bool startSlide;

		public Slider slider => null;

		public SelectionButton inputButton => null;

		private void Awake()
		{
		}

		public SliderWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
