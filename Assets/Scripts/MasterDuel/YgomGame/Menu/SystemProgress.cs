using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu
{
	public class SystemProgress : MonoBehaviour
	{
		public enum ProgressType
		{
			None = 0,
			Normal = 1,
			Tips = 2,
			Blank = 3
		}

		public CanvasGroup fillScreen;

		public Image fadeScreen;

		public GameObject normalProgress;

		public GameObject tipsProgress;

		public GameObject connectingProgress;

		public ElementObjectManager fatalErrorDialogPref;

		public float delayTime;

		public float guaranteeTime;

		public float fadeSpeed;

		public float fadeAlpha;

		private int count;

		private float crntTime;

		private bool rebooting;

		private bool unloadCalled;

		private ResourceManager.UnloadCheckLevel unloadCheckLevel;

		private string abortRequest;

		private AppInfo.BootType abortRequestType;

		private ProgressType crntType;

		private bool crntScreenCenter;

		private Dictionary<string, object> tipsSettingDict;

		private Image centerFadeScreen;

		public bool CenterFade;

		[Obsolete]
		public static SystemProgress Instance => null;

		public Color fadeColor => default(Color);

		public static string get_driverURL()
		{
			return null;
		}

		public void OnFatalErrorReboot()
		{
		}

		public void OnAbortRebootRequest(string bootpage, AppInfo.BootType boottype = AppInfo.BootType.ExitReboot)
		{
		}

		private void OnAbortReboot(string bootpage, AppInfo.BootType boottype)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void SetDirty()
		{
		}

		public float GetFadeAlpha()
		{
			return 0f;
		}

		private bool IsNeedChangeFadeAlpha(Color fadeColor)
		{
			return false;
		}

		public void DispProgress(ProgressType type, Color fadeColor, float delay = 0f, bool immediate = false, ResourceManager.UnloadCheckLevel unloadCheckLevel = ResourceManager.UnloadCheckLevel.Low)
		{
		}

		private IEnumerator ShowNormalProgress(bool isShow)
		{
			return null;
		}

		private static string RandomSelectTipsNumberString(Dictionary<string, object> tipsSettingDict)
		{
			return null;
		}

		private void LoadTipsSetting()
		{
		}

		public void HideProgress()
		{
		}

		public ViewControllerManager.FadeState GetFadeState()
		{
			return default(ViewControllerManager.FadeState);
		}

		public GameObject GetNormalProgress()
		{
			return null;
		}

		public void ClearOnReboot()
		{
		}

		[Obsolete]
		public void OpenFatalErrorDialog(string message, string label1 = null, Action action1 = null, Dictionary<string, object> args = null)
		{
		}

		[Obsolete]
		public static void Disp(ProgressType type, Color fadeColor, float delay = 0f, bool immediate = false)
		{
		}

		[Obsolete]
		public static void Hide()
		{
		}

		[Obsolete]
		public static void OpenNetworkErrorDialog(Handle handle)
		{
		}
	}
}
