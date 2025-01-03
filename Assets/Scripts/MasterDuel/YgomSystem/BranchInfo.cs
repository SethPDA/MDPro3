namespace YgomSystem
{
	public static class BranchInfo
	{
		private static string s_branchName;

		private static string s_commitHash;

		private static bool s_isReleaseBranch;

		public static string branchName => null;

		public static string commitHash => null;

		public static bool isReleaseBranch => false;

		public static void Initialize(BranchData data)
		{
		}
	}
}
