using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission
{
	public class MissionGoalsWidget : ElementWidgetBase
	{
		private readonly int k_ELabelGoalWidgetMax;

		private readonly string k_ELabelGoalHolderFormat;

		private readonly string k_ELabelGauge;

		private readonly string k_ELabelGaugeStartHead;

		private readonly string k_ELabelGaugeGaugeStartHeadFill;

		private readonly string k_ELabelGaugeExtendHead;

		private readonly string k_ELabelGaugeExtendHeadFill;

		private readonly string k_ELabelGaugeExtendTail;

		private readonly string k_ELabelGaugeExtendTailFill;

		private readonly string k_ELabelSecretFilter;

		public int idx;

		public readonly MissionPanelWidget ownerPanel;

		public readonly Slider gauge;

		public readonly GameObject gaugeStartHead;

		public readonly GameObject gaugeStartHeadFill;

		public readonly GameObject gaugeExtendHeadBar;

		public readonly GameObject gaugeExtendHeadFill;

		public readonly GameObject gaugeExtendTailBar;

		public readonly GameObject gaugeExtendTailFill;

		public readonly Slider secretFilterGauge;

		public readonly List<MissionGoalHolderWidget> goalHolders;

		public MissionGoalsWidget(ElementObjectManager eom, MissionPanelWidget ownerPanel)
			: base(null)
		{
		}
	}
}
