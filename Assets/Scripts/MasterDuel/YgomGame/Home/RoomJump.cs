using System;
using YgomGame.Home.RoomJumpInternal;
using YgomGame.Room;

namespace YgomGame.Home
{
	public class RoomJump
	{
		public static void GotoRoomSelect(RoomEntryViewController.Mode mode, Action<bool> resultCallback = null)
		{
		}

		public static void GotoCurrentRoom(Action<bool> resultCallback = null)
		{
		}

		private static void execute(RoomJumperBase jumper, Action<bool> callback = null)
		{
		}
	}
}
