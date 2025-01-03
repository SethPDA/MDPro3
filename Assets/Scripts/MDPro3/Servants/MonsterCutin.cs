using DG.Tweening;
using JetBrains.Annotations;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.UI;
using UnityEngine.EventSystems;
using TMPro;
using MDPro3.UI.PropertyOverrider;

namespace MDPro3
{
    public class MonsterCutin : Servant
    {
        public static List<Card> cards = new List<Card>();
        public static List<int> codes = new List<int>();
        public static List<int> codes2 = new List<int>();
        public static int controller = 0;

        [Header("MonsterCutin")]
        public TMP_InputField inputField;
        [HideInInspector] public SelectionToggle_Cutin lastSelectedCutinItem;
        static DirectoryInfo[] dirInfos;
        static FileInfo[] fileInfos;
        List<string[]> tasks = new List<string[]>();
        SuperScrollView superScrollView;


        #region Servant
        public override void Initialize()
        {
            depth = 1;
            showLine = false;
            returnServant = Program.instance.menu;
            base.Initialize();
            var targetFolder = Program.root + "MonsterCutin";
            var targetFolder2 = Program.root + "MonsterCutin2";

#if UNITY_STANDALONE_WIN && !UNITY_EDITOR
            targetFolder = Path.Combine(Application.dataPath, Program.root + "MonsterCutin");
            targetFolder2 = Path.Combine(Application.dataPath, Program.root + "MonsterCutin2");
#endif
            if(!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);
            if (!Directory.Exists(targetFolder2))
                Directory.CreateDirectory(targetFolder2);
            dirInfos = new DirectoryInfo(targetFolder).GetDirectories();
            fileInfos = new DirectoryInfo(targetFolder2).GetFiles();
            inputField.onEndEdit.AddListener(Print);
            Load();
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            UserInput.SetMoveRepeatRate(0.05f);
        }
        protected override void ApplyHideArrangement(int nextDepth)
        {
            base.ApplyHideArrangement(nextDepth);
            UserInput.SetMoveRepeatRate(0.1f);

            if (randomBGMPlayed)
            {
                randomBGMPlayed = false;
                AudioManager.PlayBGM("BGM_MENU_01");
            }

            CameraManager.DuelOverlayEffect3DCount = 0;
            CameraManager.DuelOverlayEffect3DMinus();
            DOTween.To(v => { }, 0, 0, 0.7f).OnComplete(() =>
            {
                Resources.UnloadUnusedAssets();
                GC.Collect();
            });

        }
        protected override bool NeedResponseInput()
        {
            if(inputField.isFocused)
                return false;
            return base.NeedResponseInput();
        }
        public override void PerFrameFunction()
        {
            if (!showing) return;
            if (NeedResponseInput())
            {
                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                    OnReturn();

                if(UserInput.WasGamepadButtonWestPressed)
                    inputField.ActivateInputField();
                if (UserInput.WasGamepadButtonNorthPressed)
                {
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonAutoPlay"));
                    AutoPlay();
                }
            }
        }
        public override void OnReturn()
        {
            if (returnAction != null) return;
            if (inTransition) return;
            AudioManager.PlaySE("SE_MENU_CANCEL");
            if (cg.alpha == 0)
            {
                StopCoroutine(autoPlay);
                autoPlay = null;
                foreach (var cutin in cutins)
                    Destroy(cutin);
                cutins.Clear();
                UIManager.ShowExitButton(transitionTime);
                cg.alpha = 1;
                cg.blocksRaycasts = true;
            }
            else
                OnExit();
        }
        public override void SelectLastSelectable()
        {
            EventSystem.current.SetSelectedGameObject(lastSelectedCutinItem.gameObject);
        }
        #endregion

        public void SelectLastCutinItem()
        {
            UserInput.NextSelectionIsAxis = true;
            SelectLastSelectable();
        }

        public void Load()
        {
            cards.Clear();
            for (int i = 0; i < dirInfos.Length; i++)
            {
                try
                {
                    Card card = CardsManager.Get(int.Parse(dirInfos[i].Name));
                    cards.Add(card);
                    codes.Add(card.Id);
                }
                catch { }
            }
            for (int i = 0; i < fileInfos.Length; i++)
            {
                try
                {
                    var cardCode = int.Parse(fileInfos[i].Name);
                    if (!codes.Contains(cardCode))
                    {
                        Card card = CardsManager.Get(cardCode);
                        cards.Add(card);
                        codes2.Add(card.Id);
                    }
                }
                catch { }
            }
            cards.Sort(CardsManager.ComparisonOfCard());
            Print();
        }

        public void Print(string search = "")
        {
            superScrollView?.Clear();
            tasks.Clear();
            foreach (var card in cards)
            {
                if (card.Name.Contains(search))
                {
                    string code = card.Id.ToString();
                    string cardName = card.Name;
                    string[] task = new string[] { code, cardName };
                    tasks.Add(task);
                }
            }
            var handle = Addressables.LoadAssetAsync<GameObject>("ItemCutin");
            handle.Completed += (result) =>
            {
                var itemWidth = PropertyOverrider.NeedMobileLayout() ? 460f : 360f;
                var itemHeight = PropertyOverrider.NeedMobileLayout() ? 80f : 40f;

                superScrollView = new SuperScrollView(
                    1,
                    itemWidth,
                    itemHeight,
                    0,
                    0,
                    result.Result,
                    ItemOnListRefresh,
                    Manager.GetElement<ScrollRect>("ScrollRect"),
                    4);
                superScrollView.Print(tasks);
                if(superScrollView.items.Count > 0)
                    lastSelectedCutinItem = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_Cutin>();

                if (showing)
                {
                    if (Cursor.lockState == CursorLockMode.Locked)
                        SelectLastSelectable();
                }
                else
                    transform.GetChild(0).gameObject.SetActive(false);
            };
        }


        public static bool HasCutin(int code)
        {
            if (Program.instance.ocgcore.condition == OcgCore.Condition.Duel
                && Config.Get("DuelCutin", "1") == "0")
                return false;
            if (Program.instance.ocgcore.condition == OcgCore.Condition.Watch
                && Config.Get("WatchCutin", "1") == "0")
                return false;
            if (Program.instance.ocgcore.condition == OcgCore.Condition.Replay
                && Config.Get("ReplayCutin", "1") == "0")
                return false;
            code = AliasCode(code);
            bool returnValue = false;
            foreach (var card in cards)
            {
                if (card.Id == code)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }

        static bool playing;
        public static void Play(int code, int controller, bool isDiy = false, GameObject cutin = null)
        {
            if (playing) 
                return;
            playing = true;
            if (Program.instance.ocgcore.showing)
                AudioManager.PlayBgmKeyCard();
            DOTween.To(v => { }, 0, 0, 1.6f).OnComplete(() =>
            {
                playing = false;
            });
            code = AliasCode(code);
            Card card = CardsManager.Get(code);

            GameObject loader = null;
            bool diy = false;
            if(cutin == null)
            {
                if (codes.Contains(code))
                    loader = ABLoader.LoadFromFolder("MonsterCutin/" + code, "Spine" + code);
                else
                {
                    loader = ABLoader.LoadFromFile("MonsterCutin2/" + code);
                    diy = true;
                }
            }
            else
            {
                loader = cutin;
                diy = isDiy;
            }

            loader.transform.SetParent(Program.instance.container_2D, false);
            Destroy(loader, 1.6f);

            if (!diy)
            {
                loader.transform.GetChild(0).localPosition = Vector3.zero;
                loader.transform.GetChild(0).GetComponent<PlayableDirector>().time = 0;
            }

            //BackEffects
            GameObject back;
            if ((card.Attribute & (uint)CardAttribute.Dark) > 0)//125
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bgdak_s2", true);
            else if ((card.Attribute & (uint)CardAttribute.Light) > 0)//100
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bglit_s2", true);
            else if ((card.Attribute & (uint)CardAttribute.Earth) > 0)//56
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bgeah_s2", true);
            else if ((card.Attribute & (uint)CardAttribute.Water) > 0)//35
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bgwtr_s2", true);
            else if ((card.Attribute & (uint)CardAttribute.Fire) > 0)//31
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bgfie_s2", true);
            else if ((card.Attribute & (uint)CardAttribute.Wind) > 0)//25
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bgwid_s2", true);
            else//4
                back = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/04backeff/summonmonster_bgdve_s2", true);
            back.transform.SetParent(Program.instance.container_2D, false);
            Transform eff_flame = back.transform.Find("Eff_Flame");
            eff_flame.localScale = new Vector3(2.76f, 1.55f, 1f);
            eff_flame.gameObject.AddComponent<AutoScaleOnce>();
            Transform eff_bg00 = back.transform.Find("Eff_Bg00");
            eff_bg00.localScale = new Vector3(250f, 25f, 1f);
            Transform flame_re = back.transform.Find("flame_re");
            if (flame_re == null)
                flame_re = back.transform.Find("Eff_group/flame_re");
            if (flame_re == null)
                flame_re = back.transform.Find("Eff_Flame01_re");
            flame_re.gameObject.AddComponent<AutoScaleOnce>();
            Destroy(back, 1.6f);

            //Name Bar
            GameObject nameBar;
            if (controller == 0)
                nameBar = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/01text/summonmonster_name_near", true);
            else
                nameBar = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/01text/summonmonster_name_far", true);

            nameBar.transform.SetParent(Program.instance.container_2D, false);
            var manager = nameBar.GetComponent<ElementObjectManager>();
            var tmp = manager.GetElement<ExtendedTextMeshPro>("Monster_Name_TMP");
            tmp.font = Program.instance.ui_.tmpFont;
            tmp.text = card.Name;
            var para = "ATK " + (card.Attack == -2 ? "?" : card.Attack.ToString());
            if (!card.HasType(CardType.Link))
            {
                para += " DEF " + (card.Defense == -2 ? "?" : card.Defense.ToString());
                Destroy(manager.GetElement("Icon_LINK"));
            }
            else
            {
                Destroy(manager.GetElement("Icon_Level"));
                Destroy(manager.GetElement("Icon_Level_Odd"));
                Destroy(manager.GetElement("Icon_Rank"));
                Destroy(manager.GetElement("Icon_Rank_Odd"));
                switch (CardDescription.GetCardLinkCount(card))
                {
                    case 2:
                        manager.GetElement<ElementObjectManager>("Icon_LINK").
                            GetElement<SpriteRenderer>("LINK1").sprite = TextureManager.container.link2;
                        break;
                    case 3:
                        manager.GetElement<ElementObjectManager>("Icon_LINK").
                            GetElement<SpriteRenderer>("LINK1").sprite = TextureManager.container.link3;
                        break;
                    case 4:
                        manager.GetElement<ElementObjectManager>("Icon_LINK").
                            GetElement<SpriteRenderer>("LINK1").sprite = TextureManager.container.link4;
                        break;
                    case 5:
                        manager.GetElement<ElementObjectManager>("Icon_LINK").
                            GetElement<SpriteRenderer>("LINK1").sprite = TextureManager.container.link5;
                        break;
                    case 6:
                        manager.GetElement<ElementObjectManager>("Icon_LINK").
                            GetElement<SpriteRenderer>("LINK1").sprite = TextureManager.container.link6;
                        break;
                }
            }

            ElementObjectManager subManager;
            if (!card.HasType(CardType.Xyz))
            {
                Destroy(manager.GetElement("Icon_Rank"));
                Destroy(manager.GetElement("Icon_Rank_Odd"));
                if (card.Level % 2 == 0)
                {
                    subManager = manager.GetElement<ElementObjectManager>("Icon_Level");
                    Destroy(manager.GetElement("Icon_Level_Odd"));
                }
                else
                {
                    subManager = manager.GetElement<ElementObjectManager>("Icon_Level_Odd");
                    Destroy(manager.GetElement("Icon_Level"));
                }
            }
            else
            {
                Destroy(manager.GetElement("Icon_Level"));
                Destroy(manager.GetElement("Icon_Level_Odd"));
                if (card.Level % 2 == 0)
                {
                    subManager = manager.GetElement<ElementObjectManager>("Icon_Rank");
                    Destroy(manager.GetElement("Icon_Rank_Odd"));
                }
                else
                {
                    subManager = manager.GetElement<ElementObjectManager>("Icon_Rank_Odd");
                    Destroy(manager.GetElement("Icon_Rank"));
                }
            }
            if (!card.HasType(CardType.Link))
                for (int i = card.Level + 1; i < 14; i++)
                    Destroy(subManager.GetElement("Icon" + i));
            manager.GetElement<TextMesh>("Monster_Para").text = para;
            Destroy(nameBar, 1.6f);

            //front Effect
            var frontEffect = ABLoader.LoadFromFile("MasterDuel/Timeline/summon/summonmonster/02fronteff/summonmonster_thunder_power", true);
            frontEffect.transform.SetParent(Program.instance.container_2D, false);
            Destroy(frontEffect, 1.6f);
        }

        IEnumerator autoPlay;
        public void AutoPlay()
        {
            if (autoPlay != null) 
                return;
            autoPlay = AutoPlayAsync();
            StartCoroutine(autoPlay);
        }
        bool randomBGMPlayed;
        List<GameObject> cutins = new List<GameObject>();
        IEnumerator AutoPlayAsync()
        {
            while (playing)
                yield return null;
            if(!showing)
                yield break;

            AudioManager.PlayRandomKeyCardBGM();
            randomBGMPlayed = true;
            cg.alpha = 0f;
            cg.blocksRaycasts = false;
            UIManager.HideExitButton(transitionTime);
            int count = 0;
            foreach (var card in cards)
            {
                IEnumerator<GameObject> ie;
                bool diy = false;
                if (codes.Contains(card.Id))
                    ie = ABLoader.LoadFromFolderAsync("MonsterCutin/" + card.Id, "Spine" + card.Id, false, true);
                else
                {
                    ie = ABLoader.LoadFromFileAsync("MonsterCutin2/" + card.Id, false, true);
                    diy = true;
                }
                while (ie.MoveNext())
                    yield return null;
                ie.Current.SetActive(false);
                cutins.Add(ie.Current);
                while (playing)
                    yield return null;
                ie.Current.SetActive(true);
                Play(card.Id, 0, diy, ie.Current);
                count++;
                if (count % 20 == 0)
                {
                    var unload =  Resources.UnloadUnusedAssets();
                    while (!unload.isDone)
                        yield return null;
                }
            }
            cg.alpha = 1f;
            cg.blocksRaycasts = true;
            UIManager.ShowExitButton(transitionTime);
            autoPlay = null;
        }

        void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SelectionToggle_Cutin>();
            handler.code = int.Parse(task[0]);
            handler.cardName = task[1];
            handler.Refresh();
        }

        static int AliasCode(int code)
        {
            if (code == 89631142 || code == 89631148)//ÇàÑÛ°×Áú
                return 89631141;
            if (code == 89943725)//ÐÂÓîÏÀ
                return 89943723;
            if (code == 46986424 || code == 46986426)//ºÚÄ§ÊõÊ¦
                return 46986417;
            if (code == 74677425)//ÕæºìÑÛºÚÁú
                return 74677424;
            if (code == 44508096)//ÐÇ³¾Áú
                return 44508094;
            if (code == 84013240)//»ôÆÕ
                return 84013237;
            if (code == 16178684)//ÒìÉ«ÑÛ
                return 16178681;
            if (code == 5043013)//·À»ðÁú
                return 5043010;
            return code;
        }
    }
}
