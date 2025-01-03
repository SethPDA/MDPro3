using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.UI;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class URLSchemeButton
	{
		[SerializeField]
		public string url;

		[SerializeField]
		public GlobalTextData label;

		[SerializeField]
		public SelectorManager.KeyType shortcut;

		[SerializeField]
		public bool interactable;

		public URLSchemeButton()
		{
		}

		public URLSchemeButton(string url, string rawLabel, SelectorManager.KeyType shortcut)
		{
		}

		public static object ExportJsonObj(List<URLSchemeButton> buttons)
		{
			return null;
		}

		public static List<URLSchemeButton> ImportJsonObj(object jsonObj)
		{
			return null;
		}
	}
}
