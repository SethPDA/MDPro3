using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class EffectTaskCardLockon : EffectTask
	{
		private enum Step
		{
			WaitCardLoad = 0,
			WaitCardMove = 1,
			WaitEffect = 2,
			MoveFront = 3,
			CardShow = 4,
			MoveBack = 5,
			Finish = 6
		}

		private enum Type
		{
			Target = 0,
			NotTarget = 1,
			Show = 2
		}

		private bool finished;

		private Step step;

		private CardPlace cardPlace;

		private CardRoot cardRoot;

		private bool tempCard;

		private int team;

		private int position;

		private int index;

		private int uniqueID;

		private bool exist;

		private Type type;

		private float time;

		private const float MOVE_TIME = 0.375f;

		private const float WAIT_TIME = 0.5f;

		private Vector3 defaultPos;

		private Vector3 dstPos;

		private Quaternion defaultQuat;

		private Quaternion dstQuat;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskCardLockon(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardMoveStep()
		{
		}

		private void MoveFrontStep()
		{
		}

		private void CardShowStep()
		{
		}

		private void MoveBackStep()
		{
		}

		private void FinishStep()
		{
		}
	}
}
