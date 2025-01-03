using System;

namespace YgomGame.Menu.AgeGate
{
	public class Parameter
	{
		public int defaultYear;

		public int defaultMonth;

		public int defaultDay;

		public Action<int, int, int> resultCallback;
	}
}
