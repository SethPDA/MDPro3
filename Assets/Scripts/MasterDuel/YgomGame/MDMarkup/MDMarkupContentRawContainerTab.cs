using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentRawContainerTab : MDMarkupContentBase, IMDMarkupContentGlobalText, IMDMarkupContentAsyncLoader
	{
		[SerializeField]
		public GlobalTextData title;

		public List<IMDMarkupContent> contents;

		private Action m_LoadAsyncOnComplete;

		private int m_LoadingCnt;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

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
