namespace YgomSystem.LocalFileSystem
{
	public class WindowsStorageIO : StandardStorageIO
	{
		protected override void OnInitialize()
		{
		}

		public string GetHashRootNativePath(Storage storage)
		{
			return null;
		}

		private string GetSteamUserDirectoryName()
		{
			return null;
		}
	}
}
