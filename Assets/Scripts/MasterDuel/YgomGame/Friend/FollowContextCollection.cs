using System.Collections;
using System.Collections.Generic;

namespace YgomGame.Friend
{
	public class FollowContextCollection : PlayerContextCollection//, IReadOnlyDictionary<long, FollowPlayerContext>, IEnumerable<KeyValuePair<long, FollowPlayerContext>>, IEnumerable, IReadOnlyCollection<KeyValuePair<long, FollowPlayerContext>>
	{
		private Dictionary<long, FollowPlayerContext> m_PlayerContextMap;

		private IEnumerable<long> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_002EKeys => null;

		private IEnumerable<FollowPlayerContext> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_002EValues => null;

		private int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_003E_002ECount => 0;

		private FollowPlayerContext System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_002EItem => null;

		public int SearchOnlineSum()
		{
			return 0;
		}

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

		public bool TryGetValue(long key, out FollowPlayerContext value)
		{
			value = null;
			return false;
		}

		private IEnumerator<KeyValuePair<long, FollowPlayerContext>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_003E_002EGetEnumerator()
		{
			return null;
		}
	}
}
