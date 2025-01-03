using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumDeckManager
	{
		public ColosseumPathManager pm;

		public ColosseumDeckManager(ColosseumUtil.PlayMode playMode, int identifier = 0)
		{
		}

		public ColosseumDeckManager(ColosseumUtil.PlayMode playMode, bool isRental, int identifier = 0)
		{
		}

		public ColosseumDeckManager(ColosseumPathManager pathManager)
		{
		}

		public DeckCaseWidget SetDeckCase(Dictionary<string, object> deckDic, DeckCaseWidget deckCase, Transform parent)
		{
			return null;
		}

		public void OnClickDeck(bool isSetDeck, ViewControllerManager manager, int id, int logoId, ElementObjectManager overviewEOM, Action<int, bool> openDeckEditCallback, int stage = 0)
		{
		}

		public GameObject CreateEmbedObj(int logoId, ElementObjectManager overviewEOM, int stage, string deckName = "")
		{
			return null;
		}

		public Dictionary<string, object> GetDeckList(int rentalState = 0)
		{
			return null;
		}

		private Dictionary<string, object> GetDeckAccessory()
		{
			return null;
		}

		private int[] GetDeckPickUpCardIDs()
		{
			return null;
		}

		private int[] GetDeckPickUpCardDecorations()
		{
			return null;
		}

		private string GetDeckNameTextID()
		{
			return null;
		}
	}
}
