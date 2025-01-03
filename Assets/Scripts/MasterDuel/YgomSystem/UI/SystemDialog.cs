using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI
{
	public class SystemDialog : MonoBehaviour
	{
		public const string k_ArgKeyTitle = "title";

		public const string k_ArgKeyUpperMessage = "upperMessage";

		public const string k_ArgKeyLowerMessage = "lowerMessage";

		public const string k_ArgKeyLowerMessageScrollHeight = "lowerMessageScrollHeight";

		public const string k_ArgKeyTime = "time";

		public const string k_ArgKeyImagePath = "imagePath";

		public const string k_ArgKeyImageScale = "imageScale";

		public const string k_ArgKeyImageVisible = "imageVisible";

		public const string k_ArgKeyButtonLabel = "buttonLabel";

		public const string k_ArgKeyAction = "action";

		public const string k_ArgKeyButtonLabel2 = "buttonLabel2";

		public const string k_ArgKeyAction2 = "action2";

		public const string k_ArgKeyRebootButtonVisible = "rebootVisible";

		public const string k_ArgKeyWindowWidth = "windowWidth";

		public const string k_ArgKeyOpenSe = "opense";

		private readonly string k_MaintenanceBannerPath;

		[SerializeField]
		private ElementObjectManager m_SystemDialogPref;

		private CommonDialogContentContainerWidget m_SystemDialogWidget;

		private IEnumerator m_FontLoadCoroutine;

		private Action m_ActionCallback1;

		private Action m_ActionCallback2;

		public bool isExistsDialog => false;

		private int defaultMinHeight => 0;

		public bool OpenFatalErrorDialog(string message, string label1 = null, Action action1 = null, Dictionary<string, object> args = null)
		{
			return false;
		}

		public Dictionary<string, object> GetMaintenanceDialogArgs()
		{
			return null;
		}

		public void OpenOperationMainteDialog(Dictionary<string, object> defaultArgs = null, Dictionary<string, object> overrideArgs = null)
		{
		}

		public bool OpenMaintenanceDialog(Dictionary<string, object> args)
		{
			return false;
		}

		private bool OpenSystemDialog(List<IEntryData> entryDatas, Dictionary<string, object> args = null)
		{
			return false;
		}

		private IEnumerator waitLocalizedFontsLoad(Action callback)
		{
			return null;
		}

		private void OpenSystemDialogCore(List<IEntryData> entryDatas, Dictionary<string, object> args = null)
		{
		}

		private void CloseSystemDialog()
		{
		}

		private void ClearCallbacks()
		{
		}

		public void ClearOnReboot()
		{
		}

		private void OnClickReboot()
		{
		}

		private void OnClickAction1()
		{
		}

		private void OnClickAction2()
		{
		}
	}
}
