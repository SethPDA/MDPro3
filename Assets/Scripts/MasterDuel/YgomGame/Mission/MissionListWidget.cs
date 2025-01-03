using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission
{
	public class MissionListWidget : ElementWidgetBase
	{
		public readonly int k_NormalTemplateIdx;

		public readonly int k_HeaderTemplateIdx;

		public readonly string k_TweenFadeIn;

		public readonly string k_TweenFadeOut;

		public readonly string k_TweenOnRecieveFocusScroll;

		public readonly InfinityScrollView scrollView;

		public readonly ScrollRect scrollRect;

		public readonly TMP_Text tabNameText;

		private TweenPosition m_TweenOnRecieveFocusScrollPosition;

		private RectOffset m_OriginalPadding;

		private float m_OriginalSpacing;

		private float m_EntityHeight;

		public GameObject fadeTargetGo => null;

		public MissionListWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void OnInitializedScrollView(Dictionary<GameObject, MissionPanelWidget> panelWidgetsMap)
		{
		}

		public IEnumerator yPlayFadeIn()
		{
			return null;
		}

		public IEnumerator yPlayFadeOut()
		{
			return null;
		}

		public IEnumerator yPlayFade(string tweenFadeKey)
		{
			return null;
		}

		public void SetPlayFocusPanelSpeed(float speed)
		{
		}

		public IEnumerator yPlayFocusPanel(int idx)
		{
			return null;
		}
	}
}
