using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Willow
{
	public class TimelineController : MonoBehaviour
	{
		public class ClipData
		{
			public string label
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

			public double startTime
			{
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public double endTime
			{
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[SerializeField]
		private PlayableDirector m_currentDirector;

		private List<ClipData> m_listLoop;

		private List<ClipData> m_listLabel;

		private bool m_isPlay;

		private bool m_isReady;

		private bool m_hasLoop;

		private int m_loopIndex;

		private double m_endTime;

		private double m_speedRate;

		protected bool m_isForceFinish;

		protected double m_oneFrame;

		private Action m_endCallHandler;

		private Action m_onExitLoopHandler;

		private IEnumerable<PlayableBinding> m_bindingAll;

		private IEnumerable<TrackAsset> m_trackAll;

		private IEnumerable<TrackAsset> m_trackRoot;

		private bool m_isJustBeforeEnd;

		public const string kAutoCinemachineTrackName = "Cinemachine Track";

		protected IEnumerable<PlayableBinding> bindingAll => null;

		public IEnumerable<TrackAsset> trackAll => null;

		public IEnumerable<TrackAsset> tracks => null;

		public IEnumerable<TrackAsset> trackRoot => null;

		public PlayableDirector currentDirector 
		{ 
			get { return m_currentDirector; }
			set { m_currentDirector = value; }
		}

		public bool isPlay
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool isPause
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

		public bool isLoop => false;

		public bool isLoopIgnore
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public double currentTime
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int currentFrame => 0;

		public double oneFrame => 0.0;

		public double startTime
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<bool> onChangeLoopState
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

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void Clear()
		{
		}

		protected virtual void Finish(bool isEndCall = true)
		{
		}

		protected virtual void CheckDirector()
		{
		}

		protected virtual void Proceed(float deltaTime)
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ChangeDirector(PlayableDirector director)
		{
		}

		public virtual void Play(Action endCall, float speed = 1f, double startTimePosition = 0.0)
		{
		}

		public virtual void Play(Action endCall, float speed, string startLabel)
		{
		}

		public virtual void ChangeSpeed(float speed)
		{
		}

		public virtual void Stop(bool isEndTime = true, bool isEndCall = true)
		{
		}

		public virtual void Pause(bool isPause, bool isForced = false)
		{
		}

		public void SkipLoop(bool isForce = true, Action onExitLoop = null, double timeAdjust = 0.0)
		{
		}

		public void Skip(double goalTime = 0.0)
		{
		}

		public ClipData GetLoopInfo(int index = 0)
		{
			return null;
		}

		public double GetLabelTime(string labelName)
		{
			return 0.0;
		}

		public bool GoToLabel(string labelName, bool isForced = false)
		{
			return false;
		}

		public string[] GetLabelNameList()
		{
			return null;
		}

		public void SetBind<T>(string trackName, T obj) where T : UnityEngine.Object
		{
		}

		public T GetClip<T>(string trackName, string clipName) where T : PlayableAsset
		{
			return null;
		}

		public List<T> GetClips<T>(string trackName, string clipName) where T : PlayableAsset
		{
			return null;
		}

		public void SetBindCMCamera(CinemachineBrain brain, string trackName = "Cinemachine Track")
		{
		}

		public void SetMuteTrack(string trackName, bool isMute, bool isMuteBindObject = false)
		{
		}

		private void SetMuteTrackBindObject(TrackAsset track, bool isMute)
		{
		}
	}
}
