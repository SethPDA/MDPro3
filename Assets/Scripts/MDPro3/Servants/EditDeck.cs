using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.UI;
using Toggle = MDPro3.UI.Toggle;
using MDPro3.Net;

namespace MDPro3
{
    public class EditDeck : Servant
    {
        public InputField input;
        public Text textMainCount;
        public Text textExtraCount;
        public Text textSideCount;
        public Image deckCase;

        int m_mainCount;
        public int mainCount
        {
            get { return m_mainCount; }
            set
            {
                m_mainCount = value;
                textMainCount.text = m_mainCount.ToString();
            }
        }
        int m_extraCount;
        public int extraCount
        {
            get { return m_extraCount; }
            set
            {
                m_extraCount = value;
                textExtraCount.text = m_extraCount.ToString();
            }
        }
        int m_sideCount;
        public int sideCount
        {
            get { return m_sideCount; }
            set
            {
                m_sideCount = value;
                textSideCount.text = m_sideCount.ToString();
            }
        }

        public Transform cardsOnEditParent;
        public GameObject itemInDeck;
        public GameObject itemOnList;
        public List<CardInDeck> cards = new List<CardInDeck>();

        Tabs tabs;

        public bool dirty;
        string deckName;
        public Deck deck;
        public string onlineDeckID;
        public bool deckIsFromLocalFile;
        public static bool liked;

        Deck history;

        Card cardShowing;
        int cardIndex;
        public Banlist banlist;
        public static string pack = "";
        SuperScrollView superScrollView;
        bool intoAppearance;

        public override void Initialize()
        {
            showLine = false;
            depth = 5;
            returnServant = Program.instance.selectDeck;
            deckIsFromLocalFile = true;

            base.Initialize();
            Manager.GetElement<Button>("CardButton").onClick.AddListener(ShowDetail);
            tabs = Manager.GetElement<Tabs>("List");
            tabs.tabs[0].onSelected = OnList;
            tabs.tabs[1].onSelected = OnBook;
            tabs.tabs[2].onSelected = OnHistory;

            banlist = BanlistManager.Banlists[0];
            Manager.GetElement<Text>("TextBanlist").text = banlist.Name;
            Manager.GetElement<Button>("ButtonAppearance").onClick.AddListener(ShowAppearance);
            Manager.GetElement<Button>("ButtonBanlist").onClick.AddListener(ShowBanlists);
            Manager.GetElement<InputField>("InputSearch").onEndEdit.AddListener(OnSearch);
            Manager.GetElement<InputField>("InputSearch").onEndEdit.AddListener(OnSearch);
            Manager.GetElement<Button>("ButtonSearch").onClick.AddListener(OnClickSearch);

            SystemEvent.OnResolutionChange += AdjustSize;
            AdjustSize();

            var handle = Addressables.LoadAssetAsync<GameObject>("CardInDeck");
            handle.Completed += (result) =>
            {
                itemInDeck = result.Result;
            };
            handle = Addressables.LoadAssetAsync<GameObject>("CardInCollection");
            handle.Completed += (result) =>
            {
                itemOnList = result.Result;
            };
        }

        public enum Condition
        {
            EditDeck,
            OnlineDeck,
            ReplayDeck,
            ChangeSide
        }
        public Condition condition = Condition.EditDeck;
        public void SwitchCondition(Condition condition, string deckName = "", Deck deck = null)
        {
            this.condition = condition;
            if (condition == Condition.EditDeck)
            {
                returnServant = Program.instance.selectDeck;
                Manager.GetElement("ButtonChangeSide").SetActive(false);
                Manager.GetElement("ButtonAppearance").SetActive(true);

                this.deckName = Config.Get("DeckInUse", "");
                this.deck = new Deck(Program.deckPath + this.deckName + Program.ydkExpansion);
                deckIsFromLocalFile = true;
                history = new();
            }
            else if (condition == Condition.ChangeSide)
            {
                Manager.GetElement("ButtonChangeSide").SetActive(true);
                Manager.GetElement("ButtonAppearance").SetActive(false);

                this.deckName = Config.Get("DeckInUse", "");
                this.deck = TcpHelper.deck;
                deckIsFromLocalFile = false;
                history = Program.instance.ocgcore.sideReference;
                tabs.tabs[2].TabThis();
            }
            else if(condition == Condition.OnlineDeck) 
            {
                returnServant = Program.instance.onlineDeckViewer;
                Manager.GetElement("ButtonChangeSide").SetActive(false);
                Manager.GetElement("ButtonAppearance").SetActive(true);

                this.deck = null;
                deckIsFromLocalFile = false;
                history = new Deck();
            }
            else if (condition == Condition.ReplayDeck)
            {
                returnServant = Program.instance.replay;
                Manager.GetElement("ButtonChangeSide").SetActive(false);
                Manager.GetElement("ButtonAppearance").SetActive(true);

                this.deckName = deckName;
                this.deck = deck;
                deckIsFromLocalFile = false;
                history = new Deck();
            }
            RefreshLikeButton();
        }

        void RefreshLikeButton()
        {
            input.interactable = deckIsFromLocalFile;

            if (!deckIsFromLocalFile && condition == Condition.OnlineDeck)
            {
                Manager.GetElement<Text>("TextLike").text = InterString.Get("点赞");
                Manager.GetElement("ButtonLike").SetActive(!liked);
                return;
            }

            if (MyCard.account == null || !deckIsFromLocalFile)
            {
                Manager.GetElement("ButtonLike").SetActive(false);
            }
            else
            {
                var onlineDeck = OnlineDeck.GetByID(deck.deckId);
                if (onlineDeck == null || onlineDeck.isDelete)
                    Manager.GetElement("ButtonLike").SetActive(false);
                else
                {
                    Manager.GetElement("ButtonLike").SetActive(true);
                    if (onlineDeck.isPublic)
                        Manager.GetElement<Text>("TextLike").text = InterString.Get("公开中");
                    else if (!onlineDeck.isPublic)
                        Manager.GetElement<Text>("TextLike").text = InterString.Get("非公开中");
                }
            }
        }

        public void SetBanlistName(string listName)
        {
            Manager.GetElement<Text>("TextBanlist").text = listName;
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            UIManager.SetCanvasMatch(0f, transitionTime);
            if (toHandTest)
            {
                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    cg.alpha = 1f;
                    cg.blocksRaycasts = true;
                });
            }
            else
            {
                if (intoAppearance)
                    intoAppearance = false;
                else
                {
                    AudioManager.PlayBGM("BGM_MENU_02");
                    Manager.GetElement("Group").SetActive(false);
                    ScrollViewInstall();
                    StartCoroutine(RefreshAsync());
                    StartCoroutine(RefreshIcons());
                }
            }
            toHandTest = false;
            liked = false;
        }

        protected override void ApplyHideArrangement(int preDepth)
        {
            base.ApplyHideArrangement(preDepth);
            UIManager.SetCanvasMatch(1f, transitionTime);
            if (!toHandTest && !intoAppearance)
            {
                AudioManager.PlayBGM("BGM_MENU_01");
                CardRarity.Save();

                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    Dispose();
                    if (superScrollView != null)
                        foreach (var item in superScrollView.items)
                            item.gameObject.GetComponent<SuperScrollViewItemForDeckEdit>().Dispose();
                });
            }
        }


        public override void OnReturn()
        {
            if (!dirty || !deckIsFromLocalFile)
                base.OnReturn();
            else
            {
                List<string> selections = new List<string>
                {
                    InterString.Get("卡组未保存"),
                    InterString.Get("卡组已修改，是否保存？"),
                    InterString.Get("保存"),
                    InterString.Get("不保存")
                };
                UIManager.ShowPopupYesOrNo(selections, OnSave, OnExit);
            }
        }

        bool refreshFailed = false;
        IEnumerator RefreshAsync()
        {
            refreshFailed = false;
            if (deck == null)
            {
                var task = OnlineDeck.GetDeck(onlineDeckID);
                while(!task.IsCompleted)
                    yield return null;
                var onlineDeckData = task.Result;
                if(onlineDeckData == null)
                {
                    refreshFailed = true;
                    MessageManager.Cast(InterString.Get("网络异常，获取在线卡组失败。"));
                    yield break;
                }

                deckName = onlineDeckData.deckName;
                deck = new Deck(onlineDeckData.deckYdk, onlineDeckData.deckContributor);
            }

            mainCount = deck.Main.Count;
            extraCount = deck.Extra.Count;
            sideCount = deck.Side.Count;
            input.text = deckName;

            var casePath = deck.Case.ToString();
            var ie = Program.items.LoadItemIconAsync(casePath, Items.ItemType.Case);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            deckCase.sprite = ie.Current;

            for (int i = 0; i < deck.Main.Count; i++)
            {
                if (!showing)
                    yield break;
                var card = Instantiate(itemInDeck);
                card.transform.SetParent(cardsOnEditParent, false);
                var mono = card.GetComponent<CardInDeck>();
                mono.id = i;
                mono.Code = deck.Main[i];
                mono.RefreshPosition();
                cards.Add(mono);
                yield return null;
            }
            for (int i = 0; i < deck.Extra.Count; i++)
            {
                if (!showing)
                    yield break;
                var card = Instantiate(itemInDeck);
                card.transform.SetParent(cardsOnEditParent, false);
                var mono = card.GetComponent<CardInDeck>();
                mono.id = i + 1000;
                mono.Code = deck.Extra[i];
                mono.RefreshPosition();
                cards.Add(mono);
                yield return null;
            }
            for (int i = 0; i < deck.Side.Count; i++)
            {
                if (!showing)
                    yield break;
                var card = Instantiate(itemInDeck);
                card.transform.SetParent(cardsOnEditParent, false);
                var mono = card.GetComponent<CardInDeck>();
                mono.id = i + 2000;
                mono.Code = deck.Side[i];
                mono.RefreshPosition();
                cards.Add(mono);
                yield return null;
            }
            dirty = false;
            yield return null;
        }

        IEnumerator RefreshIcons()
        {
            Manager.GetElement<Image>("IconCase").color = Color.clear;
            Manager.GetElement<Image>("IconProtector").color = Color.clear;
            Manager.GetElement<Image>("IconField").color = Color.clear;
            Manager.GetElement<Image>("IconGrave").color = Color.clear;
            Manager.GetElement<Image>("IconStand").color = Color.clear;
            Manager.GetElement<Image>("IconMate").color = Color.clear;
            Manager.GetElement<Tabs>("List").AdjustSize();

            while (deck == null)
            {
                if(refreshFailed) 
                    yield break;
                yield return null;
            }

            var ie = Program.items.LoadItemIconAsync(deck.Case.ToString(), Items.ItemType.Case);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            Manager.GetElement<Image>("IconCase").color = Color.white;
            Manager.GetElement<Image>("IconCase").sprite = ie.Current;

            var im = ABLoader.LoadProtectorMaterial(deck.Protector.ToString());
            StartCoroutine(im);
            while (im.MoveNext())
                yield return null;
            Manager.GetElement<Image>("IconProtector").color = Color.white;
            Manager.GetElement<Image>("IconProtector").material = im.Current;

            ie = Program.items.LoadItemIconAsync(deck.Field.ToString(), Items.ItemType.Mat);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            Manager.GetElement<Image>("IconField").color = Color.white;
            Manager.GetElement<Image>("IconField").sprite = ie.Current;

            ie = Program.items.LoadItemIconAsync(deck.Grave.ToString(), Items.ItemType.Grave);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            Manager.GetElement<Image>("IconGrave").color = Color.white;
            Manager.GetElement<Image>("IconGrave").sprite = ie.Current;

            ie = Program.items.LoadItemIconAsync(deck.Stand.ToString(), Items.ItemType.Stand);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            Manager.GetElement<Image>("IconStand").color = Color.white;
            Manager.GetElement<Image>("IconStand").sprite = ie.Current;

            var mate = deck.Mate.ToString();
            if (mate.Length == 7 && mate.StartsWith("100"))
            {
                ie = Program.items.LoadItemIconAsync(mate, Items.ItemType.Mate);
                StartCoroutine(ie);
                while (ie.MoveNext())
                    yield return null;
                Manager.GetElement<Image>("IconMate").color = Color.white;
                Manager.GetElement<Image>("IconMate").sprite = ie.Current;
            }
            else
            {
                var task = TextureManager.LoadArtAsync(deck.Mate, true);
                while(!task.IsCompleted)
                    yield return null;
                Manager.GetElement<Image>("IconMate").color = Color.white;
                Manager.GetElement<Image>("IconMate").sprite = TextureManager.Texture2Sprite(task.Result);
            }
        }
        void Dispose()
        {
            foreach (var card in cards)
            {
                card.transform.SetParent(Program.instance.container_2D, false);
                card.Dispose();
            }
            cards.Clear();
        }

        public void OnRelatedDescripton()
        {
            var cardFace = Manager.GetElement<RawImage>("RawImageRelatedCard").texture;
            var mat = Manager.GetElement<RawImage>("RawImageRelatedCard").material;
            Description(relatedCard.Id, cardFace, mat);
        }

        Texture showingFace;
        public void Description(int code, Texture cardFace, Material mat, bool inHistory = true, int cardIndex = -1)
        {
            var data = CardsManager.Get(code);
            if (data.Id == 0)
                return;
            if (condition != Condition.ChangeSide && inHistory)
            {
                if (history.Main.Contains(code))
                    history.Main.Remove(code);
                history.Main.Insert(0, code);
                if (Manager.GetElement<Tab>("TabHistory").selected)
                    PrintHistoryCards();
            }
            Manager.GetElement("Group").SetActive(true);
            cardShowing = data;
            this.cardIndex = cardIndex;
            showingFace = cardFace;
            Manager.GetElement<RawImage>("Card").texture = showingFace;
            Manager.GetElement<RawImage>("Card").material = mat;
            Manager.GetElement<Text>("TextName").text = data.Name;
            var colors = CardDescription.GetCardFrameColor(data);
            Manager.GetElement<Image>("BaseName").color = colors[0];
            Manager.GetElement<Image>("BaseType").color = colors[1];
            Manager.GetElement<Image>("Attribute").sprite = CardDescription.GetCardAttribute(data).sprite;
            Manager.GetElement<Text>("TextType").text = StringHelper.GetType(data);

            Manager.GetElement("Tuner").SetActive(false);

            if (data.HasType(CardType.Monster))
            {
                Manager.GetElement("PropertyMonster").SetActive(true);
                Manager.GetElement("PropertySpell").SetActive(false);
                Manager.GetElement<Image>("Level").sprite = TextureManager.GetCardLevelIcon(data);
                Manager.GetElement<Text>("TextAttack").text = data.Attack == -2 ? "?" : data.Attack.ToString();
                Manager.GetElement<Image>("Race").sprite = CardDescription.GetCardRace(data).sprite;
                if (data.HasType(CardType.Tuner))
                    Manager.GetElement("Tuner").SetActive(true);
                if (data.HasType(CardType.Pendulum))
                {
                    var texts = CardDescription.GetCardDescriptionSplit(data.Desc);
                    string monster = InterString.Get("【怪兽效果】");
                    if (!data.HasType(CardType.Effect))
                        monster = InterString.Get("【怪兽描述】");

                    Manager.GetElement<TMP_InputField>("TextDescription").text =
                        CardDescription.GetSetName(data.Id) +
                        InterString.Get("【灵摆效果】") + "\n" + texts[0] + "\n" +
                        monster + "\n" + texts[1];
                    Manager.GetElement("Scale").SetActive(true);
                    Manager.GetElement("TextScale").SetActive(true);
                    Manager.GetElement<Text>("TextScale").text = data.LScale.ToString();
                    Manager.GetElement<RectTransform>("Attack").anchoredPosition = new Vector2(0, -90);
                    Manager.GetElement<RectTransform>("TextAttack").anchoredPosition = new Vector2(40, -90);
                    Manager.GetElement<RectTransform>("Defense").anchoredPosition = new Vector2(0, -135);
                    Manager.GetElement<RectTransform>("TextDefense").anchoredPosition = new Vector2(40, -135);
                }
                else
                {
                    Manager.GetElement<TMP_InputField>("TextDescription").text = CardDescription.GetSetName(data.Id) + data.Desc;
                    Manager.GetElement("Scale").SetActive(false);
                    Manager.GetElement("TextScale").SetActive(false);
                    Manager.GetElement<RectTransform>("Attack").anchoredPosition = new Vector2(0, -45);
                    Manager.GetElement<RectTransform>("TextAttack").anchoredPosition = new Vector2(40, -45);
                    Manager.GetElement<RectTransform>("Defense").anchoredPosition = new Vector2(0, -90);
                    Manager.GetElement<RectTransform>("TextDefense").anchoredPosition = new Vector2(40, -90);
                }

                if (data.HasType(CardType.Link))
                {
                    Manager.GetElement<Text>("TextLevel").text = CardDescription.GetCardLinkCount(data).ToString();
                    Manager.GetElement("Defense").SetActive(false);
                    Manager.GetElement("TextDefense").SetActive(false);
                    Manager.GetElement<RectTransform>("Attack").anchoredPosition = new Vector2(0, -45);
                    Manager.GetElement<RectTransform>("TextAttack").anchoredPosition = new Vector2(40, -45);
                }
                else
                {
                    Manager.GetElement<Text>("TextLevel").text = data.Level.ToString();
                    Manager.GetElement("Defense").SetActive(true);
                    Manager.GetElement("TextDefense").SetActive(true);
                    Manager.GetElement<Text>("TextDefense").text = data.Defense == -2 ? "?" : data.Defense.ToString();
                }
            }
            else
            {
                Manager.GetElement("PropertyMonster").SetActive(false);
                Manager.GetElement("PropertySpell").SetActive(true);
                Manager.GetElement<Image>("SpellType").sprite = TextureManager.GetSpellTrapTypeIcon(data);
                Manager.GetElement<Text>("TextSpellType").text = StringHelper.SecondType(data.Type) + StringHelper.MainType(data.Type);
                Manager.GetElement<TMP_InputField>("TextDescription").text = CardDescription.GetSetName(data.Id) + data.Desc;
            }
            RefreshLimitIcon();
            if (CardRarity.CardBookmarked(code))
                Manager.GetElement<Toggle>("ButtonBook").SwitchOn();
            else
                Manager.GetElement<Toggle>("ButtonBook").SwitchOff();

            var rarity = CardRarity.GetRarity(code);
            GetRarityToggle(rarity)?.SwitchOnWithoutAction();
            TurnOffOtherRarityToggles(rarity);

            //manager.GetElement<TMP_InputField>("TextDescription").fontSize = 26f * Config.GetUIScale(1.35f);
        }

        void RefreshLimitIcon()
        {
            if (!Manager.GetElement("Group").activeInHierarchy)
                return;

            var limit = banlist.GetQuantity(cardShowing.Id);
            if (limit == 3)
                Manager.GetElement<Image>("Limit").sprite = TextureManager.container.typeNone;
            else if (limit == 2)
                Manager.GetElement<Image>("Limit").sprite = TextureManager.container.limit2;
            else if (limit == 1)
                Manager.GetElement<Image>("Limit").sprite = TextureManager.container.limit1;
            else
                Manager.GetElement<Image>("Limit").sprite = TextureManager.container.banned;
        }

        void ShowDetail()
        {
            var cardFace = Manager.GetElement<RawImage>("Card").texture;
            var mat = Manager.GetElement<RawImage>("Card").material;
            Program.instance.ui_.cardDetail.Show(cardShowing, cardFace, mat, cardIndex >= 0 ? CardsInDeck() : CardsOnList(), cardIndex);
        }

        public List<int> CardsInDeck()
        {
            var cards = new Dictionary<int, int>();
            foreach (var card in this.cards)
                cards.Add(card.transform.GetSiblingIndex(), card.Code);
            var returnValue = new List<int>();
            for(int i = 0; i < this.cards.Count; i++)
                returnValue.Add(cards[i]);
            return returnValue;
        }

        List<int> CardsOnList()
        {
            var cards = new List<int>();
            for(int i = 0; i < superScrollView.items.Count; i++)
                cards.Add(int.Parse(superScrollView.items[i].args[0]));
            return cards;
        }

        public override void PerFrameFunction()
        {
            if (showing)
            {
                if (!Program.instance.ui_.subMenu.showing && UserInput.MouseRightUp)
                {
                    if (!Program.instance.ui_.cardDetail.showing && returnAction != null)
                        returnAction();
                }
                if (!Program.instance.ui_.subMenu.showing && UserInput.WasCancelPressed)
                {
                    if (!Program.instance.ui_.cardDetail.showing && returnAction != null)
                        returnAction();
                    else if (!Program.instance.ui_.cardDetail.showing)
                        OnReturn();
                }
            }
        }

        public float descriptionWidth;
        public float tableWidth;
        public float listWidth;
        public float outerWidth;
        public float innerWidth;

        void AdjustSize()
        {
            var uiWidth = Screen.width * 1080f / Screen.height;
            descriptionWidth = 420f;
            tableWidth = 790f;
            listWidth = 550f;//1920
            outerWidth = 50;
            innerWidth = 30;
            if (uiWidth <= 1920)
            {
                if (uiWidth >= 1920 - 80)
                {
                    descriptionWidth -= 1920 - uiWidth;
                }
                else if (uiWidth >= 1920 - 80 - 2 * (50 + 30))
                {
                    descriptionWidth = 420 - 80;
                    float percent = (uiWidth - 1920 + 240) / 160f;
                    outerWidth *= percent;
                    innerWidth *= percent;
                }
                else
                {
                    descriptionWidth = 420 - 80;
                    outerWidth = 0;
                    innerWidth = 0;
                }
            }
            Manager.GetElement<RectTransform>("Description").anchoredPosition = new Vector2(outerWidth, -120);
            Manager.GetElement<RectTransform>("Description").sizeDelta = new Vector2(descriptionWidth, 900);
            Manager.GetElement<RectTransform>("Table").anchoredPosition = new Vector2(outerWidth + descriptionWidth + innerWidth, -120);
            Manager.GetElement<RectTransform>("List").anchoredPosition = new Vector2(outerWidth + descriptionWidth + innerWidth + tableWidth + innerWidth, -180);
            listWidth = uiWidth - (outerWidth * 2 + descriptionWidth + innerWidth * 2 + tableWidth);
            Manager.GetElement<RectTransform>("List").sizeDelta = new Vector2(listWidth, 840);

            var startX = 810f;
            var space = 20f;
            var fullWidth = uiWidth - startX - 30 - space * 5;

            //var buttonWidth = fullWidth / 6;
            //manager.GetElement<RectTransform>("ButtonDeckReset").sizeDelta = new Vector2(buttonWidth, 62);
            //manager.GetElement<RectTransform>("ButtonDeckSort").sizeDelta = new Vector2(buttonWidth, 62);
            //manager.GetElement<RectTransform>("ButtonDeckRandom").sizeDelta = new Vector2(buttonWidth, 62);
            //manager.GetElement<RectTransform>("ButtonDeckCopy").sizeDelta = new Vector2(buttonWidth, 62);
            //manager.GetElement<RectTransform>("ButtonDeckShare").sizeDelta = new Vector2(buttonWidth, 62);
            //manager.GetElement<RectTransform>("ButtonDeckSave").sizeDelta = new Vector2(buttonWidth, 62);
            //manager.GetElement<RectTransform>("ButtonChangeSide").sizeDelta = new Vector2(buttonWidth * 4 + space * 3, 62);

            //manager.GetElement<RectTransform>("ButtonDeckReset").anchoredPosition = new Vector2(startX, -34);
            //manager.GetElement<RectTransform>("ButtonDeckSort").anchoredPosition = new Vector2(startX + buttonWidth + space, -34);
            //manager.GetElement<RectTransform>("ButtonDeckRandom").anchoredPosition = new Vector2(startX + (buttonWidth + space) * 2, -34);
            //manager.GetElement<RectTransform>("ButtonDeckCopy").anchoredPosition = new Vector2(startX + (buttonWidth + space) * 3, -34);
            //manager.GetElement<RectTransform>("ButtonDeckShare").anchoredPosition = new Vector2(startX + (buttonWidth + space) * 4, -34);
            //manager.GetElement<RectTransform>("ButtonDeckSave").anchoredPosition = new Vector2(startX + (buttonWidth + space) * 5, -34);
            //manager.GetElement<RectTransform>("ButtonChangeSide").anchoredPosition = new Vector2(startX + (buttonWidth + space) * 2, -34);

            foreach (var card in cards)
                card.RefreshPositionInstant();

            uiWidth = Manager.GetElement<RectTransform>("List").sizeDelta.x - 40;
            if (uiWidth < 0) uiWidth = 0;
            Manager.GetElement<RectTransform>("ButtonFilter").sizeDelta = new Vector2(uiWidth / 3f, 60);
            Manager.GetElement<RectTransform>("ButtonSort").sizeDelta = new Vector2(uiWidth / 3f, 60);
            Manager.GetElement<RectTransform>("ButtonReset").sizeDelta = new Vector2(uiWidth / 3f, 60);

            ScrollViewInstall();
        }

        void OnList()
        {
            Manager.GetElement<RectTransform>("ScrollView").sizeDelta = new Vector2(0, 680);

            if (relatedCards.Count == 0)
            {
                Manager.GetElement("SearchComponents").SetActive(true);
                Manager.GetElement("RelatedComponents").SetActive(false);
                if (showing)
                    OnClickSearch();
            }
            else
            {
                Manager.GetElement("SearchComponents").SetActive(false);
                Manager.GetElement("RelatedComponents").SetActive(true);
                PrintCards(relatedCards);
            }
        }
        void OnBook()
        {
            Manager.GetElement("SearchComponents").SetActive(false);
            Manager.GetElement("RelatedComponents").SetActive(false);
            Manager.GetElement<RectTransform>("ScrollView").sizeDelta = new Vector2(0, 820);
            PrintBookedCards();
        }
        void OnHistory()
        {
            Manager.GetElement("SearchComponents").SetActive(false);
            Manager.GetElement("RelatedComponents").SetActive(false);
            Manager.GetElement<RectTransform>("ScrollView").sizeDelta = new Vector2(0, 820);
            PrintHistoryCards();
        }
        void ShowAppearance()
        {
            if (!deckIsFromLocalFile)
                return;
            intoAppearance = true;
            Program.instance.appearance.SwitchCondition(Appearance.Condition.Deck);
            Program.instance.ShiftToServant(Program.instance.appearance);
        }
        void ShowBanlists()
        {
            List<string> selections = new()
            {
                InterString.Get("禁限卡表"),
                string.Empty
            };
            foreach (var list in BanlistManager.Banlists)
                selections.Add(list.Name);
            UIManager.ShowPopupSelection(selections, ChangeBanlist);
        }

        void ChangeBanlist()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            banlist = BanlistManager.GetByName(selected);
            Manager.GetElement<Text>("TextBanlist").text = selected;
            foreach (var card in cards)
                card.RefreshLimitIcon();
            RefreshLimitIcon();
            RefreshListItemIcons();
        }

        public void RefreshCardID()
        {
            CardInDeck cardDrag = null;

            foreach (var card in cards)
                if (card.dragging)
                {
                    cardDrag = card;
                    break;
                }
            if (cardDrag == null)
                return;

            CardInDeck cardHover = null;
            foreach (var card in cards)
                if (card.hover && !card.dragging)
                {
                    cardHover = card;
                    break;
                }
            if (cardHover != null)
            {
                SwitchCard(cardDrag, cardHover);
                dirty = true;
            }
            else
            {
                var c = CardsManager.Get(cardDrag.Code);
                var isExtra = c.IsExtraCard();

                if (Manager.GetElement<UIHover>("DummyMain").hover)
                {
                    if (cardDrag.id > 1999 && !isExtra)
                    {
                        dirty = true;

                        foreach (var card in cards)
                            if (card.id > cardDrag.id)
                                card.id--;
                        cardDrag.id = mainCount;
                        mainCount++;
                        sideCount--;
                    }
                }
                else if (Manager.GetElement<UIHover>("DummyExtra").hover)
                {
                    if (cardDrag.id > 1999 && isExtra)
                    {
                        dirty = true;

                        foreach (var card in cards)
                            if (card.id > cardDrag.id)
                                card.id--;
                        cardDrag.id = extraCount + 1000;
                        extraCount++;
                        sideCount--;
                    }
                }
                else if (Manager.GetElement<UIHover>("DummySide").hover)
                {
                    if (cardDrag.id < 1000)
                    {
                        dirty = true;

                        foreach (var card in cards)
                            if (card.id > cardDrag.id && card.id < 1000)
                                card.id--;
                        cardDrag.id = sideCount + 2000;
                        mainCount--;
                        sideCount++;
                    }
                    else if (cardDrag.id > 999 && cardDrag.id < 2000)
                    {
                        dirty = true;

                        foreach (var card in cards)
                            if (card.id > cardDrag.id && card.id < 2000)
                                card.id--;
                        cardDrag.id = sideCount + 2000;
                        extraCount--;
                        sideCount++;
                    }
                }
            }
            foreach (var card in cards)
                card.Move();
            SetCardSiblingIndex(CardInDeck.moveTime);
        }
        public void SwitchSide(CardInDeck card)
        {
            AudioManager.PlaySE("SE_DECK_MINUS");

            var isExtra = CardsManager.Get(card.Code).IsExtraCard();
            if(card.id >= 2000)
            {
                foreach (var c in cards)
                    if (c.id > card.id)
                        c.id--;
                sideCount--;

                if (isExtra)
                {
                    card.id = 1000 + extraCount;
                    extraCount++;
                }
                else
                {
                    card.id = mainCount;
                    mainCount++;
                }
            }
            else if (card.id >= 1000)
            {
                foreach (var c in cards)
                    if (c.id > card.id && c.id < 2000)
                        c.id--;
                extraCount--;

                card.id = 2000 + sideCount;
                sideCount++;
            }
            else
            {
                foreach (var c in cards)
                    if (c.id > card.id && c.id < 1000)
                        c.id--;
                mainCount--;

                card.id = 2000 + sideCount;
                sideCount++;
            }

            foreach (var c in Program.instance.editDeck.cards)
                c.Move();
            Program.instance.editDeck.SetCardSiblingIndex(CardInDeck.moveTime);
        }

        public void SwitchCard(CardInDeck dragCard, CardInDeck hoverCard)
        {
            var hover = hoverCard.id;
            if (dragCard.id == 99999999)
            {
                var data = CardsManager.Get(dragCard.Code);
                var isExtra = data.IsExtraCard();
                if (!isExtra)
                {
                    if (hover < 1000)
                    {
                        foreach (var card in cards)
                            if (card.id >= hover && card.id < 1000)
                                card.id++;
                        dragCard.id = hover;
                        mainCount++;
                    }
                    else if (hover > 1999)
                    {
                        foreach (var card in cards)
                            if (card.id >= hover)
                                card.id++;
                        dragCard.id = hover;
                        sideCount++;
                    }
                    else
                    {
                        cards.Remove(dragCard);
                        Destroy(dragCard.gameObject);
                    }
                }
                else
                {
                    if (hover < 1000)
                    {
                        cards.Remove(dragCard);
                        Destroy(dragCard.gameObject);
                    }
                    else if (hover > 1999)
                    {
                        foreach (var card in cards)
                            if (card.id >= hover)
                                card.id++;
                        dragCard.id = hover;
                        sideCount++;
                    }
                    else
                    {
                        foreach (var card in cards)
                            if (card.id >= hover && card.id < 2000)
                                card.id++;
                        dragCard.id = hover;
                        extraCount++;
                    }
                }
            }
            else if (dragCard.id < 1000)
            {
                if (hover < 1000)
                {
                    foreach (var card in cards)
                        if (card.id > dragCard.id)
                            card.id--;
                    foreach (var card in cards)
                        if (card.id >= hover)
                            card.id++;
                    dragCard.id = hover;
                }
                else if (hover > 999 && hover < 2000)
                    return;
                else if (hover > 1999)
                {
                    foreach (var card in cards)
                        if (card.id > dragCard.id && card.id < 1000)
                            card.id--;
                    foreach (var card in cards)
                        if (card.id >= hover)
                            card.id++;
                    dragCard.id = hover;
                    Program.instance.editDeck.mainCount--;
                    Program.instance.editDeck.sideCount++;
                }
            }
            else if (dragCard.id > 999 && dragCard.id < 2000)
            {
                if (hover < 1000)
                    return;
                else if (hover > 999 && hover < 2000)
                {
                    foreach (var card in cards)
                        if (card.id > dragCard.id)
                            card.id--;
                    foreach (var card in cards)
                        if (card.id >= hover)
                            card.id++;
                    dragCard.id = hover;
                }
                else if (hover > 1999)
                {
                    foreach (var card in cards)
                        if (card.id > dragCard.id && card.id > 999 && card.id < 2000)
                            card.id--;
                    foreach (var card in cards)
                        if (card.id >= hover)
                            card.id++;
                    dragCard.id = hover;
                    Program.instance.editDeck.extraCount--;
                    Program.instance.editDeck.sideCount++;
                }
            }
            else if (dragCard.id > 1999)
            {
                var c = CardsManager.Get(dragCard.Code);
                var isExtra = c.IsExtraCard();

                if (hover < 1000)
                {
                    if (!isExtra)
                    {
                        foreach (var card in cards)
                            if (card.id > dragCard.id)
                                card.id--;
                        foreach (var card in cards)
                            if (card.id >= hover && card.id < 1000)
                                card.id++;
                        dragCard.id = hover;
                        Program.instance.editDeck.mainCount++;
                        Program.instance.editDeck.sideCount--;
                    }
                }
                else if (hover > 999 && hover < 2000)
                {
                    if (isExtra)
                    {
                        foreach (var card in cards)
                            if (card.id > dragCard.id)
                                card.id--;
                        foreach (var card in cards)
                            if (card.id >= hover && card.id < 2000)
                                card.id++;
                        dragCard.id = hover;
                        Program.instance.editDeck.extraCount++;
                        Program.instance.editDeck.sideCount--;
                    }
                }
                else if (hover > 1999)
                {
                    foreach (var card in cards)
                        if (card.id > dragCard.id)
                            card.id--;
                    foreach (var card in cards)
                        if (card.id >= hover)
                            card.id++;
                    dragCard.id = hover;
                }
            }
        }

        public void SetCardSiblingIndex(float delay)
        {
            DOTween.To(v => { }, 0, 0, delay).OnComplete(() =>
            {
                cards.Sort((x, y) => x.id.CompareTo(y.id));
                for (int i = 0; i < cards.Count; i++)
                    cards[i].transform.SetSiblingIndex(i);
            });
        }

        public void DeleteCard(CardInDeck card)
        {
            if (condition == Condition.ChangeSide)
                return;

            dirty = true;
            AudioManager.PlaySE("SE_DECK_MINUS");

            card.transform.SetSiblingIndex(cards.Count - 1);
            cards.Remove(card);
            Destroy(card.gameObject, 0.4f);
            Vector3 end;
            if (Manager.GetElement<Tab>("TabList").selected)
            {
                end = Manager.GetElement<Transform>("ScrollView").GetChild(0).position;
            }
            else
            {
                end = Manager.GetElement<Transform>("TabList").GetChild(0).position;
            }
            var sequence = DOTween.Sequence();
            sequence.Append(card.transform.DOMove(end, 0.2f));
            sequence.Join(card.transform.DOScale(Vector3.one * 1.5f, 0.2f));
            sequence.Append(card.GetComponent<CanvasGroup>().DOFade(0, 0.2f));
            sequence.Join(card.transform.DOScale(Vector3.one * 0.7f, 0.2f));

            if (card.id < 1000)
            {
                foreach (var c in cards)
                    if (c.id > card.id && c.id < 1000)
                        c.id--;
                mainCount--;
            }
            else if (card.id > 999 && card.id < 2000)
            {
                foreach (var c in cards)
                    if (c.id > card.id && c.id > 999 && c.id < 2000)
                        c.id--;
                extraCount--;
            }
            else if (card.id > 1999)
            {
                foreach (var c in cards)
                    if (c.id > card.id && c.id > 1999)
                        c.id--;
                sideCount--;
            }
            foreach (var c in cards)
                c.Move();
            SetCardSiblingIndex(0);
            RefreshListItemIcons();
        }

        public void OnReset()
        {
            if (!deckIsFromLocalFile)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            Dispose();
            StartCoroutine(RefreshAsync());
        }
        public void OnSort()
        {
            if (!deckIsFromLocalFile && condition != Condition.ChangeSide)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            dirty = true;

            List<CardInDeck> main = new List<CardInDeck>();
            List<CardInDeck> extra = new List<CardInDeck>();
            List<CardInDeck> side = new List<CardInDeck>();
            foreach (var card in cards)
            {
                if (card.id < 1000)
                    main.Add(card);
                else if (card.id > 1999)
                    side.Add(card);
                else
                    extra.Add(card);
            }
            main.Sort((left, right) =>
            {
                return CardsManager.ComparisonOfCard()
                (CardsManager.Get(left.Code), CardsManager.Get(right.Code));
            });
            for (int i = 0; i < main.Count; i++)
                main[i].id = i;
            extra.Sort((left, right) =>
            {
                return CardsManager.ComparisonOfCard()
                (CardsManager.Get(left.Code), CardsManager.Get(right.Code));
            });
            for (int i = 0; i < extra.Count; i++)
                extra[i].id = i + 1000;
            side.Sort((left, right) =>
            {
                return CardsManager.ComparisonOfCard()
                (CardsManager.Get(left.Code), CardsManager.Get(right.Code));
            });
            for (int i = 0; i < side.Count; i++)
                side[i].id = i + 2000;
            foreach (var card in cards)
                card.Move();
            SetCardSiblingIndex(0);
        }
        public void OnRandom()
        {
            if (!deckIsFromLocalFile)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            dirty = true;

            List<CardInDeck> main = new List<CardInDeck>();
            foreach (var card in cards)
                if (card.id < 1000)
                    main.Add(card);
            System.Random rand = new System.Random();
            for (int i = 0; i < main.Count; i++)
            {
                int random_index = rand.Next() % main.Count;
                var buffer = main[i];
                main[i] = main[random_index];
                main[random_index] = buffer;
            }
            for (int i = 0; i < main.Count; i++)
                main[i].id = i;
            foreach (var card in cards)
                card.Move();
            SetCardSiblingIndex(0);
        }
        public void OnNameInputChange()
        {
            dirty = true;
        }
        public void OnCopy()
        {
            if (!deckIsFromLocalFile)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            dirty = true;

            deckName += " - " + InterString.Get("复制");
            input.text = deckName;
            deck.deckId = string.Empty;
        }
        public void OnShare()
        {
            if(!deckIsFromLocalFile || dirty || !File.Exists("Deck/" + deckName + Program.ydkExpansion))
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            //#if UNITY_ANDROID && !UNITY_EDITOR
            //            new NativeShare().SetText(File.ReadAllText(Program.deckPath + deckName + Program.ydkExpansion)).Share();
            //#else
            //            Tools.TryOpenInFileExplorer(Path.GetFullPath(Program.deckPath + deckName + Program.ydkExpansion));
            //#endif

            var url = DeckShareURL.DeckToUri(deck.Main, deck.Extra, deck.Side).ToString();
            GUIUtility.systemCopyBuffer = url;
            Application.OpenURL(url);

        }
        public void OnLike()
        {
            if (!deckIsFromLocalFile && condition == Condition.OnlineDeck)
            {
                OnlineDeck.LikeDeck(onlineDeckID);
                liked = true;
                Manager.GetElement("ButtonLike").SetActive(false);
                return;
            }

            if (dirty || !deckIsFromLocalFile)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            if(MyCard.account != null)
            {
                var onlineDeck = OnlineDeck.GetByID(deck.deckId);
                if (onlineDeck == null || onlineDeck.isDelete)
                    return;
                _ = OnlineDeck.UpdatePublicState(deck.deckId, !onlineDeck.isPublic);
                onlineDeck.isPublic = !onlineDeck.isPublic;
                RefreshLikeButton();
            }
        }
        public void OnSave()
        {
            if (Manager.GetElement<Text>("TextBanlist").text != "N/A")
            {
                if (mainCount > 60 || extraCount > 15 || sideCount > 15)
                {
                    List<string> tasks = new List<string>
                    {
                        InterString.Get("保存失败"),
                        InterString.Get("卡组内卡片张数超过限制。@n如需无视限制，请将禁限卡表设置为无（N/A）。")
                    };
                    UIManager.ShowPopupConfirm(tasks);
                    return;
                }
            }

            if (!deckIsFromLocalFile && File.Exists(Program.deckPath + input.text + Program.ydkExpansion))
            {
                List<string> tasks = new List<string>()
                    {
                        InterString.Get("该卡组名已存在"),
                        InterString.Get("该卡组名的文件已存在，是否直接覆盖创建？"),
                        InterString.Get("覆盖"),
                        InterString.Get("取消")
                    };
                UIManager.ShowPopupYesOrNo(tasks, OnSaveConfirmed, null);
            }
            else
                OnSaveConfirmed();
        }
        void OnSaveConfirmed()
        {
            deck = FromObjectDeckToCodedDeck();
            FileSave();
            if (returnAction != null && deckIsFromLocalFile)
                OnExit();
            deckIsFromLocalFile = true;
            RefreshLikeButton();
        }

        Deck FromObjectDeckToCodedDeck()
        {
            cards.Sort((left, right) =>
            {
                if (left.id < right.id) return -1;
                if (left.id > right.id) return 1;
                return 0;
            });
            var deck = new Deck();
            foreach (var card in cards)
            {
                if (card.id < 1000)
                    deck.Main.Add(card.Code);
                else if (card.id > 1999)
                    deck.Side.Add(card.Code);
                else
                    deck.Extra.Add(card.Code);
            }
            foreach (var pickup in this.deck.Pickup)
                deck.Pickup.Add(pickup);
            deck.Protector = this.deck.Protector;
            deck.Case = this.deck.Case;
            deck.Field = this.deck.Field;
            deck.Grave = this.deck.Grave;
            deck.Stand = this.deck.Stand;
            deck.Mate = this.deck.Mate;
            deck.deckId = this.deck.deckId;
            deck.userId = this.deck.userId;
            return deck;
        }

        void FileSave()
        {
            try
            {
                deck.Save(input.text, DateTime.Now);
                if (input.text != deckName)
                    File.Delete(Program.deckPath + deckName + Program.ydkExpansion);
                deckName = input.text;
                MessageManager.Cast(InterString.Get("本地卡组「[?]」已保存。", input.text));
                dirty = false;
            }
            catch(Exception e)
            {
                MessageManager.Cast(InterString.Get("保存失败！"));
                Debug.Log(e);
            }
        }

        public int GetCardCount(int code)
        {
            var data = CardsManager.Get(code);
            if (data == null) return 0;
            var alias = data.Alias;
            int count = 0;
            foreach (var card in cards)
            {
                var c = CardsManager.Get(card.Code);
                if (c == null)
                    continue;
                if (alias == 0)
                {
                    if (c.Id == code || c.Alias == code)
                        count++;
                }
                else
                {
                    if (c.Id == alias || c.Alias == alias)
                        count++;
                }
            }
            return count;
        }

        public void OnChangeSideComplete()
        {
            TcpHelper.CtosMessage_UpdateDeck(FromObjectDeckToCodedDeck());
        }
        public void OnPlusOne()
        {
            if (condition == Condition.ChangeSide)
                return;
            if (!deckIsFromLocalFile)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }
            if (GetCardCount(cardShowing.Id) >= banlist.GetQuantity(cardShowing.Id))
                return;
            AudioManager.PlaySE("SE_DECK_PLUS");

            var card = Instantiate(itemInDeck);
            card.transform.SetParent(cardsOnEditParent, false);
            var mono = card.GetComponent<CardInDeck>();

            if (!cardShowing.IsExtraCard())
            {
                if (mainCount < 60)
                {
                    mono.id = mainCount;
                    mainCount++;
                }
                else
                {
                    mono.id = sideCount + 2000;
                    sideCount++;
                }
            }
            else
            {
                if (extraCount < 15)
                {
                    mono.id = extraCount + 1000;
                    extraCount++;
                }
                else
                {
                    mono.id = sideCount + 2000;
                    sideCount++;
                }
            }
            mono.Code = cardShowing.Id;
            mono.RefreshPosition();
            cards.Add(mono);
            foreach (var c in cards)
                c.Move();
            SetCardSiblingIndex(0);
            RefreshListItemIcons();
        }
        public void OnMinusOne()
        {
            if (condition == Condition.ChangeSide)
                return;

            if (!deckIsFromLocalFile)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            foreach (var c in cards)
            {
                var card = CardsManager.Get(c.Code);
                if (cardShowing.Alias == 0)
                {
                    if (card.Id == cardShowing.Id || card.Alias == cardShowing.Id)
                    {
                        DeleteCard(c);
                        break;
                    }
                }
                else
                {
                    if (card.Id == cardShowing.Alias || card.Alias == cardShowing.Alias)
                    {
                        DeleteCard(c);
                        break;
                    }
                }
            }
        }
        public void OnDeckNameChange()
        {
            dirty = true;
        }
        void OnSearch(string search)//For Input Field
        {
            OnClickSearch();
        }

        public void OnClickSearch()
        {
            List<int> cards = new List<int>();
            var result = CardsManager.Search(Manager.GetElement<InputField>("InputSearch").text, filters, banlist, pack);
            switch (sortOrder)
            {
                case SortOrder.ByType:
                    result.Sort(CardsManager.ComparisonOfCard());
                    break;
                case SortOrder.ByTypeReverse:
                    result.Sort(CardsManager.ComparisonOfCardReverse());
                    break;
                case SortOrder.ByLevelUp:
                    result.Sort(CardsManager.ComparisonOfCard_LV_Up());
                    break;
                case SortOrder.ByLevelDown:
                    result.Sort(CardsManager.ComparisonOfCard_LV_Down());
                    break;
                case SortOrder.ByAttackUp:
                    result.Sort(CardsManager.ComparisonOfCard_ATK_Up());
                    break;
                case SortOrder.ByAttackDown:
                    result.Sort(CardsManager.ComparisonOfCard_ATK_Down());
                    break;
                case SortOrder.ByDefenceUp:
                    result.Sort(CardsManager.ComparisonOfCard_DEF_Up());
                    break;
                case SortOrder.ByDefenceDown:
                    result.Sort(CardsManager.ComparisonOfCard_DEF_Down());
                    break;
                case SortOrder.ByRarityUp:
                    result.Sort(CardsManager.ComparisonOfCard_Rarity_Up());
                    break;
                case SortOrder.ByRarityDown:
                    result.Sort(CardsManager.ComparisonOfCard_Rarity_Down());
                    break;
            }
            foreach (var card in result)
                cards.Add(card.Id);
            Manager.GetElement<Text>("LabelSearch").text = cards.Count.ToString();
            PrintCards(cards);
        }

        public enum SortOrder
        {
            ByType = 1,
            ByTypeReverse = 2,
            ByLevelUp = 3,
            ByLevelDown = 4,
            ByAttackUp = 5,
            ByAttackDown = 6,
            ByDefenceUp = 7,
            ByDefenceDown = 8,
            ByRarityUp = 9,
            ByRarityDown = 10
        }
        public SortOrder sortOrder = SortOrder.ByType;
        public void OnSearchSort()
        {
            var handle = Addressables.InstantiateAsync("PopupSearchOrder");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                result.Result.GetComponent<UI.Popup.PopupSearchOrder>().Show();
            };
        }

        public void BookCard()
        {
            if (CardRarity.CardBookmarked(cardShowing.Id))
            {
                CardRarity.UnbookmarkCard(cardShowing.Id);
                AudioManager.PlaySE("SE_MENU_S_DECIDE_02");
            }
            else
            {
                CardRarity.BookmarkCard(cardShowing.Id);
                AudioManager.PlaySE("SE_MENU_S_DECIDE_01");
            }

            if (Manager.GetElement<Tab>("TabBook").selected)
                PrintBookedCards();
        }
        Card relatedCard;
        List<int> relatedCards = new List<int>();
        public void OnRelated()
        {
            relatedCard = CardsManager.Get(cardShowing.Id);
            var related = CardsManager.RelatedSearch(cardShowing.Id);
            relatedCards = new List<int>();
            foreach (var card in related)
                relatedCards.Add(card.Id);
            Manager.GetElement<Tab>("TabList").TabThis();

            Manager.GetElement("SearchComponents").SetActive(false);
            Manager.GetElement("RelatedComponents").SetActive(true);
            Manager.GetElement<RawImage>("RawImageRelatedCard").texture =
                Instantiate(Manager.GetElement<RawImage>("Card").texture);
            Manager.GetElement<RawImage>("RawImageRelatedCard").material =
                Instantiate(Manager.GetElement<RawImage>("Card").material);
            Manager.GetElement<Text>("TextRelatedCard").text = InterString.Get("「[?]」的相关卡片", relatedCard.Name);

            PrintCards(relatedCards);
        }

        public void OnRelatedReturn()
        {
            Manager.GetElement("SearchComponents").SetActive(true);
            Manager.GetElement("RelatedComponents").SetActive(false);
            relatedCards.Clear();
            ScrollViewInstall();
        }

        public List<long> filters = new List<long>();
        public void OnFilter()
        {
            UIManager.ShowPopupFilter();
        }
        public void OnFilterReset()
        {
            filters.Clear();
            pack = "";
            Manager.GetElement<InputField>("InputSearch").text = "";
            FilterButtonSwitch(false);
            OnClickSearch();
        }

        void ScrollViewInstall()
        {
            StartCoroutine(ScrollViewInstallAsync());
        }

        IEnumerator ScrollViewInstallAsync()
        {
            while(itemOnList == null)
                yield return null;

            superScrollView?.Clear();

            var scale = Config.GetUIScale();
            superScrollView = new SuperScrollView
            (
            (int)Math.Floor((Manager.GetElement<RectTransform>("ScrollView").rect.width - 30f) / (86f * scale)),
            86 * scale,
            140 * scale,
            0,
            0,
            itemOnList,
            ItemOnListRefresh,
            Manager.GetElement<ScrollRect>("ScrollView")
            );

            Manager.GetElement<Text>("LabelSearch").text = InterString.Get("搜索");

            if (Manager.GetElement<Tab>("TabBook").selected)
                PrintBookedCards();
            else if (Manager.GetElement<Tab>("TabHistory").selected)
                PrintHistoryCards();
            else
            {
                if (relatedCards.Count > 0)
                    PrintCards(relatedCards);
            }
        }

        void PrintCards(List<int> codes)
        {
            if (superScrollView == null)
                return;

            var args = new List<string[]>();
            for (int i = 0; i < codes.Count; i++)
            {
                string[] arg = new string[1] { codes[i].ToString() };
                args.Add(arg);
            }
            superScrollView.Print(args);
        }

        void PrintBookedCards()
        {
            PrintCards(CardRarity.GetBookCards());
        }
        void PrintHistoryCards()
        {
            var list = new List<int>();
            foreach (var card in history.Main)
                list.Add(card);
            PrintCards(list);
        }
        void ItemOnListRefresh(string[] tasks, GameObject item)
        {
            var handler = item.GetComponent<SuperScrollViewItemForDeckEdit>();
            handler.code = int.Parse(tasks[0]);
            handler.Refresh();
        }

        public void RefreshListItemIcons()
        {
            if (superScrollView != null)
            {
                foreach (var item in superScrollView.items)
                {
                    if (item.gameObject != null)
                    {
                        var handler = item.gameObject.GetComponent<SuperScrollViewItemForDeckEdit>();
                        handler.RefreshCountDot();
                        handler.RefreshLimiteIcon();
                    }
                }
            }
        }

        public void FilterButtonSwitch(bool on)
        {
            if (on)
            {
                Manager.GetElement<Image>("ButtonFilter").sprite = TextureManager.container.toggleM_On;
                var state = Manager.GetElement<Button>("ButtonFilter").spriteState;
                state.highlightedSprite = TextureManager.container.toggleM_On;
                state.pressedSprite = TextureManager.container.toggleM_On;
                Manager.GetElement<Button>("ButtonFilter").spriteState = state;
                Manager.GetElement<Transform>("ButtonFilter").GetChild(0).GetComponent<Image>().color = Color.black;
            }
            else
            {
                Manager.GetElement<Image>("ButtonFilter").sprite = TextureManager.container.toggleM;
                var state = Manager.GetElement<Button>("ButtonFilter").spriteState;
                state.highlightedSprite = TextureManager.container.toggleM_Over;
                state.pressedSprite = TextureManager.container.toggleM_Over;
                Manager.GetElement<Button>("ButtonFilter").spriteState = state;
                Manager.GetElement<Transform>("ButtonFilter").GetChild(0).GetComponent<Image>().color = Color.white;
            }
        }

        Toggle GetRarityToggle(CardRarity.Rarity rarity)
        {
            switch(rarity)
            {
                case CardRarity.Rarity.Shine:
                    return Manager.GetElement<Toggle>("ButtonR");
                case CardRarity.Rarity.Royal:
                    return Manager.GetElement<Toggle>("ButtonUR");
                case CardRarity.Rarity.Gold:
                    return Manager.GetElement<Toggle>("ButtonGR");
                case CardRarity.Rarity.Millennium:
                    return Manager.GetElement<Toggle>("ButtonMR");
                default:
                    return null;
            }
        }

        void TurnOffOtherRarityToggles(CardRarity.Rarity rarity)
        {
            if (rarity != CardRarity.Rarity.Shine)
                Manager.GetElement<Toggle>("ButtonR").SwitchOffWithoutAction();
            if (rarity != CardRarity.Rarity.Royal)
                Manager.GetElement<Toggle>("ButtonUR").SwitchOffWithoutAction();
            if (rarity != CardRarity.Rarity.Gold)
                Manager.GetElement<Toggle>("ButtonGR").SwitchOffWithoutAction();
            if (rarity != CardRarity.Rarity.Millennium)
                Manager.GetElement<Toggle>("ButtonMR").SwitchOffWithoutAction();
        }

        public void ChangeRarity(int rarity)
        {
            var cardRarity = (CardRarity.Rarity)rarity;
            TurnOffOtherRarityToggles(cardRarity);

            var toggle = GetRarityToggle(cardRarity);
            if (toggle.switchOn)
                cardRarity = CardRarity.Rarity.Normal;
            CardRarity.SetRarity(cardShowing.Id, cardRarity);
            UpdateRarity();
        }

        void UpdateRarity()
        {
            Material mat = TextureManager.GetCardMaterial(cardShowing.Id);
            var face = Manager.GetElement<RawImage>("Card");
            mat.mainTexture = face.texture;
            face.material = mat;
            if (relatedCard != null && relatedCard.Id == cardShowing.Id)
                Manager.GetElement<RawImage>("RawImageRelatedCard").material = mat;
            foreach (var card in cards)
                if (card.Code == cardShowing.Id)
                    card.gameObject.GetComponent<RawImage>().material = mat;
            foreach (var item in superScrollView.items)
                if (item.gameObject != null)
                    if (item.gameObject.GetComponent<SuperScrollViewItemForDeckEdit>().code == cardShowing.Id)
                        item.gameObject.GetComponent<RawImage>().material = mat;
        }

        #region HandTest
        public bool toHandTest;
        static string handTestPuzzleName = "HandTest.lua";
        public void OnHandTest()
        {
            toHandTest = true;
            DeckToPuzzle();
            Program.instance.puzzle.StartPuzzle(Program.tempFolder + handTestPuzzleName.Replace(".lua", string.Empty));
        }

        void DeckToPuzzle()
        {
            var puzzle = string.Format("Debug.SetAIName(\"{0}\")\r\n", deckName);
            puzzle += "Debug.ReloadFieldBegin(DUEL_ATTACK_FIRST_TURN+DUEL_SIMPLE_AI,5)\r\n";
            puzzle += "Debug.SetPlayerInfo(0,8000,0,0)\r\n";
            puzzle += "Debug.SetPlayerInfo(1,8000,0,0)\r\n";

            foreach (var card in cards)
            {
                if (card.id >= 2000)
                    continue;
                if (card.id >= 1000)
                {
                    puzzle += string.Format("Debug.AddCard({0}, 0, 0, LOCATION_EXTRA, 0, POS_FACEUP_ATTACK)\r\n", card.Code);
                    continue;
                }
                if (card.id >= 5)
                    puzzle += string.Format("Debug.AddCard({0}, 0, 0, LOCATION_DECK, 0, POS_FACEUP_ATTACK)\r\n", card.Code);
                else if(card.id < 5)
                    puzzle += string.Format("Debug.AddCard({0}, 0, 0, LOCATION_HAND, 0, POS_FACEUP_ATTACK)\r\n", card.Code);
            }

            puzzle += "Debug.ReloadFieldEnd()\r\n";
            puzzle += "aux.BeginPuzzle()";

            if(!Directory.Exists(Program.tempFolder))
                Directory.CreateDirectory(Program.tempFolder);
            File.WriteAllText(Program.tempFolder + handTestPuzzleName, puzzle);
        }
        #endregion

        public void OnSubMenu()
        {
            var menus = new List<string>()
            {
                InterString.Get("副菜单"),
                InterString.Get("重置"),
                //InterString.Get("排序"),
                InterString.Get("打乱"),
                InterString.Get("复制"),
                InterString.Get("分享"),
                //InterString.Get("测试"),
            };
            var actions = new List<Action>()
            {
                null,
                OnReset,
                //OnSort,
                OnRandom,
                OnCopy,
                OnShare,
                //OnHandTest
            };
            Program.instance.ui_.subMenu.Show(menus, actions);
        }
    }
}