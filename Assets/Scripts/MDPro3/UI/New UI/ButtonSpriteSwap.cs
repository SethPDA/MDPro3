using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class ButtonSpriteSwap : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {
        public Image swap;
        public Sprite normalSprite;
        public Sprite hoverSprite;
        public string hoverAudio;

        public void OnPointerEnter(PointerEventData eventData)
        {
            swap.sprite = hoverSprite;
            AudioManager.PlaySE(hoverAudio);
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            swap.sprite = normalSprite;
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            swap.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            swap.color = Color.white;
        }

    }
}
