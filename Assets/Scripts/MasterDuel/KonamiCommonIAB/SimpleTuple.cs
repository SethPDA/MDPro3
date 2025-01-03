using System.Runtime.CompilerServices;

namespace KonamiCommonIAB
{
	public class SimpleTuple<T1, T2>
	{
		public T1 First
		{
			[CompilerGenerated]
			get
			{
				return default(T1);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public T2 Second
		{
			[CompilerGenerated]
			get
			{
				return default(T2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SimpleTuple(T1 first, T2 second)
		{
		}
	}
}
