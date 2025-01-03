using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MDPro3.UI
{
    [Serializable]
    public class StringUnityEvent : UnityEvent<string> { }

    public class InputFieldSubmit : MonoBehaviour
    {
        public StringUnityEvent onSubmit;

        private InputField inputField;
        private TMP_InputField tmpInput;

        void Awake()
        {
            if (TryGetComponent(out inputField))
                inputField.lineType = InputField.LineType.MultiLineNewline;
            if (TryGetComponent(out tmpInput))
                tmpInput.lineType = TMP_InputField.LineType.MultiLineNewline;
        }

        void OnEnable()
        {
            if(inputField != null)
                inputField.onValidateInput += CheckForEnter;
            if(tmpInput != null)
                tmpInput.onValidateInput += CheckForEnter;
        }

        void OnDisable()
        {
            if (inputField != null)
                inputField.onValidateInput -= CheckForEnter;
            if (tmpInput != null)
                tmpInput.onValidateInput -= CheckForEnter;
        }

        private char CheckForEnter(string text, int charIndex, char addedChar)
        {
            if (addedChar == '\n' && onSubmit != null)
            {
                onSubmit.Invoke(text);
                return '\0';
            }
            else
                return addedChar;
        }
    }
}
