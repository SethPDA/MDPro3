using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Friend
{
	public class FriendWidget : ElementWidgetBehaviourBase<FriendWidget>
	{
		private readonly string k_ELabelPlatformPlayerNameGroup;

		private readonly string k_ELabelPlatformPlayerIcon;

		private readonly string k_ELabelProfileIcon;

		private readonly string k_ELabelFollowIcon;

		private readonly string k_ELabelFollowerIcon;

		private readonly string k_ELabelDuelIcon;

		private readonly string k_ELabelOnlineIcon;

		private readonly string k_ELabelOfflineIcon;

		private readonly string k_ELabelFriendPinLine;

		private readonly string k_ELabelFriendPinLineOn;

		private readonly string k_ELabelFriendPinLineOff;

		private readonly string k_ELabelWallpaper;

		private readonly string k_ELabelRoomBadge;

		private readonly string k_TweenOn;

		private readonly string k_TweenOff;

		public SelectionButton button
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

		public PlatformPlayerNameGroup platformPlayerNameGroup
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

		public PlatformPlayerIcon platformPlayerIcon
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

		public GameObject profileIconRoot
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

		public Image wallpaperImage
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

		public GameObject followIcon
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

		public GameObject followerIcon
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

		public GameObject roomBadge
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

		public GameObject pinLineRoot => null;

		public GameObject pinLineOn => null;

		public GameObject pinLineOff => null;

		public bool followStateVisible
		{
			set
			{
			}
		}

		public event Action<FriendWidget> onClickEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<FriendWidget> onSelectedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static FriendWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void SetProfileIcon(int iconId, int iconFrameId)
		{
		}

		public void SetWallpaper(int wallpaperId)
		{
		}

		public void SetStatusText(bool isEnableDuelWatch, bool isOnline)
		{
		}

		public void SetFollowState(FollowState followState)
		{
		}

		public void SetRoomBadge(FollowState followState, int inviteRoomId, int inviteTeamId)
		{
		}

		private void OnClick()
		{
		}

		private void OnSelected()
		{
		}

		public FriendWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
