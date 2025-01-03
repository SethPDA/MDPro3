using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using Mono.Cecil.Cil;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class DeckView : UIWidget
    {
        #region Elements

        #region Root

        private const string LABEL_DTM_LOADING = "Loading";
        private DoTweenManager m_TweenLoading;
        protected DoTweenManager TweenLoading =>
            m_TweenLoading = m_TweenLoading != null ? m_TweenLoading
            : Manager.GetElement<DoTweenManager>(LABEL_DTM_LOADING);

        private const string LABEL_CG_VIEWPORT = "Viewport";
        private CanvasGroup m_Viewport;
        protected CanvasGroup Viewport =>
            m_Viewport = m_Viewport != null ? m_Viewport
            : Manager.GetElement<CanvasGroup>(LABEL_CG_VIEWPORT);

        private const string LABEL_SBN_NOITEM = "NoItemButton";
        private SelectionButton m_ButtonNoItem;
        protected SelectionButton ButtonNoItem =>
            m_ButtonNoItem = m_ButtonNoItem != null ? m_ButtonNoItem
            : Manager.GetElement<SelectionButton>(LABEL_SBN_NOITEM);

        private const string LABEL_TXT_NOITEM = "NoItemText";
        private TextMeshProUGUI m_TextNoItem;
        private TextMeshProUGUI TextNoItem =>
            m_TextNoItem = m_TextNoItem != null ? m_TextNoItem
            : Manager.GetElement<TextMeshProUGUI>(LABEL_TXT_NOITEM);

        private const string LABEL_GPC_CURSORWINDOWSELECT = "CursorWindowSelect";
        private GamepadCursor m_CursorWindowSelect;
        protected GamepadCursor CursorWindowSelect =>
            m_CursorWindowSelect = m_CursorWindowSelect != null ? m_CursorWindowSelect
            : Manager.GetElement<GamepadCursor>(LABEL_GPC_CURSORWINDOWSELECT);

        private const string LABEL_SR_DECKVIEW = "ScrollRect";
        private ScrollRect m_ScrollRect;
        public ScrollRect ScrollRect =>
            m_ScrollRect = m_ScrollRect != null ? m_ScrollRect
            : Manager.GetElement<ScrollRect>(LABEL_SR_DECKVIEW);

        #endregion

        #region HeaderArea

        private const string LABEL_RT_HEADERAREA = "HeaderArea";
        private RectTransform m_HeaderArea;
        protected RectTransform HeaderArea =>
            m_HeaderArea = m_HeaderArea != null ? m_HeaderArea
            : Manager.GetElement<RectTransform>(LABEL_RT_HEADERAREA);

        private const string LABEL_TXT_DECKNAME = "HeaderArea/DeckNameText";
        private TextMeshProUGUI m_TextDeckName;
        protected TextMeshProUGUI TextDeckName =>
            m_TextDeckName = m_TextDeckName != null ? m_TextDeckName
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_DECKNAME);

        private const string LABEL_GO_NAMEAREAGROUP = "HeaderArea/NameAreaGroup";
        private GameObject m_NameAreaGroup;
        protected GameObject NameAreaGroup =>
            m_NameAreaGroup = m_NameAreaGroup != null ? m_NameAreaGroup
            : Manager.GetNestedElement(LABEL_GO_NAMEAREAGROUP);

        private const string LABEL_IPT_DECKNAME = "HeaderArea/InputField";
        private TMP_InputField m_InputDeckName;
        protected TMP_InputField InputDeckName =>
            m_InputDeckName = m_InputDeckName != null ? m_InputDeckName
            : Manager.GetNestedElement<TMP_InputField>(LABEL_IPT_DECKNAME);

        private const string LABEL_SBN_BUTTON_DECK = "HeaderArea/ButtonDeck";
        private SelectionButton m_ButtonDeck;
        protected SelectionButton ButtonDeck =>
            m_ButtonDeck = m_ButtonDeck != null ? m_ButtonDeck :
            Manager.GetNestedElement<SelectionButton>(LABEL_SBN_BUTTON_DECK);


        private const string LABEL_IMG_DECK = "HeaderArea/IconDeck";
        private Image m_IconDeck;
        protected Image IconDeck =>
            m_IconDeck = m_IconDeck != null ? m_IconDeck
            : Manager.GetNestedElement<Image>(LABEL_IMG_DECK);

        #endregion

        #region MainDeckView

        private const string LABEL_UH_MAINDECKVIEW = "MainDeckView";
        private UIHover m_MainDeckView;
        protected UIHover MainDeckView =>
            m_MainDeckView = m_MainDeckView != null ? m_MainDeckView
            : Manager.GetElement<UIHover>(LABEL_UH_MAINDECKVIEW);

        private const string LABEL_TXT_MAINDECKCARDNUM = "MainDeckView/TextMainDeckCardNum";
        private TextMeshProUGUI m_TextMainDeckCardNum;
        protected TextMeshProUGUI TextMainDeckCardNum =>
            m_TextMainDeckCardNum = m_TextMainDeckCardNum != null ? m_TextMainDeckCardNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_MAINDECKCARDNUM);

        private const string LABEL_TXT_MAINDECKMONSTERNUM = "MainDeckView/TextMainDeckMonsterNum";
        private TextMeshProUGUI m_TextMainDeckMonsterNum;
        protected TextMeshProUGUI TextMainDeckMonsterNum =>
            m_TextMainDeckMonsterNum = m_TextMainDeckMonsterNum != null ? m_TextMainDeckMonsterNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_MAINDECKMONSTERNUM);

        private const string LABEL_TXT_MAINDECKSPELLNUM = "MainDeckView/TextMainDeckSpellNum";
        private TextMeshProUGUI m_TextMainDeckSpellNum;
        protected TextMeshProUGUI TextMainDeckSpellNum =>
            m_TextMainDeckSpellNum = m_TextMainDeckSpellNum != null ? m_TextMainDeckSpellNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_MAINDECKSPELLNUM);

        private const string LABEL_TXT_MAINDECKTRAPNUM = "MainDeckView/TextMainDeckTrapNum";
        private TextMeshProUGUI m_TextMainDeckTrapNum;
        protected TextMeshProUGUI TextMainDeckTrapNum =>
            m_TextMainDeckTrapNum = m_TextMainDeckTrapNum != null ? m_TextMainDeckTrapNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_MAINDECKTRAPNUM);

        private const string LABEL_GLG_MainDeckContent = "MainDeckView/MainDeckContent";
        private GridLayoutGroup m_MainDeckContent;
        protected GridLayoutGroup MainDeckContent =>
            m_MainDeckContent = m_MainDeckContent != null ? m_MainDeckContent
            : Manager.GetNestedElement<GridLayoutGroup>(LABEL_GLG_MainDeckContent);

        private const string LABEL_GO_TEMPLATE = "MainDeckView/template";
        private GameObject m_Template;
        protected GameObject Template =>
            m_Template = m_Template != null ? m_Template
            : Manager.GetNestedElement(LABEL_GO_TEMPLATE);

        #endregion

        #region ExtraDeckView

        private const string LABEL_UH_EXTRADECKVIEW = "ExtraDeckView";
        private UIHover m_ExtraDeckView;
        protected UIHover ExtraDeckView =>
            m_ExtraDeckView = m_ExtraDeckView != null ? m_ExtraDeckView
            : Manager.GetElement<UIHover>(LABEL_UH_EXTRADECKVIEW);

        private const string LABEL_TXT_EXTRADECKCARDNUM = "ExtraDeckView/TextExtraDeckCardNum";
        private TextMeshProUGUI m_TextExtraDeckCardNum;
        protected TextMeshProUGUI TextExtraDeckCardNum =>
            m_TextExtraDeckCardNum = m_TextExtraDeckCardNum != null ? m_TextExtraDeckCardNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_EXTRADECKCARDNUM);

        private const string LABEL_TXT_EXTRADECKFUSIONNUM = "ExtraDeckView/TextExtraDeckFusionNum";
        private TextMeshProUGUI m_TextExtraDeckFusionNum;
        protected TextMeshProUGUI TextExtraDeckFusionNum =>
            m_TextExtraDeckFusionNum = m_TextExtraDeckFusionNum != null ? m_TextExtraDeckFusionNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_EXTRADECKFUSIONNUM);

        private const string LABEL_TXT_EXTRADECKSYNCHRONUM = "ExtraDeckView/TextExtraDeckSynchroNum";
        private TextMeshProUGUI m_TextExtraDeckSynchroNum;
        protected TextMeshProUGUI TextExtraDeckSynchroNum =>
            m_TextExtraDeckSynchroNum = m_TextExtraDeckSynchroNum != null ? m_TextExtraDeckSynchroNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_EXTRADECKSYNCHRONUM);

        private const string LABEL_TXT_EXTRADECKXYZNUM = "ExtraDeckView/TextExtraDeckXyzNum";
        private TextMeshProUGUI m_TextExtraDeckXyzNum;
        protected TextMeshProUGUI TextExtraDeckXyzNum =>
            m_TextExtraDeckXyzNum = m_TextExtraDeckXyzNum != null ? m_TextExtraDeckXyzNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_EXTRADECKXYZNUM);

        private const string LABEL_TXT_EXTRADECKLINKNUM = "ExtraDeckView/TextExtraDeckLinkNum";
        private TextMeshProUGUI m_TextExtraDeckLinkNum;
        protected TextMeshProUGUI TextExtraDeckLinkNum =>
            m_TextExtraDeckLinkNum = m_TextExtraDeckLinkNum != null ? m_TextExtraDeckLinkNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_EXTRADECKLINKNUM);

        private const string LABEL_GLG_EXTRADeckContent = "ExtraDeckView/ExtraDeckContent";
        private GridLayoutGroup m_ExtraDeckContent;
        protected GridLayoutGroup ExtraDeckContent =>
            m_ExtraDeckContent = m_ExtraDeckContent != null ? m_ExtraDeckContent
            : Manager.GetNestedElement<GridLayoutGroup>(LABEL_GLG_EXTRADeckContent);

        #endregion

        #region SideDeckView

        private const string LABEL_UH_SIDEDECKVIEW = "SideDeckView";
        private UIHover m_SideDeckView;
        protected UIHover SideDeckView =>
            m_SideDeckView = m_SideDeckView != null ? m_SideDeckView
            : Manager.GetElement<UIHover>(LABEL_UH_SIDEDECKVIEW);

        private const string LABEL_TXT_SIDEDECKCARDNUM = "SideDeckView/TextSideDeckCardNum";
        private TextMeshProUGUI m_TextSideDeckCardNum;
        protected TextMeshProUGUI TextSideDeckCardNum =>
            m_TextSideDeckCardNum = m_TextSideDeckCardNum != null ? m_TextSideDeckCardNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_SIDEDECKCARDNUM);

        private const string LABEL_TXT_SIDEDECKMONSTERNUM = "SideDeckView/TextSideDeckMonsterNum";
        private TextMeshProUGUI m_TextSideDeckMonsterNum;
        protected TextMeshProUGUI TextSideDeckMonsterNum =>
            m_TextSideDeckMonsterNum = m_TextSideDeckMonsterNum != null ? m_TextSideDeckMonsterNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_SIDEDECKMONSTERNUM);

        private const string LABEL_TXT_SIDEDECKSPELLNUM = "SideDeckView/TextSideDeckSpellNum";
        private TextMeshProUGUI m_TextSideDeckSpellNum;
        protected TextMeshProUGUI TextSideDeckSpellNum =>
            m_TextSideDeckSpellNum = m_TextSideDeckSpellNum != null ? m_TextSideDeckSpellNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_SIDEDECKSPELLNUM);

        private const string LABEL_TXT_SIDEDECKTRAPNUM = "SideDeckView/TextSideDeckTrapNum";
        private TextMeshProUGUI m_TextSideDeckTrapNum;
        protected TextMeshProUGUI TextSideDeckTrapNum =>
            m_TextSideDeckTrapNum = m_TextSideDeckTrapNum != null ? m_TextSideDeckTrapNum
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_SIDEDECKTRAPNUM);

        private const string LABEL_GLG_SideDeckContent = "SideDeckView/SideDeckContent";
        private GridLayoutGroup m_SideDeckContent;
        protected GridLayoutGroup SideDeckContent =>
            m_SideDeckContent = m_SideDeckContent != null ? m_SideDeckContent
            : Manager.GetNestedElement<GridLayoutGroup>(LABEL_GLG_SideDeckContent);

        #endregion

        #endregion

        #region Reference
        public enum DeckLocation
        {
            MainDeck = 1,
            ExtraDeck = 2,
            SideDeck = 4,
            All = 7
        }

        public enum Condition
        {
            Editable,
            OnlyReorder,
            Pickup,
            NonEditable
        }
        protected Condition condition;
        protected float contentWidth = 772f - 16f;
        protected float templateWidth = 72f;
        protected Vector2 defaultSpacing = new(4f, 4f);
        protected float defaultVerticalSpacing = 4f;
        protected int defaultColumns = 10;
        protected int defaultMainDeckRows = 4;
        protected int defaultExtraDeckRows = 1;
        protected int defaultSideDeckRows = 1;
        protected Vector3 dragCardScale = new(1.7f, 1.7f, 1f);

        public bool deckLoaded;
        public int mainCount;
        public int extraCount;
        public int sideCount;
        public List<SelectionButton_CardInDeck> cards;
        public Deck deck;

        protected string deckName;
        protected bool needSave;

        #endregion

        #region Public Functions

        public void PrintDeck(Deck deck, string deckName, Condition condition)
        {
            this.deck = deck;
            this.deckName = deckName;
            this.condition = condition;

            SetCondition(condition);
            InputDeckName.text = deckName;
            TextDeckName.text = deckName;

            StartCoroutine(PrintDeckAsync());
        }

        public void ResetDeck()
        {
            PrintDeck(deck, deckName, condition);
        }

        public void SetDirty()
        {
            needSave = true;
        }

        public bool GetDirty()
        {
            if (condition == Condition.Editable && InputDeckName.text != deckName)
                return true;
            return needSave;
        }

        public string GetDeckName()
        {
            if (condition == Condition.Editable)
                return InputDeckName.text;
            else
                return deckName;
        }

        public void SetCondition(Condition condition)
        {
            this.condition = condition;
            NameAreaGroup.SetActive(condition == Condition.Editable);
            TextDeckName.gameObject.SetActive(condition != Condition.Editable);
        }

        public RectTransform GetDeckLocationParent(DeckLocation location)
        {
            return location switch
            {
                DeckLocation.MainDeck => MainDeckContent.GetComponent<RectTransform>(),
                DeckLocation.ExtraDeck => ExtraDeckContent.GetComponent<RectTransform>(),
                DeckLocation.SideDeck => SideDeckContent.GetComponent<RectTransform>(),
                _ => null
            };
        }

        public int GetCardCount(int code)
        {
            var count = 0;
            var data = CardsManager.Get(code);
            if (data == null) return count;

            foreach (var card in cards)
            {
                if (card.Data == null || card.Data.Id == 0)
                    continue;

                if (data.Alias == 0)
                {
                    if (card.Data.Id == code || card.Data.Alias == code)
                        count++;
                }
                else
                {
                    if (card.Data.Id == data.Alias || card.Data.Alias == data.Alias)
                        count++;
                }
            }
            return count;
        }

        public void AddCard(Card data, bool callAnimation, bool playBirthAnimation)
        {
            if (!deckLoaded) return;
            if (condition == Condition.NonEditable)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }
            if (!CanAddCard(data.Id)) return;

            AudioManager.PlaySE("SE_DECK_PLUS");
            var targetLocaltion = DeckLocation.SideDeck;
            if (data.IsExtraCard())
            {
                if (GetDeckLocationCount(DeckLocation.ExtraDeck) < 15)
                    targetLocaltion = DeckLocation.ExtraDeck;
            }
            else if (GetDeckLocationCount(DeckLocation.MainDeck) < 60)
                targetLocaltion = DeckLocation.MainDeck;

            AddCard(data, targetLocaltion, callAnimation, playBirthAnimation);
        }

        public void AddCardFromPosition(Card data, Vector3 position)
        {
            if (!deckLoaded) return;
            if (condition == Condition.NonEditable)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }
            else if (condition != Condition.Editable)
                return;
            if (!CanAddCard(data.Id))
                return;

            SortCards();
            SelectionButton_CardInDeck hoverCard = null;
            foreach (var card in cards)
                if (card.IsHovering())
                {
                    hoverCard = card;
                    break;
                }

            DeckLocation location = DeckLocation.All;
            if (hoverCard == null)
                location = GetHoveredLocation();
            else
                location = hoverCard.location;

            if (location == DeckLocation.All || !CanSwitchPosition(data, location))
                return;

            if (hoverCard == null)
            {
                var added = AddCard(data, location, true, false);
                added.MoveToParent(position);
            }
            else
            {
                var added = AddCard(data, location, false, false);
                foreach (var card in cards)
                    if (card.location == location)
                        if (card != added)
                            card.LockPosition();
                added.LockPosition(position, dragCardScale);
                added.transform.SetSiblingIndex(hoverCard.transform.GetSiblingIndex());
            }
        }

        public void AddCardFromPositionWithSequence(Card data, Vector3 position)
        {
            if (!deckLoaded) return;
            if (condition == Condition.NonEditable)
            {
                MessageManager.Toast(InterString.Get("请先保存卡组"));
                return;
            }
            else if (condition != Condition.Editable)
                return;
            if (!CanAddCard(data.Id))
                return;

            SortCards();
            AudioManager.PlaySE("SE_DECK_PLUS");

            var targetLocaltion = DeckLocation.SideDeck;
            if (data.IsExtraCard())
            {
                if (GetDeckLocationCount(DeckLocation.ExtraDeck) < 15)
                    targetLocaltion = DeckLocation.ExtraDeck;
            }
            else if (GetDeckLocationCount(DeckLocation.MainDeck) < 60)
                targetLocaltion = DeckLocation.MainDeck;

            var added = AddCard(data, targetLocaltion, true, false);
            added.MoveToParentSequence(position);
        }

        public void DragCardTo(SelectionButton_CardInDeck dragCard, Vector3 position)
        {
            if (!deckLoaded) return;
            SortCards();

            SelectionButton_CardInDeck hoverCard = null;
            foreach (var card in cards)
                if (card.IsHovering())
                {
                    hoverCard = card;
                    break;
                }

            DeckLocation location;
            if (hoverCard == null)
                location = GetHoveredLocation();
            else
                location = hoverCard.location;

            if (location == DeckLocation.All || !CanSwitchPosition(dragCard.Data, location))
            {
                dragCard.MoveToParent(position);
                return;
            }

            needSave = true;
            if (dragCard.location == location)
            {
                if (hoverCard == null)
                {
                    dragCard.MoveToParent(position);
                    return;
                }

                foreach (var card in cards)
                    if (card.location == location)
                        if (card != dragCard)
                            card.LockPosition();
                dragCard.LockPosition(position, dragCardScale);
                dragCard.transform.SetSiblingIndex(hoverCard.transform.GetSiblingIndex());
            }
            else
            {
                if (hoverCard == null)
                {
                    MoveCardToLocation(dragCard, location, position);
                    return;
                }

                foreach (var card in cards)
                    if (card != dragCard)
                        if (card.location == dragCard.location || card.location == location)
                            card.LockPosition();
                dragCard.LockPosition(position, dragCardScale);

                var indexHover = hoverCard.transform.GetSiblingIndex();
                dragCard.transform.SetParent(hoverCard.transform.parent, false);
                dragCard.transform.SetSiblingIndex(indexHover);
                dragCard.location = hoverCard.location;
                RefreshCardsCount(DeckLocation.All);
                ChangeGridSpacing(DeckLocation.All);
            }
        }

        public void MoveCardToLocation(SelectionButton_CardInDeck card, DeckLocation location, Vector3 position)
        {
            if (!deckLoaded) return;

            foreach (var c in cards)
                if (c != card)
                    if (c.location == location || c.location == card.location)
                        c.LockPosition();
            card.LockPosition(position, dragCardScale);

            card.transform.SetParent(GetDeckLocationParent(location), false);
            card.location = location;
            RefreshCardsCount(DeckLocation.All);
            ChangeGridSpacing(DeckLocation.All);
        }

        public void RemoveCard(SelectionButton_CardInDeck card, bool needSelect)
        {
            if (!deckLoaded || condition != Condition.Editable) return;
            needSave = true;

            SortCards();
            int index = 0;
            for (int i = 0; i < cards.Count; i++)
                if (cards[i].location == card.location)
                {
                    if (cards[i] != card)
                    {
                        if(needSelect)
                            cards[i].LockPosition();
                    }
                    else
                        index = i;
                }

            cards.RemoveAt(index);            

            if(needSelect)
            {
                if (index - 1 >= 0
                    && index < cards.Count
                    && cards[index].location != card.location)
                    index--;
                if (cards.Count <= index)
                    index = cards.Count - 1;

                if (cards.Count == 0)
                {
                    TextNoItem.gameObject.SetActive(true);
                    if(UserInput.gamepadType != UserInput.GamepadType.None)
                        EventSystem.current.SetSelectedGameObject(ButtonNoItem.gameObject);
                }
                else if (UserInput.gamepadType != UserInput.GamepadType.None)
                    EventSystem.current.SetSelectedGameObject(cards[index].gameObject);
            }

            RefreshCardsCount(card.location);
            ChangeGridSpacing(card.location);
        }

        public SelectionButton_CardInDeck GetCardByData(Card data)
        {
            if (!deckLoaded) return null;

            List<SelectionButton_CardInDeck> aliasCards = new();
            foreach (var card in cards)
            {
                if (card.Data.Id == data.Id)
                    return card;

                if (data.Alias == 0)
                {
                    if (card.Data.Alias == data.Id)
                        aliasCards.Add(card);
                }
                else
                {
                    if (card.Data.Id == data.Alias || card.Data.Alias == data.Alias)
                        aliasCards.Add(card);
                }
            }
            if (aliasCards.Count > 0)
                return aliasCards[0];
            else
                return null;
        }

        public SelectionButton_CardInDeck GetNavigationTarget(
            DeckLocation location, MoveDirection direction
            , int targetColumn, int fromColumn)
        {
            var targetList = new List<SelectionButton_CardInDeck>();
            foreach (var card in cards)
                if (card.location == location)
                    targetList.Add(card);

            if (targetList.Count == 0)
            {
                if (location == DeckLocation.ExtraDeck)
                {
                    if (direction == MoveDirection.Up)
                        location = DeckLocation.MainDeck;
                    else if (direction == MoveDirection.Down)
                        location = DeckLocation.SideDeck;
                    foreach (var card in cards)
                        if (card.location == location)
                            targetList.Add(card);
                    if (targetList.Count == 0)
                        return null;
                }
                else
                    return null;
            }

            var columnCount = GetDeckLocationParent(location)
                .GetComponent<GridLayoutGroup>().Size().x;

            if (columnCount < defaultColumns)
                columnCount = defaultColumns;
            if (fromColumn < 0)
                fromColumn = defaultColumns;
            targetColumn = Mathf.RoundToInt(targetColumn * columnCount / (float)fromColumn);

            if (location == DeckLocation.MainDeck)
            {
                var lastColumnCount = mainCount % columnCount;
                if (lastColumnCount == 0)
                    lastColumnCount = columnCount;

                bool onlyOneColumn = lastColumnCount == mainCount || lastColumnCount == columnCount;

                if (onlyOneColumn)
                {
                    if (targetColumn >= lastColumnCount)
                        return targetList[^1];
                    else
                        return targetList[^(lastColumnCount - targetColumn)];
                }
                else
                {
                    if (targetColumn >= lastColumnCount)
                        return targetList[^(lastColumnCount + columnCount - targetColumn)];
                    else
                        return targetList[^(lastColumnCount - targetColumn)];
                }
            }
            else
            {
                if (targetColumn >= targetList.Count)
                    targetColumn = targetList.Count - 1;
                return targetList[targetColumn];
            }
        }

        public bool CanAddCard(int code)
        {
            var count = GetCardCount(code);
            if (count >= DeckEditor.banlist.GetQuantity(code))
            {
                if (count == 3)
                    MessageManager.Toast(InterString.Get("卡组中同名卡片不得超过3张"));
                else if (count == 2)
                    MessageManager.Toast(InterString.Get("卡组中准限制卡片不得超过2张，@n如需无视限制，请将禁限卡表设置为无（N/A）。"));
                else if (count == 1)
                    MessageManager.Toast(InterString.Get("卡组中限制卡片不得超过1张，@n如需无视限制，请将禁限卡表设置为无（N/A）。"));
                else
                    MessageManager.Toast(InterString.Get("无法将禁止卡片放入卡组，@n如需无视限制，请将禁限卡表设置为无（N/A）。"));
                return false;
            }
            return true;
        }

        public bool CanSwitchPosition(Card card, DeckLocation location)
        {
            if (card.IsExtraCard() && location == DeckLocation.MainDeck)
            {
                MessageManager.Toast(InterString.Get("无法将该卡片加入主卡组"));
                return false;
            }
            if (!card.IsExtraCard() && location == DeckLocation.ExtraDeck)
            {
                MessageManager.Toast(InterString.Get("无法将该卡片加入额外卡组"));
                return false;
            }
            return true;
        }

        public void HideDeckLocationTable()
        {
            MainDeckView.Hide();
            ExtraDeckView.Hide();
            SideDeckView.Hide();
        }

        public void SetCursor(bool selected)
        {
            CursorWindowSelect.Show = selected;
            foreach (var shortcut in transform.GetComponentsInChildren<ShortcutIcon>(true))
                shortcut.GroupShow = selected;
        }

        public void SelectDefaultItem()
        {
            if (cards.Count > 0)
            {
                SortCards();
                EventSystem.current.SetSelectedGameObject(cards[0].gameObject);
            }
            else
                EventSystem.current.SetSelectedGameObject(ButtonNoItem.gameObject);
        }

        public void SelectNearestCard(Vector3 fromPosition)
        {
            UserInput.NextSelectionIsAxis = true;
            if (cards.Count == 0)
            {
                SelectDefaultItem();
                return;
            }

            var distance = new Dictionary<SelectionButton_CardInDeck, float>();
            foreach (var card in cards)
                distance.Add(card, Vector3.Distance(fromPosition, card.transform.position));
            var minKey = distance.Aggregate((left, right) => left.Value < right.Value ? left : right).Key;
            EventSystem.current.SetSelectedGameObject(minKey.gameObject);
        }

        public void SetNoItemButtonNavigationEvent(MoveDirection direction, UnityAction navigation)
        {
            ButtonNoItem.SetNavigationEvent(direction, navigation);
        }

        public void Save()
        {
            deck = FromObjectDeckToCodedDeck();
            DeckFileSave();
        }

        public int GetDeckLocationCount(DeckLocation location)
        {
            int count = 0;
            if ((location & DeckLocation.MainDeck) > 0)
                count += GetDeckLocationParent(DeckLocation.MainDeck).childCount;
            if ((location & DeckLocation.ExtraDeck) > 0)
                count += GetDeckLocationParent(DeckLocation.ExtraDeck).childCount;
            if ((location & DeckLocation.SideDeck) > 0)
                count += GetDeckLocationParent(DeckLocation.SideDeck).childCount;
            return count;
        }

        public void SetCardInfoType(DeckEditor.CardInfoType type)
        {
            foreach (var card in cards)
                card.RefreshIcons();
        }

        public TMP_InputField GetInputField()
        {
            return InputDeckName;
        }

        public void RefreshRarity(int code)
        {
            foreach (var card in cards)
                card.RefreshRarity(code);
        }

        #endregion

        #region Protected Functions

        protected override void Awake()
        {
            base.Awake();

            Template.transform.SetParent(transform, false);
            Template.SetActive(false);
        }

        protected IEnumerator PrintDeckAsync()
        {
            deckLoaded = false;

            if (cards != null)
                foreach (var card in cards)
                    Destroy(card.gameObject);
            cards = new();

            Viewport.alpha = 0f;
            Viewport.blocksRaycasts = false;

            if (Program.instance.deckEditor.inTransition)
                yield return null;
            TweenLoading.Show();

            int count = 0;

            foreach (var card in deck.Main)
            {
                var handler = AddCard(CardsManager.Get(card), DeckLocation.MainDeck, false, false);
                count++;
                if (count == TextureLoader.MAX_LOADING_THREADS)
                {
                    count = 0;
                    while (!handler.refreshed)
                        yield return null;
                }
            }
            yield return new WaitForSeconds(0.1f);
            foreach (var card in deck.Extra)
            {
                var handler = AddCard(CardsManager.Get(card), DeckLocation.ExtraDeck, false, false);
                count++;
                if (count == TextureLoader.MAX_LOADING_THREADS)
                {
                    count = 0;
                    while (!handler.refreshed)
                        yield return null;
                }
            }
            yield return new WaitForSeconds(0.1f);
            foreach (var card in deck.Side)
            {
                var handler = AddCard(CardsManager.Get(card), DeckLocation.SideDeck, false, false);
                count++;
                if (count == TextureLoader.MAX_LOADING_THREADS)
                {
                    count = 0;
                    while (!handler.refreshed)
                        yield return null;
                }
            }
            yield return new WaitForSeconds(0.1f);

            TweenLoading.Hide();
            Viewport.alpha = 1f;
            Viewport.blocksRaycasts = true;

            deckLoaded = true;
            needSave = false;
            if (cards.Count > 0)
                EventSystem.current.SetSelectedGameObject(cards[0].gameObject);
        }


        protected virtual void ChangeGridSpacing(DeckLocation location)
        {
            if ((location & DeckLocation.MainDeck) > 0)
            {
                int count = GetDeckLocationCount(DeckLocation.MainDeck);
                if (count <= defaultMainDeckRows * defaultColumns)
                    MainDeckContent.spacing = defaultSpacing;
                else
                {
                    int columns = Mathf.CeilToInt((float)count / defaultMainDeckRows);
                    var targetSpace = (contentWidth - columns * templateWidth) / (columns - 1);
                    MainDeckContent.spacing = new Vector2(targetSpace, defaultVerticalSpacing);
                }
            }
            if ((location & DeckLocation.ExtraDeck) > 0)
            {
                int count = GetDeckLocationCount(DeckLocation.ExtraDeck);
                if (count <= defaultExtraDeckRows * defaultColumns)
                    ExtraDeckContent.spacing = defaultSpacing;
                else
                {
                    int columns = Mathf.CeilToInt((float)count / defaultExtraDeckRows);
                    var targetSpace = (contentWidth - columns * templateWidth) / (columns - 1);
                    ExtraDeckContent.spacing = new Vector2(targetSpace, defaultVerticalSpacing);
                }
            }
            if ((location & DeckLocation.SideDeck) > 0)
            {
                int count = GetDeckLocationCount(DeckLocation.SideDeck);
                if (count <= defaultSideDeckRows * defaultColumns)
                    SideDeckContent.spacing = defaultSpacing;
                else
                {
                    int columns = Mathf.CeilToInt((float)count / defaultSideDeckRows);
                    var targetSpace = (contentWidth - columns * templateWidth) / (columns - 1);
                    SideDeckContent.spacing = new Vector2(targetSpace, defaultVerticalSpacing);
                }
            }
        }

        protected void RefreshCardsCount(DeckLocation location)
        {
            if ((location & DeckLocation.MainDeck) > 0)
            {
                mainCount = 0;
                int monsterCount = 0;
                int spellCount = 0;
                int trapCount = 0;

                foreach (var card in cards)
                    if (card.location == DeckLocation.MainDeck)
                    {
                        mainCount++;
                        if (card.Data.HasType(CardType.Spell))
                            spellCount++;
                        else if (card.Data.HasType(CardType.Trap))
                            trapCount++;
                        else
                            monsterCount++;
                    }
                TextMainDeckCardNum.text = mainCount.ToString();
                TextMainDeckMonsterNum.text = monsterCount.ToString();
                TextMainDeckSpellNum.text = spellCount.ToString();
                TextMainDeckTrapNum.text = trapCount.ToString();
            }
            if ((location & DeckLocation.ExtraDeck) > 0)
            {
                extraCount = 0;
                int fusionCount = 0;
                int synchroCount = 0;
                int xyzCount = 0;
                int linkCount = 0;

                foreach (var card in cards)
                    if (card.location == DeckLocation.ExtraDeck)
                    {
                        extraCount++;
                        if (card.Data.HasType(CardType.Fusion))
                            fusionCount++;
                        else if (card.Data.HasType(CardType.Synchro))
                            synchroCount++;
                        else if (card.Data.HasType(CardType.Xyz))
                            xyzCount++;
                        else if (card.Data.HasType(CardType.Link))
                            linkCount++;
                    }
                TextExtraDeckCardNum.text = extraCount.ToString();
                TextExtraDeckFusionNum.text = fusionCount.ToString();
                TextExtraDeckSynchroNum.text = synchroCount.ToString();
                TextExtraDeckXyzNum.text = xyzCount.ToString();
                TextExtraDeckLinkNum.text = linkCount.ToString();
            }
            if ((location & DeckLocation.SideDeck) > 0)
            {
                sideCount = 0;
                int monsterCount = 0;
                int spellCount = 0;
                int trapCount = 0;

                foreach (var card in cards)
                    if (card.location == DeckLocation.SideDeck)
                    {
                        sideCount++;
                        if (card.Data.HasType(CardType.Spell))
                            spellCount++;
                        else if (card.Data.HasType(CardType.Trap))
                            trapCount++;
                        else
                            monsterCount++;
                    }
                TextSideDeckCardNum.text = sideCount.ToString();
                TextSideDeckMonsterNum.text = monsterCount.ToString();
                TextSideDeckSpellNum.text = spellCount.ToString();
                TextSideDeckTrapNum.text = trapCount.ToString();
            }
        }

        protected void SortCards()
        {
            if (cards == null)
                return;
            cards.Sort(ComparisonOfCard());
        }

        internal static Comparison<SelectionButton_CardInDeck> ComparisonOfCard()
        {
            return (left, right) =>
            {
                int a = -1;
                if (left.location < right.location)
                    a = -1;
                else if (right.location < left.location)
                    a = 1;
                else
                {
                    if (left.transform.GetSiblingIndex() <= right.transform.GetSiblingIndex())
                        a = -1;
                    else
                        a = 1;
                }
                return a;
            };
        }

        protected SelectionButton_CardInDeck AddCard(Card data, DeckLocation location, bool callAnimation, bool playBirthAnimation)
        {
            needSave = true;

            SortCards();
            TextNoItem.gameObject.SetActive(false);

            if (callAnimation)
                foreach (var card in cards)
                    if (card.location == location)
                        card.LockPosition();

            var template = Instantiate(Template);
            template.SetActive(true);
            template.transform.SetParent(GetDeckLocationParent(location), false);
            var handler = template.GetComponent<SelectionButton_CardInDeck>();
            handler.deckView = this;
            handler.Data = data;
            handler.location = location;
            cards.Add(handler);
            RefreshCardsCount(location);
            ChangeGridSpacing(location);

            if (playBirthAnimation)
                handler.PlayBirthAnimation();

            return handler;
        }

        protected DeckLocation GetHoveredLocation()
        {
            if (MainDeckView.hover)
                return DeckLocation.MainDeck;
            else if (ExtraDeckView.hover)
                return DeckLocation.ExtraDeck;
            else if (SideDeckView.hover)
                return DeckLocation.SideDeck;
            return DeckLocation.All;
        }

        protected Deck FromObjectDeckToCodedDeck()
        {
            SortCards();
            Deck deck = new();
            foreach (var card in cards)
            {
                if (card.location == DeckLocation.MainDeck)
                    deck.Main.Add(card.Data.Id);
                else if (card.location == DeckLocation.ExtraDeck)
                    deck.Extra.Add(card.Data.Id);
                else if (card.location == DeckLocation.SideDeck)
                    deck.Side.Add(card.Data.Id);
            }
            foreach (var pickUp in this.deck.Pickup)
                deck.Pickup.Add(pickUp);
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

        protected void DeckFileSave()
        {
            try
            {
                var deckName = GetDeckName();
                deck.Save(deckName, DateTime.Now);
                if (deckName != this.deckName)
                    File.Delete(Program.deckPath + this.deckName + Program.ydkExpansion);
                this.deckName = deckName;
                MessageManager.Toast(InterString.Get("本地卡组「[?]」已保存。", deckName));
                needSave = false;
            }
            catch (Exception e)
            {
                MessageManager.Toast(InterString.Get("保存失败！"));
                MessageManager.Cast(e.Message);
            }
        }

        #endregion

    }
}
