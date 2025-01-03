using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.YGOSharp.OCGWrapper.Enums;

namespace MDPro3.UI
{
    public enum ButtonType
    {
        Select,
        Decide,
        Cancel,
        Activate,
        SetPendulum,
        Battle,
        ToAttackPosition,
        ToDefensePosition,
        SpSummon,
        Summon,
        PenSummon,
        SetSpell,
        SetMonster,
    }

    public class DuelButton : MonoBehaviour
    {
        public GameCard cookieCard;
        public List<int> response = new List<int>();
        // response -1 for bg buttons activate
        // response -2 for bg buttons spsummon
        public string hint;
        public ButtonType type;
        public int id;
        public int buttonsCount;

        //for bg Buttons
        public uint location;
        public uint controller;
        //for select Button
        public uint sequence;

        public TextMeshProUGUI text;
        public GameObject bg;
        static float transitionTime = 0.1f;
        bool showing;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(OnClick);
            transform.SetParent(Program.instance.ui_.duelButton, false);
            RefreshPosition();
            text.text = hint;
            if(hint == string.Empty)
                bg.SetActive(false);
            transform.localScale = Vector3.zero;
            StartCoroutine(RefreshIcons());
        }

        IEnumerator RefreshIcons()
        {
            while (TextureManager.container == null)
                yield return null;
            var spriteState = new SpriteState();
            switch (type)
            {
                case ButtonType.Select:
                    GetComponent<Image>().sprite = TextureManager.container.select[0];
                    spriteState.highlightedSprite = TextureManager.container.select[1];
                    spriteState.pressedSprite = TextureManager.container.select[2];
                    spriteState.disabledSprite = TextureManager.container.select[3];
                    break;
                case ButtonType.Decide:
                    GetComponent<Image>().sprite = TextureManager.container.decide[0];
                    spriteState.highlightedSprite = TextureManager.container.decide[1];
                    spriteState.pressedSprite = TextureManager.container.decide[2];
                    spriteState.disabledSprite = TextureManager.container.decide[3];
                    break;
                case ButtonType.Cancel:
                    GetComponent<Image>().sprite = TextureManager.container.cancel[0];
                    spriteState.highlightedSprite = TextureManager.container.cancel[1];
                    spriteState.pressedSprite = TextureManager.container.cancel[2];
                    spriteState.disabledSprite = TextureManager.container.cancel[3];
                    break;
                case ButtonType.Activate:
                    GetComponent<Image>().sprite = TextureManager.container.activate[0];
                    spriteState.highlightedSprite = TextureManager.container.activate[1];
                    spriteState.pressedSprite = TextureManager.container.activate[2];
                    spriteState.disabledSprite = TextureManager.container.activate[3];
                    break;
                case ButtonType.Battle:
                    GetComponent<Image>().sprite = TextureManager.container.battle[0];
                    spriteState.highlightedSprite = TextureManager.container.battle[1];
                    spriteState.pressedSprite = TextureManager.container.battle[2];
                    spriteState.disabledSprite = TextureManager.container.battle[3];
                    break;
                case ButtonType.ToAttackPosition:
                    GetComponent<Image>().sprite = TextureManager.container.toAttack[0];
                    spriteState.highlightedSprite = TextureManager.container.toAttack[1];
                    spriteState.pressedSprite = TextureManager.container.toAttack[2];
                    spriteState.disabledSprite = TextureManager.container.toAttack[3];
                    break;
                case ButtonType.ToDefensePosition:
                    GetComponent<Image>().sprite = TextureManager.container.toDefense[0];
                    spriteState.highlightedSprite = TextureManager.container.toDefense[1];
                    spriteState.pressedSprite = TextureManager.container.toDefense[2];
                    spriteState.disabledSprite = TextureManager.container.toDefense[3];
                    break;
                case ButtonType.SpSummon:
                    GetComponent<Image>().sprite = TextureManager.container.spSummon[0];
                    spriteState.highlightedSprite = TextureManager.container.spSummon[1];
                    spriteState.pressedSprite = TextureManager.container.spSummon[2];
                    spriteState.disabledSprite = TextureManager.container.spSummon[3];
                    break;
                case ButtonType.Summon:
                    GetComponent<Image>().sprite = TextureManager.container.summon[0];
                    spriteState.highlightedSprite = TextureManager.container.summon[1];
                    spriteState.pressedSprite = TextureManager.container.summon[2];
                    spriteState.disabledSprite = TextureManager.container.summon[3];
                    break;
                case ButtonType.PenSummon:
                    GetComponent<Image>().sprite = TextureManager.container.penSummon[0];
                    spriteState.highlightedSprite = TextureManager.container.penSummon[1];
                    spriteState.pressedSprite = TextureManager.container.penSummon[2];
                    spriteState.disabledSprite = TextureManager.container.penSummon[3];
                    break;
                case ButtonType.SetSpell:
                    GetComponent<Image>().sprite = TextureManager.container.setSpell[0];
                    spriteState.highlightedSprite = TextureManager.container.setSpell[1];
                    spriteState.pressedSprite = TextureManager.container.setSpell[2];
                    spriteState.disabledSprite = TextureManager.container.setSpell[3];
                    break;
                case ButtonType.SetMonster:
                    GetComponent<Image>().sprite = TextureManager.container.setMonster[0];
                    spriteState.highlightedSprite = TextureManager.container.setMonster[1];
                    spriteState.pressedSprite = TextureManager.container.setMonster[2];
                    spriteState.disabledSprite = TextureManager.container.setMonster[3];
                    break;
                case ButtonType.SetPendulum:
                    GetComponent<Image>().sprite = TextureManager.container.setPendulum[0];
                    spriteState.highlightedSprite = TextureManager.container.setPendulum[1];
                    spriteState.pressedSprite = TextureManager.container.setPendulum[2];
                    spriteState.disabledSprite = TextureManager.container.setPendulum[3];
                    break;
            }
            GetComponent<Button>().spriteState = spriteState;
        }

        void RefreshPosition()
        {
            if (response[0] == -4)
            {
                var middle = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta.x / 2;
                GetComponent<RectTransform>().anchoredPosition = new Vector2(middle + 340, 620);
            }
            else if (response[0] == -5)
            {
                var middle = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta.x / 2;
                GetComponent<RectTransform>().anchoredPosition = new Vector2(middle - 340, 620);
            }
            else
            {
                Vector2 uiPoint;
                float height = 130f;
                if (cookieCard == null || cookieCard.model == null)
                {
                    var gps = new GPS();
                    gps.location = location;
                    gps.controller = controller;
                    gps.sequence = sequence;
                    var position = GameCard.GetCardPosition(gps);
                    uiPoint = UIManager.WorldToScreenPoint(Program.instance.camera_.cameraMain, position);
                    if ((location & ((uint)CardLocation.Deck + (uint)CardLocation.Extra)) > 0
                        && controller != 0)
                        height = -100;
                }
                else
                {
                    uiPoint = UIManager.WorldToScreenPoint(Program.instance.camera_.cameraMain, cookieCard.model.transform.position);
                    if (cookieCard != null)
                    {
                        if((cookieCard.p.location & (uint)CardLocation.Hand) > 0)
                        {
                            if(cookieCard.p.controller == 0)
                                height = 250f;
                            else
                                height = -200;
                        }
                    }
                }
                GetComponent<RectTransform>().anchoredPosition = new Vector2(uiPoint.x - (buttonsCount - 1) * 80 + id * 160, uiPoint.y + height);
            }
        }

        public void Show()
        {
            RefreshPosition();
            if (showing) return;
            showing = true;
            transform.DOScale(1, transitionTime);
        }
        public void Hide()
        {
            if (!showing) return;
            showing = false;
            transform.DOScale(0, transitionTime);
        }

        void OnClick()
        {
            AudioManager.PlaySE("SE_DUEL_DECIDE");

            if (response[0] >= 0)
            {
                switch (Program.instance.ocgcore.currentMessage)
                {
                    case GameMessage.SelectBattleCmd:
                    case GameMessage.SelectIdleCmd:
                        if (response.Count == 1 || type != ButtonType.Activate)
                        {
                            var p = new BinaryMaster();
                            p.writer.Write(response[0]);
                            Program.instance.ocgcore.SendReturn(p.Get());
                        }
                        else
                        {
                            var selections = new List<string>() { InterString.Get("效果选择") };
                            var responses = new List<int> { };
                            for (var i = 0; i < cookieCard.effects.Count; i++)
                            {
                                var desc = cookieCard.effects[i].desc;
                                if (desc.Length <= 2)
                                    desc = InterString.Get("发动效果");
                                selections.Add(desc);
                                responses.Add(cookieCard.effects[i].ptr);
                            }
                            selections.Add(InterString.Get("放弃"));
                            responses.Add(-233);
                            Program.instance.ocgcore.ShowPopupSelection(selections, responses);
                        }
                        break;
                }
            }
            else if (response[0] == -1 || response[0] == -2)
            {
                List<GameCard> responseCards = new List<GameCard>();
                foreach (var card in Program.instance.ocgcore.cards)
                    if (card.p.controller == controller)
                        if ((card.p.location & location) > 0)
                            foreach (var btn in card.buttons)
                                if (btn.type == type)
                                {
                                    responseCards.Add(card);
                                    break;
                                }
                if (type == ButtonType.Activate)
                    Program.instance.ocgcore.ShowPopupSelectCard(InterString.Get("选择效果发动。"), responseCards, 1, 1, true, false);
                else
                    Program.instance.ocgcore.ShowPopupSelectCard(InterString.Get("选择怪兽特殊召唤。"), responseCards, 1, 1, true, false);
            }
            else if (response[0] == -3)
            {
                foreach (var place in Program.instance.ocgcore.places)
                {
                    if (place.p.controller == controller)
                        if (place.p.location == location)
                            if (place.p.sequence == sequence)
                                place.SelectCardInThisZone();
                }
            }
            else if (response[0] == -4)
            {
                Program.instance.ocgcore.FieldSelectedSend();
            }
            else if (response[0] == -5)
            {
                Program.instance.ocgcore.FieldSelectedCancel();
            }
        }
    }
}

