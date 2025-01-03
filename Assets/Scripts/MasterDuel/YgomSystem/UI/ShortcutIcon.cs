using System;
using YgomSystem.Utility;

namespace YgomSystem.UI
{
	public class ShortcutIcon : DeviceIcon
	{
		public enum Mode
		{
			None = 0,
			PadKey = 1,
			Mouse = 2,
			Analog = 3
		}

		public enum AnalogDirection
		{
			Horizontal = 0,
			Vertical = 1
		}

		public SelectorManager.KeyType keyType;

		public SelectorManager.AnalogType analogType;

		public SelectorManager.MouseType mouseType;

		public GamePadIconUtil.Variation iconVariation;

		public Mode mode;

		public AnalogDirection analogDirection;

		public void SetKeyType(SelectorManager.KeyType keyType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, Action onCompleted = null)
		{
		}

		public void SetAnalogType(SelectorManager.AnalogType analogType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, Action onCompleted = null)
		{
		}

		public void SetMouseType(SelectorManager.MouseType mouseType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, Action onCompleted = null)
		{
		}

		protected override void UpdateDisplay(Action onCompleted = null)
		{
		}

		private void SetIcon(Action onCompleted = null)
		{
		}
	}
}
