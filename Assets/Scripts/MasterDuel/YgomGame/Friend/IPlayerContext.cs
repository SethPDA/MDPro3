using System;

namespace YgomGame.Friend
{
	public interface IPlayerContext : IComparable<IPlayerContext>
	{
		long pcode { get; }

		string playerName { get; }

		string platformPlayerName { get; }

		bool isRegistedPlatform { get; }

		bool isSamePlatform { get; }

		int iconId { get; }

		int iconFrameId { get; }

		int wallpaperId { get; }

		FollowState followState { get; }

		bool isPin { get; }

		long onlineTime { get; }

		long loginTime { get; }

		long followedTime { get; }

		bool isOnline { get; }

		bool isEnableDuelWatch { get; }

		int invitedRoomId { get; }

		int invitedTeamId { get; }
	}
}
