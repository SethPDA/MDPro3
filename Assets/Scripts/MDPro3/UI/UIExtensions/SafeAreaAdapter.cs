using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SafeAreaAdapter : MonoBehaviour
    {
        private RectTransform _rectTransform;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            SystemEvent.OnSafeAreaUpdate += ApplySafeArea;
            ApplySafeArea();
        }

        private void OnDestroy()
        {
            SystemEvent.OnSafeAreaUpdate -= ApplySafeArea;
        }

        private void ApplySafeArea()
        {
            if (_rectTransform == null)
            {
                Debug.LogError("RectTransform is null");
                return;
            }

            Rect safeArea = Screen.safeArea;
            if (Screen.height == 0 || safeArea.width == 0 || safeArea.height == 0)
                return;
            var width = Screen.width * 1080 / Screen.height;
            var offsetMin = new Vector2(safeArea.position.x * width / safeArea.width,
                safeArea.position.y * 1080f / safeArea.height);
            var offsetMax = new Vector2((safeArea.position.x + safeArea.width - Screen.width) * width / safeArea.width,
                (safeArea.position.y + safeArea.height - Screen.height) * 1080f / safeArea.height);

            _rectTransform.offsetMin = offsetMin;
            _rectTransform.offsetMax = offsetMax;
        }

        public static float GetSafeAreaRightOffset()
        {
            return (Screen.width - (Screen.safeArea.x + Screen.safeArea.width)) * Screen.height / 1080f;
        }
    }
}
