using System;

namespace YgomGame.Menu
{
	public class HomeAction
	{
		public int priority;

		public Action<Action> action;

		public HomeAction(int priority, Action<Action> action)
		{
		}
	}
}
