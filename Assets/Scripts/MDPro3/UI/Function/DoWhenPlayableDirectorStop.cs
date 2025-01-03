using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace MDPro3.UI
{
    public class DoWhenPlayableDirectorStop : MonoBehaviour
    {
        public Action action;
        PlayableDirector director;
        void Start()
        {
            director = GetComponent<PlayableDirector>();
        }

        void Update()
        {
            if (director.state != PlayState.Playing)
            {
                action?.Invoke();
                enabled = false;
            }
        }
    }
}
