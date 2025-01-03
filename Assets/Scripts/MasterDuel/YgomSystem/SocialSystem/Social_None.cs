using System;

namespace YgomSystem.SocialSystem
{
	public class Social_None : ISocialSystem
	{
		public bool IsEnableAutoLogin => false;

		public bool IsFirstAutoLogin => false;

		public bool IsAuthenticated => false;

		public string socialId => null;

		public void Activate()
		{
		}

		public void Authenticate(Action<bool> callback = null)
		{
		}

		public void SignOut()
		{
		}

		public void ShowAchievementUI()
		{
		}

		public string ConvertAchievementIdToKey(int achievementId)
		{
			return null;
		}

		public void UnlockAchievement(string id, Action<bool> callback = null)
		{
		}
	}
}
