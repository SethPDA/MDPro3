using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;

namespace MDPro3
{
    public class AudioManager : Manager
    {
        public AudioSource seR;
        public AudioSource bgmR;
        public AudioSource voiceR;

        static AudioSource se;
        static AudioSource bgm;
        static AudioSource voice;
        public override void Initialize()
        {
            base.Initialize();
            se = seR;
            bgm = bgmR;
            voice = voiceR;
            AudioSettings.OnAudioConfigurationChanged += OnAudioConfigurationChanged;

            PlayBGM("BGM_MENU_01");
        }
        void OnAudioConfigurationChanged(bool deviceWasChanged)
        {
#if !UNITY_EDITOR && UNITY_ANDROID
            if (deviceWasChanged)
            {
                AudioConfiguration config = AudioSettings.GetConfiguration();
                AudioSettings.Reset(config);
            }
            bgm.Play();
#endif
        }
        public static void SetSeVol(float vol)
        {
            se.volume = vol;
        }
        public static void SetBGMVol(float vol)
        {
            bgm.volume = vol * currentBGMScale;
        }
        public static void SetVoiceVol(float vol)
        {
            voice.volume = vol;
        }

        #region SE
        struct LastSE
        {
            public float time;
            public string seName;
        }

        static LastSE lastSE = new LastSE();
        public static string nextMuteSE;
        public static void PlaySE(string path, float volumeScale = 1)
        {
            if (se == null)
                return;

            if (string.IsNullOrEmpty(path))
                return;
            if (path == nextMuteSE)
            {
                nextMuteSE = string.Empty;
                return;
            }

            if (lastSE.time > 0 && lastSE.seName == path && Time.time - lastSE.time < 0.1f)
                return;

            lastSE.time = Time.time;
            lastSE.seName = path;
            var handle = Addressables.LoadAssetAsync<AudioClip>(path);
            handle.Completed += (result) =>
            {
                if(result.Result != null)
                    se.PlayOneShot(result.Result, volumeScale);
            };
        }

        static IEnumerator PlaySEGroup(List<string> ses, float volumeScale = 1)
        {
            foreach (string s in ses)
            {
                var handle = Addressables.LoadAssetAsync<AudioClip>(s);
                while (!handle.IsDone)
                    yield return null;
                se.PlayOneShot(handle.Result, volumeScale);
                yield return new WaitForSeconds(handle.Result.length * 0.5f);
            }
        }

        public void PlayShuffleSE()
        {
            List<string> ses = new List<string>()
            {
                "SE_CARD_MOVE_01",
                "SE_CARD_MOVE_02",
                "SE_CARD_MOVE_03",
                "SE_CARD_MOVE_04"
            };
            StartCoroutine(PlaySEGroup(ses));
        }

        public static void PlaySEClip(AudioClip clip, float volumeScale = 1)
        {
            se.PlayOneShot(clip, volumeScale);
        }
        public static void ResetSESource()
        {
            se.gameObject.SetActive(false);
            se.gameObject.SetActive(true);
        }

        #endregion

        #region Voice
        public static void PlayVoiceByResourcePath(string path)
        {
            var clip = Resources.Load<AudioClip>(path);
            if(clip != null)
                voice.PlayOneShot(clip);
        }

        public static void PlayVoice(AudioClip clip)
        {
            voice.PlayOneShot(clip);
        }

        #endregion

        #region BGM

        enum BgmType
        {
            NORMAL,
            KEYCARD,
            CLIMAX
        }

        struct BgmLoop
        {
            public string name;
            public float startTime;
            public float endTime;
        }

        readonly static List<BgmLoop> loops = new List<BgmLoop>
        {
            new BgmLoop{name = "BGM_MENU_01", startTime = 12.433f, endTime = 120 + 31.100f },
            new BgmLoop{name = "BGM_MENU_02", startTime = 15.687f, endTime = 120 + 2.354f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_01", startTime = 9.600f, endTime = 60 + 55.200f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_02", startTime = 16.500f, endTime = 60 + 48.500f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_03", startTime = 5.727f, endTime = 120 + 11.444f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_04", startTime = 13.518f, endTime = 60 + 57.300f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_05", startTime = 11.208f, endTime = 120 + 22.875f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_06", startTime = 9.527f, endTime = 60 + 41.906f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_07", startTime = 17.456f, endTime = 120 +9.247f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_08", startTime = 18.400f, endTime = 120 + 12.400f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_09", startTime = 6.200f, endTime = 60 +51.400f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_10", startTime = 9.989f, endTime = 60 + 51.636f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_11", startTime = 2.378f, endTime = 60 +29.650f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_12", startTime = 7.500f, endTime = 60 +47.800f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_13", startTime = 7.433f, endTime = 60 + 54.741f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_14", startTime = 5.538f, endTime = 60 +34.142f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_15", startTime = 8.455f, endTime = 60 +34.855f },
            new BgmLoop{name = "BGM_DUEL_NORMAL_16", startTime = 14.440f, endTime = 60 + 44.440f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_01", startTime = 11.744f, endTime = 60 + 49.390f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_02", startTime = 10.500f, endTime = 60 + 46.500f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_03", startTime = 13.697f, endTime = 60 + 38.150f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_04", startTime = 7.032f, endTime = 60 + 49.888f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_05", startTime = 12.495f, endTime = 60 +23.079f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_06", startTime = 11.400f, endTime = 60 + 38.400f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_07", startTime = 6.518f, endTime = 60 + 24.928f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_08", startTime = 13.783f, endTime = 60 + 57.727f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_09", startTime = 3.800f, endTime = 60 + 20.300f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_10", startTime = 17.599f, endTime = 60 + 40.508f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_11", startTime = 11.738f, endTime = 60 + 57.104f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_12", startTime = 13.630f, endTime = 60 + 45.684f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_13", startTime = 18.519f, endTime = 60 + 55.734f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_14", startTime = 2.269f, endTime = 60 + 35.830f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_15", startTime = 11.369f, endTime = 60 + 41.369f },
            new BgmLoop{name = "BGM_DUEL_KEYCARD_16", startTime = 6.348f, endTime = 60 + 36.151f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_01", startTime = 6.300f, endTime = 60 + 37.800f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_02", startTime = 12.883f, endTime = 60 + 53.958f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_03", startTime = 12.579f, endTime = 120 + 7.444f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_04", startTime = 3.325f, endTime = 60 + 31.047f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_05", startTime = 5.424f, endTime = 60 + 37.188f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_06", startTime = 5.896f, endTime = 60 + 26.184f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_07", startTime = 11.500f, endTime = 60 + 31.500f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_08", startTime = 15.547f, endTime = 60 + 48.505f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_09", startTime = 6.300f, endTime = 60 + 28.800f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_10", startTime = 2.500f, endTime = 60 + 34.500f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_11", startTime = 13.223f, endTime = 60 + 43.955f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_12", startTime = 6.448f, endTime = 60 + 34.252f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_13", startTime = 5.637f, endTime = 60 + 50.429f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_14", startTime = 12.169f, endTime = 60 + 48.165f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_15", startTime = 7.056f, endTime = 60 + 39.847f },
            new BgmLoop{name = "BGM_DUEL_CLIMAX_16", startTime = 9.606f, endTime = 60 + 28.067f },
            new BgmLoop{name = "BGM_DUEL_EX_01", startTime = 21.014f, endTime = 60 + 57.026f },
            new BgmLoop{name = "BGM_DUEL_EX_02_NORMAL", startTime = 2.466f, endTime = 60 + 47.193f },
            new BgmLoop{name = "BGM_DUEL_EX_02_KEYCARD", startTime = 6.941f, endTime = 60 + 46.766f },
            new BgmLoop{name = "BGM_DUEL_EX_02_CLIMAX", startTime = 2.346f, endTime = 60 + 43.210f },
            new BgmLoop{name = "BGM_DUEL_EX_03_NORMAL", startTime = 11.478f, endTime = 60 + 56.473f },
            new BgmLoop{name = "BGM_DUEL_EX_03_KEYCARD", startTime = 12.463f, endTime = 60 + 46.098f },
            new BgmLoop{name = "BGM_DUEL_EX_03_CLIMAX", startTime = 1.815f, endTime = 120 + 8.792f },
            new BgmLoop{name = "BGM_OUT_TUTORIAL_2", startTime = 7.480f, endTime = 60 + 22.480f },
            new BgmLoop{name = "BGM_DUEL_F01_ALL", startTime = 24.219f, endTime = 120 + 42.886f },
            new BgmLoop{name = "BGM_DUEL_F02_PHASE_A", startTime = 13.603f, endTime = 60 + 43.324f },
            new BgmLoop{name = "BGM_DUEL_F02_PHASE_B", startTime = 14.818f, endTime = 120 + 2.645f },

        };


        static readonly List<int> bgms = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
        };
        static readonly List<int> exBgms = new List<int>()
        {
            2, 3, 4, 5
        };
        static readonly List<int> commonBgms = new List<int>()
        {
            1,
            3,
            7
        };

        static readonly Dictionary<int, List<int>> fieldBGMs = new Dictionary<int, List<int>>()
        {
            {1, new List<int>{ 2, 12 } },//「森」「未界域－欧玛利亚大陆」
            {2, new List<int>{ 4, 3, 21 } },//「齿车街」「魔导书廊」「教导的圣堂」
            {3, new List<int>{ 1, 11 } },//「仪式之间」「荒野的祭殿」
            {4, new List<int>{ 5, 6 } },//「火山」「星遺物沉眠的废墟」
            {5, new List<int>{ 7 } },//「异国之都」
            {6, new List<int>{ 15, 24 } },//「鲜彩之苍海」「辉石的洞窟」
            {7, new List<int>{ 9 } },//「摩天楼」
            {8, new List<int>{  } },
            {9, new List<int>{ 16, 17 } },//「魔偶甜点城堡」「鬼计之馆」
            {10, new List<int>{  } },
            {11, new List<int>{ } },
            {12, new List<int>{ 19, 18, 25 } },//「突异变种进化研究所」「电脑的宇宙」「六世坏=天魔世界」
            {13, new List<int>{ 14 } },//「相剑的灵峰」
            {14, new List<int>{ 22 } },//「恶魔宫殿」
            {15, new List<int>{ 10 } },//「冻结的世界」
            {16, new List<int>{ 20, 27, 28 } },//「古之决斗的记忆」「苏醒的天空殿」「青色眼睛的灵堂」
        };

        static readonly Dictionary<int, List<int>> exFieldBGMs = new Dictionary<int, List<int>>()
        {
            {1, new List<int>{  } },
            {2, new List<int>{ 8 } },//「角斗场」
            {3, new List<int>{ 13 } },//「WCS」
            {4, new List<int>{ } },
            {5, new List<int>{ } },
        };

        static int bgmState = 0;
        static int bgmId = 1;
        static bool exBgm = false;
        static int GetFieldIdByFieldName(string fieldName)
        {
            return int.Parse(fieldName.Substring(4, 3));
        }

        static int GetBgmIdByFieldId(int fieldId)
        {
            exBgm = false;
            foreach(var pair in fieldBGMs)
                if (pair.Value.Contains(fieldId))
                    return pair.Key;
            foreach (var pair in exFieldBGMs)
                if (pair.Value.Contains(fieldId))
                {
                    exBgm = true;
                    return pair.Key;
                }

            return commonBgms[UnityEngine.Random.Range(0, commonBgms.Count)];
        }

        static string GetBgmPathById(int bgmId, BgmType type)
        {
            if (exBgm)
                return "BGM_DUEL_EX_" + bgmId.ToString("D2") + "_" + type;
            else
                return "BGM_DUEL_" + type + "_" + bgmId.ToString("D2");
        }

        public static void PlayBgmNormal(string filedName)
        {
            bgmState = 0;
            var fieldId = GetFieldIdByFieldName(filedName);
            bgmId = GetBgmIdByFieldId(fieldId);
            PlayBGM(GetBgmPathById(bgmId, BgmType.NORMAL));
        }

        public static void PlayBgmKeyCard()
        {
            if (bgmState > 0)
                return;
            bgmState = 1;
            PlayBGM(GetBgmPathById(bgmId, BgmType.KEYCARD));
        }
        public static void PlayBgmClimax()
        {
            if (bgmState == 2)
                return;
            bgmState = 2;
            PlayBGM(GetBgmPathById(bgmId, BgmType.CLIMAX));
        }

        static float currentBGMScale = 1f;
        public static void PlayBGM(string path, float volumeScale = 1f)
        {
            currentBGMScale = volumeScale;
            var handle = Addressables.LoadAssetAsync<AudioClip>(path);
            handle.Completed += (result) =>
            {
                var volume = Program.instance.setting.GetBGMVolum() * currentBGMScale;
                DOTween.To(() => volume, x => bgm.volume = x, 0, 0.2f).OnComplete(() =>
                {
                    SetCurrentBGM(path, result.Result.length);
                    bgm.volume = volume;
                    bgm.clip = result.Result;
                    bgm.time = 0;
                    bgm.Play();
                });
            };
        }

        public static void StopBGM()
        {
            var volume = bgm.volume;
            DOTween.To(() => volume, x => bgm.volume = x, 0, 0.5f).OnComplete(() =>
            {
                bgm.Stop();
                bgm.volume = volume;
            });
        }
        public static void PlayRandomKeyCardBGM()
        {
            PlayBGM(GetBgmPathById(bgms[UnityEngine.Random.Range(0, bgms.Count)], BgmType.KEYCARD));
        }

        static string currentBGM = string.Empty;
        static float loopStart = 0;
        static float loopEnd = 10;
        static void SetCurrentBGM(string bgm, float bgmLength)
        {
            currentBGM = bgm;
            bool found = false;
            foreach (var loop in loops)
            {
                if (loop.name == currentBGM)
                {
                    found = true;
                    loopStart = loop.startTime;
                    loopEnd = loop.endTime;
                    break;
                }
            }
            if (!found)
            {
                loopStart = 0;
                loopEnd = bgmLength - 1;
            }
        }

        private void Update()
        {
            if (bgm == null)
                return;
            if (bgm.time > loopEnd)
                bgm.time = loopStart;
        }


        #endregion

        #region PUBLIC STATIC FUNCTION
        public static IEnumerator<AudioClip> LoadAudioFileAsync(string path, AudioType audioType)
        {
            string fullPath;
#if !UNITY_EDITOR && UNITY_ANDROID
            fullPath = "file://" + Application.persistentDataPath + Program.slash + path;
#else
            fullPath = Environment.CurrentDirectory + Program.slash + path;
#endif

            using var request = UnityWebRequestMultimedia.GetAudioClip(fullPath, audioType);
            var wait = request.SendWebRequest();

            while (!wait.isDone)
                yield return null;

            if (request.result == UnityWebRequest.Result.Success)
            {
                var audioClip = DownloadHandlerAudioClip.GetContent(request);
                yield return audioClip;
            }
        }


        #endregion
    }
}
