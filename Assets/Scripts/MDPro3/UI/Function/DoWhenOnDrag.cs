using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoWhenOnDrag : MonoBehaviour, IDragHandler
{
    public Action action;

    public void OnDrag(PointerEventData eventData)
    {
        action?.Invoke();
    }
}
