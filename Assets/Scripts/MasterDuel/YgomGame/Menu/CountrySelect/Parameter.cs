using System;
using System.Collections.Generic;

namespace YgomGame.Menu.CountrySelect
{
	public class Parameter
	{
		public int defaultCountry;

		public IReadOnlyList<int> codeList;

		public IReadOnlyList<string> nameList;

		public Action<int> resultCallback;
	}
}
