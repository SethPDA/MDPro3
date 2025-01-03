using DG.Tweening;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.UI;

namespace MDPro3.UI
{
    [RequireComponent(typeof(Button))]
    public class SelectionButton_Setting : SelectionButton
    {
        [Header("Setting")]
        [SerializeField] Slider slider;
        [SerializeField] RectTransform arrow;
        [SerializeField] TextMeshProUGUI modeText;
        [SerializeField] TextMeshProUGUI noteText;

        public void SetModeText(string text)
        {
            if (modeText == null)
            {
#if UNITY_EDITOR
                Debug.LogError("No TextMeshProUGUI to Set mode text.");
#endif
                return;
            }
            modeText.text = text;
        }

        public string GetModeText()
        {
            if (modeText == null)
            {
#if UNITY_EDITOR
                Debug.LogError("No TextMeshProUGUI to Get mode text.");
#endif
                return string.Empty;
            }
            return modeText.text;
        }

        public void SetNoteText(string text)
        {
            if (noteText == null)
            {
#if UNITY_EDITOR
                Debug.LogError("No TextMeshProUGUI to Set note text.");
#endif
                return;
            }
            noteText.text = text;
        }

        public void SetSliderEvent(UnityAction<float> onValueChanged)
        {
            if (slider == null)
            {
#if UNITY_EDITOR
                Debug.LogError("No Slider to Callback.");
#endif
                return;
            }
            slider.onValueChanged.AddListener(onValueChanged);
        }

        public void SetSliderValue(float value)
        {
            if (slider == null)
            {
#if UNITY_EDITOR
                Debug.LogError("No Slider to set value.");
#endif
                return;
            }
            slider.value = value;
        }

        public float GetSliderValue()
        {
            if (slider == null)
            {
#if UNITY_EDITOR
                Debug.LogError("No Slider to get value.");
#endif
                return 0f;
            }
            return slider.value;
        }

        public void SetClickEvent(UnityAction call)
        {
            if(Selectable is Button button)
                button.onClick.AddListener(call);
        }

        protected override void HoverOn()
        {
            if (hoverd)
                return;
            base.HoverOn();

            if(arrow != null)
            {
                arrow.anchoredPosition = new Vector3(-36f, 0f, 0f);
                var tween1 = arrow.DOAnchorPosX(0f, 0.3f).SetEase(Ease.OutCubic);
                hoverOnTweens.Add(tween1);
            }
        }

        protected override void HoverOff(bool force = false)
        {
            base.HoverOff();

            if (arrow != null)
            {
                var tween1 = arrow.DOAnchorPosX(0f, 0.3f).SetEase(Ease.OutCubic);
                hoverOffTweens.Add(tween1);
            }
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            base.OnNavigation(eventData);
            if (slider == null)
                return;

            var addtion = eventData.moveVector.x * slider.maxValue * 0.05f;
            if (slider.wholeNumbers)
                addtion = eventData.moveVector.x;

            slider.value += addtion;
        }

        protected override void OnSelect(bool playSE)
        {
            base.OnSelect(playSE);
            Program.instance.setting.lastSelectedButton = this;
        }
    }
}
