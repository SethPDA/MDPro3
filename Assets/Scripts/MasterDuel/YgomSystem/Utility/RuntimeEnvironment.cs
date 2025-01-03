namespace YgomSystem.Utility
{
	public static class RuntimeEnvironment
	{
		public enum ServerType
		{
			Product = 0,
			Staging = 1,
			QC1 = 2,
			Development = 3,
			KonamiLan = 4,
			Mock = 5,
			Apple = 6,
			Event = 7,
			QC2 = 8,
			Mock1 = 9,
			Mock2 = 10,
			Mock3 = 11,
			Dummy = 9999
		}

		public static ServerType server;

		private static readonly string[] langs;

		public static ServerType GetDefaultServerType()
		{
			return default(ServerType);
		}

		static RuntimeEnvironment()
		{
		}
	}
}
