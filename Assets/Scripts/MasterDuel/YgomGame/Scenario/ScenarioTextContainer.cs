using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Scenario
{
	public class ScenarioTextContainer : ScenarioContainerBase
	{
		private readonly string k_ELabelCenterGroup;

		private readonly string k_ELabelLeftGroup;

		private readonly string k_ELabelRightGroup;

		private readonly string k_ELabelBottomGroup;

		private readonly string k_ELabelMessageTextTemplate;

		private readonly string k_ELabelNextArrow;

		private readonly string k_TweenShowArrow;

		private readonly string k_TweenHideArrow;

		private readonly Tween m_ShowArrowTween;

		private readonly Tween m_HideArrowTween;

		private readonly List<Tween> m_ArrowTweens;

		private readonly TextMeshProUGUI m_MessageTextTemplate;

		private readonly List<TextMeshProUGUI> m_ActiveTexts;

		private readonly Stack<TextMeshProUGUI> m_InactiveTexts;

		private readonly GameObject m_NextArrowGom;

		public TMP_FontAsset fontAsset => null;

		public ScenarioTextContainer(ElementObjectManager eom)
			: base(null)
		{
		}

		public TextMeshProUGUI RentText(int pos)
		{
			return null;
		}

		public void ReturnText(TextMeshProUGUI rentedText)
		{
		}

		private Transform GetTextGroup(int pos)
		{
			return null;
		}

		public void ShowArrow()
		{
		}

		public void HideArrow()
		{
		}

		public void ShowTexts()
		{
		}

		public void HideTexts()
		{
		}
	}
}
