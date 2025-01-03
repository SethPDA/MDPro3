using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class TimelineManager : MonoBehaviour
	{
		internal class TimelineObjectDesc
		{
			public Stack<int> toidList;

			public bool boostEnable;

			public string label
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TimelineObjectDesc(string label, bool boostEnable)
			{
			}
		}

		public enum EndEventType
		{
			NONE = 0,
			AUTODESTROY = 1,
			AUTORECYCLE = 2
		}

		public const string TM_LABEL_DUEL = "Duel";

		public const string TM_LABEL_BASE = "Base";

		public const string GROUP_LABEL_DEFAULT = "DefaultGroup";

		public const string GROUP_LABEL_DUEL = "DuelGroup";

		private static TimelineManager m_Instance;

		private Dictionary<string, Dictionary<string, TimelineObjectDesc>> m_CachedTimelineObjectGroupTable;

		private Dictionary<int, TimelineObject> m_AllTimelineObjectInstanceTable;

		private RectTransform m_TimeLineRoot2D;

		private Transform m_TimeLineRoot3D;

		private Transform m_HidePool;

		private static Dictionary<string, Action> eventCallback;

		private static TimelineManager instance => null;

		private static TimelineManager CreateTimelineManager()
		{
			return null;
		}

		public static void DestroyAllTimelineObject()
		{
		}

		public static void ResetTImelineTableOfGroup(string group, bool includeEndEventTypeNone = true)
		{
		}

		private void ResetTImelineTableOfGroupInpl(string group, bool includeEndEventTypeNone)
		{
		}

		public static void OpenTimelineAsync2D(string path, UnityAction<PlayableDirector> onLoaded, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
		}

		public static void OpenTimelineAsync2D(string group, string path, UnityAction<PlayableDirector> onLoaded, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
		}

		public static void OpenTimelineAsync3D(string path, UnityAction<PlayableDirector> onLoaded, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
		}

		public static void OpenTimelineAsync3D(string group, string path, UnityAction<PlayableDirector> onLoaded, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
		}

		public static bool PreloadTimeline(string path, Action<bool> onFinish = null, int instancenum = 1, bool boostEnable = true)
		{
			return false;
		}

		public static bool PreloadTimeline(string group, string path, Action<bool> onFinish = null, int instancenum = 1, bool boostEnable = true)
		{
			return false;
		}

		private bool PreloadTimelineImpl(string group, string path, Action<bool> onFinish = null, int instancenum = 1, bool boostEnable = true)
		{
			return false;
		}

		public static void OpenTimelineAsync(string path, UnityAction<PlayableDirector> onLoaded, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
		{
		}

		public static void OpenTimelineAsync(string group, string path, UnityAction<PlayableDirector> onLoaded, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
		{
		}

		private void OpenTimelineAsyncImpl(string group, string path, UnityAction<PlayableDirector> onLoaded, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
		{
		}

		public static TimelineObject OpenTimeline(string path, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
		{
			return null;
		}

		public static TimelineObject OpenTimeline(string group, string path, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
		{
			return null;
		}

		private TimelineObject OpenTimelineImpl(string group, string path, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
		{
			return null;
		}

		public static TimelineObject OpenTimeline2D(string path, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
			return null;
		}

		public static TimelineObject OpenTimeline2D(string group, string path, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
			return null;
		}

		public static TimelineObject OpenTimeline3D(string path, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
			return null;
		}

		public static TimelineObject OpenTimeline3D(string group, string path, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
			return null;
		}

		public static bool RecycleTimeline(string path, TimelineObject timelineObject)
		{
			return false;
		}

		public static bool RecycleTimeline(string group, string path, TimelineObject timelineObject)
		{
			return false;
		}

		public bool RecycleTimelineImpl(string group, string path, TimelineObject timelineObject)
		{
			return false;
		}

		public static void UpdateTimelineSpeed(string group, double speed)
		{
		}

		public static void UpdateTimelineSpeed(double speed)
		{
		}

		public void UpdateBoostModeImpl(string group, double speed)
		{
		}

		private void TimelineOnLoaded(TimelineObject to, UnityAction<PlayableDirector> onLoaded, Transform parent, Action onStop = null, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
		{
		}

		private void RegisterTimelineObejct(TimelineObject to)
		{
		}

		public static void SetEventCallback(string label, Action callback)
		{
		}

		public static void InvokeEventCallback(string label)
		{
		}
	}
}
