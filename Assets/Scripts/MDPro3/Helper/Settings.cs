using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

namespace MDPro3
{
    [Serializable]
    public class SettingData
    {
        public int[] FinalAttackBlueEyes;
        public int[] FinalAttackDarkM;
        public int[] FinalAttackRedEyes;
        public int[] FinalAttackObelisk;
        public int[] FinalAttackRa;
        public int[] FinalAttackSlifer;
        public string PrereleasePackUrl;
        public string PrereleasePackVersionUrl;
        public string MDPro3VersionUrl;
        public bool CardRenderPassword;
        public int[] SavedCardSize;
        public string SavedCardFormat;
        public bool BatchMove;
        public string DiySymbol;

        public SettingData()
        {
            FinalAttackBlueEyes = new int[]
            {
                89631139,   //青眼白龙
                53347303,   //青眼光龙
                22804410,   //渊眼白龙
                38517737,   //青眼亚白龙
                30576089,   //青眼喷气龙
                9433350,    //罪 青眼白龙
                53183600,   //青眼卡通龙
                23995346,   //青眼究极龙
                43228023,   //青眼究极亚龙
                56532353,   //真青眼究极龙
                2129638,    //青眼双爆裂龙
                11443677    //青眼暴君龙
            };

            FinalAttackDarkM = new int[]
            {
                46986414,   //黑魔术师
                92377303,   //黑衣大贤者
                342673,       //黑色魔术师-黑魔术师
                21296502,   //卡通黑魔术师
                29436665,   //黑魔导执行官
                35191415,   //黑幻想之魔术师
                38033121,   //黑魔术少女
                90960358,   //卡通黑魔术少女
                50237654    //超魔导师-黑魔术师徒
            };

            FinalAttackRedEyes = new int[]
            {
                74677422,   //真红眼黑龙
                96561011,   //真红眼暗龙
                64335804,   //真红眼黑钢龙
                18491580,   //真红眼亚黑龙
                55343236,   //罪 真红眼黑龙
                6556909,     //真红之魂
            };

            FinalAttackObelisk = new int[]
            {
                10000000   //巨神兵
            };

            FinalAttackRa = new int[]
            {
                10000010,   //翼神龙
                10000080,   //蛋
                10000090,   //不死鸟
            };

            FinalAttackSlifer = new int[]
            {
                10000020   //天空龙
            };

            PrereleasePackUrl = "https://cdn02.moecube.com:444/ygopro-super-pre/archive/ygopro-super-pre.ypk";
            PrereleasePackVersionUrl = "https://cdn02.moecube.com:444/ygopro-super-pre/data/version.txt";
            MDPro3VersionUrl = "https://code.moenext.com/sherry_chaos/MDPro3/-/raw/master/Version.txt";
            CardRenderPassword = true;
            SavedCardSize = new int[] { 704, 1024 };
            SavedCardFormat = Program.jpgExpansion;
            BatchMove = true;
            DiySymbol = "DIY by";
        }
    }

    public static class Settings
    {
        private const string JsonPath = "Data/Settings.json";
        private static SettingData _data;
        public static SettingData Data
        {
            get
            {
                if(_data == null)
                    Initialize();
                return _data;
            }
        }

        public static void Initialize()
        {
            if (!File.Exists(JsonPath))
            {
                _data = new SettingData();
                SaveSettings(_data);
                return;
            }

            var json = File.ReadAllText(JsonPath);
            try
            {
                _data = EnsureDefaultValues(json);
            }
            catch(JsonReaderException ex)
            {
                MessageManager.Cast("Failed to parse Settings.json: " + ex.Message);
                _data = new SettingData();
            }
        }

        private static void SaveSettings(SettingData data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(JsonPath, json);
        }

        private static SettingData EnsureDefaultValues(string json)
        {
            var data = JsonConvert.DeserializeObject<SettingData>(json);
            var defau = new SettingData();
            bool needOverwrite = false;

            if (!json.Contains("FinalAttackBlueEyes"))
            {
                data.FinalAttackBlueEyes = defau.FinalAttackBlueEyes;
                needOverwrite = true;
            }
            if (!json.Contains("FinalAttackDarkM"))
            {
                data.FinalAttackDarkM = defau.FinalAttackDarkM;
                needOverwrite = true;
            }
            if (!json.Contains("FinalAttackRedEyes"))
            {
                data.FinalAttackRedEyes = defau.FinalAttackRedEyes;
                needOverwrite = true;
            }
            if (!json.Contains("FinalAttackObelisk"))
            {
                data.FinalAttackObelisk = defau.FinalAttackObelisk;
                needOverwrite = true;
            }
            if (!json.Contains("FinalAttackRa"))
            {
                data.FinalAttackRa = defau.FinalAttackRa;
                needOverwrite = true;
            }
            if (!json.Contains("FinalAttackSlifer"))
            {
                data.FinalAttackSlifer = defau.FinalAttackSlifer;
                needOverwrite = true;
            }
            if (!json.Contains("PrereleasePackUrl"))
            {
                data.PrereleasePackUrl = defau.PrereleasePackUrl;
                needOverwrite = true;
            }
            if (!json.Contains("PrereleasePackVersionUrl"))
            {
                data.PrereleasePackVersionUrl = defau.PrereleasePackVersionUrl;
                needOverwrite = true;
            }
            if (!json.Contains("CardRenderPassword"))
            {
                data.CardRenderPassword = defau.CardRenderPassword;
                needOverwrite = true;
            }
            if (!json.Contains("SavedCardSize"))
            {
                data.SavedCardSize = defau.SavedCardSize;
                needOverwrite = true;
            }
            if (!json.Contains("SavedCardFormat"))
            {
                data.SavedCardFormat = defau.SavedCardFormat;
                needOverwrite = true;
            }
            if (!json.Contains("BatchMove"))
            {
                data.BatchMove = defau.BatchMove;
                needOverwrite = true;
            }
            if (!json.Contains("DiySymbol"))
            {
                data.DiySymbol = defau.DiySymbol;
                needOverwrite = true;
            }
            if (needOverwrite)
                SaveSettings(data);

            return data;
        }
    }
}
