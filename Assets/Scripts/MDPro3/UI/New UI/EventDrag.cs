using Spine;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class EventDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public Action<PointerEventData> onBeginDrag;
        public Action<PointerEventData> onEndDrag;
        public Action<PointerEventData> onDrag;
        public Action<PointerEventData> onClick;
        public Action<PointerEventData> onPointerDown;
        public Action<PointerEventData> onPointUp;
        public Action<PointerEventData> onBeginDragRight;
        public Action<PointerEventData> onEndDragRight;
        public Action<PointerEventData> onDragRight;
        public Action<PointerEventData> onClickRight;
        public Action<PointerEventData> onPointerDownRight;
        public Action<PointerEventData> onPointUpRight;
        public Action<PointerEventData> onPointerEnter;
        public Action<PointerEventData> onPointerExit;

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                onBeginDrag?.Invoke(eventData);
            else if (eventData.button == PointerEventData.InputButton.Right)
                onBeginDragRight?.Invoke(eventData);
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                onDrag?.Invoke(eventData);
            else if (eventData.button == PointerEventData.InputButton.Right)
                onDragRight?.Invoke(eventData);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                onEndDrag?.Invoke(eventData);
            else if (eventData.button == PointerEventData.InputButton.Right)
                onEndDragRight?.Invoke(eventData);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                onClick?.Invoke(eventData);
            else if (eventData.button == PointerEventData.InputButton.Right)
                onClickRight?.Invoke(eventData);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                onPointerDown?.Invoke(eventData);
            else if (eventData.button == PointerEventData.InputButton.Right)
                onPointerDownRight?.Invoke(eventData);
        }


        public void OnPointerUp(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                onPointUp?.Invoke(eventData);
            else if (eventData.button == PointerEventData.InputButton.Right)
                onPointUpRight?.Invoke(eventData);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            onPointerEnter?.Invoke(eventData);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            onPointerExit?.Invoke(eventData);
        }

    }
}
