using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupText : PopupBase
    {
        [Header("Popup Select Reference")]
        public RectTransform backTop;
        public RectTransform backBotton;
        public ScrollRect scrollRect;
        public TextMeshProUGUI text;

        public HorizontalAlignmentOptions alignment = HorizontalAlignmentOptions.Center;
        public override void InitializeSelections()
        {
            base.InitializeSelections();
            text.text = selections[1];
            text.GetComponent<ContentSizeFitter>().SetLayoutVertical();
            var height = text.GetComponent<RectTransform>().rect.height;
            if (height > 825)
                height = 825;
            if (height < 300)
                height = 300;
            var sizeDelta = new Vector2(-50, height);
            var rect = scrollRect.GetComponent<RectTransform>();
            rect.sizeDelta = sizeDelta;
            backTop.sizeDelta = new Vector2(backTop.sizeDelta.x, (1100 - sizeDelta.y) / 2);
            backBotton.sizeDelta = new Vector2(backBotton.sizeDelta.x, (1100 - sizeDelta.y) / 2);
            scrollRect.verticalScrollbar.value = 1;

            text.horizontalAlignment = alignment;
        }

        public override void OnCancel()
        {
            base.OnCancel();
            Hide();
        }
    }
}
