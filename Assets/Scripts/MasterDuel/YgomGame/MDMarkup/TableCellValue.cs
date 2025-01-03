using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class TableCellValue
	{
		[SerializeField]
		public string type;

		[SerializeField]
		public TextAlignmentOptions alignment;

		[SerializeField]
		public GlobalTextData text;

		[SerializeField]
		public string imagePath;

		[SerializeField]
		public float overrideHeight;

		[SerializeField]
		public float overrideWidth;

		[SerializeField]
		public bool usePrefferedSize;

		[SerializeField]
		public bool detailEnabled;

		[SerializeField]
		public int mrk;

		[SerializeField]
		public int premiere;

		[SerializeField]
		public MDMarkupDef.CardSize cardSize;

		[SerializeField]
		public bool isPeriod;

		[SerializeField]
		public int itemCategory;

		[SerializeField]
		public int itemId;

		[SerializeField]
		public MDMarkupDef.ItemSize itemSize;

		[SerializeField]
		public MDMarkupBannerContext banner;

		[SerializeField]
		public string link;

		[SerializeField]
		public MDMarkupDef.ButtonStyle buttonStyle;

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

		public MDMarkupDef.TableCellValueType valueType
		{
			get
			{
				return default(MDMarkupDef.TableCellValueType);
			}
			set
			{
			}
		}

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}
	}
}
