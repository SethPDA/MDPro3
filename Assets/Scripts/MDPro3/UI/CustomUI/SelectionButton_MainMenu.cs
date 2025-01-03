using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using YgomSystem.UI;

namespace MDPro3.UI
{
    public class SelectionButton_MainMenu : SelectionButton
    {
        protected override void Awake()
        {
            ElementsReset();
        }

        protected override void OnDisable()
        {
        }

        private void ElementsReset()
        {
            // Out
            Manager.GetElement<CanvasGroup>("Out").alpha = 1f;
            Manager.GetElement<RectTransform>("Line").localScale = Vector3.one;

            // Hover
            Manager.GetElement<CanvasGroup>("Hover").alpha = 0f;
            Manager.GetElement<RectTransform>("PlateTween").localScale = new Vector3(0.5f, 1f, 1f);
            Manager.GetElement<RectTransform>("HoverTextMask").offsetMax = new Vector2(-340f, 0f);
            Manager.GetElement<RectTransform>("Arrow").localPosition = new Vector2(-5f, 0f);

            // Cursor
            Manager.GetElement<RectTransform>("Corner").offsetMin = new Vector2(0f, 0f);
            Manager.GetElement<RectTransform>("Corner").offsetMax = new Vector2(0f, 0f);

            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(ColorContainer.SelectMode.Unselected, ColorContainer.StatusMode.Normal, true);
        }

        protected override void HoverOn()
        {
            if (hoverd)
                return;
            base.HoverOn();

            Manager.GetElement<CanvasGroup>("Out").alpha = 0f;

            Manager.GetElement<RectTransform>("PlateTween").localScale = new Vector3(0.5f, 1f, 1f);
            var tween1 = Manager.GetElement<RectTransform>("PlateTween").DOScaleX(1f, 0.33f).SetEase(Ease.OutQuart);
            hoverOnTweens.Add(tween1);

            Manager.GetElement<DOTweenAnimation>("PlateBlink").DOPlay();

            Manager.GetElement<RectTransform>("HoverTextMask").offsetMax = new Vector2(-340f, 0f);
            Manager.GetElement<RectTransform>("HoverTextMask").DOSizeDelta(Vector2.zero, 0.2f);

            Manager.GetElement<RectTransform>("Arrow").anchoredPosition = new Vector2(-262f, 0f);
            var tween2 = Manager.GetElement<RectTransform>("Arrow").DOAnchorPosX(-5f, 0.33f).SetEase(Ease.OutQuart);
            hoverOnTweens.Add(tween2);
        }

        protected override void HoverOff(bool force = false)
        {
            base.HoverOff();

            Manager.GetElement<CanvasGroup>("Out").alpha = 1f;
            Manager.GetElement<RectTransform>("Line").localScale = new Vector3(7f, 1f, 1f);
            var tween1 = Manager.GetElement<RectTransform>("Line").DOScaleX(1f, 0.4f).SetEase(Ease.OutQuart);
            hoverOffTweens.Add(tween1);

            Manager.GetElement<DOTweenAnimation>("PlateBlink").DOPause();
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            base.OnNavigation(eventData);
            if (eventData.moveVector.y > 0 && Selectable.navigation.selectOnUp != null)
                UserInput.RumbleForUp();
            else if (eventData.moveVector.y < 0 && Selectable.navigation.selectOnDown != null)
                UserInput.RumbleForDown();
        }

        protected override void OnSelect(bool playSE)
        {
            base.OnSelect(playSE);
            Program.instance.menu.lastSelectedButton = this;
        }
    }
}
