using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame
{
	public class PopUpTextForSelectionList : MonoBehaviour
	{
		private enum Status
		{
			Opening = 0,
			Showing = 1,
			Closing = 2,
			Free = 3
		}

		private Dictionary<SelectionButton, string> m_PupUpBtnTabel;

		private float m_MaxWidth;

		private Coroutine m_CurrentCoroutine;

		private SelectionButton m_TargetSbtn;

		private Image m_Arrow;

		private TweenAlpha m_TweenAlphaTo;

		private TweenScaleTo m_TweenScaleRootTo;

		private TweenScaleTo m_TweenScaleArrowTo;

		private Status m_Status;

		private ElementObjectManager m_EOManager;

		private ExtendedTextMeshProUGUI m_PopUpText;

		private RectTransform m_Rt;

		private AdaptiveTextContainer adaptiveTextContainer;

		public void RegistPopUpCallback(SelectionButton sbtn, string text)
		{
		}

		public void OnDisappear()
		{
		}

		public void Initialize()
		{
		}

		private void RegistPopUpCallbackImpl(SelectionButton sbtn, string text)
		{
		}

		public void SetMaxWidth(int maxWidth)
		{
		}

		private IEnumerator Show(string text)
		{
			return null;
		}

		private void Update()
		{
		}

		private void StopAllTween()
		{
		}
	}
}
