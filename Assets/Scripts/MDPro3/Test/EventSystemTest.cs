using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemTest : MonoBehaviour, IPointerClickHandler, ISelectHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked");
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("Selected");
    }
}
