using System;
using System.Collections.Generic;

namespace YgomGame.Duel
{
	public abstract class DuelTransitionUIBase : DuelUIBase
	{
		protected abstract class OperationInfoBase
		{
			public Action act;

			public Func<bool> wait;
		}

		protected Queue<OperationInfoBase> operationQueue;

		private OperationInfoBase currentOperation;

		private void UpdateOperation()
		{
		}

		protected override void Update()
		{
		}
	}
}
