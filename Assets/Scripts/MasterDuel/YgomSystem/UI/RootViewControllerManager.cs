using System;
using System.Runtime.CompilerServices;

namespace YgomSystem.UI
{
	public class RootViewControllerManager : ViewControllerManager
	{
		public Action<ViewControllerManager> onBackEvent;

		public static RootViewControllerManager instance
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

		public override void Awake()
		{
		}

		public override void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public override void Update()
		{
		}
	}
}
