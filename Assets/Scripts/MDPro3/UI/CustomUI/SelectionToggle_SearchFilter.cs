using MDPro3.Utility;
using UnityEngine;

namespace MDPro3.UI
{
    public class SelectionToggle_SearchFilter : SelectionToggle
    {
        [Header("SelectionToggle SearchFilter")]
        public int code;
        public int subCode;
        public int group;
        public long filterCode;
        public string text_es_ES;

        protected override void Awake()
        {
            base.Awake();
            if(code != 0)
            {
                SetButtonText(StringHelper.GetUnsafe(code));
                if(subCode != 0)
                {
                    if (subCode == 9999)
                        SetButtonText(InterString.Get("[?]Че", GetButtonText()));
                    else if (Language.GetConfig() == Language.Spanish && text_es_ES != string.Empty)
                        SetButtonText(text_es_ES);
                    else
                    {
                        var title = GetButtonText();
                        if (Language.NeedBlankToAddWord())
                            title += " ";
                        title += StringHelper.GetUnsafe(subCode);
                        SetButtonText(title);
                    }
                }
            }
        }

        protected override void CallHoverOnEvent()
        {
            base.CallHoverOnEvent();
            ((Popup.PopupSearchFilter)Program.instance.ui_.currentPopupB).lastSelectedToggle = this;
        }
    }
}

