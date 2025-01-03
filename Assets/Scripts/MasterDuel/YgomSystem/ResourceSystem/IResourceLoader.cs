using System.Collections;

namespace YgomSystem.ResourceSystem
{
	public interface IResourceLoader
	{
		bool DisablePathForErrorHandler { get; }

		void Initialize();

		void Load(Resource res, uint crc);

		IEnumerator LoadAsync(Resource res, uint key);

		void LateUpdate();

		void ClearCache();
	}
}
