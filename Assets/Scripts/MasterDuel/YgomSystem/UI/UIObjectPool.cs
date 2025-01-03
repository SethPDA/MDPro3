using System.Collections.Generic;

namespace YgomSystem.UI
{
	public abstract class UIObjectPool<T> : IObjectPool<T>
	{
		private readonly List<T> m_ActiveObjects;

		private readonly Stack<T> m_UsableStack;

		public void CreateReserve(int cnt)
		{
		}

		public T Rent()
		{
			return default(T);
		}

		protected abstract T Create();

		protected virtual void OnAfterCreate(T obj)
		{
		}

		protected virtual void OnBeforeRent(T obj)
		{
		}

		public void Return(T obj)
		{
		}

		protected virtual void OnBeforeReturn(T obj)
		{
		}

		public void ReturnAll()
		{
		}
	}
}
