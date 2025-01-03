namespace YgomSystem.Utility
{
	public class AppInfo
	{
		public enum BootType
		{
			StartUp = 0,
			ExitReboot = 1,
			TitleLoopReboot = 2
		}

		public const string AppIdentifier = "AMAA";

		public static BootType bootType;
	}
}
