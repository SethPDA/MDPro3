using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardShow
	{
		public enum Step
		{
			Init = 0,
			WaitLoad = 1,
			Move = 2,
			Wait = 3,
			Back = 4,
			Finish = 5
		}

		public enum Mode
		{
			Happen = 0,
			Disabled = 1,
			Apply = 2
		}

		private CardRoot cardRoot;

		private bool cardFace;

		private Mode mode;

		private int team;

		private int position;

		private float time;

		private Vector3 startPosition;

		private Quaternion startRotation;

		private Vector3 startScale;

		private Vector3 movedPosition;

		private Quaternion movedRotation;

		private Vector3 movedScale;

		private Vector3 waitedPosition;

		private Quaternion waitedRotation;

		private Vector3 waitedScale;

		private Vector3 destScale;

		private BezierMotionSetting motionShow;

		private BezierMotionSetting motionWait;

		private BezierMotionSetting motionBack;

		public Action OnInitCallback
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnMoveCallback
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnWaitCallback
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnBackCallback
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnFinishCallback
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Step step
		{
			[CompilerGenerated]
			get
			{
				return default(Step);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(CardRoot setCardRoot, Mode mode, int team, int position)
		{
		}

		public void UpdateStatus()
		{
		}

		private void Init()
		{
		}

		private void WaitLoad()
		{
		}

		private void Move()
		{
		}

		private void Wait()
		{
		}

		private void Back()
		{
		}

		private void Finish()
		{
		}
	}
}
