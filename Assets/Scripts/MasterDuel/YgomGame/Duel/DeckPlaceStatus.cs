using UnityEngine;

namespace YgomGame.Duel
{
	public class DeckPlaceStatus
	{
		private PlaceStatusLabel statusLabel;

		private DeckCardPlace deckPlace;

		public bool isTerminated => false;

		public DeckPlaceStatus(DeckCardPlace deckPlace)
		{
		}

		public void Terminate()
		{
		}

		public void Update()
		{
		}

		public void Show(bool immediate)
		{
		}

		public void Hide(bool immediate)
		{
		}

		private Vector2 World2ScreenPos(Vector3 pos)
		{
			return default(Vector2);
		}
	}
}
