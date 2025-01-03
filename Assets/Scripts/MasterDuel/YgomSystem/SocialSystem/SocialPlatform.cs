using System;
using System.Collections;
using UnityEngine;

namespace YgomSystem.SocialSystem
{
	public class SocialPlatform
	{
		private static ISocialSystem s_instance;

		private static Coroutine yWatchObserver;

		public static bool IsEnable => false;

		public static bool IsAuthenticated => false;

		public static string socialId => null;

		public static string socialHashId => null;

		private static bool IsEnableAutoLogin => false;

		static SocialPlatform()
		{
		}

		private static bool IsInitAutoLogin()
		{
			return false;
		}

		public static void Initialize()
		{
		}

		public static void Activate()
		{
		}

		public static void Authenticate(Action<bool> callback = null)
		{
		}

		public static void SignOut()
		{
		}

		public static void UpdateSocialId()
		{
		}

		private static void StartWatchAuthenticate()
		{
		}

		private static IEnumerator yStartWatchAuthenticate(bool isAuthenticated)
		{
			return null;
		}

		private static void UpdateLoginStatus(bool isAutheticated)
		{
		}

		public static void ShowAchievementUI()
		{
		}

		private static void SetAchievementNotificator()
		{
		}

		private static void AchievementNotificator(object value)
		{
		}

		public static void UnlockAchievement(string id, Action<bool> callback = null)
		{
		}
	}
}
