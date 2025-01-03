using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.LocalFileSystem;

namespace YgomSystem.ResourceSystem
{
	public class AssetBundleLoader : BaseAssetBundleLoader
	{
		internal class RequestCache : AbstractReferenceCache<LocalFileAssetBundleLoadRequest>
		{
			protected override LocalFileAssetBundleLoadRequest LoadRequest(string key, params object[] param)
			{
				return null;
			}

			protected override void RemoveCacheAction(LocalFileAssetBundleLoadRequest value)
			{
			}

			public RequestCache()
			{
				//((AbstractReferenceCache<>)(object)this)._002Ector();
			}
		}

		private DependenciesList dlcList;

		private DependenciesList dlcStreamingList;

		private RequestCache reqCache;

		private void loadDLCList()
		{
		}

		protected override List<string> GetWithDependenciesList(Resource res)
		{
			return null;
		}

		public override void Initialize()
		{
		}

		protected override IEnumerator yLoadRequestCache(string loadPath, Action<AssetBundle> callback)
		{
			return null;
		}

		protected override void RemoveRequestCache(string loadPath)
		{
		}

		protected override void ClearRequestCache()
		{
		}

		public override void ClearCache()
		{
		}

		private void CardIllustPathNotificator(object value)
		{
		}
	}
}
