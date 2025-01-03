using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.Audio;

namespace USnd
{
	public class AudioManager : MonoBehaviour
	{
		[Serializable]
		public class AudioCategorySettings
		{
			public string categoryName;

			public int maxPlaybacksNum;

			public float volume;

			public string masterName;

			private AudioMasterSettings attachMaster;

			private AudioParamUpdater volumeUpdater;

			private AudioParamUpdater duckingUpdater;

			public float programVolume;

			public float duckingVolume;

			public void CopySettings(AudioCategorySettings src)
			{
			}

			public void SetAttachMasterInstance(AudioMasterSettings master)
			{
			}

			public float GetVolumeFactor()
			{
				return 0f;
			}

			public float GetCurrentVolume()
			{
				return 0f;
			}

			public void SetVolumeUpdater(float start, float target, float time)
			{
			}

			public void SetDuckingVolumeUpdater(float target, float time, bool isLow)
			{
			}

			public void ClearVolumeUpdater()
			{
			}

			public bool UpdateVolume()
			{
				return false;
			}

			public bool UpdateDuckingVolume()
			{
				return false;
			}
		}

		private class AudioDebugLog
		{
			private static bool isActive;

			public static void Break()
			{
			}

			public static void Log(object message)
			{
			}

			public static void Log(object message, UnityEngine.Object context)
			{
			}

			public static void LogError(object message)
			{
			}

			public static void LogError(object message, UnityEngine.Object context)
			{
			}

			public static void LogWarning(object message)
			{
			}

			public static void LogWarning(object message, UnityEngine.Object context)
			{
			}

			private static bool IsEnable()
			{
				return false;
			}
		}

		private class AudioInstance
		{
			private enum FADE_END_STATE
			{
				UNSET = 0,
				PAUSE = 1,
				STOP = 2
			}

			private bool isAudioDebug;

			private AudioLabelSettings setting;

			private AudioSource source;

			private Transform sourceTransform;

			private float defaultVolume;

			private float defaultPan;

			private int defaultPitch;

			private int currentPitch;

			private float currentVolume;

			private float volumeFactor;

			private float ctrlVolumeFactor;

			private AudioParamUpdater volumeUpdater;

			private AudioParamUpdater panUpdater;

			private AudioParamUpdater pitchUpdater;

			private AudioParamUpdater controlUpdater;

			private int prevPlaySamples;

			private bool onPause;

			private int randomIndex;

			private int instanceId;

			public bool activeSelf;

			private FADE_END_STATE fadeStatus;

			private AudioDefine.INSTANCE_STATUS status;

			private Transform targetTransform;

			private Vector3 defaultPos;

			private bool isUpdateStart;

			public void SetActive(bool active)
			{
			}

			public void SetInstanceID(int id)
			{
			}

			public int GetInstanceID()
			{
				return 0;
			}

			public void Reset(AudioMainPool pool)
			{
			}

			public int GetRandomIndex()
			{
				return 0;
			}

			public void Init(AudioSource playSource, float factor, int index)
			{
			}

			public void Init(AudioSource playSource, AudioLabelSettings labelInfo, float factor, int index)
			{
			}

			public void UpdateVolumeFactor(float factor)
			{
			}

			public void Update()
			{
			}

			public void ResetPlayPosition()
			{
			}

			public void Prepare(float volume, float fadeTime, float pan, int pitch, int playStartSample)
			{
			}

			public void Play(float delay)
			{
			}

			public void Stop(float fadeTime)
			{
			}

			public void ForceStop()
			{
			}

			public void OnPause(float fadeTime)
			{
			}

			public void OffPause(float fadeTime)
			{
			}

			public void SetVolume(float newVolume, float moveTime)
			{
			}

			public float GetCurrentVolume()
			{
				return 0f;
			}

			public float GetCalcVolume()
			{
				return 0f;
			}

			public void SetPitch(int newPitch, float moveTime)
			{
			}

			public void SetPan(float newPan, float moveTime)
			{
			}

			public void SetTrackingObject(GameObject target)
			{
			}

			public void SetTrackingObject(Transform target)
			{
			}

			public void SetPosition(Vector3 position)
			{
			}

			public bool IsPlaying()
			{
				return false;
			}

			public AudioDefine.INSTANCE_STATUS GetStatus()
			{
				return default(AudioDefine.INSTANCE_STATUS);
			}

			public int GetPrevPlaySamples()
			{
				return 0;
			}

			public float GetPlayTime()
			{
				return 0f;
			}

			public int GetPlaySamples()
			{
				return 0;
			}

			public void SetTime(float time)
			{
			}

			public void SetTimeSamples(int samples)
			{
			}

			public bool GetSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
			{
				return false;
			}

			private void setupVolume(float volume, float fadeTime, bool isPlayLastSamples)
			{
			}

			private void setupPitch(int pitch)
			{
			}

			private void setupStereoPan(float pan)
			{
			}

			private float getRandomValue(float min, float max, float unit, bool isconsecutive, float prevValue)
			{
				return 0f;
			}

			private float calcPitchRatio(int cent)
			{
				return 0f;
			}

			public void UpdateAudio3DSettings(Audio3DSettings audio3d)
			{
			}
		}

		private class AudioInstancePool
		{
			private static AudioInstancePool _instance;

			private static int instanceIdNext;

			private List<AudioInstance> pool;

			public static AudioInstancePool instance => null;

			public static void Initialize()
			{
			}

			public void AddEmpty(int num)
			{
			}

			public AudioInstance AddComponent()
			{
				return null;
			}

			public void Deactive(AudioInstance instance)
			{
			}

			public void Clear()
			{
			}
		}

		[Serializable]
		public class AudioLabelSettings
		{
			public enum BEHAVIOR
			{
				STEAL_OLDEST = 0,
				JUST_FAIL = 1,
				QUEUE = 2
			}

			public float volume;

			public BEHAVIOR maxPlaybacksBehavior;

			public int priority;

			public string categoryName;

			public string singleGroup;

			public int maxPlaybacksNum;

			public bool isStealOldest;

			public string unityMixerName;

			public string spatialGroup;

			public float playStartDelay;

			public float playInterval;

			public float pan;

			public int pitchShiftCent;

			public bool isPlayLastSamples;

			public float fadeInTime;

			public float fadeOutTime;

			public float fadeInTimeOldSamples;

			public float fadeOutTimeOnPause;

			public float fadeInTimeOffPause;

			public bool isVolumeRandom;

			public bool inconsecutiveVolume;

			public float volumeRandomMin;

			public float volumeRandomMax;

			public float volumeRandomUnit;

			public bool isPitchRandom;

			public bool inconsecutivePitch;

			public int pitchRandomMin;

			public int pitchRandomMax;

			public int pitchRandomUnit;

			public bool isPanRandom;

			public bool inconsecutivePan;

			public float panRandomMin;

			public float panRandomMax;

			public float panRandomUnit;

			public bool isRandomPlay;

			public bool inconsecutiveSource;

			public string[] randomSource;

			public bool isMovePitch;

			public int pitchStart;

			public int pitchEnd;

			public float pitchMoveTime;

			public bool isMovePan;

			public float panStart;

			public float panEnd;

			public float panMoveTime;

			public string[] duckingCategories;

			public float duckingStartTime;

			public float duckingEndTime;

			public float duckingVolumeFactor;

			public bool autoRestoreDucking;

			public float restoreTime;

			public bool isAndroidNative;

			private int androidSoundId;

			public int loadId;

			public string name;

			private AudioCategorySettings attachCategory;

			public string clipName;

			public bool isLoop;

			public void SetAndroidSoundId(int soundId)
			{
			}

			public int GetAndroidSoundId()
			{
				return 0;
			}

			public void SetLoop(bool loop)
			{
			}

			public bool GetLoop()
			{
				return false;
			}

			public void SetClipName(string name)
			{
			}

			public string GetClipName()
			{
				return null;
			}

			public void SetAttachCategoryInstance(AudioCategorySettings category)
			{
			}

			public AudioCategorySettings GetAttachCategory()
			{
				return null;
			}

			public string GetCategoryName()
			{
				return null;
			}
		}

		private class AudioMainPool : MonoBehaviour
		{
			private List<AudioSource> pool;

			private static AudioMainPool _instance;

			private static GameObject owner;

			private static Transform _cacheTransform;

			private static Transform CacheTransform => null;

			public static AudioMainPool instance => null;

			public static void Initialize(GameObject obj)
			{
			}

			public static void Terminate()
			{
			}

			public void AddEmpty(int num)
			{
			}

			public AudioSource GetClone()
			{
				return null;
			}

			public void Deactive(AudioSource source)
			{
			}

			public void Clear()
			{
			}
		}

		private enum RESULT
		{
			CONTINUE = 0,
			EXECUTE = 1,
			FINISH = 2
		}

		[Serializable]
		private class Wrapper<T>
		{
			public T[] master;

			public T[] category;

			public T[] label;
		}

		[Serializable]
		private class AudioSourceWrapper
		{
			public string spatialName;

			public float spatialBlend;

			public float reverbZoneMix;

			public float dopplerLevel;

			public int spread;

			public AudioRolloffMode rolloffMode;

			public float minDistance;

			public float maxDistance;

			public AnimationCurve customRolloffCurve;

			public AnimationCurve spatialBlendCurve;

			public AnimationCurve reverbZoneMixCurve;

			public AnimationCurve spreadCurve;
		}

		[Serializable]
		public class AudioMasterSettings
		{
			public string masterName;

			public float volume;

			private AudioParamUpdater volumeUpdater;

			public float programVolume;

			public float mute;

			private float manner;

			public void CopySettings(AudioMasterSettings src)
			{
			}

			public float GetCurrentVolume()
			{
				return 0f;
			}

			public float GetVolumeFactor()
			{
				return 0f;
			}

			public void SetVolumeUpdater(float start, float target, float time)
			{
			}

			public void ClearVolumeUpdater()
			{
			}

			public bool UpdateVolume()
			{
				return false;
			}

			public void SetMute(bool onMute)
			{
			}

			public void SetMannerMode(bool onMute)
			{
			}
		}

		private class AudioMixerSettings
		{
			public AudioMixer mixer;

			public void SetAudioMixer(AudioMixer _mixer)
			{
			}

			public AudioMixerGroup[] FindGroup(string groupName)
			{
				return null;
			}

			public void SetSnapshot(string snapName, float time)
			{
			}

			public void SetFloat(string paramName, float value)
			{
			}
		}

		private class AudioParamUpdater
		{
			private float target;

			private float current;

			private float unit;

			private float prevTime;

			private bool move;

			private bool _active;

			public bool active
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public void SetParam(float _start, float _target, float moveTime, bool isLow)
			{
			}

			public void UpdateStart()
			{
			}

			public float Update()
			{
				return 0f;
			}

			public void Clear()
			{
			}
		}

		private class AudioPlayer
		{
			private class PlayData
			{
				public AudioClip clip;

				public AudioLabelSettings info;
			}

			private List<AudioInstance> playInstance;

			private List<PlayData> playSource;

			private AudioLabelSettings playSettings;

			private AudioClip playClip;

			private bool isSetClip;

			private int prevPlayIndex;

			private float prevVolumeRandom;

			private float prevPitchRandom;

			private float prevPanRandom;

			private List<int> prevPlaySamplesList;

			private string playerName;

			private AudioMixerGroup mixer;

			private Audio3DSettings spatialSettings;

			private float nextInterval;

			private float prevPlayTime;

			private bool force2D;

			public string PlayerName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void SetAudioMixerGroup(AudioMixerGroup _mixer)
			{
			}

			public void UpdateRandomSourceInfo(Dictionary<string, AudioPlayer> dict)
			{
			}

			public AudioClip GetPlayClip()
			{
				return null;
			}

			public bool IsSetPlayClip()
			{
				return false;
			}

			public void SetPlayClip(AudioClip clip)
			{
			}

			public float GetClipLength()
			{
				return 0f;
			}

			public int GetClipSamples()
			{
				return 0;
			}

			public bool Init(AudioClip clip, string name, AudioLabelSettings label, Dictionary<string, AudioPlayer> dict)
			{
				return false;
			}

			private void initRandomSettins()
			{
			}

			public void ResetPlayClip()
			{
			}

			public void Reset()
			{
			}

			public void LoadAudioData()
			{
			}

			public void UnloadAudioData()
			{
			}

			private float getRandomValue(float min, float max, float unit, bool isconsecutive, float prevValue)
			{
				return 0f;
			}

			public void ResetPlayPosition()
			{
			}

			public int GetPlayingNum()
			{
				return 0;
			}

			public int GetPlayingTrueNum()
			{
				return 0;
			}

			public int GetMaxPlaybacksNum()
			{
				return 0;
			}

			public bool IsStealOldest()
			{
				return false;
			}

			public string GetCategoryName()
			{
				return null;
			}

			public int GetCategoryMaxPlaybacksNum()
			{
				return 0;
			}

			public int GetPriority()
			{
				return 0;
			}

			public AudioLabelSettings.BEHAVIOR GetMaxPlaybacksBehavior()
			{
				return default(AudioLabelSettings.BEHAVIOR);
			}

			public float GetFadeOutTime()
			{
				return 0f;
			}

			public AudioCategorySettings GetCategorySettings()
			{
				return null;
			}

			public AudioLabelSettings GetLabelSettings()
			{
				return null;
			}

			public AudioDefine.INSTANCE_STATUS GetInstanceStatus(int instanceId)
			{
				return default(AudioDefine.INSTANCE_STATUS);
			}

			public void StopOldInstance()
			{
			}

			private int prepareImpl(float volume, float fadeTime, float pan, int pitch, float delay, bool isStart, bool isForce2D)
			{
				return 0;
			}

			public int Prepare(float volume, float fadeTime, float pan, int pitch, bool isForce2D)
			{
				return 0;
			}

			public int Play(float volume, float fadeTime, float pan, int pitch, float delay, bool isForce2D)
			{
				return 0;
			}

			public void PlayInstance(int instanceId, float delay = 0f)
			{
			}

			public void SetTrackingObject(int instanceId, GameObject target)
			{
			}

			public void SetTrackingObject(int instanceId, Transform target)
			{
			}

			public void Stop(int instanceId, float fadeTime = -1f)
			{
			}

			public void StopAll(float fadeTime = -1f)
			{
			}

			public void OnPause(int instanceId, float fadeTime = -1f)
			{
			}

			public void OnPauseAll(float fadeTime = -1f)
			{
			}

			public void OffPause(int instanceId, float fadeTime = -1f)
			{
			}

			public void OffPauseAll(float fadeTime = -1f)
			{
			}

			public void SetVolume(int instanceId, float newVolume, float moveTime)
			{
			}

			public float GetCurrentVolume(int instanceId)
			{
				return 0f;
			}

			public float GetCalcVolume(int instanceId)
			{
				return 0f;
			}

			public void SetVolumeAll(float newVolume, float moveTime)
			{
			}

			public void SetPitch(int instanceId, int newPitch, float moveTime)
			{
			}

			public void SetPitchAll(int newPitch, float moveTime)
			{
			}

			public void SetPan(int instanceId, float newPan, float moveTime)
			{
			}

			public void SetPanAll(float newPan, float moveTime)
			{
			}

			public void SetPosition(int instanceId, Vector3 position)
			{
			}

			public void SetPositionAll(Vector3 position)
			{
			}

			public void UpdateVolumeFactor(float volumeFactor)
			{
			}

			public float GetPlayTime(int instanceId)
			{
				return 0f;
			}

			public float GetPlayTime()
			{
				return 0f;
			}

			public int GetPlaySamples(int instanceId)
			{
				return 0;
			}

			public void SetTime(int instanceId, float time)
			{
			}

			public void SetTimeSamples(int instanceId, int samples)
			{
			}

			public bool GetSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
			{
				return false;
			}

			public void Update()
			{
			}

			public string GetSpatialGroup()
			{
				return null;
			}

			public bool IsSetSpatialGroup()
			{
				return false;
			}

			public void SetAudio3DSettings(Audio3DSettings setting)
			{
			}

			public bool IsPlayInterval()
			{
				return false;
			}

			private void setInterval()
			{
			}

			public void UpdateAudio3DSettings(Audio3DSettings settings)
			{
			}
		}

		private class AudioXmlLoad
		{
			public static XmlDocument Load(Stream xml)
			{
				return null;
			}

			public static XmlDocument Load(Stream xsd, Stream xml)
			{
				return null;
			}

			private static void DebugParse(XmlDocument xmlDoc)
			{
			}

			private static void OutputXml(XmlDocument xmlDoc)
			{
			}

			private static void ValidationCallback(object sender, ValidationEventArgs args)
			{
			}
		}

		private static AudioManager manager;

		private bool IsOnMute;

		private int AndroidSoundPoolNum;

		private Dictionary<string, AudioPlayer> sourceDict;

		private Dictionary<int, AudioPlayer> playAudioDict;

		private Dictionary<string, List<int>> playCategoryDict;

		private Dictionary<string, AudioCategorySettings> categoryDict;

		private Dictionary<string, AudioMasterSettings> masterDict;

		private Dictionary<string, List<string>> playDuckingTrigger;

		private List<int> playAudioRemoveKey;

		private HashSet<AudioPlayer> playerHashSet;

		private Dictionary<string, AudioClip> audioClipDict;

		private Dictionary<string, Audio3DSettings> audio3DSettings;

		private AudioMixerSettings mixerSettings;

		private Transform _cacheTransform;

		private Thread jsonThread;

		private bool jsonThreadFlag;

		private string jsonStr;

		private AudioMasterSettings[] tmpMaster;

		private AudioCategorySettings[] tmpCategory;

		private AudioLabelSettings[] tmpLabel;

		private AudioDefine.LOAD_XML_STATUS loadXmlStatus;

		private AudioDefine.LOAD_JSON_STATUS loadJsonStatus;

		private Transform CacheTransform => null;

		public static bool IsInitialized()
		{
			return false;
		}

		public static void Initialize(int defaultSampleRate = 0)
		{
		}

		public static void Terminate()
		{
		}

		public static void SetAudioMixer(AudioMixer mixer)
		{
		}

		public static void UnsetAudioMixer()
		{
		}

		public static void SetSnapshot(string snapName, float time)
		{
		}

		public static void SetAudioMixerExposedParam(string paramName, float value)
		{
		}

		public static void SetAudio3DSettingsFromJson(string jsonStr)
		{
		}

		public static void SetAudio3DSettings(Audio3DSettings setting)
		{
		}

		public static void SetAudio3DSettings(Audio3DSettings[] settings)
		{
		}

		public static bool LoadBinaryTable(byte[] tableData, int loadId = 0)
		{
			return false;
		}

		public static bool LoadJson(string tableData, int loadId = 0)
		{
			return false;
		}

		public static void AddAudioClip(AudioClip[] clips)
		{
		}

		public static void AddAudioClip(AudioClip clip)
		{
		}

		public static bool IsExistAudioClip(string clipName)
		{
			return false;
		}

		public static void RemoveAudioClip(string clipName)
		{
		}

		public static void RemoveAudioClipAll()
		{
		}

		public static bool FindLabel(string name)
		{
			return false;
		}

		public static bool FindCategory(string name)
		{
			return false;
		}

		public static bool FindMaster(string name)
		{
			return false;
		}

		public static bool CanRemoveLabel(string labelName)
		{
			return false;
		}

		public static bool UnsetAudioClipToLabel(string labelName)
		{
			return false;
		}

		public static void UnsetAudioClipToLabelLoadId(int loadId)
		{
		}

		public static void UnsetAudioClipToLabelAll()
		{
		}

		public static bool RemoveLabel(string labelName)
		{
			return false;
		}

		public static void RemoveLabelLoadId(int loadId)
		{
		}

		public static void RemoveLabelAll()
		{
		}

		public static void RemoveAll()
		{
		}

		public static void UpdateRandomSourceInfo(string labelName)
		{
		}

		public static void UpdateRandomSourceInfoAll()
		{
		}

		public static void LoadAudioData(string labelName)
		{
		}

		public static void LoadAudioDataLoadId(int loadId)
		{
		}

		public static void UnloadAudioData(string labelName)
		{
		}

		public static void UnloadAudioDataAll()
		{
		}

		public static void UnloadAudioDataLoadId(int loadId)
		{
		}

		public static AudioDefine.LOAD_XML_STATUS GetLoadXmlStatus()
		{
			return default(AudioDefine.LOAD_XML_STATUS);
		}

		public static AudioDefine.LOAD_JSON_STATUS GetLoadJsonStatus()
		{
			return default(AudioDefine.LOAD_JSON_STATUS);
		}

		public static bool LoadMasterXml(Stream xml, Stream xsd = null)
		{
			return false;
		}

		public static bool LoadCategoryXml(Stream xml, Stream xsd = null)
		{
			return false;
		}

		public static bool LoadLabelXml(int loadId, Stream xml, Stream xsd = null)
		{
			return false;
		}

		public static void SetDucking(string categoryName, float targetVolumeFactor, float fadeTime)
		{
		}

		public static void ResetDucking(string categoryName, float fadeTime)
		{
		}

		public static void ResetDuckingAll(float fadeTime)
		{
		}

		public static void ForceResetDucking(string categoryName, float fadeTime)
		{
		}

		public static void ForceResetDuckingAll(float fadeTime)
		{
		}

		public static int Play(string labelName, float delay = -1f)
		{
			return 0;
		}

		public static int PlayOption(string labelName, float volume, float fadeTime, float pan, int pitch, float delay = -1f)
		{
			return 0;
		}

		public static int Prepare(string labelName)
		{
			return 0;
		}

		public static int PrepareOption(string labelName, float volume, float fadeTime, float pan, int pitch)
		{
			return 0;
		}

		public static void PlayInstance(int instanceId, float delay = -1f)
		{
		}

		public static int Play3D(string labelName, GameObject target, float delay = -1f)
		{
			return 0;
		}

		public static int Play3D(string labelName, Vector3 position, float delay = -1f)
		{
			return 0;
		}

		public static int Play3D(string labelName, Transform target, float delay = -1f)
		{
			return 0;
		}

		public static int Play2D(string labelName, float delay = -1f)
		{
			return 0;
		}

		public static void SetTrackingObject(int instanceId, GameObject target)
		{
		}

		public static void SetTrackingObject(int instanceId, Transform target)
		{
		}

		public static void Stop(int instanceId, float fadeTime = -1f)
		{
		}

		public static void StopLabel(string labelName, float fadeTime = -1f)
		{
		}

		public static void StopAll(float fadeTime = -1f)
		{
		}

		public static void OnPause(int instanceId, float fadeTime = -1f)
		{
		}

		public static void OnPauseAll(float fadeTime = -1f)
		{
		}

		public static void OffPause(int instanceId, float fadeTime = -1f)
		{
		}

		public static void OffPauseAll(float fadeTime = -1f)
		{
		}

		public static void SetVolume(int instanceId, float newVolume, float moveTime)
		{
		}

		public static void SetVolume(string labelName, float newVolume, float moveTime)
		{
		}

		public static void SetPitch(int instanceId, int newPitch, float moveTime)
		{
		}

		public static void SetPitch(string labelName, int newPitch, float moveTime)
		{
		}

		public static void SetPan(int instanceId, float newPan, float moveTime)
		{
		}

		public static void SetPan(string labelName, float newPan, float moveTime)
		{
		}

		public static void SetPosition(int instanceId, Vector3 position)
		{
		}

		public static void SetPosition(string labelName, Vector3 position)
		{
		}

		public static void ResetPlayPosition(string labelName)
		{
		}

		public static void ResetPlayPositionAll()
		{
		}

		public static float GetInstanceVolume(int instanceId)
		{
			return 0f;
		}

		public static float GetInstanceCalcVolume(int instanceId)
		{
			return 0f;
		}

		public static void SetMasterVolume(string masterName, float volume, float moveTime = 0f)
		{
		}

		public static float GetMasterVolume(string masterName)
		{
			return 0f;
		}

		public static void SetCategoryVolume(string categoryName, float volume, float moveTime = 0f)
		{
		}

		public static float GetCategoryVolume(string categoryName)
		{
			return 0f;
		}

		public static float GetLabelVolume(string labelName)
		{
			return 0f;
		}

		public static void StopMaster(string masterName, float fadeTime = -1f)
		{
		}

		public static void OnPauseMaster(string masterName, float fadeTime = -1f)
		{
		}

		public static void OffPauseMaster(string masterName, float fadeTime = -1f)
		{
		}

		public static void StopCategory(string categoryName, float fadeTime = -1f)
		{
		}

		public static void OnPauseLabel(string labelName, float fadeTime = -1f)
		{
		}

		public static void OffPauseLabel(string labelName, float fadeTime = -1f)
		{
		}

		public static void OnPauseCategory(string categoryName, float fadeTime = -1f)
		{
		}

		public static void OffPauseCategory(string categoryName, float fadeTime = -1f)
		{
		}

		public static void OffPauseCategory(string categoryName, List<int> instanceList, float fadeTime = -1f)
		{
		}

		public static AudioDefine.INSTANCE_STATUS GetInstanceStatus(int instanceId)
		{
			return default(AudioDefine.INSTANCE_STATUS);
		}

		public static bool IsPlayingLabel(string labelName)
		{
			return false;
		}

		public static int GetLabelNum()
		{
			return 0;
		}

		public static string[] GetLabelNameList()
		{
			return null;
		}

		public static int GetCategoryNum()
		{
			return 0;
		}

		public static string[] GetCategoryNameList()
		{
			return null;
		}

		public static int GetMasterNum()
		{
			return 0;
		}

		public static string[] GetMasterNameList()
		{
			return null;
		}

		public static string GetCategoryNameSettingOfLabel(string labelName)
		{
			return null;
		}

		public static string GetMasterNameSettingOfCategory(string categoryName)
		{
			return null;
		}

		public static float GetPlayTime(int instanceId)
		{
			return 0f;
		}

		public static int GetPlaySamples(int instanceId)
		{
			return 0;
		}

		public static void SetTime(int instanceId, float time)
		{
		}

		public static void SetTimeSamples(int instanceId, int samples)
		{
		}

		public static void SetMute(bool onMute)
		{
		}

		public static bool GetMuteStatus()
		{
			return false;
		}

		public static string[] GetAudioClipNameLoadId(int loadId)
		{
			return null;
		}

		public static string[] GetAudioClipNameAll()
		{
			return null;
		}

		public static string GetAudioClipName(string labelName)
		{
			return null;
		}

		public static string[] GetAudioClipNames(string labelName)
		{
			return null;
		}

		public static string[] GetRandomSourceNames(string labelName)
		{
			return null;
		}

		public static void SetAudioClipToLabelLoadId(int loadId)
		{
		}

		public static void SetAudioClipToLabelAll()
		{
		}

		public static void SetAudioClipToLabel(string labelName)
		{
		}

		public static void SetAndroidNativeToLabel(string labelName, string filePath, string className, string funcName)
		{
		}

		public static void ClearObjectPool()
		{
		}

		public static float GetLabelLength(string labelName)
		{
			return 0f;
		}

		public static int GetLabelSamples(string labelName)
		{
			return 0;
		}

		public static bool GetSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
		{
			return false;
		}

		public static bool IsLoop(string labelName)
		{
			return false;
		}

		public static int GetLabelMaxPlaybacksNum(string labelName)
		{
			return 0;
		}

		public static int GetCategoryMaxPlaybacksNum(string categoryName)
		{
			return 0;
		}

		public static int GetCategoryMaxPlaybacksNumFromLabel(string labelName)
		{
			return 0;
		}

		public static bool IsInterval(string labelName)
		{
			return false;
		}

		public static int GetCurrentPlayNum()
		{
			return 0;
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationPause(bool status)
		{
		}

		private void OnApplicationFocus(bool status)
		{
		}

		private void onHeadsetPlugCallback(string status)
		{
		}

		private void SetMannerMode(bool onMute)
		{
		}

		private void SetMannerMode()
		{
		}

		private void Awake()
		{
		}

		public void setAudioMixer(AudioMixer mixer)
		{
		}

		public void unsetAudioMixer()
		{
		}

		public void setSnapshot(string snapName, float time)
		{
		}

		public void setAudioMixerExposedParam(string paramName, float value)
		{
		}

		public void setAudio3DSettingsFromJson(string jsonStr)
		{
		}

		public void setAudio3DSettings(Audio3DSettings setting)
		{
		}

		public void setAudio3DSettings(Audio3DSettings[] settings)
		{
		}

		private string getChunk(byte[] tableData, int startIndex)
		{
			return null;
		}

		public bool loadBinaryTable(byte[] tableData, int loadId)
		{
			return false;
		}

		private string getString(byte[] tableData, ref int startIndex)
		{
			return null;
		}

		public bool loadJson(string tableData, int loadId)
		{
			return false;
		}

		private IEnumerator loadJsonImpl(string tableData, int loadId)
		{
			return null;
		}

		private void jsonParse()
		{
		}

		private T[] MasterFromJson<T>(string json)
		{
			return null;
		}

		private T[] CategoryFromJson<T>(string json)
		{
			return null;
		}

		private T[] LabelFromJson<T>(string json)
		{
			return null;
		}

		private Audio3DSettings D3SettingsFromJson(string json)
		{
			return null;
		}

		private bool loadLabelJson(int loadId)
		{
			return false;
		}

		private bool loadMasterBinary(byte[] tableData, ref int startIndex)
		{
			return false;
		}

		private bool loadCategoryBinary(byte[] tableData, ref int startIndex)
		{
			return false;
		}

		private bool loadLabelBinary(byte[] tableData, ref int startIndex, int loadId, int tableVer)
		{
			return false;
		}

		public void addCategorySettings(AudioCategorySettings[] list)
		{
		}

		public bool addCategorySettings(AudioCategorySettings category)
		{
			return false;
		}

		public void addMasterSettings(AudioMasterSettings[] list)
		{
		}

		public bool addMasterSettings(AudioMasterSettings master)
		{
			return false;
		}

		public void addAudioClip(AudioClip[] clips)
		{
		}

		public void addAudioClip(AudioClip clip)
		{
		}

		public bool isExistAudioClip(string clipName)
		{
			return false;
		}

		public void removeAudioClip(string clipName)
		{
		}

		public void removeAudioClipAll()
		{
		}

		public bool findLabel(string name)
		{
			return false;
		}

		public bool findCategory(string name)
		{
			return false;
		}

		public bool findMaster(string name)
		{
			return false;
		}

		public bool canRemoveLabel(string labelName)
		{
			return false;
		}

		public bool unsetAudioClipToLabel(string labelName)
		{
			return false;
		}

		public void unsetAudioClipToLabelLoadId(int loadId)
		{
		}

		public void unsetAudioClipToLabelAll()
		{
		}

		public bool removeLabel(string labelName)
		{
			return false;
		}

		public void removeLabelLoadId(int loadId)
		{
		}

		public void removeLabelAll()
		{
		}

		public void removeAll()
		{
		}

		private void deleteAudioSource(AudioPlayer player)
		{
		}

		public void updateRandomSourceInfo(string labelName)
		{
		}

		public void updateRandomSourceInfoAll()
		{
		}

		public void loadAudioData(string labelName)
		{
		}

		public void loadAudioDataLoadId(int loadId)
		{
		}

		public void unloadAudioData(string labelName)
		{
		}

		public void unloadAudioDataAll()
		{
		}

		public void unloadAudioDataLoadId(int loadId)
		{
		}

		private void setUnityAudioMixer(AudioPlayer player)
		{
		}

		public AudioDefine.LOAD_XML_STATUS getLoadXmlStatus()
		{
			return default(AudioDefine.LOAD_XML_STATUS);
		}

		public AudioDefine.LOAD_JSON_STATUS getLoadJsonStatus()
		{
			return default(AudioDefine.LOAD_JSON_STATUS);
		}

		public bool loadMasterXml(Stream xml, Stream xsd = null)
		{
			return false;
		}

		private IEnumerator loadMasterXmlCoroutine(Stream xml, Stream xsd)
		{
			return null;
		}

		private void attachMasterSettings(AudioCategorySettings category)
		{
		}

		public bool loadCategoryXml(Stream xml, Stream xsd = null)
		{
			return false;
		}

		private IEnumerator loadCategoryXmlCoroutine(Stream xml, Stream xsd)
		{
			return null;
		}

		public bool loadLabelXml(int loadId, Stream xml, Stream xsd = null)
		{
			return false;
		}

		private IEnumerator loadLabelXmlCoroutine(int loadId, Stream xml, Stream xsd)
		{
			return null;
		}

		private void orderCategoryInstanceList(List<int> playerList)
		{
		}

		private void addPlayInfo(AudioPlayer player, int instanceId)
		{
		}

		private void stopSameSingleGroup(string singleGroup, string playLabelName)
		{
		}

		private RESULT checkLabelPlaybacksNum(AudioPlayer player)
		{
			return default(RESULT);
		}

		private RESULT checkCategoryPlaybacksNum(AudioPlayer player, ref float time, ref bool queueOn)
		{
			return default(RESULT);
		}

		private void startDucking(AudioPlayer player, int instanceId)
		{
		}

		public void setDucking(string categoryName, float targetVolumeFactor, float fadeTime)
		{
		}

		public void resetDucking(string categoryName, float fadeTime)
		{
		}

		public void resetDuckingAll(float fadeTime)
		{
		}

		public void forceResetDucking(string categoryName, float fadeTime)
		{
		}

		public void forceResetDuckingAll(float fadeTime)
		{
		}

		public int play(string labelName, float delay = -1f)
		{
			return 0;
		}

		private int prepareInstance(string labelName, float volume, float fadeTime, float pan, int pitch, float delay, ref AudioPlayer player, ref float time, ref bool queueOn, bool isForce2D)
		{
			return 0;
		}

		public int playOption(string labelName, float volume, float fadeTime, float pan, int pitch, float delay)
		{
			return 0;
		}

		public int prepare(string labelName, bool isForce2D = false)
		{
			return 0;
		}

		public int prepareOption(string labelName, float volume, float fadeTime, float pan, int pitch, bool isForce2D)
		{
			return 0;
		}

		public void playInstance(int instanceId, float delay = -1f)
		{
		}

		public int play3D(string labelName, GameObject target, float delay = -1f)
		{
			return 0;
		}

		public int play3D(string labelName, Vector3 position, float delay = -1f)
		{
			return 0;
		}

		public int play3D(string labelName, Transform target, float delay = -1f)
		{
			return 0;
		}

		public int play2D(string labelName, float delay = -1f)
		{
			return 0;
		}

		public void setTrackingObject(int instanceId, GameObject target)
		{
		}

		public void setTrackingObject(int instanceId, Transform target)
		{
		}

		public void stop(int instanceId, float fadeTime = -1f)
		{
		}

		public void stopLabel(string labelName, float fadeTime = -1f)
		{
		}

		public void stopAll(float fadeTime = -1f)
		{
		}

		public void onPause(int instanceId, float fadeTime = -1f)
		{
		}

		public void onPauseAll(float fadeTime = -1f)
		{
		}

		public void offPause(int instanceId, float fadeTime = -1f)
		{
		}

		public void offPauseAll(float fadeTime = -1f)
		{
		}

		public void setVolume(int instanceId, float newVolume, float moveTime)
		{
		}

		public void setVolume(string labelName, float newVolume, float moveTime)
		{
		}

		public void setPitch(int instanceId, int newPitch, float moveTime)
		{
		}

		public void setPitch(string labelName, int newPitch, float moveTime)
		{
		}

		public void setPan(int instanceId, float newPan, float moveTime)
		{
		}

		public void setPan(string labelName, float newPan, float moveTime)
		{
		}

		public void setPosition(int instanceId, Vector3 position)
		{
		}

		public void setPosition(string labelName, Vector3 position)
		{
		}

		public void resetPlayPosition(string labelName)
		{
		}

		public void resetPlayPositionAll()
		{
		}

		public float getInstanceVolume(int instanceId)
		{
			return 0f;
		}

		public float getInstanceCalcVolume(int instanceId)
		{
			return 0f;
		}

		public void setMasterVolume(string masterName, float volume, float moveTime = 0f)
		{
		}

		public float getMasterVolume(string masterName)
		{
			return 0f;
		}

		public void setCategoryVolume(string categoryName, float volume, float moveTime = 0f)
		{
		}

		public float getCategoryVolume(string categoryName)
		{
			return 0f;
		}

		public float getLabelVolume(string labelName)
		{
			return 0f;
		}

		public void stopMaster(string masterName, float fadeTime = -1f)
		{
		}

		public void onPauseMaster(string masterName, float fadeTime = -1f)
		{
		}

		public void offPauseMaster(string masterName, float fadeTime = -1f)
		{
		}

		public void stopCategory(string categoryName, float fadeTime = -1f)
		{
		}

		public void onPauseLabel(string labelName, float fadeTime = -1f)
		{
		}

		public void offPauseLabel(string labelName, float fadeTime = -1f)
		{
		}

		public void onPauseCategory(string categoryName, float fadeTime = -1f)
		{
		}

		public void offPauseCategory(string categoryName, float fadeTime = -1f)
		{
		}

		public void offPauseCategory(string categoryName, List<int> instanceList, float fadeTime = -1f)
		{
		}

		public AudioDefine.INSTANCE_STATUS getInstanceStatus(int instanceId)
		{
			return default(AudioDefine.INSTANCE_STATUS);
		}

		public bool isPlayingLabel(string labelName)
		{
			return false;
		}

		public int getLabelNum()
		{
			return 0;
		}

		public string[] getLabelNameList()
		{
			return null;
		}

		public int getCategoryNum()
		{
			return 0;
		}

		public string[] getCategoryNameList()
		{
			return null;
		}

		public int getMasterNum()
		{
			return 0;
		}

		public string[] getMasterNameList()
		{
			return null;
		}

		public int getAudio3DSettingsNum()
		{
			return 0;
		}

		public string[] getAudio3DSettingsNameList()
		{
			return null;
		}

		public void updateUnityMixerName(string labelName, string newMixerName)
		{
		}

		public void updateSpatialGroupName(string labelName, string newGroupName)
		{
		}

		public string getCategoryNameSettingOfLabel(string labelName)
		{
			return null;
		}

		public string getMasterNameSettingOfCategory(string categoryName)
		{
			return null;
		}

		public float getPlayTime(int instanceId)
		{
			return 0f;
		}

		public int getPlaySamples(int instanceId)
		{
			return 0;
		}

		public void setTime(int instanceId, float time)
		{
		}

		public void setTimeSamples(int instanceId, int samples)
		{
		}

		public void setMute(bool onMute)
		{
		}

		public bool getMuteStatus()
		{
			return false;
		}

		public string[] getAudioClipNameLoadId(int loadId)
		{
			return null;
		}

		public string[] getAudioClipNameAll()
		{
			return null;
		}

		public string getAudioClipName(string labelName)
		{
			return null;
		}

		public string[] getAudioClipNames(string labelName)
		{
			return null;
		}

		public string[] getRandomSourceNames(string labelName)
		{
			return null;
		}

		public void setAudioClipToLabelLoadId(int loadId)
		{
		}

		public void setAudioClipToLabelAll()
		{
		}

		public void setAudioClipToLabel(string labelName)
		{
		}

		public void setAndroidNativeToLabel(string labelName, string filePath, string className, string funcName)
		{
		}

		public void clearObjectPool()
		{
		}

		public float getLabelLength(string labelName)
		{
			return 0f;
		}

		public int getLabelSamples(string labelName)
		{
			return 0;
		}

		public bool getSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
		{
			return false;
		}

		public bool isLoop(string labelName)
		{
			return false;
		}

		public int getLabelMaxPlaybacksNum(string labelName)
		{
			return 0;
		}

		public int getCategoryMaxPlaybacksNum(string categoryName)
		{
			return 0;
		}

		public int getCategoryMaxPlaybacksNumFromLabel(string labelName)
		{
			return 0;
		}

		public bool isInterval(string labelName)
		{
			return false;
		}

		public int getCurrentPlayNum()
		{
			return 0;
		}

		private void Update()
		{
		}

		private void resetDuckingBeforeUpdate(AudioPlayer player)
		{
		}

		public static AudioLabelSettings GetLabelInfo_Extention(string name)
		{
			return null;
		}
	}
}
