using System.Collections;
using System.Collections.Generic;

namespace YgomGame.Friend
{
	public class BlockContextCollection : PlayerContextCollection//, IReadOnlyDictionary<long, BlockPlayerContext>, IEnumerable<KeyValuePair<long, BlockPlayerContext>>, IEnumerable, IReadOnlyCollection<KeyValuePair<long, BlockPlayerContext>>
	{
		private Dictionary<long, BlockPlayerContext> m_PlayerContextMap;

		private IEnumerable<long> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_002EKeys => null;

		private IEnumerable<BlockPlayerContext> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_002EValues => null;

		private int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_003E_002ECount => 0;

		private BlockPlayerContext System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_002EItem => null;

		public void Import(IReadOnlyDictionary<string, object> followPlayers)
		{
		}

		public void Sort()
		{
		}

		public bool ContainsKey(long key)
		{
			return false;
		}

		public bool TryGetValue(long key, out BlockPlayerContext value)
		{
			value = null;
			return false;
		}

		private IEnumerator<KeyValuePair<long, BlockPlayerContext>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_003E_002EGetEnumerator()
		{
			return null;
		}
	}
}
