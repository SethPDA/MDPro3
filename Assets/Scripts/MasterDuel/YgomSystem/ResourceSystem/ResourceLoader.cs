using System.Collections.Generic;

namespace YgomSystem.ResourceSystem
{
	public class ResourceLoader
	{
		public enum LoadType
		{
			None = 0,
			BuiltIn = 1,
			AssetBundle = 2,
			Binary = 3,
			Network = 4,
			StreamingBinary = 5,
			PlayAssetDelivery = 6
		}

		private Dictionary<int, IResourceLoader> loaderDic;

		private Dictionary<Resource.Type, LoadType> resourceTypeToLoaderDic;

		public void Initialize(ResourceManager.ProgressHandler progressHandler, ResourceManager.RetryHandler retryHandler, float HttpTimeOut)
		{
		}

		public IResourceLoader GetLoader(Resource.Type resType)
		{
			return null;
		}

		public void LateUpdate()
		{
		}

		public void ClearCache()
		{
		}

		public void Destroy()
		{
		}

		public string GetPathFromSpriteTagName(string tag)
		{
			return null;
		}
	}
}
