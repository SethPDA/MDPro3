namespace YgomGame.Menu.AgeGate
{
	internal class MonthNumber : AgeNumber
	{
		private static readonly string[] monthNames;

		public MonthNumber(int defaultMonth)
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
