using UnityEngine;

namespace YgomGame.Duel
{
	public class BattleAimingEffect : DuelEffectHandle
	{
		public enum Shading
		{
			SURFACE = 0,
			LINE = 1
		}

		private const int TETRAGON_COUNT = 16;

		private const int NOSE_VERTEX_COUNT = 3;

		private const int ARROW_POLYGON_COUNT = 3;

		private const int Z_POINT_COUNT = 17;

		private const int VERTEX_COUNT = 37;

		private float STREACH_SPEED;

		private float FADE_SPEED;

		private Vector3 from;

		private Vector3 to;

		private Vector3 aim;

		private float width;

		private float alpha;

		private Color color;

		private MeshRenderer mr;

		private float lengthRate;

		private bool reqStop;

		private bool isEnd;

		private bool isSetPosition;

		public override bool isPlaying => false;

		public void SetPositions(Vector3 srcPos, Vector3 dstPos)
		{
		}

		public void SetColor(Color col)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		protected override void OnInitialize()
		{
		}

		protected override void OnTerminate()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnStop()
		{
		}

		public static void MakeAimingArrowMesh(Shading shading, Mesh mesh, Vector3 from, Vector3 to, Vector3 aim, float lengthRate, float width, float wingWidthRate, Color color, Vector3 camPos, bool isTopHorizontally)
		{
		}
	}
}
