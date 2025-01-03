using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class TableRow
	{
		[SerializeField]
		public string style;

		[SerializeField]
		public bool border;

		[SerializeField]
		public List<TableCell> cells;

		public MDMarkupDef.TableRowStyle styleType
		{
			get
			{
				return default(MDMarkupDef.TableRowStyle);
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
