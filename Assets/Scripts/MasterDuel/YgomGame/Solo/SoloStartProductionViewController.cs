using System;
using YgomGame.Colosseum;
using YgomGame.Menu;

namespace YgomGame.Solo
{
	public class SoloStartProductionViewController : BaseMenuViewController
	{
		public enum Step
		{
			None = 0,
			Init = 1,
			WaitInit = 2,
			SelectTurn = 3,
			WaitSelectTurn = 4,
			Final = 5,
			WaitFinal = 6,
			StartDuel = 7,
			End = 8
		}

		private readonly string ROOT_RESULT_COINTOSS_LABEL;

		private readonly string TXT_LABEL;

		private Step step;

		private int chapterID;

		private ColosseumUtil.Turn playerTurn;

		private SoloModeUtil.DeckType deckType;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void ProgressUpdate()
		{
		}

		public void Update()
		{
		}

		private void EvalEachSteps()
		{
		}

		private void Init()
		{
		}

		private void WaitInit()
		{
		}

		private void SelectTurn()
		{
		}

		private void WaitSelectTurn()
		{
		}

		private void Final()
		{
		}

		private void WaitFinal()
		{
		}

		private void StartDuel()
		{
		}

		private void DispFirstorSecond(ColosseumUtil.Turn turn)
		{
		}
	}
}
