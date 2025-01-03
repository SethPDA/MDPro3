using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.Utility;

namespace YgomSystem
{
	[DisallowMultipleComponent]
	public class Rebooter : MonoBehaviour
	{
		private IEnumerator _proc;

		public static Rebooter instance
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

		public static bool rebooting => false;

		public static void Execute(string bootpage, AppInfo.BootType boottype, UnityAction onEnd)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void RebootStart(string bootpage, AppInfo.BootType boottype, UnityAction onEnd)
		{
		}

		private IEnumerator RebootProcess(string bootpage, AppInfo.BootType boottype, UnityAction onEnd)
		{
			return null;
		}
	}
}
