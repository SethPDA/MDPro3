using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.UI;

namespace YgomGame.Duelpass
{
	public class DuelpassRecommendItemWidget : MonoBehaviour
	{
		[SerializeField]
		public GameObject itemHolder;

		[SerializeField]
		private GameObject holderParent;

		[SerializeField]
		private GameObject wallpaperBgObject;

		private List<(DuelpassRewardContext, GameObject, GameObject)> recommends;

		[SerializeField]
		private SelectionButton mateButton;

		[SerializeField]
		private TMP_Text gradeText;

		private GameObject currentWallpaperGo;

		private readonly string LABEL_ITEMBINDER;

		private readonly string LABEL_WALLPAPERBG;

		private int nowItemIdx;

		private int nextItemIdx;

		public Character2D Character
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Init()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void StartSwap()
		{
		}

		public void BindAll()
		{
		}

		private IEnumerator SwapCoroutine(float swapSpan)
		{
			return null;
		}

		private void BindItem(DuelpassRewardContext context, GameObject holderTemplate, GameObject binder)
		{
		}

		private void TweenTargetItemBinderPlayLabel(GameObject template, string label)
		{
		}

		public void StopTween()
		{
		}
	}
}
