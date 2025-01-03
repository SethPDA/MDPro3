using System;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Card;

namespace YgomGame.Duel
{
	public class MonsterCutinEffect
	{
		public enum LevelType
		{
			Level = 0,
			Rank = 1,
			Link = 2
		}

		private bool isMyself;

		private int loadCounter;

		private int playCount;

		private bool changeBGM;

		private Sprite textureLinkNum;

		private PlayableDirector monsterTimeline;

		private PlayableDirector bgTimeline;

		private PlayableDirector nameTimeline;

		private PlayableDirector effectTimeline;

		private int cardID;

		private string cardName;

		private Content.Attribute attribute;

		private int level;

		private LevelType levelType;

		private int attack;

		private int defense;

		private bool startCardInvoked;

		private bool ready;

		private Action loadedCallback;

		private const string SUMMON_STRONG_BG_DARK = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgdak_S2";

		private const string SUMMON_STRONG_BG_LIGHT = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bglit_S2";

		private const string SUMMON_STRONG_BG_EARTH = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgeah_S2";

		private const string SUMMON_STRONG_BG_FIRE = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgfie_S2";

		private const string SUMMON_STRONG_BG_WIND = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgwid_S2";

		private const string SUMMON_STRONG_BG_WATER = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgwtr_S2";

		private const string SUMMON_STRONG_BG_GOD = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgdve_S2";

		private const string SUMMON_STRONG_NAME_NEAR = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/01Text/SummonMonster_Name_near";

		private const string SUMMON_STRONG_NAME_FAR = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/01Text/SummonMonster_Name_far";

		private const string SUMMON_STRONG_EFFECT_HIGH = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/02FrontEff/SummonMonster_Thunder_power";

		private const string SUMMON_STRONG_EFFECT_MIDDLE = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/02FrontEff/SummonMonster_Thunder_normal";

		public bool isLoaded => false;

		public bool finished => false;

		public static bool IsStrongSummonTarget(int cardID)
		{
			return false;
		}

		public static MonsterCutinEffect Create()
		{
			return null;
		}

		public void Setup(int cardID, int rareID, bool isMyself, bool changeBGM, Action loadedCallback)
		{
		}

		public void Setup(int cardID, int rareID, bool isMyself, string cardName, Content.Attribute attribute, LevelType levelType, int level, int attack, int defense, bool changeBGM, Action loadedCallback)
		{
		}

		private void OnLoaded(bool result)
		{
		}

		public void Play(Action finishCallback, Action onStartCard, double playOffset = 0.0, bool mute = false)
		{
		}

		private void OnPlayFinished(Action onFinished)
		{
		}

		public void Stop()
		{
		}

		public void Terminate()
		{
		}

		private void StopSE(PlayableDirector timeline)
		{
		}

		public void SetScreenSize(float screenWidth, float screenHeight, Camera targetCamera = null)
		{
		}

		private void SetScreenSize(PlayableDirector target, float screenWidth, float screenHeight, Camera targetCamera = null)
		{
		}
	}
}
