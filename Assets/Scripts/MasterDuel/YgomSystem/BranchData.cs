using UnityEngine;

namespace YgomSystem
{
	public class BranchData : ScriptableObject
	{
		public string branchName;

		public string commitHash;

		public bool isReleaseBranch;
	}
}
