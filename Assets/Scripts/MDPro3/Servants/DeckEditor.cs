using DG.Tweening;
using MDPro3.UI;
using MDPro3.UI.PropertyOverrider;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using static MDPro3.UI.DeckView;

namespace MDPro3
{
    public class DeckEditor : Servant
    {
        #region Reference
        public static Deck Deck;
        public static string DeckName;
        public static bool DeckIsFromLocal;
        public static Banlist banlist;
        public static List<int> historyCards;
        public static bool useMobileLayout;

        private ElementObjectManager managerUI;
        private ElementObjectManager managerOverHeader;
        private ElementObjectManager managerHeader;

        public DeckView deckView;
        public CardCollectionView cardCollectionView;
        private CardDetailView cardDetailView;
        private CardActionMenu cardActionMenu;

        private bool needSave;

        public enum CardInfoType
        {
            None = 0,
            Detail = 1,
            Pool = 2
        }

        public static CardInfoType _CardInfoType = CardInfoType.None;

        public enum ResponseRegion
        {
            Deck,
            Collection,
            Action
        }

        private ResponseRegion _responseRegion;
        public ResponseRegion _ResponseRegion
        {
            get { return _responseRegion; }
            set
            {
                _responseRegion = value;
                ShiftToResponseRegion();
            }
        }
        private void ShiftToResponseRegion()
        {
            deckView.SetCursor(_ResponseRegion == ResponseRegion.Deck);
            cardCollectionView.SetCursor(_ResponseRegion == ResponseRegion.Collection);
        }

        public enum Condition
        {
            EditDeck,
            OnlineDeck,
            ReplayDeck,
            ChangeSide
        }
        public static Condition condition = Condition.EditDeck;
        public void SwitchCondition(Condition condition, string deckName = "", Deck deck = null)
        {
            DeckEditor.condition = condition;
            switch (condition)
            {
                case Condition.EditDeck:
                    returnServant = Program.instance.selectDeck;
                    DeckName = Config.Get("DeckInUse", "@ui");
                    Deck = new Deck(Program.deckPath + DeckName + Program.ydkExpansion);
                    DeckIsFromLocal = true;
                    historyCards = new();
                    break;
                case Condition.OnlineDeck:
                    break;
                case Condition.ReplayDeck:
                    break;
                case Condition.ChangeSide:
                    break;
            }
        }

        #endregion

        #region Servant
        [HideInInspector] public SelectionButton_CardInDeck lastSelectedCardInDeck;
        [HideInInspector] public SelectionButton_CardInCollection lastSelectedCardOnCollection;
        private TMP_InputField inputDeckName;
        private TMP_InputField inputSearch;
        private bool gotoAppearance;

        public override void Initialize()
        {
            SystemEvent.OnResolutionChange += ChangeCanvasMatch;
            transitionTime = 0.6f;
            showLine = false;
            needExit = false;
            depth = 5;
            returnServant = Program.instance.selectDeck;

            base.Initialize();

            banlist = BanlistManager.Banlists[0];
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            if (!gotoAppearance)
            {
                gotoAppearance = false;
                needSave = false;

                useMobileLayout = PropertyOverrider.NeedMobileLayout();
                var address = useMobileLayout ? "DeckEditUIMobile" : "DeckEditUI";
                var handle = Addressables.InstantiateAsync(address);
                handle.Completed += (result) =>
                {
                    UIManager.Translate(result.Result);
                    result.Result.transform.SetParent(transform, false);
                    base.ApplyShowArrangement(preDepth);
                    UIManager.SetCanvasMatch(GetCanvasMatch(), transitionTime);

                    managerUI = transform.GetChild(0).GetComponent<ElementObjectManager>();
                    managerOverHeader = managerUI.GetElement<ElementObjectManager>("OverHeader");
                    managerHeader = managerUI.GetElement<ElementObjectManager>("Header");
                    //managerFooter = managerUI.GetElement<ElementObjectManager>("TemplateFooterDesc");

                    deckView = managerUI.GetElement<DeckView>("DeckView");
                    InitializeDeckView();
                    cardCollectionView = managerUI.GetElement<CardCollectionView>("CardCollectionView");
                    InitializeCardCollectionView();

                    cardDetailView = managerUI.GetElement<CardDetailView>("CardDetailView");
                    cardActionMenu = managerUI.GetElement<CardActionMenu>("CardActionMenu");


                    InitializeOverHeader();
                    InitializeHeader();

                    ShowBackButton();
                };
            }
            else
                base.ApplyShowArrangement(preDepth);
        }

        protected override void ApplyHideArrangement(int preDepth)
        {
            base.ApplyHideArrangement(preDepth);
            HideBackButton();
            if (!gotoAppearance)
            {
                UIManager.SetCanvasMatch(1f, transitionTime);
                CardRarity.Save();
                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    Dispose();
                });
            }
        }

        private void Dispose()
        {
            Destroy(transform.GetChild(0).gameObject);
            callExit = false;
        }

        public override void PerFrameFunction()
        {
            if (!showing)
                return;
            if (NeedResponseInput())
            {
                if (UserInput.WasCancelPressed)
                    OnReturn();

                if (UserInput.WasLeftTriggerPressed)
                {
                    ShowCardActionMenu();
                }

                if (UserInput.WasRightTriggerPressed)
                {
                    if (_ResponseRegion == ResponseRegion.Deck)
                        SelectLastCollectionViewItem();
                    else if (_ResponseRegion == ResponseRegion.Collection)
                        SelectLastDeckViewItem();
                }

                if (UserInput.WasRightShoulderPressing)
                {
                    if (UserInput.WasGamepadButtonNorthPressed)
                    {
                        OnBanlist();
                        return;
                    }
                    else if (UserInput.WasGamepadButtonWestPressed)
                    {
                        SetCardInfoType();
                        return;
                    }
                }

                if (_ResponseRegion == ResponseRegion.Deck)
                {

                }
                else if (_ResponseRegion == ResponseRegion.Collection)
                {
                    if (cardCollectionView.area == CardCollectionView.Area.Collection)
                    {
                        if (UserInput.WasGamepadButtonNorthPressed)
                        {
                            if (UserInput.WasLeftShoulderPressing)
                                cardCollectionView.ShowSortOrder();
                            else if (inputSearch != null)
                                inputSearch.ActivateInputField();
                        }
                        else if (UserInput.WasGamepadButtonWestPressed)
                        {
                            if (UserInput.WasLeftShoulderPressing)
                                cardCollectionView.ResetFilters();
                            else
                                cardCollectionView.ShowFilters();
                        }
                        else if (UserInput.WasLeftStickPressed)
                            cardCollectionView.PrintSearchCards();
                    }
                    if (UserInput.WasRightStickPressed)
                    {
                        cardCollectionView.OnTabRight();
                    }
                }
            }
        }

        protected override bool NeedResponseInput()
        {
            if (inputDeckName != null && inputDeckName.isFocused)
                return false;
            if (inputSearch != null && inputSearch.isFocused)
                return false;
            if (cardActionMenu != null && cardActionMenu.showing)
                return false;
            return base.NeedResponseInput();
        }

        public override void SelectLastSelectable()
        {
            if (_ResponseRegion == ResponseRegion.Collection)
                SelectLastCollectionViewItem();
            else if (_ResponseRegion == ResponseRegion.Deck)
                SelectLastDeckViewItem();
            else if (_ResponseRegion == ResponseRegion.Action)
            {
                if(Selected != null)
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    cardActionMenu.SelectDefaultButton();
            }
        }

        private void SelectLastDeckViewItem()
        {
            _ResponseRegion = ResponseRegion.Deck;
            if (lastSelectedCardInDeck != null)
                EventSystem.current.SetSelectedGameObject(lastSelectedCardInDeck.gameObject);
            else
                deckView.SelectDefaultItem();
        }

        public void SelectNearestDeckViewItem(Vector3 position)
        {
            _ResponseRegion = ResponseRegion.Deck;
            UserInput.NextSelectionIsAxis = true;
            deckView.SelectNearestCard(position);
        }

        private void SelectLastCollectionViewItem()
        {
            _ResponseRegion = ResponseRegion.Collection;
            if (lastSelectedCardOnCollection != null)
                EventSystem.current
                    .SetSelectedGameObject(lastSelectedCardOnCollection.gameObject);
            else
                cardCollectionView.SelectDefaultItem();
        }

        public void SelectNearestCollectionViewItem(Vector3 position)
        {
            _ResponseRegion = ResponseRegion.Collection;
            UserInput.NextSelectionIsAxis = true;
            cardCollectionView.SelectNearestCard(position);
        }

        public override void OnReturn()
        {
            if (!needSave || !DeckIsFromLocal)
                base.OnReturn();
            else
            {
                callExit = true;

                var selections = new List<string>
                {
                    InterString.Get("卡组未保存"),
                    InterString.Get("卡组已修改，是否保存？"),
                    InterString.Get("保存"),
                    InterString.Get("不保存")
                };
                UIManager.ShowPopupYesOrNo(selections, OnSave, OnExit);
            }
        }

        public override void JudgeInputBlockerExitMark(object o)
        {
            _ResponseRegion = (ResponseRegion)o;
        }

        #endregion

        #region Detail View

        public void ShowDetail(Card data)
        {
            if (cardDetailView != null)
                cardDetailView.ShowCard(data);
        }

        public void ChangeRarity(CardRarity.Rarity rarity)
        {
            var code = 0;
            if (_ResponseRegion == ResponseRegion.Action)
                code = cardActionMenu.Card.Id;
            else if (cardDetailView != null)
                code = cardDetailView.Card.Id;
            CardRarity.SetRarity(code, rarity);
            UpdateRarity(code, rarity);
        }

        private void UpdateRarity(int code, CardRarity.Rarity rarity)
        {
            if (cardDetailView != null)
                cardDetailView.RefreshRarity(code, rarity);
            if (cardActionMenu.showing)
                cardActionMenu.RefreshRarity(code, rarity);
            cardCollectionView.RefreshRarity(code);
            deckView.RefreshRarity(code);
        }

        #endregion

        #region Deck View

        private void InitializeDeckView()
        {
            deckView.SetNoItemButtonNavigationEvent(MoveDirection.Right, () =>
            {
                UserInput.NextSelectionIsAxis = true;
                SelectLastCollectionViewItem();
            });
            inputDeckName = deckView.GetInputField();
            deckView.PrintDeck(Deck, DeckName, DeckView.Condition.Editable);
        }

        private void RefreshShowingCardCount()
        {
            if(cardDetailView != null)
                cardDetailView.SetCardCount();
            cardCollectionView.RefreshCardCount();
            if (_ResponseRegion == ResponseRegion.Action)
                cardActionMenu.SetCardCount();
        }

        /// <summary>
        /// +1按钮添加卡片、CardInDeck中键
        /// </summary>
        public void AddCard(Card data)
        {
            bool playAnimation = _ResponseRegion != ResponseRegion.Action;
            deckView.AddCard(data, playAnimation, playAnimation);
            AddHistoryCard(data.Id);
            RefreshShowingCardCount();
        }

        /// <summary>
        /// 拖动CollectionCard添加进卡组
        /// </summary>
        /// <param name="code"></param>
        public void AddCardFromCollection(Card data)
        {
            deckView.AddCardFromPosition(data, GetDragCardPositon());
            if(cardCollectionView.area != CardCollectionView.Area.History)
                AddHistoryCard(data.Id);
            RefreshShowingCardCount();
        }

        /// <summary>
        /// 右击CollectionCard添加进卡组
        /// </summary>
        /// <param name="code"></param>
        /// <param name="position"></param>
        public void AddCardFromCollection(Card data, Vector3 position)
        {
            deckView.AddCardFromPositionWithSequence(data, position);
            if (cardCollectionView.area != CardCollectionView.Area.History)
                AddHistoryCard(data.Id);
            RefreshShowingCardCount();
        }

        public void RemoveCard(SelectionButton_CardInDeck card)
        {
            if (!deckView.deckLoaded) return;

            bool needSelect = _ResponseRegion != ResponseRegion.Action;
            deckView.RemoveCard(card, needSelect);
            AddHistoryCard(card.Data.Id);

            AudioManager.PlaySE("SE_DECK_MINUS");

            card.transform.SetParent(transform, true);
            card.transform.localScale = new Vector3(2f, 2f, 1f);
            var cg = card.GetComponent<CanvasGroup>();
            cg.blocksRaycasts = false;
            RefreshShowingCardCount();

            if(needSelect)
            {
                var endPostion = cardCollectionView.GetRubbishBinPositon();
                endPostion.z -= 1f;

                DOTween.Sequence()
                    .Append(card.transform.DOMove(endPostion, 0.4f).SetEase(Ease.OutCubic))
                    .Append(card.transform.DOScale(1f, 0.2f).SetEase(Ease.InCubic))
                    .Join(cg.DOFade(0f, 0.2f).SetEase(Ease.InCubic))
                    .OnComplete(() =>
                    {
                        Destroy(card.gameObject);
                    });
            }
            else
            {
                Destroy(card.gameObject);
            }
        }

        public void RemoveCard(Card data)
        {
            if (condition == Condition.ChangeSide)
                return;
            if (!DeckIsFromLocal)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }

            var card = deckView.GetCardByData(data);
            if(card == null)
            {
                MessageManager.Toast(InterString.Get("无法删除更多卡片"));
                return;
            }

            RemoveCard(card);
        }

        public RectTransform GetDragCardImage()
        {
            if (managerUI == null)
                return null;

            return managerUI.GetElement<RectTransform>("DragCard");
        }

        public Vector3 GetDragCardPositon()
        {
            return managerUI.GetElement<RectTransform>("DragCard").position;
        }

        #endregion

        #region Card Collection View

        private void InitializeCardCollectionView()
        {
            cardCollectionView.SetNoItemButtonNavigationEvent(MoveDirection.Left, () =>
            {
                UserInput.NextSelectionIsAxis = true;
                SelectLastDeckViewItem();
            });
            inputSearch = cardCollectionView.GetInputField();
        }

        public void BookmarkCard(int code)
        {
            CardRarity.BookmarkCard(code);
            if(cardDetailView != null)
                cardDetailView.RefreshBookmarkToggle();
            if (_ResponseRegion == ResponseRegion.Action)
                cardActionMenu.RefreshBookmarkToggle();
            if(cardCollectionView.area == CardCollectionView.Area.Bookmark)
                cardCollectionView.PrintBookmarkCards();
        }

        public void UnbookmarkCard(int code)
        {
            CardRarity.UnbookmarkCard(code);
            if (cardDetailView != null)
                cardDetailView.RefreshBookmarkToggle();
            if (_ResponseRegion == ResponseRegion.Action)
                cardActionMenu.RefreshBookmarkToggle();
            if (cardCollectionView.area == CardCollectionView.Area.Bookmark)
                cardCollectionView.PrintBookmarkCards();
        }

        public void AddHistoryCard(int code)
        {
            cardCollectionView.AddHistoryCard(code);
        }

        public bool NeedAddCardToHistoryWhenClick()
        {
            return cardCollectionView.area != CardCollectionView.Area.History;
        }

        #endregion

        #region Action Menu

        private void ShowCardActionMenu()
        {
            if (_ResponseRegion == ResponseRegion.Deck
                && lastSelectedCardInDeck != null)
            {
                var list = new List<Card>();
                var index = 0;
                for (int i = 0; i < deckView.cards.Count; i++)
                {
                    list.Add(deckView.cards[i].Data);
                    if (deckView.cards[i] == lastSelectedCardInDeck)
                        index = i;
                }
                cardActionMenu.Show(list, index, _ResponseRegion);
                _ResponseRegion = ResponseRegion.Action;
            }
        }

        #endregion

        #region Header

        private bool callExit;

        private void InitializeHeader()
        {
            if (managerHeader == null)
                return;
            managerHeader.GetElement<SelectionButton>("ButtonBanlist")
                .SetButtonText(banlist.Name);
            managerHeader.GetElement<SelectionButton>("ButtonBanlist")
                .SetClickEvent(OnBanlist);
            managerHeader.GetElement<SelectionButton>("ButtonTest")
                .SetClickEvent(OnHandTest);
            managerHeader.GetElement<SelectionButton>("ButtonSort")
                .SetClickEvent(OnSort);
            managerHeader.GetElement<SelectionButton>("ButtonSave")
                .SetClickEvent(OnSave);
            managerHeader.GetElement<SelectionButton>("ButtonMenu")
                .SetClickEvent(OnSubMenu);
            managerHeader.GetElement<SelectionButton>("Back")
                .SetClickEvent(OnReturn);
        }

        private void SetCardInfoType()
        {
            var type = (CardInfoType)(((int)_CardInfoType + 1) % 3);
            SetCardInfoType(type);
        }

        public void SetCardInfoType(CardInfoType type)
        {
            AudioManager.PlaySE("SE_MENU_SELECT_01");
            _CardInfoType = type;
            switch (_CardInfoType)
            {
                case CardInfoType.None:
                    MessageManager.Toast(InterString.Get("切换到简单显示"));
                    break;
                case CardInfoType.Detail:
                    MessageManager.Toast(InterString.Get("切换到详情显示"));
                    break;
                case CardInfoType.Pool:
                    MessageManager.Toast(InterString.Get("切换到归属显示"));
                    break;
            }

            deckView.SetCardInfoType(type);
            cardCollectionView.SetCardInfoType(type);
        }

        private void RefreshRegulationIcons()
        {
            foreach (var card in deckView.cards)
                card.SetRegulationIcon();
            foreach (var go in cardCollectionView.superScrollView.gameObjects)
                go.GetComponent<SelectionButton_CardInCollection>()
                    .SetRegulationIcon();
        }

        private void OnBanlist()
        {
            AudioManager.PlaySE("SE_MENU_DECIDE");
            List<string> selections = new()
            {
                InterString.Get("禁限卡表"),
                string.Empty
            };
            foreach (var list in BanlistManager.Banlists)
                selections.Add(list.Name);
            UIManager.ShowPopupSelection(selections, ChangeBanlist);
        }

        private void ChangeBanlist()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            banlist = BanlistManager.GetByName(selected);
            managerHeader.GetElement<SelectionButton>("ButtonBanlist")
                .SetButtonText(selected);
            RefreshRegulationIcons();
        }

        private void OnSubMenu()
        {
            if (!deckView.deckLoaded) return;

            var menus = new List<string>()
            {
                InterString.Get("副菜单"),
                InterString.Get("重置"),
                InterString.Get("排序"),
                InterString.Get("打乱"),
                InterString.Get("复制"),
                InterString.Get("分享"),
                InterString.Get("测试"),
            };
            var actions = new List<Action>()
            {
                null,
                OnReset,
                OnSort,
                OnRandom,
                OnCopy,
                OnShare,
                OnHandTest
            };
            Program.instance.ui_.subMenu.Show(menus, actions);
        }

        private void OnSave()
        {
            if (!needSave) return;

            if (banlist.Name != BanlistManager.EmptyBanlistName)
            {
                if (deckView.mainCount > 60 || deckView.extraCount > 15 || deckView.sideCount > 15)
                {
                    List<string> tasks = new()
                    {
                        InterString.Get("保存失败"),
                        InterString.Get("卡组内卡片张数超过限制。@n如需无视限制，请将禁限卡表设置为无（N/A）。")
                    };
                    UIManager.ShowPopupConfirm(tasks);
                    callExit = false;
                    return;
                }
            }

            if (!DeckIsFromLocal && File.Exists(Program.deckPath + DeckName + Program.ydkExpansion))
            {
                List<string> tasks = new()
                    {
                        InterString.Get("该卡组名已存在"),
                        InterString.Get("该卡组名的文件已存在，是否直接覆盖创建？"),
                        InterString.Get("覆盖"),
                        InterString.Get("取消")
                    };
                UIManager.ShowPopupYesOrNo(tasks, OnSaveConfirmed, () => { callExit = false; });
            }
            else
                OnSaveConfirmed();
        }

        private void OnSaveConfirmed()
        {
            deckView.Save();
            if (callExit)
            {
                cg.blocksRaycasts = false;
                DOTween.To(v => { }, 0, 0, 2f).OnComplete(() =>
                {
                    OnExit();
                });
            }
            DeckIsFromLocal = true;

            inputDeckName.text = DeckName;

            deckView.SetCondition(DeckView.Condition.Editable);
        }

        private void OnReset()
        {
            if (!deckView.deckLoaded) return;
            if (!CheckDeckIsLocal()) return;

            deckView.ResetDeck();
        }

        private void OnSort()
        {
            if (!deckView.deckLoaded) return;
            if (!CheckDeckIsLocal()) return;

            needSave = true;

            List<SelectionButton_CardInDeck> main = new();
            List<SelectionButton_CardInDeck> extra = new();
            List<SelectionButton_CardInDeck> side = new();
            foreach (var card in deckView.cards)
            {
                if (card.location == DeckLocation.MainDeck)
                    main.Add(card);
                else if (card.location == DeckLocation.ExtraDeck)
                    extra.Add(card);
                else if (card.location == DeckLocation.SideDeck)
                    side.Add(card);
                card.LockPosition();
            }

            main.Sort((left, right) =>
            {
                return CardsManager.ComparisonOfCard()
                (left.Data, right.Data);
            });
            extra.Sort((left, right) =>
            {
                return CardsManager.ComparisonOfCard()
                (left.Data, right.Data);
            });
            side.Sort((left, right) =>
            {
                return CardsManager.ComparisonOfCard()
                (left.Data, right.Data);
            });

            for (int i = 0; i < main.Count; i++)
                main[i].transform.SetSiblingIndex(i);
            for (int i = 0; i < extra.Count; i++)
                extra[i].transform.SetSiblingIndex(i);
            for (int i = 0; i < side.Count; i++)
                side[i].transform.SetSiblingIndex(i);

            deckView.cards.Clear();
            deckView.cards = new(main);
            deckView.cards.AddRange(extra);
            deckView.cards.AddRange(side);
        }

        private void OnRandom()
        {

        }

        private void OnCopy()
        {

        }

        private void OnShare()
        {

        }

        private void OnHandTest()
        {

        }

        private bool CheckDeckIsLocal()
        {
            if (!DeckIsFromLocal && condition != Condition.ChangeSide)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return false;
            }
            return true;
        }

        private void ShowBackButton()
        {
            if (managerHeader == null)
                return;

            var rect = managerHeader.GetElement<RectTransform>("Back");
            rect.anchoredPosition3D = new Vector3(24f, 120f, 0f);
            DOTween.Sequence()
                .AppendInterval(0.6f)
                .Append(rect.DOAnchorPos3D(new Vector3(24f, 0f, 0f), 0.2f).SetEase(Ease.OutQuart));
        }

        private void HideBackButton()
        {
            managerHeader.GetElement("Back").SetActive(false);
        }

        #endregion

        #region Over Header

        private void InitializeOverHeader()
        {
            if (managerOverHeader == null)
                return;
            managerOverHeader.GetElement<SelectionButton>("AppearanceGroup").SetClickEvent(ShiftToAppearance);
            StartCoroutine(RefreshOverHeaderIconsAsync());
        }

        private IEnumerator RefreshOverHeaderIconsAsync()
        {
            if (managerOverHeader == null)
                yield break;

            managerOverHeader.GetElement<Image>("IconCase").color = Color.clear;
            managerOverHeader.GetElement<Image>("IconProtector").color = Color.clear;
            managerOverHeader.GetElement<Image>("IconField").color = Color.clear;
            managerOverHeader.GetElement<Image>("IconGrave").color = Color.clear;
            managerOverHeader.GetElement<Image>("IconStand").color = Color.clear;
            managerOverHeader.GetElement<Image>("IconMate").color = Color.clear;

            while (Deck == null)
            {
                yield return null;
            }

            var ie = Program.items.LoadItemIconAsync(Deck.Case.ToString(), Items.ItemType.Case);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            managerOverHeader.GetElement<Image>("IconCase").color = Color.white;
            managerOverHeader.GetElement<Image>("IconCase").sprite = ie.Current;

            var im = ABLoader.LoadProtectorMaterial(Deck.Protector.ToString());
            StartCoroutine(im);
            while (im.MoveNext())
                yield return null;
            managerOverHeader.GetElement<Image>("IconProtector").color = Color.white;
            managerOverHeader.GetElement<Image>("IconProtector").material = im.Current;

            ie = Program.items.LoadItemIconAsync(Deck.Field.ToString(), Items.ItemType.Mat);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            managerOverHeader.GetElement<Image>("IconField").color = Color.white;
            managerOverHeader.GetElement<Image>("IconField").sprite = ie.Current;

            ie = Program.items.LoadItemIconAsync(Deck.Grave.ToString(), Items.ItemType.Grave);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            managerOverHeader.GetElement<Image>("IconGrave").color = Color.white;
            managerOverHeader.GetElement<Image>("IconGrave").sprite = ie.Current;

            ie = Program.items.LoadItemIconAsync(Deck.Stand.ToString(), Items.ItemType.Stand);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            managerOverHeader.GetElement<Image>("IconStand").color = Color.white;
            managerOverHeader.GetElement<Image>("IconStand").sprite = ie.Current;

            var mate = Deck.Mate.ToString();
            if (mate.Length == 7 && mate.StartsWith("100"))
            {
                ie = Program.items.LoadItemIconAsync(mate, Items.ItemType.Mate);
                StartCoroutine(ie);
                while (ie.MoveNext())
                    yield return null;
                managerOverHeader.GetElement<Image>("IconMate").color = Color.white;
                managerOverHeader.GetElement<Image>("IconMate").sprite = ie.Current;
            }
            else
            {
                var task = TextureManager.LoadArtAsync(Deck.Mate, true);
                while (!task.IsCompleted)
                    yield return null;
                managerOverHeader.GetElement<Image>("IconMate").color = Color.white;
                managerOverHeader.GetElement<Image>("IconMate").sprite = TextureManager.Texture2Sprite(task.Result);
            }
        }

        private void ShiftToAppearance()
        {
            needSave = true;
            gotoAppearance = true;
            Program.instance.appearance.SwitchCondition(Appearance.Condition.DeckEditor);
            Program.instance.ShiftToServant(Program.instance.appearance);
        }

        #endregion

        #region Other
        private void ChangeCanvasMatch()
        {
            if (!showing)
                return;

            UIManager.SetCanvasMatch(GetCanvasMatch(), 0f);
        }

        private int GetCanvasMatch()
        {
            if ((float)Screen.width / Screen.height > 16f / 9f)
                return 1;
            else return 0;
        }

        #endregion
    }
}