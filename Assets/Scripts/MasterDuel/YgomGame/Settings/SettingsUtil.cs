using System.Runtime.CompilerServices;
using YgomGame.Card;

namespace YgomGame.Settings
{
	public class SettingsUtil
	{
		public struct SoundParam
		{
			public enum INIT_TYPE
			{
				DEFAULT = 0,
				WORK = 1
			}

			public int bgm;

			public int se;

			public int voice;

			public bool bgmMute;

			public bool seMute;

			public bool voiceMute;

			//public SoundParam(INIT_TYPE initType)
			//{
			//}

			//public SoundParam(int init_bgm, int init_se, int init_voice, bool init_bgm_mute = false, bool init_se_mute = false, bool init_voice_mute = false)
			//{
			//}
		}

		public struct BasicParam
		{
			public enum INIT_TYPE
			{
				DEFAULT = 0,
				WORK = 1
			}

			public enum CARD_TEXT_SIZE
			{
				LARGE = 0,
				MEDIUM = 1,
				SMALL = 2
			}

			public enum QUALITY
			{
				STANDARD = 0,
				RECOMMENDED = 1,
				HIGH = 2
			}

			public int perform;

			public QUALITY quality;

			public int resolution;

			public bool fullScreen;

			public CARD_TEXT_SIZE cardTextSize;

			public bool vibration;

			//public BasicParam(INIT_TYPE initType)
			//{
			//}

			//public BasicParam(int init_perform, QUALITY init_quality = QUALITY.RECOMMENDED, int init_resolution = -1, bool init_fullScreen = false, CARD_TEXT_SIZE init_cardTextSize = CARD_TEXT_SIZE.MEDIUM, bool init_vibration = true)
			//{
			//}
		}

		public struct SystemParam
		{
			public enum INIT_TYPE
			{
				DEFAULT = 0,
				WORK = 1
			}

			public bool notify;

			public bool chat;

			//public SystemParam(INIT_TYPE initType)
			//{
			//}

			//public SystemParam(bool init_notify, bool init_chat)
			//{
			//}
		}

		public enum SHOW_CARDREPORT_TYPE
		{
			NONE = 0,
			ALL = 1
		}

		public enum SHOW_RIVALNAME_TYPE
		{
			HIDE = 0,
			SHOW = 1
		}

		public enum SHOW_HAPPENEDEFFECT_TYPE
		{
			OFF = 0,
			ON = 1,
			ON_ONLY_DUELSTATUS = 2
		}

		public struct DuelParam
		{
			public enum INIT_TYPE
			{
				DEFAULT = 0,
				WORK = 1
			}

			public enum CHAIN_TYPE
			{
				MY_CHAIN_ON = 0,
				MY_CHAIN_OFF = 1
			}

			public enum MANUAL_TYPE
			{
				NONE = 0,
				TOUCH = 1,
				TOGGLE = 2,
				TOUCH2 = 3,
				TOUCH3 = 4,
				TOGGLE2 = 5
			}

			public enum LOCATE_TYPE
			{
				AUTO = 0,
				MANUAL = 1
			}

			public enum COMMAND_TYPE
			{
				MASTERDUEL = 0,
				DUELLINKS = 1
			}

			public enum SKIP_TYPE
			{
				NONE = 0,
				ONETIME = 1,
				ALWAYS = 2
			}

			public enum CAMERA_TYPE
			{
				NEAR = 0,
				FAR = 1
			}

			public enum SHOW_CARDINFO_TYPE
			{
				NONE = 0,
				AUTO_ALL = 1,
				AUTO_ONLY_CARDSHOW = 2
			}

			public CHAIN_TYPE chainType;

			public MANUAL_TYPE manualType;

			public LOCATE_TYPE locateType;

			public COMMAND_TYPE commandType;

			public bool autoPlayEnable;

			public bool enemyEmote;

			public bool decideActivateOrder;

			public int showCardInfoType;

			public bool showAudienceInfo;

			public bool showSetCard;

			public bool showBattleStep;

			public SKIP_TYPE skipSummonEffectType;

			public SKIP_TYPE skipMonsterCutinType;

			public SKIP_TYPE skipCardRunEffectType;

			public bool useConsoleLayout;

			public CAMERA_TYPE cameraType;

			public int showRivalName;

			public int showCardReportType;

			public int showHappenedEffectType;

			//public DuelParam(INIT_TYPE initType)
			//{
			//}
		}

		public struct AudienceParam
		{
			public enum INIT_TYPE
			{
				DEFAULT = 0,
				WORK = 1
			}

			public enum SKIP_TYPE
			{
				NONE = 0,
				ALWAYS = 1,
				ONETIME = 2
			}

			public enum CAMERA_TYPE
			{
				NEAR = 0,
				FAR = 1
			}

			public enum SHOW_CARDINFO_TYPE
			{
				NONE = 0,
				AUTO_ALL = 1,
				AUTO_ONLY_CARDSHOW = 2
			}

			public bool enemyEmote;

			public int showCardInfoType;

			public bool showAudienceInfo;

			public bool showSetCard;

			public bool showBattleStep;

			public SKIP_TYPE skipSummonEffectType;

			public SKIP_TYPE skipMonsterCutinType;

			public SKIP_TYPE skipCardRunEffectType;

			public bool useConsoleLayout;

			public CAMERA_TYPE cameraType;

			public int showRivalName;

			public int showCardReportType;

			public int showHappenedEffectType;

			//public AudienceParam(INIT_TYPE initType)
			//{
			//}
		}

		public static readonly string SETTING_JSON_PATH;

		public static readonly string CHAT_SETTING_PATH;

		private static readonly SoundParam defaultSoundParam;

		private static readonly BasicParam defaultBasicParam;

		private static readonly SystemParam defaultSystemParam;

		private static readonly DuelParam defaultDuelParam;

		private static readonly AudienceParam defaultAudienceParam;

		private static SoundParam soundParamCache;

		private static BasicParam basicParamCache;

		private static SystemParam systemParamCache;

		private static DuelParam duelParamCache;

		private static AudienceParam audienceParamCache;

		private static readonly int BaseWidth;

		private static readonly int BaseHeight;

		public static readonly int[] RESOLUTION_WIDTH;

		public static readonly int[] RESOLUTION_HEIGHT;

		public static int bgmVolume => 0;

		public static int seVolume => 0;

		public static int voiceVolume => 0;

		public static bool bgmMute => false;

		public static bool seMute => false;

		public static bool voiceMute => false;

		public static int performance => 0;

		public static BasicParam.QUALITY quality => default(BasicParam.QUALITY);

		public static int resolution => 0;

		public static bool fullScreen => false;

		public static BasicParam.CARD_TEXT_SIZE cardTextSize => default(BasicParam.CARD_TEXT_SIZE);

		public static bool vibration => false;

		public static bool chat => false;

		public static bool pushNotyfy => false;

		public static DuelParam.CHAIN_TYPE chainType => default(DuelParam.CHAIN_TYPE);

		public static DuelParam.MANUAL_TYPE manualType => default(DuelParam.MANUAL_TYPE);

		public static DuelParam.LOCATE_TYPE locateType => default(DuelParam.LOCATE_TYPE);

		public static DuelParam.COMMAND_TYPE commandType => default(DuelParam.COMMAND_TYPE);

		public static bool autoPlay => false;

		public static bool emote => false;

		public static bool decideActivateOrder => false;

		public static int showCardInfoType => 0;

		public static bool showAudienceInfo => false;

		public static bool showSetCard => false;

		public static bool showBattleStep => false;

		public static DuelParam.SKIP_TYPE skipSummonEffectType => default(DuelParam.SKIP_TYPE);

		public static DuelParam.SKIP_TYPE skipMonsterCutinType => default(DuelParam.SKIP_TYPE);

		public static DuelParam.SKIP_TYPE skipCardRunEffectType => default(DuelParam.SKIP_TYPE);

		public static bool useConsoleLayout => false;

		public static DuelParam.CAMERA_TYPE cameraType => default(DuelParam.CAMERA_TYPE);

		public static int showRivalName => 0;

		public static int showCardReportType => 0;

		public static int showHappenedEffectType => 0;

		public static int audienceShowCardInfoType => 0;

		public static bool audienceShowAudienceInfo => false;

		public static bool audienceShowSetCard => false;

		public static bool audienceShowBattleStep => false;

		public static AudienceParam.SKIP_TYPE audienceSkipSummonEffectType => default(AudienceParam.SKIP_TYPE);

		public static AudienceParam.SKIP_TYPE audienceSkipMonsterCutinType => default(AudienceParam.SKIP_TYPE);

		public static AudienceParam.SKIP_TYPE audienceSkipCardRunEffectType => default(AudienceParam.SKIP_TYPE);

		public static bool audienceUseConsoleLayout => false;

		public static AudienceParam.CAMERA_TYPE audienceCameraType => default(AudienceParam.CAMERA_TYPE);

		public static int audienceShowRivalName => 0;

		public static int audienceShowCardReportType => 0;

		public static int audienceShowHappenedEffectType => 0;

		public static bool isUseLightImages
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static void SaveSettings()
		{
		}

		public static void SaveSettings(DuelParam duelParam, SoundParam soundParam)
		{
		}

		public static void SaveSettings(DuelParam duelParam, SoundParam soundParam, BasicParam basicParam, SystemParam systemParam, AudienceParam audienceParam)
		{
		}

		public static void InitializeSettings()
		{
		}

		public static void ApplySettings(bool isDirtyQuality = true)
		{
		}

		public static void OnUpdateSettingsJsonData(object obj)
		{
		}

		public static void ApplyVolumeBGM(float volume)
		{
		}

		public static void ApplyVolumeSE(float volume)
		{
		}

		public static void ApplyVolumeVoice(float volume)
		{
		}

		public static void SetPerformance(int param)
		{
		}

		public static void SetQuality(BasicParam.QUALITY quality)
		{
		}

		public static CardQuality GetCardQuality()
		{
			return default(CardQuality);
		}

		public static int GetNumSelectableResolutions()
		{
			return 0;
		}

		public static void SetResolution(int param)
		{
		}

		public static void SetFullScreen(bool isFullScreen)
		{
		}

		public static bool IsChatSettingEnable()
		{
			return false;
		}

		public static void SetVibration(bool vibration)
		{
		}

		public static void ResetCache()
		{
		}

		private static int GetBgmVolume()
		{
			return 0;
		}

		private static int GetSeVolume()
		{
			return 0;
		}

		private static int GetVoiceVolume()
		{
			return 0;
		}

		private static bool GetBgmMute()
		{
			return false;
		}

		private static bool GetSeMute()
		{
			return false;
		}

		private static bool GetVoiceMute()
		{
			return false;
		}

		private static int GetPerformance()
		{
			return 0;
		}

		private static BasicParam.QUALITY GetQuality()
		{
			return default(BasicParam.QUALITY);
		}

		private static int GetResolution()
		{
			return 0;
		}

		private static BasicParam.CARD_TEXT_SIZE GetCardTextSize()
		{
			return default(BasicParam.CARD_TEXT_SIZE);
		}

		private static bool GetVibration()
		{
			return false;
		}

		private static bool GetChat()
		{
			return false;
		}

		private static bool GetPushNotyfy()
		{
			return false;
		}

		private static DuelParam.CHAIN_TYPE GetChainType()
		{
			return default(DuelParam.CHAIN_TYPE);
		}

		private static DuelParam.MANUAL_TYPE GetManualType()
		{
			return default(DuelParam.MANUAL_TYPE);
		}

		private static DuelParam.LOCATE_TYPE GetLocateType()
		{
			return default(DuelParam.LOCATE_TYPE);
		}

		private static DuelParam.COMMAND_TYPE GetCommandType()
		{
			return default(DuelParam.COMMAND_TYPE);
		}

		private static bool GetEmote()
		{
			return false;
		}

		private static bool GetAutoPlay()
		{
			return false;
		}

		private static bool GetDecideActivateOrder()
		{
			return false;
		}

		private static int GetShowCardInfoType()
		{
			return 0;
		}

		private static bool GetShowAudienceInfo()
		{
			return false;
		}

		private static bool GetShowSetCard()
		{
			return false;
		}

		private static bool GetShowBattleStep()
		{
			return false;
		}

		private static DuelParam.SKIP_TYPE GetSkipSummonEffectType()
		{
			return default(DuelParam.SKIP_TYPE);
		}

		private static DuelParam.SKIP_TYPE GetSkipMonsterCutinType()
		{
			return default(DuelParam.SKIP_TYPE);
		}

		private static DuelParam.SKIP_TYPE GetSkipCardRunEffectType()
		{
			return default(DuelParam.SKIP_TYPE);
		}

		private static bool GetUseConsoleLayout()
		{
			return false;
		}

		private static DuelParam.CAMERA_TYPE GetCameraType()
		{
			return default(DuelParam.CAMERA_TYPE);
		}

		private static int GetShowRivalName()
		{
			return 0;
		}

		private static int GetShowCardReportType()
		{
			return 0;
		}

		private static int GetShowHappenedEffectType()
		{
			return 0;
		}

		private static int GetAudienceShowCardInfoType()
		{
			return 0;
		}

		private static bool GetAudienceShowAudienceInfo()
		{
			return false;
		}

		private static bool GetAudienceSetCard()
		{
			return false;
		}

		private static bool GetAudienceShowBattleStep()
		{
			return false;
		}

		private static AudienceParam.SKIP_TYPE GetAudienceSkipSummonEffectType()
		{
			return default(AudienceParam.SKIP_TYPE);
		}

		private static AudienceParam.SKIP_TYPE GetAudienceSkipMonsterCutinType()
		{
			return default(AudienceParam.SKIP_TYPE);
		}

		private static AudienceParam.SKIP_TYPE GetAudienceSkipCardRunEffectType()
		{
			return default(AudienceParam.SKIP_TYPE);
		}

		private static bool GetAudienceUseConsoleLayout()
		{
			return false;
		}

		private static AudienceParam.CAMERA_TYPE GetAudienceCameraType()
		{
			return default(AudienceParam.CAMERA_TYPE);
		}

		private static int GetAudienceShowRivalName()
		{
			return 0;
		}

		private static int GetAudienceShowCardReportType()
		{
			return 0;
		}

		private static int GetAudienceShowHappenedEfectType()
		{
			return 0;
		}
	}
}
