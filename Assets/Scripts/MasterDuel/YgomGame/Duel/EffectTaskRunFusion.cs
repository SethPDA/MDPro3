using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskRunFusion : EffectTask
	{
		private enum Step
		{
			Loading = 0,
			WaitCardEffect = 1,
			Start = 2,
			Wait = 3,
			Finish = 4
		}

		private bool finished;

		private Step step;

		private int[] materialUniqueID;

		private int[] materialCardID;

		private int dstCardId;

		private int dstUniqueID;

		private int matNum;

		private Engine.SpSummonType summonType;

		private int player;

		private bool isMyself;

		private bool loadingSummonCard;

		private int leftCardID;

		private int leftUniqueID;

		private int leftScale;

		private int rightCardID;

		private int rightUniqueID;

		private int rightScale;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskRunFusion(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		private void StartLoad()
		{
		}

		private void Loading()
		{
		}

		private bool WaitCardEffect()
		{
			return false;
		}

		private void StartSummonEffect()
		{
		}

		private void LoadLinkSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadWaitLinkSummon()
		{
		}

		private void StartLinkSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadWaitFusionSummon()
		{
		}

		private void StartFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadSPFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadWaitSPFusionSummon()
		{
		}

		private void StartSPFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadRitualSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadWaitRitualSummon()
		{
		}

		private void StartRitualSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadSyncSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadWaitSyncSummon()
		{
		}

		private void StartSyncSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadXyzSummon(int dstCardId, int matNum, int[] materialUniqueID)
		{
		}

		private void LoadWaitXyzSummon()
		{
		}

		private void StartXyzSummon(int dstCardId, int matNum, int[] matList)
		{
		}

		private void LoadPendSummon(int dstCardId, int matNum, int[] matList)
		{
		}

		private void LoadWaitPendSummon()
		{
		}

		private void StartPendSummon(int dstCardId, int matNum, int[] matList)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void FinishStep()
		{
		}
	}
}
