using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using MDPro3.YGOSharp;
using Spine.Unity;
using TMPro;
using UnityEngine.AddressableAssets;
using MDPro3.UI;
using MDPro3.Net;
using MDPro3.Utility;
using MDPro3.UI.PropertyOverrider;
using MDPro3.UI.Popup;

namespace MDPro3
{
    public class UIManager : Manager
    {
        [Header("Public Reference")]
        public CanvasGroup wallpaper;
        public Button btnExit;
        public CanvasGroup line;
        public Image blackBack;
        public RectTransform popup;
        public RectTransform transition;
        public RectTransform duelButton;
        public static string currentWallpaper;

        [Header("UI Handler")]
        public FPSHandler fps;
        public CardDetail cardDetail;
        List<UIHandler> handlers;

        [Header("Side Panel")]
        public ChatPanel chatPanel;
        public SubMenuHandler subMenu;

        [Header("Source Reference")]
        public Font cnFont;
        public Font jpFont;
        public Font cnMenuFont;
        public TMP_FontAsset tmpFont;
        public TMP_FontAsset jpMenuTmpFont;
        public TMP_FontAsset cnMenuTmpFont;

        [HideInInspector] public PopupBase currentPopup;
        [HideInInspector] public Popup currentPopupB;
        [HideInInspector] public SidePanel currentSidePanel;

        [HideInInspector] public static MonoBehaviour InputBlocker;

        public override void Initialize()
        {
            base.Initialize();

            currentWallpaper = Config.Get("Wallpaper", Program.items.wallpapers[0].id.ToString());
            ChangeWallpaper(currentWallpaper);
            InitializeLanguage();

            handlers = new List<UIHandler>() 
            { 
                fps,
                cardDetail,
            };
            foreach (UIHandler handler in handlers)
                handler.Initialize();
        }

        public override void PerFrameFunction()
        {
            base.PerFrameFunction();
            foreach (UIHandler handler in handlers)
                handler.PerframeFunction();
        }

        public static void Translate(GameObject go)
        {
            //TO DELETE
            foreach (var text in go.GetComponentsInChildren<Text>(true))
                if (text.name.StartsWith("#Text"))
                    text.text = InterString.Get(text.text.Replace("\r\n", "@n"));
            foreach (var text in go.GetComponentsInChildren<TextMeshProUGUI>(true))
                if (text.name.StartsWith("#Text"))
                    text.text = InterString.Get(text.text.Replace("\r\n", "@n"));
        }

        public static void InitializeLanguage()
        {
            InterString.Initialize();
            StringHelper.Initialize();
            CardsManager.Initialize();
            Program.items.Initialize();
            Program.instance.cardRenderer.SwitchLanguage();
            Program.instance.online.LocalHostInitialize();
            UIManager instance = Program.instance.ui_;

            foreach (var t in instance.GetComponentsInChildren<Transform>(true))
            {
                if (t.name.StartsWith("#Text"))
                {
                    var text = t.GetComponent<Text>();
                    if (text == null)
                    {
                        var tmp = t.GetComponent<TextMeshProUGUI>();
                        if (tmp != null)
                        {
                            tmp.text = InterString.Get(tmp.text);

                            if (tmp.name.EndsWith("Menu"))
                            {
                                if ((Language.GetConfig() == Language.English
                                    || Language.GetConfig() == Language.Japanese))
                                {
                                    tmp.font = instance.jpMenuTmpFont;
                                    tmp.fontSize = 64f;
                                }
                                else if (Language.GetConfig() == Language.SimplifiedChinese)
                                {
                                    tmp.font = instance.cnMenuTmpFont;
                                    tmp.fontSize = 62f;
                                }
                                else
                                {
                                    tmp.font = instance.tmpFont;
                                    tmp.fontSize = 60f;
                                }
                            }
                        }
                    }
                    else
                    {
                        text.text = InterString.Get(text.text);
                    }
                }
            }
        }

        public static void ChangeLanguage()
        {
            UIManager instance = Program.instance.ui_;
            foreach(var t in instance.GetComponentsInChildren<Transform>(true))
            {
                if (t.name.StartsWith("#Text"))
                {
                    var text = t.GetComponent<Text>();
                    if(text == null)
                    {
                        var tmp = t.GetComponent<TextMeshProUGUI>();
                        if(tmp != null)
                            tmp.text = InterString.GetOriginal(tmp.text);
                    }
                    else
                        text.text = InterString.GetOriginal(text.text);
                }
            }

            TextureManager.ClearCache();
            TextureLoader.DeleteCache();
            Program.instance.UnloadUnusedAssets();

            InitializeLanguage();
            Program.instance.cutin.Load();
            Program.instance.mate.Load();
            Program.instance.solo.Load();
            Program.instance.character.LoadCharacters();
            Program.instance.setting.RefreshCharacterName();
            Online.severSelectionsInitialized = false;
        }

        public static void ChangeLayout()
        {
            UIManager instance = Program.instance.ui_;
            foreach (var overrider in instance.GetComponentsInChildren<PropertyOverrider>(true))
                overrider.Override();

            ShowExitButton(0f);
            Program.instance.cutin.Load();
            Program.instance.mate.Load();
            Program.instance.solo.Load();
            Program.instance.puzzle.Print();
            Program.instance.online.Print();
        }


        IEnumerator LoadDiyWallpaperAsync(string path, Transform parent)
        {
            var ie = ABLoader.LoadFromFileAsync(path);
            while (ie.MoveNext())
                yield return null;

            GameObject dynamic = ie.Current;
            dynamic.transform.SetParent(parent, false);
        }

        public Transform ChangeWallpaper(string path)
        {
            if (wallpaper.transform.childCount > 0)
                Destroy(wallpaper.transform.GetChild(0).gameObject);
            if (path == Items.noneCode.ToString())
                return null;

            path = "MasterDuel/" + Program.items.WallpaperCodeToPath(path);
            if (!path.ToLower().Contains("front"))
            {
                Transform frontback = ChangeWallpaper("1130002");
                Destroy(frontback.GetChild(1).gameObject);
                StartCoroutine(LoadDiyWallpaperAsync(path, frontback));
                return frontback;
            }
            GameObject frontLoader = ABLoader.LoadFromFolder(path);
            Destroy(frontLoader);
            var front = frontLoader.transform.GetChild(0).GetComponent<RectTransform>();
            front.SetParent(wallpaper.transform, false);
            for (int i = 0; i < front.transform.childCount; i++)
                front.transform.GetChild(i).gameObject.AddComponent<RectLoopMoveY>();

            foreach (ParticleSystem p in front.GetComponentsInChildren<ParticleSystem>(true))
                p.Play();
            return front;
        }
        public static void ShowWallpaper(float time)
        {
            UIManager instance = Program.instance.ui_;
            instance.wallpaper.gameObject.SetActive(true);
            DOTween.To(() => instance.wallpaper.alpha, x => instance.wallpaper.alpha = x, 1, time);
            foreach (var p in instance.wallpaper.transform.GetComponentsInChildren<ParticleSystem>(true))
            {
                p.gameObject.SetActive(true);
                p.Play();
            }
            foreach (var skeleton in instance.wallpaper.transform.GetComponentsInChildren<SkeletonAnimation>())
            {
                //skeleton.GetComponent<Renderer>().material.SetColor("_Color", new Color(1f, 1f, 1f, 0f));
                skeleton.GetComponent<Renderer>().material.DOFade(1f, time - 0.1f).OnComplete(() => { });

            }
        }
        public static void HideWallpaper(float time)
        {
            DOTween.To(() => Program.instance.ui_.wallpaper.alpha, x => Program.instance.ui_.wallpaper.alpha = x, 0, time).OnComplete(() =>
                Program.instance.ui_.wallpaper.gameObject.SetActive(false));
            foreach (var p in Program.instance.ui_.wallpaper.transform.GetComponentsInChildren<ParticleSystem>(true))
                p.gameObject.SetActive(false);
            foreach (var skeleton in Program.instance.ui_.wallpaper.transform.GetComponentsInChildren<SkeletonAnimation>())
                skeleton.GetComponent<Renderer>().material.DOFade(0f, time - 0.1f).OnComplete(() => { });
        }
        public static void ShowExitButton(float time, Ease ease = Ease.Linear)
        {
            Program.instance.ui_.btnExit.GetComponent<RectTransform>().DOAnchorPosY(PropertyOverrider.NeedMobileLayout() ? -65f : -60f, time).SetEase(ease);
        }

        public static void HideExitButton(float time, Ease ease = Ease.Linear)
        {
            Program.instance.ui_.btnExit.GetComponent<RectTransform>().DOAnchorPosY(PropertyOverrider.NeedMobileLayout() ? 65f : 60f, time).SetEase(ease);
        }

        public static void ShowLine(float time)
        {
            Program.instance.ui_.line.DOFade(1f, time);
        }
        public static void HideLine(float time)
        {
            Program.instance.ui_.line.DOFade(0f, time);
        }
        public static void ShowFPS()
        {
            Program.instance.ui_.fps.gameObject.SetActive(true);
        }
        public static void HideFPS()
        {
            Program.instance.ui_.fps.gameObject.SetActive(false);
        }

        public static void ShowFPSLeft()
        {
            Program.instance.ui_.fps.GetComponent<RectTransform>().anchorMin = new Vector2(0, 1);
            Program.instance.ui_.fps.GetComponent<RectTransform>().anchorMax = new Vector2(0, 1);
            Program.instance.ui_.fps.GetComponent<RectTransform>().anchoredPosition = new Vector2(120, 0);
        }

        public static void ShowFPSRight()
        {
            Program.instance.ui_.fps.GetComponent<RectTransform>().anchorMin = new Vector2(1, 1);
            Program.instance.ui_.fps.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
            Program.instance.ui_.fps.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }

        public static void SetFpsSize(int size)
        {
            Program.instance.ui_.fps.text.fontSize = size;
        }

        #region Popup
        public static void ShowPopupSelection(List<string> selections, Action decideAction, Action cancelAction = null)
        {
            var handle = Addressables.InstantiateAsync("PopupSelection");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupSelection = result.Result.GetComponent<UI.Popup.PopupSelection>();
                popupSelection.args = selections;
                popupSelection.decideAction = decideAction;
                popupSelection.quitAction = cancelAction;
                popupSelection.Show();
            };
        }
        public static void ShowPopupYesOrNo(List<string> selections, Action decideAction, Action cancelAction)
        {
            var handle = Addressables.InstantiateAsync("PopupYesOrNo");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupYesOrNo = result.Result.GetComponent<UI.Popup.PopupYesOrNo>();
                popupYesOrNo.args = selections;
                popupYesOrNo.decideAction = decideAction;
                popupYesOrNo.cancelAction = cancelAction;
                popupYesOrNo.Show();
            };
        }
        public static void ShowPopupConfirm(List<string> selections)
        {
            var handle = Addressables.InstantiateAsync("PopupConfirm");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupConfirm = result.Result.GetComponent<UI.Popup.PopupConfirm>();
                popupConfirm.args = selections;
                popupConfirm.Show();
            };
        }
        public static void ShowPopupInput(List<string> selections, Action<string> decideAction, Action cancelAction, TmpInputValidation.ValidationType type = TmpInputValidation.ValidationType.None)
        {
            var handle = Addressables.InstantiateAsync("PopupInput");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupInput = result.Result.GetComponent<UI.Popup.PopupInput>();
                popupInput.args = selections;
                popupInput.decideAction = decideAction;
                popupInput.cancelAction = cancelAction;
                popupInput.validationType = type;
                popupInput.Show();
            };
        }
        public static void ShowPopupFilter()
        {
            var handle = Addressables.InstantiateAsync("PopupSearchFilter");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupSearchFilter = result.Result.GetComponent<UI.Popup.PopupSearchFilter>();
                popupSearchFilter.Show();
            };
        }
        public static void ShowPopupText(List<string> selections, HorizontalAlignmentOptions alignment = HorizontalAlignmentOptions.Center)
        {
            var handle = Addressables.InstantiateAsync("PopupText");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupText = result.Result.GetComponent<UI.Popup.PopupText>();
                popupText.alignment = alignment;
                popupText.args = selections;
                popupText.Show();
            };
        }
        public static void ShowPopupServer(List<string> selections)
        {
            var handle = Addressables.InstantiateAsync("PopupServer");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var popupServer = result.Result.GetComponent<PopupServer>();
                popupServer.selections = selections;
                popupServer.Show();
            };
        }
        #endregion

        #region UI Tools
        public static void UIBlackIn(float time)
        {
            float width = Screen.width * 1080 * 1.7f / Screen.height;
            Program.instance.ui_.transition.sizeDelta = new Vector2(0, 0);
            DOTween.To(() => Program.instance.ui_.transition.sizeDelta, x => Program.instance.ui_.transition.sizeDelta = x, new Vector2(width, width), time);
        }
        public static void UIBlackOut(float time)
        {
            DOTween.To(() => Program.instance.ui_.transition.sizeDelta, x => Program.instance.ui_.transition.sizeDelta = x, new Vector2(0, 0), time);
        }

        public static void SetCanvasMatch(float match, float duration)
        {
            var instance = Program.instance.ui_;
            var scaler = instance.GetComponent<CanvasScaler>();
            DOTween.To(() => scaler.matchWidthOrHeight, x => scaler.matchWidthOrHeight = x, match, duration);
        }

        public static void ShowCardExpand(int code)
        {
            var handle = Addressables.InstantiateAsync("CardExpand");
            handle.Completed += (result) =>
            {
                result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                var handler = result.Result.GetComponent<CardExpand>();
                InputBlocker = handler;
                handler.Show(code);
            };
        }

        #endregion

        #region Public Static Tools
        public static Vector2 WorldToScreenPoint(Camera camera, Vector3 positon)
        {
            var screenPosition = camera.WorldToScreenPoint(positon);
            var sizeDelta = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta;
            return new Vector2(screenPosition.x * sizeDelta.x / Screen.width, screenPosition.y * sizeDelta.y / Screen.height);
        }
        public static Vector2 ScreenToNoScalerScreenPoint(Vector2 position)
        {
            var sizeDelta = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta;
            return new Vector2(position.x * Screen.width / sizeDelta.x, position.y * Screen.height / sizeDelta.y);
        }
        public static Vector3 ScreenToWorldPoint(Camera camera, Vector2 positon)
        {
            var screenPosition = ScreenToNoScalerScreenPoint(positon);
            return camera.ScreenToWorldPoint(screenPosition);
        }
        public static float ScreenLengthWithoutScalerX(float length)
        {
            var sizeDelta = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta;
            return length * sizeDelta.x / Screen.width;
        }
        public static float ScreenLengthWithScalerX(float length)
        {
            var sizeDelta = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta;
            return length * Screen.width / sizeDelta.x;
        }
        public static float ScreenLengthWithoutScalerY(float length)
        {
            var sizeDelta = Program.instance.ui_.GetComponent<RectTransform>().sizeDelta;
            return length * sizeDelta.y / Screen.height;
        }
        public static Vector2 GetMousePositionToAnchorPosition()
        {
            var returnValue = UserInput.MousePos;
            var uiWidth = 1080f * Screen.width / Screen.height;
            returnValue.x = returnValue.x * uiWidth / Screen.width;
            returnValue.y = returnValue.y * 1080 / Screen.height;
            returnValue.x -= uiWidth / 2f;
            returnValue.y -= 540;
            return returnValue;
        }
        #endregion
    }
}
