using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using MDPro3.YGOSharp;
using Newtonsoft.Json;

namespace MDPro3
{
    public static class Cid2Ydk
    {
        const string cardsPath = "Data/cards.json";
        const string cardsAltPath = "Data/cards_Alt.json";
        const string cardsLitePath = "Data/cards_Lite.json";
        const string pattern = @"<card mrk='(\d+)'/>";

        static bool initialized;
        static Dictionary<string, Id2Ydk> dic;
        static void Initialize()
        {
            if(initialized) return;

            if (File.Exists(cardsLitePath))
                dic = JsonConvert.DeserializeObject<Dictionary<string, Id2Ydk>>(File.ReadAllText(cardsLitePath));
            else
            {
                dic = JsonConvert.DeserializeObject<Dictionary<string, Id2Ydk>>(File.ReadAllText(cardsPath));
                var altDic = JsonConvert.DeserializeObject<Dictionary<string, Id2Ydk>>(File.ReadAllText(cardsAltPath));
                foreach(var key in altDic.Keys)
                    dic[key] = altDic[key];

                File.WriteAllText(cardsLitePath, JsonConvert.SerializeObject(dic));
            }

            initialized = true;
        }

        public static bool HaveCid(int cid)
        {
            Initialize();
            return dic.ContainsKey(cid.ToString());
        }

        public static int GetYDK(int cid)
        {
            Initialize();
            if (dic.ContainsKey(cid.ToString()))
                return dic[cid.ToString()].id;
            return cid;
        }

        public static int GetCID(int ydk)
        {
            Initialize();
            var card = CardsManager.Get(ydk);
            if(card.Alias != 0)
                ydk = card.Alias;
            foreach(var value in dic.Values)
                if(value.id == ydk || value.id == card.Id)
                    return value.cid;
            return ydk;
        }

        static string EvaluatorGetNameFromNumber(Match match)
        {
            string numberString = match.Groups[1].Value;
            int cid = int.Parse(numberString);
            dic.TryGetValue(cid.ToString(), out var code);
            if (code != null)
                return CardsManager.Get(code.id).Name;
            else
                return CardsManager.Get(cid).Name;
        }


        public static string ReplaceWithCardName(string origin)
        {
            Initialize();

            origin = origin.Replace(" get=\'name\'", string.Empty);
            return Regex.Replace(origin, pattern, EvaluatorGetNameFromNumber);
        }

        public class Id2Ydk
        {
            public int cid;
            public int id;
        }
    }
}
