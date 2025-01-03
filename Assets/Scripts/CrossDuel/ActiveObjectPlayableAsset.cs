using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Willow
{
	[Serializable]
	public class ActiveObjectPlayableAsset : PlayableAsset, ITimelineClipAsset
	{
		public string m_name;

		public ExposedReference<GameObject> m_parentObject;

		public GameObject m_prefab;

		public bool m_isFullLifespan;

		public bool m_onCreateRelayObject;

		public ExposedReference<CustomTimelineObject> m_relayObject;

		public bool m_isSyncPosition;

		public bool m_isSyncRotation;

		public bool m_isSyncScale;

		public bool m_isLookAtCamera;

		public bool m_isIgnoreInitRotation;

		public bool m_isIgnoreInitScale;

		public bool m_isRelayChild;

		public ClipCaps clipCaps => default(ClipCaps);

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
            var playable = ScriptPlayable<ActiveObjectPlayableBehaviour>.Create(graph);
			var behaviour = playable.GetBehaviour();
			behaviour.m_parentObject = m_parentObject.Resolve(graph.GetResolver());
            behaviour.m_relayObject = m_relayObject.Resolve(graph.GetResolver());
            behaviour.m_prefab = m_prefab;
			behaviour.m_isFullLifespan = m_isFullLifespan;
			behaviour.m_isLookAtCamera = m_isLookAtCamera;


            behaviour.controller = go.transform.parent.GetComponent<CustomTimelineController>();
			behaviour.m_name = m_name;
			return playable;
		}
	}
}
