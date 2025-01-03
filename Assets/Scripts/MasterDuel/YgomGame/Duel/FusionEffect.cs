using System;
using System.Collections.Generic;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class FusionEffect : SummonEffectBase
	{
		private static string[] indexLabel;

		private PlayableDirector showCardTimeline;

		private List<PlayableDirector> showCardTimelineUnits;

		private PlayableDirector bgTimeline;

		private Action onFinishCallback;

		private const string SUMMON_FUSION0 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusion00_01/SummonFusion00_01";

		private const string SUMMON_FUSION1 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusion01_01/SummonFusion01_01";

		private const string SUMMON_FUSION2 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusion02_01/SummonFusion02_01";

		private const string SUMMON_FUSION3 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusion03_01/SummonFusion03_01";

		private const string SUMMON_FUSION4 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusion04_01/SummonFusion04_01";

		private const string SUMMON_FUSION5 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusion05_01/SummonFusion05_01";

		private const string SUMMON_FUSION6 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionNum/FusionNum";

		private const string SUMMON_FUSION_NUM = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionNum/FusionNum";

		private const string SUMMON_FUSION_SHOW1 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard01";

		private const string SUMMON_FUSION_SHOW2 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard02";

		private const string SUMMON_FUSION_SHOW3 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard03";

		private const string SUMMON_FUSION_SHOW4 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard04";

		private const string SUMMON_FUSION_SHOW5 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard05";

		private const string SUMMON_FUSION_SHOW6 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard06";

		private const string SUMMON_FUSION_SHOW7 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard07";

		private const string SUMMON_FUSION_SHOW8 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCard08";

		private const string SUMMON_FUSION_SHOW9 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitCard/SummonFusionShowUnitCardNum";

		private const string SUMMON_FUSION_SHOWPARTS01 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitParts/SummonFusionShowUnitParts01";

		private const string SUMMON_FUSION_SHOWPARTS02 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionShowUnitParts/SummonFusionShowUnitParts02";

		private const string SUMMON_FUSION_BG = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionBG/SummonFusionBG";

		private const string SUMMON_FUSION_BG0 = "Duel/Timeline/Duel/Universal/Summon/SummonFusion/SummonFusionBG/SummonFusionBG00_01";

		public override Engine.SpSummonType spSummonType => default(Engine.SpSummonType);

		public static FusionEffect Create()
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

		private bool PlayFusionEffect(int materialNum, Action onFinished)
		{
			return false;
		}

		private void SetupCardShowTimeline(PlayableDirector timeline, int materialNum)
		{
		}

		private void SetupFusionTimeline(PlayableDirector timeline, int materialNum)
		{
		}

		private void PlayMainTimeline(int materialNum, Action onFinished)
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
