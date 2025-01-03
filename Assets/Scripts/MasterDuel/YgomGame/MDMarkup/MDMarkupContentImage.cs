using System;
using TMPro;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentImage : MDMarkupContentBase
	{
		[MDMarkupIndent]
		[SerializeField]
		private int indent;

		[SerializeField]
		public TextAlignmentOptions alignment;

		[SerializeField]
		public string imagePath;

		[SerializeField]
		public float overrideHeight;

		[SerializeField]
		public bool ignorePadding;

		[SerializeField]
		public bool usePrefferedSize;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}
	}
}
