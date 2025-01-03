using System;
using System.Collections;
using System.Collections.Generic;

namespace YgomSystem
{
	public class StepSequencer
	{
		private enum Status
		{
			Idle = 0,
			Running = 1,
			End = 2
		}

		private enum ProcessType
		{
			None = 0,
			Method = 1,
			Coroutine = 2
		}

		private class StepEntry
		{
			public int step;

			public ProcessType type;

			public object proccess;

			public IEnumerator enumerator;
		}

		private Dictionary<int, StepEntry> m_steps;

		private int m_currentStep;

		private int m_prevStep;

		private bool m_stepChanged;

		private IEnumerator m_stepCoroutine;

		private const int INVALID_STEP = -1;

		private Status m_status;

		private int m_result;

		public bool isRunning => false;

		public bool isStepChanged => false;

		public int currentStep => 0;

		public int result => 0;

		private StepEntry registerStep(int step, ProcessType type, object proccess)
		{
			return null;
		}

		private IEnumerator stepCoroutineProcess(StepEntry entry)
		{
			return null;
		}

		private void runStepCoroutine(StepEntry entry)
		{
		}

		private void stopStepCoroutine()
		{
		}

		public void Destroy()
		{
		}

		public void RegisterStep(int stepValue, Action<StepSequencer> stepMethod)
		{
		}

		public void RegisterStep<T>(T stepValue, Action<StepSequencer> stepMethod) where T : Enum
		{
		}

		public void RegisterStep(int stepValue, Func<StepSequencer, IEnumerator> stepGenerator)
		{
		}

		public void RegisterStep<T>(T stepValue, Func<StepSequencer, IEnumerator> stepGenerator) where T : Enum
		{
		}

		public bool IsStepRegistered<T>(T step) where T : Enum
		{
			return false;
		}

		public void StartSequence(int startStep)
		{
		}

		public void StartSequence<T>(T startStep) where T : Enum
		{
		}

		public void Reset()
		{
		}

		public bool UpdateSequence()
		{
			return false;
		}

		public void SetStep(int step)
		{
		}

		public void SetStep<T>(T stepValue) where T : Enum
		{
		}

		public void SetEnd(int result = 0)
		{
		}
	}
}
