using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomSystem.Home
{
	public class BindingTopicsCardUV : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private string settingPath;

		[SerializeField]
		public int mrk;

		[SerializeField]
		private bool fitScalePendulum;

		private bool loadStart;

		public bool visible => false;

		public event Action onReloadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		public void ExecuteBinding()
		{
		}

		private void FitScalePendulum(RawImage rawImage, int mrk)
		{
		}

		private IEnumerator yDelayFrame(int waitFrame = 1, Action onComplete = null)
		{
			return null;
		}
	}
}
