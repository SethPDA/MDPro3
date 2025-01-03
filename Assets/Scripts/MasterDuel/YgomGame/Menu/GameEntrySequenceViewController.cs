using System;
using System.Collections;
using System.Collections.Generic;
using YgomSystem;

namespace YgomGame.Menu
{
	public class GameEntrySequenceViewController : BaseMenuViewController
	{
		private enum Step
		{
			Start = 0,
			CountrySelect = 1,
			StartingAgeGate = 2,
			USAStateSelect = 3,
			StartingTermOfService = 4,
			StartingPrivacyPolicy = 5,
			StartSurvey = 6,
			AccountCreate = 7,
			ExistingLogin = 8,
			ReagreementAgeGate = 9,
			ReagreementTermOfService = 10,
			ReagreementPrivacyPolicy = 11,
			Reagree = 12,
			PasswordInput = 13,
			RestoreProduct = 14,
			Finish = 1000,
			ErrorAbort = 9999
		}

		private class UserData
		{
			public bool isFirstPlay;

			public int countryCode;

			public int stateCode;

			public int ageGateYear;

			public int ageGateMonth;

			public int ageGateDay;

			public Dictionary<string, object> surveyAnswer;
		}

		private StepSequencer m_sequencer;

		private Stack<Step> m_backSteps;

		private UserData m_userData;

		private CountryList m_countryList;

		private USAStateList m_stateList;

		protected override Type[] textIds => null;

		private UserAgreementType currentAgreementType()
		{
			return default(UserAgreementType);
		}

		private static bool isMobile()
		{
			return false;
		}

		private static AccountUtility.PrivacyOptionType getUSAPrivacyOption(int birthYear, int birthMonth, int birthDay)
		{
			return default(AccountUtility.PrivacyOptionType);
		}

		private static void quitGameEntry()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Update()
		{
		}

		private void saveStepHistory(StepSequencer seq)
		{
		}

		private void backStepHistory(StepSequencer seq)
		{
		}

		private void clearStepHistory()
		{
		}

		private void stepStart(StepSequencer seq)
		{
		}

		private IEnumerator stepCountrySelect(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepStartingAgeGate(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepUSAStateSelect(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepStartingTermOfService(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepStartingPrivacyPolicy(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepStartSurvey(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepAccountCreate(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepExistingLogin(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepReagreementAgeGate(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepReagreementTermOfService(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepReagreementPrivacyPolicy(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepReagree(StepSequencer seq)
		{
			return null;
		}

		private IEnumerator stepPasswordInput(StepSequencer seq)
		{
			return null;
		}

		private void stepRestoreUnfinishedProducts(StepSequencer seq)
		{
		}

		private void stepErrorAbort(StepSequencer seq)
		{
		}

		private void stepFinish(StepSequencer seq)
		{
		}

		private IEnumerator callTermOfServiceView(UserAgreementType agreementType, string url, Action<int> resultCallback)
		{
			return null;
		}

		private IEnumerator callPrivacyPolicyView(UserAgreementType agreementType, Action<int> resultCallback)
		{
			return null;
		}

		private IEnumerator callAgeGateView(int defaultYear, int defaultMonth, int defaultDay, Action<int, int, int> resultCallback)
		{
			return null;
		}

		private IEnumerator showErrorDialog(string title, string msg)
		{
			return null;
		}
	}
}
