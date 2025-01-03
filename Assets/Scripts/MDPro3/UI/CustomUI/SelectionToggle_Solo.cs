using Mono.WebBrowser;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_Solo : SelectionToggle_ScrollRectItem
    {
        public Solo.BotInfo botInfo;
        bool diyDeck;

        public override void Refresh()
        {
            base.Refresh();
            Manager.GetElement<TextMeshProUGUI>("Title").text = botInfo.name;
            diyDeck = botInfo.command.Contains("Lucky");

            Manager.GetElement("NumBadge").SetActive(false);
            Manager.GetElement("TextClear").SetActive(false);
        }

        protected override IEnumerator RefreshAsync()
        {
            refreshed = false;
            while (TextureManager.container == null)
                yield return null;

            var face = Manager.GetElement<RawImage>("Image");
            face.texture = TextureManager.container.black.texture;
            var task = TextureManager.LoadArtAsync(botInfo.main0, true);
            while (!task.IsCompleted)
                yield return null;
            face.texture = task.Result;

            enumerator = null;
            refreshed = true;
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.solo.superScrollView.selected = index;

            var description = Program.instance.solo.Manager.GetElement<TextMeshProUGUI>("TextOverview");
            description.text = botInfo.desc;
            description.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

            Program.instance.solo.lastSoloItem = this;

            var btnDeck = Program.instance.solo.Manager.GetElement("ButtonDeck");
            if (diyDeck)
                btnDeck.SetActive(true);
            else
                btnDeck.SetActive(false);
        }

        protected override void CallSubmitEvent()
        {
            base.CallSubmitEvent();
            if (Solo.condition == Solo.Condition.ForSolo)
                Program.instance.solo.StartAIForSolo(index, diyDeck);
            else
                Program.instance.solo.StartAIForRoom(index, diyDeck);
        }

        public void PublicSubmit()
        {
            CallSubmitEvent();
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            base.OnNavigation(eventData);

            if (eventData.moveDir == MoveDirection.Right)
            {
                UserInput.NextSelectionIsAxis = true;
                EventSystem.current.SetSelectedGameObject(Program.instance.solo.toggleLockHand.gameObject);
            }
        }
    }
}
