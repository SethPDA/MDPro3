using System;
using System.Collections.Generic;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class SynchroEffect : SummonEffectBase
	{
		private List<PlayableDirector> showTimeline;

		private int tunerNum;

		private Dictionary<int, int> tunerLevelList;

		private Dictionary<int, int> notTunerLevelList;

		private const string SUMMON_SYNCHRO_SHOW2 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard02";

		private const string SUMMON_SYNCHRO_SHOW3 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard03";

		private const string SUMMON_SYNCHRO_SHOW4 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard04";

		private const string SUMMON_SYNCHRO_SHOW5 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard05";

		private const string SUMMON_SYNCHRO_SHOW6 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard06";

		private const string SUMMON_SYNCHRO_SHOWPARTS1 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitParts/SummonSynchroShowUnitParts01";

		private const string SUMMON_SYNCHRO_SHOWPARTS2 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitParts/SummonSynchroShowUnitParts02";

		private const string SUMMON_SYNCHRO = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroMain01/SummonSynchro01";

		private const string SUMMON_SYNCHRO_NOMATERIAL = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroMain02/SummonSynchro02";

		public override Engine.SpSummonType spSummonType => default(Engine.SpSummonType);

		private int tunerLevel => 0;

		private int notTunerLevel => 0;

		public static SynchroEffect Create()
		{
			return null;
		}

		public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
		{
		}

		protected override bool PlayEffect(Action onFinished)
		{
			return false;
		}

		public void AddTunerNum()
		{
		}

		public void AddTunerLevel(int uniqueID, int level)
		{
		}

		public void AddNotTunerLevel(int uniqueID, int level)
		{
		}

		public void ResetTuningInfo()
		{
		}

		private bool PlaySynchroEffect(int materialNum, int tunerNum, int notTunerLevel, int tunerLevel, Action onFinished)
		{
			return false;
		}

		private void SetupCardShowTimeline(PlayableDirector timeline, int materialNum, int tunerNum)
		{
		}

		private void SetupSynchroTimeline(PlayableDirector timeline, int notTunerLevel, int tunerLevel)
		{
		}

		private void SetupDestCardTexture(ElementObjectManager manager)
		{
		}

		public override bool Skip()
		{
			return false;
		}

		protected override void Finish()
		{
		}
	}
}
