using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class ColorLabelSetting : ScriptableObject
	{
		[Serializable]
		public class ValueContainer
		{
			public string label;

			public Color color;

			public ValueContainer Copy()
			{
				return null;
			}
		}

		public List<ValueContainer> list;

		private Dictionary<string, ValueContainer> m_labelMap;

		public void Setup()
		{
		}

		public ValueContainer Get(string label)
		{
			return null;
		}

		public bool Get(string label, out Color res)
		{
			res = default(Color);
			return false;
		}
	}
}
