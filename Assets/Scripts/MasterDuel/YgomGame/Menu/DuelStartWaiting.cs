using System;
using System.Collections;

namespace YgomGame.Menu
{
	public class DuelStartWaiting : DuelStartWaitingBase
	{
		private float m_ProgressCount;

		public override int ProgressCount()
		{
			return 0;
		}

		public override void StartWaiting()
		{
		}

		public override IEnumerator yWaitWaiting(Action callback)
		{
			return null;
		}
	}
}
