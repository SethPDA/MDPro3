using System.Collections.Generic;
using TMPro;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_Text : ScenarioBehaviour, IScenarioLogTextBehavior, IScenarioLogBehavior, IScenarioPreGenerateTextBehaviour
	{
		public float waitLineSec;

		private List<TextMeshProUGUI> m_LineTextMeshs;

		private int m_PlayPos;

		private float m_RemineWaitLineSec;

		private bool m_PlayTrigger;

		private float m_AutoFinishSec;

		private float m_TextFilledArrowWaitSec;

		private string m_Text;

		public ScenarioBehaviour_Text(object commandData)
			: base(null)
		{
		}

		public string GetPreGenerateText()
		{
			return null;
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}

		protected override void ProgressWaitInput()
		{
		}

		protected override void ProgressFinish()
		{
		}

		public override void OnPointerClick()
		{
		}

		public string GetLogText()
		{
			return null;
		}

		private void ResetAutoFinihSec()
		{
		}

		private void OnChangeSuspend(bool isSuspend)
		{
		}

		private void OnChangeAuto(bool isAuto)
		{
		}
	}
}
