using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelEndOperation
	{
		private enum Mode
		{
			DuelEndEffect = 0,
			Error = 1
		}

		private enum EffectStep
		{
			WaitCardEffect = 0,
			InitWinLose = 1,
			WaitSpecialWin = 2,
			InitDeckOut = 3,
			WaitDeckOut = 4,
			InitMateMotion = 5,
			WaitMateMotion = 6,
			WaitWinLose = 7,
			WaitWinLose2 = 8,
			FadeOut = 9,
			Finish = 10
		}

		private enum ErrorStep
		{
			WaitCardEffect = 0,
			WaitErrorDialog = 1,
			Finish = 2
		}

		private RunEffectWorker worker;

		private Mode mode;

		private EffectStep step;

		private ErrorStep errorStep;

		private Engine.ResultType resultType;

		private Engine.FinishType finishType;

		private DuelEndMessage msgObj;

		private float autoFinishTimer;

		private string userNameMyself;

		private string userNameRival;

		private int iconIDMyself;

		private int iconIDRival;

		private int frameIDMyself;

		private int frameIDRival;

		private int myselfid;

		private int rivalid;

		private string onlineIDMyself;

		private string onlineIDRival;

		private bool sameOSMyself;

		private bool sameOSRival;

		private int prepareCounter;

		private GameObject animation;

		private string endReasonFormat;

		private bool isOnlineMode;

		private bool isReplayMode;

		private bool isAudienceMode;

		private bool isShowRetry;

		private bool winMyself;

		private bool winRival;

		private bool isDuelLiveContinuous;

		private bool isForceNoProfileCard;

		private bool endMessageStarted;

		private bool hidePlayerID;

		private Dictionary<string, object> profileDataMyself;

		private Dictionary<string, object> profileDataRival;

		private const float duelLiveAutoLeaveTime = 3f;

		public bool finished
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

		private int winner => 0;

		private int loser => 0;

		public static DuelEndOperation Create()
		{
			return null;
		}

		public void Setup(RunEffectWorker worker, Engine.ResultType resultType, Engine.FinishType finishType)
		{
		}

		public void SetupError(RunEffectWorker worker)
		{
		}

		public void Update()
		{
		}

		private void UpdateEffect()
		{
		}

		private void RequestPreLoad()
		{
		}

		private bool WaitCardEffectStep()
		{
			return false;
		}

		private bool InitWinLoseStep()
		{
			return false;
		}

		private bool WaitSpecialWin()
		{
			return false;
		}

		private bool InitDeckOutStep()
		{
			return false;
		}

		private void WaitDeckOutStep()
		{
		}

		private bool InitMateMotionStep()
		{
			return false;
		}

		private void PlayWinLose()
		{
		}

		private void StartEndMessage()
		{
		}

		private void WaitWinLoseStep()
		{
		}

		private void WaitWinLoseStep2()
		{
		}

		private void FadeOutStep()
		{
		}

		private void FinishStep()
		{
		}

		private void UpdateError()
		{
		}

		private void WaitCardEffectErrorStep()
		{
		}

		private void FinishErrorStep()
		{
		}

		private bool IsSpecialWin(Engine.FinishType finishType)
		{
			return false;
		}

		private string GetWinLoseTimelinePath(Engine.FinishType finishType, Engine.ResultType resultType)
		{
			return null;
		}

		public void SelectEndMessageBtn()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
