using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentFullImagePage : MDMarkupContentPageBase, IMDMarkupContentGlobalText
	{
		[SerializeField]
		public GlobalTextData caption;

		[SerializeField]
		public string resourcePath;

		[SerializeField]
		public List<URLSchemeButton> buttons;

		public bool isCreatedSprite;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public Sprite imageSprite
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

		public GameObject prefab
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

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}
	}
}
