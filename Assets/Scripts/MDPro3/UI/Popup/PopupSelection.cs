using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupSelection : PopupBase
    {
        [Header("Popup Select Reference")]
        public RectTransform backTop;
        public RectTransform backBotton;
        public ScrollRect scrollRect;

        public Action returnAction;
        public Action closeAction;

        public override void InitializeSelections()
        {
            base.InitializeSelections();

            var sizeDelta = new Vector2(-10, 16 + (selections.Count - 1) * 90);
            if (sizeDelta.y > 825)
                sizeDelta.y = 825;
            var rect = scrollRect.GetComponent<RectTransform>();
            rect.sizeDelta = sizeDelta;
            backTop.sizeDelta = new Vector2(backTop.sizeDelta.x, (1100 - sizeDelta.y) / 2);
            backBotton.sizeDelta = new Vector2(backBotton.sizeDelta.x, (1100 - sizeDelta.y) / 2);

            var handle = Addressables.LoadAssetAsync<GameObject>("PopupSelectionItem");
            handle.Completed += (result) =>
            {
                var superScrollView = new SuperScrollView
                (
                1,
                750,
                90,
                16,
                0,
                result.Result,
                ItemOnListRefresh,
                scrollRect
                );
                var tasks = new List<string[]>();
                for (int i = 1; i < selections.Count; i++)
                {
                    var task = new string[] { selections[i] };
                    tasks.Add(task);
                }
                superScrollView.Print(tasks);
            };
        }

        void OnClick()
        {
            AudioManager.PlaySE("SE_MENU_DECIDE");
            returnAction?.Invoke();
            Hide();
        }

        public override void Hide()
        {
            if (shadow != null)
                shadow.DOFade(0f, transitionTime);
            var servant = Program.instance.currentServant;
            window.DOAnchorPos(new Vector2(0f, -1100f), transitionTime).OnComplete(() =>
            {
                Destroy(gameObject);
                servant.returnAction = null;
                closeAction?.Invoke();
                Program.instance.ui_.currentPopup = lastPopup;
                if (lastPopup == null && Cursor.lockState == CursorLockMode.Locked)
                    Program.instance.currentServant.SelectLastSelectable();
            });

        }

        public void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SuperScrollViewItemForSelection>();
            handler.selection = task[0];
            handler.onClick = OnClick;
            handler.Refresh();
        }
    }
}
