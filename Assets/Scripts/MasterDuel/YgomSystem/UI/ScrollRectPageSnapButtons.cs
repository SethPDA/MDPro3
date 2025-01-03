using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI
{
	public class ScrollRectPageSnapButtons : MonoBehaviour
	{
		[SerializeField]
		public ElementObjectManager eom;

		[SerializeField]
		public string backButtonLabel;

		[SerializeField]
		public string nextButtonLabel;

		[SerializeField]
		public bool hideOnEmpty;

		private ScrollRectPageSnap m_PageSnap;

		public SelectionButton backButton => null;

		public SelectionButton nextButton => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Refresh()
		{
		}

		private void OnPageChanged()
		{
		}

		private void OnClickBack()
		{
		}

		private void OnClickNext()
		{
		}
	}
}
