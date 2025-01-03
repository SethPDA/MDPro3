using System.Collections.Generic;

namespace YgomSystem.ResourceSystem
{
	public abstract class AbstractReferenceCache<T> where T : class
	{
		protected Dictionary<string, T> m_refCache;

		private Dictionary<string, int> m_refCount;

		protected abstract T LoadRequest(string key, params object[] param);

		protected virtual void RemoveCacheAction(T value)
		{
		}

		public virtual void Clear()
		{
		}

		protected virtual void ClearKey(string key)
		{
		}

		public bool Exist(string key)
		{
			return false;
		}

		public void AddReference(string key, T value)
		{
		}

		public T GetReference(string key, params object[] param)
		{
			return null;
		}

		public void RemoveReference(string key)
		{
		}

		private void AddRefCount(string key)
		{
		}

		private int DecRefCount(string key)
		{
			return 0;
		}
	}
}
