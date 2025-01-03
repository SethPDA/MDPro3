using System.Collections;
using UnityEngine;

namespace YgomSystem.ResourceSystem
{
	public abstract class BaseLoader : IResourceLoader
	{
		public virtual bool DisablePathForErrorHandler => false;

		public virtual void Initialize()
		{
		}

		public virtual void Load(Resource res, uint crc)
		{
		}

		public virtual IEnumerator LoadAsync(Resource res, uint crc)
		{
			return null;
		}

		public virtual void LateUpdate()
		{
		}

		public virtual void ClearCache()
		{
		}

		protected byte[] decompressedData(byte[] data)
		{
			return null;
		}

		protected byte[] decompressedData(TextAsset textasset)
		{
			return null;
		}

		protected bool checkLoadedAssets(Resource res)
		{
			return false;
		}
	}
}
