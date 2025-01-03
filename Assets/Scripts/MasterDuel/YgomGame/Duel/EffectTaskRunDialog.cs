using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskRunDialog : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitTutorial = 1,
			Finish = 2
		}

		private Step step;

		private bool finished;

		private Engine.DialogType type;

		private int textId;

		private int dwParam;

		private string text;

		private static string activateCardSelectionText;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskRunDialog(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private bool WaitCardEffectStep()
		{
			return false;
		}

		private void FinishStep()
		{
		}

		private void RunDialog()
		{
		}

		private void StartDialogInput()
		{
		}
	}
}
