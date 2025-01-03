using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Utility
{
	public class ScriptableObjectManager<T> where T : ScriptableObject
	{
		private static Dictionary<string, UnityEvent<T>> loadFinishedCallbackList;

		public static void Initialize()
		{
		}

		public static T Load(string path)
		{
			return null;
		}

		public static void LoadAsync(string path, Action<T> on_finished)
		{
		}

		public static void UnloadAll()
		{
		}
	}
}
