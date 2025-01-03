namespace YgomSystem.ResourceSystem
{
	public interface IResTypeChecker
	{
		void Initialize();

		void Destroy();

		void ClearCache();

		ResTypeData GetResType(string path);

		ResTypeData GetResTypeSimpleCheck(string path);
	}
}
