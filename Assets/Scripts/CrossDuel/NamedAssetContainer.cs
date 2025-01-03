using UnityEngine;

namespace Willow
{
	[CreateAssetMenu]
	public class NamedAssetContainer : AssetContainer
	{
		[SerializeField]
		private string[] m_keys;

		private void OnEnable()
		{
            for (int i = 0; i < m_keys.Length; i++)
                m_table.Add(m_keys[i], m_container[i]);
        }

		public string[] AllNamedAssetNames()
		{
			return m_keys;
		}

		public void Set<T>(string name, T value) where T : Object
		{
		}
	}
}
