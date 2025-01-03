using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioBGContainer : ScenarioContainerBase
	{
		private readonly string k_ELabelBGCanvas;

		private readonly string k_ELabelBGOutlineCanvas;

		private readonly string k_ELabelBGRawImage;

		private readonly string k_ELabelBGSubRawImage;

		private readonly Canvas bgCanvas;

		private readonly Canvas bgOutlineCanvas;

		public readonly ScenarioBGActor bgActor;

		public readonly ScenarioBGActor bgSubActor;

		protected override GameObject shakeTarget => null;

		public ScenarioBGContainer(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(ScenarioWork work)
		{
		}

		public void ToBlurOn()
		{
		}

		public void ToBlurOff()
		{
		}
	}
}
