using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using DG.Tweening;
using static YgomSystem.UI.ColorContainer;
using UnityEngine.Events;
using TMPro;

namespace MDPro3.UI
{
    [RequireComponent(typeof(Selectable))]
    [RequireComponent(typeof(ElementObjectManager))]
    public class SelectionButton : MonoBehaviour,
        IPointerEnterHandler, IPointerExitHandler,
        IPointerDownHandler, IPointerUpHandler,
        IPointerClickHandler, ISubmitHandler,
        ISelectHandler, IDeselectHandler,
        IMoveHandler
    {
        [Header("Selection Button")]
        public int index = -1;
        [SerializeField] protected bool SetToResponser = true;
        [SerializeField] protected string SoundLabelClick;
        [SerializeField] protected string SoundLabelClickInactive;
        [SerializeField] protected string SoundLabelPointerEnter;
        [SerializeField] protected string SoundLabelSelectedGamePad;

        [SerializeField] protected SelectionButtonNavigationEvent navigationEvent;
        [SerializeField] protected SelectionButtonHoverEvent hoverEvent;
        [SerializeField] protected SelectionClickEvent clickEvent;

        private ElementObjectManager m_Manager;
        protected ElementObjectManager Manager
        {
            get
            {
                if (m_Manager == null)
                    m_Manager = GetComponent<ElementObjectManager>();
                return m_Manager;
            }
        }

        private Selectable m_Selectable;
        protected Selectable Selectable
        {
            get
            {
                if (m_Selectable == null)
                    m_Selectable = GetComponent<Selectable>();
                return m_Selectable;
            }
        }

        protected List<Tweener> hoverOnTweens = new();
        protected List<Tweener> hoverOffTweens = new();
        protected bool hovering;
        protected bool pressing;
        protected bool hoverd;
        protected bool selected;

        protected bool manuallySetNavigation = true;
        protected bool clickIsSubmit = true;
        protected bool selectedWhenHover;
        protected bool pointerExitThenUnselect = true;

        protected bool nonPersistentNavigationEventAdded;

        #region InterFace Implementation
        public virtual void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                OnClick();
            else if (eventData.button == PointerEventData.InputButton.Right)
                clickEvent.onRightClick?.Invoke();
            else if (eventData.button == PointerEventData.InputButton.Middle)
                clickEvent.onMiddleClick?.Invoke();
        }
        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            hovering = true;
            OnEnter();
        }
        public virtual void OnPointerExit(PointerEventData eventData)
        {
            hovering = false;
            pressing = false;
            OnExit();
        }
        public virtual void OnPointerDown(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                pressing = true;
                OnDown();
            }
        }
        public virtual void OnPointerUp(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                pressing = false;
                OnUp();
            }
        }
        public virtual void OnSubmit(BaseEventData eventData)
        {
            OnSubmit();
        }
        public virtual void OnSelect(BaseEventData eventData)
        {
            selected = true;
            if (eventData is not PointerEventData || !hovering)
            {
                OnSelect(eventData is AxisEventData || UserInput.NextSelectionIsAxis);
                UserInput.NextSelectionIsAxis = false;
            }
        }
        public virtual void OnDeselect(BaseEventData eventData)
        {
            selected = false;
            OnDeselect();
        }
        public virtual void OnMove(AxisEventData eventData)
        {
            OnNavigation(eventData);
        }
        #endregion

        #region Input Control

        protected virtual void Awake()
        {
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Unselected, StatusMode.Normal, Selectable.interactable);

            HoverOff(true);
        }

        protected virtual void OnDisable()
        {
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Unselected, StatusMode.Normal, Selectable.interactable);
        }

        /// <summary>
        /// 仅被鼠标点击触发；
        /// </summary>
        protected virtual void OnClick()
        {
            AudioManager.PlaySE(Selectable.interactable ? SoundLabelClick : SoundLabelClickInactive);
            if (SetToResponser)
            {
                if (Program.instance.ui_.currentPopupB != null)
                    Program.instance.ui_.currentPopupB.lastSelectable = m_Selectable;
                else
                    Program.instance.currentServant.Selected = Selectable;
            }
            clickEvent.onLeftClick?.Invoke();
        }

        /// <summary>
        /// 选中时，键盘回车、手柄A键触发
        /// </summary>
        protected virtual void OnSubmit()
        {
            AudioManager.PlaySE(Selectable.interactable ? SoundLabelClick : SoundLabelClickInactive);
        }

        /// <summary>
        /// 鼠标进入时触发
        /// 调用HoverOn();
        /// </summary>
        protected virtual void OnEnter()
        {
            HoverOn();
            AudioManager.PlaySE(SoundLabelPointerEnter);
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(selected ? SelectMode.Selected : SelectMode.Unselected, StatusMode.Enter, Selectable.interactable);
            if (selectedWhenHover)
                EventSystem.current.SetSelectedGameObject(gameObject);
        }

        /// <summary>
        /// 鼠标离开时触发，鼠标未锁定时，自动取消所有物品的选中状态
        /// 调用HoverOff();
        /// </summary>
        protected virtual void OnExit()
        {
            if (pointerExitThenUnselect)
                if (Cursor.lockState == CursorLockMode.None)
                    if(EventSystem.current.currentSelectedGameObject == gameObject)
                            EventSystem.current.SetSelectedGameObject(null);
            HoverOff();
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(selected ? SelectMode.Selected : SelectMode.Unselected, StatusMode.Normal, Selectable.interactable);
        }

        /// <summary>
        /// 鼠标按下时触发
        /// </summary>
        protected virtual void OnDown()
        {
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(selected ? SelectMode.Selected : SelectMode.Unselected, StatusMode.Down, Selectable.interactable);
        }

        /// <summary>
        /// 鼠标抬起时触发
        /// </summary>
        protected virtual void OnUp()
        {
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(selected ? SelectMode.Selected : SelectMode.Unselected, hovering ? StatusMode.Enter : StatusMode.Normal, Selectable.interactable);
        }

        /// <summary>
        /// 手柄方向键选中时触发
        /// 调用HoverOn();
        /// </summary>
        /// <param name="playSE">是否播放选中音效</param>
        protected virtual void OnSelect(bool playSE)
        {
            HoverOn();
            if (playSE)
                AudioManager.PlaySE(SoundLabelSelectedGamePad);
            if (SetToResponser)
            {
                if (Program.instance.ui_.currentPopupB != null)
                    Program.instance.ui_.currentPopupB.lastSelectable = m_Selectable;
                else
                    Program.instance.currentServant.Selected = Selectable;
            }

            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Selected, hovering ? StatusMode.Enter : StatusMode.Normal, Selectable.interactable);
        }

        /// <summary>
        /// 脱离选中时触发
        /// 调用HoverOff();
        /// </summary>
        protected virtual void OnDeselect()
        {
            HoverOff();
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Unselected, hovering ? StatusMode.Enter : StatusMode.Normal, Selectable.interactable);
        }

        #endregion

        #region Input Reaction

        /// <summary>
        /// 鼠标进入或者被选中时触发；
        /// 调用HoverEvent()。
        /// </summary>
        protected virtual void HoverOn()
        {
            if (hoverd)
                return;
            hoverd = true;

            foreach (var tween in hoverOffTweens)
                if (tween.IsActive())
                    tween.Kill();
            hoverOffTweens.Clear();

            var selectCursorOffset = Manager.GetElement("SelectCursorOffset");
            if (selectCursorOffset != null)
            {
                if(selectCursorOffset.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 1.0f;
                if(selectCursorOffset.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DORestart();
            }

            var corner = Manager.GetElement("Corner");
            if (corner != null)
            {
                var cornerRect = Manager.GetElement<RectTransform>("Corner");
                cornerRect.offsetMin = new Vector2(-16f, -16f);
                cornerRect.offsetMax = new Vector2(16f, 16f);
                var tween1 = cornerRect.DOSizeDelta(new Vector2(0f, 0f), 0.2f).SetEase(Ease.OutQuart);
                hoverOnTweens.Add(tween1);
            }

            var hover = Manager.GetElement("Hover");
            if (hover != null)
            {
                if (hover.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 1.0f;
                if (hover.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DORestart();
            }

            CallHoverOnEvent();
        }

        /// <summary>
        /// 鼠标离开或脱离选中状态时触发
        /// </summary>
        protected virtual void HoverOff(bool forced = false)
        {
            if(forced)
                if (!hoverd)
                    return;

            hoverd = false;

            foreach (var tween in hoverOnTweens)
                if (tween.IsActive())
                    tween.Kill();
            hoverOnTweens.Clear();

            var selectCursorOffset = Manager.GetElement("SelectCursorOffset");
            if (selectCursorOffset != null)
            {
                if (selectCursorOffset.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DOPause();
                if (selectCursorOffset.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 0.0f;
            }

            var hover = Manager.GetElement("Hover");
            if (hover != null)
            {
                if (hover.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DOPause();
                if (hover.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 0.0f;
            }

            CallHoverOffEvent();
        }

        protected virtual void CallHoverOnEvent()
        {
            hoverEvent.onHoverOff?.Invoke();
        }

        protected virtual void CallHoverOffEvent()
        {
            hoverEvent.onHoverOff?.Invoke();
        }

        #endregion

        #region Public Function

        public virtual void SetClickEvent(UnityAction call)
        {
            if (Selectable is Button button)
                button.onClick.AddListener(call);
            else
                clickEvent.onLeftClick.AddListener(call);
        }

        public virtual void SetRightClickEvent(UnityAction call)
        {
            clickEvent.onRightClick.AddListener(call);
        }

        public virtual void SetMiddleClickEvent(UnityAction call)
        {
            clickEvent.onMiddleClick.AddListener(call);
        }

        public virtual void RemoveAllListeners()
        {
            if (Selectable is Button button)
                button.onClick.RemoveAllListeners();
        }

        public virtual void SetNavigationEvent(MoveDirection direction, UnityAction call)
        {
            nonPersistentNavigationEventAdded = true;
            switch (direction)
            {
                case MoveDirection.Left:
                    navigationEvent.onLeftNavigation.AddListener(call);
                    break;
                case MoveDirection.Right:
                    navigationEvent.onRightNavigation.AddListener(call);
                    break;
                case MoveDirection.Up:
                    navigationEvent.onUpNavigation.AddListener(call);
                    break;
                case MoveDirection.Down:
                    navigationEvent.onDownNavigation.AddListener(call);
                    break;
            }
        }

        public virtual void SetButtonText(string title)
        {
            var buttonText = Manager.GetElement("ButtonText");
            if (buttonText != null && buttonText.TryGetComponent<TextMeshProUGUI>(out var text))
                text.text = title;
        }

        public virtual string GetButtonText()
        {
            var buttonText = Manager.GetElement("ButtonText");
            if (buttonText != null && buttonText.TryGetComponent<TextMeshProUGUI>(out var text))
                return text.text;
            return string.Empty;
        }

        public virtual Sprite GetIconSprite()
        {
            var icon = Manager.GetElement("Icon");
            if (icon != null)
            {
                if (icon.TryGetComponent<Image>(out var image))
                    return image.sprite;
                else
                    return null;
            }
            return null;
        }

        public virtual void SetIconSprite(Sprite sprite)
        {
            var icon = Manager.GetElement<Image>("Icon");
            if (icon == null)
                return;
            icon.sprite = sprite;
        }

        public virtual void SetHoverOnEvent(UnityAction call)
        {
            hoverEvent.onHoverOn.AddListener(call);
        }
        public virtual void SetHoverOffEvent(UnityAction call)
        {
            hoverEvent.onHoverOff.AddListener(call);
        }

        #endregion

        #region Navigation

        /// <summary>
        /// 选中时响应方向键；
        /// 注册了对应方向的SelectionButtonNavigationEvent就执行Event并返回。
        /// 如果manuallySetNavigation，即手动设置了Selectable的Navigation，就链式选中对应方向上的激活按钮（自动跳过未激活按钮）；
        /// 否则，依照GetRowsNum() GetColumnsNum() GetButtonsCount()获取的行列数和按钮总数自动导航。
        /// </summary>
        /// <param name="eventData"></param>
        protected virtual void OnNavigation(AxisEventData eventData)
        {
            if (eventData.moveDir == MoveDirection.Up)
            {
                if (navigationEvent.onUpNavigation.GetPersistentEventCount() > 0
                    || nonPersistentNavigationEventAdded)
                {
                    navigationEvent.onUpNavigation.Invoke();
                    return;
                }
            }
            else if (eventData.moveDir == MoveDirection.Down)
            {
                if (navigationEvent.onDownNavigation.GetPersistentEventCount() > 0
                    || nonPersistentNavigationEventAdded)
                {
                    navigationEvent.onDownNavigation.Invoke();
                    return;
                }
            }
            else if (eventData.moveDir == MoveDirection.Left)
            {
                if (navigationEvent.onLeftNavigation.GetPersistentEventCount() > 0
                    || nonPersistentNavigationEventAdded)
                {
                    navigationEvent.onLeftNavigation.Invoke();
                    return;
                }
            }
            else if (eventData.moveDir == MoveDirection.Right)
            {
                if (navigationEvent.onRightNavigation.GetPersistentEventCount() > 0
                    || nonPersistentNavigationEventAdded)
                {
                    navigationEvent.onRightNavigation.Invoke();
                    return;
                }
            }

            if (manuallySetNavigation)
            {
                if (eventData.moveDir == MoveDirection.Left && Selectable.navigation.selectOnLeft != null && !Selectable.navigation.selectOnLeft.gameObject.activeSelf)
                {
                    var nextSeletable = Selectable.navigation.selectOnLeft;
                    while (nextSeletable != null && !nextSeletable.gameObject.activeSelf)
                        nextSeletable = GetNextSelectable(nextSeletable, MoveDirection.Left);
                    if (nextSeletable != null)
                    {
                        UserInput.NextSelectionIsAxis = true;
                        EventSystem.current.SetSelectedGameObject(nextSeletable.gameObject);
                    }
                }
                else if (eventData.moveDir == MoveDirection.Right && Selectable.navigation.selectOnRight != null && !Selectable.navigation.selectOnRight.gameObject.activeSelf)
                {
                    var nextSeletable = Selectable.navigation.selectOnRight;
                    while (nextSeletable != null && !nextSeletable.gameObject.activeSelf)
                        nextSeletable = GetNextSelectable(nextSeletable, MoveDirection.Right);
                    if (nextSeletable != null)
                    {
                        UserInput.NextSelectionIsAxis = true;
                        EventSystem.current.SetSelectedGameObject(nextSeletable.gameObject);
                    }
                }
                else if (eventData.moveDir == MoveDirection.Up && Selectable.navigation.selectOnUp != null && !Selectable.navigation.selectOnUp.gameObject.activeSelf)
                {
                    var nextSeletable = Selectable.navigation.selectOnUp;
                    while (nextSeletable != null && !nextSeletable.gameObject.activeSelf)
                        nextSeletable = GetNextSelectable(nextSeletable, MoveDirection.Up);
                    if (nextSeletable != null)
                    {
                        UserInput.NextSelectionIsAxis = true;
                        EventSystem.current.SetSelectedGameObject(nextSeletable.gameObject);
                    }
                }
                else if (eventData.moveDir == MoveDirection.Down && Selectable.navigation.selectOnDown != null && !Selectable.navigation.selectOnDown.gameObject.activeSelf)
                {
                    var nextSeletable = Selectable.navigation.selectOnDown;
                    while (nextSeletable != null && !nextSeletable.gameObject.activeSelf)
                        nextSeletable = GetNextSelectable(nextSeletable, MoveDirection.Down);
                    if (nextSeletable != null)
                    {
                        UserInput.NextSelectionIsAxis = true;
                        EventSystem.current.SetSelectedGameObject(nextSeletable.gameObject);
                    }
                }
            }
            else
            {
                var selfIndex = index;
                if (selfIndex < 0)
                    selfIndex = transform.GetSiblingIndex();

                var count = GetButtonsCount();
                var columes = GetColumnsCount();

                var targetIndex = selfIndex + 1;

                if (eventData.moveDir == MoveDirection.Left)
                {
                    if (selfIndex % columes == 0)
                    {
                        OnNavigationLeftBorder();
                        return;
                    }
                    targetIndex = selfIndex - 1;
                }
                else if (eventData.moveDir == MoveDirection.Right)
                {
                    if (selfIndex % columes == columes - 1
                        || targetIndex >= count)
                    {
                        OnNavigationRightBorder();
                        return;
                    }
                }
                else if (eventData.moveDir == MoveDirection.Up)
                {
                    targetIndex = selfIndex - columes;
                    if (targetIndex < 0)
                    {
                        OnNavigationUpBorder();
                        return;
                    }
                }
                else if (eventData.moveDir == MoveDirection.Down)
                {
                    var lastLineLeft = count % columes;
                    var bound = count - lastLineLeft - 1;
                    if (lastLineLeft == 0)
                        bound -= columes;
                    if (selfIndex > bound)
                    {
                        OnNavigationDownBorder();
                        return;
                    }
                    targetIndex = selfIndex + columes;
                    if (targetIndex >= count)
                        targetIndex = count - 1;
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
        }

        protected Selectable GetNextSelectable(Selectable selectable, MoveDirection direction)
        {
            return direction switch
            {
                MoveDirection.Left => selectable.navigation.selectOnLeft,
                MoveDirection.Right => selectable.navigation.selectOnRight,
                MoveDirection.Up => selectable.navigation.selectOnUp,
                MoveDirection.Down => selectable.navigation.selectOnDown,
                _ => null,
            };
        }

        protected virtual int GetColumnsCount()
        {
            return 1;
        }

        protected virtual int GetButtonsCount()
        {
            return transform.parent.childCount;
        }

        protected virtual void OnNavigationLeftBorder()
        {
        }

        protected virtual void OnNavigationRightBorder()
        {
        }

        protected virtual void OnNavigationUpBorder()
        {
        }

        protected virtual void OnNavigationDownBorder()
        {
        }
        #endregion

    }

    [Serializable]
    public class SelectionButtonNavigationEvent
    {
        public UnityEvent onLeftNavigation;
        public UnityEvent onRightNavigation;
        public UnityEvent onUpNavigation;
        public UnityEvent onDownNavigation;
    }

    [Serializable]
    public class SelectionButtonHoverEvent
    {
        public UnityEvent onHoverOn;
        public UnityEvent onHoverOff;
    }

    [Serializable]
    public class SelectionClickEvent
    {
        public UnityEvent onLeftClick;
        public UnityEvent onMiddleClick;
        public UnityEvent onRightClick;
    }
}

