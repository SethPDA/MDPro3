using System;

namespace YgomSystem
{
	public class XboxUser
	{
		public enum Privilege
		{
			MULTIPLAY = 0,
			CROSSPLAY = 1,
			ADD_FRIEND = 2,
			COMMUNICATION = 3
		}

		public static ulong GetMyUserId()
		{
			return 0uL;
		}

		public static void ShowGamerCard(ulong xuid, Action<bool> onEnd)
		{
		}

		public static void ShowMyGamerCard(Action<bool> onEnd)
		{
		}

		public static void ResolvePriviledgeProblem(Privilege target, Action<bool> onEnd)
		{
		}
	}
}
