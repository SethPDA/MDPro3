using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.UI
{
	public class ViewController : MonoBehaviour
	{
		public enum TransitionType
		{
			Push = 0,
			Pop = 1,
			Cover = 2,
			Uncover = 3,
			SwapIn = 4,
			SwapOut = 5,
			Max = 6
		}

		public enum ViewStyle
		{
			Part = 0,
			Full = 1
		}

		public ViewStyle viewStyle;

		public bool acceptBack;

		public bool securitySingle031;

		public bool parallelTransition;

		public bool uniqueView;

		private Dictionary<string, object> args;

		[HideInInspector]
		public ViewControllerManager manager;

		private List<MonoBehaviour> unSleepArray;

		protected static readonly string ParameterArgKey;

		[HideInInspector]
		public Dictionary<string, object> Args
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual int selectorPriorityAddRange => 0;

		protected int selectorPriorityBase
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected int selectorPriorityMax => 0;

		public int GetSelectorPriorityAdditional(int addPos)
		{
			return 0;
		}

		public void PrepareStackEntry()
		{
		}

		public virtual void SetVisibleOnInitialize(bool visible)
		{
		}

		public virtual void NotificationStackEntry()
		{
		}

		public virtual void NotificationStackRemove()
		{
		}

		public virtual void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public virtual float Progress()
		{
			return 0f;
		}

		public virtual void ProgressUpdate()
		{
		}

		public virtual void TransitionStart(TransitionType type)
		{
		}

		public virtual bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		protected ViewControllerManager GetRootManager()
		{
			return null;
		}

		public virtual bool OnBack()
		{
			return false;
		}

		public virtual bool OnResult(ViewController from, object value)
		{
			return false;
		}

		public virtual void OnFocusChanged(bool setfocus)
		{
		}

		public ViewController SendResult(object value)
		{
			return null;
		}

		public void SendBack()
		{
		}

		public void PopViewController()
		{
		}

		public void PushViewController(string prefabname, Dictionary<string, object> args = null)
		{
		}

		public void PushViewController(GameObject prefab)
		{
		}

		public void SwapViewController(string prefabname, Dictionary<string, object> args = null)
		{
		}

		public void SwapViewController(GameObject prefab)
		{
		}

		public bool IsDoneBindingUnSleep()
		{
			return false;
		}

		public void CallUnSleepStart()
		{
		}

		public void CallUnSleepUpdate()
		{
		}

		private void MakeUnSleepArray()
		{
		}

		public static Dictionary<string, object> CreateParameterArg<T>(T parameter) where T : class
		{
			return null;
		}

		protected T GetParameterArg<T>() where T : class
		{
			return null;
		}
	}
}
