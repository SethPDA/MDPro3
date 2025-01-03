using UnityEngine;

namespace YgomSystem.UI
{
	public class TouchParticle : uGuiParticleBase
	{
		private static int TouchEnableCount;

		public float emissionSpan;

		public float moveEmissionSpan;

		public float lifeTime;

		public float startScaleMin;

		public float startScaleMax;

		public float endScale;

		public int startId;

		public int endId;

		public float rscaleMin;

		public float rscaleMax;

		public float totalscale;

		private float emission;

		private float rscale;

		private Color32[] scolors;

		private Color32[] ecolors;

		private int pointingBit;

		private int pointingTrgBit;

		private int pointingNtrgBit;

		private int pointingMoveBit;

		private Vector2[] pointingPos;

		private void CreateTouchParticle(float px, float py, int n, float rs, float ss)
		{
		}

		public static void EffectDisable()
		{
		}

		public static void EffectEnable()
		{
		}

		protected override void Update()
		{
		}
	}
}
