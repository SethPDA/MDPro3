using System.Collections;

namespace YgomSystem.ResourceSystem
{
	public class BuiltInLoader : BaseLoader
	{
		public override void Load(Resource res, uint crc)
		{
		}

		public override IEnumerator LoadAsync(Resource res, uint key)
		{
			return null;
		}
	}
}
