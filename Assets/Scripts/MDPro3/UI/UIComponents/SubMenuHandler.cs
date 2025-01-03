using DG.Tweening;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SubMenuHandler : SidePanel
    {
        [Header("SubMenu Panel")]

        public ScrollRect scrollRect;

        public void Show(List<string> menus, List<Action> actions)
        {
            base.Show();
            Clear();
            var height = -30f;
            for (int i = 0; i < menus.Count; i++)
            {
                var text = menus[i];
                var action = actions[i];
                var currentHeight = height;
                if (action == null)
                {
                    var handle = Addressables.InstantiateAsync("SubMenuTitle");
                    handle.Completed += (result) =>
                    {
                        var rect = result.Result.GetComponent<RectTransform>();
                        rect.SetParent(scrollRect.content, false);
                        rect.anchoredPosition = new Vector2(0f, currentHeight);
                        rect.GetComponent<Text>().text = text;
                    };
                }
                else
                {
                    var handle = Addressables.InstantiateAsync("SubMenuButton");
                    handle.Completed += (result) =>
                    {
                        var rect = result.Result.GetComponent<RectTransform>();
                        rect.SetParent(scrollRect.content, false);
                        rect.anchoredPosition = new Vector2(0f, currentHeight);
                        rect.GetChild(0).GetComponent<Button>().onClick.AddListener(() => { action.Invoke(); });
                        rect.GetChild(0).GetComponent<Button>().onClick.AddListener(() => Hide());
                        rect.GetChild(0).GetChild(0).GetComponent<Text>().text = text;
                    };
                }
                if (action == null)
                {
                    height -= 80f;
                }
                else
                {
                    height -= 90f;
                }
            }

            height -= 30f;
            scrollRect.content.sizeDelta = new Vector2(0, -height);
            scrollRect.verticalScrollbar.value = 1f;
        }

        private void Clear()
        {
            scrollRect.content.DestroyAllChildren();
        }
    }
}
