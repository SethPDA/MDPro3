using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	[DisallowMultipleComponent]
	public class LoadingIcon : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] m_HandleTargets;

		private List<ILoadingIconHandler> m_Handlers;

		[SerializeField]
		private GameObject m_LoadingIconPref;

		[SerializeField]
		private bool m_LoadingIconStretch;

		[SerializeField]
		private GameObject m_LoadingCoverPref;

		[SerializeField]
		private GameObject m_LoadingCoverLocator;

		[SerializeField]
		private List<GameObject> m_LoadingTweenTargets;

		private GameObject m_LoadingIcon;

		private GameObject m_LoadingCover;

		private IEnumerator m_Sequence;

		public GameObject loadingCoverLocator => null;

		public void AssignHandler(ILoadingIconHandler handler)
		{
		}

		private void GetHandlersState(out bool completed, out bool visible)
		{
			completed = default(bool);
			visible = default(bool);
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private IEnumerator ySequence()
		{
			return null;
		}

		private void OnSourceChanged()
		{
		}

		private void Terminate()
		{
		}

		private IEnumerator yPlayRoutines(IEnumerator[] routines)
		{
			return null;
		}

		private IEnumerator yPlayShowLoadingIcon()
		{
			return null;
		}

		private IEnumerator yPlayHideLoadingIcon()
		{
			return null;
		}

		private IEnumerator yPlayShowLoadingCover()
		{
			return null;
		}

		private IEnumerator yPlayHideCoverIcon()
		{
			return null;
		}

		private IEnumerator yPlayLoadStartTarget()
		{
			return null;
		}

		private IEnumerator yPlayLoadEndTarget()
		{
			return null;
		}

		private void TerminateTweenTarget()
		{
		}

		private void TweenStopLabel(GameObject target, bool includeChildren = false, params string[] labels)
		{
		}
	}
}
