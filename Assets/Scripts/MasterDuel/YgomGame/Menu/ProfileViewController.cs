using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class ProfileViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private enum ProfileMenu
		{
			OVERVIEW = 0,
			REPLAY = 1,
			DATA = 2
		}

		private readonly string MATE_TRANSFORM_SETTING_PATH;

		private readonly string TITLE_NAME;

		private readonly string BTN_MENU_TMP_LABEL;

		private readonly string ROOT_MENU_LABEL;

		private readonly string ROOT_OVERVIEW_LABEL;

		private readonly string TMP_BTN_LABEL;

		private readonly string TMP_TXT_LABEL;

		private readonly string OBJ_MATE_LABEL;

		private TextMeshProUGUI titleText;

		private GameObject rootMenu;

		private GameObject rootOverview;

		private long pcode;

		private bool isFollowed;

		private bool isMine;

		private bool fromDuel;

		private MateTransformSetting m_ModelLocateSettings;

		private DefinitionSetting matchingDefine;

		private Character2D chara;

		private int charaId;

		private bool isNeedCharaCreate;

		private List<GameObject> menuGOs;

		private GameObject followButton;

		private ProfileCard profileCard;

		protected override Type[] textIds => null;

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator DelayedInvokeCallback(Action action)
		{
			return null;
		}

		private void InitMenuButtons()
		{
		}

		private void OnClickBlock()
		{
		}

		private void UpdateProfile(Dictionary<string, object> profileDic)
		{
		}

		private void PlayMateMotion()
		{
		}

		private void InitMateSettings(MateTransformSetting modelLocateSettings)
		{
		}

		private void SetFollowButton(bool isFollowed)
		{
		}
	}
}
