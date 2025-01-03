using System;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	public class KeyCommand
	{
		public enum OnKeyResult
		{
			Success = 0,
			Complete = 1,
			AlreadyCompleted = 2,
			Failed = 3
		}

		private KeyCommandSetting.KeyCommandInfo info;

		private int index;

		private Action<OnKeyResult> onSetKeyCallback;

		public KeyCommand(KeyCommandSetting.KeyCommandInfo info, Action<OnKeyResult> onSetKeyCallback)
		{
		}

		public void SetKey(SelectorManager.KeyType keyType)
		{
		}

		public void Reset()
		{
		}

		private void InvokeOnSetKeyResult(OnKeyResult result)
		{
		}
	}
}
