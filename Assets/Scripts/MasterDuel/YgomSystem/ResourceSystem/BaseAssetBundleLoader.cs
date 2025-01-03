using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.ResourceSystem
{
	public abstract class BaseAssetBundleLoader : BaseLoader, ISpriteTagLoader
	{
		protected internal class AssetBundleCache
		{
			private List<WeakReference> weakRefs;

			private AssetBundle bundle;

			private bool unloadAll;

			public bool IsAlive => false;

			public UnityEngine.Object[] Target => null;

			public AssetBundleCache(AssetBundle asset, bool unload = false)
			{
			}

			public bool IsContains(string name)
			{
				return false;
			}

			public bool IsSpriteAtlas()
			{
				return false;
			}

			public void Release()
			{
			}

			public void Load()
			{
			}

			public IEnumerator LoadAsync()
			{
				return null;
			}

			private void SetObjects(UnityEngine.Object[] objects)
			{
			}
		}

		protected internal class AssetCache : AbstractReferenceCache<AssetBundleCache>
		{
			protected override AssetBundleCache LoadRequest(string key, params object[] param)
			{
				return null;
			}

			protected override void RemoveCacheAction(AssetBundleCache value)
			{
			}

			public override void Clear()
			{
			}

			public List<string> ExistsKeys()
			{
				return null;
			}

			public AssetCache()
			{
				//((AbstractReferenceCache<>)(object)this)._002Ector();
			}
		}

		private const int kAssetCacheFrame = 10;

		private Dictionary<string, HashSet<string>> m_loadedDic;

		private Dictionary<string, int> m_unloadReqDic;

		private Dictionary<string, string> m_loadingDic;

		private Dictionary<string, string> m_spriteTagDic;

		private List<string> m_unloadKeys;

		protected virtual AssetCache assetCache
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected abstract List<string> GetWithDependenciesList(Resource res);

		protected abstract IEnumerator yLoadRequestCache(string loadPath, Action<AssetBundle> callback);

		protected abstract void RemoveRequestCache(string loadPath);

		protected abstract void ClearRequestCache();

		protected static bool GetUnloadAllOption(string path)
		{
			return false;
		}

		private void AddLoadedList(Resource res, List<string> addList)
		{
		}

		private void AddLoadedList(Resource res, string addPath)
		{
		}

		public override void Load(Resource res, uint crc)
		{
		}

		public override IEnumerator LoadAsync(Resource res, uint key)
		{
			return null;
		}

		private void LoadCancel(Resource res)
		{
		}

		private void UnloadAction(Resource res)
		{
		}

		private void UnloadRequest(Resource res)
		{
		}

		public override void LateUpdate()
		{
		}

		public override void ClearCache()
		{
		}

		public void AddSpriteTagDic(string loadPath)
		{
		}

		public string GetPathFromSpriteAtlasTag(string tag)
		{
			return null;
		}
	}
}
