using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duelpass
{
	public class DuelpassHomeBannerWidget
	{
		private ElementObjectManager eom;

		private TMP_Text currentGradeText;

		private TMP_Text nextGradeText;

		private Image progressBar;

		private Image normalpassWallpaper;

		private Image goldpassWallpaper;

		private GameObject clockIcon;

		private GameObject limitDate;

		private DuelpassProgressBarContext context;

		public DuelpassHomeBannerWidget(ElementObjectManager eom)
		{
		}

		private void InitializeComponents()
		{
		}

		private void OnLimitGettingCloser()
		{
		}

		private void OnLimitNotClose()
		{
		}
	}
}
