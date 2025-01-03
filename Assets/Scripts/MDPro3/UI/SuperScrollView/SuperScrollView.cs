using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

namespace MDPro3.UI
{
    public class SuperScrollView
    {
        public int selected = -1;
        public List<Item> items = new();
        public List<GameObject> gameObjects = new();

        protected int columnCount;
        protected float itemWidth;
        protected float itemHeight;
        protected float topPadding;
        protected float bottomPadding;
        protected int extraShow = 2;

        protected GameObject itemObject;
        protected Action<string[], GameObject> itemOnListRefresh;
        protected ScrollRect scrollRect;
        private RectTransform scrollRectWindow;
        private int maxShow;
        private List<Vector3> childrenPosition = new();
        private int lastHiddenRows = -1;

        public class Item
        {
            public string[] args;
            public GameObject gameObject;
        }

        public SuperScrollView(
            int columnCount,
            float itemWidth,
            float itemHeight,
            float topPadding,
            float bottomPadding,
            GameObject itemObject,
            Action<string[], GameObject> itemOnListRefresh,
            ScrollRect scrollRect,
            int extraShow = 2)
        {
            this.columnCount = columnCount;
            this.itemWidth = itemWidth;
            this.itemHeight = itemHeight;
            this.topPadding = topPadding;
            this.bottomPadding = bottomPadding;
            this.itemObject = itemObject;
            this.itemOnListRefresh = itemOnListRefresh;
            this.scrollRect = scrollRect;
            this.extraShow = extraShow;
            Install();
        }

        private void Install()
        {
            scrollRectWindow = scrollRect.GetComponent<RectTransform>();
            scrollRect.verticalScrollbar.value = 1f;
            scrollRect.verticalScrollbar.onValueChanged.AddListener(OnScrollBarChange);
        }

        public  void Clear()
        {
            foreach(var go in gameObjects)
            {
                if(go.TryGetComponent<SelectionToggle_ScrollRectItem>(out var handler))
                    handler.Dispose();
                else
                    UnityEngine.Object.Destroy(go);
            }
            items.Clear();
            gameObjects.Clear();
            scrollRect.content.sizeDelta = new Vector2(0, 0);
            _columnCount = -1;
        }

        public void ToTop()
        {
            scrollRect.verticalNormalizedPosition = 1f;
        }


        private int _columnCount = -1;
        public int GetColumnCount()
        {
            if (columnCount > 0)
                return columnCount;
            else
            {
                if(_columnCount < 0)
                    _columnCount = (int)Math.Floor(GetContentRectWidth() / itemWidth);
                return _columnCount;
            }
        }

        private float GetContentRectWidth()
        {
            return scrollRectWindow.rect.width - scrollRect.verticalScrollbarSpacing - scrollRect.verticalScrollbar.handleRect.rect.width;
        }

        public int GetRowsCount()
        {
            return (int)MathF.Ceiling(items.Count / (float)GetColumnCount());
        }

        public void Print(List<string[]> tasks)
        {
            Clear();

            for (int i = 0; i < tasks.Count; i++)
            {
                var it = new Item
                {
                    args = tasks[i],
                    gameObject = null
                };
                items.Add(it);
            }
            CalculateChildrenPositon();

            var cc = GetColumnCount();
            scrollRect.content.sizeDelta = new Vector2(0, GetRowsCount() * itemHeight + topPadding + bottomPadding);
            float viewHeight = scrollRectWindow.rect.height;
            var maxShowLines = (int)Math.Ceiling(viewHeight / itemHeight);
            maxShow = cc * (maxShowLines + extraShow);
            if (maxShow > items.Count)
                maxShow = items.Count;
            for (int i = 0; i < maxShow; i++)
            {
                CreateItem(i);
            }
            ToTop();
        }

        private void RefreshLayout(List<GameObject> obs = null)
        {
            var topHiddenHeight = (1f - scrollRect.verticalScrollbar.value) * (scrollRect.content.rect.height - scrollRectWindow.rect.height);
            int hiddenRows = (int)math.floor(topHiddenHeight / itemHeight);

            if (hiddenRows < 0 && obs == null)
                return;
            if (hiddenRows < 0)
                hiddenRows = 0;
            if (hiddenRows > 0)
                hiddenRows--;

            if (hiddenRows == lastHiddenRows)
                return;
            lastHiddenRows = hiddenRows;

            var cc = GetColumnCount();
            int start = hiddenRows * cc;
            int end = start + maxShow; //last one +1
            if (end > items.Count)
            {
                start -= end - items.Count;
                end = items.Count;
            }

            List<GameObject> objects = obs ?? new List<GameObject>();

            bool found = false;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].gameObject == null)
                {
                    if (!found)
                        continue;
                    else
                        break;
                }
                found = true;
                if (i < start || i >= end)
                {
                    objects.Add(items[i].gameObject);
                    items[i].gameObject = null;
                }
            }

            for (int i = start; i < end; i++)
            {
                if (items[i].gameObject == null)
                {
                    items[i].gameObject = objects[0];
                    objects.RemoveAt(0);
                    ItemRefreshPositon(i);
                }
            }

            foreach(var ob in objects)
            {
                gameObjects.Remove(ob);
                UnityEngine.Object.Destroy(ob);
            }
        }

        public void OnScrollBarChange(float value)
        {
            if (items.Count == 0)
                return;

            RefreshLayout();
        }
        private void CreateItem(int i)
        {
            if (items[i].gameObject == null)
            {
                items[i].gameObject = UnityEngine.Object.Instantiate(itemObject);
                items[i].gameObject.SetActive(true);
                items[i].gameObject.transform.SetParent(scrollRect.content, false);
                if(items[i].gameObject.TryGetComponent<SuperScrollViewItem>(out var mono))
                    mono.handler = this;
                gameObjects.Add(items[i].gameObject);
                ItemRefreshPositon(i);
            }
        }
        private void ItemRefreshPositon(int i)
        {
            if (items[i].gameObject == null)
                return;

            items[i].gameObject.GetComponent<RectTransform>().anchoredPosition = childrenPosition[i];

            if (items[i].gameObject.TryGetComponent<SelectionToggle_ScrollRectItem>(out var selection))
            {
                if (i == selected)
                    selection.ToggleOnNow();
                else
                    selection.ToggleOffNow();

                selection.index = i;
            }
            else if (items[i].gameObject.TryGetComponent<SelectionButton>(out var button))
                button.index = i;
            else if (items[i].gameObject.TryGetComponent<SuperScrollViewItem>(out var mono))
                mono.id = i;
            itemOnListRefresh(items[i].args, items[i].gameObject);
        }

        private void CalculateChildrenPositon()
        {
            childrenPosition.Clear();

            var npr = GetColumnCount();

            for (int i = 0; i < items.Count; i++)
            {
                int x = i % npr;
                int y = (int)Math.Floor(i / (float)npr);
                var position = new Vector3(-((float)npr / 2) * itemWidth + (x + 0.5f) * itemWidth,
                -y * itemHeight - topPadding, 0f);
                childrenPosition.Add(position);
            }
        }

        public void Add(string[] args)
        {
            items.Add(new Item
            {
                args = args,
                gameObject = null
            });

            var npr = GetColumnCount();
            scrollRect.content.sizeDelta = new Vector2(0, GetRowsCount() * itemHeight + topPadding + bottomPadding);
            float viewHeight = scrollRectWindow.rect.height;
            var maxShowLines = (int)Math.Ceiling(viewHeight / itemHeight);
            maxShow = npr * (maxShowLines + extraShow);
            if (maxShow > items.Count)
                maxShow = items.Count;

            RefreshLayout();
        }

        public void RemoveAt(int removed)
        {
            if(items.Count <= removed)
                return;
            List<GameObject> objects = new ();
            for(int i = removed; i < items.Count; i++)
            {
                if (items[i].gameObject == null)
                    continue;

                objects.Add(items[i].gameObject);
                items[i].gameObject = null;
            }
            items.RemoveAt(removed);

            var cc = GetColumnCount();
            scrollRect.content.sizeDelta = new Vector2(0, GetRowsCount() * itemHeight + topPadding + bottomPadding);
            var maxShowLines = (int)Math.Ceiling(scrollRectWindow.rect.height / itemHeight);
            maxShow = cc * (maxShowLines + extraShow);
            if (maxShow > items.Count)
                maxShow = items.Count;

            RefreshLayout(objects);
        }

        public void UpdateAt(int id, string[] args)
        {
            items[id].args = args;
            if (items[id].gameObject != null)
                itemOnListRefresh(args, items[id].gameObject);
        }

        public SelectionToggle_ScrollRectItem GetItemByIndex(int index)
        {
            if(index >= items.Count)
                index = items.Count - 1;

            for(int i = index; i >= 0; i--)
            {
                if (items[i].gameObject != null)
                    return items[i].gameObject.GetComponent<SelectionToggle_ScrollRectItem>();
            }
            return null;
        }
    }
}
