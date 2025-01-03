using System;

namespace YgomGame.Menu.AgeGate
{
	public class AgeGateViewController : CommonScreenViewController
	{
		private Action<int, int, int> m_resultCallback;

		private DateTime m_today;

		private YearNumber m_year;

		private MonthNumber m_month;

		private DayNumber m_day;

		private bool verifyDate()
		{
			return false;
		}

		private void updateStatus()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}
	}
}
