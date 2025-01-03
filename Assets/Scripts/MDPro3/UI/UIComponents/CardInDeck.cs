using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class CardInDeck : MonoBehaviour
    {
        public Button button;
        public Image limitIcon;
        public GameObject pickup;
        float startX = -410f;
        float endX = -410f + 690f;
        float[] ys = new float[] { 246f, 136f, 26f, -84f, -253f, -419f };
        float[] ys2 = new float[] { 246f, 136f, 26f, -84f, -253f, -419f };
        public int id;

        public static float moveTime = 0.1f;

        private void Start()
        {
            var drag = button.gameObject.GetComponent<EventDrag>();
            drag.onClick = OnClick;
            drag.onClickRight = OnClickRight;
            drag.onDrag = OnDrag;
            drag.onBeginDrag = OnBeginDrag;
            drag.onEndDrag = OnEndDrag;
            drag.onPointerEnter = OnPointerEnter;
            drag.onPointerExit = OnPointerExit;
        }

        public void RefreshPosition()
        {
            GetComponent<RectTransform>().anchoredPosition = GetPosition();
            transform.localScale = Vector3.one * 1.3f;
            transform.DOScale(Vector3.one, 0.2f);
        }
        public void RefreshPositionInstant()
        {
            GetComponent<RectTransform>().anchoredPosition = GetPosition();
        }
        public Vector2 GetPosition()
        {
            if (Program.instance.currentServant == Program.instance.editDeck)
                startX = Program.instance.editDeck.outerWidth + Program.instance.editDeck.descriptionWidth + Program.instance.editDeck.innerWidth - 910f;
            else
                startX = -410f;
            endX = startX + 690f;
            Vector2 position = Vector2.zero;
            int count = 0;
            if (id < 1000)
            {
                count = Program.instance.editDeck.mainCount;
                if (count <= 40)
                {
                    position.x = startX + (id % 10) * (endX - startX) / 9;
                    position.y = ys[id / 10];
                }
                else
                {
                    int lineCount = (int)Math.Ceiling(count / 4f);
                    position.x = startX + (id % lineCount) * (endX - startX) / (lineCount - 1);
                    position.y = ys[id / lineCount];
                }
            }
            else if (id > 1999)
            {
                count = Program.instance.editDeck.sideCount;
                if (count <= 10)
                    position.x = startX + (id - 2000) * (endX - startX) / 9;
                else
                    position.x = startX + (id - 2000) * (endX - startX) / (count - 1);
                position.y = ys[5];
            }
            else
            {
                count = Program.instance.editDeck.extraCount;
                if (count <= 10)
                    position.x = startX + (id - 1000) * (endX - startX) / 9;
                else
                    position.x = startX + (id - 1000) * (endX - startX) / (count - 1);
                position.y = ys[4];
            }
            return position;
        }

        int m_code;
        public int Code
        {
            get
            {
                return m_code;
            }
            set
            {
                m_code = value;
                RefreshLimitIcon();
                StartCoroutine(RefreshCard());
            }
        }

        bool refreshed;
        IEnumerator RefreshCard()
        {
            refreshed = false;
            while (TextureManager.container == null)
                yield return null;
            GetComponent<RawImage>().texture = TextureManager.container.unknownCard.texture;
            var task = TextureManager.LoadCardAsync(Code, true);
            while (!task.IsCompleted)
                yield return null;

            GetComponent<RawImage>().material = TextureManager.GetCardMaterial(Code, true);
            GetComponent<RawImage>().material.mainTexture = task.Result;
            GetComponent<RawImage>().texture = task.Result;

            refreshed = true;
        }

        public void Dispose()
        {
            StartCoroutine(DisposeAsync());
        }

        IEnumerator DisposeAsync()
        {
            GetComponent<CanvasGroup>().alpha = 0f;
            while (!refreshed)
                yield return null;
            Destroy(gameObject);
        }

        public void RefreshLimitIcon()
        {
            StartCoroutine(RefreshLimitIconAsync());
        }

        IEnumerator RefreshLimitIconAsync()
        {
            while(TextureManager.container == null)
                yield return null;
            var limit = Program.instance.editDeck.banlist.GetQuantity(Code);
            if (limit == 3)
                limitIcon.sprite = TextureManager.container.typeNone;
            else if (limit == 2)
                limitIcon.sprite = TextureManager.container.limit2;
            else if (limit == 1)
                limitIcon.sprite = TextureManager.container.limit1;
            else
                limitIcon.sprite = TextureManager.container.banned;
        }

        public bool picked;
        public void PickUp(bool on)
        {
            Program.instance.editDeck.dirty = true;
            picked = on;
            pickup.SetActive(on);
        }

        public bool dragging;

        void OnClick(PointerEventData eventData)
        {
            AudioManager.PlaySE("SE_DUEL_SELECT");

            if (Program.instance.currentServant == Program.instance.editDeck)
                Program.instance.editDeck.Description(Code, GetComponent<RawImage>().texture, GetComponent<RawImage>().material, true, transform.GetSiblingIndex());
            else
                Program.instance.appearance.PickThis(this);
        }

        void OnClickRight(PointerEventData eventData)
        {
            if (!Program.instance.editDeck.deckIsFromLocalFile
                && Program.instance.editDeck.condition != EditDeck.Condition.ChangeSide)
                return;
            if (Program.instance.currentServant == Program.instance.editDeck)
            {
                if(Program.instance.editDeck.condition == EditDeck.Condition.ChangeSide)
                    Program.instance.editDeck.SwitchSide(this);
                else
                    Program.instance.editDeck.DeleteCard(this);
            }
        }

        void OnBeginDrag(PointerEventData eventData)
        {
            if (!Program.instance.editDeck.deckIsFromLocalFile 
                && Program.instance.editDeck.condition != EditDeck.Condition.ChangeSide)
                return;

            dragging = true;
            transform.localScale = Vector3.one * 1.2f;
            transform.SetSiblingIndex(transform.parent.childCount - 1);
            button.GetComponent<Image>().raycastTarget = false;
        }
        void OnDrag(PointerEventData eventData)
        {
            if (!Program.instance.editDeck.deckIsFromLocalFile
                && Program.instance.editDeck.condition != EditDeck.Condition.ChangeSide)
                return;

            var dragTarget = GetComponent<RectTransform>();
            Vector3 uiPosition;
            RectTransformUtility.ScreenPointToWorldPointInRectangle(
                dragTarget, eventData.position, eventData.enterEventCamera, out uiPosition);
            uiPosition.z = 90f;
            dragTarget.position = uiPosition;
            var anchoredPosition = dragTarget.anchoredPosition3D;
            dragTarget.anchoredPosition3D = (Vector2)anchoredPosition;
        }

        public void Move()
        {
            transform.DOScale(Vector3.one, moveTime);
            GetComponent<RectTransform>().DOAnchorPos3D(GetPosition(), moveTime);
        }

        void OnEndDrag(PointerEventData eventData)
        {
            if (!Program.instance.editDeck.deckIsFromLocalFile
                && Program.instance.editDeck.condition != EditDeck.Condition.ChangeSide)
                return;

            Program.instance.editDeck.RefreshCardID();
            dragging = false;
            button.GetComponent<Image>().raycastTarget = true;
        }

        public bool hover;
        void OnPointerEnter(PointerEventData eventData)
        {
            hover = true;
        }
        void OnPointerExit(PointerEventData eventData)
        {
            hover = false;
        }
    }
}
