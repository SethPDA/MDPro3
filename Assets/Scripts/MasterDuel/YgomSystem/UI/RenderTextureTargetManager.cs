using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class RenderTextureTargetManager : MonoBehaviour
	{
		private int targetCount;

		private GameObject lightObject;

		private List<int> useIdxList;

		private List<int> removeIdxList;

		private List<RenderTextureTarget> renderTextureTargetList;

		private static RenderTextureTargetManager instance;

		private static bool isQuitting;

		public static RenderTextureTargetManager Instance => null;

		private void OnApplicationQuit()
		{
		}

		public static void Reboot()
		{
		}

		public static void CreateManager()
		{
		}

		public static int Create(Action<RenderTextureTarget> onFinish)
		{
			return 0;
		}

		public static void DestroyTarget(int id)
		{
		}

		public static Camera GetTargetCamera(int id)
		{
			return null;
		}

		private int GetUnusedId()
		{
			return 0;
		}
	}
}
