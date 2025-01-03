using System.Collections;
using System.Collections.Generic;
using YgomGame.Duel;

namespace YgomGame
{
	public class CharacterSoundDataManager
	{
		private static int characterSoundLoadCount;

		private static AvatarModelSetting modelSetting;

		private static Dictionary<int, int> loadIdDic;

		private static List<int> loadedId;

		public static AvatarModelSetting ModelSetting => null;

		public static bool IsLoaded(int id)
		{
			return false;
		}

		public static void Reset()
		{
		}

		public static void LoadAudioClip(int modelId)
		{
		}

		private static IEnumerator LoadAudioClipCoroutine(int id)
		{
			return null;
		}

		public static void UnloadAudioClip()
		{
		}

		private static IEnumerator UnloadAudioClipCroutine()
		{
			return null;
		}
	}
}
