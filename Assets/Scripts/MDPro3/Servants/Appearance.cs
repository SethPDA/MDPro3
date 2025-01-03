using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using MDPro3.UI;
using TMPro;
using UnityEngine.EventSystems;
using System.IO;
using MDPro3.YGOSharp;

namespace MDPro3
{
    public class Appearance : Servant
    {
        [Header("Appearance")]
        [SerializeField] private SelectionToggle_AppearancePlayer defaultPlayerToggle;
        [HideInInspector] public SelectionToggle_AppearanceGenre lastSelectedToggle;
        [HideInInspector] public SelectionToggle_AppearanceItem lastSelectedItem;

        public TMP_InputField inputPlayerName;

        public GameObject table;
        public Text deckName;
        public Text mainCount;
        public Text extraCount;
        public Text sideCount;
        public RectTransform cardsRoot;

        #region Assets

        public static Sprite duelFace0;
        public static Sprite duelFace1;
        public static Sprite watchFace0;
        public static Sprite watchFace1;
        public static Sprite replayFace0;
        public static Sprite replayFace1;
        public static Sprite duelFace0Tag;
        public static Sprite duelFace1Tag;
        public static Sprite watchFace0Tag;
        public static Sprite watchFace1Tag;
        public static Sprite replayFace0Tag;
        public static Sprite replayFace1Tag;
        public static Sprite defaultFace0;
        public static Sprite defaultFace1;

        public static Material duelFrameMat0;
        public static Material duelFrameMat1;
        public static Material watchFrameMat0;
        public static Material watchFrameMat1;
        public static Material replayFrameMat0;
        public static Material replayFrameMat1;
        public static Material duelFrameMat0Tag;
        public static Material duelFrameMat1Tag;
        public static Material watchFrameMat0Tag;
        public static Material watchFrameMat1Tag;
        public static Material replayFrameMat0Tag;
        public static Material replayFrameMat1Tag;

        public static Material duelProtector0;
        public static Material duelProtector1;
        public static Material watchProtector0;
        public static Material watchProtector1;
        public static Material replayProtector0;
        public static Material replayProtector1;
        public static Material duelProtector0Tag;
        public static Material duelProtector1Tag;
        public static Material watchProtector0Tag;
        public static Material watchProtector1Tag;
        public static Material replayProtector0Tag;
        public static Material replayProtector1Tag;

        public static Material matForFace;
        public static string player = "0";
        public const string meString = "Me";
        public const string opString = "Op";
        public const string meTagString = "MeTag";
        public const string opTagString = "OpTag";


        private static List<GameObject> wallpapers = new List<GameObject>();
        private static List<GameObject> faces = new List<GameObject>();
        private static List<GameObject> frames = new List<GameObject>();
        private static List<GameObject> protectors = new List<GameObject>();
        private static List<GameObject> mats = new List<GameObject>();
        private static List<GameObject> graves = new List<GameObject>();
        private static List<GameObject> stands = new List<GameObject>();
        private static List<GameObject> mates = new List<GameObject>();
        private static List<GameObject> cases = new List<GameObject>();

        private Dictionary<string, List<GameObject>> pools = new Dictionary<string, List<GameObject>>
        {
            { "Wallpaper", wallpapers },
            { "Face", faces },
            { "Frame", frames },
            { "Protector", protectors },
            { "Field", mats },
            { "Grave", graves },
            { "Stand", stands },
            { "Mate", mates },
            { "Case", cases },
        };

        public GameObject appearanceItem;

        #endregion


        public enum Condition
        {
            Duel,
            Watch,
            Replay,
            Deck,
            DeckEditor
        }
        public Condition condition = Condition.Duel;
        public void SwitchCondition(Condition condition)
        {
            this.condition = condition;
            var title = Manager.GetElement<TextMeshProUGUI>("Title");
            switch (condition)
            {
                case Condition.Duel:
                    title.text = InterString.Get("决斗外观");
                    break;
                case Condition.Watch:
                    title.text = InterString.Get("观战外观");
                    break;
                case Condition.Replay:
                    title.text = InterString.Get("回放外观");
                    break;
                case Condition.Deck:
                case Condition.DeckEditor:
                    title.text = InterString.Get("卡组外观");
                    break;
            }

            if (condition == Condition.DeckEditor)
                condition = Condition.Deck;

            Manager.GetElement("Page0 PlayerName").SetActive(condition != Condition.Deck);
            Manager.GetElement("Page1 Wallpaper").SetActive(condition != Condition.Deck);
            Manager.GetElement("Page2 Face").SetActive(condition != Condition.Deck);
            Manager.GetElement("Page3 Frame").SetActive(condition != Condition.Deck);
            Manager.GetElement("Page4 Case").SetActive(condition == Condition.Deck);
            Manager.GetElement("Page10 Pickup").SetActive(condition == Condition.Deck);
        }

        #region Servant
        public override void Initialize()
        {
            depth = 6;
            showLine = false;
            subBlackAlpha = 0.9f;
            base.Initialize();
            inputPlayerName.onEndEdit.AddListener(SavePlayerName);

            AssetBundle ab = AssetBundle.LoadFromFile(Program.root + "MasterDuel/Frame/ProfileFrameMat1030001");
            matForFace = ab.LoadAsset<Material>("ProfileFrameMat1030001");
            ab.Unload(false);
            var handle = Addressables.LoadAssetAsync<GameObject>("ItemAppearance");
            handle.Completed += (result) =>
            {
                appearanceItem = result.Result;
            };


            StartCoroutine(LoadSettingAssets());
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            if (condition == Condition.Deck || condition == Condition.DeckEditor)
            {
                EventSystem.current.SetSelectedGameObject(Manager.GetElement("Page10 Pickup"));
                Manager.GetElement<SelectionToggle_AppearanceGenre>("Page10 Pickup").SetToggleOn();

                deckName.text = Program.instance.editDeck.input.text;
                mainCount.text = Program.instance.editDeck.mainCount.ToString();
                extraCount.text = Program.instance.editDeck.extraCount.ToString();
                sideCount.text = Program.instance.editDeck.sideCount.ToString();
                foreach (var card in Program.instance.editDeck.cards)
                {
                    card.transform.SetParent(cardsRoot, false);
                    card.RefreshPositionInstant();
                }
                PrePick();
            }
            else
            {
                EventSystem.current.SetSelectedGameObject(Manager.GetElement("Page0 PlayerName"));
                Manager.GetElement<SelectionToggle_AppearanceGenre>("Page0 PlayerName").SetToggleOn();
            }

            defaultPlayerToggle.SetToggleOn();

            base.ApplyShowArrangement(preDepth);
        }

        public override void OnReturn()
        {
            if (inTransition) return;
            if (returnAction != null)
            {
                returnAction.Invoke();
                return;
            }
            AudioManager.PlaySE("SE_MENU_CANCEL");
            GameObject selected = EventSystem.current.currentSelectedGameObject;

            if (selected == null)
                OnExit();
            else if (Cursor.lockState == CursorLockMode.None)
                OnExit();
            else if (selected.TryGetComponent<SelectionToggle_AppearanceItem>(out _) 
                ||selected == inputPlayerName.gameObject)
            {
                if (lastSelectedToggle != null)
                    EventSystem.current.SetSelectedGameObject(lastSelectedToggle.gameObject);
                else
                {
                    if(condition == Condition.Deck || condition == Condition.DeckEditor)
                        EventSystem.current.SetSelectedGameObject(Manager.GetElement("Page4 Case"));
                    else
                        EventSystem.current.SetSelectedGameObject(Manager.GetElement("Page0 PlayerName"));
                }
            }
            else
                OnExit();
        }

        public override void OnExit()
        {
            if (condition != Condition.Deck && condition != Condition.DeckEditor)
            {
                if (Program.instance.currentSubServant == this)
                    Program.instance.ShowSubServant(Program.instance.setting);
                else
                    Program.instance.ShiftToServant(Program.instance.setting);

                Program.instance.setting.RefreshAppearanceModeText();

                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    foreach (var pool in pools)
                    {
                        foreach (var item in pool.Value)
                            item.GetComponent<SelectionToggle_AppearanceItem>().Dispose();
                        pool.Value.Clear();
                    }
                    Config.Save();
                });

                if (UIManager.currentWallpaper != Config.Get("Wallpaper", Program.items.wallpapers[0].id.ToString()))
                {
                    UIManager.currentWallpaper = Config.Get("Wallpaper", Program.items.wallpapers[0].id.ToString());
                    Program.instance.ui_.ChangeWallpaper(UIManager.currentWallpaper);
                }
            }
            else if (condition == Condition.Deck)
            {
                Program.instance.ShiftToServant(Program.instance.editDeck);
                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    foreach (var pool in pools)
                    {
                        foreach (var item in pool.Value)
                            item.GetComponent<SelectionToggle_AppearanceItem>().Dispose();
                        pool.Value.Clear();
                    }
                });
                Program.instance.editDeck.deck.Pickup.Clear();
                foreach (var card in Program.instance.editDeck.cards)
                {
                    card.transform.SetParent(Program.instance.editDeck.cardsOnEditParent, false);
                    card.RefreshPositionInstant();
                    if (card.picked)
                        Program.instance.editDeck.deck.Pickup.Add(card.Code);
                    card.PickUp(false);
                }
            }
            else
            {
                Program.instance.ShiftToServant(Program.instance.deckEditor);

            }
        }

        public override void PerFrameFunction()
        {
            if (!showing) return;
            if (NeedResponseInput())
            {
                if (UserInput.WasLeftShoulderPressed)
                    if(Manager.GetElement("PlayerToggle0").activeInHierarchy)
                        Manager.GetElement<SelectionToggle_AppearancePlayer>("PlayerToggle0").OnLeftSelection();
                if (UserInput.WasRightShoulderPressed)
                    if (Manager.GetElement("PlayerToggle0").activeInHierarchy)
                        Manager.GetElement<SelectionToggle_AppearancePlayer>("PlayerToggle0").OnRightSelection();

                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                    OnReturn();
            }
        }

        protected override bool NeedResponseInput()
        {
            if(inputPlayerName.isFocused)
                return false;
            return base.NeedResponseInput();
        }

        public override void SelectLastSelectable()
        {
            if (Selected != null)
            {
                if (Selected.TryGetComponent<SelectionToggle_CharacterItem>(out _))
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else if (Selected.TryGetComponent<SelectionToggle_CharacterSeries>(out _))
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement(condition == Condition.Deck 
                        || condition == Condition.DeckEditor ? "Page10 Pickup" : "Page0 PlayerName"));
            }
            else
                EventSystem.current.SetSelectedGameObject(Manager.GetElement(condition == Condition.Deck 
                    || condition == Condition.DeckEditor ? "Page10 Pickup" : "Page0 PlayerName"));
        }

        #endregion

        public void SetDetailName(string itemName)
        {
            Manager.GetElement<TextMeshProUGUI>("DetailSetting").text = itemName;
        }

        public void SetDetailDescription(string description)
        {
            Manager.GetElement<TextMeshProUGUI>("DetailDesc").text = description;
        }
        public void SetHoverText(string text)
        {
            Manager.GetElement<TextMeshProUGUI>("HoverText").text = text;
        }
        public void SetDetailImage(Sprite sprite)
        {
            Manager.GetElement<Image>("Image").sprite = sprite;
            Manager.GetElement("Image").SetActive(true);
            Manager.GetElement("RawImage").SetActive(false);
        }
        public void SetDetailImageMaterial(Material mat)
        {
            Manager.GetElement<Image>("Image").material = mat;
            Manager.GetElement("Image").SetActive(true);
            Manager.GetElement("RawImage").SetActive(false);
        }
        public void SetDetailRawImageMaterial(Material mat)
        {
            Manager.GetElement<RawImage>("RawImage").material = mat;
            Manager.GetElement("RawImage").SetActive(true);
            Manager.GetElement("Image").SetActive(false);
        }

        public static bool loaded;
        public IEnumerator LoadSettingAssets()
        {
            loaded = false;

            #region Face
            var ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFace0", Program.items.faces[0].id.ToString()), Items.ItemType.Face, 0);
            while (ie.MoveNext())
                yield return null;
            duelFace0 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFace1", Program.items.faces[0].id.ToString()), Items.ItemType.Face, 1);
            while (ie.MoveNext())
                yield return null;
            duelFace1 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFace0Tag", Program.items.faces[0].id.ToString()), Items.ItemType.Face, 2);
            while (ie.MoveNext())
                yield return null;
            duelFace0Tag = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFace1Tag", Program.items.faces[0].id.ToString()), Items.ItemType.Face, 3);
            while (ie.MoveNext())
                yield return null;
            duelFace1Tag = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFace0", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            watchFace0 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFace1", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            watchFace1 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFace0Tag", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            watchFace0Tag = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFace1Tag", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            watchFace1Tag = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFace0", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            replayFace0 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFace1", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            replayFace1 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFace0Tag", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            replayFace0Tag = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFace1Tag", Program.items.faces[0].id.ToString()), Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            replayFace1Tag = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync("1010039", Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            defaultFace0 = ie.Current;

            ie = Program.items.LoadConcreteItemIconAsync("1010001", Items.ItemType.Face);
            while (ie.MoveNext())
                yield return null;
            defaultFace1 = ie.Current;

            #endregion

            #region Frame

            Sprite duelFrame0;
            Sprite duelFrame1;
            Sprite watchFrame0;
            Sprite watchFrame1;
            Sprite replayFrame0;
            Sprite replayFrame1;
            Sprite duelFrame0Tag;
            Sprite duelFrame1Tag;
            Sprite watchFrame0Tag;
            Sprite watchFrame1Tag;
            Sprite replayFrame0Tag;
            Sprite replayFrame1Tag;

            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFrame0", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            duelFrame0 = ie.Current;

            var im = ABLoader.LoadFrameMaterial(Config.Get("DuelFrame0", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelFrameMat0 = im.Current;
            duelFrameMat0.SetTexture("_ProfileFrameTex", duelFrame0.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFrame1", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            duelFrame1 = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("DuelFrame1", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelFrameMat1 = im.Current;
            duelFrameMat1.SetTexture("_ProfileFrameTex", duelFrame1.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFrame0Tag", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            duelFrame0Tag = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("DuelFrame0Tag", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelFrameMat0Tag = im.Current;
            duelFrameMat0Tag.SetTexture("_ProfileFrameTex", duelFrame0Tag.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("DuelFrame1Tag", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            duelFrame1Tag = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("DuelFrame1Tag", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelFrameMat1Tag = im.Current;
            duelFrameMat1Tag.SetTexture("_ProfileFrameTex", duelFrame1Tag.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFrame0", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            watchFrame0 = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("WatchFrame0", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchFrameMat0 = im.Current;
            watchFrameMat0.SetTexture("_ProfileFrameTex", watchFrame0.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFrame1", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            watchFrame1 = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("WatchFrame1", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchFrameMat1 = im.Current;
            watchFrameMat1.SetTexture("_ProfileFrameTex", watchFrame1.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFrame0Tag", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            watchFrame0Tag = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("WatchFrame0Tag", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchFrameMat0Tag = im.Current;
            watchFrameMat0Tag.SetTexture("_ProfileFrameTex", watchFrame0Tag.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("WatchFrame1Tag", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            watchFrame1Tag = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("WatchFrame1Tag", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchFrameMat1Tag = im.Current;
            watchFrameMat1Tag.SetTexture("_ProfileFrameTex", watchFrame1Tag.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFrame0", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            replayFrame0 = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("ReplayFrame0", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayFrameMat0 = im.Current;
            replayFrameMat0.SetTexture("_ProfileFrameTex", replayFrame0.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFrame1", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            replayFrame1 = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("ReplayFrame1", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayFrameMat1 = im.Current;
            replayFrameMat1.SetTexture("_ProfileFrameTex", replayFrame1.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFrame0Tag", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            replayFrame0Tag = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("ReplayFrame0Tag", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayFrameMat0Tag = im.Current;
            replayFrameMat0Tag.SetTexture("_ProfileFrameTex", replayFrame0Tag.texture);


            ie = Program.items.LoadConcreteItemIconAsync(Config.Get("ReplayFrame1Tag", Program.items.frames[0].id.ToString()), Items.ItemType.Frame);
            while (ie.MoveNext())
                yield return null;
            replayFrame1Tag = ie.Current;

            im = ABLoader.LoadFrameMaterial(Config.Get("ReplayFrame1Tag", Program.items.frames[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayFrameMat1Tag = im.Current;
            replayFrameMat1Tag.SetTexture("_ProfileFrameTex", replayFrame1Tag.texture);

            #endregion

            #region Protector
            im = ABLoader.LoadProtectorMaterial(Config.Get("DuelProtector0", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelProtector0 = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("DuelProtector1", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelProtector1 = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("DuelProtector0Tag", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelProtector0Tag = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("DuelProtector1Tag", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            duelProtector1Tag = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("WatchProtector0", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchProtector0 = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("WatchProtector1", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchProtector1 = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("WatchProtector0Tag", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchProtector0Tag = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("WatchProtector1Tag", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            watchProtector1Tag = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("ReplayProtector0", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayProtector0 = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("ReplayProtector1", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayProtector1 = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("ReplayProtector0Tag", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayProtector0Tag = im.Current;

            im = ABLoader.LoadProtectorMaterial(Config.Get("ReplayProtector1Tag", Program.items.protectors[0].id.ToString()));
            while (im.MoveNext())
                yield return null;
            replayProtector1Tag = im.Current;

            #endregion

            loaded = true;
        }

        private void SavePlayerName(string nameValue)
        {
            Config.Set(condition.ToString() + "PlayerName" + player, nameValue == "" ? "@ui" : nameValue);
            inputPlayerName.text = Config.Get(condition.ToString() + "PlayerName" + player, "@ui");
        }


        public static string currentContent = "PlayerName";
        private static List<Items.Item> targetItems;
        private static List<GameObject> currentList;
        private static List<GameObject> onlyOpSideShowItems = new();
        public void ShowItems(string type)
        {
            currentContent = type;
            pools.TryGetValue(currentContent, out currentList);
            if (condition == Condition.Deck || condition == Condition.DeckEditor)
                defaultPlayerToggle.transform.parent.gameObject.SetActive(false);
            else
                defaultPlayerToggle.transform.parent.gameObject.SetActive(true);
            table.SetActive(false);
            cardsRoot.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -1080f);

            var detial = Manager.GetElement<CanvasGroup>("Details");
            var scrollView = Manager.GetElement<ScrollRect>("ScrollRect");

            if (currentContent == "PlayerName")
            {
                scrollView.GetComponent<CanvasGroup>().alpha = 0;
                scrollView.GetComponent<CanvasGroup>().blocksRaycasts = false;
                detial.alpha = 0f;
                inputPlayerName.transform.parent.parent.gameObject.SetActive(true);

                inputPlayerName.text = Config.Get(condition.ToString() + currentContent + player, "");
                var playerNameEx = Manager.GetElement<TextMeshProUGUI>("InputHint");
                if (player == "0")
                    playerNameEx.text = InterString.Get("请输入您的昵称：");
                else if (player == "1")
                    playerNameEx.text = InterString.Get("请输入对方的昵称，留空则显示真实昵称：");
                else if (player == "0Tag")
                    playerNameEx.text = InterString.Get("请输入您的队友的昵称，留空则显示真实昵称：");
                else if (player == "1Tag")
                    playerNameEx.text = InterString.Get("请输入对方的队友的昵称，留空则显示真实昵称：");
                return;
            }
            else if (currentContent == "Pickup")
            {
                scrollView.GetComponent<CanvasGroup>().alpha = 0f;
                scrollView.GetComponent<CanvasGroup>().blocksRaycasts = false;
                detial.alpha = 0f;
                inputPlayerName.transform.parent.parent.gameObject.SetActive(false);
                table.gameObject.SetActive(true);
                cardsRoot.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

                return;
            }
            else if (currentContent == "Wallpaper")
            {
                defaultPlayerToggle.transform.parent.gameObject.SetActive(false);
            }

            scrollView.GetComponent<CanvasGroup>().alpha = 1.0f;
            scrollView.GetComponent<CanvasGroup>().blocksRaycasts = true;
            detial.alpha = 1f;
            inputPlayerName.transform.parent.parent.gameObject.SetActive(false);
            table.SetActive(false);

            bool isWallpaper = false;
            switch (currentContent)
            {
                case "Wallpaper":
                    targetItems = Program.items.wallpapers;
                    isWallpaper = true;
                    break;
                case "Face":
                    targetItems = Program.items.faces;
                    break;
                case "Frame":
                    targetItems = Program.items.frames;
                    break;
                case "Protector":
                    targetItems = Program.items.protectors;
                    break;
                case "Field":
                    targetItems = Program.items.mats;
                    break;
                case "Grave":
                    targetItems = Program.items.graves;
                    break;
                case "Stand":
                    targetItems = Program.items.stands;
                    break;
                case "Mate":
                    targetItems = Program.items.mates;
                    break;
                case "Case":
                    targetItems = Program.items.cases;
                    break;
                default:
                    targetItems = Program.items.mates;
                    break;
            }


            foreach (var pool in pools)
                if (pool.Key != currentContent)
                    foreach (var item in pool.Value)
                        item.GetComponent<SelectionToggle_AppearanceItem>().Hide();

            if (currentList.Count == 0)
            {
                int itemCount = 0;
                for (int i = 0; i < targetItems.Count; i++)
                {
                    GameObject item = Instantiate(appearanceItem);
                    var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                    itemMono.index = i;
                    itemCount = itemMono.index;
                    itemMono.itemID = targetItems[i].id;
                    itemMono.description = targetItems[i].description;
                    itemMono.itemName = targetItems[i].name;
                    itemMono.path = Items.CodeToIconPath(itemMono.itemID.ToString());
                    itemMono.transform.SetParent(scrollView.content, false);
                    itemMono.Refresh();
                    currentList.Add(item);
                }

#if UNITY_ANDROID
                if (currentContent == "Mate")
                {
                    var files = new DirectoryInfo(Program.root + "CrossDuel").GetFiles("*.bundle");
                    for (int i = 0; i < files.Length; i++)
                    {
                        int code = int.Parse(files[i].Name.Replace(".bundle", ""));
                        var card = CardsManager.Get(code, true);
                        GameObject item = Instantiate(appearanceItem);
                        var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                        itemMono.index = i + targetItems.Count;
                        itemCount = itemMono.index;
                        itemMono.itemID = code;
                        if (card.Id == 0)
                            itemMono.itemName = MateView.GetRushDuelMateName(code);
                        else
                            itemMono.itemName = card.Name;
                        itemMono.description = card.Desc;
                        itemMono.path = string.Empty;
                        itemMono.transform.SetParent(scrollView.content, false);
                        itemMono.Refresh();
                        currentList.Add(item);
                    }
                }
#endif
                if(condition != Condition.Deck && condition != Condition.DeckEditor)
                {
                    if (Program.items.ListHaveNone(targetItems))
                    {
                        GameObject item = Instantiate(appearanceItem);
                        var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                        itemMono.index = ++itemCount;
                        itemMono.itemID = Items.noneCode;
                        itemMono.description = InterString.Get("该项设置将设置为无。");
                        itemMono.itemName = InterString.Get("不设置");
                        itemMono.path = (isWallpaper ? "WallPaperIcon" : string.Empty) + Items.noneIconPath;
                        itemMono.transform.SetParent(scrollView.content, false);
                        itemMono.Refresh();
                        currentList.Add(item);
                    }

                    if (Program.items.ListHaveRandom(targetItems))
                    {
                        GameObject item = Instantiate(appearanceItem);
                        var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                        itemMono.index = ++itemCount;
                        itemMono.itemID = Items.randomCode;
                        itemMono.description = InterString.Get("该项设置将随机设置。");
                        itemMono.itemName = InterString.Get("随机");
                        itemMono.path = (isWallpaper ? "WallPaperIcon" : string.Empty) + Items.randomIconPath;
                        itemMono.transform.SetParent(scrollView.content, false);
                        itemMono.Refresh();
                        currentList.Add(item);
                    }
                    if (Program.items.ListHaveSame(targetItems))
                    {
                        GameObject item = Instantiate(appearanceItem);
                        var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                        itemMono.index = ++itemCount;
                        itemMono.itemID = Items.sameCode;
                        itemMono.description = InterString.Get("该项设置将与场地设置保持一致。");
                        itemMono.itemName = InterString.Get("一致");
                        itemMono.path = Items.sameIconPath;
                        itemMono.transform.SetParent(scrollView.content, false);
                        itemMono.Refresh();
                        currentList.Add(item);
                    }

                    if (Program.items.ListHaveDIY(targetItems))
                    {
                        GameObject item = Instantiate(appearanceItem);
                        var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                        itemMono.index = ++itemCount;
                        itemMono.itemID = Items.diyCode;
                        itemMono.description = InterString.Get("我方头像：") + 
                                                                Program.diyPath + meString + Program.pngExpansion + "\n" +
                                                                InterString.Get("对方头像：") + 
                                                                Program.diyPath + opString + Program.pngExpansion + "\n" +
                                                                InterString.Get("我方队友头像：") +
                                                                Program.diyPath + meTagString + Program.pngExpansion + "\n" +
                                                                InterString.Get("对方队友头像：") +
                                                                Program.diyPath + opTagString + Program.pngExpansion;
                        itemMono.itemName = InterString.Get("自定义");
                        itemMono.path = Items.diyIconPath;
                        itemMono.transform.SetParent(scrollView.content, false);
                        itemMono.Refresh();
                        currentList.Add(item);
                    }

                    if (targetItems == Program.items.mats)
                    {
                        GameObject item = Instantiate(appearanceItem);
                        var itemMono = item.GetComponent<SelectionToggle_AppearanceItem>();
                        itemMono.index = ++itemCount;
                        itemMono.itemID = Items.sameCode;
                        itemMono.description = InterString.Get("该项设置将与我方场地设置保持一致。");
                        itemMono.itemName = InterString.Get("一致");
                        itemMono.path = Items.sameIconPath;
                        itemMono.transform.SetParent(scrollView.content, false);
                        itemMono.Refresh();
                        currentList.Add(item);
                        onlyOpSideShowItems.Add(item);
                    }
                }
            }
            foreach (var item in currentList)
            {
                if (player.Contains("0") && onlyOpSideShowItems.Contains(item))
                    item.SetActive(false);
                else
                    item.SetActive(true);
                item.GetComponent<SelectionToggle_AppearanceItem>().Show();
            }
            foreach (var item in currentList)
            {
                if (currentContent == "Wallpaper")
                {
                    if (item.GetComponent<SelectionToggle_AppearanceItem>().itemID.ToString() == Config.Get("Wallpaper", targetItems[0].id.ToString()))
                    {
                        item.GetComponent<SelectionToggle_AppearanceItem>().SetToggleOn();
                        break;
                    }
                }
                else
                {
                    var itemID = item.GetComponent<SelectionToggle_AppearanceItem>().itemID;

                    if (condition == Condition.Deck)
                    {
                        if (itemID == Program.instance.editDeck.deck.Case
                            || itemID == Program.instance.editDeck.deck.Protector
                            || itemID == Program.instance.editDeck.deck.Field
                            || itemID == Program.instance.editDeck.deck.Grave
                            || itemID == Program.instance.editDeck.deck.Stand
                            || itemID == Program.instance.editDeck.deck.Mate)
                        {
                            item.GetComponent<SelectionToggle_AppearanceItem>().SetToggleOn();
                            break;
                        }
                    }
                    else if(condition == Condition.DeckEditor)
                    {
                        if (itemID == DeckEditor.Deck.Case
                            || itemID == DeckEditor.Deck.Protector
                            || itemID == DeckEditor.Deck.Field
                            || itemID == DeckEditor.Deck.Grave
                            || itemID == DeckEditor.Deck.Stand
                            || itemID == DeckEditor.Deck.Mate)
                        {
                            item.GetComponent<SelectionToggle_AppearanceItem>().SetToggleOn();
                            break;
                        }
                    }
                    else
                    {
                        if (itemID.ToString() == Config.Get(Program.instance.appearance.condition.ToString() + currentContent + player, targetItems[0].id.ToString()))
                        {
                            item.GetComponent<SelectionToggle_AppearanceItem>().SetToggleOn();
                            break;
                        }
                    }
                }
            }
        }

        public void SwitchPlayer(string player)
        {
            Appearance.player = player;
            var btnOverride = Manager.GetElement<SelectionToggle>("ToggleOverwrite");
            if (condition == Condition.Duel)
            {
                if(player == "0")
                {
                    btnOverride.gameObject.SetActive(true);
                    if (Config.GetBool("OverrideDeckAppearance", false))
                        btnOverride.SetToggleOn();
                    else
                        btnOverride.SetToggleOff();
                }
                else
                    btnOverride.gameObject.SetActive(false);
            }
            else
                btnOverride.gameObject.SetActive(false);
            if (showing)
                ShowItems(currentContent);
        }

        int pickCount;
        public void PickThis(CardInDeck card)
        {
            if (!card.picked)
            {
                if (pickCount > 2)
                    return;
                else
                {
                    pickCount++;
                    card.PickUp(true);
                }
            }
            else
            {
                pickCount--;
                card.PickUp(false);
            }
        }
        void PrePick()
        {
            if (condition == Condition.Deck)
            {
                pickCount = 0;
                for (int i = 0; i < Program.instance.editDeck.deck.Pickup.Count; i++)
                {
                    foreach (var card in Program.instance.editDeck.cards)
                    {
                        if (card.Code == Program.instance.editDeck.deck.Pickup[i])
                        {
                            pickCount++;
                            card.PickUp(true);
                            break;
                        }
                    }
                }
            }
            else if(condition == Condition.DeckEditor)
            {

            }
        }

        public void SetOverride(bool over)
        {
            if (!showing)
                return;
            Config.SetBool("OverrideDeckAppearance", over);
        }

        public int GetCurrentGenreCount()
        {
            foreach (var pool in pools)
                if (pool.Key == currentContent)
                    return pool.Value.Count;
            return 0;
        }

        public GameObject GetCurrentContentItem()
        {
            if (currentContent == "PlayerName")
                return inputPlayerName.gameObject;
            if (currentContent == "Pickup")
                return null;
            //TODO
            if(lastSelectedItem != null && lastSelectedItem.gameObject.activeSelf)
                return lastSelectedItem.gameObject;
            return Manager.GetElement<ScrollRect>("ScrollRect").content.GetChild(0).gameObject;
        }

        public void SelectPlayerNameToggle()
        {
            UserInput.NextSelectionIsAxis = true;
            EventSystem.current.SetSelectedGameObject(Manager.GetElement("Page0 PlayerName"));
        }
    }
}
