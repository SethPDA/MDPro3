using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace MDPro3.UI
{
    public class TimerHandler : MonoBehaviour
    {
        bool duelStart;
        bool duelEnd;
        public int timeLimit;
        public int time
        {
            get { return m_time; }
            set
            {
                pastTime = 0;
                m_time = value;
            }
        }
        int m_time;
        public int player
        {
            get { return m_player; }
            set
            {
                m_player = value;
                ChangePlayer();
            }
        }
        int m_player;
        float pastTime = 0;
        ElementObjectManager manager;
        TextMeshPro text;
        Material material;

        private void Awake()
        {
            manager = GetComponent<ElementObjectManager>();
            text = manager.GetElement<TextMeshPro>("Text");
            text.font = Program.instance.ui_.jpMenuTmpFont;
            material = manager.GetElement<Renderer>("Timer").materials[1];
            material.SetFloat("_AddTime", 0);
        }

        private void Start()
        {
            //manager = GetComponent<ElementObjectManager>();
            //text = manager.GetElement<TextMeshPro>("Text");
            //text.font = Program.instance.ui_.tmpFontForPhaseButton;
            //material = manager.GetElement<Renderer>("Timer").materials[1];
            //material.SetFloat("_AddTime", 0);
        }

        private void Update()
        {
            if (!duelStart || duelEnd)
                return;

            if (timeLimit == 0)
                DuelEnd();
            pastTime += Time.unscaledDeltaTime;
            int remainTime = Mathf.CeilToInt(time - pastTime);
            text.text = remainTime.ToString();

            material.SetFloat("_MaxTime", time - pastTime < 0 ? 0 : (time - pastTime) / timeLimit);
        }

        public void DuelStart()
        {
            text.gameObject.SetActive(true);
            Tools.PlayAnimation(transform, "StartToPhase1");
            duelStart = true;
        }

        public void DuelEnd()
        {
            text.gameObject.SetActive(false);
            duelEnd = true;
        }
        void ChangePlayer()
        {
            if (player == 0)
            {
                material.SetColor("_MaxTimeColor01", new Color(0.2117f, 0.6784f, 1f, 0f));
                material.SetColor("_MaxTimeColor02", new Color(0.1098f, 0.4745f, 1f, 0f));
            }
            else
            {
                material.SetColor("_MaxTimeColor01", new Color(1f, 0.2194f, 0.2117f, 0f));
                material.SetColor("_MaxTimeColor02", new Color(1f, 0.1362f, 0.1098f, 0f));
            }
        }
    }
}
