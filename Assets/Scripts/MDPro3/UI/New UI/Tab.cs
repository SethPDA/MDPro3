using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class Tab : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
    {
        Sprite normalSprite;
        Sprite hoverSprite;
        Sprite selectedSprite;

        public int id;
        public float pressColor = 0.5f;
        public bool selected;
        public Action onSelected;

        public Image icon;
        public Text text;
        public Color iconOffColor = Color.white;
        public Color iconOnColor = Color.black;
        public Color textOffColor = new Color(0, 0, 0, 0);
        public Color textOnColor = Color.black;

        void Awake()
        {
            normalSprite = GetComponent<Image>().sprite;
            hoverSprite = GetComponent<Button>().spriteState.highlightedSprite;
            selectedSprite = GetComponent<Button>().spriteState.selectedSprite;
        }
        void Start()
        {
            if (id == 1)
                TabThis();
        }

        Color iconColor;

        public void OnPointerDown(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                GetComponent<Image>().color = new Color(pressColor, pressColor, pressColor, 1f);
                iconColor = icon.color;
                icon.color = new Color(iconColor.r * pressColor, iconColor.g * pressColor, iconColor.b * pressColor, 1);
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                GetComponent<Image>().color = Color.white;
                icon.color = iconColor;
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            AudioManager.PlaySE("SE_MENU_SELECT_01");
            if (!selected)
                TabThis();
        }

        public void TabThis()
        {
            selected = true;
            transform.parent.GetComponent<Tabs>().Tab(this);
            var state = GetComponent<Button>().spriteState;
            GetComponent<Image>().sprite = selectedSprite;
            state.highlightedSprite = selectedSprite;
            state.pressedSprite = selectedSprite;
            GetComponent<Button>().spriteState = state;
            icon.color = iconOnColor;
            text.color = textOnColor;
            AdjustSize();
            onSelected?.Invoke();
        }

        public void CancelSelect()
        {
            selected = false;
            var state = GetComponent<Button>().spriteState;
            GetComponent<Image>().sprite = normalSprite;
            state.highlightedSprite = hoverSprite;
            state.pressedSprite = hoverSprite;
            GetComponent<Button>().spriteState = state;
            icon.color = iconOffColor;
            text.color = textOffColor;
            AdjustSize();
        }

        public void AdjustSize()
        {
            var parentWidth = transform.parent.GetComponent<RectTransform>().sizeDelta.x;

            if (id == 1)
            {
                if (selected)
                {
                    GetComponent<RectTransform>().sizeDelta = new Vector2((parentWidth - 20) / 2f, 56);
                }
                else
                {
                    GetComponent<RectTransform>().sizeDelta = new Vector2((parentWidth - 20) / 4f, 56);
                }
            }
            else if (id == 2)
            {
                if (selected)
                {
                    GetComponent<RectTransform>().anchoredPosition = new Vector2((parentWidth - 20) / 4f + 10, 0);
                    GetComponent<RectTransform>().sizeDelta = new Vector2((parentWidth - 20) / 2f, 56);
                }
                else
                {
                    GetComponent<RectTransform>().sizeDelta = new Vector2((parentWidth - 20) / 4f, 56);
                    if (transform.parent.GetComponent<Tabs>().tabs[0].selected)
                        GetComponent<RectTransform>().anchoredPosition = new Vector2((parentWidth - 20) / 2f + 10, 0);
                    else
                        GetComponent<RectTransform>().anchoredPosition = new Vector2((parentWidth - 20) / 4f + 10, 0);
                }
            }
            else if (id == 3)
            {
                if (selected)
                {
                    GetComponent<RectTransform>().sizeDelta = new Vector2((parentWidth - 20) / 2f, 56);
                }
                else
                {
                    GetComponent<RectTransform>().sizeDelta = new Vector2((parentWidth - 20) / 4f, 56);
                }
            }

            var width = GetComponent<RectTransform>().sizeDelta.x;
            var iconWidth = icon.GetComponent<RectTransform>().sizeDelta.x;
            //Text 100
            if (selected)
            {
                if (width > iconWidth + 110)
                {
                    var side = width - iconWidth - 110;
                    icon.GetComponent<RectTransform>().anchoredPosition = new Vector2(side / 2f + iconWidth / 2, 0);
                    text.GetComponent<RectTransform>().anchoredPosition = new Vector2(side / 2f + iconWidth + 10 + 50, 0);
                    icon.color = iconOnColor;
                    text.color = textOnColor;
                }
                else if (width > 100)
                {
                    icon.color = new Color(0, 0, 0, 0);
                    text.color = textOnColor;
                    text.GetComponent<RectTransform>().anchoredPosition = new Vector2(width / 2f, 0);
                }
                else
                {
                    icon.color = iconOnColor;
                    text.color = new Color(0, 0, 0, 0);
                    icon.GetComponent<RectTransform>().anchoredPosition = new Vector2(width / 2f, 0);
                }
            }
            else
            {
                icon.GetComponent<RectTransform>().anchoredPosition = new Vector2(width / 2f, 0);
            }

        }
    }
}
