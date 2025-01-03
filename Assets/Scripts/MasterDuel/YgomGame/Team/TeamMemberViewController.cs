using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Team
{
	public class TeamMemberViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, TeamLobbyPollingWatcher.ICallback
	{
		public class PcodeData : MonoBehaviour
		{
			public long value
			{
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		public class Param
		{
			public TeamLobbyPollingWatcher watchDog
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int teamNumMax
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private enum ArgKeyName
		{
			name = 0,
			pcode = 1,
			follow_num = 2,
			follower_num = 3,
			level = 4,
			rank = 5,
			rate = 6,
			icon_id = 7,
			icon_frame_id = 8,
			tag = 9,
			avatar_id = 10,
			wallpaper = 11,
			exp = 12,
			need_exp = 13,
			online_id = 14,
			is_same_os = 15,
			xuid = 16,
			edit = 17,
			rank_event = 18,
			official = 19,
			MAX = 20
		}

		private readonly string LBL_PLATFORMPLAYERICON;

		private readonly string LBL_PLATFORMPLAYERNAMEGROUP;

		private readonly string LBL_PROFILEICON;

		private readonly string LBL_BUTTON;

		private InfinityScrollView _scrollView;

		private Param _param;

		private Dictionary<long, Dictionary<string, object>> members;

		private Dictionary<int, string> s_KeyNameCaches;

		private List<long> _orderedPcodes;

		public static void Open(ViewControllerManager manager, Param param)
		{
		}

		private bool GetBool(Dictionary<string, object> data, ArgKeyName key)
		{
			return false;
		}

		private int GetInt(Dictionary<string, object> data, ArgKeyName key)
		{
			return 0;
		}

		private long GetLong(Dictionary<string, object> data, ArgKeyName key)
		{
			return 0L;
		}

		private string GetString(Dictionary<string, object> data, ArgKeyName key)
		{
			return null;
		}

		private void Register(Dictionary<string, object> data, ArgKeyName key, object value)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Start()
		{
		}

		private void OnEntityUpdate(GameObject obj, int index)
		{
		}

		public void OnPollingResponse(Handle handle)
		{
		}

		private void OnProfileCardOpening(Dictionary<string, object> member)
		{
		}

		private void UpdateMembers()
		{
		}

		public void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
		{
		}

		public void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
		{
		}

		public void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
		{
		}
	}
}
