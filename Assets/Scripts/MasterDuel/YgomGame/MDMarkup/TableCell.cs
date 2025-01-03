using System;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class TableCell
	{
		[SerializeField]
		public bool border;

		[SerializeField]
		public bool ignorePadding;

		[SerializeField]
		private TableCellValue cellValue;

		public TableCellValue value => null;

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}
	}
}
