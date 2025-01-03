using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PromoCodes
{
	public class PromoCodesViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string k_VCPath = "PromoCodes/PromoCodes";

		private const string k_Args_PromoCodeId = "promoCodeId";

		private const string k_ELabel_HeaderPromoNameText = "PromoNameText";

		private const string k_ELabel_InputFormRoot = "InputFormRoot";

		private const string k_ELabel_CooltimeLoadingIcon = "CooltimeLoadingIcon";

		private const string k_ELabel_InputField = "InputField";

		private const string k_ELabel_CompleteLabelRoot = "CompleteLabelRoot";

		private const string k_TLabel_CooltimeLoadingIconShow = "Show";

		private const string k_OLabel_ScrollBarDefault = "Default";

		private const string k_OLabel_ScrollBarOnFooter = "OnFooter";

		[SerializeField]
		private float m_CoolTime;

		private IEnumerator m_ProgressUpdateRoutine;

		private Coroutine m_InputCooltimeRoutine;

		private List<string> m_LoadedTextGroups;

		private int m_PromoCodesId;

		private Dictionary<string, object> m_PromoCodeDataWork;

		private InputFieldWidget m_InputFieldWidget;

		protected override Type[] textIds => null;

		public static bool OpenWithValidate(bool pushOnHome = false)
		{
			return false;
		}

		public static bool OpenWithValidate(int promoCodeId, bool pushOnHome = false)
		{
			return false;
		}

		public override void NotificationStackEntry()
		{
		}

		private void OnLaunchFailed()
		{
		}

		public override void ProgressUpdate()
		{
		}

		private IEnumerator yProgressUpdateRoutine(Action onComplete)
		{
			return null;
		}

		public override void NotificationStackRemove()
		{
		}

		private void Start()
		{
		}

		private void RefreshView()
		{
		}

		private InputField.ContentType GetPromoCodeFormatContentType(PromoCodeFormat format)
		{
			return default(InputField.ContentType);
		}

		private void StartInputCooltimeRoutine()
		{
		}

		private IEnumerator yInputCooltimeRoutine()
		{
			return null;
		}

		private void OnSubmitInput(string input)
		{
		}

		private void OnCodeDecided(string promoCode)
		{
		}

		private void OnCodeSendResult(Handle h)
		{
		}

		private void OnCodeSuccess(Dictionary<string, object> resultWork)
		{
		}

		private void OnCodeFailed(Dictionary<string, object> resultWork, PromoCodesCode resultCode)
		{
		}
	}
}
