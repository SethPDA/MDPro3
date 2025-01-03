using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.ActionSheet;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room
{
	public class RoomCreateViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private struct DuelTimeSetting
		{
			public int id
			{
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string name
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int duration
			{
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int order
			{
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		internal class TemplateInfo
		{
			internal int templateType;

			internal readonly string settingLabel;

			public TemplateInfo(string settingLabel)
			{
			}
		}

		internal class LabelInfo : TemplateInfo
		{
			internal LabelInfo(string settingLabel)
				: base(null)
			{
			}
		}

		internal class ButtonInfo : TemplateInfo
		{
			internal readonly string title;

			internal readonly string[] settingStrings;

			internal readonly object[] settings;

			internal readonly InfinityScrollView isv;

			internal int currentSetting;

			internal bool interactable;

			internal bool isActionSheet;

			internal UnityAction onFinishSetting;

			internal ButtonInfo(InfinityScrollView isv, string settingLabel, string title, string[] settingStrings, object[] settings, bool isActionSheet = true, int defaultSettings = 0)
				: base(null)
			{
			}

			internal void OnClick()
			{
			}

			protected virtual void ProcessOnClicked()
			{
			}
		}

		internal class BtnInfoForRule : ButtonInfo
		{
			private RegulationSelectSheet _sheet;

			internal BtnInfoForRule(RegulationSelectSheet sheet, InfinityScrollView isv, string settingLabel, string title, string[] settingStrings, object[] settings, int defaultSettings = 0)
				: base(null, null, null, null, null, isActionSheet: false)
			{
			}

			protected override void ProcessOnClicked()
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string BTN_OK_LABEL;

		private List<TemplateInfo> infos;

		private InfinityScrollView isv;

		private const string KEY_MEMBER_MAX = "member_max";

		private const string KEY_PUBLIC = "is_public";

		private const string KEY_SPECTRAL = "is_spectral";

		private const string KEY_SPECTER = "is_specter";

		private const string KEY_COMMENT = "room_comment";

		private const string KEY_TIME = "battle_time";

		private const string KEY_LP = "battle_lp";

		private const string KEY_REPLAY = "is_replay";

		private Dictionary<string, int> defaultIdxSettings;

		private RegulationSelectSheet _regulationSelectSheet;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		public static Dictionary<string, object> GetDefaultRoomSettings(int meberMax = 6, bool isPublic = true, bool isSpectral = true, bool isSpecter = true, int roomComment = 0, int battleTimeId = 1, RoomUtil.LPType battleLp = RoomUtil.LPType.LP_8000, bool isReplay = true)
		{
			return null;
		}

		protected override void OnCreatedView()
		{
		}

		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		private void SetDefaultIdxSettings()
		{
		}

		private void SetDefaultIdx(string key, int defaultIdx)
		{
		}

		private void SetData()
		{
		}

		private void SetMemberMax()
		{
		}

		private void SetIsPublic()
		{
		}

		private void SetIsSpectral()
		{
		}

		private void SetIsSpecter()
		{
		}

		private void SetBattleRule()
		{
		}

		private void SetRoomComment()
		{
		}

		private void SetBattleTime()
		{
		}

		private void SetBattleLP()
		{
		}

		private void SetIsReplay()
		{
		}

		private void CallAPIRoomCreate()
		{
		}

		private void ErrorRoomCreate(RoomCode roomCode)
		{
		}

		private Handle APIRoomCreate(Dictionary<string, object> _room_settings_)
		{
			return null;
		}
	}
}
