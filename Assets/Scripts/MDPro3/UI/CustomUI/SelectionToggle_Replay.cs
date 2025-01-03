using Percy;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_Replay : SelectionToggle_ScrollRectItem
    {
        public string replayName;
        private YRP yrp;

        public override void Refresh()
        {
            Manager.GetElement<TextMeshProUGUI>("Title").text = replayName;
            yrp = Program.instance.replay.CacheYRP(replayName);

            Manager.GetElement("NumBadge").SetActive(false);
            Manager.GetElement("TextClear").SetActive(false);

            base.Refresh();
        }

        protected override IEnumerator RefreshAsync()
        {
            refreshed = false;
            while (TextureManager.container == null)
                yield return null;

            var face = Manager.GetElement<RawImage>("Image");
            face.texture = TextureManager.container.black.texture;

            if (yrp == null)
            {
                face.texture = TextureManager.container.unknownArt.texture;
                face.color = Color.white;
                enumerator = null;
                yield break;
            }

            var task = TextureManager.LoadArtAsync(yrp.playerData[0].main[0], true);
            while (!task.IsCompleted)
                yield return null;
            face.texture = task.Result;

            enumerator = null;
            refreshed = true;
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.replay.lastSelectedReplayItem = this;
            Program.instance.replay.superScrollView.selected = index;

            var manager = Program.instance.replay.Manager;
            var tmp = manager.GetElement<TextMeshProUGUI>("TextOverview");
            if (yrp == null)
            {
                tmp.text = "";
                manager.GetElement("ButtonPlayer0").SetActive(false);
                manager.GetElement("ButtonPlayer1").SetActive(false);
                manager.GetElement("ButtonPlayer2").SetActive(false);
                manager.GetElement("ButtonPlayer3").SetActive(false);
            }
            else
            {
                manager.GetElement("ButtonPlayer0").SetActive(true);
                manager.GetElement("ButtonPlayer1").SetActive(true);
                manager.GetElement("ButtonPlayer2").SetActive(true);
                manager.GetElement("ButtonPlayer3").SetActive(true);

                var description = "";
                bool tag = false;
                if ((yrp.opt & 0x20) > 0)
                {
                    description += StringHelper.GetUnsafe(1246) + "\r\n";//双打模式
                    tag = true;
                }
                description += StringHelper.GetUnsafe(1259 + (yrp.opt >> 16)) + "\r\n";//规则
                description += StringHelper.GetUnsafe(1231) + yrp.StartLp + "\r\n";//初始基本分：
                description += StringHelper.GetUnsafe(1232) + yrp.StartHand + "\r\n";//初始手卡数：
                description += StringHelper.GetUnsafe(1233) + yrp.DrawCount + "\r\n";//每回合抽卡：
                if ((yrp.opt & 0x10) > 0)
                    description += StringHelper.GetUnsafe(1230) + "\r\n";

                manager.GetElement<SelectionButton>("ButtonPlayer0").SetButtonText(yrp.playerData[0].name);
                manager.GetElement<SelectionButton>("ButtonPlayer1").SetButtonText(yrp.playerData[1].name);
                if (tag)
                {
                    manager.GetElement<SelectionButton>("ButtonPlayer2").SetButtonText(yrp.playerData[2].name);
                    manager.GetElement<SelectionButton>("ButtonPlayer3").SetButtonText(yrp.playerData[3].name);
                }
                else
                {
                    manager.GetElement("ButtonPlayer2").SetActive(false);
                    manager.GetElement("ButtonPlayer3").SetActive(false);
                }

                tmp.text = description;
            }
        }

        protected override void CallSubmitEvent()
        {
            Program.instance.replay.KF_Replay(replayName);
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            base.OnNavigation(eventData);

            if (eventData.moveDir == MoveDirection.Right)
            {
                UserInput.NextSelectionIsAxis = true;
                var deckButton = Program.instance.replay.Manager.GetElement("ButtonPlayer0");
                if (deckButton.activeSelf)
                    EventSystem.current.SetSelectedGameObject(deckButton);
                else
                    EventSystem.current.SetSelectedGameObject(Program.instance.replay.Manager.GetElement("ButtonGod"));
            }
        }
    }
}
