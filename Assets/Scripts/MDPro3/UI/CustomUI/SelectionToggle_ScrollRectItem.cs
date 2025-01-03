using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class SelectionToggle_ScrollRectItem : SelectionToggle
    {
        [HideInInspector] public bool refreshed;
        protected IEnumerator enumerator;
        protected float switchTime = 0.2f;

        protected bool simpleMove = true;

        #region Input Reaction
        protected override void Awake()
        {
            base.Awake();
            exclusiveToggle = true;
            canToggleOffSelf = false;
            toggleWhenSelected = true;
        }

        protected override void ToggleOn()
        {
            base.ToggleOn();
            Manager.GetElement<RectTransform>("Offset").DOAnchorPosX(48f, switchTime).SetEase(Ease.OutQuart);
        }
        protected override void ToggleOff()
        {
            base.ToggleOff();
            Manager.GetElement<RectTransform>("Offset").DOAnchorPosX(0f, switchTime).SetEase(Ease.OutQuart);
        }
        #endregion

        #region Public Function

        public virtual void ToggleOnNow()
        {
            toggled = true;
            isOn = true;
            Manager.GetElement<RectTransform>("Offset").DOAnchorPosX(48f, 0f);
        }
        public virtual void ToggleOffNow()
        {
            toggled = false;
            isOn = false;
            Manager.GetElement<RectTransform>("Offset").DOAnchorPosX(0f, 0f);
        }

        public virtual void Dispose()
        {
            if (enumerator != null)
                StopCoroutine(enumerator);
            Destroy(gameObject);
        }
        public virtual void Refresh()
        {
            if (enumerator != null)
                StopCoroutine(enumerator);
            if (gameObject.activeInHierarchy)
            {
                enumerator = RefreshAsync();
                StartCoroutine(enumerator);
            }
        }
        protected virtual IEnumerator RefreshAsync()
        {
            refreshed = false;
            while (TextureManager.container == null)
                yield return null;

            var face = Manager.GetElement<RawImage>("Image");
            face.texture = TextureManager.container.black.texture;
            face.color = Color.white;

            enumerator = null;
            refreshed = true;
        }

        #endregion

        protected override void OnNavigation(AxisEventData eventData)
        {
            if (simpleMove)
            {
                if (eventData.moveDir == MoveDirection.Up)
                {
                    for (int i = 0; i < transform.parent.childCount; i++)
                    {
                        if (transform.parent.GetChild(i).GetComponent<SelectionToggle_ScrollRectItem>().index == index - 1)
                        {
                            UserInput.NextSelectionIsAxis = true;
                            EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(i).gameObject);
                            break;
                        }
                    }
                }
                else if (eventData.moveDir == MoveDirection.Down)
                {
                    for (int i = 0; i < transform.parent.childCount; i++)
                    {
                        if (transform.parent.GetChild(i).GetComponent<SelectionToggle_ScrollRectItem>().index == index + 1)
                        {
                            UserInput.NextSelectionIsAxis = true;
                            EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(i).gameObject);
                            break;
                        }
                    }
                }
            }
            else
                base.OnNavigation(eventData);
        }

    }
}
