using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public class LocationInfo
	{
		public delegate void UpdateCallback();

		public int player;

		public int position;

		public int index;

		public event UpdateCallback updateCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		public void Set(int player, int position, int index)
		{
		}

		public void Reset()
		{
		}

		public bool IsEquals(int player, int position, int index)
		{
			return false;
		}

		public int GetIndex(int player, int position)
		{
			return 0;
		}
	}
}
