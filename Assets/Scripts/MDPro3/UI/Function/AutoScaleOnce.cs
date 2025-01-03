using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MDPro3.UI
{
    public class AutoScaleOnce : MonoBehaviour
    {
        float width;
        float height;
        void Start()
        {
            width = transform.localScale.x;
            height = transform.localScale.y;
            Scale();
        }

        void Scale()
        {
            float screenAspect = (float)Screen.width / Screen.height;
            if (screenAspect > 16 / 9f)
                transform.localScale = new Vector3(width * screenAspect * 9 / 16, height * screenAspect * 9 / 16, transform.localScale.z);
            else
                transform.localScale = new Vector3(width, height, transform.localScale.z);
        }
    }
}
