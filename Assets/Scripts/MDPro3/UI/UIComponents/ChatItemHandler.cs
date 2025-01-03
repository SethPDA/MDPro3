using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class ChatItemHandler : MonoBehaviour
    {
        public RectTransform anchor;
        public Image frame0;
        public Image frame1;
        public TextMeshProUGUI text0;
        public TextMeshProUGUI text1;

        public string text;
        public float time;
        public int frame;

        float frameHeight0 = 120f;
        float frameHeight1 = 160f;
        int charaWidth = 40;

        public void Start()
        {
            text0.text = text;
            text1.text = text;

            var target = GetFrameWidth();
            if(target > 360)
                target = 360;
            if (target < 150)
                target = 150;
            frame0.GetComponent<RectTransform>().sizeDelta = new Vector2 (target, frameHeight0);
            target = GetFrameWidth() + 80;
            if (target > 380)
                target = 380;
            if (target < 150)
                target = 150;
            frame1.GetComponent<RectTransform>().sizeDelta = new Vector2(target, frameHeight1);

            anchor.localScale = Vector3.zero;
            anchor.DOScale(1, 0.2f);

            if (frame == 0)
                Destroy(frame1.gameObject);
            else
                Destroy(frame0.gameObject);

            Destroy(gameObject, time < 2f ? 2f : time);
        }

        public void BeGray()
        {
            if(frame0 != null)
                frame0.color = Color.gray;
            if (frame1 != null)
                frame1.color = Color.gray;
        }

        int GetFrameWidth()
        {
            var lines = text.Split("\n");
            var maxC = 0;
            for(var i = 0; i < lines.Length; i++)
                if (lines[i].Length > maxC)
                    maxC = lines[i].Length;
            return maxC * charaWidth;
        }



    }
}
