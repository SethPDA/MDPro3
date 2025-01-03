using System;
using UnityEngine;

namespace USnd
{
	//[CreateAssetMenu]
	public class Audio3DSettings : ScriptableObject, ICloneable
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

		public object Clone()
		{
			return null;
		}

		public void Copy(Audio3DSettings newParam)
		{
		}
	}
}
