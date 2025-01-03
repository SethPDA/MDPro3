using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomGame.Solo;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Tutorial
{
	public class CardFlyingViewController : BaseMenuViewController
	{
		private const string PATH = "Tutorial/CardFlying";

		private const string TWEEN_LABEL_SHOW = "Show";

		private const string TWEEN_LABEL_HIDE = "Hide";

		private const string ELEOBJ_LABEL_MSG = "Message";

		private const string ARGS_KEY_TEXTLIST = "TextList";

		private const string ARGS_KEY_FINISHCALLBACK = "onFinish";

		private const string ARGS_KEY_AUTOMODE = "AutoMode";

		private const string ANDROID_BACK_KEY_LABEL = "AndroidBackKey";

		private ElementObjectManager _ui;

		private SoloFlyingCardSettings _flyingCardSetting;

		private LabeledPlayableController _labelCtrl;

		private static PlayableDirector _director;

		public static PlayableDirector bgDirector => null;

		public static void Start(IList<string> msgList, UnityAction onFinish)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public void OnBlackoutEnd()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void StartTimeline()
		{
		}

		private IEnumerator ShowTelopRoutine(IList<string> messages)
		{
			return null;
		}
	}
}
