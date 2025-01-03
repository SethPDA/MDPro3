using System;
using System.Collections.Generic;
using System.IO;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.Net;
using System.Text;

namespace MDPro3.YGOSharp
{
    public class Deck
    {
        public List<int> Main;
        public List<int> Extra;
        public List<int> Side;
        public List<int> Pickup;
        public int Protector;
        public int Case;
        public int Field;
        public int Grave;
        public int Stand;
        public int Mate;

        public const string deckHint = "#created by MDPro3";
        public string userId;
        public string deckId;

        public Deck()
        {
            Main = new List<int>();
            Extra = new List<int>();
            Side = new List<int>();
            Pickup = new List<int>();
            Protector = 1070001;
            Case = 1080001;
            Field = 1090001;
            Grave = 1100001;
            Stand = 1110001;
            Mate = 1000001;
        }

        public Deck(string path) : this(File.ReadAllText(path), string.Empty, string.Empty)
        {

        }

        public Deck(string ydk, string deckID = "", string userID = "")
        {
            deckId = deckID;
            userId = userID;

            Main = new List<int>();
            Extra = new List<int>();
            Side = new List<int>();
            Pickup = new List<int>();
            Protector = 1070001;
            Case = 1080001;
            Field = 1090001;
            Grave = 1100001;
            Stand = 1110001;
            Mate = 1000001;
            string st = ydk.Replace("\r", "");
            string[] lines = st.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int flag = -1;

            foreach (string line in lines)
            {
                if (line.StartsWith("###") && userId == string.Empty)
                {
                    userId = line.Replace("###", string.Empty);
                    continue;
                }
                if (line.StartsWith("##") && deckId == string.Empty)
                {
                    deckId = line.Replace("##", string.Empty);
                    continue;
                }

                if (line == "#main")
                    flag = 1;
                else if (line == "#extra")
                    flag = 2;
                else if (line == "!side")
                    flag = 3;
                else if (line == "#pickup")
                    flag = 4;
                else if (line == "#protector")
                    flag = 5;
                else if (line == "#case")
                    flag = 6;
                else if (line == "#field")
                    flag = 7;
                else if (line == "#grave")
                    flag = 8;
                else if (line == "#stand")
                    flag = 9;
                else if (line == "#mate")
                    flag = 10;
                else
                {
                    int code = 0;
                    try
                    {
                        code = int.Parse(line.Replace("#", ""));
                    }
                    catch
                    {
                        continue;
                    }
                    if (code > 100)
                    {
                        switch (flag)
                        {
                            case 1:
                                Main.Add(code);
                                break;
                            case 2:
                                Extra.Add(code);
                                break;
                            case 3:
                                Side.Add(code);
                                break;
                            case 4:
                                Pickup.Add(code);
                                break;
                            case 5:
                                Protector = code;
                                break;
                            case 6:
                                Case = code;
                                break;
                            case 7:
                                Field = code;
                                break;
                            case 8:
                                Grave = code;
                                break;
                            case 9:
                                Stand = code;
                                break;
                            case 10:
                                Mate = code;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        public Deck(List<int> main, List<int> extra, List<int> side)
        {
            Main = main;
            Extra = extra;
            Side = side;
            Pickup = new List<int>();
            Protector = 1070001;
            Case = 1080001;
            Field = 1090001;
            Grave = 1100001;
            Stand = 1110001;
            Mate = 1000001;
        }

        public int Check(Banlist ban, bool ocg, bool tcg)
        {
            if (Main.Count < 40 ||
                Main.Count > 60 ||
                Extra.Count > 15 ||
                Side.Count > 15)
                return 1;

            Dictionary<int, int> cards = new Dictionary<int, int>();

            List<int>[] stacks = { Main, Extra, Side };
            foreach (List<int> stack in stacks)
            {
                foreach (int id in stack)
                {
                    Card card = CardsManager.Get(id);
                    AddToCards(cards, card);
                    if (!ocg && card.Ot == 1 || !tcg && card.Ot == 2)
                        return id;
                    if (card.HasType(CardType.Token))
                        return id;
                }
            }

            if (ban == null)
                return 0;

            foreach (var pair in cards)
            {
                int max = ban.GetQuantity(pair.Key);
                if (pair.Value > max)
                    return pair.Key;
            }
            return 0;
        }

        public int GetCardCount(int code)
        {
            int al = 0;
            try
            {
                al = CardsManager.Get(code).Alias;
            }
            catch (Exception)
            {
            }
            int returnValue = 0;
            return returnValue;
        }

        public bool Check(Deck deck)
        {
            if (deck.Main.Count != Main.Count || deck.Extra.Count != Extra.Count)
                return false;

            Dictionary<int, int> cards = new Dictionary<int, int>();
            Dictionary<int, int> ncards = new Dictionary<int, int>();
            List<int>[] stacks = { Main, Extra, Side };
            foreach (IList<int> stack in stacks)
            {
                foreach (int id in stack)
                {
                    if (!cards.ContainsKey(id))
                        cards.Add(id, 1);
                    else
                        cards[id]++;
                }
            }
            stacks = new[] { deck.Main, deck.Extra, deck.Side };
            foreach (var stack in stacks)
            {
                foreach (int id in stack)
                {
                    if (!ncards.ContainsKey(id))
                        ncards.Add(id, 1);
                    else
                        ncards[id]++;
                }
            }
            foreach (var pair in cards)
            {
                if (!ncards.ContainsKey(pair.Key))
                    return false;
                if (ncards[pair.Key] != pair.Value)
                    return false;
            }
            return true;
        }

        private static void AddToCards(Dictionary<int, int> cards, Card card)
        {
            int id = card.Id;
            if (card.Alias != 0)
                id = card.Alias;
            if (cards.ContainsKey(id))
                cards[id]++;
            else
                cards.Add(id, 1);
        }

        public bool Save(string deckName, DateTime saveTime, bool upload = true)
        {
            var ydk = GetYDK();
            try
            {
                var path = Program.deckPath + deckName + Program.ydkExpansion;
                File.WriteAllText(path, ydk, Encoding.UTF8);
                File.SetLastWriteTime(path, saveTime);

                if (MyCard.account != null && upload)
                    _ = OnlineDeck.SyncDeck(deckId, deckName, this, true);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string GetYDK()
        {
            var value = deckHint + "\r\n#main";
            for (var i = 0; i < Main.Count; i++)
                value += "\r\n" + Main[i];
            value += "\r\n#extra";
            for (var i = 0; i < Extra.Count; i++)
                value += "\r\n" + Extra[i];
            value += "\r\n!side";
            for (var i = 0; i < Side.Count; i++)
                value += "\r\n" + Side[i];
            if(Pickup.Count > 0)
                value += "\r\n#pickup\r\n" + Pickup[0] + "#";
            if (Pickup.Count > 1)
                value += "\r\n" + Pickup[1] + "#";
            if (Pickup.Count > 2)
                value += "\r\n" + Pickup[2] + "#";

            value += "\r\n#case\r\n" + Case + "#";
            value += "\r\n#protector\r\n" + Protector + "#";
            value += "\r\n#field\r\n" + Field + "#";
            value += "\r\n#grave\r\n" + Grave + "#";
            value += "\r\n#stand\r\n" + Stand + "#";
            value += "\r\n#mate\r\n" + Mate + "#";

            if (!string.IsNullOrEmpty(deckId))
                value += "\r\n##" + deckId;
            if (!string.IsNullOrEmpty(userId))
                value += "\r\n###" + userId;

            return value;
        }
    }
}