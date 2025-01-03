using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class PropertyContainer : MonoBehaviour//, IReadOnlyDictionary<string, string>, IEnumerable<KeyValuePair<string, string>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, string>>
	{
		[Serializable]
		public class PropertyInfo
		{
			public string label;

			[Multiline]
			public string property;

			public KeyValuePair<string, string> keyValuePair => default(KeyValuePair<string, string>);

			public PropertyInfo Copy()
			{
				return null;
			}
		}

		public List<PropertyInfo> propertyList;

		public IEnumerable<string> Keys => null;

		public IEnumerable<string> Values => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		public string Item => null;

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out string value)
		{
			value = null;
			return false;
		}

		public float GetValueOrDefault(string key, float defaultVal = 0f)
		{
			return 0f;
		}

		public int GetValueOrDefault(string key, int defaultVal = 0)
		{
			return 0;
		}

		public string GetValueOrDefault(string key, string defaultVal = null)
		{
			return null;
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
