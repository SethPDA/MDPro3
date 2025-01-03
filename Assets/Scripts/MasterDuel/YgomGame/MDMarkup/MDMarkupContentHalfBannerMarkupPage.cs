using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentHalfBannerMarkupPage : MDMarkupContentPageBase, IMDMarkupContentGlobalText, IMDMarkupContentAsyncLoader
	{
		[SerializeField]
		public MDMarkupBannerContext banner;

		[SerializeField]
		public List<URLSchemeButton> buttons;

		public List<IMDMarkupContent> contents;

		private int m_LoadingCnt;

		private Action m_LoadAsyncOnComplete;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public IReadOnlyList<string> GetTextGloups()
		{
			return null;
		}

		public void LoadAsync(Action onComplete)
		{
		}

		private void LoadAsyncCompleteCheck()
		{
		}

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}
	}
}
