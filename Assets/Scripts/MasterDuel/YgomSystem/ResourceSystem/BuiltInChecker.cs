namespace YgomSystem.ResourceSystem
{
	public class BuiltInChecker : BaseChecker
	{
		private ResourceExistsConvertData existsConvertData;

		public override ResTypeData GetResType(string path)
		{
			return null;
		}

		public override ResTypeData GetResTypeSimpleCheck(string path)
		{
			return null;
		}

		protected ResTypeData GetData(string path)
		{
			return null;
		}

		protected string GetResourcePath(string path)
		{
			return null;
		}

		private bool ExistsConvertFile(string path)
		{
			return false;
		}

		protected bool ExistsFile(string path)
		{
			return false;
		}

		public override void Initialize()
		{
		}

		public override void Destroy()
		{
		}
	}
}
