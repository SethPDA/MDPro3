using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class DuelTutorialSetting : ScriptableObject
	{
		[Serializable]
		public class TutorialChapter
		{
			public int chapter;
		}

		public List<TutorialChapter> tutorialChapterList;

		public bool IsTutorialChapter(int chapter)
		{
			return false;
		}
	}
}
