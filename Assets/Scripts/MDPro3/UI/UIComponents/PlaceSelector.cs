using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using static MDPro3.GameCard;

namespace MDPro3.UI
{
    public class PlaceSelector : MonoBehaviour
    {
        public GPS p;

        public List<DuelButtonInfo> buttons = new List<DuelButtonInfo>();
        public List<DuelButton> buttonObjs = new List<DuelButton>();

        DuelButton selectButton;

        GameObject highlight;
        GameObject select;
        GameObject selectPush;
        GameObject selectCard;
        GameObject selectCardPush;
        GameObject disable;
        public GameCard cookieCard;

        bool hover;
        bool selecting;
        bool selected;

        public bool cardSelecting;
        public bool cardSelected;
        bool cardPreselected;
        bool cardUnselectable;

        private void Start()
        {
            var collider = gameObject.AddComponent<BoxCollider>();
            if ((p.location & (uint)CardLocation.Deck) > 0)
            {
                highlight = ABLoader.LoadFromFile("MasterDuel/Effects/eff_highlight/eff_duel_highlight10", true);
                transform.localEulerAngles = new Vector3(0, -19.5f, 0);
                collider.size = new Vector3(8f, 1f, 10f);
            }
            else if ((p.location & (uint)CardLocation.Extra) > 0)
            {
                highlight = ABLoader.LoadFromFile("MasterDuel/Effects/eff_highlight/eff_duel_highlight10", true);
                transform.localEulerAngles = new Vector3(0, 19.5f, 0);
                collider.size = new Vector3(8f, 1f, 10f);
            }
            else if ((p.location & (uint)CardLocation.MonsterZone) > 0)
            {
                highlight = ABLoader.LoadFromFile("MasterDuel/Effects/eff_highlight/eff_duel_highlight11", true);
                collider.size = new Vector3(8f, 1f, 8f);
                select = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_mst_001", true);
                selectPush = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_mst_push_001", true);
                selectCard = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_001", true);
                selectCardPush = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_push_001", true);
                disable = new GameObject("Disable");
                CreateSelectButton();
            }
            else if ((p.location & (uint)CardLocation.SpellZone) > 0)
            {
                if (p.sequence == 5)
                {
                    highlight = ABLoader.LoadFromFile("MasterDuel/Effects/eff_highlight/eff_duel_highlight13", true);
                    collider.size = new Vector3(6f, 1f, 7f);
                    select = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_001", true);
                    selectPush = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_push_001", true);
                    selectCard = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_001", true);
                    selectCardPush = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_push_001", true);
                    select.transform.localScale = Vector3.one * 0.8f;
                    selectPush.transform.localScale = Vector3.one * 0.8f;
                }
                else
                {
                    highlight = ABLoader.LoadFromFile("MasterDuel/Effects/eff_highlight/eff_duel_highlight12", true);
                    collider.size = new Vector3(8f, 1f, 7f);
                    select = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_trpmgc_001", true);
                    selectPush = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_trpmgc_push_001", true);
                    selectCard = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_001", true);
                    selectCardPush = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_select/fxp_hl_select_card_push_001", true);
                }
                selectCard.transform.localScale = Vector3.one * 0.8f;
                selectCardPush.transform.localScale = Vector3.one * 0.8f;
                disable = new GameObject("Disable");
                CreateSelectButton();
            }

            highlight.transform.SetParent(transform, false);
            transform.localPosition = GetCardPosition(p);
            if (select != null)
            {
                select.transform.SetParent(transform, false);
                selectPush.transform.SetParent(transform, false);
                selectCard.transform.SetParent(transform, false);
                selectCardPush.transform.SetParent(transform, false);
                var main = select.GetComponent<ParticleSystem>().main;
                main.playOnAwake = true;
                main = selectPush.GetComponent<ParticleSystem>().main;
                main.playOnAwake = true;
                main = selectCard.GetComponent<ParticleSystem>().main;
                main.playOnAwake = true;
                main = selectCardPush.GetComponent<ParticleSystem>().main;
                main.playOnAwake = true;
                select.SetActive(false);
                selectPush.SetActive(false);
                selectCard.SetActive(false);
                selectCardPush.SetActive(false);
            }
            if (disable != null)
            {
                disable.transform.SetParent(transform, false);
                disable.transform.localEulerAngles = new Vector3(90, 0, 0);
                disable.transform.localScale = new Vector3(3, 3, 1);
                var spriteRenderer = disable.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = TextureManager.container.CardAffectDisable;
                disable.SetActive(false);
            }
        }

        bool countShowing;

        private void Update()
        {
            hover = false;
            if (UserInput.HoverObject == gameObject)
                hover = true;

            if (hover)
            {
                highlight.SetActive(true);
                if (UserInput.MouseLeftDown)
                    OnClick();
                if ((p.location & (uint)CardLocation.Onfield) == 0 && !countShowing)
                {
                    countShowing = true;
                    Program.instance.ocgcore.ShowLocationCount(p);
                }
            }
            else
            {
                highlight.SetActive(false);
                if (UserInput.MouseLeftDown)
                    HideButtons();
                if (countShowing)
                {
                    countShowing = false;
                    Program.instance.ocgcore.HidePlaceCount();
                }
            }

            if (UserInput.HoverObject == gameObject)
                highlight.SetActive(true);
            else
                highlight.SetActive(false);
        }



        void OnClick()
        {
            if (selecting)
            {
                AudioManager.PlaySE("SE_DUEL_SELECT");
                if (!selected)
                {
                    selected = true;
                    select.SetActive(false);
                    selectPush.SetActive(false);
                    selectPush.SetActive(true);
                }
                else
                {
                    selected = false;
                    select.SetActive(true);
                }
                var selectedCount = 0;
                foreach(var place in Program.instance.ocgcore.places)
                    if(place.selected)
                        selectedCount++;
                if (selectedCount == Program.instance.ocgcore.ES_min)
                {
                    var binaryMaster = new BinaryMaster();
                    foreach (var place in Program.instance.ocgcore.places)
                        if (place.selected)
                        {
                            var response = new byte[3];
                            response[0] = Program.instance.ocgcore.isFirst ? (byte)place.p.controller : (byte)(1 - place.p.controller);
                            response[1] = (byte)place.p.location;
                            response[2] = (byte)place.p.sequence;
                            binaryMaster.writer.Write(response);
                        }
                    Program.instance.ocgcore.SendReturn(binaryMaster.Get());
                }
            }
            else if (cardSelecting)
            {
                AudioManager.PlaySE("SE_DUEL_SELECT");
                if (Program.instance.ocgcore.currentMessage == GameMessage.SelectCounter)
                {
                    if (!cardUnselectable)
                        selectButton.Show();
                }
                else if (!cardSelected && !cardUnselectable && !cardPreselected)
                    selectButton.Show();
                else if (cardSelected && !cardUnselectable && !cardPreselected)
                    UnselectCardInThisZone();
                var card = FindCardInThisPlace();
                if (card != null)
                    card.OnClick();
            }
            else
            {
                if ((p.location & (uint)CardLocation.Onfield) > 0)
                {
                    var card = FindCardInThisPlace();
                    if (card != null)
                        card.OnClick();
                    else
                    {
                        Program.instance.ocgcore.description.Hide();
                        Program.instance.ocgcore.list.Hide();
                    }
                    foreach (var c in Program.instance.ocgcore.cards)
                        if (c != card)
                            c.NotClickThis();
                }
                else
                {
                    AudioManager.PlaySE("SE_DUEL_SELECT");
                    List<GameCard> cards = new List<GameCard>();
                    foreach (var card in Program.instance.ocgcore.cards)
                        if ((card.p.location & p.location) > 0)
                            if (card.p.controller == p.controller)
                                cards.Add(card);
                    Program.instance.ocgcore.list.Show(cards, (CardLocation)p.location, (int)p.controller);

                    if (!buttonsCreated)
                    {
                        bool spsummmon = false;
                        bool activate = false;
                        foreach (var card in Program.instance.ocgcore.cards)
                            if ((card.p.location & p.location) > 0)
                                if (card.p.controller == p.controller)
                                    foreach (var btn in card.buttons)
                                    {
                                        if (btn.type == ButtonType.Activate)
                                            activate = true;
                                        if (btn.type == ButtonType.SpSummon)
                                            spsummmon = true;
                                    }
                        if (activate)
                        {
                            int response = -1;
                            buttons.Add(new DuelButtonInfo() { response = new List<int>() { response }, hint = InterString.Get("发动效果"), type = ButtonType.Activate });
                        }
                        if (spsummmon)
                        {
                            int response = -2;
                            buttons.Add(new DuelButtonInfo() { response = new List<int>() { response }, hint = InterString.Get("特殊召唤"), type = ButtonType.SpSummon });
                        }
                        CreateButtons();
                    }
                    else
                    {
                        if (Program.instance.ocgcore.returnAction == null)
                            ShowButtons();
                    }
                }
            }
        }

        bool buttonsCreated = false;
        void CreateButtons()
        {
            if (buttonsCreated || Program.instance.ocgcore.returnAction != null || buttons.Count == 0)
                return;

            for (int i = 0; i < buttons.Count; i++)
            {
                var obj = Instantiate(Program.instance.ocgcore.container.duelButton);
                var mono = obj.GetComponent<DuelButton>();
                buttonObjs.Add(mono);
                mono.response = buttons[i].response;
                mono.hint = buttons[i].hint;
                mono.type = buttons[i].type;
                mono.id = i;
                mono.buttonsCount = buttons.Count;
                mono.cookieCard = null;
                mono.location = p.location;
                mono.controller = p.controller;
                mono.Show();
            }
            buttonsCreated = true;
        }

        void CreateSelectButton()
        {
            var obj = Instantiate(Program.instance.ocgcore.container.duelButton);
            selectButton = obj.GetComponent<DuelButton>();
            selectButton.response.Add(-3);
            selectButton.hint = "";
            selectButton.type = ButtonType.Select;
            selectButton.id = 0;
            selectButton.buttonsCount = 1;
            selectButton.cookieCard = null;
            selectButton.location = p.location;
            selectButton.controller = p.controller;
            selectButton.sequence = p.sequence;
            selectButton.Hide();
        }


        public void ShowButtons()
        {
            foreach (var button in buttonObjs)
                button.Show();
        }

        public void HideButtons()
        {
            foreach (var button in buttonObjs)
                button.Hide();
            if (selectButton != null)
                selectButton.Hide();
        }

        public void ClearButtons()
        {
            foreach (var go in buttonObjs)
                Destroy(go.gameObject);
            buttonObjs.Clear();
            buttons.Clear();
            buttonsCreated = false;
        }


        public void StopResponse()
        {
            if (selecting)
            {
                selecting = false;
                select.SetActive(false);
                if (selected)
                {
                    selectPush.SetActive(false);
                    selectPush.SetActive(true);
                    selected = false;
                }
            }
            if (cardSelecting)
            {
                cardSelecting = false;
                cardSelected = false;
                selectCard.SetActive(false);
                cookieCard = null;
                cardUnselectable = false;
                cardPreselected = false;
            }
        }

        public void InitializeSelectCardInThisZone(List<GameCard> cards)
        {
            foreach (var card in cards)
            {
                if (card.p.controller == p.controller)
                {
                    if (card.p.location == p.location)
                        if (card.p.sequence == p.sequence)
                        {
                            cardSelecting = true;
                            cookieCard = card;
                            ShowSelectCardHighlight();
                            break;
                        }
                }
                else
                {
                    if ((p.location & (uint)CardLocation.MonsterZone) > 0
                        && p.sequence == 5
                        && card.p.controller == 1
                        && (card.p.location & (uint)CardLocation.MonsterZone) > 0
                        && card.p.sequence == 6
                        )
                    {
                        cardSelecting = true;
                        cookieCard = card;
                        ShowSelectCardHighlight();
                        break;
                    }
                    if ((p.location & (uint)CardLocation.MonsterZone) > 0
                        && p.sequence == 6
                        && card.p.controller == 1
                        && (card.p.location & (uint)CardLocation.MonsterZone) > 0
                        && card.p.sequence == 5
                        )
                    {
                        cardSelecting = true;
                        cookieCard = card;
                        ShowSelectCardHighlight();
                        break;
                    }
                }
            }
            if (cardSelecting && Program.instance.ocgcore.currentMessage == GameMessage.SelectSum)
            {
                if (Program.instance.ocgcore.cardsMustBeSelected.Contains(cookieCard))
                {
                    cardPreselected = true;
                    cardSelected = true;
                    selectCard.SetActive(false);
                }
            }
        }

        public void SelectCardInThisZone()
        {
            cardSelected = true;

            if (Program.instance.ocgcore.currentMessage != GameMessage.SelectCounter)
                selectCard.SetActive(false);
            selectCardPush.SetActive(false);
            selectCardPush.SetActive(true);
            Program.instance.ocgcore.FieldSelectRefresh(cookieCard);
        }

        public void UnselectCardInThisZone()
        {
            if (Program.instance.ocgcore.currentMessage == GameMessage.SelectCounter)
                return;
            cardSelected = false;
            Program.instance.ocgcore.FieldSelectRefresh(cookieCard);
        }

        public void CardInThisZoneSelectable()
        {
            cardUnselectable = false;
            selectCard.SetActive(true);
        }

        public void CardInThisZoneUnselectable()
        {
            cardUnselectable = true;
            selectCard.SetActive(false);
        }

        public void HighlightThisZone(uint place, int min, bool needConfirm = false)
        {
            for (var i = 0; i < min; i++)
            {
                uint passController;
                if (p.controller == 0)
                    passController = place & 0xFFFF;
                else
                    passController = place >> 16;

                if ((passController & 0x7F) > 0)
                {
                    if ((p.location & (uint)CardLocation.MonsterZone) > 0)
                    {
                        var filter = passController & 0x7F;
                        if ((filter & (1u << (int)p.sequence)) > 0)
                        {
                            ShowSelectZoneHighlight();
                            selecting = true;
                        }
                    }
                }
                if ((passController & 0x3F00) > 0)
                {
                    if ((p.location & (uint)CardLocation.SpellZone) > 0)
                    {
                        var filter = passController >> 8;
                        if ((filter & (1u << (int)p.sequence)) > 0)
                        {
                            ShowSelectZoneHighlight();
                            selecting = true;
                        }
                    }
                }
            }
        }

        public void ShowSelectZoneHighlight()
        {
            select.SetActive(true);
        }
        public void ShowSelectCardHighlight()
        {
            selectCard.SetActive(true);
            if ((cookieCard.p.position & (uint)CardPosition.Attack) > 0)
            {
                selectCard.transform.localEulerAngles = Vector3.zero;
                selectCardPush.transform.localEulerAngles = Vector3.zero;
            }
            else
            {
                selectCard.transform.localEulerAngles = new Vector3(0, 90, 0);
                selectCardPush.transform.localEulerAngles = new Vector3(0, 90, 0);
            }

        }

        public GameCard FindCardInThisPlace()
        {
            if ((p.location & (uint)CardLocation.MonsterZone) > 0 && p.sequence == 5)
                foreach (var card in Program.instance.ocgcore.cards)
                {
                    if ((card.p.location & (uint)CardLocation.MonsterZone) > 0)
                    {
                        if (card.p.controller == 0 && card.p.sequence == 5
                            && (card.p.location & (uint)CardLocation.Overlay) == 0)
                            return card;
                        if (card.p.controller == 1 && card.p.sequence == 6
                            && (card.p.location & (uint)CardLocation.Overlay) == 0)
                            return card;
                    }
                }
            else if ((p.location & (uint)CardLocation.MonsterZone) > 0 && p.sequence == 6)
                foreach (var card in Program.instance.ocgcore.cards)
                {
                    if ((card.p.location & (uint)CardLocation.MonsterZone) > 0)
                    {
                        if (card.p.controller == 0 && card.p.sequence == 6
                            && (card.p.location & (uint)CardLocation.Overlay) == 0)
                            return card;
                        if (card.p.controller == 1 && card.p.sequence == 5
                            && (card.p.location & (uint)CardLocation.Overlay) == 0)
                            return card;
                    }
                }
            else
                foreach (var card in Program.instance.ocgcore.cards)
                    if (p.controller == card.p.controller)
                        if ((card.p.location & (uint)CardLocation.Overlay) == 0)
                            if (p.location == card.p.location)
                                if (p.sequence == card.p.sequence)
                                    return card;

            return null;
        }

        GameObject hintObj;
        public void ShowHint(uint location, uint controller)
        {
            if ((location & p.location) > 0 && controller == p.controller)
            {
                hintObj = ABLoader.LoadFromFile("MasterDuel/Effects/hitghlight/fxp_hl_exdeck_001", true);
                hintObj.transform.SetParent(transform, false);
                int cardCount = Program.instance.ocgcore.GetLocationCardCount((CardLocation)location, controller);
                hintObj.transform.localScale = new Vector3(1.1f, cardCount * 0.1f, 1.1f);
            }
        }

        public void HideHint()
        {
            if (hintObj != null)
                Destroy(hintObj);
        }

        public void SetDisabled(uint filter)
        {
            if ((p.location & (uint)CardLocation.Onfield) == 0)
                return;

            if (p.location == (uint)CardLocation.MonsterZone && (p.sequence == 5 || p.sequence == 6))
                return;

            int order = 0;
            if (p.controller != 0 && Program.instance.ocgcore.isFirst
                || p.controller == 0 && !Program.instance.ocgcore.isFirst)
                order += 16;

            if (p.location == (uint)CardLocation.SpellZone)
                order += 8;
            order += (int)p.sequence;
            if ((filter & (1 << order)) > 0)
                disable.SetActive(true);
            else
                disable.SetActive(false);
        }

        public bool InTheSameLine(GPS gps)
        {
            if ((gps.location & ((uint)CardLocation.Deck + (uint)CardLocation.Extra)) > 0)
                return false;
            if ((p.location & ((uint)CardLocation.Deck + (uint)CardLocation.Extra)) > 0)
                return false;

            if ((p.sequence == gps.sequence) && (p.controller == gps.controller))
                return true;
            if ((p.sequence == (4 - gps.sequence)) && (p.controller != gps.controller))
                return true;

            return false;
        }
    }
}
