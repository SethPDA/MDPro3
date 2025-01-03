using System;
using UnityEngine;

namespace YgomGame.Scenario
{
	[Serializable]
	public class ScenarioSerializableAnimationCurve : IScenarioSerializableValue, ISerializationCallbackReceiver
	{
		private AnimationCurve m_AnimationCurve;

		[SerializeField]
		private string[] k;

		public AnimationCurve animationCurve => null;

		public static AnimationCurve defaultCurve => null;

		public static AnimationCurve Deserialize(object jsonVal)
		{
			return null;
		}

		public ScenarioSerializableAnimationCurve(AnimationCurve animationCurve)
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
