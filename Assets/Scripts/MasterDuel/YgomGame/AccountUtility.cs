using System;
using System.Collections;
using System.Collections.Generic;
using YgomSystem;
using YgomSystem.Network;

namespace YgomGame
{
	public static class AccountUtility
	{
		public class AccoutCreateParamter
		{
			public int countryNumeric;

			public UserAgreementType userAgreementType;

			public PrivacyOptionType privacyOption;

			public Dictionary<string, object> survayAnswer;
		}

		public enum PrivacyOptionType
		{
			None = 0,
			OptIn = 1,
			OptOut = 2
		}

		public enum LoginResultCode
		{
			Success = 0,
			Error_Create = 1,
			Error_Auth = 2,
			Error_Platform_Check = 3,
			Error_Platform_Reauth = 4,
			Error_Agreement_Required = 5,
			Error_Password_Required = 6,
			Error_Banned = 7,
			Error_Unknown = 8
		}

		public enum BanType
		{
			None = 0,
			Alert = 1,
			LimitedBan = 2,
			PermanentBan = 3,
			Removed = 4
		}

		private static SteamAuthSession steamAuthSession;

		private static IEnumerator GetSteamAuthSession(bool cancel, Action<string> resultCallback)
		{
			return null;
		}

		public static IEnumerator GetAuthSessionForKidCheck(Action<string, bool> resultCallback)
		{
			return null;
		}

		private static IEnumerator callAPICoroutine(Handle apiHandle, Action<int> resultCallback)
		{
			return null;
		}

		private static IEnumerator loginCoroutine(AccoutCreateParamter createParam, Action<LoginResultCode> resultCallback)
		{
			return null;
		}

		private static IEnumerator resumeCoroutine(Action<bool> resultCallback)
		{
			return null;
		}

		public static IEnumerator RefreshAuthCoroutine(Action<bool> resultCallback)
		{
			return null;
		}

		public static void Resume(Action<bool> resultCallback)
		{
		}

		public static IEnumerator ResumeCoroutine(Action<bool> resultCallback)
		{
			return null;
		}

		public static void CreateAccount(AccoutCreateParamter parameter, Action<LoginResultCode> resultCallback)
		{
		}

		public static IEnumerator CreateAccountCoroutine(AccoutCreateParamter parameter, Action<LoginResultCode> resultCallback)
		{
			return null;
		}

		public static void Auth(Action<LoginResultCode> resultCallback)
		{
		}

		public static IEnumerator AuthCoroutine(Action<LoginResultCode> resultCallback)
		{
			return null;
		}

		public static void RefreshAuth(Action<bool> resultCallback)
		{
		}

		public static IEnumerator ReagreeCoroutine(IReadOnlyList<AgreementKind> agreementKinds, PrivacyOptionType privacyOption, Action<int> resultCallback)
		{
			return null;
		}

		public static IEnumerator UnlockCoroutine(string password, Action<bool> resultCallback)
		{
			return null;
		}

		public static void AlertXboxMultiplayOFFMessage(Action onEnd = null)
		{
		}

		public static bool GetBanDialogData(out BanType banType, out string title, out string message, out string button)
		{
			banType = default(BanType);
			title = null;
			message = null;
			button = null;
			return false;
		}

		private static string getBanText(Dictionary<string, object> cw, string textIdKey, string textKey)
		{
			return null;
		}
	}
}
