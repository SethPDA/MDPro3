using System;
using System.Collections.Generic;
using YgomGame.Utility;
using YgomSystem.UI;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupBoardContainer : MDMarkupContainerBase
	{
		[Serializable]
		public class FooterContent
		{
			public enum ContentType
			{
				Text = 0,
				Button = 1
			}

			[Serializable]
			public class Content
			{
				public ContentType tp;

				public GlobalTextData text;

				public string url;

				public SelectorManager.KeyType shortcut;

				public bool consoleOnly;

				public bool interactable;

				public object ExportJsonObj()
				{
					return null;
				}

				public void ImportJsonObj(object jsonObj)
				{
				}
			}

			public List<Content> contents;

			public void Clear()
			{
			}

			public object ExportJsonObj()
			{
				return null;
			}

			public void ImportJsonObj(object jsonObj)
			{
			}
		}

		public FooterContent footerContent;

		public override MDMarkupDef.ContainerType containerType => default(MDMarkupDef.ContainerType);

		public override void Clear()
		{
		}

		public override object ExportJsonObj()
		{
			return null;
		}

		public override void ImportJsonObj(object jsonObj)
		{
		}

		protected override void InnerSearchUseTextGroups(List<string> useTextGroups)
		{
		}
	}
}
