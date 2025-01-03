using System;
using System.Collections;
using System.Collections.Generic;

namespace YgomGame.Menu
{
	public class PvpMenuMatchingRoom : PvpMenuMatchingBase
	{
		private float m_ProgressCount;

		public override int ProgressCount()
		{
			return 0;
		}

		public override void StartMatching(Dictionary<string, object> param)
		{
		}

		public override IEnumerator yWaitMatching(Action callback)
		{
			return null;
		}

		public override void SetBootDuelParam(ref Dictionary<string, object> param)
		{
		}
	}
}
