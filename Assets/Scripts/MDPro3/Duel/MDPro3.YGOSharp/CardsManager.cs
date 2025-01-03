using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Mono.Data.Sqlite;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using System.IO;
using Ionic.Zip;
using MDPro3.Utility;

namespace MDPro3.YGOSharp
{
    internal static class CardsManager
    {
        public static IDictionary<int, Card> _cards = new Dictionary<int, Card>();
        public static IDictionary<int, Card> _cardsForRender = new Dictionary<int, Card>();
        public static string nullName = "";

        public static string nullString = "";

        internal static void Initialize()
        {
            nullName = InterString.Get("未知卡片");
            nullString = string.Empty;
;
            string language = Language.GetConfig();
            string databaseFullPath = Program.localesPath + language + "/cards.cdb";
            if (!File.Exists(databaseFullPath))
                databaseFullPath = Program.localesPath + "zh-CN/cards.cdb";
            _cards.Clear();
            LoadCDB(databaseFullPath);
            if (Config.Get("Expansions", "1") == "1")
            {
                foreach (var cdb in Directory.GetFiles("Expansions", "*.cdb"))
                    LoadCDB(cdb);
                foreach (var zip in ZipHelper.zips)
                {
                    if (zip.Name.ToLower().EndsWith("script.zip"))
                        continue;
                    foreach (var file in zip.EntryFileNames)
                    {
                        if (file.ToLower().EndsWith(".cdb"))
                        {
                            var e = zip[file];
                            if (!Directory.Exists(Program.tempFolder))
                                Directory.CreateDirectory(Program.tempFolder);
                            var tempFile = Path.Combine(Path.GetFullPath(Program.tempFolder), file);
                            e.Extract(Path.GetFullPath(Program.tempFolder), ExtractExistingFileAction.OverwriteSilently);
                            LoadCDB(tempFile, isPreCards : Path.GetFileName(zip.Name) == "ygopro-super-pre.ypk");
                            File.Delete(tempFile);
                        }
                    }
                }
            }

            UpdateSetNames();
            PacksManager.Initialize();

            _cardsForRender.Clear();
            var cardLanguage = Language.GetCardConfig();
            databaseFullPath = Program.localesPath + cardLanguage + "/cards.cdb";
            if (!File.Exists(databaseFullPath))
                databaseFullPath = Program.localesPath + "zh-CN/cards.cdb";
            LoadCDB(databaseFullPath, true);
            if (Config.Get("Expansions", "1") == "1")
            {
                foreach (var cdb in Directory.GetFiles("Expansions", "*.cdb"))
                    LoadCDB(cdb, true);
                foreach (var zip in ZipHelper.zips)
                {
                    if (zip.Name.ToLower().EndsWith("script.zip"))
                        continue;
                    foreach (var file in zip.EntryFileNames)
                    {
                        if (file.ToLower().EndsWith(".cdb"))
                        {
                            var e = zip[file];
                            if (!Directory.Exists(Program.tempFolder))
                                Directory.CreateDirectory(Program.tempFolder);
                            var tempFile = Path.Combine(Path.GetFullPath(Program.tempFolder), file);
                            e.Extract(Path.GetFullPath(Program.tempFolder), ExtractExistingFileAction.OverwriteSilently);
                            LoadCDB(tempFile, true, isPreCards: Path.GetFileName(zip.Name) == "ygopro-super-pre.ypk");
                            File.Delete(tempFile);
                        }
                    }
                }
            }
        }

        internal static void LoadCDB(string databaseFullPath, bool render = false, bool isPreCards = false)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + databaseFullPath))
            {
                connection.Open();

                using (IDbCommand command =
                    new SqliteCommand("SELECT datas.*, texts.* FROM datas,texts WHERE datas.id=texts.id;", connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoadCard(reader, render, isPreCards);
                        }
                    }
                }
            }
        }

        internal static void UpdateSetNames()
        {
            foreach (var item in _cards)
            {
                Card card = item.Value;
                card.strSetName = StringHelper.GetSetName(card.Setcode, true);
            }
        }

        internal static Card GetCard(int id)
        {
            if (_cards.ContainsKey(id))
                return _cards[id].Clone();
            return null;
        }
        internal static Card GetRenderCard(int id)
        {
            if (_cardsForRender.ContainsKey(id))
                return _cardsForRender[id].Clone();
            return null;
        }
        internal static Card GetCardRaw(int id)
        {
            if (_cards.ContainsKey(id))
                return _cards[id];
            return null;
        }

        internal static Card Get(int id, bool noneIsZero = false)
        {
            Card returnValue = new Card();
            if (id > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    returnValue = GetCard(id - i);
                    if (returnValue != null)
                    {
                        break;
                    }
                }

                if (returnValue == null)
                {
                    returnValue = new Card();
                    if (!noneIsZero)
                    {
                        returnValue.Id = id;
                        returnValue.Desc = id.ToString();
                    }
                }
            }

            return returnValue;
        }
        internal static List<Card> GetAllCards()
        {
            var returnValue = new List<Card>();
            foreach (var card in _cards)
                returnValue.Add(card.Value);
            return returnValue;
        }

        internal static List<int> GetAllCardCodes()
        {
            var returnValue = new List<int>();
            foreach (var card in _cards)
                returnValue.Add(card.Key);
            return returnValue;
        }

        private static void LoadCard(IDataRecord reader, bool render = false, bool isPreCards = false)
        {
            Card card = new(reader) 
            {
                isPre = isPreCards
            };
            if (!render)
            {
                //if (!_cards.ContainsKey(card.Id))
                //    _cards.Add(card.Id, card);
                _cards[card.Id] = card;
            }
            else
            {
                //if (!_cardsForRender.ContainsKey(card.Id))
                //    _cardsForRender.Add(card.Id, card);
                _cardsForRender[card.Id] = card;
            }
        }


        public static List<string> GetMiddleStrings(string str, string start, string end)
        {
            List<string> returnValue = new List<string>();
            Regex reg = new Regex("(?<=(" + start + "))[.\\s\\S]*?(?=(" + end + "))", RegexOptions.RightToLeft);
            while (reg.Match(str).Value != "")
            {
                string s = reg.Match(str).Value;
                returnValue.Add(s);
                str = str.Replace(start + s + end, "");
            }
            return returnValue;
        }

        public static List<string> setNameTail = new List<string>
        {
            "、",
            "卡",
            "怪兽",
            "魔法",
            "陷阱",
            "通常",
            "效果怪兽",
            "融合",
            "仪式",
            "灵魂",
            "同盟",
            "二重",
            "调整",
            "同调",
            "衍生物",
            "速攻",
            "永续",
            "装备",
            "场地",
            "反击",
            "反转",
            "卡通",
            "超量",
            "灵摆",
            "连接",
        };
        public static List<string> setNameHead = new List<string>
        {
            "带有"
        };

        static List<string> GetSetNamesInDescription(string input)
        {
            List <string> returnValue = new List<string>();
            foreach(string s in setNameHead)
            {
                List<string> setNames = GetMiddleStrings(input, s + "「", "」");
                for (int i = 0; i < setNames.Count; i++)
                {
                    if (returnValue.Contains(setNames[i]) == false)
                        returnValue.Add(setNames[i]);
                }
            }
            foreach (string s in setNameTail)
            {
                List<string> setNames = GetMiddleStrings(input, "「", "」" + s);
                for (int i = 0; i < setNames.Count; i++)
                {
                    if (returnValue.Contains(setNames[i]) == false)
                        returnValue.Add(setNames[i]);
                }
            }
            return returnValue;
        }
        internal static List<Card> Search
        (
            string getName,
            List<long> filters,
            Banlist banlist,
            string pack
        )
        {
            List<Card> returnValue = new List<Card>();
            string[] strings = getName.Split(' ');
            nameInSearch = getName;
            foreach (var item in _cards)
            {
                Card card = item.Value;
                if (!card.HasType(CardType.Token))
                {
                    bool pass = true;
                    foreach (string s in strings)
                    {
                        if (s.StartsWith("@"))
                        {
                            if (Regex.Replace(card.strSetName, s.Substring(1, s.Length - 1), "miaowu", RegexOptions.IgnoreCase) == card.strSetName)
                            {
                                pass = false;
                                break;
                            }
                        }
                        else if (
                                s != ""
                                && Regex.Replace(card.Name, s, "miaowu", RegexOptions.IgnoreCase) == card.Name
                                && Regex.Replace(card.Desc, s, "miaowu", RegexOptions.IgnoreCase) == card.Desc
                                && Regex.Replace(card.strSetName, s, "miaowu", RegexOptions.IgnoreCase) == card.strSetName
                                && card.Id.ToString() != s
                                )
                        {
                            pass = false;
                            break;
                        }
                    }
                    if (pass)
                    {
                        if (filters.Count == 0)
                            returnValue.Add(card);
                        else
                        {
                            //CardType
                            pass = false;
                            if (filters[0] == 0)
                                pass = true;
                            if (!pass && (card.Type & (uint)filters[0]) > 0)
                            {
                                if ((filters[0] & (long)CardType.Ritual) > 0)
                                {
                                    if ((filters[0] & (long)CardType.Spell) > 0 && card.HasType(CardType.Spell))
                                        pass = true;
                                    if ((filters[0] & (long)CardType.Trap) > 0 && card.HasType(CardType.Trap))
                                        pass = true;
                                    if (card.HasType(CardType.Monster))
                                        pass = true;
                                }
                                else
                                    pass = true;
                            }
                            if (pass)
                            {
                                //Attribute
                                pass = false;
                                if (filters[1] == 0)
                                    pass = true;
                                if (!pass && (card.HasType(CardType.Monster) && (card.Attribute & (uint)filters[1]) > 0))
                                    pass = true;
                                if (pass)
                                {
                                    //SpellType
                                    pass = false;
                                    if (filters[2] == 0)
                                        pass = true;
                                    if (!pass)
                                    {
                                        if ((filters[2] & (long)CardType.Spell) > 0)
                                            if(card.Type == 2)
                                                pass = true;
                                        if ((filters[2] & (long)CardType.Field) > 0)
                                            if (card.HasType(CardType.Field))
                                                pass = true;
                                        if ((filters[2] & (long)CardType.Equip) > 0)
                                            if (card.HasType(CardType.Equip))
                                                pass = true;
                                        if ((filters[2] & 0x8000000) > 0)
                                            if (card.HasType(CardType.Spell) && card.HasType(CardType.Continuous))
                                                pass = true;
                                        if ((filters[2] & (long)CardType.QuickPlay) > 0)
                                            if (card.HasType(CardType.QuickPlay))
                                                pass = true;
                                        if ((filters[2] & (long)CardType.Ritual) > 0)
                                            if (card.HasType(CardType.Spell) && card.HasType(CardType.Ritual))
                                                pass = true;
                                        if ((filters[2] & (long)CardType.Trap) > 0)
                                        {
                                            if (card.HasType(CardType.Trap)
                                                && !card.HasType(CardType.Continuous)
                                                && !card.HasType(CardType.Counter)
                                                )
                                                pass = true;
                                        }
                                        if ((filters[2] & 0x10000000) > 0)
                                            if (card.HasType(CardType.Trap) && card.HasType(CardType.Continuous))
                                                pass = true;
                                        if ((filters[2] & (long)CardType.Counter) > 0)
                                            if (card.HasType(CardType.Counter))
                                                pass = true;
                                    }
                                    if (pass)
                                    {
                                        //Race
                                        pass = false;
                                        if (filters[3] == 0)
                                            pass = true;
                                        if (!pass && card.HasType(CardType.Monster) && (card.Race & filters[3]) > 0)
                                            pass = true;
                                        if (pass)
                                        {
                                            //Ability
                                            pass = false;
                                            if (filters[4] == 0)
                                                pass = true;
                                            if (!pass && card.HasType(CardType.Monster) && (card.Type & filters[4]) > 0)
                                                pass = true;
                                            if(!pass && (filters[4] & 0x8000000) > 0)
                                                if (card.HasType(CardType.Monster) && !card.HasType(CardType.Effect))
                                                    pass = true;
                                            if (pass)
                                            {
                                                //Limit
                                                pass = false;
                                                if (filters[5] == 0)
                                                    pass = true;
                                                if (!pass)
                                                {
                                                    var permit = banlist.GetQuantity(card.Id);
                                                    if ((filters[5] & 0x1) > 0 && permit == 0)
                                                        pass = true;
                                                    else if ((filters[5] & 0x2) > 0 && permit == 1)
                                                        pass = true;
                                                    else if ((filters[5] & 0x4) > 0 && permit == 2)
                                                        pass = true;
                                                    else if ((filters[5] & 0x8) > 0 && permit == 3)
                                                        pass = true;
                                                }
                                                if (pass)
                                                {
                                                    //Pool
                                                    pass = false;
                                                    if (filters[6] == 0)
                                                        pass = true;
                                                    if (!pass)
                                                    {
                                                        if ((filters[6] & card.Ot) > 0)
                                                            pass = true;
                                                        if ((filters[6] & 16) > 0 && (card.Ot & 1) == 1 && (card.Ot & 2) == 0)
                                                            pass = true;
                                                        if ((filters[6] & 32) > 0 && (card.Ot & 1) == 0 && (card.Ot & 2) == 2)
                                                            pass = true;
                                                        if ((filters[6] & 64) > 0 && (card.Ot & 3) == 3)
                                                            pass = true;
                                                        if ((filters[6] & 128) > 0 && card.isPre)
                                                            pass = true;
                                                    }
                                                    if (pass)
                                                    {
                                                        //Effect
                                                        pass = false;
                                                        if (filters[7] == 0)
                                                            pass = true;
                                                        if(!pass && (card.Category & (uint)filters[7]) > 0)
                                                            pass = true;
                                                        if (pass)
                                                        {
                                                            //Rarity
                                                            pass = false;
                                                            if (filters[8] == 0 || filters[8] == 7)
                                                                pass = true;
                                                            if (!pass)
                                                                if ((filters[8] & (long)CardRarity.GetRarity(card.Id)) > 0)
                                                                    pass = true;
                                                            if (pass)
                                                            {
                                                                //Cutin
                                                                pass = false;
                                                                if (filters[9] == 0 || filters[9] == 3)
                                                                    pass = true;
                                                                if (!pass)
                                                                {
                                                                    bool found = false;
                                                                    foreach (var c in MonsterCutin.cards)
                                                                        if (c.Id == card.Id)
                                                                        {
                                                                            found = true;
                                                                            break;
                                                                        }
                                                                    if ((filters[9] & 1) > 0 && found)
                                                                        pass = true;
                                                                    if ((filters[9] & 2) > 0 && !found)
                                                                        pass = true;
                                                                }
                                                                if (pass)
                                                                {
                                                                    //Link Markers
                                                                    pass = false;
                                                                    if (filters[10] == 0)
                                                                        pass = true;
                                                                    if (!pass)
                                                                        if(card.HasType(CardType.Link))
                                                                        {
                                                                            pass = true;
                                                                            for (int i = 0; i < 9; i++)
                                                                            {
                                                                                if ((filters[10] >> i & 1) > 0 && (card.LinkMarker >> i & 1) == 0)
                                                                                    pass = false;
                                                                            }
                                                                        }
                                                                    if (pass)
                                                                    {
                                                                        if (JudgeInt((int)filters[11], (int)filters[12], card.Level))
                                                                            if (JudgeInt((int)filters[13], (int)filters[14], card.Attack))
                                                                                if (JudgeInt((int)filters[15], (int)filters[16], card.Defense))
                                                                                    if (JudgeInt((int)filters[17], (int)filters[18], card.LScale))
                                                                                        if (JudgeInt((int)filters[19], (int)filters[20], card.year))
                                                                                        {
                                                                                            if (pack == string.Empty)
                                                                                                returnValue.Add(card);
                                                                                            else
                                                                                            {
                                                                                                if (card.packFullName == pack)
                                                                                                    returnValue.Add(card);
                                                                                            }
                                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }

        internal static List<Card> AnnounceSearch(string announced, List<int> searchCodes)
        {
            List<Card> returnValue = new List<Card>();
            foreach(var item in _cards)
            {
                Card card = item.Value;
                if(announced == ""
                    || Regex.Replace(card.Name, announced, "miaowu", RegexOptions.IgnoreCase) != card.Name
                    || Regex.Replace(card.strSetName, announced, "miaowu", RegexOptions.IgnoreCase) != card.strSetName
                    || card.Id.ToString() == announced)
                {
                    if(searchCodes.Count == 0 || IsDeclarable(card, searchCodes))
                        returnValue.Add(card);
                }
            }
            nameInSearch = announced;
            returnValue.Sort(ComparisonOfCard());
            nameInSearch = "";
            return returnValue;
        }

        internal static List<Card> RelatedSearch(int code)
        {
            var cards = new List<Card>();
            var card = GetCard(code);
            if (card == null)
                return cards;
            card.strSetName = StringHelper.GetSetName(card.Setcode).Replace("【", "").Replace("】", "");

            List<string> names = new List<string>();
            names.Add(card.Name);
            List<string> setNames = GetSetNamesInDescription(card.Desc);
            if (!setNames.Contains(card.strSetName))
                setNames.Add(card.strSetName);

            var matches = GetMiddleStrings(card.Desc, "「", "」");
            foreach (var match in matches)
                if (!names.Contains(match.ToString()))
                    names.Add(match.ToString());
            foreach (string s in setNames)
                if (names.Contains(s))
                    names.Remove(s);

            names.Remove("");
            setNames.Remove("");

            string result = "";
            foreach(string s in setNames)
                result += s + "\r\n";

            result = "";
            foreach (string s in names)
                result += s + "\r\n";

            List<int> setCodes = new List<int>();
            foreach (var s in setNames)
                setCodes.Add(StringHelper.GetSetNameCode(s));

            foreach (var item in _cards)
            {
                if (card.Id != item.Value.Id && !item.Value.HasType(CardType.Token))
                {
                    bool pass = false;
                    foreach (var n in names)
                    {
                        if (
                            Regex.Replace(item.Value.Name, n, "miaowu", RegexOptions.IgnoreCase) != item.Value.Name
                            || Regex.Replace(item.Value.Desc, "「" + n + "」", "miaowu", RegexOptions.IgnoreCase) != item.Value.Desc
                            || Regex.Replace(item.Value.strSetName, n, "miaowu", RegexOptions.IgnoreCase) != item.Value.strSetName
                            )
                        {
                            pass = true;
                            break;
                        }
                    }
                    if (pass == false)
                    {
                        for (int i = 0; i < setNames.Count; i++)
                        {
                            if (
                                Regex.Replace(item.Value.Desc, "「" + setNames[i] + "」", "miaowu", RegexOptions.IgnoreCase) != item.Value.Desc
                                //|| Regex.Replace(item.Value.strSetName, setNames[i], "miaowu", RegexOptions.IgnoreCase) != item.Value.strSetName
                                || (setCodes[i] != 0)
                                    && (setCodes[i] - item.Value.Setcode == 0 || ~Math.Abs(setCodes[i] - item.Value.Setcode) == 0x999)
                                )
                            {
                                pass = true;
                                break;
                            }
                        }
                    }
                    if (pass)
                        cards.Add(item.Value);
                }
            }
            cards.Sort(ComparisonOfCard());
            return cards;
        }


        public static string nameInSearch = "";

        static bool JudgeInt(int min, int max, int raw)
        {
            bool re = true;
            if (min == -233 && max == -233)
            {
                re = true;
            }

            if (min == -233 && max != -233)
            {
                re = max == raw;
            }

            if (min != -233 && max == -233)
            {
                re = min == raw;
            }

            if (min != -233 && max != -233)
            {
                re = min <= raw && raw <= max;
            }

            return re;
        }

        private static bool IsDeclarable(Card card, List<int> getsearchCode)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < getsearchCode.Count; i++)
            {
                switch (getsearchCode[i])
                {
                    case (int)SearchCode.OPCODE_ADD:
                        if (stack.Count >= 2)
                        {
                            int rhs = stack.Pop();
                            int lhs = stack.Pop();
                            stack.Push(lhs + rhs);
                        }

                        break;
                    case (int)SearchCode.OPCODE_SUB:
                        if (stack.Count >= 2)
                        {
                            int rhs = stack.Pop();
                            int lhs = stack.Pop();
                            stack.Push(lhs - rhs);
                        }

                        break;
                    case (int)SearchCode.OPCODE_MUL:
                        if (stack.Count >= 2)
                        {
                            int rhs = stack.Pop();
                            int lhs = stack.Pop();
                            stack.Push(lhs * rhs);
                        }

                        break;
                    case (int)SearchCode.OPCODE_DIV:
                        if (stack.Count >= 2)
                        {
                            int rhs = stack.Pop();
                            int lhs = stack.Pop();
                            stack.Push(lhs / rhs);
                        }

                        break;
                    case (int)SearchCode.OPCODE_AND:
                        if (stack.Count >= 2)
                        {
                            int rhs = stack.Pop();
                            int lhs = stack.Pop();
                            bool b0 = rhs != 0;
                            bool b1 = lhs != 0;
                            if (b0 && b1)
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_OR:
                        if (stack.Count >= 2)
                        {
                            int rhs = stack.Pop();
                            int lhs = stack.Pop();
                            bool b0 = rhs != 0;
                            bool b1 = lhs != 0;
                            if (b0 || b1)
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_NEG:
                        if (stack.Count >= 1)
                        {
                            int rhs = stack.Pop();
                            stack.Push(-rhs);
                        }

                        break;
                    case (int)SearchCode.OPCODE_NOT:
                        if (stack.Count >= 1)
                        {
                            int rhs = stack.Pop();
                            bool b0 = rhs != 0;
                            if (b0)
                            {
                                stack.Push(0);
                            }
                            else
                            {
                                stack.Push(1);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_ISCODE:
                        if (stack.Count >= 1)
                        {
                            int code = stack.Pop();
                            bool b0 = code == card.Id;
                            if (b0)
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_ISSETCARD:
                        if (stack.Count >= 1)
                        {
                            if (IfSetCard(stack.Pop(), card.Setcode))
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_ISTYPE:
                        if (stack.Count >= 1)
                        {
                            if ((stack.Pop() & card.Type) > 0)
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_ISRACE:
                        if (stack.Count >= 1)
                        {
                            if ((stack.Pop() & card.Race) > 0)
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    case (int)SearchCode.OPCODE_ISATTRIBUTE:
                        if (stack.Count >= 1)
                        {
                            if ((stack.Pop() & card.Attribute) > 0)
                            {
                                stack.Push(1);
                            }
                            else
                            {
                                stack.Push(0);
                            }
                        }

                        break;
                    default:
                        stack.Push(getsearchCode[i]);
                        break;
                }
            }

            if (stack.Count != 1 || stack.Pop() == 0)
                return false;
            return
                card.Id == (int)TwoNameCards.CARD_MARINE_DOLPHIN
                ||
                card.Id == (int)TwoNameCards.CARD_TWINKLE_MOSS
                ||
                (!(card.Alias != 0)
                 && ((card.Type & ((int)CardType.Monster + (int)CardType.Token)))
                 != ((int)CardType.Monster + (int)CardType.Token));
        }

        public static bool IfSetCard(int setCodeToAnalyse, long setCodeFromCard)
        {
            bool res = false;
            int settype = setCodeToAnalyse & 0xfff;
            int setsubtype = setCodeToAnalyse & 0xf000;
            long sc = setCodeFromCard;
            while (sc != 0)
            {
                if ((sc & 0xfff) == settype && (sc & 0xf000 & setsubtype) == setsubtype)
                    res = true;
                sc = sc >> 16;
            }

            return res;
        }

        internal static Comparison<Card> ComparisonOfCard()
        {
            return (left, right) =>
            {
                int a = 1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        //if ((left.Type >> 3) > (right.Type >> 3))
                        //{
                        //    a = 1;
                        //}
                        //else if ((left.Type >> 3) < (right.Type >> 3))
                        //{
                        //    a = -1;
                        //}
                        if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                        {
                            a = -1;
                        }
                        else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                        {
                            a = 1;
                        }
                        else
                        {
                            if (left.Level > right.Level)
                            {
                                a = -1;
                            }
                            else if (left.Level < right.Level)
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Attack > right.Attack)
                                {
                                    a = -1;
                                }
                                else if (left.Attack < right.Attack)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCardReverse()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        //if ((left.Type >> 3) > (right.Type >> 3))
                        //{
                        //    a = -1;
                        //}
                        //else if ((left.Type >> 3) < (right.Type >> 3))
                        //{
                        //    a = 1;
                        //}
                        if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                        {
                            a = 1;
                        }
                        else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                        {
                            a = -1;
                        }
                        else
                        {
                            if (left.Level > right.Level)
                            {
                                a = -1;
                            }
                            else if (left.Level < right.Level)
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Attack > right.Attack)
                                {
                                    a = -1;
                                }
                                else if (left.Attack < right.Attack)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_ATK_Down()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        if (left.Attack > right.Attack)
                        {
                            a = -1;
                        }
                        else if (left.Attack < right.Attack)
                        {
                            a = 1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Level > right.Level)
                                {
                                    a = -1;
                                }
                                else if (left.Level < right.Level)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_ATK_Up()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        if (left.Attack > right.Attack)
                        {
                            a = 1;
                        }
                        else if (left.Attack < right.Attack)
                        {
                            a = -1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Level > right.Level)
                                {
                                    a = 1;
                                }
                                else if (left.Level < right.Level)
                                {
                                    a = -1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_DEF_Down()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        if (left.Defense > right.Defense)
                        {
                            a = -1;
                        }
                        else if (left.Defense < right.Defense)
                        {
                            a = 1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Level > right.Level)
                                {
                                    a = -1;
                                }
                                else if (left.Level < right.Level)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_DEF_Up()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        if (left.Defense > right.Defense)
                        {
                            a = 1;
                        }
                        else if (left.Defense < right.Defense)
                        {
                            a = -1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Level > right.Level)
                                {
                                    a = 1;
                                }
                                else if (left.Level < right.Level)
                                {
                                    a = -1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_LV_Down()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        if (left.Level > right.Level)
                        {
                            a = -1;
                        }
                        else if (left.Level < right.Level)
                        {
                            a = 1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Attack > right.Attack)
                                {
                                    a = -1;
                                }
                                else if (left.Attack < right.Attack)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_LV_Up()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    if ((left.Type & 7) < (right.Type & 7))
                    {
                        a = -1;
                    }
                    else if ((left.Type & 7) > (right.Type & 7))
                    {
                        a = 1;
                    }
                    else
                    {
                        if (left.Level > right.Level)
                        {
                            a = 1;
                        }
                        else if (left.Level < right.Level)
                        {
                            a = -1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Attack > right.Attack)
                                {
                                    a = 1;
                                }
                                else if (left.Attack < right.Attack)
                                {
                                    a = -1;
                                }
                                else
                                {
                                    if (left.Attribute > right.Attribute)
                                    {
                                        a = 1;
                                    }
                                    else if (left.Attribute < right.Attribute)
                                    {
                                        a = -1;
                                    }
                                    else
                                    {
                                        if (left.Race > right.Race)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Race < right.Race)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Category > right.Category)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Category < right.Category)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Id > right.Id)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Id < right.Id)
                                                {
                                                    a = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_Rarity_Up()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    var rarity = CardRarity.GetRarity(left.Id);
                    if ((int)CardRarity.GetRarity(left.Id) > (int)CardRarity.GetRarity(right.Id))
                    {
                        a = 1;
                    }
                    else if ((int)CardRarity.GetRarity(left.Id) < (int)CardRarity.GetRarity(right.Id))
                    {
                        a = -1;
                    }
                    else
                    {
                        if ((left.Type & 7) < (right.Type & 7))
                        {
                            a = -1;
                        }
                        else if ((left.Type & 7) > (right.Type & 7))
                        {
                            a = 1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Level > right.Level)
                                {
                                    a = -1;
                                }
                                else if (left.Level < right.Level)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attack > right.Attack)
                                    {
                                        a = -1;
                                    }
                                    else if (left.Attack < right.Attack)
                                    {
                                        a = 1;
                                    }
                                    else
                                    {
                                        if (left.Attribute > right.Attribute)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Attribute < right.Attribute)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Race > right.Race)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Race < right.Race)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Category > right.Category)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Category < right.Category)
                                                {
                                                    a = -1;
                                                }
                                                else
                                                {
                                                    if (left.Id > right.Id)
                                                    {
                                                        a = 1;
                                                    }
                                                    else if (left.Id < right.Id)
                                                    {
                                                        a = -1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }
        internal static Comparison<Card> ComparisonOfCard_Rarity_Down()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.Name == nameInSearch && right.Name != nameInSearch)
                {
                    a = -1;
                }
                else if (right.Name == nameInSearch && left.Name != nameInSearch)
                {
                    a = 1;
                }
                else
                {
                    var rarity = CardRarity.GetRarity(left.Id);
                    if ((int)CardRarity.GetRarity(left.Id) > (int)CardRarity.GetRarity(right.Id))
                    {
                        a = -1;
                    }
                    else if ((int)CardRarity.GetRarity(left.Id) < (int)CardRarity.GetRarity(right.Id))
                    {
                        a = 1;
                    }
                    else
                    {
                        if ((left.Type & 7) < (right.Type & 7))
                        {
                            a = -1;
                        }
                        else if ((left.Type & 7) > (right.Type & 7))
                        {
                            a = 1;
                        }
                        else
                        {
                            //if ((left.Type >> 3) > (right.Type >> 3))
                            //{
                            //    a = 1;
                            //}
                            //else if ((left.Type >> 3) < (right.Type >> 3))
                            //{
                            //    a = -1;
                            //}
                            if ((left.Type & 0x58020f0) < (right.Type & 0x58020f0))
                            {
                                a = -1;
                            }
                            else if ((left.Type & 0x58020f0) > (right.Type & 0x58020f0))
                            {
                                a = 1;
                            }
                            else
                            {
                                if (left.Level > right.Level)
                                {
                                    a = -1;
                                }
                                else if (left.Level < right.Level)
                                {
                                    a = 1;
                                }
                                else
                                {
                                    if (left.Attack > right.Attack)
                                    {
                                        a = -1;
                                    }
                                    else if (left.Attack < right.Attack)
                                    {
                                        a = 1;
                                    }
                                    else
                                    {
                                        if (left.Attribute > right.Attribute)
                                        {
                                            a = 1;
                                        }
                                        else if (left.Attribute < right.Attribute)
                                        {
                                            a = -1;
                                        }
                                        else
                                        {
                                            if (left.Race > right.Race)
                                            {
                                                a = 1;
                                            }
                                            else if (left.Race < right.Race)
                                            {
                                                a = -1;
                                            }
                                            else
                                            {
                                                if (left.Category > right.Category)
                                                {
                                                    a = 1;
                                                }
                                                else if (left.Category < right.Category)
                                                {
                                                    a = -1;
                                                }
                                                else
                                                {
                                                    if (left.Id > right.Id)
                                                    {
                                                        a = 1;
                                                    }
                                                    else if (left.Id < right.Id)
                                                    {
                                                        a = -1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return a;
            };
        }

    }

    internal static class PacksManager
    {
        public class PackName
        {
            public string fullName;
            public string shortName;
            public int year;
            public int month;
            public int day;
        }

        public static List<PackName> packs = new List<PackName>();

        static Dictionary<string, string> pacDic = new Dictionary<string, string>();

        static string path = "Data/pack";

        internal static void Initialize()
        {
            if (Directory.Exists(path))
            {
                var fileInfos = new DirectoryInfo(path).GetFiles();
                foreach (var file in fileInfos)
                    if (file.Name.ToLower().EndsWith(".db"))
                        LoadDataBase(path + Program.slash + file.Name);
                InitializeSec();
            }
        }

        internal static void LoadDataBase(string filePath)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + filePath))
            {
                connection.Open();
                using (IDbCommand command = new SqliteCommand("SELECT pack.* FROM pack;", connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                int Id = (int) reader.GetInt64(0);
                                Card c = CardsManager.GetCardRaw(Id);
                                if (c != null)
                                {
                                    string temp = reader.GetString(1);
                                    c.packFullName = reader.GetString(2);
                                    string[] mats = temp.Split('-');
                                    if (mats.Length > 1)
                                        c.packShortName = mats[0];
                                    else
                                        c.packShortName = c.packFullName.Length > 10 ? c.packFullName.Substring(0, 10) + "..." : c.packFullName;
                                    c.reality = reader.GetString(3);
                                    temp = reader.GetString(4);
                                    mats = temp.Split('/');
                                    if (mats.Length == 3)
                                    {
                                        c.month = int.Parse(mats[0]);
                                        c.day = int.Parse(mats[1]);
                                        c.year = int.Parse(mats[2]);
                                    }
                                    mats = temp.Split('-');
                                    if (mats.Length == 3)
                                    {
                                        c.year = int.Parse(mats[0]);
                                        c.month = int.Parse(mats[1]);
                                        c.day = int.Parse(mats[2]);
                                    }
                                    c.packFullName = c.year + "-" + c.month.ToString("D2") + "-" + c.day.ToString("D2") + " " + c.packFullName;

                                    if (!pacDic.ContainsKey(c.packFullName))    
                                    {
                                        pacDic.Add(c.packFullName, c.packShortName);
                                        PackName p = new PackName();
                                        p.day = c.day;
                                        p.year = c.year;
                                        p.month = c.month;
                                        p.fullName = c.packFullName;
                                        p.shortName = c.packShortName;
                                        packs.Add(p);
                                    }
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
            }
        }

        internal static void InitializeSec()
        {
            packs.Sort((left, right) =>
            {
                if (left.year > right.year)
                {
                    return -1;
                }

                if (left.year < right.year)
                {
                    return 1;
                }

                if (left.month > right.month)
                {
                    return -1;
                }

                if (left.month < right.month)
                {
                    return 1;
                }

                if (left.day > right.day)
                {
                    return -1;
                }

                if (left.day < right.day)
                {
                    return 1;
                }

                return 1;
            });
        }
    }
}