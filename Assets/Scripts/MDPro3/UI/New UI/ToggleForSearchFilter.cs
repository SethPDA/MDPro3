using MDPro3.Utility;

namespace MDPro3.UI
{
    public class ToggleForSearchFilter : Toggle
    {
        public int code;
        public int subCode;
        public int group;
        public long filterCode;
        public string text_es_ES;

        private void Start()
        {
            if (code != 0)
            {
                label.text = StringHelper.GetUnsafe(code);
                if (subCode != 0)
                {
                    if (subCode == 9999)
                        label.text = InterString.Get("[?]Че", label.text);
                    else if(Language.GetConfig() == Language.Spanish && text_es_ES != string.Empty)
                        label.text = text_es_ES;
                    else
                    {
                        if (Language.NeedBlankToAddWord())
                            label.text += " ";
                        label.text += StringHelper.GetUnsafe(subCode);
                    }
                }
            }
        }

        public override void OnClickOn()
        {
            base.OnClickOn();
            //AudioManager.PlaySE("SE_MENU_S_DECIDE_01");
        }
        public override void OnClickOff()
        {
            base.OnClickOff();
            //AudioManager.PlaySE("SE_MENU_S_DECIDE_02");
        }
    }
}
