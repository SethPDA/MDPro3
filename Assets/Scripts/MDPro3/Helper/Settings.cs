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
                89631139,   //���۰���
                53347303,   //���۹���
                22804410,   //Ԩ�۰���
                38517737,   //�����ǰ���
                30576089,   //����������
                9433350,    //�� ���۰���
                53183600,   //���ۿ�ͨ��
                23995346,   //���۾�����
                43228023,   //���۾�������
                56532353,   //�����۾�����
                2129638,    //����˫������
                11443677    //���۱�����
            };

            FinalAttackDarkM = new int[]
            {
                46986414,   //��ħ��ʦ
                92377303,   //���´�����
                342673,       //��ɫħ��ʦ-��ħ��ʦ
                21296502,   //��ͨ��ħ��ʦ
                29436665,   //��ħ��ִ�й�
                35191415,   //�ڻ���֮ħ��ʦ
                38033121,   //��ħ����Ů
                90960358,   //��ͨ��ħ����Ů
                50237654    //��ħ��ʦ-��ħ��ʦͽ
            };

            FinalAttackRedEyes = new int[]
            {
                74677422,   //����ۺ���
                96561011,   //����۰���
                64335804,   //����ۺڸ���
                18491580,   //������Ǻ���
                55343236,   //�� ����ۺ���
                6556909,     //���֮��
            };

            FinalAttackObelisk = new int[]
            {
                10000000   //�����
            };

            FinalAttackRa = new int[]
            {
                10000010,   //������
                10000080,   //��
                10000090,   //������
            };

            FinalAttackSlifer = new int[]
            {
                10000020   //�����
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
