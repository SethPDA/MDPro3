using MDPro3.Net;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class SelectionToggle_Watch : SelectionToggle_ScrollRectItem
    {
        [Header("SelectionToggle Watch")]


        public string roomId;
        public string roomTitile;
        public string player0Name;
        public string player1Name;
        public string arena;
        public MyCardRoomOptions options = new();
        public override void Refresh()
        {
            base.Refresh();

            Manager.GetElement<TextMeshProUGUI>("Player0Name").text = player0Name;
            Manager.GetElement<TextMeshProUGUI>("Player1Name").text = player1Name;
        }

        protected override IEnumerator RefreshAsync()
        {
            refreshed = false;

            Manager.GetElement<RawImage>("Face0").texture = Appearance.defaultFace0.texture;
            Manager.GetElement<RawImage>("Face1").texture = Appearance.defaultFace1.texture;

            var load = MyCard.GetAvatarAsync(player0Name);
            while (!load.IsCompleted)
                yield return null;
            if (load.Result != null)
                Manager.GetElement<RawImage>("Face0").texture = load.Result;

            load = MyCard.GetAvatarAsync(player1Name);
            while (!load.IsCompleted)
                yield return null;
            if (load.Result != null)
                Manager.GetElement<RawImage>("Face1").texture = load.Result;

            enumerator = null;
            refreshed = true;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            if(enumerator != null)
                StopCoroutine(enumerator);
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.online.lastSelectedWatchItem = this;
        }

        protected override void CallSubmitEvent()
        {
            AudioManager.PlaySE("SE_MENU_DECIDE");
            base.CallSubmitEvent();
            var password = MyCard.GetJoinRoomPassword(options, roomId, MyCard.account.user.id);
            TcpHelper.LinkStart(MyCard.duelUrl, MyCard.account.user.username, MyCard.athleticPort.ToString(), password, false, null);
        }

        protected override void OnClick()
        {
            Program.instance.online.lastSelectedWatchItem = this;
            CallSubmitEvent();
        }

        protected override void ToggleOn()
        {
            toggled = true;
            isOn = true;
        }
        public override void ToggleOnNow()
        {
            toggled = true;
            isOn = true;
        }
        protected override void ToggleOff()
        {
            toggled = false;
            isOn = false;
        }
        public override void ToggleOffNow()
        {
            toggled = false;
            isOn = false;
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            var selfIndex = index;
            if (selfIndex < 0)
                selfIndex = transform.GetSiblingIndex();

            var count = Program.instance.online.watchListHandler.superScrollView.items.Count;
            var columes = Program.instance.online.watchListHandler.superScrollView.GetColumnCount();

            var targetIndex = selfIndex + 1;

            if (eventData.moveDir == MoveDirection.Left)
            {
                if (selfIndex % columes == 0)
                {
                    Program.instance.online.SelectDeckSelector();
                    return;
                }
                targetIndex = index - 1;
            }
            else if (eventData.moveDir == MoveDirection.Right)
            {
                if (selfIndex % columes == columes - 1 || index == count - 1)
                {
                    Program.instance.online.SelectMyCardDefaultButton();
                    return;
                }
            }
            else if (eventData.moveDir == MoveDirection.Up)
                targetIndex = selfIndex - columes;
            else if (eventData.moveDir == MoveDirection.Down)
            {
                var lastLineLeft = count % columes;
                var bound = count - lastLineLeft - 1;
                if (lastLineLeft == 0)
                    bound -= columes;
                if (selfIndex > bound)
                    return;
                targetIndex = index + columes;
            }

            if (targetIndex < 0)
                return;
            if (targetIndex >= count)
                targetIndex = count - 1;
            if (targetIndex == index)
                return;

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                var child = transform.parent.GetChild(i);
                if (!child.gameObject.activeSelf)
                    continue;

                var buttonIndex = child.GetComponent<SelectionButton>().index;
                if (buttonIndex < 0)
                    buttonIndex = i;

                if (buttonIndex == targetIndex)
                {
                    UserInput.NextSelectionIsAxis = true;
                    EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(i).gameObject);
                    break;
                }
            }

        }
    }
}

