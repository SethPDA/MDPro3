using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem
{
	[Serializable]
	public class SelectEnvBGSetting
	{
		public List<string> targetBranchPatterns;

		public Color bgColor;

		public bool IsMatchBranch(string branchName)
		{
			return false;
		}

		public bool IsMatchAnyBranch()
		{
			return false;
		}
	}
}
