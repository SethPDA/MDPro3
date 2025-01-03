using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public static class TutorialUtil
	{
		private enum CommandType
		{
			None = 0,
			Summon = 1,
			Set = 2,
			Attack = 3,
			SummonSp = 4,
			Action = 5,
			Pendulum = 6
		}

		private class EffectInfo
		{
			public DuelTutorialData.EffectInfo info;

			public SimpleEffect effect;

			public EffectInfo(DuelTutorialData.EffectInfo info, SimpleEffect effect)
			{
			}
		}

		private class UIEffectInfo
		{
			public DuelTutorialData.EffectInfo info;

			public GameObject effect;

			public UIEffectInfo(DuelTutorialData.EffectInfo info, GameObject effect)
			{
			}
		}

		private static bool initialized;

		private static DuelTutorialSetting setting;

		private static DuelTutorialSetting setting2;

		private static DuelTutorialData data;

		private static DuelTutorialData.MessageInfo currentMessageInfo;

		private static int currentMessageIndex;

		private static List<DuelTutorialData.MessageInfo> doneMessageInfoList;

		private static CommandType preDoCommand;

		private static bool phaseStartStep;

		private static List<EffectInfo> playingEffectList;

		private static List<UIEffectInfo> playingUIEffectList;

		private static GameObject prefabUIEffect;

		public static bool isReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static DuelGameObjectManager goManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool isTutorial
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static void LoadTutorialSetting(Action onFinished)
		{
		}

		public static void InitializeTutorial(DuelGameObjectManager goManager, Action onFinished)
		{
		}

		public static void HideTutorialMessage()
		{
		}

		public static void TerminateTutorial()
		{
		}

		private static void ShowCenterMessage(IList<string> textIDList, Action finishedCallback, float delay)
		{
		}

		private static void ShowHelp(string helpLabelPath, Action onFinished)
		{
		}

		public static bool HelpExists()
		{
			return false;
		}

		public static string GetHelp()
		{
			return null;
		}

		private static void ShowTopMessage(string textID)
		{
		}

		private static void HideTopMessage()
		{
		}

		private static void HideCenterMessage()
		{
		}

		private static List<string> ParseTextIDs(IList<string> textIDs)
		{
			return null;
		}

		private static string ParseTextID(string textID)
		{
			return null;
		}

		public static void Check(DuelTutorialData.View view, Action finishedCallback)
		{
		}

		public static void CheckPhaseChange(Engine.Phase phase, Action finishedCallback)
		{
		}

		public static void CheckWaitInput(Action finishedCallback)
		{
		}

		public static void SetPhaseChanged()
		{
		}

		public static void SetPreDoCommand(Engine.CommandType commandType)
		{
		}

		public static void ResetPreDoCommand()
		{
		}

		public static void CheckBattleAttack(Action finishedCallback)
		{
		}

		public static void CheckCardHappen(Action finishedCallback)
		{
		}

		public static void CheckChainEnd(Action finishedCallback)
		{
		}

		public static void CheckCommandBegin(Action finishedCallback)
		{
		}

		public static void CheckCommandExecuted(Action finishedCallback)
		{
		}

		public static void CheckLocationBegin(Action finishedCallback)
		{
		}

		public static void CheckLocationExecuted(Action finishedCallback)
		{
		}

		public static void CheckBeginDialog(Action finishedCallback)
		{
		}

		public static bool IsInvalidPhase(Engine.Phase phase)
		{
			return false;
		}

		public static void ShowInvalidPhaseMessage()
		{
		}

		public static bool IsInvalidCommand(Engine.CommandType command)
		{
			return false;
		}

		public static void ShowInvalidCommandMessage()
		{
		}

		public static bool IsInvalidStandType(CardCommandEx.StandType standType)
		{
			return false;
		}

		public static void ShowInvalidStandTypeMessage()
		{
		}

		public static bool IsInvalidCardID(int cardID)
		{
			return false;
		}

		public static void ShowInvalidCardMessage()
		{
		}

		public static void ShowNoCancelMessage()
		{
		}

		public static void ShowBlockExtraDeckCommandMessage()
		{
		}

		public static bool IsEffectSelectionTarget(int effectIndex)
		{
			return false;
		}

		public static void ShowInvalidEffectSelectionTargetMessage()
		{
		}

		public static bool IsLocationTargetPosition(int position)
		{
			return false;
		}

		public static void CheckEffectField()
		{
		}

		private static void CheckEffectCard()
		{
		}

		private static void CheckEffectPhaseButton()
		{
		}

		private static void CheckEffectGrave()
		{
		}

		private static void CheckEffectExtra()
		{
		}

		public static void CheckEffectUIPhase(Engine.Phase phase, Transform target)
		{
		}

		public static void CheckEffectUICommand(Engine.CommandType command, Transform target)
		{
		}

		public static void CheckEffectUIActivateButton(Transform target)
		{
		}

		public static void CheckEffectUIListCard(int cardID, Transform target)
		{
		}

		public static bool IsCurrentTutorialContainsUIListCard()
		{
			return false;
		}

		public static bool IsEffectTargetUIListCard(int cardID)
		{
			return false;
		}

		public static void CheckEffectUIStandType(CardCommandEx.StandType standType, Transform target)
		{
		}

		private static void AddPlayingEffect(DuelTutorialData.EffectInfo effectInfo, SimpleEffect effect)
		{
		}

		private static void AddPlayingUIEffect(DuelTutorialData.EffectInfo effectInfo, GameObject effect)
		{
		}

		private static bool IsPlayingEffect(DuelTutorialData.EffectInfo effectInfo)
		{
			return false;
		}

		private static GameObject CreateUIEffect(Transform parent, string showLabel)
		{
			return null;
		}

		public static void ClearEffectAll()
		{
		}

		public static void ClearUIEffectPhase()
		{
		}

		public static void ClearUIEffectCommand()
		{
		}

		public static void ClearUIEffectStandType()
		{
		}

		public static void ClearUIEffectActivateButton()
		{
		}

		public static void ClearUIEffectListCard()
		{
		}

		public static void ClearUIEffectListCard(int cardID)
		{
		}

		private static void ClearUIEffect(DuelTutorialData.Effect effect)
		{
		}

		private static void ClearUIEffect(DuelTutorialData.Effect effect, int param)
		{
		}

		public static void ClearUIEffectAll()
		{
		}

		public static bool IsSkipActivation()
		{
			return false;
		}

		public static bool NoCancel()
		{
			return false;
		}

		public static bool BlockExtraDeckCommand()
		{
			return false;
		}

		public static bool IsClimaxBGMPlayable()
		{
			return false;
		}

		public static bool IsFirstTutorial()
		{
			return false;
		}

		public static bool IsStrategy()
		{
			return false;
		}

		public static bool IsDone()
		{
			return false;
		}
	}
}
