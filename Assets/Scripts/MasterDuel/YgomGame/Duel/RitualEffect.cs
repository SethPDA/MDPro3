using System;
using System.Collections.Generic;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class RitualEffect : SummonEffectBase
	{
		private List<PlayableDirector> showTimeline;

		private const string SUMMON_RITUAL_SHOW1 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard01";

		private const string SUMMON_RITUAL_SHOW2 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard02";

		private const string SUMMON_RITUAL_SHOW3 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard03";

		private const string SUMMON_RITUAL_SHOW4 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard04";

		private const string SUMMON_RITUAL_SHOW5 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard05";

		private const string SUMMON_RITUAL_SHOW6 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard06";

		private const string SUMMON_RITUAL_SHOWPARTS01 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitParts/SummonRitualShowUnitParts01";

		private const string SUMMON_RITUAL_SHOWPARTS02 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitParts/SummonRitualShowUnitParts02";

		private const string SUMMON_RITUAL = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitual01";

		private const string SUMMON_RITUAL_NOMATERIAL = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitual02";

		public override Engine.SpSummonType spSummonType => default(Engine.SpSummonType);

		public static RitualEffect Create()
		{
			return null;
		}

		protected override bool PlayEffect(Action onFinished)
		{
			return false;
		}

		public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
		{
		}

		private bool PlayRitualEffect(int materialNum, Action onFinished)
		{
			return false;
		}

		private void PlayMainTimeline(Action onFinished)
		{
		}

		private void SetupCardShowTimeline(PlayableDirector timeline, int materialNum)
		{
		}

		private void SetupRitualTimeline(PlayableDirector timeline, int materialNum)
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
