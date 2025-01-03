using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumResultVersusViewController : BaseMenuViewController
	{
		public const string PREF_PATH = "Colosseum/ColosseumResultVersus";

		private static readonly string ARGS_VERSUSID;

		private static readonly string ARGS_CALLBACK;

		private readonly string E_Image;

		private readonly string E_Button;

		private readonly string E_TextMyPoint;

		private readonly string E_TextMyPointLabel;

		private readonly string E_TextTotalPoint;

		private readonly string E_TextTotalPointLabel;

		private readonly string E_TextPercent;

		private readonly string E_TextBase;

		private readonly string E_Root;

		private readonly string E_ImageBg;

		private readonly string E_ImageMonster;

		private readonly string E_ImageIconEffLoop;

		private readonly string E_ImageIcon;

		private readonly string E_ImageIconEff;

		[SerializeField]
		private float totalAnimationTime;

		private int versus_id;

		private bool isStartedTween;

		protected override Type[] textIds => null;

		public static Dictionary<string, object> GetArgs(int logoId, UnityAction onFinished)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		private void SetGroup(int groupNo, long ownPercent, long rivalPercent, long totalPoint, bool isPlayEffect)
		{
		}

		private void Update()
		{
		}
	}
}
