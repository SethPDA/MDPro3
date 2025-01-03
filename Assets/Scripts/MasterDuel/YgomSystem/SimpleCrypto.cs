namespace YgomSystem
{
	public class SimpleCrypto
	{
		private class SysRand
		{
			private const int MBIG = int.MaxValue;

			private const int MSEED = 161803398;

			private int inext;

			private int inextp;

			private int[] seedArray;

			public SysRand(int Seed)
			{
			}

			public int Next(int minValue, int maxValue)
			{
				return 0;
			}

			private double Sample()
			{
				return 0.0;
			}
		}

		public static void Encrypt(ref byte[] data, string key)
		{
		}
	}
}
