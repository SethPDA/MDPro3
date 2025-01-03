using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Team
{
	[DisallowMultipleComponent]
	public class TeamLobbyPollingWatcher : MonoBehaviour
	{
		public interface ICallback
		{
			void OnPollingResponse(Handle handle);

			void OnApplyingStatusChanged(ApplyingBattleData data);

			void OnAppliedFromOtherTeam(AppliedBattleData data);

			void OnOpponentTeamInfoUpdated(OpponentTeamInfo data);
		}

		public enum ApplyingStatusOnServer
		{
			NONE = 0,
			WAITING = 1,
			CANCEL = 2,
			REJECT = 3,
			ACCEPT = 4,
			READY = 5
		}

		public struct ApplyingBattleData
		{
			public ApplyingStatusOnServer status;

			public int mrk;

			public int teamId;

			public bool Equals(ref ApplyingBattleData other)
			{
				return false;
			}
		}

		public struct AppliedBattleData
		{
			public int mrk;

			public int duelDurationId;

			public int teamId;

			public bool valid => false;

			public bool Equals(ref AppliedBattleData other)
			{
				return false;
			}
		}

		private const float POLLING_SPAN = 3f;

		private const string CW_PATH_REQUEST_INFO = "$.DuelMenu.TeamMatch.team_info.request_info";

		private const string CW_PATH_NEW_REQUEST = "$.DuelMenu.TeamMatch.team_info.new_request";

		private static HashSet<ulong> s_alives;

		private static ulong s_InstanceNumber;

		private IEnumerator _routine;

		private TeamUtil.MatchType _matchType;

		private ViewControllerManager manager;

		private ulong number;

		private bool _isForceLeaveErrOccured;

		private bool _isFatalErrOccured;

		private HashSet<ICallback> _callbacks;

		private ApplyingBattleData _applyingBattleData;

		private AppliedBattleData _appliedBattleData;

		public ApplyingStatusOnServer applyingStatus => default(ApplyingStatusOnServer);

		private bool isErrorDlgShowing => false;

		private bool shouldPolling => false;

		private bool checkTerminate => false;

		public bool isApplyingToOppTeam => false;

		public void StartWatching()
		{
		}

		public void StopWatching()
		{
		}

		public void Register(ICallback target)
		{
		}

		public void Unregister(ICallback target)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnResponse(Handle res)
		{
		}

		private void SendApplyStatusChanged(ApplyingBattleData data)
		{
		}

		private void SendApplicationFromOtherTeam(AppliedBattleData data)
		{
		}

		private void SendOpponentTeamInfoUpdated(OpponentTeamInfo data)
		{
		}

		private void OnApplyingBattleDataUpdated(object rootData)
		{
		}

		private void OnAppliedBattleDataUpdated(object rootData)
		{
		}

		private void OnOpponentTeamInfoUpdated(object rootData)
		{
		}

		private IEnumerator Watching()
		{
			return null;
		}

		private IEnumerator CallPolling()
		{
			return null;
		}
	}
}
