using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Willow
{
	[CreateAssetMenu]
	public class AssetContainer : ScriptableObject
	{
		[SerializeField]
		protected Object[] m_container;

		protected readonly Dictionary<string, Object> m_table = new Dictionary<string, Object>();

		private void OnEnable()
		{
		}

		public int ObjectCount()
		{
			return m_container.Length;
		}
		public string[] AllAssetNames()
		{
			var list = new List<string>();
			foreach (var key in m_table.Keys)
				list.Add(key);
			return list.ToArray();
		}

		public T Get<T>(string name) where T : Object
		{
			if(m_table.TryGetValue(name, out var asset))
				return asset as T;
			else
				return null;
		}

		public bool TryGet<T>(string name, out T asset) where T : Object
		{
			if (m_table.TryGetValue(name, out var obj))
			{
				asset = obj as T;
                return true;
            }
			else
			{
				asset = null;
                return false;
            }
        }
    }
}
