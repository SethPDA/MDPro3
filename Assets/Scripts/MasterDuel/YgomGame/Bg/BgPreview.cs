using System;
using System.Collections;
using UnityEngine;

namespace YgomGame.Bg
{
	public class BgPreview : MonoBehaviour
	{
		private BgManager mng;

		private Action onInitilizeFinish;

		public bool IsInitialized;

		public static BgPreview Create(Transform root, Action onFinish = null, params int[] ids)
		{
			return null;
		}

		private IEnumerator InitializedCheck()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
