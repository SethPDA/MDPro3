using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentEmbedContainerTab : MDMarkupContentBase, IMDMarkupContentGlobalText, IMDMarkupContentAsyncLoader
	{
		[SerializeField]
		public string mmaPath;

		[SerializeField]
		public GlobalTextData overrideTitle;

		private Action m_LoadAsyncOnComplete;

		private int m_LoadingCnt;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		public MDMarkupAsset embedMarkupAsset
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

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
