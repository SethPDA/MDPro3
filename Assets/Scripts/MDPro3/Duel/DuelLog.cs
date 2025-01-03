using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;

namespace MDPro3.Duel
{
    public class DuelLog : MonoBehaviour
    {
        #region Mono

        public static Color myColor = Color.blue;
        public static Color opColor = Color.red;
        public static Color myArrowColor = new Color(0f, 0.5f, 1f, 1f);
        public static Color opArrowColor = new Color(1f, 0.2f, 0.2f, 1f);
        public static Color myChainColor = new Color(0.2f, 0.6f, 1f, 1f);
        public static Color opChainColor = new Color(1f, 0.2f, 0.2f, 1f);
        public static Color damageColor = Color.red;
        public static Color recoverColor = new Color(0, 0.7f, 1f, 1f);

        public RectTransform baseRect;
        public ScrollRect scrollRect;
        public bool showing;
        bool draged = false;

        private void Start()
        {
            scrollRect.verticalScrollbar.onValueChanged.AddListener(Refresh);
            scrollRect.GetComponent<DoWhenOnDrag>().action = () => { draged = true; };
        }

        public void Show()
        {
            showing = true;
            AudioManager.PlaySE("SE_LOG_OPEN");
            baseRect.DOAnchorPosX(-20f, 0.2f);
            baseRect.localScale = Vector3.one * Config.GetUIScale(1.15f);
        }

        public void Hide(bool silent = false)
        {
            showing = false;
            draged = false;
            baseRect.DOAnchorPosX(400f * Config.GetUIScale(1.15f), 0.2f);

            if (!silent)
                AudioManager.PlaySE("SE_LOG_CLOSE");
        }

        float fullHeight;
        public void AddLog(GameObject item, bool indent = false)
        {
            var rect = item.GetComponent<RectTransform>();
            var height = rect.rect.height;
            rect.SetParent(scrollRect.content, false);
            rect.sizeDelta = new Vector2(0, height);
            rect.anchoredPosition = new Vector2(0, -fullHeight);
            fullHeight += height;
            scrollRect.content.sizeDelta = new Vector2(0, fullHeight);

            if (indent || chainSolving > 0 && rect.GetChild(1).name == "Image Side")
            {
                rect.GetChild(0).gameObject.SetActive(false);
                rect.GetChild(1).gameObject.SetActive(false);
                rect.offsetMin = new Vector2(50f, rect.offsetMin.y);
                rect.offsetMax = new Vector2(0f, rect.offsetMax.y);
            }
            if (!showing && fullHeight > scrollRect.viewport.rect.height)
                item.SetActive(false);
            if (!draged)
                scrollRect.verticalScrollbar.value = 0f;
        }

        public void ClearLog()
        {
            scrollRect.content.DestroyAllChildren();
            fullHeight = 0;
        }

        void Refresh(float value)
        {
            if (!showing)
                return;
            var visibleRect = GetVisibleRect();
            int stage = 0;
            bool visible = false;
            if (value > 0.5f)
            {
                for (int i = 0; i < scrollRect.content.childCount; i++)
                {
                    var childRect = scrollRect.content.GetChild(i) as RectTransform;
                    if (stage < 2)
                    {
                        var isVisible = IsRectVisible(childRect, visibleRect);
                        if (visible != isVisible)
                        {
                            visible = isVisible;
                            stage++;
                        }
                        childRect.gameObject.SetActive(isVisible);
                    }
                    else
                        childRect.gameObject.SetActive(false);
                }
            }
            else
            {
                for (int i = scrollRect.content.childCount - 1; i >= 0; i--)
                {
                    var childRect = scrollRect.content.GetChild(i) as RectTransform;
                    if (stage < 2)
                    {
                        var isVisible = IsRectVisible(childRect, visibleRect);
                        if (visible != isVisible)
                        {
                            visible = isVisible;
                            stage++;
                        }
                        childRect.gameObject.SetActive(isVisible);
                    }
                    else
                        childRect.gameObject.SetActive(false);
                }
            }
        }

        Rect GetVisibleRect()
        {
            Rect viewportRect = scrollRect.viewport.rect;

            float top = -scrollRect.content.anchoredPosition.y;
            float bottom = top - viewportRect.height;

            Rect visibleRect = new Rect(0f, bottom, viewportRect.width, viewportRect.height);
            return visibleRect;
        }

        bool IsRectVisible(RectTransform rectTransform, Rect visibleRect)
        {
            float top = rectTransform.anchoredPosition.y;
            float bottom = top - rectTransform.rect.height;
            return top > visibleRect.yMin && bottom < visibleRect.yMax;
        }

        #endregion


        #region Message

        public int chainSolving;
        public uint lastMoveReason;
        public uint lastSpSummonReason;
        public bool psum;
        public int cacheLp;

        public void LogMessage(Package p)
        {
            var core = Program.instance.ocgcore;

            var r = p.Data.reader;
            r.BaseStream.Seek(0, 0);
            var player = 0;
            var code = 0;
            var code2 = 0;
            var count = 0;
            var value = 0;
            var type = 0;
            Card data;
            GameCard card;
            GPS gps;
            GPS from;
            GPS to;
            GameObject item;
            string textReason;
            Color targetColor;
            RawImage cardFace;
            switch ((GameMessage)p.Function)
            {
                #region SingleCard
                case GameMessage.Move:
                    code = r.ReadInt32();
                    from = r.ReadGPS();
                    to = r.ReadGPS();
                    if (code > 0)
                        data = CardsManager.Get(code);
                    else
                    {
                        card = core.GCS_Get(to);
                        if (card != null)
                            data = card.GetData();
                        else
                            data = CardsManager.Get(code);
                        code = data.Id;
                    }

                    lastMoveReason = r.ReadUInt32();
                    if (core.ignoreNextMoveLog)
                    {
                        core.ignoreNextMoveLog = false;
                        break;
                    }
                    if ((from.location & (uint)CardLocation.Hand) > 0
                        && (to.location & (uint)CardLocation.SpellZone) > 0
                        && (to.position & (uint)CardPosition.FaceUp) > 0
                        && !data.HasType(CardType.Monster))
                        break;
                    if ((from.location & (uint)CardLocation.Hand) > 0
                        && (to.location & (uint)CardLocation.SpellZone) > 0
                        && (to.position & (uint)CardPosition.FaceUp) > 0
                        && data.HasType(CardType.Pendulum)
                        && (to.sequence == 0 || to.sequence == 4 || to.sequence == 6 || to.sequence == 7))//TODO
                        break;
                    if ((from.location & (uint)CardLocation.SpellZone) > 0
                        && (to.location & (uint)CardLocation.SpellZone) == 0
                        && !data.HasType(CardType.Monster)
                        && (lastMoveReason & (uint)CardReason.RULE) > 0)
                        break;
                    if ((from.location & (uint)CardLocation.Overlay) > 0
                        && (to.location & (uint)CardLocation.Overlay) > 0)
                        break;
                    if ((from.location & (uint)CardLocation.Deck) > 0
                        && (to.location & (uint)CardLocation.Deck) > 0)
                        break;
                    if ((to.location & (uint)CardLocation.Onfield) > 0
                        && (to.position & (uint)CardPosition.FaceDown) > 0)
                        break;

                    bool indent = false;
                    if ((lastMoveReason & (uint)CardReason.COST) > 0)
                    {
                        textReason = InterString.Get("����");
                        indent = true;
                    }
                    else if ((lastMoveReason & (uint)CardReason.DESTROY) > 0)
                        textReason = InterString.Get("�ƻ�");
                    else if ((lastMoveReason & (uint)CardReason.RELEASE) > 0)
                        textReason = InterString.Get("���");
                    else if ((lastMoveReason & (uint)CardReason.BATTLE) > 0)
                        textReason = InterString.Get("ս���ƻ�");
                    else if ((lastMoveReason & (uint)CardReason.FLIP) > 0)
                        textReason = InterString.Get("��ת");
                    else if ((to.location & (uint)CardLocation.Hand) > 0)
                    {
                        textReason = InterString.Get("�ص�");
                        if ((from.location & ((uint)CardLocation.Deck + (uint)CardLocation.Extra)) > 0)
                            textReason = InterString.Get("����");
                        if ((from.location & ((uint)CardLocation.Grave + (uint)CardLocation.Removed)) > 0)
                            textReason = InterString.Get("����");
                    }
                    else if ((to.location & (uint)CardLocation.SpellZone) > 0
                        && (from.location & (uint)CardLocation.SpellZone) == 0
                        && (from.location & (uint)CardLocation.Hand) == 0)
                        textReason = InterString.Get("����");
                    else if ((from.location & (uint)CardLocation.SpellZone) > 0
                        && (to.location & (uint)CardLocation.SpellZone) > 0)
                        textReason = InterString.Get("�ƶ�");
                    else if ((from.location & (uint)CardLocation.MonsterZone) > 0
                        && (to.location & (uint)CardLocation.MonsterZone) > 0)
                        textReason = InterString.Get("�ƶ�");
                    else if ((to.location & (uint)CardLocation.MonsterZone) > 0
                        && (from.location & (uint)CardLocation.MonsterZone) == 0)
                        textReason = InterString.Get("�ص�");
                    else
                        textReason = InterString.Get("����");

                    if (!data.HasType(CardType.Token))
                        AddSingleCardMessageToLog(data.Id, from, to, textReason, indent);
                    else
                        AddSingleCardMessageToLog(data.Id, from, null, textReason, indent);
                    break;
                case GameMessage.Summoning:
                case GameMessage.SpSummoning:
                case GameMessage.FlipSummoning:
                    code = r.ReadInt32();
                    gps = r.ReadGPS();
                    card = core.GCS_Get(gps);
                    if (card == null)
                    {
                        Debug.LogError("Log Summoning: not find card.");
                        break;
                    }
                    core.lastConfirmedCard = card;
                    data = card.GetData();
                    if (core.currentMessage == GameMessage.Summoning)
                        textReason = InterString.Get("�ٻ�");
                    else if (core.currentMessage == GameMessage.SpSummoning)
                    {
                        if ((lastSpSummonReason & (uint)CardReason.Ritual) > 0)
                            textReason = InterString.Get("��ʽ�ٻ�");
                        else if ((lastSpSummonReason & (uint)CardReason.Fusion) > 0)
                            textReason = InterString.Get("�ں��ٻ�");
                        else if ((lastSpSummonReason & (uint)CardReason.Synchro) > 0)
                            textReason = InterString.Get("ͬ���ٻ�");
                        else if ((lastSpSummonReason & (uint)CardReason.Xyz) > 0)
                            textReason = InterString.Get("�����ٻ�");
                        else if ((lastSpSummonReason & (uint)CardReason.Link) > 0)
                            textReason = InterString.Get("�����ٻ�");
                        else if ((lastSpSummonReason & (uint)CardReason.Pendulum) > 0)
                            textReason = InterString.Get("����ٻ�");
                        else
                            textReason = InterString.Get("�����ٻ�");
                    }
                    else if (core.currentMessage == GameMessage.FlipSummoning)
                        textReason = InterString.Get("��ת�ٻ�");
                    else
                        textReason = InterString.Get("����");
                    if (!data.HasType(CardType.Token))
                        AddSingleCardMessageToLog(code, card.cacheP, gps, textReason);
                    else
                        AddSingleCardMessageToLog(code, gps, null, textReason);
                    break;
                case GameMessage.Set:
                    card = core.lastMoveCard;
                    if (card == null)
                    {
                        Debug.LogError("Log Set: not find card");
                        break;
                    }
                    textReason = InterString.Get("�Ƿ�");
                    AddSingleCardMessageToLog(card.GetData().Id, card.cacheP, card.p, textReason);
                    break;
                case GameMessage.Chaining:
                    code = r.ReadInt32();
                    gps = r.ReadGPS();
                    card = core.GCS_Get(gps);
                    data = card.GetData();

                    if (card == null)
                    {
                        Debug.LogError("Log Chaining: not find card");
                        break;
                    }
                    if (core.cardsInChain.Count > 1)
                    {
                        item = Instantiate(core.container.duelLogChaining);
                        item.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
                        {
                            core.description.Show(card, null);
                        });
                        item.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = core.cardsInChain.Count.ToString();
                        item.transform.GetChild(1).GetChild(0).GetComponent<Text>().color =
                            card.p.controller == 0 ? DuelLog.myChainColor : DuelLog.opChainColor;
                        item.transform.GetChild(2).GetComponent<Text>().text = InterString.Get("����");
                        StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(
                            item.transform.GetChild(3).GetComponent<RawImage>(), code));
                        AddLog(item);
                    }
                    textReason = InterString.Get("����");
                    if (card.cacheP != null && (card.cacheP.location & (uint)CardLocation.Hand) > 0
                        && (gps.location & (uint)CardLocation.SpellZone) > 0
                        && (gps.position & (uint)CardPosition.FaceUp) > 0
                        && data.HasType(CardType.Pendulum)
                        && (gps.sequence == 0 || gps.sequence == 4 || gps.sequence == 6 || gps.sequence == 7)
                        && card == core.lastMoveCard
                        && card != core.lastConfirmedCard)
                        textReason = InterString.Get("��ڷ���");
                    if (card == core.lastMoveCard
                        && card != core.lastConfirmedCard
                        && (gps.location & (uint)CardLocation.SpellZone) > 0
                        && (card.cacheP.location & (uint)CardLocation.Hand) > 0
                        )
                    {
                        core.lastConfirmedCard = card;
                        AddSingleCardMessageToLog(code, card.cacheP, gps, textReason);
                    }
                    else
                        AddSingleCardMessageToLog(code, gps, null, textReason);
                    break;
                case GameMessage.ChainNegated:
                case GameMessage.ChainDisabled:
                    card = core.cardsInChain[r.ReadByte() - 1];
                    if (card == null)
                    {
                        Debug.LogError("Log Negated: not find card");
                        break;
                    }
                    if (core.currentMessage == GameMessage.ChainDisabled)
                    {
                        textReason = InterString.Get("Ч����Ч");
                        if (card.negated)
                            break;
                    }
                    else
                        textReason = InterString.Get("������Ч");
                    AddSingleCardMessageToLog(card.GetData().Id, card.p, null, textReason);
                    break;
                case GameMessage.Draw:
                    player = core.LocalPlayer(r.ReadByte());
                    count = r.ReadByte();
                    gps = new GPS()
                    {
                        location = (uint)CardLocation.Hand,
                        controller = (uint)player
                    };
                    List<int> codes = new List<int>();
                    for (var i = 0; i < count; i++)
                    {
                        code = r.ReadInt32() & 0x7fffffff;
                        codes.Add(code);
                    }
                    bool allUnknown = true;
                    for (var i = 0; i < codes.Count; i++)
                        if (codes[i] != 0)
                        {
                            allUnknown = false;
                            break;
                        }

                    if (allUnknown)
                    {
                        code = 0;
                        textReason = InterString.Get("�鿨") + " x " + count;
                        AddSingleCardMessageToLog(code, gps, null, textReason);
                    }
                    else
                    {
                        for (var i = 0; i < count; i++)
                        {
                            code = codes[i];
                            textReason = InterString.Get("�鿨");
                            AddSingleCardMessageToLog(code, gps, null, textReason);
                        }
                    }

                    break;
                case GameMessage.RandomSelected:
                    player = core.LocalPlayer(r.ReadByte());
                    count = r.ReadByte();
                    item = Instantiate(core.cardsInChain.Count > 0 ? core.container.duelLogText2 : core.container.duelLogText);
                    item.transform.GetChild(1).GetComponent<Text>().text = InterString.Get("����");
                    AddLog(item);
                    for (int i = 0; i < count; i++)
                    {
                        var tempGPS = r.ReadGPS();
                        card = core.GCS_Get(tempGPS);
                        if (card == null)
                            continue;
                        AddSingleCardMessageToLog(card.GetData().Id, tempGPS, null, string.Empty, true);
                    }
                    break;
                case GameMessage.BecomeTarget:
                    if (core.cardsInChain.Count == 0
                        && core.cardsBeTarget.Count == 1
                        && core.cardsBeTarget[0].InPendulumZone())
                        break;
                    if (psum)
                        break;
                    count = r.ReadByte();
                    item = Instantiate(core.cardsInChain.Count > 0 ? core.container.duelLogText2 : core.container.duelLogText);
                    item.transform.GetChild(1).GetComponent<Text>().text = InterString.Get("����");
                    AddLog(item);
                    for (int i = 0; i < count; i++)
                    {
                        var tempGPS = r.ReadGPS();
                        card = core.GCS_Get(tempGPS);
                        if (card == null)
                            continue;
                        AddSingleCardMessageToLog(card.GetData().Id, tempGPS, null, string.Empty, true);
                    }
                    break;
                case GameMessage.AttackDisabled:
                    if (core.attackingCard == null)
                        break;
                    textReason = InterString.Get("��������Ч");
                    AddSingleCardMessageToLog(core.attackingCard.GetData().Id, core.attackingCard.p, null, textReason);
                    break;
                case GameMessage.ConfirmDecktop:
                    player = core.LocalPlayer(r.ReadByte());
                    count = r.ReadByte();
                    for (int i = 0; i < count; i++)
                    {
                        code = r.ReadInt32();
                        gps = r.ReadShortGPS();
                        textReason = InterString.Get("��������");
                        AddSingleCardMessageToLog(code, gps, null, textReason);
                    }
                    break;
                case GameMessage.ConfirmCards:
                    player = core.LocalPlayer(r.ReadByte());
                    count = r.ReadByte();
                    for (int i = 0; i < count; i++)
                    {
                        code = r.ReadInt32();
                        gps = r.ReadShortGPS();
                        textReason = InterString.Get("����");
                        if ((gps.location & (uint)CardLocation.Hand) > 0)
                            textReason = InterString.Get("�����ֿ�");
                        else if ((gps.location & (uint)CardLocation.Onfield) > 0)
                            textReason = InterString.Get("�����ǿ�");
                        AddSingleCardMessageToLog(code, gps, null, textReason);
                    }
                    break;
                case GameMessage.PosChange:
                    code = r.ReadInt32();
                    from = r.ReadGPS();

                    textReason = InterString.Get("���ı�ʾ��ʽ");
                    if ((from.location & (uint)CardLocation.SpellZone) > 0
                        && (from.position & (uint)CardPosition.FaceUp) > 0)
                        textReason = InterString.Get("�Ƿ�");
                    if ((from.location & (uint)CardLocation.SpellZone) > 0
                        && (from.position & (uint)CardPosition.FaceDown) > 0)
                        textReason = InterString.Get("�򿪸ǿ�");
                    to = from;
                    to.position = r.ReadByte();
                    if (code == 0)
                    {
                        card = core.GCS_Get(to);
                        if (card != null)
                        {
                            data = card.GetData();
                            code = data.Id;
                        }
                    }
                    AddSingleCardMessageToLog(code, to, null, textReason);
                    break;
                case GameMessage.Swap:
                    code = r.ReadInt32();
                    from = r.ReadGPS();
                    code2 = r.ReadInt32();
                    to = r.ReadGPS();
                    var from2 = new GPS
                    {
                        controller = from.controller,
                        location = from.location,
                        sequence = from.sequence,
                        position = to.position
                    };
                    var to2 = new GPS
                    {
                        controller = to.controller,
                        location = to.location,
                        sequence = to.sequence,
                        position = from.position
                    };
                    textReason = from.controller == from2.controller ? InterString.Get("�ƶ�") : InterString.Get("ת�ƿ���Ȩ"); ;
                    AddSingleCardMessageToLog(code, from, to2, textReason);
                    textReason = to.controller == to2.controller ? InterString.Get("�ƶ�") : InterString.Get("ת�ƿ���Ȩ"); ;
                    AddSingleCardMessageToLog(code2, to, from2, textReason);
                    break;

                #endregion

                #region LpChange
                case GameMessage.Damage:
                    player = core.LocalPlayer(r.ReadByte());
                    value = r.ReadInt32();
                    textReason = InterString.Get("�˺�");
                    AddLpPChangeMessageToLog(player, textReason, value);
                    break;
                case GameMessage.PayLpCost:
                    player = core.LocalPlayer(r.ReadByte());
                    value = r.ReadInt32();
                    textReason = InterString.Get("����");
                    AddLpPChangeMessageToLog(player, textReason, value, true, true);
                    break;
                case GameMessage.Recover:
                    player = core.LocalPlayer(r.ReadByte());
                    value = r.ReadInt32();
                    textReason = InterString.Get("�ظ�");
                    AddLpPChangeMessageToLog(player, textReason, value, false);
                    break;
                case GameMessage.LpUpdate:
                    player = core.LocalPlayer(r.ReadByte());
                    textReason = InterString.Get("�����ָı�");
                    AddLpPChangeMessageToLog(player, textReason, cacheLp > 0 ? cacheLp : -cacheLp, cacheLp < 0);
                    break;
                #endregion

                #region Done
                case GameMessage.ChainSolving:
                    chainSolving = r.ReadByte();
                    card = core.cardsInChain[chainSolving - 1];
                    item = Instantiate(core.container.duelLogChaining);
                    item.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
                    {
                        core.description.Show(card, null);
                    });
                    item.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = chainSolving.ToString();
                    item.transform.GetChild(1).GetChild(0).GetComponent<Text>().color =
                        card.p.controller == 0 ? DuelLog.myChainColor : DuelLog.opChainColor;
                    item.transform.GetChild(2).GetComponent<Text>().text = InterString.Get("Ч������");
                    StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(
                        item.transform.GetChild(3).GetComponent<RawImage>(), card.GetData().Id));
                    AddLog(item);
                    break;
                case GameMessage.ChainEnd:
                    item = Instantiate(core.container.duelLogChaining);
                    item.transform.GetChild(1).gameObject.SetActive(false);
                    item.transform.GetChild(3).gameObject.SetActive(false);
                    textReason = chainSolving > 1 ? InterString.Get("��������") : InterString.Get("�������");
                    item.transform.GetChild(2).GetComponent<Text>().text = textReason;
                    chainSolving = 0;
                    AddLog(item);
                    break;
                case GameMessage.Attack:
                    from = r.ReadGPS();
                    to = r.ReadGPS();
                    var attackCard = core.GCS_Get(from);
                    if (attackCard == null)
                    {
                        Debug.LogError("Log Attack: not find card.");
                        break;
                    }
                    item = Instantiate(core.container.duelLogAttack);
                    targetColor = from.controller == 0 ? DuelLog.myColor : DuelLog.opColor;
                    targetColor.a = 0.75f;
                    item.transform.GetChild(1).GetComponent<Image>().color = targetColor;
                    item.transform.GetChild(2).GetComponent<Text>().text = InterString.Get("����");
                    var cardFace1 = item.transform.GetChild(3).GetComponent<RawImage>();
                    code = attackCard.GetData().Id;
                    StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(cardFace1, code, true));
                    if ((from.position & (uint)CardPosition.Defence) > 0)
                        cardFace1.transform.localEulerAngles = new Vector3(0f, 0f, 90f);
                    cardFace1.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
                    {
                        core.description.Show(null, null, code, from);
                    });
                    var icons = TextureManager.container.GetLocationIcons(from);
                    item.transform.GetChild(4).GetComponent<Image>().sprite = icons[0];
                    targetColor = from.controller == 0 ? DuelLog.myArrowColor : DuelLog.opArrowColor;
                    item.transform.GetChild(5).GetComponent<Image>().color = targetColor;
                    var attackedCard = core.GCS_Get(to);
                    if (attackedCard == null)
                    {
                        item.transform.GetChild(6).gameObject.SetActive(false);
                        item.transform.GetChild(7).gameObject.SetActive(false);
                        item.transform.GetChild(8).GetComponent<Image>().material =
                            from.controller == 0 ? core.player1Frame.material : core.player0Frame.material;
                        item.transform.GetChild(8).GetComponent<Image>().sprite =
                            from.controller == 0 ? core.player1Frame.sprite : core.player0Frame.sprite;
                    }
                    else
                    {
                        item.transform.GetChild(8).gameObject.SetActive(false);
                        icons = TextureManager.container.GetLocationIcons(to);
                        item.transform.GetChild(6).GetComponent<Image>().sprite = icons[0];
                        var cardFace2 = item.transform.GetChild(7).GetComponent<RawImage>();
                        code2 = attackedCard.GetData().Id;
                        if (code2 > 0)
                            StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(cardFace2, code2, true));
                        else
                        {
                            cardFace2.texture = null;
                            cardFace2.material = from.controller == 0 ? core.opProtector : core.myProtector;
                            cardFace2.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        if ((to.position & (uint)CardPosition.Defence) > 0)
                            cardFace2.transform.localEulerAngles = new Vector3(0f, 0f, 90f);
                        if ((to.position & (uint)CardPosition.FaceUp) > 0)
                            cardFace2.transform.GetChild(0).gameObject.SetActive(false);
                        cardFace2.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
                        {
                            core.description.Show(null, null, code2, to);
                        });
                    }
                    AddLog(item);
                    break;
                case GameMessage.NewTurn:
                    item = Instantiate(core.container.duelLogNewTurn);
                    if (core.myTurn)
                        item.transform.GetChild(1).GetComponent<Image>().color = DuelLog.myColor;
                    else
                        item.transform.GetChild(1).GetComponent<Image>().color = DuelLog.opColor;
                    item.transform.GetChild(2).GetComponent<Text>().text = InterString.Get("��[?]�غ�", core.turns.ToString());
                    item.transform.GetChild(3).GetComponent<Image>().material = core.player0Frame.material;
                    item.transform.GetChild(4).GetComponent<Image>().material = core.player1Frame.material;
                    item.transform.GetChild(3).GetComponent<Image>().sprite = core.player0Frame.sprite;
                    item.transform.GetChild(4).GetComponent<Image>().sprite = core.player1Frame.sprite;
                    item.transform.GetChild(7).GetComponent<Text>().text = core.life0.ToString();
                    item.transform.GetChild(8).GetComponent<Text>().text = core.life1.ToString();
                    AddLog(item);
                    break;
                case GameMessage.NewPhase:
                    var ph = r.ReadUInt16();
                    var textPhase = string.Empty;
                    if (ph == 0x01)
                        textPhase = InterString.Get("�鿨�׶�");
                    else if (ph == 0x02)
                        textPhase = InterString.Get("׼���׶�");
                    else if (ph == 0x04)
                        textPhase = InterString.Get("��Ҫ�׶�1");
                    else if (ph == 0x08)
                        textPhase = InterString.Get("ս���׶�");
                    else if (ph == 0x100)
                        textPhase = InterString.Get("��Ҫ�׶�2");
                    else if (ph == 0x200)
                        textPhase = InterString.Get("�����׶�");

                    if (textPhase != string.Empty)
                    {
                        item = Instantiate(core.container.duelLogNewPhase);
                        item.transform.GetChild(1).GetComponent<Text>().text = textPhase;
                        AddLog(item);
                    }
                    break;
                case GameMessage.UpdateData:
                    if (psum)
                    {
                        psum = false;
                        VoiceHelper.ignoreNextPendulumSummon = false;
                        core.cardsBeTarget.Clear();
                        item = Instantiate(chainSolving > 0 ? core.container.duelLogText2 : core.container.duelLogText);
                        item.transform.GetChild(1).GetComponent<Text>().text = InterString.Get("����ٻ�����");
                        AddLog(item);
                    }
                    break;
                case GameMessage.Hint:
                    item = null;
                    if (core.Es_selectMSGHintType == 8
                        || core.Es_selectMSGHintType == 10)
                        item = Instantiate(core.cardsInChain.Count > 0 ? core.container.duelLogTextWithCard2 : core.container.duelLogTextWithCard);
                    else if (core.Es_selectMSGHintType >= 2
                        && core.Es_selectMSGHintType <= 11
                        && core.Es_selectMSGHintType != 3)
                        item = Instantiate(core.cardsInChain.Count > 0 ? core.container.duelLogText2 : core.container.duelLogText);
                    if (item != null)
                    {
                        item.transform.GetChild(1).GetComponent<Text>().text = OcgCore.lastDuelLog;
                        if (item.transform.childCount > 2)
                        {
                            code = core.Es_selectMSGHintData;
                            cardFace = item.transform.GetChild(2).GetComponent<RawImage>();
                            StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(cardFace, code, true));
                            item.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
                            {
                                core.description.Show(null, null, code, new GPS());
                            });
                        }
                        AddLog(item);
                    }
                    break;
                case GameMessage.AddCounter:
                case GameMessage.RemoveCounter:
                    type = r.ReadUInt16();
                    gps = r.ReadShortGPS();
                    card = core.GCS_Get(gps);
                    count = r.ReadUInt16();
                    if (card == null)
                    {
                        Debug.Log("Log Counter: not find card! ");
                        break;
                    }
                    var counterNow = card.GetCounterCount(type);
                    var counterBefore = counterNow - count;
                    if (core.currentMessage == GameMessage.RemoveCounter)
                        counterBefore = counterNow + count;
                    item = Instantiate(core.container.duelLogCounter);
                    targetColor = gps.controller == 0 ? DuelLog.myColor : DuelLog.opColor;
                    item.transform.GetChild(1).GetComponent<Image>().color = targetColor;
                    item.transform.GetChild(2).GetComponent<Text>().text = card.GetData().Name;
                    cardFace = item.transform.GetChild(3).GetComponent<RawImage>();
                    StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(cardFace, card.GetData().Id, true));
                    cardFace.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
                    {
                        core.description.Show(null, null, code, gps);
                    });
                    icons = TextureManager.container.GetLocationIcons(gps);
                    if (icons.Count == 2)
                    {
                        item.transform.GetChild(4).GetComponent<Image>().sprite = icons[1];
                        item.transform.GetChild(4).GetChild(0).GetComponent<Image>().sprite = icons[0];
                    }
                    else
                    {
                        item.transform.GetChild(4).GetComponent<Image>().sprite = icons[0];
                        item.transform.GetChild(4).GetChild(0).gameObject.SetActive(false);
                    }
                    var textCounterTo = item.transform.GetChild(5).GetComponent<Text>();
                    textCounterTo.text = counterNow.ToString();
                    var textCounterFrom = textCounterTo.transform.GetChild(0).GetChild(0).GetComponent<Text>();
                    textCounterFrom.text = counterBefore.ToString();
                    textCounterFrom.transform.GetChild(0).GetComponent<Image>().sprite =
                        TextureManager.GetCardCounterIcon(type);
                    item.transform.GetChild(6).GetComponent<Text>().text = StringHelper.Get("counter", type);
                    AddLog(item);
                    break;

                #endregion

                case GameMessage.Win:
                    break;
                case GameMessage.SwapGraveDeck:
                    break;
                case GameMessage.ReverseDeck:
                    break;
                case GameMessage.FieldDisabled:
                    break;
                case GameMessage.Equip:
                    break;
            }
        }

        void AddSingleCardMessageToLog(int code, GPS from, GPS to, string reason, bool indent = false)
        {
            var core = Program.instance.ocgcore;

            var item = Instantiate(code > 0 ? core.container.duelLogSingleCard : core.container.duelLogSingleCard2);
            Color targetColor;
            if (to == null)
                targetColor = from.controller == 0 ? DuelLog.myColor : DuelLog.opColor;
            else
                targetColor = to.controller == 0 ? DuelLog.myColor : DuelLog.opColor;
            targetColor.a = 0.75f;
            item.transform.GetChild(1).GetComponent<Image>().color = targetColor;

            if (code > 0)
                item.transform.GetChild(2).GetComponent<Text>().text = CardsManager.Get(code).Name;

            item.transform.GetChild(3).GetComponent<Text>().text = reason;

            var cardFace = item.transform.GetChild(4).GetComponent<RawImage>();
            if (code > 0)
                StartCoroutine(Program.instance.texture_.LoadCardToRawImageWithoutMaterialAsync(cardFace, code, true));
            else
            {
                cardFace.texture = null;
                cardFace.material = (to == null ? from : to).controller == 0 ? core.myProtector : core.opProtector;
                cardFace.transform.GetChild(0).gameObject.SetActive(false);
            }
            cardFace.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
            {
                core.description.Show(null, null, code, to == null ? from : to);
            });
            if (to != null && (to.position & (uint)CardPosition.Defence) > 0 && (to.location & (uint)CardLocation.MonsterZone) > 0)
                cardFace.transform.localEulerAngles = new Vector3(0f, 0f, 90f);
            if (to == null && (from.position & (uint)CardPosition.Defence) > 0 && (from.location & (uint)CardLocation.MonsterZone) > 0)
                cardFace.transform.localEulerAngles = new Vector3(0f, 0f, 90f);

            if (to != null && (to.position & (uint)CardPosition.FaceUp) > 0)
                cardFace.transform.GetChild(0).gameObject.SetActive(false);
            if (to == null && (from.position & (uint)CardPosition.FaceUp) > 0)
                cardFace.transform.GetChild(0).gameObject.SetActive(false);

            List<Sprite> icons;
            icons = TextureManager.container.GetLocationIcons(from);
            if (icons.Count == 2)
            {
                item.transform.GetChild(5).GetComponent<Image>().sprite = icons[1];
                item.transform.GetChild(5).GetChild(0).GetComponent<Image>().sprite = icons[0];
            }
            else
            {
                item.transform.GetChild(5).GetComponent<Image>().sprite = icons[0];
                item.transform.GetChild(5).GetChild(0).gameObject.SetActive(false);
            }
            if (to != null)
            {
                if (to.controller == 0)
                    item.transform.GetChild(6).GetComponent<Image>().color = DuelLog.myArrowColor;
                else
                    item.transform.GetChild(6).GetComponent<Image>().color = DuelLog.opArrowColor;
                icons = TextureManager.container.GetLocationIcons(to);
                if (icons.Count == 2)
                {
                    item.transform.GetChild(7).GetComponent<Image>().sprite = icons[1];
                    item.transform.GetChild(7).GetChild(0).GetComponent<Image>().sprite = icons[0];
                }
                else
                {
                    item.transform.GetChild(7).GetComponent<Image>().sprite = icons[0];
                    item.transform.GetChild(7).GetChild(0).gameObject.SetActive(false);
                }
            }
            else
            {
                item.transform.GetChild(6).gameObject.SetActive(false);
                item.transform.GetChild(7).gameObject.SetActive(false);
            }
            AddLog(item, indent);
#if UNITY_EDITOR
            if (core.currentMessage == GameMessage.Move
                || core.currentMessage == GameMessage.Summoning
                || core.currentMessage == GameMessage.SpSummoning)
            {
                var targetReason = lastMoveReason;
                item.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(() =>
                {
                    Debug.LogFormat("{0:X}", targetReason);
                });
            }

            item.transform.GetChild(5).GetComponent<Button>().onClick.AddListener(() =>
            {
                Debug.LogFormat("Location: {0:X}, Sequence: {1}, Position: {2:X}", from.location, from.sequence, from.position);
            });
            if (to != null)
            {
                item.transform.GetChild(7).GetComponent<Button>().onClick.AddListener(() =>
                {
                    Debug.LogFormat("Location: {0:X}, Sequence: {1}, Position: {2:X}", to.location, to.sequence, to.position);
                });
            }
#endif
        }

        void AddLpPChangeMessageToLog(int player, string reason, int value, bool red = true, bool indent = false)
        {
            var core = Program.instance.ocgcore;

            var item = Instantiate(core.container.duelLogLpChange);
            var targetColor = player == 0 ? DuelLog.myColor : DuelLog.opColor;
            item.transform.GetChild(1).GetComponent<Image>().color = targetColor;
            var frame = item.transform.GetChild(2).GetComponent<Image>();
            frame.material = player == 0 ? core.player0Frame.material : core.player1Frame.material;
            frame.sprite = player == 0 ? core.player0Frame.sprite : core.player1Frame.sprite;
            item.transform.GetChild(3).GetComponent<Text>().text = reason;
            item.transform.GetChild(4).GetComponent<Text>().text = value.ToString();
            item.transform.GetChild(4).GetComponent<Text>().color = red ? DuelLog.damageColor : DuelLog.recoverColor;
            var lp = player == 0 ? core.life0 : core.life1;
            if (lp < 0)
                lp = 0;
            item.transform.GetChild(6).GetComponent<Text>().text = lp.ToString();
            AddLog(item, indent);
        }

        #endregion
    }
}
