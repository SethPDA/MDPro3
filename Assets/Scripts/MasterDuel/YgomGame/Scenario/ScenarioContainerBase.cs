using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario
{
	public class ScenarioContainerBase : ElementWidgetBase
	{
		private ScenarioShaker m_Shaker;

		protected virtual GameObject shakeTarget => null;

		public ScenarioContainerBase(ElementObjectManager eom)
			: base(null)
		{
		}

		public void PlayShake(float amount, float cycle, bool isShakeX, bool isShakeY, float autoStopSec = 0f)
		{
		}

		public void StopShake()
		{
		}

		public bool IsPlayingShake()
		{
			return false;
		}
	}
}
