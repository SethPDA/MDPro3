using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public class AutoReleaseCardIllust : MonoBehaviour
	{
		private CardIllustManager cardIllustManager;

		[SerializeField]
		private int requestCardId;

		[SerializeField]
		private int loadedCardid;

		private UnityAction<Texture2D> onFinish;

		public void SetCardIllustManager(CardIllustManager cardIllustManager)
		{
		}

		public void SetCard(int cardid, UnityAction<Texture2D> onFinish, bool immediateOnReuse = false)
		{
		}

		private void LoadCardIllust(bool immediateOnReuse = false)
		{
		}

		private void ReleaseCardIllust()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
