using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack
{
	public class CardPackChartWidget : ElementWidgetBase
	{
		private readonly string k_ELabelDestructive;

		private readonly string k_ELabelDifficult;

		private readonly string k_ELabelHandling;

		public static CardPackChartWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		public CardPackChartWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Binging(int destructive, int handling, int difficult)
		{
		}

		private void BindGauge(ElementObjectManager gaugeEom, float amount)
		{
		}

		private void BindUniqueGauge(ElementObjectManager gaugeEom, string label, float amount, Color color)
		{
		}
	}
}
