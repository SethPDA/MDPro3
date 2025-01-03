using System;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentSerializeData
	{
		[SerializeField]
		protected string tp;

		[SerializeField]
		protected string data;

		public MDMarkupContentSerializeData(IMDMarkupContent content)
		{
		}

		public MDMarkupDef.MarkupType GetMarkupType()
		{
			return default(MDMarkupDef.MarkupType);
		}

		public string GetData()
		{
			return null;
		}
	}
}
