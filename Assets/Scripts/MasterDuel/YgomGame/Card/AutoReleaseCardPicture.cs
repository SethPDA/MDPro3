using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public class AutoReleaseCardPicture : MonoBehaviour
	{
		private CardPictureManager cardPictureManager;

		[SerializeField]
		private List<int> cardidList;

		private List<int> taskidList;

		private List<UnityAction<Texture2D>> onFinishList;

		private UnityAction onFinishAll;

		private int loadingCount;

		public void SetCardMaterialManager(CardPictureManager cardPictureManager)
		{
		}

		public void SetCardList(List<int> cardidList, List<UnityAction<Texture2D>> onFinishList, UnityAction onFinishAll = null)
		{
		}

		public void SetCard(int cardid, UnityAction<Texture2D> onFinish)
		{
		}

		private void ReleaseCardPicture()
		{
		}

		private void LoadCardPicture()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
