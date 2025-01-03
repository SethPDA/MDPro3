using DG.Tweening;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionButton_CardInCollection : SelectionButton, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        private int _cardCode;
        public int CardCode
        {
            get { return _cardCode; }
            set
            {
                if (_cardCode != value)
                {
                    TextureLoader.DeleteCard(_cardCode);
                    _cardCode = value;
                    data = CardsManager.Get(_cardCode);
                    SetIcons();
                    Refresh();
                }
            }
        }
        public Card data;
        public CardCollectionView cardCollectionView;
        private Coroutine refreshCoroutine;
        private RawImage imageCard;
        private Material normalCardMat;
        private Material tempMaterial;
        private Tweener matTweener;

        protected override void Awake()
        {
            manuallySetNavigation = false;
            base.Awake();
            SetClickEvent(() =>
            {
                if(UserInput.gamepadType == UserInput.GamepadType.None)
                {
                    Program.instance.deckEditor.ShowDetail(data);
                    if (cardCollectionView.area != CardCollectionView.Area.History)
                        Program.instance.deckEditor.AddHistoryCard(data.Id);
                }
                else
                {
                    AddThisToDeck();
                }
            });
            SetRightClickEvent(() =>
            {
                AddThisToDeck();
            });
        }
        protected override void OnDisable()
        {
            base.OnDisable();
            if (refreshCoroutine != null)
                StopCoroutine(refreshCoroutine);
        }

        private void OnDestroy()
        {
            TextureLoader.DeleteCard(CardCode);
        }

        protected override void OnSelect(bool playSE)
        {
            base.OnSelect(playSE);
            Program.instance.deckEditor.ShowDetail(data);
            Program.instance.deckEditor.lastSelectedCardOnCollection = this;
            Program.instance.deckEditor._ResponseRegion = DeckEditor.ResponseRegion.Collection;
        }

        private void AddThisToDeck()
        {
            var position = transform.GetChild(0).position;
            Program.instance.deckEditor.AddCardFromCollection(data, position);
            Program.instance.deckEditor.ShowDetail(data);
        }

        public void Refresh()
        {
            if (refreshCoroutine != null)
                StopCoroutine(refreshCoroutine);
            refreshCoroutine = StartCoroutine(RefreshAsync());
        }

        private IEnumerator RefreshAsync()
        {
            while (TextureManager.container == null)
                yield return null;

            var rarity = CardRarity.GetRarity(CardCode);

            if (imageCard == null)
                imageCard = Manager.GetElement<RawImage>("ImageCard");

            if(normalCardMat == null)
                normalCardMat = TextureManager.GetCardMaterial(-1, false);
            if(tempMaterial != null)
                Destroy(tempMaterial);

            if (matTweener.IsActive())
                matTweener.Kill();
            normalCardMat.SetTexture("_LoadingTex", TextureManager.container.GetCardUnloadTexture(data));
            normalCardMat.SetFloat("_LoadingBlend", 1f);
            imageCard.material = normalCardMat;

            while (OnScrollSetFreeze.Freeze)
                yield return null;
            for (int i = 0; i < transform.GetSiblingIndex(); i++)
                yield return null;

            var task = TextureLoader.LoadCardAsync(CardCode, false);
            while (!task.IsCompleted)
                yield return null;

            imageCard.texture = task.Result;

            if (rarity == CardRarity.Rarity.Normal)
            {
                matTweener = normalCardMat.DOFloat(0f, "_LoadingBlend", 0.2f);
            }
            else
            {
                tempMaterial = TextureManager.GetCardMaterial(CardCode, false);
                tempMaterial.SetTexture("_LoadingTex", normalCardMat.GetTexture("_LoadingTex"));
                tempMaterial.SetFloat("_LoadingBlend", 1f);
                matTweener = tempMaterial.DOFloat(0f, "_LoadingBlend", 0.2f);
                imageCard.material = tempMaterial;
            }

            refreshCoroutine = null;
        }

        public void RefreshRarity(int code)
        {
            if (data.Id != code)
                return;
            if(tempMaterial != null)
                Destroy(tempMaterial);

            var rarity = CardRarity.GetRarity(CardCode);
            if(rarity == CardRarity.Rarity.Normal)
                imageCard.material = normalCardMat;
            else
            {
                tempMaterial = TextureManager.GetCardMaterial(CardCode);
                imageCard.material = tempMaterial;
            }
        }

        public void SetRegulationIcon()
        {
            Manager.GetElement<Image>("IconLimit").sprite
                = TextureManager.container.GetCardRegulationIcon(CardCode, DeckEditor.banlist);
        }

        private void SetIcons()
        {
            SetRegulationIcon();

            var attributeIcon = TextureManager.container.GetCardAttributeIcon(data);
            Manager.GetElement<Image>("IconAttribute").sprite =
                attributeIcon == null
                ? TextureManager.container.typeNone
                : attributeIcon;

            var spellTrapTypeIcon = TextureManager.container.GetCardSpellTrapTypeIcon(data);
            Manager.GetElement<Image>("IconSpellTrapType").sprite =
                spellTrapTypeIcon == null
                ? TextureManager.container.typeNone
                : spellTrapTypeIcon;

            var raceIcon = TextureManager.container.GetCardRaceIcon(data);
            Manager.GetElement<Image>("IconRace").sprite =
                raceIcon == null
                ? TextureManager.container.typeNone
                : raceIcon;
            Manager.GetElement<Image>("IconPool").sprite =
                TextureManager.container.GetCardPoolIcon(data);

            Manager.GetElement<TextMeshProUGUI>("TextLevel").text = data.Level.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextRank").text = data.Level.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextLink").text = data.GetLinkCount().ToString();
            Manager.GetElement<TextMeshProUGUI>("TextPendulumScale").text = data.LScale.ToString();

            RefreshIcons();
            RefreshCountIcon();
        }

        public void RefreshIcons()
        {
            Manager.GetElement("IconAttribute").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail);
            Manager.GetElement("IconSpellTrapType").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail);
            Manager.GetElement("IconRace").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail);
            Manager.GetElement("IconTuner").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && data.HasType(CardType.Tuner));
            var levelType = data.GetLevelType();
            Manager.GetElement("IconLevel").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && data.HasType(CardType.Monster) && levelType == Card.LevelType.Level);
            Manager.GetElement("IconRank").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && data.HasType(CardType.Monster) && levelType == Card.LevelType.Rank);
            Manager.GetElement("IconLink").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && data.HasType(CardType.Monster) && levelType == Card.LevelType.Link);
            Manager.GetElement("IconPendulumScale").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && data.HasType(CardType.Pendulum));
            Manager.GetElement("IconPool").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Pool);
        }

        public void RefreshCountIcon()
        {
            var ragulation = DeckEditor.banlist.GetQuantity(data.Id);
            var count = Program.instance.deckEditor.deckView.GetCardCount(data.Id);
            var color = Color.white;
            if(count == ragulation)
                color = Color.yellow;
            if(count > ragulation)
                color = Color.red;

            Manager.GetElement<Image>("IconCardUse1").color = color;
            Manager.GetElement<Image>("IconCardUse2").color = color;
            Manager.GetElement<Image>("IconCardUse3").color = color;

            for (int i = 1; i <= count && i < 4; i++)
                Manager.GetElement("IconCardUse" + i).SetActive(true);
            for (int i = count + 1; i < 4; i++)
                Manager.GetElement("IconCardUse" + i).SetActive(false);
        }

        #region Drag

        private RectTransform dragTarget;

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            UserInput.draging = true;

            dragTarget = Program.instance.deckEditor.GetDragCardImage();
            dragTarget.gameObject.SetActive(true);
            dragTarget.GetChild(0).GetComponent<RawImage>().texture
                = Manager.GetElement<RawImage>("ImageCard").texture;
            dragTarget.GetChild(0).GetComponent<RawImage>().material
                = Manager.GetElement<RawImage>("ImageCard").material;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            RectTransformUtility.ScreenPointToWorldPointInRectangle(
                dragTarget, eventData.position, eventData.enterEventCamera, out var position);
            dragTarget.position = position;
            var anchoredPositon = dragTarget.anchoredPosition3D;
            anchoredPositon.z = -10f;
            dragTarget.anchoredPosition3D = anchoredPositon;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            UserInput.draging = false;

            dragTarget.gameObject.SetActive(false);
            Program.instance.deckEditor.AddCardFromCollection(data);
            Program.instance.deckEditor.deckView.HideDeckLocationTable();
        }

        #endregion

        #region Navigation

        protected override int GetButtonsCount()
        {
            return Program.instance.deckEditor.cardCollectionView.superScrollView.items.Count;
        }

        protected override int GetColumnsCount()
        {
            return 6;
        }

        protected override void OnNavigationLeftBorder()
        {
            base.OnNavigationLeftBorder();
            Program.instance.deckEditor.SelectNearestDeckViewItem(transform.GetChild(0).position);
        }

        #endregion
    }
}