using System;

namespace YgomSystem.SocialSystem
{
	public interface ISocialSystem
	{
		bool IsEnableAutoLogin { get; }

		bool IsFirstAutoLogin { get; }

		bool IsAuthenticated { get; }

		string socialId { get; }

		void Activate();

		void Authenticate(Action<bool> callback = null);

		void SignOut();

		void ShowAchievementUI();

		string ConvertAchievementIdToKey(int achievementId);

		void UnlockAchievement(string id, Action<bool> callback = null);
	}
}
