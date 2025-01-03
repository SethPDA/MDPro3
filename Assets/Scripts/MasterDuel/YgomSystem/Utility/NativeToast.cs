using System.Collections;
using UnityEngine;

namespace YgomSystem.Utility
{
	public static class NativeToast
	{
		private static WaitForSeconds waitTime;

		private static IEnumerator yCoroutine;

		static NativeToast()
		{
		}

		public static void Open(string message)
		{
		}

		private static IEnumerator yOpen(string message)
		{
			return null;
		}
	}
}
