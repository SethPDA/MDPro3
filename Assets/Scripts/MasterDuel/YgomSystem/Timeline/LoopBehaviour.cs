using MDPro3;
using System;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using static Willow.TimelineReplacer;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class LoopBehaviour : PlayableBehaviour
	{
        PlayableDirector m_director;
        public TimelineClip loopClip;

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if(m_director == null)
                m_director = playable.GetGraph().GetResolver() as PlayableDirector;
            if(loopClip != null && m_director != null)
                if (m_director.time > loopClip.extrapolatedStart + loopClip.duration)
                    m_director.time = loopClip.extrapolatedStart;
        }
    }
}
