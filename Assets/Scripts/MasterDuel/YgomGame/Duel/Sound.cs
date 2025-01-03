using UnityEngine;

namespace YgomGame.Duel
{
	public class Sound
	{
		public enum DuelBGM
		{
			DuelEarly = 0,
			DuelMiddle = 1,
			DuelLate = 2,
			DuelStart = -1
		}

		internal class Work
		{
			public string[] bgms;

			public DuelBGM bgm_step;

			public bool isSeLoaded;

			public bool isBgmLoaded;

			public Work(string[] bgms)
			{
			}
		}

		private const string DefaultLabel = "BGM_DUEL_NORMAL_01";

		private static Work s_work;

		public static bool IsReady()
		{
			return false;
		}

		public static bool IsLoaded()
		{
			return false;
		}

		public static bool Init(string[] bgms)
		{
			return false;
		}

		public static void Term()
		{
		}

		public static void LoadSE()
		{
		}

		private static void UnloadSE()
		{
		}

		public static int PlaySE(string label)
		{
			return 0;
		}

		public static int PlaySE(string label, Vector3 position)
		{
			return 0;
		}

		public static int PlaySE(string label, GameObject traceTarget)
		{
			return 0;
		}

		public static void Stop(int instanceId, float fade = -1f)
		{
		}

		public static void Stop(string label, float fade = -1f)
		{
		}

		public static void SetPan(int instanceID, float newPan, float moveTime = 0f)
		{
		}

		public static void LoadBGM()
		{
		}

		private static void UnloadBGM()
		{
		}

		public static void PlayBGM(DuelBGM idx, float delay = -1f)
		{
		}

		public static string GetBGMLabel(DuelBGM idx)
		{
			return null;
		}

		public static void StopBGM(float fade = -1f)
		{
		}

		public static DuelBGM GetCurrentBGM()
		{
			return default(DuelBGM);
		}

		public static bool IsSameBGM(DuelBGM stepA, DuelBGM stepB)
		{
			return false;
		}
	}
}
