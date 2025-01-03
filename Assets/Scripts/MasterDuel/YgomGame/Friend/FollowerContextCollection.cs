using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Friend
{
	public class FollowerContextCollection : PlayerContextCollection//, IReadOnlyDictionary<long, FollowerPlayerContext>, IEnumerable<KeyValuePair<long, FollowerPlayerContext>>, IEnumerable, IReadOnlyCollection<KeyValuePair<long, FollowerPlayerContext>>
	{
		public enum Dir
		{
			Next = 0,
			Back = 1
		}

		public int cacheReleaseLine;

		private Dictionary<long, FollowerPlayerContext> m_FollowerContextMap;

		private List<FollowerPlayerContext> m_ImportTmpList;

		public long headPcode
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long headDate
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isHeadTerminal
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long tailPcode
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long tailDate
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isTailTerminal
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private FollowerPlayerContext System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_002EItem => null;

		private IEnumerable<long> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_002EKeys => null;

		private IEnumerable<FollowerPlayerContext> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_002EValues => null;

		private int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_003E_002ECount => 0;

		public void Import((List<object>, bool) followerDatas, Dir dir, IReadOnlyDictionary<string, object> followPlayers, Action onReleasedCallback = null)
		{
		}

		public void Import(IReadOnlyList<object> friendDatas, bool isTerminal, Dir dir, IReadOnlyDictionary<string, object> followPlayers, Action onReleasedCallback = null)
		{
		}

		public void ImportFollows(IReadOnlyDictionary<string, object> followPlayers)
		{
		}

		public bool ContainsKey(long key)
		{
			return false;
		}

		public bool TryGetValue(long key, out FollowerPlayerContext value)
		{
			value = null;
			return false;
		}

		private IEnumerator<KeyValuePair<long, FollowerPlayerContext>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_003E_002EGetEnumerator()
		{
			return null;
		}
	}
}
