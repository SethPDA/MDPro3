using System.Collections.Generic;

namespace YgomGame
{
	public static class AgreementUtility
	{
		private class AgreementKindInfo
		{
			public AgreementKind kind;

			public long revision;

			public LanguageUrlSet urls;

			private AgreementKindInfo()
			{
			}

			public AgreementKindInfo(AgreementKind kind, long revision, LanguageUrlSet urls)
			{
			}
		}

		private class DataManager
		{
			private Dictionary<AgreementKind, AgreementKindInfo> m_kindInfos;

			private UserAgreementType m_currentAgreementType;

			private Dictionary<PlatformTOSKind, LanguageUrlSet> m_TOSUrls;

			private AgreeRequirementType m_requirementType;

			private List<AgreementKind> m_reagreeKinds;

			private bool m_reagreeAgeGate;

			public UserAgreementType currentAgreementType => default(UserAgreementType);

			public AgreeRequirementType requirementType => default(AgreeRequirementType);

			public bool isNeedReagreeAgeGate => false;

			private AgreementKindInfo getAgreementKindInfo(AgreementKind kind)
			{
				return null;
			}

			public void Clear()
			{
			}

			public long GetAgreementKindRevision(AgreementKind kind)
			{
				return 0L;
			}

			public string GetAgreementKindUrl(AgreementKind kind, string lang)
			{
				return null;
			}

			public string GetTermOfServiceUrl(PlatformTOSKind TOSKind, string lang)
			{
				return null;
			}

			public List<AgreementKind> GetReagreeKinds()
			{
				return null;
			}

			public void ClearReagree()
			{
			}

			public string[] MakeAgreementRevisionParameter(IReadOnlyList<AgreementKind> kinds)
			{
				return null;
			}

			public void ImportAgreementInfo(object value)
			{
			}

			public void ImportNeedReagree(object value)
			{
			}
		}

		private static readonly Dictionary<UserAgreementType, AgreementKind[]> c_requiredKindsTable;

		private static DataManager s_instance;

		static AgreementUtility()
		{
		}

		private static void debugLog(string msg)
		{
		}

		public static void Clear()
		{
		}

		public static UserAgreementType GetCurrentAgreementType()
		{
			return default(UserAgreementType);
		}

		public static AgreementKind[] GetRequiredKinds(UserAgreementType agreementType)
		{
			return null;
		}

		public static long GetAgreementKindRevision(AgreementKind kind)
		{
			return 0L;
		}

		public static string GetAgreementKindUrl(AgreementKind kind, string lang = "")
		{
			return null;
		}

		public static string GetTermOfServiceUrl(PlatformTOSKind TOSKind, string lang = "")
		{
			return null;
		}

		public static AgreeRequirementType GetRequirementType()
		{
			return default(AgreeRequirementType);
		}

		public static List<AgreementKind> GetReagreeKinds()
		{
			return null;
		}

		public static bool IsNeedReagreeAgeGate()
		{
			return false;
		}

		public static void ClearReagree()
		{
		}

		public static string[] MakeAgreementRevisionParameter(IReadOnlyList<AgreementKind> kinds)
		{
			return null;
		}

		public static void ImportAgreementInfo(object value)
		{
		}

		public static void ImportNeedReagree(object value)
		{
		}
	}
}
