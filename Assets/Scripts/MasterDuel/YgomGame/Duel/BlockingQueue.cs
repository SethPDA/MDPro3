using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class BlockingQueue<T>
	{
		private Queue<T> queue;

		public int Count => 0;

		public void Clear()
		{
		}

		public T Peek()
		{
			return default(T);
		}

		public void Enqueue(T obj)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}

		public T[] ToArray()
		{
			return null;
		}

		public U DeepCopy<U>(U target)
		{
			return default(U);
		}
	}
}
