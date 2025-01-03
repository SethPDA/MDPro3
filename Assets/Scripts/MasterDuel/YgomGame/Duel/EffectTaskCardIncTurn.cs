using UnityEngine;

namespace YgomGame.Duel
{
	public class EffectTaskCardIncTurn : EffectTask
	{
		private bool finished;

		private GameObject obj;

		private DuelTurnCount turnCount;

		private const string prefabPath = "Prefabs/Duel/DuelTurnCount";

		private float waitTime;

		public static EffectTask Create(RunEffectWorker workerHUD, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskCardIncTurn(RunEffectWorker workerHUD, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		public override void OnDestroy()
		{
		}

		private void DestroyTurnCount()
		{
		}
	}
}
