using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionButton_RoomPlayer : SelectionButton
    {
        [Header("SelectionButton RoomPlayer")]
        public int playerIndex;

        protected override void CallHoverOnEvent()
        {
            base.CallHoverOnEvent();
            if(Room.isHost && playerIndex != Room.selfType)
                Manager.GetElement("KickIcon").SetActive(true);
        }

        protected override void CallHoverOffEvent()
        {
            base.CallHoverOffEvent();
            Manager.GetElement("KickIcon").SetActive(false);
        }

        protected override void OnSubmit()
        {
            base.OnSubmit();
            if (Room.isHost)
            {
                if (playerIndex != Room.selfType)
                    Program.instance.room.OnKick(playerIndex);
                else
                    Program.instance.room.OnReady();
            }
        }

        public Image GetAvatar()
        {
            return Manager.GetElement<Image>("Avatar");
        }

        public void SetReadyIcon(bool ready)
        {
            Manager.GetElement("ReadyIcon").SetActive(ready);
        }

        public void SetButtonTextColor(Color color)
        {
            Manager.GetElement<TextMeshProUGUI>("ButtonText").color = color;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            Manager.GetElement("KickIcon").SetActive(false);
        }
    }
}
