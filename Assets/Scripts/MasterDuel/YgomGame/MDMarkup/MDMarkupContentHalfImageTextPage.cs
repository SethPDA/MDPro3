using System;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentHalfImageTextPage : MDMarkupContentFullTextPage, IMDMarkupContentGlobalText
	{
		[SerializeField]
		public string resourcePath;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}
	}
}
