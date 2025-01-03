using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	public class PlayGamesHelperObject : MonoBehaviour
	{
		private static PlayGamesHelperObject instance;

		private static bool sIsDummy;

		private static List<Action> sQueue;

		private List<Action> localQueue;

		private static bool sQueueEmpty;

		private static List<Action<bool>> sPauseCallbackList;

		private static List<Action<bool>> sFocusCallbackList;

		public static void CreateObject()
		{
		}

		public void Awake()
		{
		}

		public void OnDisable()
		{
		}

		public static void RunCoroutine(IEnumerator action)
		{
		}

		public static void RunOnGameThread(Action action)
		{
		}

		public void Update()
		{
		}

		public void OnApplicationFocus(bool focused)
		{
		}

		public void OnApplicationPause(bool paused)
		{
		}

		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return false;
		}

		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return false;
		}
	}
}
