using System;

namespace YgomGame.Home.RoomJumpInternal
{
	public abstract class RoomJumperBase
	{
		public abstract void Check(Action<bool> resultCallback);

		public abstract void Jump();
	}
}
