using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.YGOSharp;

namespace MDPro3.UI
{
    public class PopupServer : PopupBase
    {
        [Header("Popup Server")]
        public Text textLflist;
        public Text textPool;
        public Text textMode;
        public Toggle toggleNoCheck;
        public Toggle toggleNoShuffle;
        public InputField inputTime;
        public InputField inputLP;
        public InputField inputHand;
        public InputField inputDraw;

        public override void InitializeSelections()
        {
            base.InitializeSelections();
            textLflist.text = selections[1];
            textPool.text = selections[2];
            textMode.text = selections[3];
            if (selections[4] == "T")
                toggleNoCheck.SwitchOn();
            if (selections[5] == "T")
                toggleNoShuffle.SwitchOn();
            inputTime.text = selections[6];
            inputLP.text = selections[7];
            inputHand.text = selections[8];
            inputDraw.text = selections[9];
        }

        public override void OnConfirm()
        {
            base.OnConfirm();
            Program.instance.online.serverSelections = GetSelections();
            whenQuitDo = () => { Program.instance.online.CreateServer(); };
            Hide();
        }
        public override void OnCancel()
        {
            base.OnCancel();
            Hide();
        }
        List<string> GetSelections()
        {
            return new List<string>() 
            {
                InterString.Get("创建主机"),
                textLflist.text,
                textPool.text,
                textMode.text,
                toggleNoCheck.switchOn ? "T" : "F",
                toggleNoShuffle.switchOn ? "T" : "F",
                inputTime.text == "" ? "0" : inputTime.text,
                inputLP.text == "" ? "8000" : inputLP.text,
                inputHand.text == "" ? "5" : inputHand.text,
                inputDraw.text == "" ? "1" : inputDraw.text
            };
        }


        public void OnLflist()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("禁限卡表"),
                string.Empty
            };
            foreach (var list in BanlistManager.Banlists)
                selections.Add(list.Name);
            UIManager.ShowPopupSelection(selections, ChangeBanlist, OnSubPopupClose);
        }
        void ChangeBanlist()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            textLflist.text = selected;
        }

        public void OnPool()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("卡片允许"),
                string.Empty
            };
            for (int i = 1481; i < 1487; i++)
                selections.Add(StringHelper.GetUnsafe(i));
            UIManager.ShowPopupSelection(selections, ChangePool, OnSubPopupClose);
        }
        void ChangePool()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            textPool.text = selected;
        }
        public void OnMode()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("决斗模式"),
                string.Empty
            };
            for (int i = 1244; i < 1247; i++)
                selections.Add(StringHelper.GetUnsafe(i));
            UIManager.ShowPopupSelection(selections, ChangeMode, OnSubPopupClose);
        }
        void ChangeMode()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            textMode.text = selected;
        }


        void OnSubPopupClose()
        {
            Program.instance.currentServant.returnAction = Hide;
        }

    }
}