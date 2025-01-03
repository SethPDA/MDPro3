using UnityEngine;

namespace MDPro3
{
    public class SystemEvent : MonoBehaviour
    {
        public delegate void SafeAreaUpdate();
        public static event SafeAreaUpdate OnSafeAreaUpdate;

        public delegate void ResolutionChange();
        public static event ResolutionChange OnResolutionChange;

        private Rect safeArea;
        private int screenWidth;
        private int screenHeight;
        private void Start()
        {
            safeArea = Screen.safeArea;
            screenWidth = Screen.width;
            screenHeight = Screen.height;
        }

        private void Update()
        {
            if (safeArea != Screen.safeArea)
            {
                safeArea = Screen.safeArea;
                OnSafeAreaUpdate.Invoke();
            }
            if (screenWidth != Screen.width || screenHeight != Screen.height)
            {
                screenWidth = Screen.width;
                screenHeight = Screen.height;
                OnResolutionChange.Invoke();
            }
        }
    }
}