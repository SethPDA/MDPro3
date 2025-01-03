using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class DuelTutorialData : ScriptableObject
	{
		[Serializable]
		public class MessageInfo
		{
			public int startTurn;

			public View startView;

			public float startDelay;

			public List<string> centerMessage;

			public bool useTopMessage;

			public string topMessage;

			public int finishTurn;

			public View finishView;

			public List<Engine.Phase> invalidPhase;

			public string invalidPhaseMessage;

			public List<Engine.CommandType> invalidCommand;

			public string invalidCommandMessage;

			public List<EffectInfo> effectList;

			public bool skipCardActivation;

			public bool noCancel;

			public string noCancelMessage;

			public CardCommandEx.StandType invalidStandType;

			public string invalidStandTypeMessage;

			public List<int> invalidCardID;

			public string invalidCardIDMessage;

			public int effectSelectionTarget;

			public string invalidEffectSelectionTargetMessage;

			public List<int> locationTargetPosition;

			public bool blockExtraDeckCommand;

			public string blockExtraDeckCommandMessage;

			public string helpLabelPath;
		}

		public enum View
		{
			None = 0,
			DuelStart = 1,
			PhaseChangeDrawStart = 2,
			PhaseChangeStandbyStart = 3,
			PhaseChangeMain1Start = 4,
			PhaseChangeBattleStart = 5,
			PhaseChangeMain2Start = 6,
			PhaseChangeEndStart = 7,
			CommandSummon = 8,
			AllAttacked = 9,
			CommandAttack = 10,
			CommandSet = 11,
			BattleAttack = 12,
			CardHappen = 13,
			ChainEnd = 14,
			FirstWaitInputMainPhase1 = 15,
			CommandSummonSp = 16,
			CommandAction = 17,
			CommandPendulum = 18,
			CommandBegin = 19,
			CommandExecuted = 20,
			LocationBegin = 21,
			LocationExecuted = 22,
			BeginDialog = 23
		}

		public enum Effect
		{
			HighlightCard = 0,
			HighlightPhase = 1,
			HighlightGrave = 2,
			ArrowCard = 3,
			UIHighlightActivateButton = 4,
			UIHighlightListCard = 5,
			UIHighlightCommand = 6,
			UIHighlightPhase = 7,
			HighlightExtra = 8,
			UIHighlightStandType = 9
		}

		[Serializable]
		public class EffectInfo
		{
			public Effect effect;

			public int param;
		}

		public List<MessageInfo> infoList;

		public bool playClimaxBGM;

		public bool isFirstTutorial;

		public bool isStrategy;

		public MessageInfo Get(int turn, View view, List<MessageInfo> ignoreList)
		{
			return null;
		}

		public MessageInfo Get(int index, int turn, View view)
		{
			return null;
		}

		public List<string> GetHelp()
		{
			return null;
		}
	}
}
