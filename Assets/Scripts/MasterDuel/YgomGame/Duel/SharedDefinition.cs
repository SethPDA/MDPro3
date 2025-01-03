using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.Duel
{
	public class SharedDefinition
	{
		public enum Location
		{
			Near = 0,
			Far = 1,
			Max = 2
		}

		public enum SelectableShaderZTest
		{
			Always = 0,
			NotEqual = 1,
			Equal = 2,
			GEqual = 3,
			LEqual = 4,
			Greater = 5,
			Less = 6
		}

		public enum SelectableShaderCull
		{
			None = 0,
			Front = 1,
			Back = 2
		}

		public enum ActivateAura
		{
			None = 0,
			LowDefault = 1,
			LowSelecting = 2,
			MiddleDefault = 3,
			MiddleSelecting = 4,
			HighDefault = 5,
			HighSelecting = 6
		}

		public enum DuelSelectorPriority
		{
			Field = 0,
			CardCommand = 1,
			Effect = 2,
			CardDetail = 3,
			Dialog = 4,
			EndMessage = 5,
			HUD = 6,
			CardList = 7,
			OverHUD = 8,
			DrawOperation = 9,
			PhaseSelect = 10,
			TutorialMessage = 11,
			DuelMenu = 12,
			CardInfoDetail = 13,
			ProfileCard = 14,
			Max = 15
		}

		public enum DuelSelectorFieldPriority
		{
			Ground = 0,
			BG = 1,
			Field = 2,
			Hand = 3,
			Log = 4,
			CardViewList = 5,
			CardSelectList = 6,
			Command = 7,
			Dialog = 8
		}

		public enum SummonMaterialType
		{
			None = 0,
			Advance = 1,
			SpSummon = 2,
			Ritual = 3,
			Fusion = 4,
			Syncro = 5,
			Xyz = 6,
			Link = 7
		}

		public enum ZoneType
		{
			Monster = 0,
			Magic = 1,
			Card = 2
		}

		public const int numTeams = 2;

		public const int numCardPoolInstances = 30;

		private static readonly Dictionary<DuelClient.DuelSpeed, float> cardMoveDulationTbl;

		private static readonly Dictionary<DuelClient.DuelSpeed, float> duelTimeScaleTbl;

		public static readonly Vector3 deckToDeckMoveBezierOfs;

		public const string cardModelResPath = "Duel/Models/CardModelWrapper";

		public const string nearFieldQuickModelResPath = "Duel/Models/DuelFieldQuick_FrameNear";

		public const string farFieldQuickModelResPath = "Duel/Models/DuelFieldQiuck_FrameFar";

		public const string nearFieldMaster3ModelResPath = "Duel/Models/DuelFieldMaster3_FrameNear";

		public const string farFieldMaster3ModelResPath = "Duel/Models/DuelFieldMaster3_FrameFar";

		public const string nearFieldNewMasterModelResPath = "Duel/Models/DuelFieldNewMaster_FrameNear";

		public const string farFieldNewMasterModelResPath = "Duel/Models/DuelFieldNewMaster_FrameFar";

		public const float mainCameraFieldOfView = 60f;

		public const float mainCameraDepth = -10f;

		public const float demoCameraDepth = 1f;

		public const float changeCameraDuration = 1f;

		public const float cardObjAlphaDulation = 0.25f;

		public const float cardPlaneBaseY = 0.025f;

		public const float cardIconOfs = 0.01f;

		public const float cardHighlightEffectOfs = 0.02f;

		public const float cardIconY = 0.035f;

		public const float modelStagingDistance = 140f;

		public const float handDistanceNear = 85f;

		public const float handDistanceFar = 105f;

		public const float drawStagingDistance = 56f;

		public const float deckShuffleStagingDistance = 56f;

		public const float modelStagingTweenDulation = 0.4f;

		public const float minIntervalTimeToAbortCutin = 0.5f;

		public static readonly int material_TintColor;

		public static readonly int material_LineColor;

		public static readonly int material_ZTest;

		public static readonly int material_Cull;

		public static readonly int material_BlendDstFactor;

		public static readonly int material_FogEnabled;

		public const string reachedToDuelStartKey = "ReachedToDuelStart";

		public const string reachedToDuelEndKey = "ReachedToDuelEnd";

		public static readonly Color tunerColor;

		public const string SelectorGroupLabelDuelMain = "DuelMain";

		public const string SelectorGroupLabelCommonDialog = "CommonDialog";

		public const string SelectorGroupLabelCardSelectList = "CardSelectList";

		public const string SelectorGroupLabelCardViewList = "CardViewList";

		public static int baseSelectorPriority;

		private const string duelDefinitionSettingPath = "Duel/ScriptableObject/Definition/";

		public const string handCardDefinitionSettingPath = "Duel/ScriptableObject/Definition/HandCardDefine";

		public const string duelEffectDefinitionSettingPath = "Duel/ScriptableObject/Definition/DuelEffectDefine";

		private static DefinitionSetting _duelEffectDefine;

		public static int[] positionPriority;

		public static int[] monsterPositionPriority;

		private static int[] _playerPriority;

		private static int[] _playerPriorityReverse;

		public const int playerNum = 2;

		public const float holdTime = 1f;

		public static float cardMoveDulation => 0f;

		public static float cardFlipDulation => 0f;

		public static float duelTimeScale => 0f;

		public static bool waitCompleteTimeline => false;

		public static float shuffleDeckSpeedNormal => 0f;

		public static float shuffleDeckSpeed => 0f;

		public static DefinitionSetting duelEffectDefine
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static float cardFloatingPositionFactor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardFloatingRotationFactor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardFloatingPower
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardFloatingRotationLimit
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float directAttackPositionHeight
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Vector2 directAttackViewportNear
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Vector2 directAttackViewportFar
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float landingEffectTimeLow
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float landingEffectTimeMiddle
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float landingEffectTimeHigh
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeDurationMax
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeDurationDistanceReductor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeDelayFactor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeHeightMax
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeHeightDistanceReductor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeAngleMax
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float cardShakeAngleDistanceReductor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Vector3 cardModelScaleDefault
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Vector3 cardModelScaleMonster
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Vector3 cardModelScaleMagic
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float lethalSlowScale
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float lethalSlowTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float lethalMateWonMotionTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float lethalMateWonMotionWaitTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static int[] playerPriority => null;

		private static int[] playerPriorityReverse => null;

		public static int recommendSide
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int LocationPlayer(Location location)
		{
			return 0;
		}

		public static Location PlayerLocation(int player)
		{
			return default(Location);
		}

		public static int GetSelectorPriority(DuelSelectorPriority priority)
		{
			return 0;
		}

		public static ZoneType GetZoneType(int player, int position, bool ignoreCard)
		{
			return default(ZoneType);
		}

		public static int GetPlayerPriority(int index)
		{
			return 0;
		}
	}
}
