using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class ContentViewControllerManager : ViewControllerManager
	{
		public static ContentViewControllerManager Instance;

		[SerializeField]
		private bool m_launchDefaultVC;

		private string m_wakeupBoot;

		private bool AbortNetwork;

		private IEnumerator m_WaitAbortNetworkCoroutine;

		private float transitionTime;

		private Canvas cv;

		private Color fadeColor;

		private SystemProgress.ProgressType fadeType;

		private bool manageFade;

		public bool ConfirmAppQuit
		{
			[CompilerGenerated]
			private get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string AppQuitUrlScheme
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Rect CanvasScreen => default(Rect);

		public static ContentViewControllerManager GetManager()
		{
			return null;
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

		public void PrepareReboot()
		{
		}

		public void ExecuteReboot(string bootpath = null)
		{
		}

		public void Boot(string bootpath = null)
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		public void OpenAppQuitDialog()
		{
		}

		private bool wantsToQuit()
		{
			return false;
		}

		private IEnumerator WaitAbortNetwork()
		{
			return null;
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		public void SetFadeType(SystemProgress.ProgressType tp, Color color)
		{
		}

		protected override void FadeIn(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
		{
		}

		protected override void FadeOut(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
		{
		}

		protected override FadeState GetFadeState()
		{
			return default(FadeState);
		}

		private void SendStackActionAction(TransitionType type, ViewController vc, ViewController preVc)
		{
		}

		public void SetBlurSetting(bool isBlur)
		{
		}

		public Camera GetCamera()
		{
			return null;
		}
	}
}
