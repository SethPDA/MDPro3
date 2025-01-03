namespace YgomSystem.ResourceSystem
{
	public abstract class BaseChecker : IResTypeChecker
	{
		public abstract ResTypeData GetResType(string path);

		public abstract ResTypeData GetResTypeSimpleCheck(string path);

		public virtual void Initialize()
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual void ClearCache()
		{
		}
	}
}
