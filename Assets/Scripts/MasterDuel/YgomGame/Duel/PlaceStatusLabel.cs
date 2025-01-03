using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class PlaceStatusLabel : MonoBehaviour
	{
		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private Vector2 defaultSize;

		private ExtendedTextMeshProUGUI numCardsValue;

		private int preNumCardValue;

		private bool hiding;

		private Camera uiCamera;

		private PlaceStatusManager manager;

		public void Initialize(PlaceStatusManager manager)
		{
		}

		public void Setup(SharedDefinition.Location location, bool lieDown)
		{
		}

		public void Show(bool immediate)
		{
		}

		public void Hide(bool immediate)
		{
		}

		private void OnFinishedTweenShow()
		{
		}

		private void OnFinishedTweenHide()
		{
		}

		public void UpdateNumCards(Vector2 scrPos, int numCards)
		{
		}

		private void ApplyPosition(GameObject go, Vector2 scrPos)
		{
		}
	}
}
