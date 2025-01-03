using MDPro3.YGOSharp;
using System;
using System.Collections.Generic;

namespace MDPro3.Net
{
    public class DeckShareURL
    {
        static readonly string URL_SCHEME_HTTP = "http";
        static readonly string URL_HOST_DECK = "deck.ourygo.top";
        static readonly string ARG_DECK = "deck";
        static readonly string QUERY_VERSION = "v";
        static readonly string QUERY_YGO_TYPE = "ygotype";
        static readonly string QUERY_DECK = "d";

        public static Uri DeckToUri(List<int>main, List<int>extra, List<int>side, Dictionary<string, string> parameters = null)
        {
            var builder = new UriBuilder(URL_SCHEME_HTTP, URL_HOST_DECK);
            if (parameters != null)
                foreach (var entry in parameters)
                    builder.Query = builder.Query.Length > 1 ? builder.Query.Substring(1) + $"&{entry.Key}={Uri.EscapeDataString(entry.Value)}" : $"{entry.Key}={entry.Value}";

            builder.Query += $"{QUERY_YGO_TYPE}={ARG_DECK}";
            builder.Query += $"&{QUERY_VERSION}=1";

            int mNum = GetTypeNum(main);
            int eNum = GetTypeNum(extra);
            int sNum = GetTypeNum(side);

            string deck = ToBit(main, extra, side, mNum, eNum, sNum);

            string m = Convert.ToString(mNum, 2);
            string e = Convert.ToString(eNum, 2);
            string s = Convert.ToString(sNum, 2);

            m = ToNumLength(m, 8);
            e = ToNumLength(e, 4);
            s = ToNumLength(s, 4);

            deck = m + e + s + deck;
            var bytes = ToBytes(deck);
            string message = Convert.ToBase64String(bytes).Replace('+', '-').Replace('/', '_').TrimEnd('=');
            builder.Query += $"&{QUERY_DECK}={Uri.EscapeDataString(message)}";

            return builder.Uri;
        }

        static string ToBit(List<int> main, List<int> extra, List<int> side, int mNum, int eNum, int sNum)
        {
            var mains = ToByte(main, mNum);
            var extras = ToByte(extra, eNum);
            var sides = ToByte(side, sNum);
            return mains + extras + sides;
        }
        static string ToByte(List<int> ids, int typeNum)
        {
            var bytes = string.Empty;
            if(ids == null)
                return bytes;
            for(int i = 0; i < ids.Count; i++)
            {
                int id = ids[i];
                if(id > 0)
                {
                    string idB = ToB(id);
                    if (i != ids.Count - 1)
                    {
                        int id1 = ids[i + 1];
                        int tNum = 1;
                        if (id1 == id)
                        {
                            tNum++;
                            if (i != ids.Count - 2)
                            {
                                id1 = ids[i + 2];
                                if (id1 == id)
                                {
                                    tNum++;
                                    i++;
                                }
                            }
                            i++;
                        }
                        tNum = Math.Min(3, tNum);
                        switch (tNum)
                        {
                            case 1:
                                idB = "01" + idB;
                                break;
                            case 2:
                                idB = "10" + idB;
                                break;
                            case 3:
                                idB = "11" + idB;
                                break;
                        }
                    }
                    else
                        idB = "01" + idB;
                    bytes += idB;
                }
            }
            return bytes;
        }
        static string ToB(int id)
        {
            return ToNumLength(Convert.ToString(id, 2), 27);
        }
        static string ToNumLength(string message, int num)
        {
            while (message.Length < num)
                message = "0" + message;
            return message;
        }

        static byte[] ToBytes(string bits)
        {
            int y = bits.Length % 8;
            if(y != 0)
                bits = ToNumLengthLast(bits, bits.Length + 8 - y);
            var bytes = new byte[bits.Length / 8];
            for(int i = 0; i < bits.Length / 8; i++)
                bytes[i] = (byte)(Convert.ToInt32(bits.Substring(i * 8, 8), 2));
            return bytes;
        }

        static string ToNumLengthLast(string message, int num)
        {
            while (message.Length < num)
                message += "0";
            return message;
        }
        static int GetTypeNum(List<int> ids)
        {
            int num = 0;
            for(int i = 0;i < ids.Count;i++)
            {
                int id = ids[i];
                if(id > 0)
                {
                    num++;
                    if(i != ids.Count - 1)
                    {
                        int id1 = ids[i + 1];
                        if(id1 == id)
                        {
                            if(i != ids.Count - 2)
                            {
                                id1 = ids[i + 2];
                                if (id1 == id)
                                    i++;
                            }
                            i++;
                        }
                    }
                }
            }
            return num;
        }


        public static Deck UriToDeck(Uri uri)
        {
            if (!uri.Host.Equals(URL_HOST_DECK) || !uri.Query.Contains($"{QUERY_DECK}="))
            {
                throw new ArgumentException("Invalid URI format or host");
            }

            var queryParameters = ParseQueryParameters(uri.Query);

            string encodedDeck = GetValueFromQuery(queryParameters, QUERY_DECK, string.Empty);
            encodedDeck = encodedDeck.Replace('-', '+').Replace('_', '/');

            byte[] deckBytes = Convert.FromBase64String(encodedDeck.PadRight(encodedDeck.Length + (4 - encodedDeck.Length % 4) % 4, '='));

            string deckBits = "";
            for (int i = 0; i < deckBytes.Length; i++)
            {
                deckBits += Convert.ToString(deckBytes[i], 2).PadLeft(8, '0');
            }

            int totalMainLength = 29 * GetBinaryIntValue(deckBits.Substring(0, 8));
            int totalExtraLength = 29 * GetBinaryIntValue(deckBits.Substring(8, 4));
            int totalSideLength = 29 * GetBinaryIntValue(deckBits.Substring(12, 4));

            int startIndex = 16;
            var main = DecodeCardList(deckBits.Substring(startIndex, totalMainLength));
            startIndex += totalMainLength;
            var extra = DecodeCardList(deckBits.Substring(startIndex, totalExtraLength));
            startIndex += totalExtraLength;
            var side = DecodeCardList(deckBits.Substring(startIndex, totalSideLength));
            return new Deck(main, extra, side);
        }
        private static Dictionary<string, string> ParseQueryParameters(string query)
        {
            var result = new Dictionary<string, string>();
            var parts = query.Split('&');
            foreach (var part in parts)
            {
                var keyValue = part.Split('=');
                if (keyValue.Length == 2)
                {
                    result[keyValue[0]] = Uri.UnescapeDataString(keyValue[1]);
                }
            }
            return result;
        }
        private static int GetBinaryIntValue(string binaryString)
        {
            return Convert.ToInt32(binaryString, 2);
        }
        private static List<int> DecodeCardList(string bitString)
        {
            List<int> cardIds = new List<int>();

            int currentIndex = 0;
            while (currentIndex < bitString.Length)
            {
                int count;
                int currentId = GetCardId(bitString, ref currentIndex, out count);
                for (int i = 0; i < count; i++)
                {
                    cardIds.Add(currentId);
                }
            }

            return cardIds;
        }
        private static int GetCardId(string bitString, ref int currentIndex, out int count)
        {
            count = 1;
            if (bitString.Length - currentIndex >= 2)
            {
                switch (bitString.Substring(currentIndex, 2))
                {
                    case "01":
                        count = 1;
                        break;
                    case "10":
                        count = 2;
                        break;
                    case "11":
                        count = 3;
                        break;
                }
                currentIndex += 2;
            }
            int id = Convert.ToInt32(bitString.Substring(currentIndex, 27), 2);
            currentIndex += 27;
            return id;
        }
        private static string GetValueFromQuery(Dictionary<string, string> queryParameters, string key, string defaultValue = "")
        {
            string value;
            if (queryParameters.TryGetValue(key, out value))
            {
                return value;
            }
            return defaultValue;
        }
    }
}
