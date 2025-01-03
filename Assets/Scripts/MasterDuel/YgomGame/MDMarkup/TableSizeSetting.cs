using System;
using System.Collections.Generic;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class TableSizeSetting
	{
		public int colLength;

		public List<float> colSizes;

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}
	}
}
