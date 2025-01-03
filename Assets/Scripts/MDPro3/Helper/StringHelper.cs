using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.YGOSharp;
using MDPro3.Utility;

namespace MDPro3
{
    public static class StringHelper
    {
        public static List<HashedString> hashedStrings = new List<HashedString>();
        public static List<HashedString> hashedStringsForRender = new List<HashedString>();
        public static List<HashedString> setNames = new List<HashedString>();

        public static int StringToInt(string str)
        {
            var return_value = 0;
            try
            {
                if (str.Length > 2 && str.Substring(0, 2) == "0x")
                    return_value = Convert.ToInt32(str, 16);
                else
                    return_value = int.Parse(str);
            }
            catch (Exception)
            {
            }

            return return_value;
        }

        public static void Initialize()
        {
            var language = Language.GetConfig();
            var path = Program.localesPath + language + "/strings.conf";
            var text = File.ReadAllText(path);
            if (Config.GetBool("Expansions", true))
            {
                foreach (var conf in Directory.GetFiles("Expansions", "*.conf"))
                    if(!conf.ToLower().EndsWith("lflist.conf"))
                        text += "\r\n" + File.ReadAllText(conf);
                foreach (var zip in ZipHelper.zips)
                {
                    if (zip.Name.ToLower().EndsWith("script.zip"))
                        continue;
                    foreach (var file in zip.EntryFileNames)
                    {
                        if (file.ToLower().EndsWith(".conf")
                            && !file.ToLower().EndsWith("lflist.conf"))
                        {
                            var ms = new MemoryStream();
                            var e = zip[file];
                            e.Extract(ms);
                            text += "\r\n" + Encoding.UTF8.GetString(ms.ToArray());
                        }
                    }
                }
            }

            language = Language.GetCardConfig();
            path = Program.localesPath + language + "/strings.conf";
            string textForRender = File.ReadAllText(path);
            if (Config.Get("Expansions", "1") == "1")
            {
                foreach (var conf in Directory.GetFiles("Expansions", "*.conf"))
                    textForRender += "\r\n" + File.ReadAllText(conf);
                foreach (var zip in ZipHelper.zips)
                {
                    if (zip.Name.ToLower().EndsWith("script.zip"))
                        continue;
                    foreach (var file in zip.EntryFileNames)
                    {
                        if (file.ToLower().EndsWith(".conf"))
                        {
                            var ms = new MemoryStream();
                            var e = zip[file];
                            e.Extract(ms);
                            textForRender += "\r\n" + Encoding.UTF8.GetString(ms.ToArray());
                        }
                    }
                }
            }

            InitializeContent(text, textForRender);
        }

        public static void InitializeContent(string text, string textForRender)
        {
            var st = text.Replace("\r", "");
            var lines = st.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            hashedStrings.Clear();
            setNames.Clear();
            foreach (var line in lines)
                if (line.Length > 1 && line.Substring(0, 1) == "!")
                {
                    var mats = line.Substring(1, line.Length - 1).Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (mats.Length > 2)
                    {
                        var a = new HashedString();
                        a.region = mats[0];
                        try
                        {
                            a.hashCode = StringToInt(mats[1]);
                        }
                        catch (Exception e)
                        {
                            MessageManager.Cast(e.ToString());
                        }

                        a.content = "";
                        for (var i = 2; i < mats.Length; i++) a.content += mats[i] + " ";
                        a.content = a.content.Substring(0, a.content.Length - 1);
                        if (Get(a.region, a.hashCode) == "")
                        {
                            hashedStrings.Add(a);
                            if (a.region == "setname") setNames.Add(a);
                        }
                    }
                }
            hashedStringsForRender.Clear();
            st = textForRender.Replace("\r", "");
            lines = st.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
                if (line.Length > 1 && line.Substring(0, 1) == "!")
                {
                    var mats = line.Substring(1, line.Length - 1).Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (mats.Length > 2)
                    {
                        var a = new HashedString();
                        a.region = mats[0];
                        try
                        {
                            a.hashCode = StringToInt(mats[1]);
                        }
                        catch (Exception e)
                        {
                            MessageManager.Cast(e.ToString());
                        }

                        a.content = "";
                        for (var i = 2; i < mats.Length; i++)
                            a.content += mats[i] + " ";
                        a.content = a.content.Substring(0, a.content.Length - 1);
                        if (Get(a.region, a.hashCode, true) == "")
                            hashedStringsForRender.Add(a);
                    }
                }
        }

        public static string Get(string region, int hashCode, bool render = false)
        {
            var re = "";
            foreach (var s in render ? hashedStringsForRender : hashedStrings)
                if (s.region == region && s.hashCode == hashCode)
                {
                    re = s.content;
                    break;
                }
            return re;
        }

        internal static string GetUnsafe(int hashCode, bool render = false)
        {
            var re = "";
            foreach (var s in render ? hashedStringsForRender : hashedStrings)
                if (s.region == "system" && s.hashCode == hashCode)
                {
                    re = s.content;
                    break;
                }

            return re;
        }
        internal static string Get(int description)
        {
            var a = "";
            if (description < 10000)
            {
                a = Get("system", description);
            }
            else
            {
                var code = description >> 4;
                var index = description & 0xf;
                try
                {
                    a = CardsManager.Get(code).Str[index];
                }
                catch (Exception e)
                {
                    MessageManager.Cast(e.ToString());
                }
            }

            return a;
        }

        internal static string FormatLocation(uint location, uint sequence)
        {
            if (location == 0x8)
            {
                if (sequence < 5)
                    return Get(1003);
                if (sequence == 5)
                    return Get(1008);
                return Get(1009);
            }

            uint filter = 1;
            var i = 1000;
            for (; filter != 0x100 && filter != location; filter <<= 1)
                ++i;
            if (filter == location)
                return Get(i);
            return "???";
        }

        internal static string FormatLocation(GPS gps)
        {
            return FormatLocation(gps.location, gps.sequence);
        }

        public class HashedString
        {
            public string content = "";
            public int hashCode;
            public string region = "";
        }

        public static string Attribute(long attribute)
        {
            var r = "";
            var passFirst = false;
            for (int i = 0; i < 7; i++)
                if ((attribute & (1u << i)) > 0)
                {
                    if (passFirst) r += Program.slash;
                    r += GetUnsafe(1010 + i);
                    passFirst = true;
                }
            return r;
        }
        public static string Race(long race, bool render = false)
        {
            var r = "";
            var passFirst = false;
            for (var i = 0; i < 26; i++)
                if ((race & (1 << i)) > 0)
                {
                    if (passFirst) r += Program.slash;
                    r += GetUnsafe(1020 + i, render);
                    passFirst = true;
                }
            return r;
        }
        public static string Zone(long data)
        {
            var strs = new List<string>();
            for (var filter = 0x1L; filter <= 0x1L << 32; filter <<= 1)
            {
                var str = "";
                var s = filter & data;
                if (s != 0)
                {
                    if ((s & 0x60) != 0)
                    {
                        str += GetUnsafe(1081);
                        data &= ~0x600000;
                    }
                    else if ((s & 0xffff) != 0)
                    {
                        str += GetUnsafe(102);
                    }
                    else if ((s & 0xffff0000) != 0)
                    {
                        str += GetUnsafe(103);
                        s >>= 16;
                    }

                    if ((s & 0x1f) != 0)
                    {
                        str += GetUnsafe(1002);
                    }
                    else if ((s & 0xff00) != 0)
                    {
                        s >>= 8;
                        if ((s & 0x1f) != 0)
                            str += GetUnsafe(1003);
                        else if ((s & 0x20) != 0)
                            str += GetUnsafe(1008);
                        else if ((s & 0xc0) != 0)
                            str += GetUnsafe(1009);
                    }

                    var seq = 1;
                    for (var i = 0x1; i < 0x100; i <<= 1)
                    {
                        if ((s & i) != 0)
                            break;
                        ++seq;
                    }

                    str += "(" + seq + ")";
                    strs.Add(str);
                }
            }

            return string.Join(", ", strs.ToArray());

        }

        public static string MainType(long a, bool render = false)
        {
            var r = "";
            var passFirst = false;
            for (var i = 0; i < 3; i++)
                if ((a & (1 << i)) > 0)
                {
                    if (passFirst) r += Program.slash;
                    r += GetUnsafe(1050 + i, render);
                    passFirst = true;
                }
            return r;
        }

        public static string SecondType(long a, bool render = false)
        {
            var start = "";
            var end = "";
            if ((a & 0x68020C0) > 0)
            {
                for (var i = 4; i < 27; i++)
                    if (((a & 0x68020C0) & (1 << i)) > 0)
                    {
                        start += Program.slash + GetUnsafe(1050 + i, render);
                        break;
                    }
                a -= a & 0x68020C0;
            }
            if ((a & (long)CardType.Pendulum) > 0)
            {
                start += Program.slash + GetUnsafe(1074, render);
                a -= (long)CardType.Pendulum;
            }
            if ((a & 0x30) > 0)
            {
                for (var i = 4; i < 6; i++)
                    if ((a & (1 << i)) > 0)
                    {
                        end += Program.slash + GetUnsafe(1050 + i, render);
                        break;
                    }
                a -= a & 0x30;
            }
            for (var i = 4; i < 27; i++)
                if ((a & (1 << i)) > 0)
                    start += Program.slash + GetUnsafe(1050 + i, render);
            var returnValue = start + end;
            if (returnValue == string.Empty)
                returnValue = GetUnsafe(1054, render);
            else
                returnValue = returnValue.Substring(1, returnValue.Length - 1);

            return returnValue;
        }

        public static string GetType(Card data, bool render = false, bool rushDuel = false)
        {
            var re = string.Empty;
            if (data.Id == 0)
                return re;

            var bracketLeft = "【";
            var bracketRight = "】";
            if (render && Language.CardNeedSmallBracket())
            {
                bracketLeft = "[";
                bracketRight = "]";
            }

            var origin = render ? CardsManager.GetRenderCard(data.Id) : CardsManager.Get(data.Id);
            try
            {
                if (CardDescription.WhetherCardIsMonster(data))
                {
                    if (data.Race != origin.Race)
                        re = bracketLeft + "<color=#FD3E08>" + InterString.Get("[?]族", Race(data.Race)) + "</color>" + Program.slash + SecondType(data.Type) + bracketRight;
                    else
                        re = bracketLeft + InterString.Get("[?]族", Race(data.Race, render), render) + Program.slash + SecondType(data.Type, render) + bracketRight;
                }
                else
                {
                    if (rushDuel)
                    {
                        re = bracketLeft;
                        if (data.HasType(CardType.Spell))
                            re += InterString.Get("魔法卡", render);
                        else
                            re += InterString.Get("陷阱卡", render);

                        re = re.Replace("SPELL CARD", "Spell Card")
                                    .Replace("TRAP CARD", "Trap Card")
                                    .Replace("CARTA MÁGICA", "Carta Mágica")
                                    .Replace("CARTA TRAMPA", "Carta Trampa");

                        var secondType = SecondType(data.Type, render);
                        if (secondType != GetUnsafe(1054, render))
                        {
                            re += Program.slash + secondType;

                            if (data.HasType(CardType.Equip))
                                re += "<Sprite=0>";
                            if (data.HasType(CardType.QuickPlay))
                                re += "<Sprite=1>";
                            if (data.HasType(CardType.Field))
                                re += "<Sprite=2>";
                            if (data.HasType(CardType.Ritual))
                                re += "<Sprite=3>";
                            if (data.HasType(CardType.Continuous))
                                re += "<Sprite=4>";
                            if (data.HasType(CardType.Counter))
                                re += "<Sprite=5>";
                        }
                        re += bracketRight;
                    }
                    else
                    {
                        if (render)
                        {
                            re = bracketLeft;
                            if (data.HasType(CardType.Spell))
                                re += InterString.Get("魔法卡", render);
                            else
                                re += InterString.Get("陷阱卡", render);

                            var secondType = SecondType(data.Type, render);
                            if (secondType != GetUnsafe(1054, render))
                            {
                                if (data.HasType(CardType.Equip))
                                    re += "<Sprite=0>";
                                if (data.HasType(CardType.QuickPlay))
                                    re += "<Sprite=1>";
                                if (data.HasType(CardType.Field))
                                    re += "<Sprite=2>";
                                if (data.HasType(CardType.Ritual))
                                    re += "<Sprite=3>";
                                if (data.HasType(CardType.Continuous))
                                    re += "<Sprite=4>";
                                if (data.HasType(CardType.Counter))
                                    re += "<Sprite=5>";
                            }
                            re += bracketRight;
                        }
                        else
                            re = bracketLeft + MainType(data.Type, render) + bracketRight;
                    }
                }
            }
            catch (Exception e)
            { Debug.LogError(e); }
            return re;
        }

        public static string GetSetName(long Setcode, bool raw = false)
        {
            var setcodes = new int[4];
            for (var j = 0; j < 4; j++)
            {
                setcodes[j] = (int)((Setcode >> j * 16) & 0xffff);
            }
            var returnValue = new List<string>();
            for (var i = 0; i < setNames.Count; i++)
            {
                var currentHash = setNames[i].hashCode;
                for (var j = 0; j < 4; j++)
                {
                    if (currentHash == setcodes[j])
                    {
                        var setArray = setNames[i].content.Split('\t');
                        var setString = setArray[0];
                        returnValue.Add(setString);
                    }
                }
            }
            if (returnValue.Count > 0)
            {
                if (raw)
                    return string.Join("|", returnValue.ToArray());
                else
                    return "【" + string.Join("|", returnValue.ToArray()) + "】";
            }
            else
                return string.Empty;
        }
        public static int GetSetNameCode(string setName)
        {
            int returnValue = 0;
            for (var i = 0; i < setNames.Count; i++)
            {
                var setArray = setNames[i].content.Split('\t');
                var setString = setArray[0];
                if (setName == setString)
                    returnValue = setNames[i].hashCode;
            }
            return returnValue;
        }
    }
}
