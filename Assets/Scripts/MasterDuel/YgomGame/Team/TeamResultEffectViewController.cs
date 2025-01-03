using System;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamResultEffectViewController : BaseMenuViewController
	{
		private const string k_ArgKeyCallback = "callback";

		private const string k_ArgKeyResult = "result";

		private const string k_ArgKeyCardMrk = "cardMrk";

		private readonly string k_ELabelBackShortcutButton;

		private TimelineObject teamResultEffectTimeLine;

		private EventPlayableAsset eventPlayableAsset;

		private ElementObjectManager eom;

		private SelectionButton backButton;

		private bool isFinishedSE;

		private bool isFinishedResultEffect;

		private int resultStatus;

		private int cardMrk;

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void Initialize()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public static void Open(ViewControllerManager manager, int result, int cardMrk, Action callback = null)
		{
		}

		private void Play()
		{
		}

		private void StartTimeLine()
		{
		}

		private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
		{
			return null;
		}
	}
}
