using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DrawOperation
	{
		private enum Step
		{
			WaitPlaceToReady = 0,
			WaitCardMove = 1,
			Init = 2,
			MoveDeck = 3,
			Touchable = 4,
			WaitBack = 5,
			Finish = 6
		}

		private enum TouchPhase
		{
			Init = 0,
			Neutral = 1,
			InitDrawCardCenterFirst = 2,
			WaitDrawCardCenterFirst = 3,
			InitDrawCardCenterLatter = 4,
			WaitDrawCardCenterLatter = 5,
			WaitDetail = 6,
			Finish = 7
		}

		private RunEffectWorker worker;

		private Step step;

		private Engine.CardStatus fromStatus;

		private Engine.CardStatus toStatus;

		private CardPlace fromPlace;

		private CardPlace toPlace;

		private int uniqueID;

		private bool isFace;

		private int player;

		private int team;

		private TouchPhase phase;

		private DeckCardPlace deckPlace;

		private CardRoot drawCard;

		private Vector3 defaultPos;

		private Quaternion defaultRot;

		private float camDist;

		private SimpleEffect drawArrowEff;

		private bool calledCardMove;

		private float frameOutTime;

		private bool isScreenOperated;

		private float time;

		private ScreenSelector screenSelector;

		private SelectionButton shortCutKey;

		private ChainedBezierMotion deckCloseUpMotion;

		private ChainedBezierMotion deckBackMotion;

		private ChainedBezierMotion drawMotionFirst;

		private ChainedBezierMotion drawMotionLatter;

		private ChainedBezierMotion toHandMotion;

		private Vector2 dragDirection;

		private const float neutralPhaseTimeLimit = 10f;

		private const float waitDetailPhaseTimeLimit = 10f;

		private SimpleEffect limitedEffectImpact;

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

		private Vector3 cardPosTo => default(Vector3);

		private Quaternion cardRotTo => default(Quaternion);

		private Vector3 deckPosTo => default(Vector3);

		private Quaternion deckRotTo => default(Quaternion);

		private Vector3 deckScaleTo => default(Vector3);

		public static DrawOperation Create(RunEffectWorker worker)
		{
			return null;
		}

		public void Terminate()
		{
		}

		public bool IsBusyEffect(Engine.ViewType viewType)
		{
			return false;
		}

		public void WaitInput(int param1, int param2, int param3)
		{
		}

		private void DrawCommand()
		{
		}

		public void CardMove(int param1, int param2, int param3)
		{
		}

		public void Update()
		{
		}

		private void WaitPlaceToReadyStep()
		{
		}

		private void WaitCardMoveStep()
		{
		}

		private void InitStep()
		{
		}

		private void MoveDeckStep()
		{
		}

		private void TouchableStep()
		{
		}

		private void TouchableStepInit()
		{
		}

		private void TouchableStepNeutral()
		{
		}

		private void TouchableStepInitDrawCardCenterFirst()
		{
		}

		private void TouchableStepWaitDrawCardCenterFirst()
		{
		}

		private void TouchableStepWaitDrawCardCenterLatter()
		{
		}

		private void TouchableStepWaitDetail()
		{
		}

		private void TouchableStepFinish()
		{
		}

		private bool UpdateDeckBack()
		{
			return false;
		}

		private void WaitBackStep()
		{
		}

		private void FinishStep()
		{
		}

		public void Abort()
		{
		}
	}
}
