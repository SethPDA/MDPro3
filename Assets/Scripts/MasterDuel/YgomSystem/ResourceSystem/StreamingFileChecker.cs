namespace YgomSystem.ResourceSystem
{
	public class StreamingFileChecker : LocalFileChecker
	{
		protected override Resource.Type TypeAssetBundle => default(Resource.Type);

		protected override Resource.Type TypeBinary => default(Resource.Type);

		protected override Resource.Type TypeLocalFile => default(Resource.Type);

		protected override bool isExistFile(string path)
		{
			return false;
		}

		protected override bool isAssetBundleData(string path)
		{
			return false;
		}

		protected override string GetCheckExistFilePath(string path)
		{
			return null;
		}
	}
}
