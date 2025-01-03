using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupBannerContext
	{
		private const string k_JKeyPrefPath = "prefPath";

		private const string k_JKeyPrefArgsJson = "prefArgsJson";

		public string prefPath;

		[TextArea]
		public string prefArgsJson;

		public Dictionary<string, object> prefArgs;

		public bool isValid => false;

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}

		public void CopyTo(MDMarkupBannerContext other, bool deep = false)
		{
		}
	}
}
