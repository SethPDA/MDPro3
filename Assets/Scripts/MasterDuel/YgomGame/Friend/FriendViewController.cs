using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Friend
{
	public class FriendViewController : BaseBlurOverlayViewController
	{
		private enum PlayerActionSheetEntry
		{
			Profile = 2,
			Pin = 4,
			Audience = 8,
			Duel = 0x10,
			Block = 0x20
		}

		private readonly string k_FriendActionSheetIcon;

		private readonly string k_ELabelBackButton;

		private readonly string k_ELabelCancelButton;

		private readonly string k_ELabelFollowRoot;

		private readonly string k_ELabelFriendSearchButton;

		private readonly string k_ELabelFollowNumText;

		private readonly string k_ELabelFollowToggle;

		private readonly string k_ELabelFollowList;

		private readonly string k_ELabelFollowFilterInput;

		private readonly string k_ELabelFollowFilterIcon;

		private readonly string k_ELabelFollowInnerSelector;

		private readonly string k_ELabelFollowerRoot;

		private readonly string k_ELabelFollowerToggle;

		private readonly string k_ELabelFollowerList;

		private readonly string k_ELabelFollowerHeadLoadingIcon;

		private readonly string k_ELabelFollowerTailLoadingIcon;

		private readonly string k_ELabelBlockRoot;

		private readonly string k_ELabelBlockToggle;

		private readonly string k_ELabelBlockList;

		private readonly string k_ASArgsPcode;

		private readonly string k_TweenToOpen;

		private readonly string k_TweenListToClose;

		private readonly string k_TweenSearchActive;

		private readonly string k_TweenSearchInactive;

		private ElementObjectManager m_FriendActionSheetIconPref;

		private FriendDefinitionSetting m_FriendDefinitionSetting;

		private GameObject m_FollowRoot;

		private ToggleWidget m_FollowToggle;

		private FriendListWidget m_FollowListWidget;

		private TMP_Text m_FollowNumText;

		private Selector m_FollowInnerSelector;

		private InputFieldWidget m_FollowFilterInput;

		private GameObject m_FollowerRoot;

		private ToggleWidget m_FollowerToggle;

		private FriendListWidget m_FollowerListWidget;

		private GameObject m_BlockRoot;

		private ToggleWidget m_BlockToggle;

		private FriendListWidget m_BlockListWidget;

		private bool m_IsReady;

		private bool m_IsInitializedFollowerList;

		private bool m_IsInitializedBlockList;

		private FollowContextCollection m_FollowContexts;

		private FollowerContextCollection m_FollowerContexts;

		private BlockContextCollection m_BlockContexts;

		private bool m_Quite;

		private bool m_IsSuspended;

		private float m_PollingTimer;

		private float m_PollingSpan;

		private List<long> m_SearchDisplayPcodeList;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void Update()
		{
		}

		private void OpenPlayerActionSheet(IPlayerContext player, PlayerActionSheetEntry visibleFlags)
		{
		}

		private void PlayToOpen(GameObject target)
		{
		}

		private void PlayToClose(GameObject target)
		{
		}

		private void PlayFollowerLoadingIcon(bool isHead)
		{
		}

		private void StopFollowerLoadingIcon(bool isHead)
		{
		}

		private void OnFollowToggleChange(bool isOn)
		{
		}

		private void OnFollowerToggleChange(bool isOn)
		{
		}

		private void OnBlockToggleChange(bool isOn)
		{
		}

		private void OnActiveToggleChange(int toggleIdx, bool isOn)
		{
		}

		private void OnFollowerReachScrollHead()
		{
		}

		private void OnFollowerReachScrollTail()
		{
		}

		private void OnFollowerAdditionalLoad(long date, long pcode, int dir, Action complete)
		{
		}

		private void OnClickFriendSearchButton()
		{
		}

		private void OnSubmitFollowFilter(string input)
		{
		}

		private void OnFollowUpdateDataCount()
		{
		}

		private void OnOpenCloseFollowList(bool isOpen)
		{
		}

		private void OnOpenCloseFollowerList(bool isOpen)
		{
		}

		private void OnOpenCloseBlockList(bool isOpen)
		{
		}

		private void OnClickFollowPlayer(IPlayerContext player)
		{
		}

		private void OnClickFollowerPlayer(IPlayerContext player)
		{
		}

		private void OnClickBlockPlayer(IPlayerContext player)
		{
		}

		private void OnClickFriendProfile(long pcode)
		{
		}

		private void OnClickFriendSetPin(long pcode)
		{
		}

		private void OnClickBlockOff(long pcode)
		{
		}

		private void OnClickFriendDuelEntry(long pcode)
		{
		}

		private Handle APIRoomEntry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
		{
			return null;
		}

		private void OnClickFriendTeamEntry(int teamId)
		{
		}

		private void OnClickCancel()
		{
		}
	}
}
