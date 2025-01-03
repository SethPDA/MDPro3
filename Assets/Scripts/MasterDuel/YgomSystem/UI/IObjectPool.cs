namespace YgomSystem.UI
{
	public interface IObjectPool<T>
	{
		void CreateReserve(int cnt);

		T Rent();

		void Return(T obj);

		void ReturnAll();
	}
}
