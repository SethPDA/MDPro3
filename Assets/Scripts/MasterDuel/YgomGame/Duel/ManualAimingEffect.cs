using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class ManualAimingEffect : DuelEffectHandle
	{
		private enum Step
		{
			MAIN = 0,
			FADEOUT = 1,
			END = 2
		}

		private Step step;

		private Vector3 aim;

		private bool playing;

		private float lengthRate;

		private float alpha;

		private Color color;

		private BattleAimingEffect.Shading shading;

		public override bool isPlaying => false;

		public Vector3 from
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Vector3 to
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected override void OnInitialize()
		{
		}

		protected override void OnTerminate()
		{
		}

		protected override void OnPlay()
		{
		}

		protected override void OnStop()
		{
		}

		protected override void OnUpdate()
		{
		}

		public void SetPosition(Vector3 from, Vector3 to)
		{
		}

		public void SetColor(Color col)
		{
		}

		public void SetShading(BattleAimingEffect.Shading shading)
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}
	}
}
