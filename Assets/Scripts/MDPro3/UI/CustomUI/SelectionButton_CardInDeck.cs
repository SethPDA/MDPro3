using DG.Tweening;
using MDPro3.YGOSharp;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static YgomSystem.UI.ColorContainer;
using YgomSystem.UI;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using static MDPro3.UI.DeckView;

namespace MDPro3.UI
{
    public class SelectionButton_CardInDeck : SelectionButton, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        [Header("SelectionButton CardInDeck")]
        public DeckView deckView;
        private Card _data;
        public Card Data
        {
            get { return _data; }
            set
            {
                if(_data == null || value.Id != _data.Id)
                {
                    if(_data != null)
                        TextureLoader.DeleteCard(_data.Id);
                    _data = value;
                    SetIcons();
                    Refresh();
                }
            }
        }

        [HideInInspector] public bool refreshed;
        [HideInInspector] public DeckLocation location;
        private Coroutine refreshCoroutine;
        private Vector3 dragScale = new(1.7f, 1.7f, 1f);
        private RectTransform child;
        private Material cardMat;

        protected override void Awake()
        {
            manuallySetNavigation = false;
            base.Awake();
            child = transform.GetChild(0).GetComponent<RectTransform>();
            SetClickEvent(() =>
            {
                if(UserInput.gamepadType == UserInput.GamepadType.None)
                {
                    Program.instance.deckEditor.AddHistoryCard(Data.Id);
                    Program.instance.deckEditor.ShowDetail(Data);
                }
                else
                {
                    if (DeckEditor.condition == DeckEditor.Condition.EditDeck)
                        Program.instance.deckEditor.RemoveCard(this);
                }
            });
            SetRightClickEvent(() =>
            {
                Program.instance.deckEditor.RemoveCard(this);
                Program.instance.deckEditor.ShowDetail(Data);
            });
            SetMiddleClickEvent(() =>
            {
                Program.instance.deckEditor.AddCard(Data);
                Program.instance.deckEditor.ShowDetail(Data);
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
            TextureLoader.DeleteCard(Data.Id);
            Destroy(cardMat);
        }

        protected override void OnSelect(bool playSE)
        {
            base.OnSelect(playSE);

            foreach (var ccg in Manager.GetElement<Transform>("ImageCard")
                .GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Selected, hovering ? StatusMode.Enter : StatusMode.Normal, Selectable.interactable);

            Program.instance.deckEditor.ShowDetail(Data);
            Program.instance.deckEditor.lastSelectedCardInDeck = this;
            Program.instance.deckEditor._ResponseRegion = DeckEditor.ResponseRegion.Deck;
        }

        public void Refresh()
        {
            refreshCoroutine = StartCoroutine(RefreshAsync());
        }

        private IEnumerator RefreshAsync()
        {
            refreshed = false;
            while (TextureManager.container == null)
                yield return null;

            var imageCard = Manager.GetElement<RawImage>("ImageCard");
            imageCard.texture = TextureManager.container.GetCardUnloadTexture(Data);

            var task = TextureLoader.LoadCardAsync(Data.Id, true);
            while (!task.IsCompleted)
                yield return null;

            cardMat = TextureManager.GetCardMaterial(Data.Id, false);
            imageCard.material = cardMat;
            imageCard.texture = task.Result;

            refreshCoroutine = null;
            refreshed = true;
        }

        public void RefreshRarity(int code)
        {
            if (code != Data.Id)
                return;
            Destroy(cardMat);
            cardMat = TextureManager.GetCardMaterial(Data.Id, false);
            Manager.GetElement<RawImage>("ImageCard").material = cardMat;
        }

        public void SetRegulationIcon()
        {
            Manager.GetElement<Image>("IconLimit").sprite
                = TextureManager.container.GetCardRegulationIcon(Data.Id, DeckEditor.banlist);
        }

        private void SetIcons()
        {
            SetRegulationIcon();

            var attributeIcon = TextureManager.container.GetCardAttributeIcon(Data);
            Manager.GetElement<Image>("IconAttribute").sprite =
                attributeIcon == null
                ? TextureManager.container.typeNone
                : attributeIcon;

            var spellTrapTypeIcon = TextureManager.container.GetCardSpellTrapTypeIcon(Data);
            Manager.GetElement<Image>("IconSpellTrapType").sprite =
                spellTrapTypeIcon == null
                ? TextureManager.container.typeNone
                : spellTrapTypeIcon;

            var raceIcon = TextureManager.container.GetCardRaceIcon(Data);
            Manager.GetElement<Image>("IconRace").sprite =
                raceIcon == null
                ? TextureManager.container.typeNone
                : raceIcon;
            Manager.GetElement<Image>("IconPool").sprite =
                TextureManager.container.GetCardPoolIcon(Data);

            Manager.GetElement<TextMeshProUGUI>("TextLevel").text = Data.Level.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextRank").text = Data.Level.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextLink").text = Data.GetLinkCount().ToString();
            Manager.GetElement<TextMeshProUGUI>("TextPendulumScale").text = Data.LScale.ToString();

            RefreshIcons();
        }

        public void RefreshIcons()
        {
            Manager.GetElement("IconAttribute").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail);
            Manager.GetElement("IconSpellTrapType").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail);
            Manager.GetElement("IconRace").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail);
            Manager.GetElement("IconTuner").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && Data.HasType(CardType.Tuner));
            var levelType = Data.GetLevelType();
            Manager.GetElement("IconLevel").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && Data.HasType(CardType.Monster) && levelType == Card.LevelType.Level);
            Manager.GetElement("IconRank").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && Data.HasType(CardType.Monster) && levelType == Card.LevelType.Rank);
            Manager.GetElement("IconLink").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && Data.HasType(CardType.Monster) && levelType == Card.LevelType.Link);
            Manager.GetElement("IconPendulumScale").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Detail
                && Data.HasType(CardType.Pendulum));
            Manager.GetElement("IconPool").SetActive(DeckEditor._CardInfoType == DeckEditor.CardInfoType.Pool);
        }

        public void PlayBirthAnimation()
        {
            StartCoroutine(PlayBirthAnimationAsync());
        }

        private IEnumerator PlayBirthAnimationAsync()
        {
            yield return null;
            child.SetParent(Program.instance.ui_.transform, true);
            child.localScale = dragScale;
            child.DOScale(Vector3.one, 0.3f).SetEase(Ease.InQuart).OnComplete(() =>
            {
                child.SetParent(transform, true);
                child.localPosition = Vector3.zero;
                child.localScale = Vector3.one;
                child.localEulerAngles = Vector3.zero;
            });
        }

        public void LockPosition()
        {
            child.SetParent(Program.instance.ui_.transform, true);
            StartCoroutine(AutoMoveToParent());
        }

        public void LockPosition(Vector3 position, Vector3 scale)
        {
            child.SetParent(Program.instance.ui_.transform, true);
            child.position = position;
            child.localScale = scale;
            StartCoroutine(AutoMoveToParent());
        }

        private IEnumerator AutoMoveToParent()
        {
            yield return null;
            foreach (var ccg in child.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(selected ? SelectMode.Selected : SelectMode.Unselected, StatusMode.Normal, Selectable.interactable);

            var position = transform.position;
            DOTween.Sequence()
                .Append(child.DOMove(position, 0.1f).SetEase(Ease.OutCubic))
                .Join(child.DOScale(Vector3.one, 0.1f).SetEase(Ease.OutCubic))
                .OnComplete(() =>
                {
                    child.SetParent(transform, true);
                    child.localPosition = Vector3.zero;
                    child.localScale = Vector3.one;
                    child.localEulerAngles = Vector3.zero;
                });
        }

        public void MoveToParent(Vector3 position)
        {
            child.SetParent(Program.instance.ui_.transform, true);
            child.localScale = new Vector3(1.7f, 1.7f, 1f);
            child.position = position;
            StartCoroutine(AutoMoveToParent());
        }
        
        public void MoveToParentSequence(Vector3 position)
        {
            child.SetParent(Program.instance.ui_.transform, true);
            child.localScale = new Vector3(1.7f, 1.7f, 1f);
            child.position = position;
            StartCoroutine(AutoMoveToParentSequence());
        }

        private IEnumerator AutoMoveToParentSequence()
        {
            yield return null;
            foreach (var ccg in child.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Unselected, StatusMode.Normal, Selectable.interactable);

            var position = transform.position;
            DOTween.Sequence()
                .Append(child.DOMove(position, 0.2f).SetEase(Ease.OutCubic))
                .Append(child.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic))
                .OnComplete(() =>
                {
                    child.SetParent(transform, true);
                    child.localPosition = Vector3.zero;
                    child.localScale = Vector3.one;
                    child.localEulerAngles = Vector3.zero;
                });
        }

        public bool IsHovering()
        {
            return hovering;
        }

        #region Drag

        private RectTransform dragTarget;
        private Vector2 dragStartPosition;
        private bool draging;
        private bool dragIni;

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            deckView.ScrollRect.OnBeginDrag(eventData);
            dragStartPosition = eventData.position;
            draging = !DeckEditor.useMobileLayout;
            dragIni = false;

            dragTarget = Program.instance.deckEditor.GetDragCardImage();
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            if(draging)
            {
                if(!dragIni)
                {
                    dragTarget.gameObject.SetActive(true);
                    dragTarget.GetChild(0).GetComponent<RawImage>().texture
                        = Manager.GetElement<RawImage>("ImageCard").texture;
                    dragTarget.GetChild(0).GetComponent<RawImage>().material
                        = Manager.GetElement<RawImage>("ImageCard").material;
                    dragIni = true;
                    UserInput.draging = true;
                    var cg = GetComponent<CanvasGroup>();
                    cg.blocksRaycasts = false;
                    cg.alpha = 0f;
                }

                RectTransformUtility.ScreenPointToWorldPointInRectangle(
                    dragTarget, eventData.position, eventData.enterEventCamera, out var position);
                dragTarget.position = position;
                var anchoredPositon = dragTarget.anchoredPosition3D;
                anchoredPositon.z = -10f;
                dragTarget.anchoredPosition3D = anchoredPositon;
            }
            else
            {
                deckView.ScrollRect.OnDrag(eventData);
                if (Mathf.Abs(eventData.position.x - dragStartPosition.x)
                    > Mathf.Abs(eventData.position.y - dragStartPosition.y))
                    draging = true;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;
            deckView.ScrollRect.OnEndDrag(eventData);
            UserInput.draging = false;

            if(draging)
            {
                var cg = GetComponent<CanvasGroup>();
                cg.blocksRaycasts = true;
                cg.alpha = 1f;

                dragTarget.gameObject.SetActive(false);

                Program.instance.deckEditor.deckView.DragCardTo(this, dragTarget.position);
                Program.instance.deckEditor.deckView.HideDeckLocationTable();
            }
        }
        #endregion

        #region Navigation
        protected override int GetButtonsCount()
        {
            return Program.instance.deckEditor.deckView.GetDeckLocationCount(location);
        }

        protected override int GetColumnsCount()
        {
            return Program.instance.deckEditor.deckView.GetDeckLocationParent(location)
                .GetComponent<GridLayoutGroup>().Size().x;
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            var selfIndex = transform.GetSiblingIndex();

            var count = GetButtonsCount();
            var columes = GetColumnsCount();
            if(columes == 0)
            {
                Debug.LogError("divide by zero");
                return;
            }
                

            var targetIndex = selfIndex + 1;

            if (eventData.moveDir == MoveDirection.Left)
            {
                if (selfIndex % columes == 0)
                    return;
                targetIndex = selfIndex - 1;
            }
            else if (eventData.moveDir == MoveDirection.Right)
            {
                if (selfIndex % columes == columes - 1
                    || selfIndex == count - 1)
                {
                    Program.instance.deckEditor.SelectNearestCollectionViewItem(transform.position);
                    return;
                }
            }
            else if (eventData.moveDir == MoveDirection.Up)
            {
                targetIndex = selfIndex - columes;
                if (targetIndex < 0)
                {
                    SelectTarget(GetNavivationTarget(eventData.moveDir));
                    return;
                }
            }
            else if (eventData.moveDir == MoveDirection.Down)
            {
                targetIndex = selfIndex + columes;
                if (targetIndex >= count)
                {
                    SelectTarget(GetNavivationTarget(eventData.moveDir));
                    return;
                }
            }

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                var child = transform.parent.GetChild(i);
                if (!child.gameObject.activeSelf)
                    continue;

                var buttonIndex = child.GetComponent<SelectionButton>().index;
                if (buttonIndex < 0)
                    buttonIndex = i;

                if (buttonIndex == targetIndex)
                {
                    UserInput.NextSelectionIsAxis = true;
                    EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(i).gameObject);
                    break;
                }
            }
        }

        private SelectionButton_CardInDeck GetNavivationTarget(MoveDirection direction)
        {
            var columeCount = GetColumnsCount();
            var columeIndex = transform.GetSiblingIndex() % GetColumnsCount();

            if (direction == MoveDirection.Up)
            {
                if (location == DeckLocation.MainDeck)
                    return null;
                else if(location == DeckLocation.ExtraDeck)
                    return Program.instance.deckEditor.deckView.GetNavigationTarget(DeckLocation.MainDeck, direction, columeIndex, columeCount);
                else if (location == DeckLocation.SideDeck)
                    return Program.instance.deckEditor.deckView.GetNavigationTarget(DeckLocation.ExtraDeck, direction, columeIndex, columeCount);
            }
            else if (direction == MoveDirection.Down)
            {
                if (location == DeckLocation.MainDeck)
                    return Program.instance.deckEditor.deckView.GetNavigationTarget(DeckLocation.ExtraDeck, direction, columeIndex, columeCount);
                else if (location == DeckLocation.ExtraDeck)
                    return Program.instance.deckEditor.deckView.GetNavigationTarget(DeckLocation.SideDeck, direction, columeIndex, columeCount);
                else if (location == DeckLocation.SideDeck)
                    return null;
            }
            return null;
        }

        private void SelectTarget(SelectionButton_CardInDeck target)
        {
            if (target == null)
                return;
            UserInput.NextSelectionIsAxis = true;
            EventSystem.current.SetSelectedGameObject(target.gameObject);
        }

        #endregion
    }
}
