using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamLeaderMatchingViewController : BaseMenuViewController
	{
		protected enum Step
		{
			WAIT_INIT = 0,
			WAIT_PRE_MATCHING = 1,
			CALL_MATCHING = 2,
			WAIT_MATCHING = 3,
			WAIT_END = 4
		}

		public const string PREFAB_PATH = "Team/TeamLeaderMatching";

		private readonly string E_ButtonCancel;

		private readonly string E_TextSearching;

		protected Step m_Step;

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

		public static void Open(ViewControllerManager manager)
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

		private void CallAPIMatching()
		{
		}

		private void NotFindMember()
		{
		}
	}
}
