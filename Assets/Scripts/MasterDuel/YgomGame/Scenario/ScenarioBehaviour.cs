using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Scenario
{
	public abstract class ScenarioBehaviour : IScenarioBehaviour
	{
		public enum Step
		{
			None = 0,
			ControllerCheck = 1,
			Init = 2,
			Action = 3,
			Wait = 4,
			WaitInput = 5,
			Finish = 6,
			Error = 7
		}

		public readonly string commandKey;

		public readonly ScenarioDef.BehaviourAsyncMode asyncMode;

		protected readonly Dictionary<string, object> m_Args;

		protected Step m_Step;

		private bool m_IsEnd;

		protected ScenarioWork work;

		public Step step
		{
			get
			{
				return default(Step);
			}
			protected set
			{
			}
		}

		public virtual bool isReady => false;

		public bool isFinish => false;

		public event Action<ScenarioBehaviour, Step> onChangeStepEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ScenarioBehaviour(object commandData)
		{
		}

		public void SetScenarioWork(ScenarioWork work)
		{
		}

		public void SetStep(Step s)
		{
		}

		public virtual bool Update()
		{
			return false;
		}

		public virtual bool OnResult()
		{
			return false;
		}

		public bool isError()
		{
			return false;
		}

		public void Abort()
		{
		}

		protected void ProgressControllerCheck()
		{
		}

		protected virtual void ProgressInit()
		{
		}

		protected virtual void ProgressAction()
		{
		}

		protected virtual void ProgressWait()
		{
		}

		protected virtual void ProgressWaitInput()
		{
		}

		protected virtual void ProgressFinish()
		{
		}

		protected virtual void OnAbort()
		{
		}

		protected virtual void OnChangedStep(Step step)
		{
		}

		public virtual bool IsOverrideBehaviour(ScenarioBehaviour target)
		{
			return false;
		}

		public virtual void OnPointerClick()
		{
		}
	}
}
