using System;
using System.Data;
using MDPro3.Utility;
using MDPro3.YGOSharp.OCGWrapper.Enums;

namespace MDPro3.YGOSharp
{
    public class Card
    {
        public int Id;
        public int Ot;
        public int Alias;
        public long Setcode;
        public int Type;

        public int Level;
        public int LScale;
        public int RScale;
        public int LinkMarker;

        public int Attribute;
        public int Race;
        public int Attack;
        public int Defense;
        public int rAttack;
        public int rDefense;
        public int Reason;
        public int ReasonCard;

        public Int64 Category;
        public string Name;
        public string Desc;
        public string[] Str;

        public string packShortName = "";
        public string packFullName = "";
        public string reality = "";
        public string strSetName = "";  
        public int year = 0;
        public int month = 0;
        public int day = 0;
        public bool isPre = false;

        public Card()
        {
            Id = 0;
            Str = new string[16];
            Name = CardsManager.nullName;
            Desc = CardsManager.nullString;
        }

        public Card Clone()
        {
            Card r = new Card();
            r.Id = Id;
            r.Ot = Ot;
            r.Alias = Alias;
            r.Setcode = Setcode;
            r.Type = Type;
            r.Level = Level;
            r.LScale = LScale;
            r.RScale = RScale;
            r.LinkMarker = LinkMarker;
            r.Attribute = Attribute;
            r.Race = Race;
            r.Attack = Attack;
            r.Defense = Defense;
            r.rAttack = rAttack;
            r.rDefense = rDefense;
            r.Category = Category;
            r.Name = Name;
            r.Desc = Desc;
            r.Str = new string[Str.Length];
            r.isPre = isPre;

            for (int ii = 0; ii < Str.Length; ii++)
            {
                r.Str[ii] = Str[ii];
            }
            return r;
        }

        public void  CloneTo(Card r)
        {
            r.Id = Id;
            r.Ot = Ot;
            r.Alias = Alias;
            r.Setcode = Setcode;
            r.Type = Type;
            r.Level = Level;
            r.LScale = LScale;
            r.RScale = RScale;
            r.Attribute = Attribute;
            r.Race = Race;
            r.Attack = Attack;
            r.Defense = Defense;
            r.rAttack = rAttack;
            r.rDefense = rDefense;
            r.Category = Category;
            r.Name = Name;
            r.Desc = Desc;
            r.Str = new string[Str.Length];
            r.isPre = isPre;

            for (int ii = 0; ii < Str.Length; ii++)
            {
                r.Str[ii] = Str[ii];
            }
        }

        public static Card Get(int id)
        {
            return CardsManager.GetCard(id);
        }

        public bool HasType(CardType type)
        {
            return ((Type & (int)type) != 0);
        }

        public bool HasLinkMarker(CardLinkMarker dir)
        {
            return (LinkMarker & (int)dir) != 0;
        }

        public bool IsExtraCard()
        {
            return (HasType(CardType.Fusion) || HasType(CardType.Synchro) || HasType(CardType.Xyz) || HasType(CardType.Link));
        }

        public int GetLinkCount()
        {
            int returnValue = 0;
            for (int i = 0; i < 9; i++)
                if (((LinkMarker >> i) & 1u) > 0 && i != 4)
                    returnValue++;
            return returnValue;
        }

        internal Card(IDataRecord reader)
        {
            Str = new string[16];
            Id = (int)reader.GetInt64(0);
            Ot = reader.GetInt32(1);
            Alias = (int)reader.GetInt64(2);
            Setcode = reader.GetInt64(3);
            Type = (int)reader.GetInt64(4);
            Attack = reader.GetInt32(5);
            Defense = reader.GetInt32(6);
            rAttack = this.Attack;
            rDefense = this.Defense;
            long Level_raw = reader.GetInt64(7);
            Level = (int)Level_raw & 0xff;
            LScale = (int)((Level_raw >> 0x18) & 0xff);
            RScale = (int)((Level_raw >> 0x10) & 0xff);
            LinkMarker = this.Defense;
            Race = reader.GetInt32(8);
            Attribute = reader.GetInt32(9);
            Category = reader.GetInt64(10);
            Name = reader.GetString(12);
            Desc = reader.GetString(13);

            for (int ii = 0; ii < 0x10; ii++)
            {
                Str[ii] = reader.GetString(14 + ii);
            }
        }

        public enum LevelType
        {
            Level,
            Rank,
            Link
        }

        public LevelType GetLevelType()
        {
            if (HasType(CardType.Link))
                return LevelType.Link;
            else if (HasType(CardType.Xyz))
                return LevelType.Rank;
            else
                return LevelType.Level;
        }

        public string GetAttackString()
        {
            return Attack == -2 ? "?" : Attack.ToString();
        }

        public string GetDefenseString()
        {
            return Defense == -2 ? "?" : Defense.ToString();
        }

        public string GetDescription(bool withSetName = false)
        {
            if (HasType(CardType.Pendulum))
            {
                var texts = GetDescriptionSplit();
                string monster = InterString.Get("【怪兽效果】");
                if (!HasType(CardType.Effect))
                    monster = InterString.Get("【怪兽描述】");

                return (withSetName ? GetSetName() : string.Empty) + InterString.Get("【灵摆效果】") + "\n" + texts[0] + "\n" + monster + "\n" + texts[1];
            }
            else
                return (withSetName ? GetSetName() : string.Empty) + Desc;
        }

        public string GetMonsterDescription(bool render = false)
        {
            if (HasType(CardType.Pendulum))
                return GetDescriptionSplit(render)[1];
            else
                return Desc;
        }

        public string GetPendulumDescription(bool render = false)
        {
            if (HasType(CardType.Pendulum))
                return GetDescriptionSplit(render)[0];
            else
                return string.Empty;
        }

        /// <summary>
        /// 仅在卡片是灵摆卡时使用
        /// </summary>
        /// <param name="render"></param>
        /// <returns></returns>
        private string[] GetDescriptionSplit(bool render = false)
        {
            var returnValue = new string[2];
            returnValue[0] = string.Empty;
            returnValue[1] = string.Empty;
            var lines = Desc.Replace("\r", "").Split('\n');
            var language = render ? Language.GetCardConfig() : Language.GetConfig();

            int beforePendulum = 1;
            int splitLines = 1;
            string symbol = "【";
            int monsterStart = 0;

            if (language == Language.English)
            {
                beforePendulum = 2;
                splitLines = 2;
                symbol = "[";
            }
            else if (language == Language.Spanish)
            {
                beforePendulum = 2;
                splitLines = 2;
            }
            else if (language == Language.TraditionalChinese)
            {
                beforePendulum = 0;
            }

            for (int i = beforePendulum; i < lines.Length; i++)
                if (lines[i].StartsWith(symbol))
                {
                    monsterStart = i;
                    break;
                }

            for (int i = beforePendulum; i < lines.Length; i++)
            {
                if (i <= monsterStart - splitLines)
                {
                    if (monsterStart - i == splitLines)
                        returnValue[0] += lines[i];
                    else
                        returnValue[0] += lines[i] + "\r\n";
                }
                else if (i > monsterStart)
                {
                    if (i == lines.Length - 1)
                        returnValue[1] += lines[i];
                    else
                        returnValue[1] += lines[i] + "\r\n";
                }
            }
            if (language == Language.Spanish)
                returnValue[0] = returnValue[0].Replace("-n/a-", string.Empty);
            return returnValue;
        }

        public string GetSetName()
        {
            var returnValue = StringHelper.GetSetName(Setcode, true);
            if (returnValue.Length > 0)
            {
                returnValue = "<color=#FFF000>" +
                    StringHelper.GetUnsafe(1329) + returnValue + "</color>" + "\r\n";
            }
            return returnValue;
        }

        public bool IsSameCard(Card data)
        {
            return GetOriginalID() == data.GetOriginalID();
        }

        public int GetOriginalID()
        {
            if(Alias == 0)
                return Id;
            else
                return Alias;
        }
    }
}