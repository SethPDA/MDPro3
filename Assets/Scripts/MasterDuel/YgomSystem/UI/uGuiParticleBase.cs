using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class uGuiParticleBase : MaskableGraphic
	{
		private struct param
		{
			public Vector2 vel;

			public float rot;

			public float scale;

			public Color col;

			public int sid;
		}

		private class prim
		{
			public uGuiParticleBase pbase;

			public float delay;

			public float time;

			public float lifetime;

			public param src;

			public param dst;

			private float pt;

			private Vector2 ps;

			public Color color => default(Color);

			public Vector2 pos => default(Vector2);

			public float scale => 0f;

			public float rot => 0f;

			public int sid => 0;

			public prim(uGuiParticleBase pbase_, float lifetime_, float delaytime_, Vector2 pos_, Vector2 vel, float rot, float scale, Color color, int sid, Vector2 dstVel, float dstRot, float dstScale, Color dstColor, int dstSid)
			{
			}

			public bool update(float tm)
			{
				return false;
			}

			public static Vector2[] CreateUvs(int divide, Texture tex)
			{
				return null;
			}

			public bool AddVert(VertexHelper vh, Vector2[] uvs)
			{
				return false;
			}
		}

		public Texture texture;

		public int divide;

		public AnimationCurve colorCurve;

		public AnimationCurve velocityCurve;

		public AnimationCurve scaleCurve;

		private List<prim> particles;

		private Vector2[] uvs;

		public override Texture mainTexture => null;

		protected virtual void Update()
		{
		}

		public void AddParticle(float lifetime, float delaytime, Vector2 pos, Vector2 velocity, float rot, float scale, Color color, int sid, Vector2 endVelocity, float endRot, float endScale, Color endColor, int endSid)
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
