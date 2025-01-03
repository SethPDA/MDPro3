using MDPro3.YGOSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UnityEngine;

namespace MDPro3
{
    public static class CardRarity
    {
        public enum Rarity
        {
            Unknown = 0,
            Normal = 1,
            Shine = 2,
            Royal = 4,
            Gold = 8,
            Millennium = 16,
        }

        const string jsonPath = "Data/Rarity.json";
        private static RarityCards cards;

        private static bool initialized = false;
        private static void Initialize()
        {
            if(initialized) return;

            if (!File.Exists(jsonPath))
            {
                cards = new RarityCards();
                initialized = true;
                return;
            }

            var json = File.ReadAllText(jsonPath);
            try
            {
                cards = JsonConvert.DeserializeObject<RarityCards>(json);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                cards = new RarityCards();
            }
            initialized = true;
        }
        public static void SetRarity(int card, Rarity rarity)
        {
            Initialize();
            cards.ShineCards.Remove(card);
            cards.RoyalCards.Remove(card);
            cards.GoldCards.Remove(card);
            cards.MillenniumCards.Remove(card);
            switch(rarity)
            {
                case Rarity.Shine:
                    cards.ShineCards.Add(card);
                    break;
                case Rarity.Royal:
                    cards.RoyalCards.Add(card);
                    break;
                case Rarity.Gold:
                    cards.GoldCards.Add(card);
                    break;
                case Rarity.Millennium:
                    cards.MillenniumCards.Add(card);
                    break;
            }
        }
        public static Rarity GetRarity(int card)
        {
            Initialize();

            if (cards.ShineCards.Contains(card))
                return Rarity.Shine;
            if (cards.RoyalCards.Contains(card))
                return Rarity.Royal;
            if (cards.GoldCards.Contains(card))
                return Rarity.Gold;
            if (cards.MillenniumCards.Contains(card))
                return Rarity.Millennium;
            return Rarity.Normal;
        }
        public static void BookmarkCard(int card)
        {
            Initialize();
            cards.BookCards.Add(card);
        }
        public static void UnbookmarkCard(int card)
        {
            Initialize();
            cards.BookCards.Remove(card);
        }
        public static bool CardBookmarked(int card)
        {
            Initialize();
            return cards.BookCards.Contains(card);
        }
        private static void BookSort()
        {
            Initialize();
            List<Card> cs = new List<Card>();
            foreach (var code in cards.BookCards)
                cs.Add(CardsManager.Get(code));
            cs.Sort(CardsManager.ComparisonOfCard());
            cards.BookCards.Clear();
            foreach (var card in cs)
                cards.BookCards.Add(card.Id);
        }

        public static List<int> GetBookCards()
        {
            BookSort();
            return cards.BookCards;
        }
        public static void Save()
        {
            Initialize();
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(cards, Formatting.Indented));
        }
    }

    [Serializable]
    public class RarityCards
    {
        public List<int> ShineCards;
        public List<int> RoyalCards;
        public List<int> GoldCards;
        public List<int> MillenniumCards;
        public List<int> BookCards;
        public RarityCards()
        {
            ShineCards = new List<int>();
            RoyalCards = new List<int>();
            GoldCards = new List<int>();
            MillenniumCards = new List<int>();
            BookCards = new List<int>();
        }
    }
}
