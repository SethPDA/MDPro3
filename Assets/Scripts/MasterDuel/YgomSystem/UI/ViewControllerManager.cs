using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class ViewControllerManager : ViewController
	{
		public enum FadeState
		{
			None = 0,
			FadeOuting = 1,
			FadeOutRequired = 2,
			FadeOut = 3,
			FadeInning = 4
		}

		private struct TransCache
		{
			public enum Type
			{
				Pop = 0,
				Push = 1,
				Swap = 2,
				Insert = 3
			}

			public Type type;

			public GameObject prefab;

			public ViewController target;

			public Dictionary<string, object> args;
		}

		private struct TransInsert
		{
			public GameObject prefab;

			public Dictionary<string, object> args;

			//public TransInsert(GameObject p, Dictionary<string, object> a)
			//{
			//}
		}

		protected static Dictionary<string, ViewControllerManager> namedManager;

		protected List<ViewController> viewStack;

		private Action<TransitionType, ViewController, ViewController> transitionAction;

		private TransitionType transDispType;

		private TransitionType transHideType;

		private ViewController transDispView;

		private ViewController transHideView;

		private bool transDispStart;

		private bool transHideStart;

		private bool transDispEnd;

		private bool transHideEnd;

		private int firstSiblingIndex;

		private List<Action> endTransActions;

		[SerializeField]
		private string managerName;

		private List<TransCache> transCache;

		private List<TransInsert> transInsert;

		private FadeState dummyFadeState;

		private static string DefaultPrefabPath;

		private Coroutine m_AbordViewControllerRoutine;

		public string ManagerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual int selectorRootPriority => 0;

		public bool isReservedTransPush()
		{
			return false;
		}

		public static void StartTrans()
		{
		}

		public static void EndTrans()
		{
		}

		private void EndTransAction()
		{
		}

		public void SetEndTransAction(Action action)
		{
		}

		[Obsolete]
		public static void SetEventSystemEnabled(bool enabled)
		{
		}

		private void PushTransCache(TransCache.Type type, GameObject prefab, ViewController target, Dictionary<string, object> args = null)
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public virtual void Update()
		{
		}

		protected virtual void FadeIn(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
		{
		}

		protected virtual void FadeOut(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
		{
		}

		protected virtual FadeState GetFadeState()
		{
			return default(FadeState);
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void SendNotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private bool InsertViewStack(ViewController vc)
		{
			return false;
		}

		private void CleanupViewController(ViewController vc)
		{
		}

		private void AbordStack(int index, int count)
		{
		}

		public void ForceClearViewControllerStack()
		{
		}

		protected virtual bool InsertTransform(GameObject vcgo)
		{
			return false;
		}

		public bool IsReadyTransition()
		{
			return false;
		}

		private GameObject LoadViewControllerPrefab(string prefabpath)
		{
			return null;
		}

		public void AbortChildViewController(ViewControllerAbortRequest abortRequest)
		{
		}

		private IEnumerator yAbortdViewController()
		{
			return null;
		}

		public void PopChildViewController()
		{
		}

		public void PopChildViewController(ViewController popTatget)
		{
		}

		public void PushChildViewController(string prefabpath)
		{
		}

		public void PushChildViewController(GameObject prefab)
		{
		}

		public void PushChildViewControllerParam<T>(string prefabpath, T parameter) where T : class
		{
		}

		public void PushChildViewControllerParam<T>(GameObject prefab, T parameter) where T : class
		{
		}

		public void PushChildViewController(string prefabpath, Dictionary<string, object> args)
		{
		}

		public void PushChildViewController(GameObject prefab, Dictionary<string, object> args)
		{
		}

		private ViewController CreateViewController(GameObject prefab, Dictionary<string, object> args)
		{
			return null;
		}

		public void SwapTopChildViewController(string prefabpath)
		{
		}

		public void SwapTopChildViewController(GameObject prefab)
		{
		}

		public void SwapTopChildViewControllerParam<T>(string prefabpath, T parameter) where T : class
		{
		}

		public void SwapTopChildViewControllerParam<T>(GameObject prefab, T parameter) where T : class
		{
		}

		public void SwapTopChildViewController(string prefabpath, Dictionary<string, object> args)
		{
		}

		public void SwapTopChildViewController(GameObject prefab, Dictionary<string, object> args)
		{
		}

		public void SwapBottomChildViewController(string prefabpath)
		{
		}

		public void SwapBottomChildViewController(GameObject prefab)
		{
		}

		public void SwapBottomChildViewControllerParam<T>(string prefabpath, T parameter) where T : class
		{
		}

		public void SwapBottomChildViewControllerParam<T>(GameObject prefab, T parameter) where T : class
		{
		}

		public void SwapBottomChildViewController(string prefabpath, Dictionary<string, object> args)
		{
		}

		public void SwapBottomChildViewController(GameObject prefab, Dictionary<string, object> args)
		{
		}

		public void SwapChildViewControllerParam<T>(ViewController swapTatget, string prefabpath, T parameter) where T : class
		{
		}

		public void SwapChildViewController(ViewController swapTatget, string prefabpath, Dictionary<string, object> args = null)
		{
		}

		public void SwapChildViewController(ViewController swapTatget, GameObject prefab, Dictionary<string, object> args = null)
		{
		}

		private void doSwapChildViewController(TransitionType disptrans, TransitionType hidetrans, ViewController swapTatget, GameObject prefab, Dictionary<string, object> args = null)
		{
		}

		public void InsertChildViewController(string prefabpath, Dictionary<string, object> args = null)
		{
		}

		public void InsertChildViewController(GameObject prefab, Dictionary<string, object> args = null)
		{
		}

		public ViewController SendChildResult(ViewController child, ViewController from, object value)
		{
			return null;
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		public override bool OnBack()
		{
			return false;
		}

		public ViewController FindViewController(string name, bool activeOnly = false)
		{
			return null;
		}

		public bool IsViewController(ViewController vc)
		{
			return false;
		}

		public ViewController GetStackTopViewController()
		{
			return null;
		}

		public ViewController GetStackBottomViewController()
		{
			return null;
		}

		public ViewController GetStackViewController(int index)
		{
			return null;
		}

		public ViewController GetStackViewController(string name)
		{
			return null;
		}

		public T GetViewController<T>() where T : ViewController
		{
			return null;
		}

		public int GetStackCount()
		{
			return 0;
		}

		public int GetStackIndex(ViewController vc)
		{
			return 0;
		}

		public ViewController GetFocusViewController(bool includeInactive = false)
		{
			return null;
		}

		public ViewController GetStyleViewController(ViewStyle style, int depth)
		{
			return null;
		}

		public void InstantiateSetup()
		{
		}

		public void RegisterTransitionAction(Action<TransitionType, ViewController, ViewController> act)
		{
		}

		public void UnregisterTransitionAction(Action<TransitionType, ViewController, ViewController> act)
		{
		}

		public static ViewControllerManager GetViewControllerManagerWithName(string name)
		{
			return null;
		}

		protected void SendStackAction(Dictionary<string, object> dic)
		{
		}
	}
}
