using System;
//using Steamworks;

namespace YgomSystem
{
	public class SteamSoftwareKeyboard
	{
		public enum MODE
		{
			SingleLine = 0,
			MultipleLines = 1,
			Email = 2,
			Numelic = 3
		}

		public enum POSITION
		{
			BOTTOM = 0,
			TOP = 1,
			DIRECT = 2
		}

		private static bool s_isOpen;

		private static Action s_callback;

		//private static Callback<FloatingGamepadTextInputDismissed_t> s_onFinish;

		public static bool Open(MODE mode = MODE.SingleLine, POSITION pos = POSITION.BOTTOM, Action callback = null, int x = -1, int y = -1, int w = -1, int h = -1)
		{
			return false;
		}

		//private static void OnFloatingKeyboardFinish(FloatingGamepadTextInputDismissed_t t)
		//{
		//}
	}
}
