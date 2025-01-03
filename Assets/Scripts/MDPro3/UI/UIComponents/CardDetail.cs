using DG.Tweening;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.UI;
using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.AddressableAssets;
using MDPro3.Utility;

namespace MDPro3
{
    public class CardDetail : UIHandler
    {
        ElementObjectManager manager;
        private readonly float bigShowTime = 0.2f;
        private readonly float hideScale = 0.9f;
        int code;
        List<int> cards;
        int cardIndex;

        public override void Initialize()
        {
            base.Initialize();
            transitionTime = 0.1f;
            shadowColor = 0.9f;
            manager = GetComponent<ElementObjectManager>();
        }

        public override void PerframeFunction()
        {
            base.PerframeFunction();
            if (!showing) return;
            if (inTransition) return;
            if (UserInput.WasCancelPressed || UserInput.MouseRightDown)
                Hide();

            if (UserInput.WasUpPressed)
                OnUp();

            if (UserInput.WasDownPressed)
                OnDown();

            if (cards == null)
                return;

            if (UserInput.WasLeftPressed)
                OnLeft();

            if (UserInput.WasRightPressed)
                OnRight();
        }

        public override void Hide()
        {
            base.Hide();
            AudioManager.PlaySE("SE_DUEL_CANCEL");
            window.DOScale(hideScale, transitionTime);
            shadow.DOFade(0f, transitionTime);
            cg.DOFade(0f, transitionTime);

            if (Program.instance.currentServant == Program.instance.editDeck)
                UIManager.ShowFPSRight();
            OnDown();
        }
        public void Show(Card data, Texture cardFace, Material mat, List<int> cards = null, int cardIndex = -1)
        {
            if (data.Id == 0)
                return;
            Show();
            AudioManager.PlaySE("SE_DECK_WINDOW_OPEN");
            window.localScale = Vector3.one * hideScale;
            window.DOScale(1f, transitionTime);
            var windowCG = window.GetComponent<CanvasGroup>();
            windowCG.alpha = 0f;
            window.GetComponent<CanvasGroup>().DOFade(1f, transitionTime);
            UIManager.ShowFPSLeft();

            this.cards = cards;
            this.cardIndex = cardIndex;
            code = data.Id;
            var needArrow = NeedShowArrow();
            manager.GetElement("ButtonLeft").SetActive(needArrow);
            manager.GetElement("ButtonRight").SetActive(needArrow);

            if (this.cardIndex == -1 && cards != null)
            {
                this.cardIndex = 0;
                for (var i = 0; i < cards.Count; i++)
                {
                    if(code == cards[i])
                    {
                        this.cardIndex = i;
                        break;
                    }
                }
            }

            var origin = CardsManager.Get(data.Id);

            if (mat != null)
            {
                manager.GetElement<RawImage>("Card").texture = cardFace;
                manager.GetElement<RawImage>("Card").material = mat;
            }
            else
            {
                if(loadEnumerator != null)
                    StopCoroutine(loadEnumerator);
                loadEnumerator = LoadCardPictureAsync();
                StartCoroutine(loadEnumerator);
            }

            var colors = CardDescription.GetCardFrameColor(origin);
            manager.GetElement<Image>("NameBase").color = colors[0];
            manager.GetElement<Image>("StatusBase").color = colors[0];
            manager.GetElement<Image>("PendulumBase").color = colors[1];
            manager.GetElement<Image>("EffectBase").color = colors[0];

            manager.GetElement<Text>("TextName").text = origin.Name;
            manager.GetElement<Image>("Attribute").sprite = CardDescription.GetCardAttribute(data).sprite;
            manager.GetElement<Text>("TextType").text = StringHelper.GetType(origin) + StringHelper.GetSetName(origin.Setcode)
                + "【" + origin.Id.ToString() + "】" + (origin.Alias != 0 ? "【" + origin.Alias.ToString() + "】" : "");

            var statusRect = manager.GetElement<RectTransform>("Status");
            var effectRect = manager.GetElement<RectTransform>("Effect");

            if (origin.HasType(CardType.Monster))
            {
                statusRect.sizeDelta = new Vector2(statusRect.sizeDelta.x, 140);
                manager.GetElement("StatusMonster").SetActive(true);
                manager.GetElement("StatusSpell").SetActive(false);
                manager.GetElement<Image>("Level").sprite = TextureManager.GetCardLevelIcon(origin);
                manager.GetElement<Image>("Race").sprite = TextureManager.GetCardRaceIcon(origin.Race);
                if (origin.HasType(CardType.Tuner))
                    manager.GetElement("Tuner").SetActive(true);
                else
                    manager.GetElement("Tuner").SetActive(false);
                manager.GetElement<Text>("TextATK").text = origin.Attack == -2 ? "?" : origin.Attack.ToString();
                if (origin.HasType(CardType.Link))
                {
                    manager.GetElement<Text>("TextLevel").text = CardDescription.GetCardLinkCount(origin).ToString();
                    manager.GetElement("DEF").SetActive(false);
                    manager.GetElement("TextDEF").SetActive(false);
                }
                else
                {
                    manager.GetElement<Text>("TextLevel").text = origin.Level.ToString();
                    manager.GetElement("DEF").SetActive(true);
                    manager.GetElement("TextDEF").SetActive(true);
                    manager.GetElement<Text>("TextDEF").text = origin.Defense == -2 ? "?" : origin.Defense.ToString();
                }
                if (origin.HasType(CardType.Pendulum))
                {
                    manager.GetElement("Scale").SetActive(true);
                    manager.GetElement("TextScale").SetActive(true);
                    manager.GetElement<Text>("TextScale").text = origin.LScale.ToString();
                    manager.GetElement("Pendulum").SetActive(true);
                    effectRect.sizeDelta = new Vector2(effectRect.sizeDelta.x, 330);
                    var texts = CardDescription.GetCardDescriptionSplit(origin.Desc);
                    manager.GetElement<Text>("TextPendulum").text = TextForDetail(texts[0]);
                    manager.GetElement<Text>("TextEffect").text = TextForDetail(texts[1]);
                }
                else
                {
                    manager.GetElement("Scale").SetActive(false);
                    manager.GetElement("TextScale").SetActive(false);
                    manager.GetElement("Pendulum").SetActive(false);
                    effectRect.sizeDelta = new Vector2(effectRect.sizeDelta.x, 565);
                    manager.GetElement<Text>("TextEffect").text = TextForDetail(origin.Desc);
                }
            }
            else
            {
                statusRect.sizeDelta = new Vector2(statusRect.sizeDelta.x, 76);
                manager.GetElement("Pendulum").SetActive(false);
                manager.GetElement("StatusMonster").SetActive(false);
                manager.GetElement<Text>("TextEffect").text = TextForDetail(origin.Desc);
                effectRect.sizeDelta = new Vector2(effectRect.sizeDelta.x, 630);

                manager.GetElement("StatusSpell").SetActive(true);
                manager.GetElement<Image>("TypeSpell").sprite = TextureManager.GetSpellTrapTypeIcon(origin);
                manager.GetElement<Text>("TextTypeSpell").text = StringHelper.SecondType(origin.Type) + StringHelper.MainType(origin.Type);
                if (manager.GetElement<Text>("TextTypeSpell").text.Contains(StringHelper.GetUnsafe(1054)))
                    manager.GetElement<RectTransform>("TextTypeSpell").anchoredPosition = new Vector2(15, -7);
                else
                    manager.GetElement<RectTransform>("TextTypeSpell").anchoredPosition = new Vector2(60, -7);
            }

            Banlist banlist;
            if (Program.instance.currentServant == Program.instance.editDeck)
                banlist = Program.instance.editDeck.banlist;
            else
            {
                //TODO
                banlist = Program.instance.editDeck.banlist;
            }
            var limit = banlist.GetQuantity(data.Id);
            if (limit == 3)
                manager.GetElement<Image>("Limit").sprite = TextureManager.container.typeNone;
            else if (limit == 2)
                manager.GetElement<Image>("Limit").sprite = TextureManager.container.limit2;
            else if (limit == 1)
                manager.GetElement<Image>("Limit").sprite = TextureManager.container.limit1;
            else
                manager.GetElement<Image>("Limit").sprite = TextureManager.container.banned;

            manager.GetElement<Text>("TextPendulum").resizeTextMaxSize = (int)(28 * Config.GetUIScale());
            manager.GetElement<Text>("TextEffect").resizeTextMaxSize = (int)(28 * Config.GetUIScale());
        }

        private bool NeedShowArrow()
        {
            if(cards == null)
                return false;
            if(cards.Count < 2)
                return false;
            List<int> cardKinds = new();
            for (int i = 0; i < cards.Count; i++)
                if (!cardKinds.Contains(cards[i]))
                {
                    cardKinds.Add(cards[i]);
                    if (cardKinds.Count > 1)
                        break;
                }
            if (cardKinds.Count > 1)
                return true;
            else
                return false;
        }

        IEnumerator loadEnumerator;

        IEnumerator LoadCardPictureAsync()
        {
            var mat = TextureManager.GetCardMaterial(code);
            mat.renderQueue = 3000;

            var task = TextureManager.LoadCardAsync(code);
            while (!task.IsCompleted)
                yield return null;
            mat.mainTexture = task.Result;

            manager.GetElement<RawImage>("Card").material = mat;
            manager.GetElement<RawImage>("Card").texture = task.Result;

            loadEnumerator = null;
        }

        public void OnCardPictureSave()
        {
            if(Program.instance.ocgcore.showing 
                || (Program.instance.editDeck.showing && Program.instance.editDeck.condition == EditDeck.Condition.ChangeSide))
            {
                SaveShowingCard();
                return;
            }

            List<string> selections = new()
            {
                InterString.Get("保存选项"),
                string.Empty,
                InterString.Get("当前卡片卡图"),
                InterString.Get("当前卡组卡图"),
                InterString.Get("所有衍生物卡图"),
                InterString.Get("所有卡图"),
            };
            UIManager.ShowPopupSelection(selections, CardPictureSaveOption);
        }
        void CardPictureSaveOption()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            if (selected == InterString.Get("当前卡片卡图"))
                SaveShowingCard();
            else if (selected == InterString.Get("当前卡组卡图"))
                SaveDeckCards();
            else if (selected == InterString.Get("所有衍生物卡图"))
                SaveAllTokens();
            else if (selected == InterString.Get("所有卡图"))
                SaveAllCards();
        }

        private bool SaveCardPicture(int code, Texture2D tex)
        {
            if (!Directory.Exists(Program.cardPicPath))
                Directory.CreateDirectory(Program.cardPicPath);

            try
            {
                var size = Settings.Data.SavedCardSize;
                if(size.Length > 1 && size[0] > 0 && size[1] > 0)
                    if (size[0] != tex.width || size[1] != tex.height)
                        tex = TextureManager.ResizeTexture2D(tex, size[0], size[1]);

                byte[] pic;
                string fullPath;
                var format = Settings.Data.SavedCardFormat.ToLower();
                if(format == Program.pngExpansion)
                {
                    pic = tex.EncodeToPNG();
                    fullPath = Program.cardPicPath + code + Program.pngExpansion;
                }
                else
                {
                    pic = tex.EncodeToJPG();
                    fullPath = Program.cardPicPath + code + Program.jpgExpansion;
                }

                File.WriteAllBytes(fullPath, pic);
                return true;
            }
            catch
            {
                return false;
            }
        }

        string errorLog;
        IEnumerator saveEnumerator;
        IEnumerator SaveCardsAsync(List<int> cards)
        {
            var handle = Addressables.InstantiateAsync("PopupProgress");
            while (!handle.IsDone)
                yield return null;
            handle.Result.transform.SetParent(Program.instance.ui_.popup, false);
            var popupProgress = handle.Result.GetComponent<UI.Popup.PopupProgress>();
            popupProgress.args = new List<string> { InterString.Get("卡图保存中") };
            popupProgress.cancelAction = StopSaving;
            popupProgress.text.text = string.Empty;
            popupProgress.progressBar.value = 0f;
            popupProgress.Show();
            yield return new WaitForSeconds(popupProgress.transitionTime);

            int errorCount = 0;
            errorLog = string.Empty;
            var errorLogPath = Program.cardPicPath + "MissingAndFailedCards.txt";
            if (File.Exists(errorLogPath))
                File.Delete(errorLogPath);

            for (int i = 0; i < cards.Count; i++)
            {
                var format = Settings.Data.SavedCardFormat;
                if (format != Program.pngExpansion)
                    format = Program.jpgExpansion;
                if (File.Exists(Program.cardPicPath + cards[i] + format))
                    continue;

                var ie = TextureManager.LoadCardAsync(cards[i]);
                while (!ie.IsCompleted)
                    yield return null;
                if (!SaveCardPicture(cards[i], ie.Result)
                    || !TextureManager.lastCardFoundArt
                    || !TextureManager.lastCardRenderSucceed)
                {
                    errorCount++;
                    errorLog += cards[i].ToString() + "\r\n";
                }
                popupProgress.text.text = i + Program.slash + cards.Count + "\r\n" + InterString.Get("错误：") + errorCount;
                popupProgress.progressBar.value = (float)i / cards.Count;
                if(cards.Count <= 100)
                    yield return null;
            }
            popupProgress.Hide();
            if (errorCount > 0)
                File.WriteAllText(errorLogPath, errorLog);
            saveEnumerator = null;
        }
        public void StopSaving()
        {
            if (saveEnumerator != null)
                StopCoroutine(saveEnumerator);
            if (!string.IsNullOrEmpty(errorLog))
                File.WriteAllText(Program.cardPicPath + "MissingAndFailedCards.txt", errorLog);
        }

        private void SaveShowingCard()
        {
            var rawImage = manager.GetElement<RawImage>("Card");
            var texture = rawImage.texture;
            if (texture == null)
                texture = rawImage.material.mainTexture;

            if (SaveCardPicture(code, (Texture2D)texture))
            {
                var fullPath = Program.cardPicPath + code + Program.pngExpansion;
                MessageManager.Cast(InterString.Get("卡图已保存于：[?]", fullPath));
            }
            else
            {
                MessageManager.Cast(InterString.Get("没有写入权限，无法保存。"));
            }
        }
        private void SaveDeckCards()
        {
            saveEnumerator = SaveCardsAsync(Program.instance.editDeck.CardsInDeck());
            StartCoroutine(saveEnumerator);
        }
        private void SaveAllTokens()
        {
            var cards = CardsManager.GetAllCards();
            var tokens = new List<int>();
            foreach (var card in cards)
                if (card.HasType(CardType.Token))
                    tokens.Add(card.Id);
            saveEnumerator = SaveCardsAsync(tokens);
            StartCoroutine(saveEnumerator);
        }
        private void SaveAllCards()
        {
            saveEnumerator = SaveCardsAsync(CardsManager.GetAllCardCodes());
            StartCoroutine(saveEnumerator);
        }


        public void OnLeft()
        {
            if (!NeedShowArrow())
                return;
            if (cardIndex < 0)
                cardIndex = 0;

            cardIndex = (cardIndex + cards.Count - 1) % cards.Count;
            var data = CardsManager.Get(cards[cardIndex]);

            while(data.Id == code)
            {
                cardIndex = (cardIndex + cards.Count - 1) % cards.Count;
                data = CardsManager.Get(cards[cardIndex]);
            }
            Show(data, null, null, cards, cardIndex);
        }
        public void OnRight()
        {
            if (!NeedShowArrow())
                return;
            if (cardIndex < 0)
                cardIndex = 0;

            cardIndex = (cardIndex + 1) % cards.Count;
            var data = CardsManager.Get(cards[cardIndex]);

            while (data.Id == code)
            {
                cardIndex = (cardIndex + 1) % cards.Count;
                data = CardsManager.Get(cards[cardIndex]);
            }
            Show(data, null, null, cards, cardIndex);
        }
        bool bigShowing = false;
        public void OnScale()
        {
            if(bigShowing)
                OnDown();
            else
                OnUp();
        }
        public void OnUp()
        {
            bigShowing = true;
#if UNITY_ANDROID
            BigShowMobile();
#else
            BigShowDesktop();
#endif
        }
        private void BigShowMobile()
        {
            var cardRect = manager.GetElement<RectTransform>("Card");
            var limit = manager.GetElement<Image>("Limit");
            limit.DOFade(0f, bigShowTime);
            var extraWidth = 1080f * Screen.width / Screen.height - 737f * 2f;
            cardRect.DOAnchorPos(new Vector2(extraWidth / 2f, -1035f), bigShowTime);
            cardRect.DOLocalRotate(new Vector3(0f, 0f, 90f), bigShowTime);
            cardRect.DOScale(2f, bigShowTime);
        }
        private void BigShowDesktop()
        {
            var cardRect = manager.GetElement<RectTransform>("Card");
            var limit = manager.GetElement<Image>("Limit");
            limit.DOFade(0f, bigShowTime);
            cardRect.DOAnchorPos(new Vector2(25f, -25f), bigShowTime);
            cardRect.DOLocalRotate(Vector3.zero, bigShowTime);
            cardRect.DOScale(1.4f, bigShowTime);

            var detailRect = manager.GetElement<RectTransform>("Detail");
            DOTween.To(() => detailRect.offsetMin.x, x => detailRect.offsetMin = new Vector2(x, 0f), 750f, bigShowTime);
        }
        public void OnDown()
        {
            bigShowing = false;
            var cardRect = manager.GetElement<RectTransform>("Card");
            var limit = manager.GetElement<Image>("Limit");
            limit.DOFade(1f, bigShowTime);
            cardRect.DOAnchorPos(new Vector2(60f, -145f), bigShowTime);
            cardRect.DOLocalRotate(Vector3.zero, bigShowTime);
            cardRect.DOScale(1f, bigShowTime);

            var detailRect = manager.GetElement<RectTransform>("Detail");
            DOTween.To(() => detailRect.offsetMin.x, x => detailRect.offsetMin = new Vector2(x, 0f), 630f, bigShowTime);
        }

        string TextForDetail(string text)
        {
            if(string.IsNullOrEmpty(text))
                text = string.Empty;
            if (Language.NeedBlankToAddWord())
                return text;
            else
                return text.Replace(" ", "\u00A0");
        }
    }
}
