using System;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	public static class KeyCommandUtil
	{
		private static KeyCommandSetting setting;

		private const string settingPath = "ScriptableObjects/KeyCommand/KeyCommandSetting";

		public static void Initialize(Action<KeyCommandSetting> onFinished)
		{
		}

		public static KeyCommandSetting.KeyCommandInfo GetInfo(string label)
		{
			return null;
		}

		public static KeyCommand Begin(string settingLabel, Action<KeyCommand.OnKeyResult> onSetKeyCallback)
		{
			return null;
		}

		public static void SetupKeyCommandReceiver(KeyCommand keyCommand, SelectionItem target)
		{
		}

		private static void SetupKeyCommandShortcut(KeyCommand keyCommand, SelectionItem target, SelectorManager.KeyType keyType)
		{
		}
	}
}
