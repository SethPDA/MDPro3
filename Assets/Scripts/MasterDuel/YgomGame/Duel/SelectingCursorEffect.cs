using UnityEngine;

namespace YgomGame.Duel
{
	public class SelectingCursorEffect : DuelEffectHandle
	{
		private Vector3 from;

		private Vector3 to;

		private Color color;

		private MeshRenderer mr;

		private float rate;

		private float timer;

		private bool isEnd;

		private bool isSetPosition;

		public override bool isPlaying => false;

		public void SetPosition(Vector3 srcPos, Vector3 dstPos)
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
	}
}
