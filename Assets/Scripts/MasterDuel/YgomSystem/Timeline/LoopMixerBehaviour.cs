using AssetStudio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class LoopMixerBehaviour : PlayableBehaviour
	{
		private readonly double k_SecMargine;

		private PlayableDirector m_Director;

		[NonSerialized]
		public List<TimelineClip> loopClips;

		private bool m_Initialized;


		public LabelTrack track;

		TimelineClip currentClip;

		public override void OnPlayableCreate(Playable playable)
		{
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		public override void PrepareData(Playable playable, FrameData info)
		{
		}

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
			if(!m_Initialized)
			{
				if(!inied)
					Ini(playable);

                if (m_Director.GetComponent<LabeledPlayableController>() != null)
				{
                    m_Director.GetComponent<LabeledPlayableController>().loopMixerBehaviour = this;
                    m_Initialized = true;
                }
            }
        }

		bool inied;
		void Ini(Playable playable)
		{
            var resolver = playable.GetGraph().GetResolver();
            if (resolver is PlayableDirector)
                m_Director = (PlayableDirector)resolver;
			if(loopClips != null && loopClips.Count > 0)
			{
                currentClip = loopClips[0];
				foreach(var clip in loopClips)
				{
					var loopClip = clip.asset as LoopClip;
					if( loopClip != null)
					{
						loopClip.loopClip = clip;
						loopClip.PassClip();
					}
				}
            }
            inied = true;



        }

        public override void PrepareFrame(Playable playable, FrameData info)
		{
			if(currentClip != null)
                if (m_Director.time > currentClip.extrapolatedStart + currentClip.duration - 0.02f)
                    m_Director.time = currentClip.extrapolatedStart;
        }

		public void PlayClip(string label, TimelineClip loopClip)
		{
            var clips = track.GetClips();
			foreach(var clip in clips)
			{
                if (clip.asset is LabelClip)
                {
					if(clip.displayName == label)
					{
                        m_Director.time = clip.extrapolatedStart;
                        currentClip = loopClip;
                        break;
                    }
                }
            }
        }

        private void CheckLoopClip()
		{
		}

		private void SetNextClipDuration()
		{
		}

		private TimelineClip SearchCurrentClip()
		{
			return null;
		}

		private TimelineClip SearchNextClip()
		{
			return null;
		}
	}
}
