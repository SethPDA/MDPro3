namespace YgomGame.Menu.AgeGate
{
	internal class YearNumber : AgeNumber
	{
		private int m_nowYear;

		public YearNumber(int nowYear, int range, int defaultYear)
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
	}
}
