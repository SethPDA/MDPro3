using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem
{
	public class Sound : MonoBehaviour
	{
		public enum Master
		{
			BGM = 0,
			SE = 1,
			VOICE = 2
		}

		private static Sound s_instance;

		private string[] ResourcesXmlList;

		private string[] AssetBundleXmlList;

		private string CurrentBGM;

		private static List<string> BGMList;

		private List<string> AB_SE_DUEL;

		public static Sound Instance => null;

		public bool IsReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsLoadingLabelXml
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static void SoundDebugPrint(string str)
		{
		}

		private static void SoundDebugPrintWarning(string str)
		{
		}

		private string getMasterName(Master master)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator LoadSoundSettingCoroutine()
		{
			return null;
		}

		public void LoadSoundResourcesXml()
		{
		}

		public void LoadSoundAssetBundleXml()
		{
		}

		public void LoadSysSoundDataAsync(Action finishedCallback)
		{
		}

		public void LoadDuelSoundXml(string[] NameList, bool checkExist = true)
		{
		}

		public void LoadDuelSoundDataAsync(Action finishedCallback)
		{
		}

		public void LoadMateSoundDataAsync(Action finishedCallback)
		{
		}

		public void LoadFieldSoundDataAsync(Action finishedCallback)
		{
		}

		public void UnloadDuelSoundData()
		{
		}

		public void UnloadAllSoundData()
		{
		}

		private IEnumerator LoadSoundXml(string[] NameList, bool checkExist = true)
		{
			return null;
		}

		private void LoadCategorySoundDataAsync(string categoryName, Action finishedCallback, bool updateRndSrc = true)
		{
		}

		public void UnloadCategorySoundData(string categoryName, bool removeLabel = false)
		{
		}

		public void LoadSoundClip(string Label)
		{
		}

		public IEnumerator LoadSoundClipAsyncCoroutine(List<string> targetList, Action finishedCallback)
		{
			return null;
		}

		private bool LoadSoundClipAsync(string Label, Action finishedCallback)
		{
			return false;
		}

		private bool UnloadSoundClip(string Label)
		{
			return false;
		}

		private bool IsCategoryMember(string label, string category)
		{
			return false;
		}

		public bool IsLoadingXml()
		{
			return false;
		}

		private bool IsAudioManagerLoadingLabel()
		{
			return false;
		}

		public void ClearObject()
		{
		}

		public int Play(string label)
		{
			return 0;
		}

		private int PlayImpl(string label, float delay = -1f)
		{
			return 0;
		}

		public int Play3D(string label, Vector3 position)
		{
			return 0;
		}

		public int Play3D(string label, GameObject traceTarget)
		{
			return 0;
		}

		public int PlayOption(string label, float volume = -1f, float fadeTime = -1f, float pan = -1f, int pitch = -1, float delay = -1f)
		{
			return 0;
		}

		public void SetPan(int instanceID, float newPan, float moveTime = 0f)
		{
		}

		public void Stop(int instanceId, float fade = -1f)
		{
		}

		public void Stop(string label, float fade = -1f)
		{
		}

		public void StopLoopInCategory(string categoryName, float fade = -1f)
		{
		}

		public void StopAll()
		{
		}

		public void SetMasterVolume(Master masterName, float volume, float moveTime = -1f)
		{
		}

		public float GetMasterVolume(Master masterName)
		{
			return 0f;
		}

		public int PlayBGM(string label, float delay = -1f)
		{
			return 0;
		}

		public static void UnloadBGM()
		{
		}

		public bool IsPlayingBGM()
		{
			return false;
		}

		public bool IsPlayingBGM(string label)
		{
			return false;
		}

		public bool IsLoopSe(string label)
		{
			return false;
		}

		public bool IsSe(string label)
		{
			return false;
		}

		public bool IsPlayingLoopSe(string label)
		{
			return false;
		}

		public bool IsPlayingSe(string label)
		{
			return false;
		}

		public bool IsPlayingLabel(string label)
		{
			return false;
		}

		public string GetPlayingBgmLabel()
		{
			return null;
		}

		public void ForceStopBGMAll()
		{
		}

		public void StopBGM(float fade = -1f)
		{
		}
	}
}
