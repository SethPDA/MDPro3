using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class TimelineObject : MonoBehaviour
	{
		public TimelineManager.EndEventType endEventType;

		public UnityAction onDestroy;

		protected PlayableDirector m_PlayableDirector;

		protected Queue<UnityAction<PlayableDirector>> onStopQueue;

		protected Queue<UnityAction<PlayableDirector>> onPlayQueue;

		protected Queue<UnityAction<PlayableDirector>> onPauseQueue;

		public PlayState state => default(PlayState);

		public double time => 0.0;

		public string path
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string group
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PlayableDirector playableDirector => null;

		public static TimelineObject CreateTimelineObject(GameObject gob, string path, string group)
		{
			return null;
		}

		public void AddOnStopCallBack(UnityAction<PlayableDirector> onstop)
		{
		}

		public void AddOnPlayCallback(UnityAction<PlayableDirector> onplay)
		{
		}

		public void AddOnPauseCallback(UnityAction<PlayableDirector> onpause)
		{
		}

		private void OnPlayableDirectorStop(PlayableDirector pd)
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public void Evaluate()
		{
		}

		public void SkipTo(float target, float start = 0f)
		{
		}

		public LabeledPlayableController GetLabeledPlayableController()
		{
			return null;
		}

		public void Destroy()
		{
		}

		public void Recycle()
		{
		}

		public void OnCached()
		{
		}

		private void OnPlayableDirectorPlay(PlayableDirector pd)
		{
		}

		private void OnPlayableDirectorPause(PlayableDirector pd)
		{
		}

		private void ResetEventQueue(Queue<UnityAction<PlayableDirector>> eventQueue)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
