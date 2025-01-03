using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace MDPro3.UI
{
    public class UIHandler : MonoBehaviour
    {
        [Header("UI Handler")]
        public CanvasGroup cg;
        public Image shadow;
        public RectTransform window;

        public bool showing;
        public bool inTransition;
        public float transitionTime = 0.3f;
        public float shadowColor = 0.75f;

        public virtual void Initialize()
        {
            showing = false;
            inTransition = false;
            if(cg != null )
            {
                cg.alpha = 0f;
                cg.blocksRaycasts = false;
            }
            if(shadow != null )
            {
                shadow.color = Color.clear;
            }
        }
        public virtual void PerframeFunction()
        {

        }

        public virtual void Show()
        {
            showing = true;
            inTransition = true;
            if (cg != null)
            {
                cg.alpha = 1f;
                cg.blocksRaycasts = true;
            }
            if(shadow != null)
            {
                shadow.DOFade(shadowColor, transitionTime);
            }
            DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
            {
                inTransition = false;
            });
        }

        public virtual void Hide()
        {
            inTransition = true;
            if (shadow != null)
            {
                shadow.DOFade(0f, transitionTime);
                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    if(cg != null)
                    {
                        cg.alpha = 0f;
                        cg.blocksRaycasts = false;
                    }
                    showing = false;
                    inTransition = false;
                });
            }
        }
    }
}
