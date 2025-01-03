using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

namespace MDPro3.UI
{

    public class DoTweenManager : MonoBehaviour
    {
        [SerializeField] private string showID = "Show";
        [SerializeField] private string hideID = "Hide";
        [SerializeField] private bool autoPlay = true;
        [SerializeField] private float shutDownDelay = 0.4f;
        private List<DoTweenInitializer> initializers = new();


        private void Awake()
        {
            foreach (var initializer in transform.GetComponentsInChildren<DoTweenInitializer>())
                initializers.Add(initializer);
        }

        private void OnEnable()
        {
            if (autoPlay)
                Show();
            else
            {
                foreach (var ini in initializers)
                {
                    ini.GetComponent<CanvasGroup>().alpha = ini.hideAlpha;
                    ini.GetComponent<RectTransform>().localScale = ini.hideScale;
                }
            }
        }

        private void OnDisable()
        {
            foreach (var ini in initializers)
                foreach (var tweener in ini.GetComponents<DOTweenAnimation>())
                    tweener.DOKill();
        }

        public void Show()
        {
            foreach(var ini in initializers)
            {
                foreach(var tweener in ini.GetComponents<DOTweenAnimation>())
                    if(tweener.id == showID)
                    {
                        if (tweener.animationType == DOTweenAnimation.AnimationType.Fade)
                            ini.GetComponent<CanvasGroup>().alpha = ini.hideAlpha;
                        else if (tweener.animationType == DOTweenAnimation.AnimationType.Scale)
                            ini.GetComponent<RectTransform>().localScale = ini.hideScale;
                        tweener.RecreateTweenAndPlay();
                    }
            }
        }

        public void Hide()
        {
            foreach (var ini in initializers)
            {
                foreach (var tweener in ini.GetComponents<DOTweenAnimation>())
                    if (tweener.id == hideID)
                    {
                        if (tweener.animationType == DOTweenAnimation.AnimationType.Fade)
                            ini.GetComponent<CanvasGroup>().alpha = ini.showAlpha;
                        else if (tweener.animationType == DOTweenAnimation.AnimationType.Scale)
                            ini.GetComponent<RectTransform>().localScale = ini.showScale;
                        tweener.RecreateTweenAndPlay();
                    }
            }
            DOTween.To(v => { }, 0, 0, shutDownDelay).OnComplete(() =>
            {
                OnDisable();
            });
        }

#if UNITY_EDITOR
        public bool show;
        public bool hide;

        private void Update()
        {
            if (show)
            {
                show = false;
                Show();
            }
            if (hide)
            {
                hide = false;
                Hide();
            }
        }

#endif
    }
}
