using System;
using System.Collections.Generic;

namespace YgomGame.Menu.USAStateSelect
{
	public class Parameter
	{
		public int defaultState;

		public IReadOnlyList<int> codeList;

		public IReadOnlyList<string> nameList;

		public Action<int> resultCallback;
	}
}
