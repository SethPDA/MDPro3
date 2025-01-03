using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duelpass
{
	public class DuelpassResultProgressBarWidget
	{
		private TMP_Text currentGradeText;

		private TMP_Text nextGradeText;

		private Image progressBar;

		private Image normalpassWallpaper;

		private Image goldpassWallpaper;

		private DuelpassResultProgressBarContext context;

		private float time100;

		private float dulationTime;

		public Action onStartAnimation;

		public Action onEndAnimation;

		public Action<int> onGradeUpInAnimation;

		public DuelpassResultProgressBarWidget(ElementObjectManager eom)
		{
		}

		public void StartGradeProgressAnimation(MonoBehaviour coroutineStarter)
		{
		}

		private IEnumerator ProgressAnimationCoroutine()
		{
			return null;
		}
	}
}
