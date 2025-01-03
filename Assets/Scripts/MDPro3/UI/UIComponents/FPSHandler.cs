using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class FPSHandler : UIHandler
    {
        private float m_lastUpdateShowTime = 0f;
        private readonly float m_updateTime = 0.5f;
        private int m_frames = 0;
        private float m_FPS = 0;

        public Text text;

        public override void Initialize()
        {
            m_lastUpdateShowTime = Time.realtimeSinceStartup;
        }

        public override void PerframeFunction()
        {
            m_frames++;
            if (Time.realtimeSinceStartup - m_lastUpdateShowTime >= m_updateTime)
            {
                m_FPS = m_frames / (Time.realtimeSinceStartup - m_lastUpdateShowTime);
                m_lastUpdateShowTime = Time.realtimeSinceStartup;
                m_frames = 0;
                text.text = ((int)m_FPS).ToString();
            }
        }
    }
}
