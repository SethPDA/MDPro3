using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.U2D;
using YgomSystem.ResourceSystem;

namespace YgomSystem
{
	public class ResourceManager : MonoBehaviour
	{
		public enum UnloadCheckLevel
		{
			None = 0,
			Low = 1,
			Middle = 2,
			High = 3,
			Force = 4
		}

		public delegate void RequestCompleteHandler(string path);

		public delegate void ErrorHandler(string path);

		public delegate bool? RetryHandler(bool isstart);

		public delegate void ProgressHandler(bool isshow);

		public enum ReqType
		{
			Sound = 0,
			Sound2 = 1,
			Sound3 = 2,
			Sound4 = 3,
			Default = 4,
			Default2 = 5,
			Default3 = 6,
			Default4 = 7,
			Default5 = 8,
			Default6 = 9,
			Default7 = 10,
			Default8 = 11,
			Default9 = 12,
			Default10 = 13,
			Default11 = 14,
			Default12 = 15,
			Default13 = 16,
			Default14 = 17,
			Default15 = 18,
			Default16 = 19,
			Default17 = 20,
			Default18 = 21,
			Default19 = 22,
			Default20 = 23,
			Default21 = 24,
			Default22 = 25,
			Default23 = 26,
			Default24 = 27,
			Default25 = 28,
			Default26 = 29,
			Default27 = 30,
			Default28 = 31,
			Default29 = 32,
			Default30 = 33,
			Default31 = 34,
			Default32 = 35,
			Num = 36
		}

		private const bool IsDisableErrorPath = false;

		private static ResourceManager s_instance;

		private ErrorHandler errorHandler;

		private RetryHandler retryHandler;

		private ProgressHandler progressHandler;

		private const int SoundQueueNum = 4;

		private const int DefaultQueueNum = 32;

		private Dictionary<uint, Resource> resourceDictionary;

		private Dictionary<uint, string>[] requestDictionaries;

		private const bool defaultSoundLoadSlot = true;

		private bool m_useSoundLoadSlot;

		private Coroutine[] updateLoadQueues;

		public int m_UnloadWaitCnt;

		private bool m_UnloadingResources;

		private ResourceLoader resourceLoader;

		private ResTypeChecker resTypeChecker;

		private const string matInfoPostfix = ".matinfo";

		private Dictionary<string, Shader> shaderCache;

		public float HttpTimeOut
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int unloadWaitCnt => 0;

		public static int GetUnloadWaitLimit(UnloadCheckLevel unloadLevel)
		{
			return 0;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public static bool IsAbortReady()
		{
			return false;
		}

		private void AtlasRequested(string spriteAtlasname, Action<SpriteAtlas> callback)
		{
		}

		private void UnloadResource(Resource res)
		{
		}

		private void RemoveRequest(Dictionary<uint, string> requestDictionary, uint key)
		{
		}

		private void RemoveRequest(uint key, ReqType queueId)
		{
		}

		private ReqType AddRequest(uint crc, string path)
		{
			return default(ReqType);
		}

		private IEnumerator UpdateLoadQueue(Dictionary<uint, string> requestDictionary, ReqType queueId)
		{
			return null;
		}

		private void DestroyAllResources()
		{
		}

		private uint findResource(string path)
		{
			return 0u;
		}

		private uint load(string path, Type systemTypeInstance, RequestCompleteHandler completeHandler, bool disableErrorNotify)
		{
			return 0u;
		}

		private void unload(string path, bool force)
		{
		}

		private void unload(uint crc, bool force)
		{
		}

		private void resetData()
		{
		}

		private uint loadImmediate(string path, Type systemTypeInstance, RequestCompleteHandler completeHandler, bool disableErrorNotify)
		{
			return 0u;
		}

		private Resource getResource(string path, out string workPath)
		{
			workPath = null;
			return null;
		}

		private Resource getResource(string path)
		{
			return null;
		}

		private Resource getResource(uint crc)
		{
			return null;
		}

		private bool isDone(string path)
		{
			return false;
		}

		private bool isDone(uint crc)
		{
			return false;
		}

		private bool isError(string path)
		{
			return false;
		}

		private bool isError(uint crc)
		{
			return false;
		}

		private string getWorkPath(string path)
		{
			return null;
		}

		private bool checkAssetType(Type assetType, Type loadType)
		{
			return false;
		}

		private UnityEngine.Object getAsset(string path, Type getSystemType)
		{
			return null;
		}

		private byte[] getBytes(string path)
		{
			return null;
		}

		private List<T> getAssets<T>(string path)
		{
			return null;
		}

		private void clearCache()
		{
		}

		private string GetErrorPath(string path)
		{
			return null;
		}

		private void CallErrorHandler(Resource res, bool disableErrorPath = false)
		{
		}

		public static void EnableSoundLoadSlot()
		{
		}

		public static void DisableSoundLoadSlot()
		{
		}

		public static void DefaultSoundLoadSlot()
		{
		}

		public static bool Load(string path, Type systemTypeInstance = null, bool disableErrorNotify = false)
		{
			return false;
		}

		public static bool Load(string path, out uint crc, Type systemTypeInstance = null, bool disableErrorNotify = false)
		{
			crc = default(uint);
			return false;
		}

		public static bool Load(RequestCompleteHandler handler, string path, Type systemTypeInstance = null)
		{
			return false;
		}

		public static bool Load(RequestCompleteHandler handler, string path, bool disableErrorNotify, Type systemTypeInstance = null)
		{
			return false;
		}

		public static bool LoadImmediate(string path, Type systemTypeInstance = null, bool disableErrorNotify = false)
		{
			return false;
		}

		public static bool LoadImmediate(RequestCompleteHandler handler, string path, Type systemTypeInstance = null)
		{
			return false;
		}

		public static bool LoadImmediate(RequestCompleteHandler handler, string path, bool disableErrorNotify, Type systemTypeInstance = null)
		{
			return false;
		}

		public static bool LoadImmediate(string path, out uint crc, Type systemTypeInstance = null, bool disableErrorNotify = false)
		{
			crc = default(uint);
			return false;
		}

		public static void Unload(string path, bool force = false)
		{
		}

		public static void Unload(uint crc, bool force = false)
		{
		}

		public static bool IsNeedUnloadResources(UnloadCheckLevel unloadLevel)
		{
			return false;
		}

		public static bool CheckUnloadResourcesAsync(UnloadCheckLevel unloadLevel, Action onComplete = null)
		{
			return false;
		}

		public static IEnumerator CheckUnloadResourcesAsyncRoutine(UnloadCheckLevel unloadLevel, Action onComplete = null)
		{
			return null;
		}

		public static void UnloadResourcesAsync(Action onComplete = null)
		{
		}

		public static IEnumerator UnloadResourcesAsyncRoutine(Action onComplete = null)
		{
			return null;
		}

		public static bool IsDone(string path)
		{
			return false;
		}

		public static bool IsDone(uint crc)
		{
			return false;
		}

		public static bool IsError(string path)
		{
			return false;
		}

		public static bool IsError(uint crc)
		{
			return false;
		}

		public static UnityEngine.Object GetAsset(string path, Type getSystemType = null)
		{
			return null;
		}

		public static byte[] GetBytes(string path)
		{
			return null;
		}

		public static List<T> GetAssets<T>(string path)
		{
			return null;
		}

		public static void SetErrorHandler(ErrorHandler handler)
		{
		}

		public static void SetRetryHandler(RetryHandler handler)
		{
		}

		public static void SetProgressHandler(ProgressHandler handler)
		{
		}

		public static void ClearCache()
		{
		}

		public static void ResetRequest()
		{
		}

		public static bool IsAsyncLoading()
		{
			return false;
		}

		public static bool Exists(string filename)
		{
			return false;
		}

		public static byte[] Decompress(byte[] compressData)
		{
			return null;
		}

		private string RemoveAutoConvertPath(string path)
		{
			return null;
		}

		private static byte[] decompressedData(byte[] data)
		{
			return null;
		}

		private Texture2D spriteToTexture2D(Sprite spr)
		{
			return null;
		}

		private Sprite texture2DToSprite(Texture2D tex)
		{
			return null;
		}

		private void finishLoadAsset(uint key, Resource res)
		{
		}

		private IEnumerator RebuildMaterialsAsync(UnityEngine.Object[] assets, string path, Type systemTypeInstance)
		{
			return null;
		}

		private void RebuildMaterialsImmediate(UnityEngine.Object[] assets, string path, Type systemTypeInstance)
		{
		}

		private bool RebuildMaterials_Prepare(UnityEngine.Object[] assets, string path, Type systemTypeInstance, out byte[] matInfoBytes, out Dictionary<string, Material> mtrls, out Dictionary<string, Texture> texs)
		{
			matInfoBytes = null;
			mtrls = null;
			texs = null;
			return false;
		}

		private void RebuildMaterials_UnpackInfo(byte[] matInfoBytes, out Dictionary<string, object> matInfo)
		{
			matInfo = null;
		}

		private void RebuildMaterials_ApplyToMaterial(object matInfoValue, Material mtrl, Dictionary<string, Texture> texs)
		{
		}
	}
}
