namespace YgomGame.Menu.AgeGate
{
	internal class DayNumber : AgeNumber
	{
		private static readonly string[] fullList;

		private static string[] createDaysList(int dayNum)
		{
			return null;
		}

		public DayNumber(int dayNum, int defaultDay)
		{
		}

		protected override int indexToValue(int index)
		{
			return 0;
		}

		protected override string getUnselectText()
		{
			return null;
		}

		public int GetDays()
		{
			return 0;
		}

		public void Rebuild(int dayNum)
		{
		}
	}
}
