using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	public class LabeledPlayableController : MonoBehaviour
	{
		private PlayableDirector m_Director;

		private Dictionary<string, TimelineClip> m_TrackClips;

		private Dictionary<string, LabelDirectorWrapMode> m_LabelModeTable;

		private string[] m_ClipLabels;

		private DirectorWrapMode m_WrapMode;

		[SerializeField]
		private LabelDirectorWrapMode m_LabelWrapMode;

		[SerializeField]
		private string m_PlayLabel;

		private double m_LastCheckedTime;

		public bool initialized;

		public DirectorWrapMode wrapMode
		{
			get
			{
				return default(DirectorWrapMode);
			}
			set
			{
			}
		}

		public LabelDirectorWrapMode labelWrapMode
		{
			get
			{
				return default(LabelDirectorWrapMode);
			}
			set
			{
			}
		}

		public PlayState state => default(PlayState);

		public string playLabel => null;

		public event Action<string, LabeledPlayableController> stopped
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string, LabeledPlayableController> played
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string, LabeledPlayableController> paused
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}



		public LoopMixerBehaviour loopMixerBehaviour;

		public static LabeledPlayableController Create(PlayableDirector target)
		{
			var controller = target.gameObject.AddComponent<LabeledPlayableController>();
			controller.m_Director = target;
			return controller;
		}

		private void Awake()
		{


			initialized = true;
		}

		public void OnCreatedLabelMixer(LabelMixerBehaviour labelMixer)
		{
		}

		public void Pause()
		{
		}

		public bool SetLabelClipExWrapMode(string label, LabelDirectorWrapMode mode)
		{
			return false;
		}

        public void PlayLabel(string label, TimelineClip loopClip)
        {
			loopMixerBehaviour.PlayClip(label, loopClip);
        }

        public void PlayLabel(string label)
		{
			
		}

		public void PlayLabel(string label, PlayableAsset asset)
		{
		}

		public void PlayLabel(string label, LabelDirectorWrapMode mode)
		{
		}

		public void PlayLabel(string label, PlayableAsset asset, LabelDirectorWrapMode mode)
		{
		}

		public bool PlayNextLabel()
		{
			return false;
		}

		public string SearchNextLabel()
		{
			return null;
		}

		public void Resume()
		{
		}

		public void Stop()
		{
		}

		public bool IsPlayingLabel(string label)
		{
			return false;
		}

		private void Update()
		{
		}

		private void OnStopped(PlayableDirector director)
		{
		}

		private void OnPlayed(PlayableDirector director)
		{
		}

		private void OnPaused(PlayableDirector director)
		{
		}
	}
}
