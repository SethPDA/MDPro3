using System;
using UnityEngine;

namespace YgomGame.Scenario
{
	[Serializable]
	public class SerializableKeyFrame : ISerializationCallbackReceiver
	{
		private Keyframe m_KeyFrame;

		[SerializeField]
		private float[] p;

		[SerializeField]
		private WeightedMode m;

		public Keyframe keyFrame => default(Keyframe);

		public SerializableKeyFrame(Keyframe keyFrame)
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
