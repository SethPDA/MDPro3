using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelStartUtility
	{
		private static DuelStartUtility m_Instance;

		public int loadDefinitionCounter;

		private bool m_Active;

		private bool m_DuelClientStart;

		private bool m_LoadExData;

		private DuelEntryController duelEntryController;

		private DuelGameObjectManager goManager;

		private bool loadTextDuelLive;

		private List<string> PreLoadTimeline_Group1;

		private List<string> PreLoadTimeline_Group2;

		private List<string> PreLoadDuelData;

		public static DuelStartUtility Instance => null;

		public bool Active => false;

		public bool isDone => false;

		private bool isSettingFileReady => false;

		private bool isGoManagerReady => false;

		private bool isTextResReady => false;

		public void Initialize(DuelEntryMode mode, bool loadExData = true)
		{
		}

		public void Terminate(bool formDuelClient = false)
		{
		}

		private void LoadDuelResource()
		{
		}

		private void ReleaseDuelResource()
		{
		}

		public void MoveGOManager(Transform parent)
		{
		}

		public void OnLoadEnd()
		{
		}

		public void OnFirstMoveDecide()
		{
		}

		public void PreloadDeckCardPicture()
		{
		}

		public void SetRunEffectWorkerForGoManager(RunEffectWorker runEffectWorker)
		{
		}

		private void LoadTextFile()
		{
		}

		private void UnloadTextFile()
		{
		}

		private void LoadSettingFile()
		{
		}

		private void UnloadSettingFile()
		{
		}

		private void LoadMateModel()
		{
		}

		private void UnloadMateModel()
		{
		}

		private IEnumerator LoadTimelineFile()
		{
			return null;
		}

		private void UnloadTimelineFile()
		{
		}

		private IEnumerator LoadDuelData()
		{
			return null;
		}

		private void UnloadDuelData()
		{
		}

		private int[] objectListToIntArray(List<object> src, bool rejectZero, out List<int> rejectIdxs)
		{
			rejectIdxs = null;
			return null;
		}

		private int[] dicDeckToIntArray(Dictionary<string, object> dic, string key1, string key2, bool rejectZero, out List<int> rejectIdxs)
		{
			rejectIdxs = null;
			return null;
		}
	}
}
