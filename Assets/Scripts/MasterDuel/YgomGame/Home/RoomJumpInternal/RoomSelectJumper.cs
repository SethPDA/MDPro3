using System;
using System.Runtime.CompilerServices;
using YgomGame.Room;

namespace YgomGame.Home.RoomJumpInternal
{
	public class RoomSelectJumper : RoomJumperBase
	{
		protected RoomEntryViewController.Mode mode
		{
			[CompilerGenerated]
			get
			{
				return default(RoomEntryViewController.Mode);
			}
		}

		public RoomSelectJumper(RoomEntryViewController.Mode mode)
		{
		}

		public override void Check(Action<bool> resultCallback)
		{
		}

		public override void Jump()
		{
		}
	}
}
