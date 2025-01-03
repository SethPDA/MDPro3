using UnityEngine;

namespace YgomSystem
{
	public abstract class GamePad
	{
		public enum VIBRATION
		{
			NONE = 0,
			SYS_RESPONSE = 1,
			DUEL_MONSTER_CUTIN = 2,
			DUEL_MONSTER_LAND_MID = 3,
			DUEL_MONSTER_LAND_HIGH = 4,
			DUEL_CARD_BREAK = 5,
			DUEL_ATTACK_LOW = 6,
			DUEL_ATTACK_HIGH = 7,
			DUEL_EFFECT_DAMAGE = 8,
			DUEL_BG_BREAK = 9,
			DUEL_FINISHBLOW = 10
		}

		public const int GAMEPAD_01 = 1;

		public const int GAMEPAD_02 = 2;

		public const int GAMEPAD_03 = 3;

		public const int GAMEPAD_04 = 4;

		public static readonly int PAD_MAX_NUM;

		public const int BUTTON_INVALID = -1;

		public const int BUTTON_RLEFT = 0;

		public const int BUTTON_RDOWN = 1;

		public const int BUTTON_RRIGHT = 2;

		public const int BUTTON_RUP = 3;

		public const int BUTTON_L1 = 4;

		public const int BUTTON_R1 = 5;

		public const int BUTTON_L2 = 6;

		public const int BUTTON_R2 = 7;

		public const int BUTTON_OPTION1 = 9;

		public const int BUTTON_L3 = 10;

		public const int BUTTON_R3 = 11;

		public const int BUTTON_OPTION2 = 13;

		public const int BUTTON_UP = 100;

		public const int BUTTON_RIGHT = 101;

		public const int BUTTON_DOWN = 102;

		public const int BUTTON_LEFT = 103;

		public const int ANALOG_L_X = 200;

		public const int ANALOG_L_Y = 201;

		public const int ANALOG_R_X = 202;

		public const int ANALOG_R_Y = 203;

		public const int ANALOG_L2 = 204;

		public const int ANALOG_R2 = 205;

		public const int BUTTON_FUNC_base = 1000;

		public const int BUTTON_FUNC_DECISION = 1001;

		public const int BUTTON_FUNC_CANCEL = 1002;

		public const int BUTTON_FUNC_end = 1003;

		private static GamePad[] g_GamePadArray;

		private static GamePadUpdater g_GamePadUpdater;

		protected int m_iPadID;

		public static GamePadUpdater GamePadUpdater => null;

		public static GamePad[] GamePadArray => null;

		public static int gamePadMaxNum => 0;

		public static int UsingPadId => 0;

		public int PadID => 0;

		public static bool IsFuncButton(int Type)
		{
			return false;
		}

		public static GamePad GetGamePad(int iPadID = 1)
		{
			return null;
		}

		public static GamePad FindGamePad(int padId)
		{
			return null;
		}

		public static void InitializeGamePadSystem(GameObject residentObject)
		{
		}

		protected abstract int resolveFuncButton(int Type);

		public GamePad(int iPadID)
		{
		}

		public virtual void UpdateFrame()
		{
		}

		public abstract bool GetKey(int Type);

		public abstract bool GetKeyDown(int Type);

		public abstract float GetAnalog(int Type);

		public virtual void Vibrate(VIBRATION Id)
		{
		}

		public virtual void StopVibration()
		{
		}

		public int GetPhysicalKey(int Type)
		{
			return 0;
		}

		public int GetFunctionalKey(int Type)
		{
			return 0;
		}
	}
}
