using System;

namespace Willow.InGameField
{
	[Serializable]
	public class IntParameterRef
	{
		public IntParameter param;

		public int value => 0;

		public static implicit operator int(IntParameterRef reference)
		{
			return 0;
		}
	}
}
