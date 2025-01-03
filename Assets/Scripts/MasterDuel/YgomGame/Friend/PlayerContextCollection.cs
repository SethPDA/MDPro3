using System.Collections;
using System.Collections.Generic;

namespace YgomGame.Friend
{
	public class PlayerContextCollection// : IReadOnlyList<IPlayerContext>, IEnumerable<IPlayerContext>, IEnumerable, IReadOnlyCollection<IPlayerContext>
	{
		protected readonly List<IPlayerContext> m_PlayerContexts;

		public IPlayerContext Item => null;

		public int Count => 0;

		public IEnumerator<IPlayerContext> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
