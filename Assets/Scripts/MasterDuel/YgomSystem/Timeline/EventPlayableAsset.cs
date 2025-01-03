using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class EventPlayableAsset : PlayableAsset
	{
		[Serializable]
		public class EventInfo
		{
			public string label;

			public double time;
		}

		public string label;

		public List<EventInfo> eventList;

		public override double duration => 0.0;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
            var playable = ScriptPlayable<EventPlayableBehaviour>.Create(graph);
            var behaviour = playable.GetBehaviour();
			behaviour.label = label;
			behaviour.eventList = new List<EventPlayableBehaviour.EventInfo>();
			foreach(var info in eventList)
			{
				behaviour.eventList.Add(new EventPlayableBehaviour.EventInfo() 
				{ 
					label = info.label,
					time = info.time,
					isDone = false
				});
            }
			return playable;
        }
    }
}
