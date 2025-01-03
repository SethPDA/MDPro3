using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.TextIDs;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Tutorial
{
	public class TutorialNavigator : MonoBehaviour
	{
		private const string VC_PREFAB_PATH = "Tutorial/TutorialNavigator";

		private const string TOP_MESSAGE_LABEL = "TopMessage";

		private const string CENTER_MESSAGE_LABEL = "CenterMessage";

		private const string TOP_MSG_TEXT_LABEL = "TopMsgText";

		private const string CENTER_MSG_TEXT_LABEL = "CenterMsgText";

		public static readonly int DEFAULT_SELECTOR_PRIORITY;

		private static TutorialNavigator _instance;

		[SerializeField]
		private ElementObjectManager _prefabUI;

		private ElementObjectManager _ui;

		private ElementObject _topUI;

		private ElementObject _centerUI;

		private ExtendedTextMeshProUGUI _topText;

		private ExtendedTextMeshProUGUI _centerText;

		private IEnumerator _coroutineTopMsgShowing;

		private IEnumerator _coroutineCenterMsgShowing;

		private string _tmpTopMsg;

		private List<string> _tmpCenterMsgList;

		private UnityAction _onEndOfCenterMsg;

		private int _setupCount;

		public static bool topMsgShowing => false;

		public static bool centerMsgShowing => false;

		public static void Open(Transform topMsgUIParent = null, Transform centerMsgUIParent = null)
		{
		}

		public static void Close()
		{
		}

		public static void PlayTopMsg(IDS_TUTORIAL id, float delay = 0f)
		{
		}

		public static void PlayTopMsg(string message, float delay = 0f)
		{
		}

		public static void StopTopMsg()
		{
		}

		public static void PlayCenterMsg(IList<IDS_TUTORIAL> msgIDs, UnityAction onMsgEnd, float delay = 0f)
		{
		}

		public static void PlayCenterMsg(IList<string> messages, UnityAction onMsgEnd, float delay = 0f)
		{
		}

		public static void StopCenterMsg()
		{
		}

		public static void Setup(int selectorPriority)
		{
		}

		public void Setup(Transform topMsgUIParent, Transform centerMsgUIParent)
		{
		}

		public void SetSelectorPriority(int priority)
		{
		}

		public void Dispose()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator ShowTopMessageInternal(float delay)
		{
			return null;
		}

		private void StopCenterMsgCore(bool disableActive = true)
		{
		}

		private void PlayCenterMsgCore(UnityAction onMsgEnd, float delay, UnityAction onPreProcess)
		{
		}

		private IEnumerator ShowCenterMessageInternal(UnityAction onMsgEnd, float delay)
		{
			return null;
		}
	}
}
