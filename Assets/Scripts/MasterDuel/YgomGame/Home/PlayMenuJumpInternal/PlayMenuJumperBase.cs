using System;
using System.Collections.Generic;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal
{
	public abstract class PlayMenuJumperBase
	{
		protected abstract ColosseumUtil.PlayMode playMode { get; }

		protected abstract string prefabPath { get; }

		protected virtual void ExtendArgs(ref Dictionary<string, object> args)
		{
		}

		public abstract void Check(Action<bool> resultCallback);

		public void Jump()
		{
		}
	}
}
