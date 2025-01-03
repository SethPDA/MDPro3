using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingComponentsJson : MonoBehaviour, IBindingModifiyByArgsHandler
	{
		[Serializable]
		public class BindingData
		{
			public string label;

			public MonoBehaviour component;

			public string writePath;
		}

		[SerializeField]
		private List<BindingData> m_BindingDatas;

		public void OnPostModifiyByArgs(Dictionary<string, object> args)
		{
		}

		private string GenerateJson(string path, object value)
		{
			return null;
		}
	}
}
