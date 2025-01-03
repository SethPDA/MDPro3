namespace YgomSystem.ResourceSystem
{
	public class LocalFileChecker : BaseChecker
	{
		protected virtual Resource.Type TypeLocalFile => default(Resource.Type);

		protected virtual Resource.Type TypeBinary => default(Resource.Type);

		protected virtual Resource.Type TypeAssetBundle => default(Resource.Type);

		public override ResTypeData GetResType(string path)
		{
			return null;
		}

		public override ResTypeData GetResTypeSimpleCheck(string path)
		{
			return null;
		}

		protected virtual bool isExistFile(string path)
		{
			return false;
		}

		protected virtual bool isAssetBundleData(string path)
		{
			return false;
		}

		protected virtual ResTypeData GetResTypeCheckType(string path, bool checkType)
		{
			return null;
		}

		private string GetLocalFilePath(string path)
		{
			return null;
		}

		public override void ClearCache()
		{
		}

		protected virtual string GetCheckExistFilePath(string path)
		{
			return null;
		}
	}
}
