using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class DialogViewControllerManager : ViewControllerManager
	{
		public static DialogViewControllerManager Instance;

		public const float FADESPEED = 0.2f;

		public Image fillImage;

		public BokehCamera bokeh;

		public GameObject hiddenScreen;

		public Color defaultFadeColor;

		private Color fadeColor;

		private float disp;

		private bool touchMask;

		private bool pauseContent;

		[SerializeField]
		private GraphicRaycaster[] maskRaycasterList;

		public override int selectorRootPriority => 0;

		public static DialogViewControllerManager GetManager()
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

		public void SetFadeColorDefault()
		{
		}

		public void SetFadeColor(Color color)
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void SendStackActionAction(TransitionType type, ViewController vc, ViewController preVc)
		{
		}
	}
}
