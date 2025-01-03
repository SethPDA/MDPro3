using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Deck
{
	public class DeckCard : DeckEditCard
	{
		public enum LocationInDeck
		{
			NA = 0,
			M = 1,
			E = 2,
			S = 3,
			T = 4,
			D = 5
		}

		public LocationInDeck m_Location
		{
			[CompilerGenerated]
			get
			{
				return default(LocationInDeck);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private void Start()
		{
		}

		public static DeckCard Create(Transform parent)
		{
			return null;
		}

		public void SetRarity(bool b)
		{
		}

		public void SetRegulation(int regurationID)
		{
		}

		public void SetRegulationVisible(bool b)
		{
		}
	}
}
