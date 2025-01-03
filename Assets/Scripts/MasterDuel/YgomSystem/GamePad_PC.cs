using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace YgomSystem
{
	public class GamePad_PC : GamePad
	{
		public class VibrationSetting
		{
			public float lowFrequency;

			public float highFrequency;

			public float time;

			public VibrationSetting(float l, float h, float t)
			{
			}
		}

		protected class ButtonInputState
		{
			public int type;

			public ButtonControl buttonControl;

			public bool nowOn;

			public bool prevOn;
		}

		private Dictionary<VIBRATION, List<VibrationSetting>> vibrationSettings;

		private List<VibrationSetting> vibrationList;

		private float vibrationTime;

		private int vibrationIdx;

		protected static readonly int[] buttonTypes;

		protected Dictionary<int, ButtonInputState> buttonInputStates;

		protected Gamepad currentPad;

		protected Dictionary<int, AxisControl> analogAxisControls;

		private bool _isAxisNotFoundErrorOccured;

		protected string axisNotFoundError
		{
			set
			{
			}
		}

		public static void InitializePCGamePadSystem()
		{
		}

		private bool getKeyOn(int Type)
		{
			return false;
		}

		public GamePad_PC(int iPadID)
			: base(0)
		{
		}

		protected void SetupButtonsAndAxes()
		{
		}

		protected void SetupVibrations()
		{
		}

		public override void UpdateFrame()
		{
		}

		public override bool GetKey(int Type)
		{
			return false;
		}

		public override bool GetKeyDown(int Type)
		{
			return false;
		}

		public override float GetAnalog(int Type)
		{
			return 0f;
		}

		public override void Vibrate(VIBRATION Id)
		{
		}

		public override void StopVibration()
		{
		}

		private void UpdateVibration()
		{
		}

		protected override int resolveFuncButton(int Type)
		{
			return 0;
		}

		protected void VerifyBtnMapping()
		{
		}
	}
}
