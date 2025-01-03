using MDPro3.UI;
using MDPro3.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using static MDPro3.CardRenderer;
using ShadowResolution = UnityEngine.Rendering.Universal.ShadowResolution;

namespace MDPro3
{
    public class Setting : Servant
    {
        [Header("Setting")]
        [SerializeField] private SelectionToggle_Setting defaultToggle;
        [HideInInspector] public SelectionToggle_Setting lastSelectedToggle;
        [HideInInspector] public SelectionButton_Setting lastSelectedButton;

        #region Servant
        public override void Initialize()
        {
            depth = 1;
            showLine = false;
            blackAlpha = 0.6f;
            subBlackAlpha = 0.9f;
            returnServant = Program.instance.menu;
            base.Initialize();

            Manager.GetElement<SelectionButton>("SurrenderButton").SetClickEvent(() => Program.instance.ocgcore.OnDuelResultConfirmed());

            QualitySettings.vSyncCount = 0;

            InitializeVolume();
            InitializeScreenMode();
            InitializeResolution();
            InitializeScale();
            InitializeQuality();
            InitializeFAA();
            InitializeAAA();
            InitializeShadow();
            InitializeFPS();
            InitializeShowFPS();
            InitializeRumble();
            InitializeConfirm();
            InitializeLayout();
            InitializeBackground();
            InitializeBgmBy();
            InitializeCardStyle();
            InitializeCardLanguage();
            InitializeLanguage();

            InitializeAppearance();
            InitializeCharacter();
            InitializeVoice();
            InitializeCloseup();
            InitializeSummon();
            InitializePendulum();
            InitializeCutin();
            InitializeEffect();
            InitializeChain();
            InitializeDice();
            InitializeCoin();
            InitializeAutoInfo();
            InitializeFaceDown();
            InitializePlayerMessage();
            InitializeSystemMessage();
            InitializeAcc();
            InitializeAutoAcc();
            InitializeTimming();
            InitializeAutoRPS();

            InitializePort();

            InitializeExpansions();

            InitializeAbout();

            transform.GetChild(0).gameObject.SetActive(false);
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            if (preDepth <= depth)
            {
                EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
                defaultToggle.ScrollRectToTop();
            }
            RefreshCharacterName();

            if (Program.instance.currentServant == Program.instance.ocgcore)
            {
                Program.instance.currentSubServant = this;
                UIManager.ShowFPSRight();


                if (Program.instance.ocgcore.condition == OcgCore.Condition.Duel)
                {
                    Manager.GetElement("Page1 Duel").SetActive(true);
                    Manager.GetElement("Page2 Watch").SetActive(false);
                    Manager.GetElement("Page3 Replay").SetActive(false);

                    Manager.GetElement("RetryButton").SetActive(false);
                    Manager.GetElement("SurrenderButton").SetActive(true);
                    Manager.GetElement<SelectionButton>("SurrenderButton").SetButtonText(InterString.Get("投降"));
                }
                else if (Program.instance.ocgcore.condition == OcgCore.Condition.Watch)
                {
                    Manager.GetElement("Page1 Duel").SetActive(false);
                    Manager.GetElement("Page2 Watch").SetActive(true);
                    Manager.GetElement("Page3 Replay").SetActive(false);

                    Manager.GetElement("RetryButton").SetActive(false);
                    Manager.GetElement("SurrenderButton").SetActive(true);
                    Manager.GetElement<SelectionButton>("SurrenderButton").SetButtonText(InterString.Get("退出观战"));
                }
                else if (Program.instance.ocgcore.condition == OcgCore.Condition.Replay)
                {
                    Manager.GetElement("Page1 Duel").SetActive(false);
                    Manager.GetElement("Page2 Watch").SetActive(false);
                    Manager.GetElement("Page3 Replay").SetActive(true);

                    Manager.GetElement("RetryButton").SetActive(false);
                    Manager.GetElement("SurrenderButton").SetActive(true);
                    Manager.GetElement<SelectionButton>("SurrenderButton").SetButtonText(InterString.Get("退出回放"));
                }
                Manager.GetElement("Page4 Port").SetActive(false);
                Manager.GetElement("Page5 Expansions").SetActive(false);

            }
            else
            {
                Manager.GetElement("Page1 Duel").SetActive(true);
                Manager.GetElement("Page2 Watch").SetActive(true);
                Manager.GetElement("Page3 Replay").SetActive(true);
                Manager.GetElement("Page4 Port").SetActive(true);
                Manager.GetElement("Page5 Expansions").SetActive(true);

                Manager.GetElement("RetryButton").SetActive(false);
                Manager.GetElement("SurrenderButton").SetActive(false);
            }
        }

        protected override void ApplyHideArrangement(int nextDepth)
        {
            base.ApplyHideArrangement(nextDepth);
            Save();
            if (Program.instance.currentServant == Program.instance.ocgcore)
                UIManager.ShowFPSLeft();
        }

        public override void SelectLastSelectable()
        {
            if(Selected != null)
            {
                if (Selected.TryGetComponent<SelectionButton_Setting>(out _))
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else if (Selected.TryGetComponent<SelectionToggle_Setting>(out _))
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
            }
            else
                EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
        }

        public override void OnReturn()
        {
            if (inTransition) return;
            if(returnAction != null)
            {
                returnAction.Invoke();
                return;
            }
            AudioManager.PlaySE("SE_MENU_CANCEL");
            GameObject selected = EventSystem.current.currentSelectedGameObject;

            if (selected == null)
                OnExit();
            else if (Cursor.lockState == CursorLockMode.None)
                OnExit();
            else if (selected.GetComponent<SelectionButton_Setting>() != null)
            {
                if (lastSelectedToggle != null)
                    EventSystem.current.SetSelectedGameObject(lastSelectedToggle.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
            }
            else
                OnExit();
        }
        #endregion

        #region setting
        public void Save()
        {
            //Non-WholeNumbers Slider Value Need be saved here;

            Config.SetFloat("BgmVol", GetBGMVolum());
            Config.SetFloat("SEVol", GetSEVolum());
            Config.SetFloat("VoiceVol", GetVoiceVolum());
            Config.SetFloat("Scale", Manager.GetElement<SelectionButton_Setting>("Scale").GetSliderValue());
            FpsSave();

            Config.SetFloat("DuelAcc", Manager.GetElement<SelectionButton_Setting>("DuelAcc").GetSliderValue());
            Config.SetFloat("WatchAcc", Manager.GetElement<SelectionButton_Setting>("WatchAcc").GetSliderValue());
            Config.SetFloat("ReplayAcc", Manager.GetElement<SelectionButton_Setting>("ReplayAcc").GetSliderValue());
            Config.Save();
        }

        // System
        #region Volume
        private void InitializeVolume()
        {
            var btnBGM = Manager.GetElement<SelectionButton_Setting>("BGM");
            btnBGM.SetSliderEvent(OnBgmVolChange);
            var volBGM = Config.GetFloat("BgmVol", 0.7f);
            btnBGM.SetSliderValue(volBGM);
            OnBgmVolChange(volBGM);

            var btnSE = Manager.GetElement<SelectionButton_Setting>("SE");
            btnSE.SetSliderEvent(OnSeVolChange);
            var volSE = Config.GetFloat("SEVol", 0.7f);
            btnSE.SetSliderValue(volSE);
            OnSeVolChange(volSE);

            var btnVoice = Manager.GetElement<SelectionButton_Setting>("Voice");
            btnVoice.SetSliderEvent(OnVoiceVolChange);
            btnVoice.SetClickEvent(PlayTestVoice);
            var volVoice = Config.GetFloat("VoiceVol", 0.7f);
            btnVoice.SetSliderValue(volVoice);
            OnVoiceVolChange(volVoice);
        }
        public float GetBGMVolum()
        {
            return Manager.GetElement<SelectionButton_Setting>("BGM").GetSliderValue();
        }
        public float GetSEVolum()
        {
            return Manager.GetElement<SelectionButton_Setting>("SE").GetSliderValue();
        }
        public float GetVoiceVolum()
        {
            return Manager.GetElement<SelectionButton_Setting>("Voice").GetSliderValue();
        }
        private void PlayTestVoice()
        {
            AudioManager.PlayVoiceByResourcePath("VOICE/VoiceSample");
        }
        private void OnBgmVolChange(float vol)
        {
            AudioManager.SetBGMVol(vol);
        }
        private void OnSeVolChange(float vol)
        {
            AudioManager.SetSeVol(vol);
        }
        private void OnVoiceVolChange(float vol)
        {
            AudioManager.SetVoiceVol(vol);
        }
        #endregion

        #region Screen Mode
        private void InitializeScreenMode()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Screen");
            button.SetClickEvent(OnScreenModeChange);

            string value = Config.Get("ScreenMode", "1");
            if (value == "0")
            {
                button.SetModeText(InterString.Get("独占全屏"));
                button.SetNoteText(InterString.Get("独占全屏（仅Windows端有效）"));
            }
            else if (value == "1")
            {
                button.SetModeText(InterString.Get("窗口全屏"));
                button.SetNoteText(InterString.Get("全屏显示"));
            }
            else
            {
                button.SetModeText(InterString.Get("窗口化"));
                button.SetNoteText(InterString.Get("窗口化（仅桌面端有效）"));
            }
        }
        private void OnScreenModeChange()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("显示模式"),
                string.Empty,
                InterString.Get("独占全屏"),
                InterString.Get("窗口全屏"),
                InterString.Get("窗口化")
            };
            UIManager.ShowPopupSelection(selections, OnScreenModeSelection);
        }
        private void OnScreenModeSelection()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            var button = Manager.GetElement<SelectionButton_Setting>("Screen");

            if (selected == InterString.Get("独占全屏"))
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenMode.ExclusiveFullScreen);
                button.SetModeText(InterString.Get("独占全屏"));
                button.SetNoteText(InterString.Get("独占全屏（仅Windows端有效）"));
            }
            else if (selected == InterString.Get("窗口全屏"))
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenMode.FullScreenWindow);
                button.SetModeText(InterString.Get("窗口全屏"));
                button.SetNoteText(InterString.Get("全屏显示"));
            }
            else
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, false);
                button.SetModeText(InterString.Get("窗口化"));
                button.SetNoteText(InterString.Get("窗口化（仅桌面端有效）"));
            }

            Config.Set("ScreenMode", SaveScreenMode(selected));
        }
        private string SaveScreenMode(string value)
        {
            string returnValue = "1";
            if (value == InterString.Get("独占全屏"))
                returnValue = "0";
            else if (value == InterString.Get("窗口全屏"))
                returnValue = "1";
            else if (value == InterString.Get("窗口化"))
                returnValue = "2";
            return returnValue;
        }
        #endregion

        #region Resolution
        private void InitializeResolution()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Resolution");
            button.SetClickEvent(OnResolutionChange);

            string resolution = $"{Screen.width} x {Screen.height}";

#if UNITY_ANDROID
            if (Config.Have("Resolution"))
                resolution = Config.Get("Resolution", "1920 x 1080");
            Screen.SetResolution(int.Parse(Regex.Split(resolution, " x ")[0]), int.Parse(Regex.Split(resolution, " x ")[1]), FullScreenMode.FullScreenWindow);
#endif
            button.SetModeText(resolution);

            SystemEvent.OnResolutionChange += SetResolutionText;
        }
        private void OnResolutionChange()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("分辨率"),
                string.Empty
            };
            foreach (var resolution in Screen.resolutions)
            {
                string selection = Regex.Split(resolution.ToString(), " @ ")[0];
#if !UNITY_EDITOR && UNITY_ANDROID
                int height = int.Parse(Regex.Split(selection, " x ")[0]);
                int width = int.Parse(Regex.Split(selection, " x ")[1]);
                if (height > width)
                {
                    var cache = height;
                    height = width;
                    width = cache;
                }
                if (height > 540)
                {
                    string r = (width * 540 / height).ToString() + " x " + 540.ToString();
                    if(!selections.Contains(r))
                        selections.Add(r);
                }
                if(height > 720)
                {
                    string r = (width * 720 / height).ToString() + " x " + 720.ToString();
                    if (!selections.Contains(r))
                        selections.Add(r);
                }
                if (height > 1080)
                {
                    string r = (width * 1080 / height).ToString() + " x " + 1080.ToString();
                    if (!selections.Contains(r))
                        selections.Add(r);
                }
                if (height > 1200)
                {
                    string r = (width * 1200 / height).ToString() + " x " + 1200.ToString();
                    if (!selections.Contains(r))
                        selections.Add(r);
                }
                if (height > 1440)
                {
                    string r = (width * 1440 / height).ToString() + " x " + 1440.ToString();
                    if (!selections.Contains(r))
                        selections.Add(r);
                }
                if (height > 1600)
                {
                    string r = (width * 1600 / height).ToString() + " x " + 1600.ToString();
                    if (!selections.Contains(r))
                        selections.Add(r);
                }
                if (height > 2160)
                {
                    string r = (width * 2160 / height).ToString() + " x " + 2160.ToString();
                    if (!selections.Contains(r))
                        selections.Add(r);
                }
                selection = width.ToString() + " x " + height.ToString();
#endif
                if (!selections.Contains(selection))
                    selections.Add(selection);
            }

            //selections.Add("3600 x 1620");

            UIManager.ShowPopupSelection(selections, OnResolutioSelection);
        }
        private void OnResolutioSelection()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            Screen.SetResolution(int.Parse(Regex.Split(selected, " x ")[0]), int.Parse(Regex.Split(selected, " x ")[1]), Screen.fullScreen);
            SetResolutionText();
            Config.Set("Resolution", selected);
        }
        private void SetResolutionText()
        {
            string resolution = $"{Screen.width} x {Screen.height}";
            var button = Manager.GetElement<SelectionButton_Setting>("Resolution");
            button.SetModeText(resolution);
        }
        #endregion

        #region Scale
        private void InitializeScale()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Scale");
            button.SetSliderEvent(OnScaleChange);

            var defau = 1f;
#if UNITY_ANDROID
            defau = 0.5f;
#endif
            var configScale = Config.GetFloat("Scale", defau);
            button.SetSliderValue(configScale);
            OnScaleChange(configScale);
        }
        private void OnScaleChange(float vol)
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Scale");

            string value = vol.ToString();
            value = value.Length > 4 ? value.Substring(0, 4) : value;
            button.SetModeText(value);
            Program.instance.camera_.urpAsset.renderScale = float.Parse(value);
        }
        #endregion

        #region Quality
        private void InitializeQuality()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Quality");
            button.SetSliderEvent(OnQualityChange);

            var configQuality = Config.GetFloat("Quality", 2f);
            button.SetSliderValue(configQuality);
            OnQualityChange(configQuality);
        }
        private void OnQualityChange(float value)
        {
            string qualityText = (int)value switch
            {
                0 => InterString.Get("非常低"),
                1 => InterString.Get("低"),
                2 => InterString.Get("中等"),
                3 => InterString.Get("高"),
                4 => InterString.Get("非常高"),
                5 => InterString.Get("极致"),
                _ => InterString.Get("中等"),
            };
            Config.SetFloat("Quality", (int)value);

            var button = Manager.GetElement<SelectionButton_Setting>("Quality");
            button.SetModeText(qualityText);
        }
        #endregion

        #region FAA
        private void InitializeFAA()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("FAA");
            button.SetSliderEvent(OnFAAChange);

            var configFAA = Config.GetFloat("FAA", 1f);
            button.SetSliderValue(configFAA);
            OnFAAChange(configFAA);
        }
        private void OnFAAChange(float value)
        {
#if UNITY_ANDROID
            value = 1f;
#endif
            var modeText = "Off";
            switch ((int)value)
            {
                case 1:
                    modeText = InterString.Get("Off");
                    Program.instance.camera_.urpAsset.msaaSampleCount = 1;
                    Program.instance.camera_.urpAssetForUI.msaaSampleCount = 1;
                    break;
                case 2:
                    modeText = "MSAA 2x";
                    Program.instance.camera_.urpAsset.msaaSampleCount = 2;
                    Program.instance.camera_.urpAssetForUI.msaaSampleCount = 2;
                    break;
                case 3:
                    modeText = "MSAA 4x";
                    Program.instance.camera_.urpAsset.msaaSampleCount = 4;
                    Program.instance.camera_.urpAssetForUI.msaaSampleCount = 4;
                    break;
                case 4:
                    modeText = "MSAA 8x";
                    Program.instance.camera_.urpAsset.msaaSampleCount = 8;
                    Program.instance.camera_.urpAssetForUI.msaaSampleCount = 8;
                    break;
            }

            var button = Manager.GetElement<SelectionButton_Setting>("FAA");
            button.SetModeText(modeText);
            Config.SetFloat("FAA", value);
        }

        #endregion

        #region AAA
        private void InitializeAAA()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("AAA");
            button.SetSliderEvent(OnAAAChange);

            var configAAA = Config.GetFloat("AAA", 0f);
            button.SetSliderValue(configAAA);
            OnAAAChange(configAAA);
        }
        private void OnAAAChange(float value)
        {
            var cameraData3D = Program.instance.camera_.cameraMain.GetUniversalAdditionalCameraData();
            OnFAAChange(Manager.GetElement<SelectionButton_Setting>("FAA").GetSliderValue());

            var modeText = "Off";
            switch ((int)value)
            {
                case 0:
                    modeText = InterString.Get("Off");
                    cameraData3D.antialiasing = AntialiasingMode.None;
                    break;
                case 1:
                    modeText = "FAA";
                    cameraData3D.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
                    break;
                case 2:
                    modeText = "SMAA Low";
                    cameraData3D.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                    cameraData3D.antialiasingQuality = AntialiasingQuality.Low;
                    break;
                case 3:
                    modeText = "SMAA Medium";
                    cameraData3D.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                    cameraData3D.antialiasingQuality = AntialiasingQuality.Medium;
                    break;
                case 4:
                    modeText = "SMAA High";
                    cameraData3D.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                    cameraData3D.antialiasingQuality = AntialiasingQuality.High;
                    break;
                case 5:
                    modeText = "TAA";
                    cameraData3D.antialiasing = AntialiasingMode.TemporalAntiAliasing;
                    Program.instance.camera_.urpAsset.msaaSampleCount = 1;
                    Program.instance.camera_.urpAssetForUI.msaaSampleCount = 1;
                    break;
            }

            var button = Manager.GetElement<SelectionButton_Setting>("AAA");
            button.SetModeText(modeText);
            Config.SetFloat("AAA", value);
        }

        #endregion

        #region Shadow
        private void InitializeShadow()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Shadow");
            button.SetSliderEvent(OnShadowChange);

            var configShadow = Config.GetFloat("Shadow", 0f);
            button.SetSliderValue(configShadow);
            OnShadowChange(configShadow);
        }

        public void OnShadowChange(float value)
        {
            SROptions sr = new SROptions();
            var modeText = InterString.Get("非常低");
            switch ((int)value)
            {
                case 0:
                    modeText = InterString.Get("非常低");
                    sr.MainLightShadowResolution = ShadowResolution._256;
                    sr.SupportsSoftShadows = false;
                    break;
                case 1:
                    modeText = InterString.Get("低");
                    sr.MainLightShadowResolution = ShadowResolution._512;
                    sr.SupportsSoftShadows = false;
                    break;
                case 2:
                    modeText = InterString.Get("中等");
                    sr.MainLightShadowResolution = ShadowResolution._1024;
                    sr.SupportsSoftShadows = false;
                    break;
                case 3:
                    modeText = InterString.Get("高");
                    sr.MainLightShadowResolution = ShadowResolution._2048;
                    sr.SupportsSoftShadows = true;
                    break;
                case 4:
                    modeText = InterString.Get("非常高");
                    sr.MainLightShadowResolution = ShadowResolution._4096;
                    sr.SupportsSoftShadows = true;
                    break;
            }

            var button = Manager.GetElement<SelectionButton_Setting>("Shadow");
            button.SetModeText(modeText);

            Config.SetFloat("Shadow", value);
        }
        #endregion

        #region FPS
        private void InitializeFPS()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("FPS");
            button.SetSliderEvent(OnFpsChange);

            var defau = 60f;
            if(DeviceInfo.OnMobile())
                defau = 30f;
            var configFPS = Config.GetFloat("FPS", defau);
            if (configFPS == 0f)
                configFPS = 29f;
            button.SetSliderValue(configFPS);
            OnFpsChange(configFPS);
        }
        private void OnFpsChange(float value)
        {
            QualitySettings.vSyncCount = 0;
            if (value == 29f)
                value = 0f;
            Application.targetFrameRate = (int)value;
            var button = Manager.GetElement<SelectionButton_Setting>("FPS");
            button.SetModeText(value.ToString());
        }
        private void FpsSave()
        {
            var config = Manager.GetElement<SelectionButton_Setting>("FPS").GetSliderValue();
            if (config == 29f)
                config = 0f;
            Config.SetFloat("FPS", config);
        }
        #endregion

        #region ShowFPS
        private void InitializeShowFPS()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ShowFPS");
            button.SetClickEvent(OnShowFPSClicked);

            var config = Config.GetBool("ShowFPS", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
            if (config)
                UIManager.ShowFPS();
            else
                UIManager.HideFPS();
        }
        private void OnShowFPSClicked()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ShowFPS");
            var config = Config.GetBool("ShowFPS", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            if (config)
                UIManager.HideFPS();
            else
                UIManager.ShowFPS();
            Config.SetBool("ShowFPS", !config);
        }
        #endregion

        #region Rumble
        private void InitializeRumble()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Rumble");
            button.SetClickEvent(OnRumbleClicked);

            var config = Config.GetBool("Rumble", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnRumbleClicked()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Rumble");
            var config = Config.GetBool("Rumble", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("Rumble", !config);
        }
        #endregion

        #region Confirm
        private void InitializeConfirm()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Confirm");
            button.SetClickEvent(OnConfirmClicked);

            var config = Config.GetBool("Confirm", false);
            button.SetModeText(InterString.Get(config ? "左" : "右"));
        }

        private void OnConfirmClicked()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Confirm");
            var config = Config.GetBool("Confirm", false);
            button.SetModeText(InterString.Get(config ? "右" : "左"));
            Config.SetBool("Confirm", !config);
        }
        #endregion

        #region Layout
        private void InitializeLayout()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Layout");
            button.SetClickEvent(OnLayoutClicked);

            var config = Config.GetFloat("Layout", 0f);
            var value = InterString.Get("自动判断");
            if(config == 1f)
                value = InterString.Get("桌面布局");
            else if (config == 2f)
                value = InterString.Get("移动布局");
            button.SetModeText(value);
        }

        private void OnLayoutClicked()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能更改此选项。"));
                return;
            }

            List<string> selections = new List<string>
            {
                InterString.Get("UI布局"),
                string.Empty,
                InterString.Get("自动判断"),
                InterString.Get("桌面布局"),
                InterString.Get("移动布局")
            };
            UIManager.ShowPopupSelection(selections, OnLayoutSelection);
        }
        private void OnLayoutSelection()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            var button = Manager.GetElement<SelectionButton_Setting>("Layout");
            button.SetModeText(selected);

            var config = 0f;
            if (selected == InterString.Get("桌面布局"))
                config = 1f;
            else if (selected == InterString.Get("移动布局"))
                config = 2f;
            Config.SetFloat("Layout", config);

            UIManager.ChangeLayout();
        }
        #endregion

        #region Background
        private void InitializeBackground()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Background");
            button.SetClickEvent(OnBackgroundClicked);

            var id = int.Parse(Config.Get("Background", "0"));
            Program.instance.background_.Change(id);
            ChangeBackgroundModeText();
        }

        private void ChangeBackgroundModeText()
        {
            var id = int.Parse(Config.Get("Background", "0"));
            var value = InterString.Get("随机");
            if (id != 0)
                if (!BackgroundManager.backgrounds.TryGetValue(id, out value))
                {
                    id = 1;
                    value = "Classic";
                }
            if (string.IsNullOrEmpty(value))
                value = InterString.Get("随机");

            var button = Manager.GetElement<SelectionButton_Setting>("Background");
            button.SetModeText(value);
        }

        private void OnBackgroundClicked()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("更换背景"),
                string.Empty,
                InterString.Get("随机"),
            };
            foreach (var background in BackgroundManager.backgrounds)
                selections.Add(background.Value);

            UIManager.ShowPopupSelection(selections, OnBackgroundSelection);
        }

        private void OnBackgroundSelection()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            var id = Program.instance.background_.GetIDByName(selected);
            Config.Set("Background", id.ToString());
            Program.instance.background_.Change(id);
            ChangeBackgroundModeText();
        }

        #endregion

        #region BgmBy
        private void InitializeBgmBy()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("BgmBy");
            button.SetClickEvent(OnBgmByClicked);
            var config = Config.GetBool("BGMbyMySide", true);
            button.SetModeText(InterString.Get(config ? "我方" : "对方"));
        }

        private void OnBgmByClicked()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("BgmBy");
            var config = Config.GetBool("BGMbyMySide", true);
            button.SetModeText(InterString.Get(config ? "对方" : "我方"));
            Config.SetBool("BGMbyMySide", !config);
        }
        #endregion

        #region CardStyle
        private void InitializeCardStyle()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("CardStyle");
            button.SetClickEvent(OnCardStyleChange);
            button.SetModeText(Config.Get("CardStyle", CardStyle.OCG_TCG.ToString()));
        }

        private void OnCardStyleChange()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能更改此选项。"));
                return;
            }

            List<string> selections = new List<string>
            {
                InterString.Get("卡图风格"),
                string.Empty
            };
            var values = Enum.GetValues(typeof(CardRenderer.CardStyle));
            foreach (var value in values)
                selections.Add(value.ToString());
            UIManager.ShowPopupSelection(selections, OnCardStyleSelection);
        }
        private void OnCardStyleSelection()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            Config.Set("CardStyle", selected);
            var button = Manager.GetElement<SelectionButton_Setting>("CardStyle");
            button.SetModeText(selected);
            UIManager.ChangeLanguage();
        }
        #endregion

        #region CardLanguage
        private void InitializeCardLanguage()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("CardLanguage");
            button.SetClickEvent(OnCardLanguageClicked);
            button.SetModeText(InterString.Get(Language.GetCardConfig()));
        }
        private void OnCardLanguageClicked()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能更改此选项。"));
                return;
            }

            List<string> selections = new List<string>
            {
                InterString.Get("卡图语言"),
                string.Empty
            };
            DirectoryInfo[] infos = new DirectoryInfo(Program.localesPath).GetDirectories();
            foreach (DirectoryInfo info in infos)
                selections.Add(InterString.Get(info.Name));
            UIManager.ShowPopupSelection(selections, OnCardLanguageSelection);
        }
        private void OnCardLanguageSelection()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            var button = Manager.GetElement<SelectionButton_Setting>("CardLanguage");
            button.SetModeText(selected);
            Config.Set(Language.CardConfigName, InterString.GetOriginal(selected));
            UIManager.ChangeLanguage();
        }
        #endregion

        #region Language
        private void InitializeLanguage()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Language");
            button.SetClickEvent(OnLanguageClicked);
            button.SetModeText(InterString.Get(Language.GetConfig()));
        }
        private void OnLanguageClicked()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能更改此选项。"));
                return;
            }

            List<string> selections = new List<string>
            {
                InterString.Get("语言"),
                string.Empty
            };
            DirectoryInfo[] infos = new DirectoryInfo(Program.localesPath).GetDirectories();
            foreach (DirectoryInfo info in infos)
                selections.Add(InterString.Get(info.Name));
            UIManager.ShowPopupSelection(selections, OnLanguageSelection);
        }
        private void OnLanguageSelection()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            var button = Manager.GetElement<SelectionButton_Setting>("Language");
            button.SetModeText(selected);
            Config.Set(Language.ConfigName, InterString.GetOriginal(selected));
            UIManager.ChangeLanguage();
        }
        #endregion

        // Duel
        #region Appearance
        private void InitializeAppearance()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAppearance");
            button.SetClickEvent(OnDuelAppearcanceClick);

            button = Manager.GetElement<SelectionButton_Setting>("WatchAppearance");
            button.SetClickEvent(OnWatchAppearcanceClick);

            button = Manager.GetElement<SelectionButton_Setting>("ReplayAppearance");
            button.SetClickEvent(OnReplayAppearcanceClick);

            RefreshAppearanceModeText();
        }
        private void OnDuelAppearcanceClick()
        {
            Program.instance.appearance.SwitchCondition(Appearance.Condition.Duel);
            if (Program.instance.currentSubServant == this)
                Program.instance.ShowSubServant(Program.instance.appearance);
            else
                Program.instance.ShiftToServant(Program.instance.appearance);
        }
        private void OnWatchAppearcanceClick()
        {
            Program.instance.appearance.SwitchCondition(Appearance.Condition.Watch);
            if (Program.instance.currentSubServant == this)
                Program.instance.ShowSubServant(Program.instance.appearance);
            else
                Program.instance.ShiftToServant(Program.instance.appearance);
        }
        private void OnReplayAppearcanceClick()
        {
            Program.instance.appearance.SwitchCondition(Appearance.Condition.Replay);
            if (Program.instance.currentSubServant == this)
                Program.instance.ShowSubServant(Program.instance.appearance);
            else
                Program.instance.ShiftToServant(Program.instance.appearance);
        }
        public void RefreshAppearanceModeText()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAppearance");
            button.SetModeText(Config.Get("DuelPlayerName0", "@ui"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchAppearance");
            button.SetModeText(Config.Get("WatchPlayerName0", "@ui"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayAppearance");
            button.SetModeText(Config.Get("ReplayPlayerName0", "@ui"));
        }
        #endregion

        #region Character

        private void InitializeCharacter()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCharacter");
            button.SetClickEvent(OnDuelCharacterClick);

            button = Manager.GetElement<SelectionButton_Setting>("WatchCharacter");
            button.SetClickEvent(OnWatchCharacterClick);

            button = Manager.GetElement<SelectionButton_Setting>("ReplayCharacter");
            button.SetClickEvent(OnReplayCharacterClick);

            RefreshCharacterName();
        }
        private void OnDuelCharacterClick()
        {
            Program.instance.character.SwitchCondition(SelectCharacter.Condition.Duel);
            if (Program.instance.currentSubServant == this)
                Program.instance.ShowSubServant(Program.instance.character);
            else
                Program.instance.ShiftToServant(Program.instance.character);
        }
        private void OnWatchCharacterClick()
        {
            Program.instance.character.SwitchCondition(SelectCharacter.Condition.Watch);
            if (Program.instance.currentSubServant == this)
                Program.instance.ShowSubServant(Program.instance.character);
            else
                Program.instance.ShiftToServant(Program.instance.character);
        }
        private void OnReplayCharacterClick()
        {
            Program.instance.character.SwitchCondition(SelectCharacter.Condition.Replay);
            if (Program.instance.currentSubServant == this)
                Program.instance.ShowSubServant(Program.instance.character);
            else
                Program.instance.ShiftToServant(Program.instance.character);
        }
        public void RefreshCharacterName()
        {
            if (Program.instance.character.characters == null)
                return;

            var button = Manager.GetElement<SelectionButton_Setting>("DuelCharacter");
            var characterName = Program.instance.character.characters.GetName(Config.Get("DuelCharacter0", VoiceHelper.defaultCharacter));
            button.SetModeText(characterName);

            button = Manager.GetElement<SelectionButton_Setting>("WatchCharacter");
            characterName = Program.instance.character.characters.GetName(Config.Get("WatchCharacter0", VoiceHelper.defaultCharacter));
            button.SetModeText(characterName);

            button = Manager.GetElement<SelectionButton_Setting>("ReplayCharacter");
            characterName = Program.instance.character.characters.GetName(Config.Get("ReplayCharacter0", VoiceHelper.defaultCharacter));
            button.SetModeText(characterName);
        }

        #endregion

        #region Voice
        private void InitializeVoice()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelVoice");
            button.SetClickEvent(OnDuelVoiceClick);
            var config = Config.GetBool("DuelVoice", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchVoice");
            button.SetClickEvent(OnWatchVoiceClick);
            config = Config.GetBool("WatchVoice", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayVoice");
            button.SetClickEvent(OnReplayVoiceClick);
            config = Config.GetBool("ReplayVoice", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelVoiceClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelVoice");
            var config = Config.GetBool("DuelVoice", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelVoice", !config);

            Program.instance.ocgcore.CheckCharaFace();
        }
        private void OnWatchVoiceClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchVoice");
            var config = Config.GetBool("WatchVoice", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchVoice", !config);

            Program.instance.ocgcore.CheckCharaFace();
        }
        private void OnReplayVoiceClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayVoice");
            var config = Config.GetBool("ReplayVoice", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayVoice", !config);

            Program.instance.ocgcore.CheckCharaFace();
        }
        #endregion

        #region Closeup
        private void InitializeCloseup()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCloseup");
            button.SetClickEvent(OnDuelCloseupClick);
            var config = Config.GetBool("DuelCloseup", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchCloseup");
            button.SetClickEvent(OnWatchCloseupClick);
            config = Config.GetBool("WatchCloseup", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayCloseup");
            button.SetClickEvent(OnReplayCloseupClick);
            config = Config.GetBool("ReplayCloseup", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelCloseupClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCloseup");
            var config = Config.GetBool("DuelCloseup", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelCloseup", !config);

            Program.instance.ocgcore.RefreshAllCardsLabel();
        }
        private void OnWatchCloseupClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchCloseup");
            var config = Config.GetBool("WatchCloseup", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchCloseup", !config);

            Program.instance.ocgcore.RefreshAllCardsLabel();
        }
        private void OnReplayCloseupClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayCloseup");
            var config = Config.GetBool("ReplayCloseup", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayCloseup", !config);

            Program.instance.ocgcore.RefreshAllCardsLabel();
        }
        #endregion

        #region Summon
        private void InitializeSummon()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelSummon");
            button.SetClickEvent(OnDuelSummonClick);
            var config = Config.GetBool("DuelSummon", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchSummon");
            button.SetClickEvent(OnWatchSummonClick);
            config = Config.GetBool("WatchSummon", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplaySummon");
            button.SetClickEvent(OnReplaySummonClick);
            config = Config.GetBool("ReplaySummon", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelSummonClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelSummon");
            var config = Config.GetBool("DuelSummon", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelSummon", !config);
        }
        private void OnWatchSummonClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchSummon");
            var config = Config.GetBool("WatchSummon", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchSummon", !config);
        }
        private void OnReplaySummonClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplaySummon");
            var config = Config.GetBool("ReplaySummon", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplaySummon", !config);
        }
        #endregion

        #region Pendulum
        private void InitializePendulum()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelPendulum");
            button.SetClickEvent(OnDuelPendulumClick);
            var config = Config.GetBool("DuelPendulum", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchPendulum");
            button.SetClickEvent(OnWatchPendulumClick);
            config = Config.GetBool("WatchPendulum", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayPendulum");
            button.SetClickEvent(OnReplayPendulumClick);
            config = Config.GetBool("ReplayPendulum", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelPendulumClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelPendulum");
            var config = Config.GetBool("DuelPendulum", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelPendulum", !config);
        }
        private void OnWatchPendulumClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchPendulum");
            var config = Config.GetBool("WatchPendulum", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchPendulum", !config);
        }
        private void OnReplayPendulumClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayPendulum");
            var config = Config.GetBool("ReplayPendulum", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayPendulum", !config);
        }
        #endregion

        #region Cutin
        private void InitializeCutin()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCutin");
            button.SetClickEvent(OnDuelCutinClick);
            var config = Config.GetBool("DuelCutin", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchCutin");
            button.SetClickEvent(OnWatchCutinClick);
            config = Config.GetBool("WatchCutin", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayCutin");
            button.SetClickEvent(OnReplayCutinClick);
            config = Config.GetBool("ReplayCutin", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelCutinClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCutin");
            var config = Config.GetBool("DuelCutin", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelCutin", !config);
        }
        private void OnWatchCutinClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchCutin");
            var config = Config.GetBool("WatchCutin", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchCutin", !config);
        }
        private void OnReplayCutinClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayCutin");
            var config = Config.GetBool("ReplayCutin", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayCutin", !config);
        }
        #endregion

        #region Effect
        private void InitializeEffect()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelEffect");
            button.SetClickEvent(OnDuelEffectClick);
            var config = Config.GetBool("DuelEffect", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchEffect");
            button.SetClickEvent(OnWatchEffectClick);
            config = Config.GetBool("WatchEffect", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayEffect");
            button.SetClickEvent(OnReplayEffectClick);
            config = Config.GetBool("ReplayEffect", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelEffectClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelEffect");
            var config = Config.GetBool("DuelEffect", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelEffect", !config);
        }
        private void OnWatchEffectClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchEffect");
            var config = Config.GetBool("WatchEffect", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchEffect", !config);
        }
        private void OnReplayEffectClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayEffect");
            var config = Config.GetBool("ReplayEffect", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayEffect", !config);
        }
        #endregion

        #region Chain
        private void InitializeChain()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelChain");
            button.SetClickEvent(OnDuelChainClick);
            var config = Config.GetBool("DuelChain", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchChain");
            button.SetClickEvent(OnWatchChainClick);
            config = Config.GetBool("WatchChain", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayChain");
            button.SetClickEvent(OnReplayChainClick);
            config = Config.GetBool("ReplayChain", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelChainClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelChain");
            var config = Config.GetBool("DuelChain", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelChain", !config);
        }
        private void OnWatchChainClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchChain");
            var config = Config.GetBool("WatchChain", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchChain", !config);
        }
        private void OnReplayChainClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayChain");
            var config = Config.GetBool("ReplayChain", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayChain", !config);
        }
        #endregion

        #region Dice
        private void InitializeDice()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelDice");
            button.SetClickEvent(OnDuelDiceClick);
            var config = Config.GetBool("DuelDice", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchDice");
            button.SetClickEvent(OnWatchDiceClick);
            config = Config.GetBool("WatchDice", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayDice");
            button.SetClickEvent(OnReplayDiceClick);
            config = Config.GetBool("ReplayDice", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelDiceClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelDice");
            var config = Config.GetBool("DuelDice", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelDice", !config);
        }
        private void OnWatchDiceClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchDice");
            var config = Config.GetBool("WatchDice", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchDice", !config);
        }
        private void OnReplayDiceClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayDice");
            var config = Config.GetBool("ReplayDice", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayDice", !config);
        }
        #endregion

        #region Coin
        private void InitializeCoin()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCoin");
            button.SetClickEvent(OnDuelCoinClick);
            var config = Config.GetBool("DuelCoin", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchCoin");
            button.SetClickEvent(OnWatchCoinClick);
            config = Config.GetBool("WatchCoin", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayCoin");
            button.SetClickEvent(OnReplayCoinClick);
            config = Config.GetBool("ReplayCoin", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelCoinClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelCoin");
            var config = Config.GetBool("DuelCoin", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelCoin", !config);
        }
        private void OnWatchCoinClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchCoin");
            var config = Config.GetBool("WatchCoin", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchCoin", !config);
        }
        private void OnReplayCoinClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayCoin");
            var config = Config.GetBool("ReplayCoin", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayCoin", !config);
        }
        #endregion

        #region AutoInfo
        private void InitializeAutoInfo()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAutoInfo");
            button.SetClickEvent(OnDuelAutoInfoClick);
            var config = Config.GetBool("DuelAutoInfo", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchAutoInfo");
            button.SetClickEvent(OnWatchAutoInfoClick);
            config = Config.GetBool("WatchAutoInfo", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayAutoInfo");
            button.SetClickEvent(OnReplayAutoInfoClick);
            config = Config.GetBool("ReplayAutoInfo", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelAutoInfoClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAutoInfo");
            var config = Config.GetBool("DuelAutoInfo", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelAutoInfo", !config);
        }
        private void OnWatchAutoInfoClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchAutoInfo");
            var config = Config.GetBool("WatchAutoInfo", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchAutoInfo", !config);
        }
        private void OnReplayAutoInfoClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayAutoInfo");
            var config = Config.GetBool("ReplayAutoInfo", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayAutoInfo", !config);
        }
        #endregion

        #region FaceDown
        private void InitializeFaceDown()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelFaceDown");
            button.SetClickEvent(OnDuelFaceDownClick);
            var config = Config.GetBool("DuelFaceDown", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchFaceDown");
            button.SetClickEvent(OnWatchFaceDownClick);
            config = Config.GetBool("WatchFaceDown", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayFaceDown");
            button.SetClickEvent(OnReplayFaceDownClick);
            config = Config.GetBool("ReplayFaceDown", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelFaceDownClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelFaceDown");
            var config = Config.GetBool("DuelFaceDown", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelFaceDown", !config);

            foreach (var card in Program.instance.ocgcore.cards)
                card.ShowFaceDownCardOrNot(card.NeedShowFaceDownCard());
        }
        private void OnWatchFaceDownClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchFaceDown");
            var config = Config.GetBool("WatchFaceDown", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchFaceDown", !config);

            foreach (var card in Program.instance.ocgcore.cards)
                card.ShowFaceDownCardOrNot(card.NeedShowFaceDownCard());
        }
        private void OnReplayFaceDownClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayFaceDown");
            var config = Config.GetBool("ReplayFaceDown", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayFaceDown", !config);

            foreach (var card in Program.instance.ocgcore.cards)
                card.ShowFaceDownCardOrNot(card.NeedShowFaceDownCard());
        }
        #endregion

        #region PlayerMessage
        private void InitializePlayerMessage()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelPlayerMessage");
            button.SetClickEvent(OnDuelPlayerMessageClick);
            var config = Config.GetBool("DuelPlayerMessage", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchPlayerMessage");
            button.SetClickEvent(OnWatchPlayerMessageClick);
            config = Config.GetBool("WatchPlayerMessage", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayPlayerMessage");
            button.SetClickEvent(OnReplayPlayerMessageClick);
            config = Config.GetBool("ReplayPlayerMessage", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelPlayerMessageClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelPlayerMessage");
            var config = Config.GetBool("DuelPlayerMessage", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelPlayerMessage", !config);
        }
        private void OnWatchPlayerMessageClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchPlayerMessage");
            var config = Config.GetBool("WatchPlayerMessage", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchPlayerMessage", !config);
        }
        private void OnReplayPlayerMessageClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayPlayerMessage");
            var config = Config.GetBool("ReplayPlayerMessage", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayPlayerMessage", !config);
        }
        #endregion

        #region SystemMessage
        private void InitializeSystemMessage()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelSystemMessage");
            button.SetClickEvent(OnDuelSystemMessageClick);
            var config = Config.GetBool("DuelSystemMessage", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchSystemMessage");
            button.SetClickEvent(OnWatchSystemMessageClick);
            config = Config.GetBool("WatchSystemMessage", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplaySystemMessage");
            button.SetClickEvent(OnReplaySystemMessageClick);
            config = Config.GetBool("ReplaySystemMessage", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelSystemMessageClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelSystemMessage");
            var config = Config.GetBool("DuelSystemMessage", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelSystemMessage", !config);
        }
        private void OnWatchSystemMessageClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchSystemMessage");
            var config = Config.GetBool("WatchSystemMessage", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchSystemMessage", !config);
        }
        private void OnReplaySystemMessageClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplaySystemMessage");
            var config = Config.GetBool("ReplaySystemMessage", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplaySystemMessage", !config);
        }
        #endregion

        #region Acc
        private void InitializeAcc()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAcc");
            button.SetSliderEvent(OnDuelAccChange);
            var config = Config.GetFloat("DuelAcc", 2f);
            button.SetSliderValue(config);
            OnDuelAccChange(config);

            button = Manager.GetElement<SelectionButton_Setting>("WatchAcc");
            button.SetSliderEvent(OnWatchAccChange);
            config = Config.GetFloat("WatchAcc", 2f);
            button.SetSliderValue(config);
            OnWatchAccChange(config);

            button = Manager.GetElement<SelectionButton_Setting>("ReplayAcc");
            button.SetSliderEvent(OnReplayAccChange);
            config = Config.GetFloat("ReplayAcc", 2f);
            button.SetSliderValue(config);
            OnReplayAccChange(config);
        }
        private void OnDuelAccChange(float value)
        {
            string result = value.ToString();
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAcc");
            button.SetModeText(result.Length > 4 ? result[..4] : result);
            if (Program.instance.ocgcore.showing)
                if (Program.instance.ocgcore.condition == OcgCore.Condition.Duel)
                    if (Program.instance.ocgcore.accing)
                        Program.instance.ocgcore.OnAcc();
        }
        private void OnWatchAccChange(float value)
        {
            string result = value.ToString();
            var button = Manager.GetElement<SelectionButton_Setting>("WatchAcc");
            button.SetModeText(result.Length > 4 ? result[..4] : result);
            if (Program.instance.ocgcore.showing)
                if (Program.instance.ocgcore.condition == OcgCore.Condition.Watch)
                    if (Program.instance.ocgcore.accing)
                        Program.instance.ocgcore.OnAcc();
        }
        private void OnReplayAccChange(float value)
        {
            string result = value.ToString();
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayAcc");
            button.SetModeText(result.Length > 4 ? result[..4] : result);
            if (Program.instance.ocgcore.showing)
                if (Program.instance.ocgcore.condition == OcgCore.Condition.Replay)
                    if (Program.instance.ocgcore.accing)
                        Program.instance.ocgcore.OnAcc();
        }

        #endregion

        #region AutoAcc
        private void InitializeAutoAcc()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAutoAcc");
            button.SetClickEvent(OnDuelAutoAccClick);
            var config = Config.GetBool("DuelAutoAcc", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("WatchAutoAcc");
            button.SetClickEvent(OnWatchAutoAccClick);
            config = Config.GetBool("WatchAutoAcc", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));

            button = Manager.GetElement<SelectionButton_Setting>("ReplayAutoAcc");
            button.SetClickEvent(OnReplayAutoAccClick);
            config = Config.GetBool("ReplayAutoAcc", true);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnDuelAutoAccClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("DuelAutoAcc");
            var config = Config.GetBool("DuelAutoAcc", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("DuelAutoAcc", !config);
        }
        private void OnWatchAutoAccClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("WatchAutoAcc");
            var config = Config.GetBool("WatchAutoAcc", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("WatchAutoAcc", !config);
        }
        private void OnReplayAutoAccClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ReplayAutoAcc");
            var config = Config.GetBool("ReplayAutoAcc", true);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("ReplayAutoAcc", !config);
        }
        #endregion

        #region Timming
        private void InitializeTimming()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Timming");
            button.SetClickEvent(OnTimmingClick);
            var config = Config.GetBool("Timming", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnTimmingClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Timming");
            var config = Config.GetBool("Timming", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("Timming", !config);
        }
        #endregion

        #region AutoRPS
        private void InitializeAutoRPS()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("AutoRPS");
            button.SetClickEvent(OnAutoRPSClick);
            var config = Config.GetBool("AutoRPS", false);
            button.SetModeText(InterString.Get(config ? "开" : "关"));
        }
        private void OnAutoRPSClick()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("AutoRPS");
            var config = Config.GetBool("AutoRPS", false);
            button.SetModeText(InterString.Get(config ? "关" : "开"));
            Config.SetBool("AutoRPS", !config);
        }
        #endregion

        // Port
        #region Port
        private void InitializePort()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("Import");
            button.SetClickEvent(OnImport);

            button = Manager.GetElement<SelectionButton_Setting>("ImportBG");
            button.SetClickEvent(OnImportBG);

            button = Manager.GetElement<SelectionButton_Setting>("ExportDeck");
            button.SetClickEvent(OnExportDeck);

            button = Manager.GetElement<SelectionButton_Setting>("ExportReplay");
            button.SetClickEvent(OnExportReplay);

            button = Manager.GetElement<SelectionButton_Setting>("ExportPicture");
            button.SetClickEvent(OnExportPicture);

            button = Manager.GetElement<SelectionButton_Setting>("ClearPicture");
            button.SetClickEvent(OnClearPicture);
        }
        private void OnImport()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能进行此操作。"));
                return;
            }

            PortHelper.ImportFiles();
        }
        private void OnImportBG()
        {
            PortHelper.ImportBG();
        }
        private void OnExportDeck()
        {
            PortHelper.ExportAllDecks();
        }
        private void OnExportReplay()
        {
            PortHelper.ExportAllReplays();
        }
        private void OnExportPicture()
        {
            PortHelper.ExportAllPictures();
        }
        private void OnClearPicture()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能进行此操作。"));
                return;
            }

            var selections = new List<string>
            {
                InterString.Get("确定清空"),
                InterString.Get("是否确认删除所有导入的卡图？"),
                InterString.Get("确认"),
                InterString.Get("取消")
            };
            UIManager.ShowPopupYesOrNo(selections, () =>
            {
                if (!Directory.Exists(Program.altArtPath))
                    Directory.CreateDirectory(Program.altArtPath);
                foreach (var file in Directory.GetFiles(Program.altArtPath))
                    File.Delete(file);
            }, null);
        }
        #endregion

        // Expansions
        #region Expansion
        private void InitializeExpansions()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("ExpansionsSupport");
            button.SetClickEvent(OnSupportExpansions);
            var config = Config.GetBool("Expansions", true);
            button.SetModeText(InterString.Get(config ? "是" : "否"));

            button = Manager.GetElement<SelectionButton_Setting>("ClearExpansions");
            button.SetClickEvent(OnClearExpansions);

            button = Manager.GetElement<SelectionButton_Setting>("UpdatePrerelease");
            button.SetClickEvent(OnUpdatePrerelease);
        }
        private void OnSupportExpansions()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能更改此选项。"));
                return;
            }

            var config = Config.GetBool("Expansions", true);
            var button = Manager.GetElement<SelectionButton_Setting>("ExpansionsSupport");
            button.SetModeText(InterString.Get(config ? "否" : "是"));
            Config.SetBool("Expansions", !config);

            Program.instance.InitializeForDataChange();
        }
        private void OnClearExpansions()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能进行此操作。"));
                return;
            }

            var selections = new List<string>
            {
                InterString.Get("确定清空"),
                InterString.Get("是否确认删除所有导入的扩展卡包？"),
                InterString.Get("确认"),
                InterString.Get("取消")
            };
            UIManager.ShowPopupYesOrNo(selections, () =>
            {
                ZipHelper.Dispose();
                if (!Directory.Exists(Program.expansionsPath))
                    Directory.CreateDirectory(Program.expansionsPath);
                foreach (var file in Directory.GetFiles(Program.expansionsPath))
                    File.Delete(file);
                Program.instance.InitializeForDataChange();
            }, null);
        }

        private bool checkingPrereleaseUpdate;
        void OnUpdatePrerelease()
        {
            if (Program.instance.ocgcore.showing)
            {
                MessageManager.Cast(InterString.Get("决斗中不能进行此操作。"));
                return;
            }

            if (!checkingPrereleaseUpdate)
            {
                checkingPrereleaseUpdate = true;
                StartCoroutine(UpdatePrereleaseAsync());
            }
        }
        IEnumerator UpdatePrereleaseAsync()
        {
            var filePath = Path.Combine(Program.expansionsPath, Path.GetFileName(Settings.Data.PrereleasePackUrl));
            if (!File.Exists(filePath))
            {
                Config.Set("Prerelease", "0");
                Config.Save();
            }
            var button = Manager.GetElement<SelectionButton_Setting>("UpdatePrerelease");

            var www = UnityWebRequest.Get(Settings.Data.PrereleasePackVersionUrl);
            www.SendWebRequest();
            while (!www.isDone)
            {
                yield return null;
                button.SetModeText(InterString.Get("检查更新中"));
            }
            if (www.result == UnityWebRequest.Result.Success)
            {
                var result = www.downloadHandler.text;
                var lines = result.Replace("\r", "").Split('\n');
                if (Config.Get("Prerelease", "0") != lines[0])
                {
                    if (!Directory.Exists(Program.expansionsPath))
                        Directory.CreateDirectory(Program.expansionsPath);
                    var download = UnityWebRequest.Get(Settings.Data.PrereleasePackUrl);
                    download.SendWebRequest();
                    MessageManager.Cast(InterString.Get("正在更新，请耐心等待更待更新完成再进行其他操作。"));
                    while (!download.isDone)
                    {
                        yield return null;
                        button.SetModeText((download.downloadProgress * 100f).ToString("0.##") + "%");
                    }
                    if (download.result == UnityWebRequest.Result.Success)
                    {
                        ZipHelper.Dispose();
                        File.WriteAllBytes(filePath, download.downloadHandler.data);
                        MessageManager.Cast(InterString.Get("先行卡更新成功。"));
                        Config.Set("Prerelease", lines[0]);
                        Config.Save();
                        Program.instance.InitializeForDataChange();
                    }
                    else
                        MessageManager.Cast(InterString.Get("先行卡更新失败。"));
                }
                else
                    MessageManager.Cast(InterString.Get("先行卡已是最新版。"));
            }
            else
                MessageManager.Cast(InterString.Get("检查更新失败！"));
            button.SetModeText(string.Empty);
            checkingPrereleaseUpdate = false;
        }
        #endregion

        // About
        #region About
        private void InitializeAbout()
        {
            var button = Manager.GetElement<SelectionButton_Setting>("AboutGame");
            button.SetClickEvent(OnAboutGame);

            button = Manager.GetElement<SelectionButton_Setting>("VersionHint");
            button.SetClickEvent(OnAboutVersion);

            button = Manager.GetElement<SelectionButton_Setting>("VersionUpdate");
            button.SetClickEvent(OnAboutUpdate);

            button = Manager.GetElement<SelectionButton_Setting>("UpdateContent");
            button.SetClickEvent(OnUpdateContent);
        }
        private void OnAboutGame()
        {
            var handle = Addressables.LoadAssetAsync<TextAsset>("AboutGame");
            handle.Completed += (result) =>
            {
                var selections = new List<string>()
                {
                    InterString.Get("关于游戏"),
                    result.Result.text
                };
                UIManager.ShowPopupText(selections);
            };
        }
        private void OnAboutVersion()
        {
            var handle = Addressables.LoadAssetAsync<TextAsset>("AboutVersion");
            handle.Completed += (result) =>
            {
                var selections = new List<string>()
                {
                    InterString.Get("关于版本号"),
                    result.Result.text
                };
                UIManager.ShowPopupText(selections, TMPro.HorizontalAlignmentOptions.Left);
            };
        }
        private void OnAboutUpdate()
        {
            var handle = Addressables.LoadAssetAsync<TextAsset>("AboutUpdate");
            handle.Completed += (result) =>
            {
                var selections = new List<string>()
                {
                    InterString.Get("关于更新"),
                    result.Result.text
                };
                UIManager.ShowPopupText(selections);
            };
        }
        private void OnUpdateContent()
        {
            var handle = Addressables.LoadAssetAsync<TextAsset>("UpdateContent");
            handle.Completed += (result) =>
            {
                var selections = new List<string>()
                {
                    InterString.Get("更新内容"),
                    result.Result.text
                };
                UIManager.ShowPopupText(selections, TMPro.HorizontalAlignmentOptions.Left);
            };
        }
        #endregion

        #endregion

    }


    public partial class SROptions
    {
        private UniversalRenderPipelineAsset urpa;
        private Type universalRenderPipelineAssetType;
        private FieldInfo mainLightShadowmapResolutionFieldInfo;
        private FieldInfo supportsSoftShadowsFieldInfo;

        private void InitializeShadowMapFieldInfo()
        {
            urpa = Resources.Load<UniversalRenderPipelineAsset>("Settings/URPAsset");
            universalRenderPipelineAssetType = urpa.GetType();
            mainLightShadowmapResolutionFieldInfo = universalRenderPipelineAssetType.GetField("m_MainLightShadowmapResolution", BindingFlags.Instance | BindingFlags.NonPublic);
            supportsSoftShadowsFieldInfo = universalRenderPipelineAssetType.GetField("m_SoftShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public ShadowResolution MainLightShadowResolution
        {
            get
            {
                if (mainLightShadowmapResolutionFieldInfo == null)
                {
                    InitializeShadowMapFieldInfo();
                }
                return (ShadowResolution)mainLightShadowmapResolutionFieldInfo.GetValue(urpa);
            }
            set
            {
                if (mainLightShadowmapResolutionFieldInfo == null)
                {
                    InitializeShadowMapFieldInfo();
                }
                mainLightShadowmapResolutionFieldInfo.SetValue(urpa, value);
            }
        }
        public bool SupportsSoftShadows
        {
            get
            {
                if (mainLightShadowmapResolutionFieldInfo == null)
                {
                    InitializeShadowMapFieldInfo();
                }
                return (bool)supportsSoftShadowsFieldInfo.GetValue(urpa);
            }
            set
            {
                if (mainLightShadowmapResolutionFieldInfo == null)
                {
                    InitializeShadowMapFieldInfo();
                }
                supportsSoftShadowsFieldInfo.SetValue(urpa, value);
            }
        }
    }
}
