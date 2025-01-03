using UnityEngine;
using DG.Tweening;
using YgomSystem.UI;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class RectLoopMoveY : MonoBehaviour
    {
        public float range;
        public float time;
        float startY;
        readonly Ease ease = Ease.InOutSine;

        private void Start()
        {
            startY = GetComponent<RectTransform>().anchoredPosition.y;
            foreach (var alpha in GetComponents<TweenAlpha>())
                if (alpha.label == "Show")
                    GetComponent<Image>().color = new Color(1, 1, 1, alpha.to);
            foreach (var position in GetComponents<TweenPosition>())
                if (position.label == "Loop")
                {
                    range = position.from.y - position.to.y;
                    time = position.duration;
                }
            if (time > 0)
                MoveUp();
        }

        void MoveUp()
        {
            GetComponent<RectTransform>().DOAnchorPosY(startY + range, time).SetEase(ease).OnComplete(() => { MoveDown(); });
        }
        void MoveDown()
        {
            GetComponent<RectTransform>().DOAnchorPosY(startY - range, time).SetEase(ease).OnComplete(() => { MoveUp(); });
        }
    }
}
