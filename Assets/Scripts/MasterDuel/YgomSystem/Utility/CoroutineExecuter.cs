using System;
using System.Collections;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class CoroutineExecuter : MonoBehaviour
	{
		public static CoroutineExecuter Instance;

		public static Coroutine Run(IEnumerator coroutine)
		{
			return null;
		}

		public static void Terminate(IEnumerator coroutine)
		{
		}

		public static void Terminate(Coroutine coroutine)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void StartCallbackCoroutine(Func<bool> func, Action callback)
		{
		}

		private IEnumerator CallbackCoroutine(Func<bool> func, Action callback)
		{
			return null;
		}

		public void CallDelay(Action callback, float delaySec, MonoBehaviour caller = null)
		{
		}

		private static IEnumerator CallDelayRoutine(Action callback, float delaySec)
		{
			return null;
		}
	}
}
