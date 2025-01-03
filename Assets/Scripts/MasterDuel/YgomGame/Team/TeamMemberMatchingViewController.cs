using System;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamMemberMatchingViewController : BaseMenuViewController
	{
		protected enum Step
		{
			WAIT_INIT = 0,
			WAIT_PRE_MATCHING = 1,
			CALL_MATCHING = 2,
			WAIT_MATCHING = 3,
			WAIT_END = 4
		}

		public const string PREFAB_PATH = "Team/TeamMemberMatching";

		public const string KEY_PARENT_VIEW = "parent_view";

		public const string KEY_DECK_ID = "deck_id";

		public const string KEY_REGULATION_ID = "regulation_id";

		private readonly string E_ButtonCancel;

		private readonly string E_TextSearching;

		protected Step m_Step;

		private ViewController parentView;

		private bool isRequestCancel;

		private SelectionButton backBtn;

		private int callCount;

		protected Step step
		{
			get
			{
				return default(Step);
			}
			set
			{
			}
		}

		public static void Open(ViewControllerManager manager, ViewController parentView, int deck_id = 0, int regulation_id = 0)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Init()
		{
		}

		private void Update()
		{
		}

		private void EvalEachSteps()
		{
		}

		private void CallAPIDeckSet(int deckId, int regulationId, Action onFinish = null)
		{
		}

		private void CallAPIMatching()
		{
		}

		private void ReCallMatching()
		{
		}

		private void NotFindTeam()
		{
		}
	}
}
