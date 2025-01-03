using UnityEngine;
using UnityEngine.Events;

namespace MDPro3.UI
{
    public class SelectionButton_CardInfoType : SelectionButton
    {

        protected override void Awake()
        {
            base.Awake();

            SetCardInfoTypeIcon(DeckEditor._CardInfoType);
            SetClickEvent(ClickEvent);
        }

        private void ClickEvent()
        {
            var type = (DeckEditor.CardInfoType)(((int)DeckEditor._CardInfoType + 1) % 3);
            Program.instance.deckEditor.SetCardInfoType(type);
            SetCardInfoTypeIcon(type);
        }

        private void SetCardInfoTypeIcon(DeckEditor.CardInfoType type)
        {
            switch (type)
            {
                case DeckEditor.CardInfoType.None:
                    Manager.GetElement("IconInfoSwitching0").SetActive(true);
                    Manager.GetElement("IconInfoSwitching1").SetActive(false);
                    Manager.GetElement("IconInfoSwitching2").SetActive(false);
                    break;
                case DeckEditor.CardInfoType.Detail:
                    Manager.GetElement("IconInfoSwitching0").SetActive(false);
                    Manager.GetElement("IconInfoSwitching1").SetActive(true);
                    Manager.GetElement("IconInfoSwitching2").SetActive(false);
                    break;
                case DeckEditor.CardInfoType.Pool:
                    Manager.GetElement("IconInfoSwitching0").SetActive(false);
                    Manager.GetElement("IconInfoSwitching1").SetActive(false);
                    Manager.GetElement("IconInfoSwitching2").SetActive(true);
                    break;                
            }
        }
    }
}
