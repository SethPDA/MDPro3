using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MDPro3
{
    [CreateAssetMenu(fileName = "Characters", menuName = "Scriptable Objects/Characters")]
    public class Characters : ScriptableObject
    {
        [Serializable]
        public struct SeriesCharacter
        {
            public string id;
            public bool notReady;
        }

        public List<SeriesCharacter> dm;
        public List<SeriesCharacter> gx;
        public List<SeriesCharacter> _5ds;
        public List<SeriesCharacter> dsod;
        public List<SeriesCharacter> zexal;
        public List<SeriesCharacter> arcv;
        public List<SeriesCharacter> vrains;
        public List<SeriesCharacter> sevens;
        public List<SeriesCharacter> npc;

        NPC_Names names;
        NPC_Profiles profiles;

        public string language = "zh-CN";
        static Characters instance;

        public string GetCharacterSeries(string charaID)
        {
            foreach (var c in dm)
                if (c.id == charaID)
                    return "00";
            foreach (var c in gx)
                if (c.id == charaID)
                    return "01";
            foreach (var c in _5ds)
                if (c.id == charaID)
                    return "02";
            foreach (var c in dsod)
                if (c.id == charaID)
                    return "03";
            foreach (var c in zexal)
                if (c.id == charaID)
                    return "04";
            foreach (var c in arcv)
                if (c.id == charaID)
                    return "05";
            foreach (var c in vrains)
                if (c.id == charaID)
                    return "06";
            foreach (var c in sevens)
                if (c.id == charaID)
                    return "07";
            foreach (var c in npc)
                if (c.id == charaID)
                    return "08";

            return "00";
        }

        public List<SeriesCharacter> GetSeriesCharacters(string serial)
        {
            switch (serial)
            {
                case "00":
                    return dm;
                case "01":
                    return gx;
                case "02":
                    return _5ds;
                case "03":
                    return dsod;
                case "04":
                    return zexal;
                case "05":
                    return arcv;
                case "06":
                    return vrains;
                case "07":
                    return sevens;
                case "08":
                    return npc;
                default: 
                    return dm;
            }
        }

        static bool initialized = false;

        public void Initialize()
        {
            if(initialized) 
                return;

            var path = Program.dataPath + "DuelLinks_NPC_NAME.json";
            names = JsonConvert.DeserializeObject<NPC_Names>(File.ReadAllText(path));
            path = Program.dataPath + "DuelLinks_Profile.json";
            profiles = JsonConvert.DeserializeObject<NPC_Profiles>(File.ReadAllText(path));
            initialized = true;
            instance = this;
        }

        public void ChangeLanguage(string language)
        {
            this.language = language;

        }

        public string GetName(string id)
        {
            if(!initialized)
                Initialize();

            if (names.NPC_NAME.TryGetValue("NAME_ID" + id, out var data))
            {
                switch(language)
                {
                    case "ja-JP":
                        return data.japanese;
                    case "en-US":
                        return data.english;
                    case "fr-FR":
                        return data.french;
                    case "it-IT":
                        return data.italian;
                    case "de-DE":
                        return data.german;
                    case "es-ES":
                        return data.spanish;
                    case "pt-BR":
                        return data.portuguese;
                    case "ru-RU":
                        return data.russian;
                    case "ko-KR":
                        return data.korean;
                    case "zh-TW":
                        return data.tChinese;
                    case "zh-CN":
                        return data.sChinese;
                    default: 
                        return data.english;
                }
            }
            else
                return string.Empty;
        }
        public string GetProfile(string id)
        {
            if (!initialized)
                Initialize();

            if (profiles.PROFILE.TryGetValue("ID" + id, out var data))
            {
                switch (language)
                {
                    case "ja-JP":
                        return data.japanese;
                    case "en-US":
                        return data.english;
                    case "fr-FR":
                        return data.french;
                    case "it-IT":
                        return data.italian;
                    case "de-DE":
                        return data.german;
                    case "es-ES":
                        return data.spanish;
                    case "pt-BR":
                        return data.portuguese;
                    case "ru-RU":
                        return data.russian;
                    case "ko-KR":
                        return data.korean;
                    case "zh-TW":
                        return data.tChinese;
                    case "zh-CN":
                        return data.sChinese;
                    default:
                        return data.english;
                }
            }
            else
                return string.Empty;
        }
    }

    [Serializable]
    public class NPC_Data
    {
        public string id;
        public string note;
        [JsonProperty("ja-JP")]
        public string japanese;
        [JsonProperty("en-US")]
        public string english;
        [JsonProperty("fr-FR")]
        public string french;
        [JsonProperty("it-IT")]
        public string italian;
        [JsonProperty("de-DE")]
        public string german;
        [JsonProperty("es-ES")]
        public string spanish;
        [JsonProperty("pt-BR")]
        public string portuguese;
        [JsonProperty("ru-RU")]
        public string russian;
        [JsonProperty("ko-KR")]
        public string korean;
        [JsonProperty("zh-TW")]
        public string tChinese;
        [JsonProperty("zh-CN")]
        public string sChinese;
        public string date;
    }

    public class NPC_Names
    {
        public Dictionary<string, NPC_Data> NPC_NAME;
    }

    public class NPC_Profiles
    {
        public Dictionary<string, NPC_Data> PROFILE;
    }
}
