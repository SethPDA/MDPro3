using DG.Tweening;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle : SelectionButton
    {
        [Header("Selection Toggle")]
        [SerializeField] protected string SoundLabelClickOn;
        [SerializeField] protected string SoundLabelClickOff;
        [SerializeField] protected SelectionToggleEvent toggleEvent;
        [SerializeField] protected SelectionSubmitEvent submitEvent;

        [HideInInspector] public bool isOn;
        protected bool toggled;
        protected bool exclusiveToggle;
        protected bool exclusiveCallOffEvent = true;
        protected bool canToggleOffSelf = true;
        protected bool toggleWhenSelected;

        #region Input Control

        protected override void Awake()
        {
            base.Awake();
            ToggleOff();
        }

        protected override void OnClick()
        {
            if (SetToResponser)
            {
                if (Program.instance.ui_.currentPopupB != null)
                    Program.instance.ui_.currentPopupB.lastSelectable = Selectable;
                else
                    Program.instance.currentServant.Selected = Selectable;
            }

            if (toggled)
            {
                if (canToggleOffSelf)
                {
                    AudioManager.PlaySE(SoundLabelClickOff);
                    SetToggleOff();
                }
                else
                {
                    AudioManager.PlaySE(Selectable.interactable ? SoundLabelClick : SoundLabelClickInactive);
                    CallSubmitEvent();
                }
            }
            else
            {
                if (canToggleOffSelf)
                    AudioManager.PlaySE(SoundLabelClickOn);
                else
                    AudioManager.PlaySE(Selectable.interactable ? SoundLabelClick : SoundLabelClickInactive);
                SetToggleOn();
            }
        }

        protected override void OnSubmit()
        {
            if (toggled)
            {
                if (canToggleOffSelf)
                {
                    AudioManager.PlaySE(SoundLabelClickOff);
                    SetToggleOff();
                }
                else
                {
                    AudioManager.PlaySE(Selectable.interactable ? SoundLabelClick : SoundLabelClickInactive);
                    CallSubmitEvent();
                }
            }
            else
            {
                if (canToggleOffSelf)
                    AudioManager.PlaySE(SoundLabelClickOn);
                else
                    AudioManager.PlaySE(Selectable.interactable ? SoundLabelClick : SoundLabelClickInactive);

                SetToggleOn();
            }
        }

        protected override void OnSelect(bool playSE)
        {
            base.OnSelect(playSE);
            if (toggleWhenSelected)
                SetToggleOn();
        }

        #endregion

        #region Input Reaction

        protected virtual void ToggleOn()
        {
            if (toggled)
                return;

            var selectCursorOffset = Manager.GetElement("SelectCursorOffset");
            if (selectCursorOffset != null)
            {
                if (selectCursorOffset.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 1.0f;
                if (selectCursorOffset.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DORestart();
            }

            var on = Manager.GetElement("On");
            if (on != null)
                on.SetActive(true);
            var off = Manager.GetElement("Off");
            if (off != null)
                off.SetActive(false);

            var hoverOn = Manager.GetElement("HoverOn");
            if (hoverOn != null)
            {
                if(hoverOn.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 1.0f;
                if(hoverOn.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DORestart();
            }

            var iconOn = Manager.GetElement("IconOn");
            if (iconOn != null)
                iconOn.SetActive(true);

            var iconOff = Manager.GetElement("IconOff");
            if (iconOff != null)
                iconOff.SetActive(false);
        }

        protected virtual void ToggleOff()
        {
            var selectCursorOffset = Manager.GetElement("SelectCursorOffset");
            if (selectCursorOffset != null)
            {
                if (selectCursorOffset.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 1.0f;
                if (selectCursorOffset.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DORestart();
            }

            var on = Manager.GetElement("On");
            if (on != null)
                on.SetActive(false);
            var off = Manager.GetElement("Off");
            if(off != null)
                off.SetActive(true);

            var hoverOff = Manager.GetElement("HoverOff");
            if (hoverOff != null)
            {
                if (hoverOff.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 1.0f;
                if (hoverOff.TryGetComponent<DOTweenAnimation>(out var animation))
                    animation.DORestart();
            }

            var iconOn = Manager.GetElement("IconOn");
            if (iconOn != null)
                iconOn.SetActive(false);

            var iconOff = Manager.GetElement("IconOff");
            if (iconOff != null)
                iconOff.SetActive(true);
        }

        protected override void HoverOn()
        {
            if (hoverd)
                return;
            base.HoverOn();

            if (isOn)
            {
                var hoverOn = Manager.GetElement("HoverOn");
                if (hoverOn != null)
                {
                    if(hoverOn.TryGetComponent<CanvasGroup>(out var cg))
                        cg.alpha = 1.0f;
                    if(hoverOn.TryGetComponent <DOTweenAnimation>(out var animation))
                        animation.DORestart();
                }
            }
            else
            {
                var hoverOff = Manager.GetElement("HoverOff");
                if (hoverOff != null)
                {
                    if (hoverOff.TryGetComponent<CanvasGroup>(out var cg))
                        cg.alpha = 1.0f;
                    if (hoverOff.TryGetComponent<DOTweenAnimation>(out var animation))
                        animation.DORestart();
                }
            }
        }

        protected override void HoverOff(bool force = false)
        {
            if (!hoverd)
                return;
            base.HoverOff();

            if (isOn)
            {
                var hoverOn = Manager.GetElement("HoverOn");
                if (hoverOn != null)
                {
                    if (hoverOn.TryGetComponent<DOTweenAnimation>(out var animation))
                        animation.DOPause();
                    if (hoverOn.TryGetComponent<CanvasGroup>(out var cg))
                        cg.alpha = 0.0f;
                }
            }
            else
            {
                var hoverOff = Manager.GetElement("HoverOff");
                if (hoverOff != null)
                {
                    if (hoverOff.TryGetComponent<DOTweenAnimation>(out var animation))
                        animation.DOPause();
                    if (hoverOff.TryGetComponent<CanvasGroup>(out var cg))
                        cg.alpha = 0.0f;
                }
            }
        }

        protected virtual void CallToggleOnEvent()
        {
            toggleEvent.onToggleOn?.Invoke();

            if (exclusiveToggle)
            {
                for (int i = 0; i < transform.parent.childCount; i++)
                {
                    if (!transform.parent.GetChild(i).TryGetComponent<SelectionToggle>(out var toggle))
                        continue;
                    if (toggle != this)
                        toggle.SetToggleOff(exclusiveCallOffEvent);
                }
            }
        }
        protected virtual void CallToggleOffEvent()
        {
            toggleEvent.onToggleOff?.Invoke();
        }
        protected virtual void CallSubmitEvent()
        {
            submitEvent.onSubmit?.Invoke();
        }

        #endregion

        #region Public Function

        public virtual void SetToggleOn(bool callEvent = true)
        {
            ToggleOn();

            toggled = true;
            isOn = true;
            if(callEvent)
                CallToggleOnEvent();
        }

        public virtual void SetToggleOff(bool callEvent = true)
        {
            toggled = false;
            isOn = false;
            ToggleOff();
            if(callEvent)
                CallToggleOffEvent();
        }

        public virtual void SwitchToggle()
        {
            if (isOn)
            {
                AudioManager.PlaySE(SoundLabelClickOff);
                SetToggleOff();
            }
            else
            {
                AudioManager.PlaySE(SoundLabelClickOn);
                SetToggleOn();
            }
        }

        public virtual void SetToggleOnEvent(UnityAction call)
        {
            toggleEvent.onToggleOn.AddListener(call);
        }
        public virtual void SetToggleOffEvent(UnityAction call)
        {
            toggleEvent.onToggleOff.AddListener(call);
        }
        public virtual void SetSubmitEvent(UnityAction call)
        {
            submitEvent.onSubmit.AddListener(call);
        }

        public override void SetButtonText(string title)
        {
            base.SetButtonText(title);
            var buttonTextOn = Manager.GetElement("TextOn");
            if (buttonTextOn != null && buttonTextOn.TryGetComponent<TextMeshProUGUI>(out var textOn))
                textOn.text = title;
            var buttonTextOff = Manager.GetElement("TextOff");
            if (buttonTextOff != null && buttonTextOff.TryGetComponent<TextMeshProUGUI>(out var textOff))
                textOff.text = title;
        }

        public virtual void SetToggleText(string titleOn, string titleOff)
        {
            var buttonTextOn = Manager.GetElement("TextOn");
            if (buttonTextOn != null && buttonTextOn.TryGetComponent<TextMeshProUGUI>(out var textOn))
                textOn.text = titleOn;
            var buttonTextOff = Manager.GetElement("TextOff");
            if (buttonTextOff != null && buttonTextOff.TryGetComponent<TextMeshProUGUI>(out var textOff))
                textOff.text = titleOff;
        }

        public override string GetButtonText()
        {
            var returnValue = base.GetButtonText();
            if (returnValue != string.Empty)
                return returnValue;

            var buttonText = Manager.GetElement("TextOn");
            if (buttonText != null && buttonText.TryGetComponent<TextMeshProUGUI>(out var textOn))
                returnValue = textOn.text;
            if(returnValue != string.Empty) 
                return returnValue;

            buttonText = Manager.GetElement("TextOff");
            if (buttonText != null && buttonText.TryGetComponent<TextMeshProUGUI>(out var textOff))
                returnValue = textOff.text;
            if (returnValue != string.Empty)
                return returnValue;

            return string.Empty;
        }

        #endregion
    }

    [Serializable]
    public class SelectionToggleEvent
    {
        public UnityEvent onToggleOn;
        public UnityEvent onToggleOff;
    }

    [Serializable]
    public class SelectionSubmitEvent
    {
        public UnityEvent onSubmit;
    }
}
