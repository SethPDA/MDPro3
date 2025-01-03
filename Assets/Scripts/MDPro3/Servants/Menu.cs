using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System.IO;
using MDPro3.Net;
using MDPro3.UI;
using UnityEngine.EventSystems;
using TMPro;
using DG.Tweening;

namespace MDPro3
{
    public class Menu : Servant
    {
        [HideInInspector] public SelectionButton_MainMenu lastSelectedButton;

        #region Servant
        public override void Initialize()
        {
            depth = 0;
            showLine = false;
            needExit = false;
            base.Initialize();
            
            showing = true;
            cg.alpha = 1f;
            cg.blocksRaycasts = true;
            Manager.GetElement<TextMeshProUGUI>("Title").text = "MDPro3 v" + Application.version;

            UIManager.HideExitButton(0f);
            UIManager.HideLine(0f);
            Program.instance.currentServant = this;
            Program.instance.depth = 0;
            StartCoroutine(CheckUpdateAsync());
            StartCoroutine(LoadMyCardNewsAsync());
        }
        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            UIManager.ShowWallpaper(transitionTime);
        }
        protected override void ApplyHideArrangement(int preDepth)
        {
            base.ApplyHideArrangement(preDepth);
            UIManager.HideWallpaper(transitionTime);
            DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
            {
                transform.GetChild(0).gameObject.SetActive(false);
            });
        }
        public override void PerFrameFunction()
        {
            if (showing)
            {
                if(NeedResponseInput())
                {
                    if (UserInput.WasCancelPressed)
                        OnReturn();

                    if (Program.instance.news_.showing)
                    {
                        if (UserInput.WasLeftPressed)
                            Program.instance.news_.OnLeft();
                        else if (UserInput.WasRightPressed)
                            Program.instance.news_.OnRight();

                        if(UserInput.WasGamepadButtonWestPressed)
                        {
                            Program.instance.news_.OnNewsClick();
                        }
                        if (UserInput.WasGamepadButtonNorthPressed)
                        {
                            Program.instance.news_.OnClose();
                        }
                    }
                }
            }
        }
        public override void SelectLastSelectable()
        {
            if (lastSelectedButton != null)
                EventSystem.current.SetSelectedGameObject(lastSelectedButton.gameObject);
            else
                EventSystem.current.SetSelectedGameObject(defaultSeletable.gameObject);
        }

        #endregion

        #region Online

        private IEnumerator CheckUpdateAsync()
        {
            yield return new WaitForSeconds(3);
            using var www = UnityWebRequest.Get(Settings.Data.MDPro3VersionUrl);
            www.SetRequestHeader("Cache-Control", "max-age=0, no-cache, no-store");
            www.SetRequestHeader("Pragma", "no-cache");
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.Success)
            {
                var result = www.downloadHandler.text;
                var lines = result.Replace("\r", "").Split('\n');
                if (Application.version != lines[0])
                    MessageManager.Cast(InterString.Get("检测到新版本[[?]]。", lines[0]));
            }
            else
                MessageManager.Cast(InterString.Get("检查更新失败！"));

            var filePath = Path.Combine(Program.expansionsPath, Path.GetFileName(Settings.Data.PrereleasePackUrl));
            if (!File.Exists(filePath))
            {
                Config.Set("Prerelease", "0");
                Config.Save();
            }

            using var www2 = UnityWebRequest.Get(Settings.Data.PrereleasePackVersionUrl);
            yield return www2.SendWebRequest();
            if(www2.result == UnityWebRequest.Result.Success)
            {
                var result = www2.downloadHandler.text;
                var lines = result.Replace("\r", "").Split('\n');
                if (Config.Get("Prerelease", "0") != lines[0])
                    MessageManager.Cast(InterString.Get("检测到新版先行卡，请至 [游戏设置]-[扩展卡包]-[更新先行卡] 处进行更新。"));
            }
        }

        private IEnumerator LoadMyCardNewsAsync()
        {
            var news = MyCard.GetNews();
            while (!news.IsCompleted)
                yield return null;
            Program.instance.news_.news = news.Result;
            Program.instance.news_.LoadNews();
        }
        #endregion

        #region Button Function
        public void OnSolo()
        {
            if(Program.exitOnReturn) 
                return;

            Program.instance.solo.SwitchCondition(Solo.Condition.ForSolo);
            Program.instance.ShiftToServant(Program.instance.solo);
        }
        public void OnOnline()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.ShiftToServant(Program.instance.online);
        }
        public void OnPuzzle()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.ShiftToServant(Program.instance.puzzle);
        }
        public void OnReplay()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.ShiftToServant(Program.instance.replay);
        }
        public void OnCutin()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.ShiftToServant(Program.instance.cutin);
        }
        public void OnMate()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.ShiftToServant(Program.instance.mate);
        }
        public void OnEditDeck()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.selectDeck.SwitchCondition(SelectDeck.Condition.ForEdit);
            Program.instance.ShiftToServant(Program.instance.selectDeck);
        }
        public void OnSetting()
        {
            if (Program.exitOnReturn)
                return;

            Program.instance.ShiftToServant(Program.instance.setting);
        }
        public override void OnExit()
        {
            if (Program.exitOnReturn)
                return;

            List<string> selections = new ()
            {
                InterString.Get("确认退出"),
                InterString.Get("即将退出应用程序，@n是否确认？"),
                InterString.Get("确认"),
                InterString.Get("取消"),
                Config.stringYes
            };
            UIManager.ShowPopupYesOrNo(selections, Program.GameQuit, null);
        }
        #endregion
    }
}
