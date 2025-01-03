using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	//[CreateAssetMenu]
	public class TweenGroupInfo : TweenInfo
	{
		public string prefix;

		public string suffix;

		public List<TweenInfo> infoList;
	}
}
