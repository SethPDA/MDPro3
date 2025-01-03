using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenLauncher : MonoBehaviour
	{
		public List<TweenInfo> infoList;

		[SerializeField]
		private bool generateTweensOnAwake;

		private void Awake()
		{
		}

		public void GenerateTweens()
		{
		}

		private void GenerateTween(TweenInfo baseInfo, string prefix, string suffix)
		{
		}
	}
}
