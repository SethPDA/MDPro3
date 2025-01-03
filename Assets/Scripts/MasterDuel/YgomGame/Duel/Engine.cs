using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using YgomSystem.Network;

namespace YgomGame.Duel
{
	public sealed class Engine
	{
		public enum PlayerType
		{
			Human = 0,
			CPU = 1,
			Remote = 2,
			Replay = 3,
			Replay2 = 4,
			None = -1
		}

		public enum DuelType
		{
			Normal = 0,
			Extra = 1,
			Tag = 2,
			Quick = 3,
			Rush = 4
		}

		public enum ResultType
		{
			None = 0,
			Win = 1,
			Lose = 2,
			Draw = 3,
			Time = 4
		}

		public enum FinishType
		{
			None = 0,
			Normal = 1,
			NoDeck = 2,
			TimeOut = 3,
			Surrender = 4,
			Failed = 5,
			Exodia = 6,
			Vija = 7,
			YataLock = 8,
			LastBattle = 9,
			CountDown = 10,
			Victory = 11,
			Venom = 12,
			Exodios = 13,
			God = 14,
			Gimmick = 15,
			Gimmick2 = 16,
			Jackpot7 = 17,
			Miracle = 18,
			RelaySoul = 19,
			Ghostrick = 20,
			Genohryu = 21,
			Winners = 22,
			Elephant = 23,
			Exodia2 = 24,
			Exodia3 = 25,
			CiNo1000 = 26,
			Sekitori = 27,
			FinishError = 100,
			FinishDisconnect = 101,
			FinishNoContest = 102,
			FinishEngineCrash = 105
		}

		public enum LimitedType
		{
			None = 0,
			NormalSummon = 1,
			SpecialSummon = 2,
			Set = 3,
			Tribute = 4,
			ChangePos = 5,
			Attack = 6,
			Draw2 = 7,
			Turn20 = 8,
			Damage = 9,
			Beginner = 10,
			Beginner2 = 11,
			Vs2on1 = 12,
			Vs2on1_Hand = 13,
			FirstDraw = 14,
			Vs3on1 = 15,
			Survival_1on3 = 256,
			Survival_3on3 = 257,
			Survival_1on2 = 258
		}

		public enum TagType
		{
			Single = 0,
			Tag = 1,
			Team = 2
		}

		public enum Phase
		{
			Draw = 0,
			Standby = 1,
			Main1 = 2,
			Battle = 3,
			Main2 = 4,
			End = 5,
			Null = 7
		}

		public enum StepType
		{
			Null = 0,
			Start = 1,
			Battle = 2,
			Damage = 3,
			End = 4
		}

		public enum DmgStepType
		{
			Null = 0,
			Start = 1,
			BeforeCalc = 2,
			DamageCalc = 3,
			AfterCalc = 4,
			End = 5
		}

		public enum CounterType
		{
			Magic = 0,
			Normal = 1,
			Clock = 2,
			Hyper = 3,
			Gem = 4,
			Chronicle = 5,
			Bushido = 6,
			D = 7,
			Shine = 8,
			Gate = 9,
			Worm = 10,
			Deformer = 11,
			Flower = 12,
			Plant = 13,
			Psycho = 14,
			EarthBind = 15,
			Junk = 16,
			Genex = 17,
			Dragonic = 18,
			Ocean = 19,
			BF = 20,
			Death = 21,
			Karakuri = 22,
			Stone = 23,
			Thunder = 24,
			Donguri = 25,
			Greed = 26,
			Chaos = 27,
			Double = 28,
			Destiny = 29,
			Orbital = 30,
			Shark = 31,
			Pumpkin = 32,
			HopeSlash = 33,
			Kattobing = 34,
			Balloon = 35,
			Yosen = 36,
			Sound = 37,
			Em = 38,
			Kaiju = 39,
			Defect = 40,
			Athlete = 41,
			Barrel = 42,
			Summon = 43,
			FireStar = 44,
			Phantasm = 45,
			Otoshidama = 46,
			Ounokagi = 47,
			Piece = 48,
			Girl = 49,
			Gardna = 50,
			Alien = 51,
			Ice = 52,
			Venom = 53,
			Fog = 54,
			Guard = 55,
			Wedge = 56,
			Guard2 = 57,
			String = 58,
			Houkai = 59,
			Zushin = 60,
			Predator = 61,
			Scales = 62,
			Police = 63,
			Signal = 64,
			Venemy = 65,
			Burn = 66,
			Illusion = 67,
			GG = 68,
			Rabbit = 69,
			Kyoumei = 70,
			Max = 71
		}

		public enum ViewType
		{
			Noop = -1,
			Null = 0,
			DuelStart = 1,
			DuelEnd = 2,
			WaitFrame = 3,
			WaitInput = 4,
			PhaseChange = 5,
			TurnChange = 6,
			FieldChange = 7,
			CursorSet = 8,
			BgmUpdate = 9,
			BattleInit = 10,
			BattleSelect = 11,
			BattleAttack = 12,
			BattleRun = 13,
			BattleEnd = 14,
			LifeSet = 15,
			LifeDamage = 16,
			LifeReset = 17,
			HandShuffle = 18,
			HandShow = 19,
			HandOpen = 20,
			DeckShuffle = 21,
			DeckReset = 22,
			DeckFlipTop = 23,
			GraveTop = 24,
			CardLockon = 25,
			CardMove = 26,
			CardSwap = 27,
			CardFlipTurn = 28,
			CardCheat = 29,
			CardSet = 30,
			CardVanish = 31,
			CardBreak = 32,
			CardExplosion = 33,
			CardExclude = 34,
			CardHappen = 35,
			CardDisable = 36,
			CardEquip = 37,
			CardIncTurn = 38,
			CardUpdate = 39,
			ManaSet = 40,
			MonstDeathTurn = 41,
			MonstShuffle = 42,
			TributeSet = 43,
			TributeReset = 44,
			TributeRun = 45,
			MaterialSet = 46,
			MaterialReset = 47,
			MaterialRun = 48,
			TuningSet = 49,
			TuningReset = 50,
			TuningRun = 51,
			ChainSet = 52,
			ChainRun = 53,
			RunSurrender = 54,
			RunDialog = 55,
			RunList = 56,
			RunSummon = 57,
			RunSpSummon = 58,
			RunFusion = 59,
			RunDetail = 60,
			RunCoin = 61,
			RunDice = 62,
			RunYujyo = 63,
			RunSpecialWin = 64,
			RunVija = 65,
			RunExtra = 66,
			RunCommand = 67,
			CutinDraw = 68,
			CutinSummon = 69,
			CutinFusion = 70,
			CutinChain = 71,
			CutinActivate = 72,
			CutinSet = 73,
			CutinReverse = 74,
			CutinTurn = 75,
			CutinFlip = 76,
			CutinTurnEnd = 77,
			CutinDamage = 78,
			CutinBreak = 79,
			CpuThinking = 80,
			HandRundom = 81,
			OverlaySet = 82,
			OverlayReset = 83,
			OverlayRun = 84,
			CutinSuccess = 85,
			ChainEnd = 86,
			LinkSet = 87,
			LinkReset = 88,
			LinkRun = 89,
			RunJanken = 90,
			CutinCoinDice = 91,
			ChainStep = 92,
			RunSpecialefx = 93
		}

		public enum FieldAnimeType
		{
			Null = 0,
			CardMove = 1,
			CardWarp = 2,
			CardSwap = 3
		}

		public enum CardMoveType
		{
			Normal = 0,
			Normal2 = 1,
			Summon = 2,
			SpSummon = 3,
			Activate = 4,
			Set = 5,
			Break = 6,
			Explosion = 7,
			Sacrifice = 8,
			Draw = 9,
			Drop = 10,
			Search = 11,
			Used = 12,
			Put = 13,
			Normal3 = 14
		}

		public struct CardProp
		{
			public ushort cardId
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

			public ushort uniqueId
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

			public ushort flags
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

			public int CardID
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int UniqueID
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int Owner
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool Correct
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool ByBattle
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool ByAnother
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool ByBreak
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool TurnPast
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool Disabled
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool TimingPast
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public CardProp(uint param)
			{
			}
		}

		public struct CardStatus
		{
			private BitVector32.Section player;

			private BitVector32.Section position;

			private BitVector32.Section index;

			private BitVector32.Section face;

			private BitVector32.Section turn;

			private BitVector32 bitVec;

			public int Player
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int Position
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int Index
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool Face
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool Turn
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public int ToInt()
			{
				return 0;
			}

			//public CardStatus(int param)
			//{
			//}
		}

		public struct BasicVal
		{
			public short CardID;

			public short EffectID;

			public int Atk;

			public int Def;

			public int OrgAtk;

			public int OrgDef;

			public short Type;

			public short Attr;

			public short Element;

			public short Level;

			public byte Rank;

			public byte VoidMagic;

			public byte VoidTrap;

			public byte VoidMonst;
		}

		public enum MenuActType
		{
			Null = 0,
			DrawPhase = 1,
			MainPhase = 2,
			BattlePhase = 3,
			CheckTiming = 4,
			CheckChain = 5,
			SummonChance = 6,
			Location = 7,
			Selection = 8,
			LockOn = 9
		}

		public enum MenuParamType
		{
			Force = -1,
			Cancel = 0,
			Decide = 1,
			TrueCancel = 2,
			OnlyCancel = 3,
			DecideCancel = 4
		}

		public enum CommandType
		{
			Attack = 0,
			Look = 1,
			SummonSp = 2,
			Action = 3,
			Summon = 4,
			Reverse = 5,
			SetMonst = 6,
			Set = 7,
			Pendulum = 8,
			TurnAtk = 9,
			TurnDef = 10,
			Surrender = 11,
			Decide = 12,
			Draw = 13
		}

		[Flags]
		public enum CommandBit
		{
			Attack = 1,
			Look = 2,
			SummonSp = 4,
			Action = 8,
			Summon = 0x10,
			Reverse = 0x20,
			SetMonst = 0x40,
			Set = 0x80,
			Pendulum = 0x100,
			TurnAtk = 0x200,
			TurnDef = 0x400,
			Surrender = 0x800,
			Decide = 0x1000,
			Draw = 0x2000
		}

		public enum CardLink
		{
			UL = 0,
			U = 1,
			UR = 2,
			L = 3,
			R = 4,
			DL = 5,
			D = 6,
			DR = 7
		}

		[Flags]
		public enum CardLinkBit
		{
			UL = 1,
			U = 2,
			UR = 4,
			L = 8,
			R = 0x10,
			DL = 0x20,
			D = 0x40,
			DR = 0x80
		}

		public enum ShowParam
		{
			Null = 0,
			Type = 1,
			Attr = 2,
			Card = 3,
			Num = 4,
			AttrMask = 5
		}

		public enum DamageType
		{
			ByEffect = 0,
			ByBattle = 1,
			ByCost = 2,
			ByLost = 3,
			Recover = 4
		}

		[Flags]
		public enum BtlPropFlag
		{
			Turn = 1,
			Break = 2,
			Damage = 4
		}

		public enum AffectType
		{
			Null = 0,
			Equip = 1,
			Permanent = 2,
			Field = 3,
			Bind = 4,
			Power = 5,
			Target = 6,
			Disable = 7,
			Chain = 256
		}

		public enum SpSummonType
		{
			Fusion = 0,
			SpFusion = 1,
			Synchro = 2,
			Ritual = 3,
			Xyz = 4,
			Pendulum = 5,
			Link = 6
		}

		public enum CutinSummonType
		{
			Normal = 0,
			Release1 = 1,
			Release2 = 2,
			Release3 = 3,
			Reverse = 4,
			SpByEffect = 5,
			SpNormal = 6,
			ReSummon = 7,
			PreSynchro = 8,
			PreXyz = 9,
			PrePendulum = 10,
			Link = 11
		}

		public enum CutinActivateType
		{
			NoChain = 0,
			FromField = 1,
			FromHand = 2,
			Activate = 3,
			Effect = 4,
			FldGrave = 5,
			CostEffect = 6
		}

		[Flags]
		public enum CpuParam : uint
		{
			None = 0u,
			Def = 0x80000000u,
			Fool = 0x40000000u,
			Light = 0x20000000u,
			MyTurnOnly = 0x10000000u,
			AttackOnly = 0x4000000u,
			Simple = 0x2000000u,
			Simple2 = 0x1000000u,
			Simples = 0x3000000u
		}

		public enum RunCommandType
		{
			Null = 0,
			PriWaitInput = 1,
			PriCpuThinking = 2,
			PriRunDialog = 3,
			PriRunList = 4
		}

		public enum DialogType
		{
			Ok = 0,
			Info = 1,
			Confirm = 2,
			YesNo = 3,
			Effect = 4,
			Sort = 5,
			Select = 6,
			Phase = 7,
			SelType = 8,
			SelAttr = 9,
			SelStand = 10,
			SelCoin = 11,
			SelDice = 12,
			SelNum = 13,
			Final = 14,
			Result = 15,
			Discard = 16,
			Ritual = 17,
			Update = 18,
			Close = 19
		}

		public enum DialogInfo
		{
			CardName = 0,
			CardName2 = 1,
			SelectItem = 2,
			CardType = 3,
			CardAttr = 4,
			CardLevel = 5,
			Coin = 6,
			Dice = 7,
			Dice2 = 8,
			DiceChange = 9,
			NotHappen = 10,
			CardAttr2 = 11,
			Info = 12,
			Info2 = 13,
			Confirm = 14
		}

		public enum DialogOkType
		{
			Stop = 0,
			Once = 1,
			Forever = 2,
			Sub = 3
		}

		public enum DialogEffectType
		{
			None = 0,
			All = 1,
			More = 2,
			Auto = 3,
			Always = 4
		}

		public enum DialogRitualType
		{
			Ritual = 0,
			Multi = 1,
			Atk = 2,
			Sync = 3,
			Link = 4
		}

		public enum DialogMixTextType
		{
			Null = 0,
			AddString = 1,
			AddCr = 2,
			InsString = 3,
			InsStringNoColor = 4,
			InsCard = 5,
			InsType = 6,
			InsAttr = 7,
			InsNum = 8,
			InsStringIfable = 9
		}

		private class CachedParam
		{
			private int myself;

			private PlayerType[] playerType;

			public uint[] cpuParam;

			public void SetMyPlayerNum(int player)
			{
			}

			public int GetMyPlayerNum()
			{
				return 0;
			}

			public void SetPlayerType(int player, PlayerType type)
			{
			}

			public int IsPlayerType(int player, PlayerType type)
			{
				return 0;
			}

			public int Myself()
			{
				return 0;
			}

			public int Rival()
			{
				return 0;
			}

			public int IsMyself(int player)
			{
				return 0;
			}

			public int IsRival(int player)
			{
				return 0;
			}
		}

		public delegate int RunEffect(int id, int param1, int param2, int param3);

		public delegate int IsBusyEffect(int id);

		public delegate void AddRecord(IntPtr ptr, int size);

		public delegate IntPtr NowRecord();

		public delegate void RecordNext();

		public delegate void RecordBegin();

		public delegate int IsRecordEnd();

		public delegate int ThreadRunEffectDeleg(int id, int param1, int param2, int param3);

		public delegate int ThreadIsBusyEffectDeleg(int id);

		public delegate void ThreadAddRecordDeleg(IntPtr ptr, int size);

		public delegate IntPtr ThreadNowRecordDeleg();

		public delegate void ThreadRecordNextDeleg();

		public delegate void ThreadRecordBeginDeleg();

		public delegate int ThreadIsRecordEndDeleg();

		public enum ListType
		{
			Null = 0,
			Fusion = 1,
			Deck = 2,
			Grave = 3,
			Exclude = 4,
			View = 5,
			Select = 6,
			SelectMax = 38,
			Selectable = 39,
			SelectableMax = 71,
			SelUpTo = 72,
			SelUpToMax = 104,
			SelFree = 105,
			SelFreeMax = 137,
			BlindSelect = 138,
			AutoSelect = 139,
			SelAllCard = 140,
			SelAllDeck = 141,
			SelAllMonst = 142,
			SelAllMonst2 = 143,
			SelAllGadget = 144,
			SelAllIndeck = 145
		}

		[Flags]
		public enum ListAttribute
		{
			FromField = 1,
			FromHand = 2,
			FromDeck = 4,
			FromGrave = 8,
			FromExtra = 0x10,
			FromExclude = 0x20,
			DisableEffect = 0x40,
			CantRevive = 0x80,
			FusionMaterial = 0x100,
			DemensionHole = 0x400,
			LightForce = 0x800,
			Targeted = 0x1000,
			Tuning = 0x2000,
			ByBattle = 0x4000,
			Opponent = 0x8000,
			Activate = 0x10000,
			Cost = 0x20000,
			End = 0x40000,
			ExtraExclude = 0x80000,
			FromMask = 0x3F
		}

		private class PvpPosBase
		{
			public uint nComBit;

			public ushort wMrk;

			public ushort wTurnCounter;

			public byte bTopIdx;

			public byte bEffectFlags;

			public byte bMonstOrgLevel;

			public byte bMonstOrgType;

			public byte bZoneAvailable;

			public byte bZoneAvailable2;

			public byte bCardInBattle;

			public byte bNormalMonster;

			public sbyte bPendScale;

			public sbyte bPendOrgScale;

			public sbyte bMonstRank;

			public sbyte bMonstOrgRank;

			public byte bTrapMonster;

			public byte bTunerMonster;

			public ushort wOverlayNum;

			public ushort wCardNum;

			public byte[] bCounter;

			public byte bFightable;

			public ushort wEquip;

			public ushort wContinuous;

			public byte bIsMagic;

			public byte bIsTrap;

			public uint nComBitTextId;

			public int nShowParam;

			public uint nCardParam;

			public int nCardDirectFlag;

			public int[] nOtherEffect;
		}

		private class PvpIconBase
		{
			public byte player;

			public byte pos;

			public byte to_player;

			public byte to_pos;

			public short icon;
		}

		private class PvpDuelInfo
		{
			public bool isQuick;

			public uint nTurnNum;

			public uint nCurrentPhase;

			public uint nCurrentStep;

			public uint nCurrentDmgStep;

			public byte bWhichTurnNow;

			public uint nMovablePhase;

			public uint[] nLP;

			public uint[] nDoPutMonst;

			public bool[] bDoSummon;

			public bool[] bDoSpSummon;

			public PvpPosBase[,] Pos;

			public ushort wTblNum;

			public ushort wIconNum;

			public PvpIconBase[] IconBases;

			public bool isDeckReverse;
		}

		private class PvpUIDBase
		{
			public uint nCom;

			public uint nPos;

			public ushort wUid;

			public CardProp stProp;

			public bool isFace;

			public bool isTurn;

			public BasicVal stBasicVal;

			public uint nComTextId;
		}

		private class PvpEngineData
		{
			public PvpDuelInfo duelInfo;

			public Dictionary<uint, ushort> posTbl;

			public Dictionary<ushort, ushort> uidTbl;

			public PvpUIDBase[] uidBases;

			public KeyValuePair<uint, ushort>[] originPos;

			public KeyValuePair<ushort, ushort>[] originUid;

			public ushort[] attackFlags;

			public Dictionary<int, uint> flipInfo;

			public Dictionary<ushort, int>[] cardAttribute;

			public bool attackFinish;

			public byte syncNeed;

			public Dictionary<int, int> tuningMonster;

			public Dictionary<int, int> tuningLevel;

			public int effectIdAtChain;

			public int summoningUid;

			public Dictionary<string, uint> posMask;

			public int recommendSide;
		}

		private class PvpDialogData
		{
			public DialogType dlgType;

			public int player;

			public int selMax;

			public uint[] sel;

			public uint posMaskSummon;

			public PvpDialogData(int num)
			{
			}

			public int GetSelectItemStr(int idx)
			{
				return 0;
			}

			public bool GetSelectItemEnable(int idx)
			{
				return false;
			}
		}

		private class PvpListData
		{
			public ListType listType;

			public int selMax;

			public int selMin;

			public short itemMax;

			public ushort[] itemUids;

			public uint[] itemAttributes;

			public int[] itemFrom;

			public uint[] itemIds;

			public uint[] itemMsg;

			public uint[] itemTargetUids;

			public MixedValue[] itemMixVal;
		}

		private class PvpFusionData
		{
			public int[] material;

			public int[] mrk;
		}

		private enum PvpCommandType
		{
			Input = 0,
			List = 1,
			Dialog = 2,
			Effect = 3,
			Field = 4,
			Data = 5,
			Fusion = 6,
			Time = 7,
			ListFrom = 8,
			FlipInfo = 9,
			FinishAttack = 10,
			MrkList = 11,
			FusionNeed = 12,
			TunerLevel = 13,
			CutinActivate = 14
		}

		private enum PvpFieldType
		{
			Prop = 1,
			Pos = 2,
			Uid = 3,
			Vals = 4,
			Icon = 5,
			Skill = 6,
			Rare = 7,
			Attack = 8,
			Show = 9,
			Step = 10,
			SummoningUid = 11,
			PosMask = 12,
			End = 13
		}

		private class PvpCommand
		{
			public PvpCommandType type;

			public int[] param;

			public object data;

			public PvpCommand(PvpCommandType t, int[] p, object o)
			{
			}
		}

		private class MixedValue
		{
			public int mixNum;

			public uint[] mixValue;

			public MixedValue(int num, uint[] values)
			{
			}
		}

		private class PvpWork
		{
			private Queue<PvpCommand> commandQueue;

			public PvpEngineData currentEngineData;

			public PvpDialogData currentDialogData;

			public PvpListData currentListData;

			public PvpFusionData currentFusionData;

			public Dictionary<ushort, ushort> rareTbl;

			public int mixNum;

			public uint[] mixValue;

			public ushort[] currentListMrk;

			public Queue<MixedValue> mixvalQueue;

			public int[] CurrentParam;

			private uint serializer;

			public ViewType RunningEffect
			{
				[CompilerGenerated]
				get
				{
					return default(ViewType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ViewType CurrentRunEffect
			{
				[CompilerGenerated]
				get
				{
					return default(ViewType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public uint TimeLeft
			{
				[CompilerGenerated]
				get
				{
					return 0u;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public uint TimeTotal
			{
				[CompilerGenerated]
				get
				{
					return 0u;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool inputGuard
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Release()
			{
			}

			public void AddCommand(PvpCommand cmd)
			{
			}

			public PvpCommand GetCommand()
			{
				return null;
			}

			public bool IsQueued()
			{
				return false;
			}

			public PvpCommand Next()
			{
				return null;
			}

			public ViewType NextEffect()
			{
				return default(ViewType);
			}

			public bool IsRunningEffect()
			{
				return false;
			}

			public uint Serial()
			{
				return 0u;
			}
		}

		public enum ToEngineActType
		{
			DoCommand = 0,
			CancelCommand = 1,
			MovePhase = 2,
			DebugCommand = 3,
			DoDebug = 4,
			CheatCard = 5,
			DialogResult = 6,
			ListSendBlindIndex = 7,
			ListSendIndex = 8,
			ListSendSelectMulti = 9,
			ForceSurrender = 10
		}

		[Serializable]
		public class ThreadPosParam
		{
			public int nShowParam;

			public uint nCardParam;

			public int nCardDirect;
		}

		[Serializable]
		public class ThreadPosBase
		{
			public uint nComBit;

			public int wMrk;

			public int wTurnCounter;

			public int bTopIdx;

			public int bEffectFlags;

			public int bMonstOrgLevel;

			public int bMonstOrgType;

			public int bZoneAvailable;

			public int bZoneAvailable2;

			public int bNormalMonster;

			public int bPendScale;

			public int bPendOrgScale;

			public int bMonstRank;

			public int bMonstOrgRank;

			public int bTrapMonster;

			public int bTunerMonster;

			public int bOverlayNum;

			public int wCardNum;

			public int[] bCounter;

			public int[] otherEffect;

			public bool Fightable;

			public int Equip;

			public int Continuous;

			public bool IsMagic;

			public bool IsTrap;

			public uint nComBitTextId;
		}

		[Serializable]
		public class ThreadIconBase
		{
			public int player;

			public int pos;

			public int to_player;

			public int to_pos;

			public int icon;
		}

		[Serializable]
		public class ThreadPlayerInfo
		{
			public int LP;

			public int DoPutMonst;

			public bool DoSummon;

			public bool DoSpSummon;
		}

		[Serializable]
		public class ThreadDuelInfo
		{
			public uint nTurnNum;

			public uint nCurrentPhase;

			public int bWhichTurnNow;

			public uint nMovablePhase;

			public ThreadPosBase[,] Pos;

			public uint nCurrentStep;

			public uint nCurrentDmgStep;

			public ThreadPlayerInfo[] playerInfo;
		}

		[Serializable]
		public class CardPropSerial
		{
			public int CardID;

			public int UniqueID;

			public int Owner;

			public bool Correct;

			public bool ByBattle;

			public bool ByAnother;

			public bool ByBreak;

			public bool TurnPast;

			public bool Disabled;

			public bool TimingPast;
		}

		[Serializable]
		public class BasicValSerial
		{
			public short CardID;

			public short EffectID;

			public int Atk;

			public int Def;

			public int OrgAtk;

			public int OrgDef;

			public short Type;

			public short Attr;

			public short Element;

			public short Level;

			public byte Rank;

			public byte VoidMagic;

			public byte VoidTrap;

			public byte VoidMonst;
		}

		[Serializable]
		public class ToMainRunEffect
		{
			public int[] param;

			public ThreadEngineData engineData;

			public ThreadDialogData dialogData;

			public ThreadListData listData;

			public ThreadFusionData fusionData;

			public ThreadMixTextData mixTextData;

			public Dictionary<string, int> attackFlags;

			public ThreadIconBase[] IconBases;

			public Dictionary<int, uint> flipInfo;

			public ThreadPosParam[][] posParam;
		}

		[Serializable]
		public class ToMainWork
		{
			public bool finishedSysAct;

			public ToMainRunEffect runeffectData;
		}

		[Serializable]
		public class ToEngineWork
		{
			public ToEngineActType actType;

			public int player;

			public int position;

			public int index;

			public int commandId;

			public int phase;

			public int cardId;

			public int face;

			public int turn;

			public uint dlgResult;

			public int listIndex;

			public int listNum;

			public bool decide;

			public int[] listSelect;
		}

		[Serializable]
		public class ThreadUIDBase
		{
			public uint nCom;

			public uint nPos;

			public int wUid;

			public CardPropSerial stProp;

			public bool isFace;

			public bool isTurn;

			public BasicValSerial stBasicVal;

			public uint nComTextId;
		}

		[Serializable]
		public class ThreadEngineData : IDisposable
		{
			public ThreadDuelInfo duelInfo;

			public Dictionary<uint, int> posTbl;

			public Dictionary<int, int> uidTbl;

			public ThreadUIDBase[] uidBases;

			public Dictionary<int, int>[] cardAttribute;

			public Dictionary<string, uint> posMask;

			public bool attackFinish;

			public int syncNeed;

			public int[] tuningLevel;

			public int effectIdAtChain;

			public int summoningUid;

			public int recommendSide;

			public bool flagDeckReverse;

			public void Dispose()
			{
			}
		}

		[Serializable]
		public class ThreadDialogData : IDisposable
		{
			public DialogType dlgType;

			public int textId;

			public int selNum;

			public int[] selStr;

			public bool[] selEnable;

			public bool yesno;

			public uint posMaskSummon;

			public void Dispose()
			{
			}
		}

		[Serializable]
		public class ThreadListData : IDisposable
		{
			public ListType listType;

			public int selMax;

			public int selMin;

			public int itemMax;

			public int[] itemUids;

			public int[] itemAttributes;

			public int[] itemFrom;

			public int[] itemIds;

			public int[] itemTargetUids;

			public int[] itemMsg;

			public ThreadMixTextData[] itemMsgVal;

			public void Dispose()
			{
			}
		}

		[Serializable]
		public class ThreadFusionData : IDisposable
		{
			public int[] material;

			public int[] mrk;

			public void Dispose()
			{
			}
		}

		[Serializable]
		public class ThreadMixTextData : IDisposable
		{
			public int mixNum;

			public int[] mixType;

			public int[] mixData;

			public void Dispose()
			{
			}
		}

		private class ThreadWork
		{
			public ThreadEngineData currentEngineData;

			public ThreadDialogData currentDialogData;

			public ThreadListData currentListData;

			public ThreadFusionData currentFusionData;

			public ThreadMixTextData currentMixTextData;

			public Dictionary<string, int> attackFlags;

			public ThreadIconBase[] IconBases;

			public Dictionary<uint, object> affectsMgr;

			public AffectType[][] dummyAffects;

			public Dictionary<int, uint> flipInfo;

			public ThreadPosParam[][] posParam;

			public ViewType RunningEffect
			{
				[CompilerGenerated]
				get
				{
					return default(ViewType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ViewType CurrentRunEffect
			{
				[CompilerGenerated]
				get
				{
					return default(ViewType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int thinkingPlayer
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

			public float startTime
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float lastTime
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Release()
			{
			}

			public bool IsRunningEffect()
			{
				return false;
			}
		}

		[Serializable]
		public struct ThreadIconBuff
		{
			public int player;

			public int pos;

			public int to_player;

			public int to_pos;

			public int icon;
		}

		public const int CardIdStart = 3000;

		public const int MaxPlayer = 4;

		public const int MaxDuelList = 300;

		public const int PosMonster = 0;

		public const int PosMonsterLL = 0;

		public const int PosMonsterL = 1;

		public const int PosMonsterC = 2;

		public const int PosMonsterR = 3;

		public const int PosMonsterRR = 4;

		public const int PosMonsterMEnd = 4;

		public const int PosExLMonster = 5;

		public const int PosExRMonster = 6;

		public const int PosMonsterEnd = 6;

		public const int PosMagic = 7;

		public const int PosMagicLL = 7;

		public const int PosMagicL = 8;

		public const int PosMagicC = 9;

		public const int PosMagicR = 10;

		public const int PosMagicRR = 11;

		public const int PosMagicEnd = 11;

		public const int PosPendulumLeft = 7;

		public const int PosPendulumRight = 11;

		public const int PosField = 12;

		public const int PosHand = 13;

		public const int PosExtra = 14;

		public const int PosDeck = 15;

		public const int PosGrave = 16;

		public const int PosExclude = 17;

		public const int PosSelect = 18;

		public const int PosNum = 18;

		public const int DialogTextMixed = 1;

		private const string LIBNAME = "duel";

		private CachedParam cachedParam;

		private static Engine s_instance;

		private RunEffect runEffectCallback;

		private IsBusyEffect isBusyEffectCallback;

		private NowRecord nowRecordCallback;

		private RecordNext recordNextCallback;

		private RecordBegin recordBeginCallback;

		private IsRecordEnd isRecordEndCallback;

		private ThreadRunEffectDeleg threadRunEffectCallback;

		private ThreadIsBusyEffectDeleg threadIsBusyEffectCallback;

		private Action updateTimerCallback;

		private Action inputStartCallback;

		private Action noResponseCallback;

		private Action recoveryResponseCallback;

		private Action noResponseClosedCallback;

		private IntPtr engineWork;

		private IntPtr cardRareBufferPtr;

		private int cardRareBufferSize;

		private IntPtr cardExistBuffer;

		private int cardExistBufferSize;

		private IntPtr questionData;

		private Dictionary<PvP.Command, Queue<byte[]>> dicRemoteRecvQueue;

		private Dictionary<PvP.Command, uint> dicRemoteRecvOrder;

		private uint remoteRecvOrder;

		private float inputStartTime;

		private bool isInputNow;

		private bool isOnlineMode;

		private bool inputTimerSetting;

		private Util.GameMode gameMode;

		private bool isExitPvp;

		private int[] mat;

		private int[] sleeve;

		private int[] latency;

		private ReplayStream replayStream;

		private Dictionary<CounterType, int> dicCounterToId;

		private Dictionary<int, CounterType> dicIdToCounter;

		private int[] initialLP;

		private PvpWork pvpWork;

		private bool pvpFinished;

		public const int UNTIL_FIELD_ZONE_ONE = 13;

		public const int UNTIL_FIELD_ZONE_TWO = 26;

		public const int UNTIL_FIELD_ZONE_ALL = 676;

		public const int UNTIL_MONSTER_ZONE_ONE = 7;

		public const int MAX_SYSACT_LOOP = 30;

		public const float CPU_CHANGE_TIME_SIMPLE = 4f;

		public const float CPU_CHANGE_TIME_FOOL = 19f;

		private static float CpuChangeTimeSimple;

		private static float CpuChangeTimeFool;

		private static bool s_bSimple;

		private static bool s_bFool;

		public static BlockingQueue<ToMainWork> ToMainQueue;

		public static BlockingQueue<ToEngineWork> ToEngineQueue;

		public static bool forceSurrender;

		private static Thread DuelEngineThread;

		private const int MIX_BUFF_SIZE_MAX = 8;

		private ThreadWork threadWork;

		private static bool isBusyCheck;

		private static bool isThreadFinished;

		private static bool isSurrender;

		private static bool isThreadRunEffectDuelEnd;

		private static ThreadIconBuff[] buffAffectIcon;

		private static ThreadPosParam[][] buffPosParam;

		private static bool IsNotOnline => false;

		public static int CounterTypeMax => 0;

		public static ReplayStream ReplayStream
		{
			set
			{
			}
		}

		public static bool InputTimerSetting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool InputNow => false;

		public static Util.GameMode CachedGameMode => default(Util.GameMode);

		public static bool IsOnline => false;

		public static bool CheckPosBit(uint mask, int player, int pos)
		{
			return false;
		}

		public static bool IsEnableBattleDamagePlayer(int prop, int player, BtlPropFlag flag)
		{
			return false;
		}

		[PreserveSig]
		private static extern int DLL_DuelDlgGetMixNum();

		[PreserveSig]
		private static extern int DLL_DuelDlgGetMixType(int index);

		[PreserveSig]
		private static extern int DLL_DuelDlgGetMixData(int index);

		[PreserveSig]
		private static extern void DLL_DuelDlgSetResult(uint result);

		[PreserveSig]
		private static extern int DLL_DuelDlgCanYesNoSkip();

		[PreserveSig]
		private static extern int DLL_DuelDlgGetPosMaskOfThisSummon();

		[PreserveSig]
		private static extern int DLL_DuelDlgGetSelectItemNum();

		[PreserveSig]
		private static extern int DLL_DuelDlgGetSelectItemStr(int index);

		[PreserveSig]
		private static extern int DLL_DuelDlgGetSelectItemEnable(int index);

		[PreserveSig]
		private static extern int DLL_DlgProcGetSummoningMonsterUniqueID();

		public static int DialogGetMixNum()
		{
			return 0;
		}

		public static DialogMixTextType DialogGetMixType(int index)
		{
			return default(DialogMixTextType);
		}

		public static int DialogGetMixData(int index)
		{
			return 0;
		}

		public static void DequeueDialogMixData()
		{
		}

		public static void DialogSetResult(uint result)
		{
		}

		public static bool DialogCanYesNoSkip()
		{
			return false;
		}

		public static uint DialogGetPosMaskOfThisSummon()
		{
			return 0u;
		}

		public static int DialogGetSelectItemNum()
		{
			return 0;
		}

		public static int DialogGetSelectItemStr(int index)
		{
			return 0;
		}

		public static bool DialogGetSelectItemEnable(int index)
		{
			return false;
		}

		public static int DialogGetSummoningMonsterUniqueID()
		{
			return 0;
		}

		[PreserveSig]
		private static extern int DLL_GetRevision();

		[PreserveSig]
		private static extern int DLL_GetBinHash(int iIndex);

		[PreserveSig]
		private static extern int DLL_SetWorkMemory(IntPtr pWork);

		[PreserveSig]
		private static extern int DLL_DuelSysInitRush();

		[PreserveSig]
		private static extern int DLL_DuelSysInitQuestion(IntPtr pScript);

		[PreserveSig]
		private static extern int DLL_DuelSysInitCustom(int fDuelType, bool tag, int life0, int life1, int hand0, int hand1, bool shuf);

		[PreserveSig]
		private static extern int DLL_DuelSysAct();

		[PreserveSig]
		private static extern void DLL_DuelSysClearWork();

		[PreserveSig]
		private static extern void DLL_DuelSysSetDeck2(int player, int[] mainDeck, int mainNum, int[] extraDeck, int extraNum, int[] sideDeck, int sideNum);

		[PreserveSig]
		private static extern void DLL_DuelSetRandomSeed(uint seed);

		[PreserveSig]
		private static extern void DLL_DuelSetMyPlayerNum(int player);

		[PreserveSig]
		private static extern void DLL_DuelSetPlayerType(int player, int type);

		[PreserveSig]
		private static extern int DLL_DuelIsHuman(int player);

		[PreserveSig]
		private static extern int DLL_DuelMyself();

		[PreserveSig]
		private static extern int DLL_DuelRival();

		[PreserveSig]
		private static extern int DLL_DuelIsMyself(int player);

		[PreserveSig]
		private static extern int DLL_DuelIsRival(int player);

		[PreserveSig]
		private static extern void DLL_DuelSetCpuParam(int player, uint param);

		[PreserveSig]
		private static extern void DLL_DuelSetFirstPlayer(int player);

		[PreserveSig]
		private static extern int DLL_DuelGetDuelResult();

		[PreserveSig]
		private static extern int DLL_DuelGetDuelFinish();

		[PreserveSig]
		private static extern int DLL_DuelGetDuelFinishCardID();

		[PreserveSig]
		private static extern void DLL_DuelSetDuelLimitedType(uint limitedType);

		[PreserveSig]
		private static extern void DLL_SetEffectDelegate(ThreadRunEffectDeleg runEffct, ThreadIsBusyEffectDeleg isBusyEffect);

		[PreserveSig]
		private static extern int DLL_DuelIsThisQuickDuel();

		[PreserveSig]
		private static extern void DLL_SetCardExistWork(IntPtr pWork, int size, int count);

		[PreserveSig]
		private static extern int DLL_GetCardExistNum();

		[PreserveSig]
		private static extern int DLL_DuelGetLP(int player);

		[PreserveSig]
		private static extern int DLL_DuelWhichTurnNow();

		[PreserveSig]
		private static extern uint DLL_DuelGetCurrentPhase();

		[PreserveSig]
		private static extern uint DLL_DuelGetCurrentStep();

		[PreserveSig]
		private static extern uint DLL_DuelGetCurrentDmgStep();

		[PreserveSig]
		private static extern uint DLL_DuelGetTurnNum();

		[PreserveSig]
		private static extern IntPtr DLL_DuelGetCardPropByUniqueID(int uniqueId);

		[PreserveSig]
		private static extern int DLL_DuelGetCardUniqueID(int player, int position, int index);

		[PreserveSig]
		private static extern int DLL_DuelGetCardTurn(int player, int position, int index);

		[PreserveSig]
		private static extern int DLL_DuelGetCardFace(int player, int position, int index);

		[PreserveSig]
		private static extern int DLL_DuelGetCardNum(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetTopCardIndex(int player, int locate);

		[PreserveSig]
		private static extern bool DLL_DuelGetHandCardOpen(int player, int index);

		[PreserveSig]
		private static extern uint DLL_DuelSearchCardByUniqueID(int uniqueId);

		[PreserveSig]
		private static extern uint DLL_DuelGetCardIDByUniqueID2(int uniqueId);

		[PreserveSig]
		private static extern uint DLL_DuelCanIDoPutMonster(int player);

		[PreserveSig]
		private static extern bool DLL_DuelCanIDoSummonMonster(int player);

		[PreserveSig]
		private static extern bool DLL_DuelCanIDoSpecialSummon(int player);

		[PreserveSig]
		private static extern uint DLL_DuelGetCardInHand(int player);

		[PreserveSig]
		private static extern void DLL_DuelGetCardBasicVal(int player, int pos, int index, ref BasicVal pVal);

		[PreserveSig]
		private static extern int DLL_DuelGetTrapMonstBasicVal(int cardId, ref BasicVal pVal);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardOverlayNum(int player, int locate);

		[PreserveSig]
		private static extern int DLL_FusionGetMaterialList(int uniqueId, IntPtr list);

		[PreserveSig]
		private static extern int DLL_FusionIsThisTunedMonsterInTuning(int wUniqueID);

		[PreserveSig]
		private static extern int DLL_FusionGetMonsterLevelInTuning(int wUniqueID);

		[PreserveSig]
		private static extern int DLL_DuelIsThisCardExist(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardEffectIDAtChain(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetAttackTargetMask(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardDirectFlag(int player, int index);

		[PreserveSig]
		private static extern void DLL_DuelGetFldAffectIcon(int player, int locate, IntPtr ptr, int view_player);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardCounter(int player, int locate, int counter);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardTurnCounter(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelIsThisTunerMonster(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelIsThisNormalMonster(int player, int locate);

		[PreserveSig]
		private static extern bool DLL_DuelIsThisEffectiveMonster(int player, int index);

		[PreserveSig]
		private static extern bool DLL_DeulIsThisEffectiveMonsterWithDual(int player, int index);

		[PreserveSig]
		private static extern bool DLL_DuelIsThisNormalMonsterInGrave(int player, int index);

		[PreserveSig]
		private static extern bool DLL_DuelIsThisNormalMonsterInHand(int wCardID);

		[PreserveSig]
		private static extern int DLL_DuelIsThisTrapMonster(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardEffectFlags(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetFldMonstOrgLevel(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetFldMonstOrgType(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetFldPendScale(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetFldPendOrgScale(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetFldMonstRank(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelGetFldMonstOrgRank(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelIsThisZoneAvailable(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelIsThisZoneAvailable2(int player, int locate, bool visibleOnly);

		[PreserveSig]
		private static extern int DLL_DuelGetThisCardShowParameter(int player, int locate);

		[PreserveSig]
		private static extern uint DLL_DuelGetThisCardParameter(int player, int locate);

		[PreserveSig]
		private static extern uint DLL_DuelGetThisCardEffectList(int player, int locate, IntPtr list);

		[PreserveSig]
		private static extern uint DLL_DUELCOMGetPosMaskOfThisHand(int player, int index, int commandId);

		[PreserveSig]
		private static extern int DLL_DuelIsThisContinuousCard(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DuelIsThisEquipCard(int player, int locate);

		[PreserveSig]
		private static extern bool DLL_DuelIsThisMagic(int player, int locate);

		[PreserveSig]
		private static extern bool DLL_DuelIsThisTrap(int player, int locate);

		[PreserveSig]
		private static extern bool DLL_DuelGetThisMonsterFightableOnEffect(int player, int locate);

		[PreserveSig]
		private static extern int DLL_DUELCOMGetRecommendSide();

		[PreserveSig]
		private static extern bool DLL_DuelGetDuelFlagDeckReverse();

		[PreserveSig]
		private static extern uint DLL_DuelComGetCommandMask(int player, int position, int index);

		[PreserveSig]
		private static extern uint DLL_DuelComGetTextIDOfThisCommand(int player, int position, int index);

		[PreserveSig]
		private static extern void DLL_DuelComDoCommand(int player, int position, int index, int commandId);

		[PreserveSig]
		private static extern int DLL_DuelComCancelCommand2(bool decide);

		[PreserveSig]
		private static extern void DLL_DuelComDefaultLocation();

		[PreserveSig]
		private static extern uint DLL_DuelComGetMovablePhase();

		[PreserveSig]
		private static extern void DLL_DuelComMovePhase(int phase);

		[PreserveSig]
		private static extern void DLL_DuelComDebugCommand();

		[PreserveSig]
		private static extern uint DLL_CardRareGetBufferSize();

		[PreserveSig]
		private static extern void DLL_CardRareSetRare(IntPtr pBuf, IntPtr rare0, IntPtr rare1, IntPtr rare2, IntPtr rare3);

		[PreserveSig]
		private static extern int DLL_CardRareGetRareByUniqueID(int uniqueId);

		[PreserveSig]
		private static extern void DLL_CardRareSetBuffer(IntPtr pBuf);

		[PreserveSig]
		private static extern int DLL_DuelResultGetMemo(int player, IntPtr dst);

		[PreserveSig]
		private static extern int DLL_DuelResultGetData(int player, IntPtr dst);

		[PreserveSig]
		private static extern void DLL_SetAddRecordDelegate(AddRecord addRecord);

		[PreserveSig]
		private static extern void DLL_SetPlayRecordDelegate(NowRecord nowRecord, RecordNext recordNext, RecordBegin recordBegin, IsRecordEnd isRecordEnd);

		[PreserveSig]
		private static extern int DLL_DuelIsReplayMode();

		[PreserveSig]
		private static extern void DLL_SetDuelChallenge(int flagbit);

		[PreserveSig]
		private static extern void DLL_SetDuelChallenge2(int player, int flagbit);

		public static int Revision()
		{
			return 0;
		}

		public static int BinHash(int iIndex)
		{
			return 0;
		}

		public static int SetWorkMemory(IntPtr pWork)
		{
			return 0;
		}

		public static int GetCardOwnerByUniqueID(int uniqueId)
		{
			return 0;
		}

		public static bool SysInitQuestion(byte[] data)
		{
			return false;
		}

		public static bool SysInitCustom(int fDuelType = 0, bool tag = false, int life0 = -1, int life1 = -1, int hand0 = -1, int hand1 = -1, bool shuf = false)
		{
			return false;
		}

		private void recvData()
		{
		}

		private void recvDataImpl(PvP.Event ev)
		{
		}

		public static void SetPreRecvData(PvP.Event ev)
		{
		}

		public static bool SysAct()
		{
			return false;
		}

		public static void PvpForceFinish()
		{
		}

		public static bool IsSysActLoopExecute()
		{
			return false;
		}

		public static void ClearWork()
		{
		}

		public static void SysSetDeck(int player, int[] mainDeck, int[] extraDeck, int[] sideDeck)
		{
		}

		public static void SetRandomSeed(uint seed)
		{
		}

		public static void SetMyPlayerNum(int player)
		{
		}

		public static void SetPlayerType(int player, PlayerType type)
		{
		}

		public static bool IsHuman(int player)
		{
			return false;
		}

		public static int Myself()
		{
			return 0;
		}

		public static int Rival()
		{
			return 0;
		}

		public static bool IsMyself(int player)
		{
			return false;
		}

		public static bool IsRival(int player)
		{
			return false;
		}

		public static int OtherSide(int player)
		{
			return 0;
		}

		public static void InitCpuParam(int player, uint param)
		{
		}

		public static void SetCpuParam(int player, uint param)
		{
		}

		public static void SetFirstPlayer(int player)
		{
		}

		public static ResultType GetDuelResult()
		{
			return default(ResultType);
		}

		public static FinishType GetDuelFinish()
		{
			return default(FinishType);
		}

		public static int GetDuelFinishCardID()
		{
			return 0;
		}

		public static void SetDuelLimitedType(LimitedType limited)
		{
		}

		public static void SetEffectDelegate(RunEffect runEffect, IsBusyEffect isBusyEffect)
		{
		}

		public static void SetCardExistWork(int size)
		{
		}

		public static void ResumeCardExistWork(byte[] data, int count)
		{
		}

		public static int GetCardExistNum()
		{
			return 0;
		}

		public static bool CpuSysCheckFinishAttack()
		{
			return false;
		}

		public static int GetLP(int player)
		{
			return 0;
		}

		public static int WhichTurnNow()
		{
			return 0;
		}

		public static Phase GetCurrentPhase()
		{
			return default(Phase);
		}

		public static StepType GetCurrentStep()
		{
			return default(StepType);
		}

		public static DmgStepType GetCurrentDmgStep()
		{
			return default(DmgStepType);
		}

		public static int GetTurnNum()
		{
			return 0;
		}

		public static int GetDuelCanIDoPutMonster(int player)
		{
			return 0;
		}

		public static bool GetDuelCanIDoSummonMonster(int player)
		{
			return false;
		}

		public static bool GetDuelCanIDoSpecialSummon(int player)
		{
			return false;
		}

		public static CardProp GetCardPropByUniqueID(int uniqueId)
		{
			return default(CardProp);
		}

		public static int GetCardID(int player, int position, int index)
		{
			return 0;
		}

		public static int GetCardUniqueID(int player, int position, int index)
		{
			return 0;
		}

		public static bool GetCardTurn(int player, int position, int index)
		{
			return false;
		}

		public static bool GetCardFace(int player, int position, int index)
		{
			return false;
		}

		public static int GetCardNum(int player, int locate)
		{
			return 0;
		}

		public static int GetTopCardIndex(int player, int locate)
		{
			return 0;
		}

		public static int SearchCardByUniqueID(int uniqueId)
		{
			return 0;
		}

		public static (int, int, int) GetParamsByUniqueId(int uniqueid)
		{
			return default((int, int, int));
		}

		public static BasicVal GetBasicValByUniqueId(int uniqueid)
		{
			return default(BasicVal);
		}

		public static int GetCardIDByUniqueID(int uniqueId)
		{
			return 0;
		}

		public static uint GetCardInHand(int player)
		{
			return 0u;
		}

		public static void GetCardBasicVal(int player, int position, int index, ref BasicVal val)
		{
		}

		public static bool GetTrapMonsterBasicVal(int cardId, ref BasicVal val)
		{
			return false;
		}

		public static int GetThisCardOverlayNum(int player, int locate)
		{
			return 0;
		}

		public static int[] GetFusionMaterialList(int uniqueId)
		{
			return null;
		}

		public static bool FusionIsThisTunedMonsterInTuning()
		{
			return false;
		}

		public static int FusionGetMonsterLevelInTuning()
		{
			return 0;
		}

		public static bool IsThisCardExist(int player, int locate)
		{
			return false;
		}

		public static int GetThisCardEffectIDAtChain(int player, int locate)
		{
			return 0;
		}

		public static int GetAttackTargetMask(int player, int locate)
		{
			return 0;
		}

		public static AffectType[][] GetFieldAffectIcon(int player, int locate)
		{
			return null;
		}

		public static CardStatus SearchCardStatusByUniqueID(int uniqueId)
		{
			return default(CardStatus);
		}

		public static int GetThisCardCounter(int player, int locate, CounterType counter)
		{
			return 0;
		}

		public static int GetThisCardTurnCounter(int player, int locate)
		{
			return 0;
		}

		public static bool IsThisTunerMonster(int player, int locate)
		{
			return false;
		}

		public static bool IsThisNormalMonster(int player, int locate)
		{
			return false;
		}

		public static bool IsThisTrapMonster(int player, int locate)
		{
			return false;
		}

		public static int IsThisContinuousCard(int player, int locate)
		{
			return 0;
		}

		public static int IsThisEquipCard(int player, int locate)
		{
			return 0;
		}

		public static bool IsThisMagic(int player, int locate)
		{
			return false;
		}

		public static bool IsThisTrap(int player, int locate)
		{
			return false;
		}

		public static bool GetThisMonsterFightableOnEffect(int player, int locate)
		{
			return false;
		}

		public static int GetThisCardEffectFlags(int player, int locate)
		{
			return 0;
		}

		public static int GetFldMonstOrgLevel(int player, int locate)
		{
			return 0;
		}

		public static int GetFldMonstOrgType(int player, int locate)
		{
			return 0;
		}

		public static int GetFldPendScale(int player, int locate)
		{
			return 0;
		}

		public static int GetFldPendOrgScale(int player, int locate)
		{
			return 0;
		}

		public static int GetFldMonstRank(int player, int locate)
		{
			return 0;
		}

		public static int GetFldMonstOrgRank(int player, int locate)
		{
			return 0;
		}

		public static bool IsThisZoneAvailable(int player, int locate, bool visibleOnly = false)
		{
			return false;
		}

		public static ShowParam GetThisCardShowParameter(int player, int locate)
		{
			return default(ShowParam);
		}

		public static uint GetThisCardParameter(int player, int locate)
		{
			return 0u;
		}

		public static int GetThisCardDirectFlag(int player, int locate)
		{
			return 0;
		}

		public static int[] GetThisCardEffectList(int player, int locate)
		{
			return null;
		}

		public static uint GetPosMaskOfThisHand(int player, int index, CommandType commandId)
		{
			return 0u;
		}

		public static uint ComGetCommandMask(int player, int position, int index)
		{
			return 0u;
		}

		public static uint ComGetTextIDOfThisCommand(int player, int position, int index)
		{
			return 0u;
		}

		public static uint ComGetCommandMaskEach(int player, int position, int index)
		{
			return 0u;
		}

		public static void ComDoCommand(int player, int position, int index, CommandType commandId)
		{
		}

		public static void ComCancelCommand(bool decide = true)
		{
		}

		public static uint ComGetMovablePhase()
		{
			return 0u;
		}

		public static void ComMovePhase(Phase phase)
		{
		}

		public static int GetRecommendSide()
		{
			return 0;
		}

		public static bool GetFlagDeckReverse()
		{
			return false;
		}

		public static void ComDebugCommand()
		{
		}

		public static int CardRareBufferSize()
		{
			return 0;
		}

		public static void SetCardRare(int[] rare0, int[] rare1, int[] rare2 = null, int[] rare3 = null)
		{
		}

		public static int GetCardRareByUniqueID(int uniqueId)
		{
			return 0;
		}

		public static void SetAddRecordDelegate(AddRecord addRecord)
		{
		}

		public static void SetPlayRecordDelegate(NowRecord nowRecord, RecordNext recordNext, RecordBegin recordBegin, IsRecordEnd isRecordEnd)
		{
		}

		public static bool IsReplayMode()
		{
			return false;
		}

		public static uint GetPvpDuelInfoTimeLeft()
		{
			return 0u;
		}

		public static uint GetPvpDuelInfoTimeTotal()
		{
			return 0u;
		}

		public static void SetDuelChallenge(int flagbit)
		{
		}

		public static void SetDuelChallenge2(int player, int flagbit)
		{
		}

		public static CounterType GetCounterType(int id)
		{
			return default(CounterType);
		}

		public static int GetCounterId(CounterType type)
		{
			return 0;
		}

		public static bool TransExMonsterPosition(int team, int pos, ref int oppTeam, ref int oppPos)
		{
			return false;
		}

		public static bool TransExMonsterPositionUnAvailable(ref int team, ref int pos)
		{
			return false;
		}

		private static void ForceSimpleCpu(int player, CpuParam param = CpuParam.Simple)
		{
		}

		private static void RestoreCpuParam(int player)
		{
		}

		public static int CachedMatId_Get(int player)
		{
			return 0;
		}

		public static void CachedMatId_Set(int player, int mid)
		{
		}

		public static int CachedSleeveId_Get(int player)
		{
			return 0;
		}

		public static void CachedSleeveId_Set(int player, int sid)
		{
		}

		public static int GetInitialLP(int player)
		{
			return 0;
		}

		public static void SetInitialLP(int player, int val)
		{
		}

		public static void Create(Util.GameMode gamemode, bool isOnline = false)
		{
		}

		public static void Destroy()
		{
		}

		private void Release()
		{
		}

		private void InitCounterDictionary(Dictionary<string, object> dic)
		{
		}

		private void CreateCardRareBuffer()
		{
		}

		private void ReleaseCardRareBuffer()
		{
		}

		public static byte[] GetRecvData(PvP.Command cmd)
		{
			return null;
		}

		public static int GetRecvCount(PvP.Command cmd)
		{
			return 0;
		}

		public static uint GetRecvOrder(PvP.Command cmd)
		{
			return 0u;
		}

		public static void ClearRecvQueue(PvP.Command cmd)
		{
		}

		public static void CreateCardExistBuffer(int size)
		{
		}

		public static byte[] GetCardExistBuffer()
		{
			return null;
		}

		private void ReleaseCardExistBuffer()
		{
		}

		public static void SetStartInputCallback(Action callback)
		{
		}

		public static void SetUpdateTimerCallback(Action callback)
		{
		}

		public static void StartInput()
		{
		}

		public static void EndInput()
		{
		}

		public static void SendPvpTime()
		{
		}

		public static void SetNoResponseCallback(Action noResponse, Action recovery, Action closed)
		{
		}

		public static void NoResponse()
		{
		}

		public static void RecoveryResponse()
		{
		}

		public static void NoResponseClosed()
		{
		}

		private void CreateQuestionData(byte[] data)
		{
		}

		private void ReleaseQuestionData()
		{
		}

		public static uint MakeCpuParam(int val, CpuParam param = CpuParam.None)
		{
			return 0u;
		}

		private void SetEngineWork()
		{
		}

		public static void SetLatency(byte[] recvData)
		{
		}

		public static int GetLatency(int player)
		{
			return 0;
		}

		public static void SendSurrender(bool autoSurrender = false)
		{
		}

		[PreserveSig]
		private static extern int DLL_DuelListIsMultiMode();

		[PreserveSig]
		private static extern void DLL_DuelListInitString();

		[PreserveSig]
		private static extern int DLL_DuelListGetSelectMax();

		[PreserveSig]
		private static extern int DLL_DuelListGetSelectMin();

		[PreserveSig]
		private static extern int DLL_DuelListGetItemMax();

		[PreserveSig]
		private static extern int DLL_DuelListGetItemID(int index);

		[PreserveSig]
		private static extern int DLL_DuelListGetItemUniqueID(int index);

		[PreserveSig]
		private static extern int DLL_DuelListGetItemFrom(int index);

		[PreserveSig]
		private static extern int DLL_DuelListGetItemMsg(int index);

		[PreserveSig]
		private static extern int DLL_DuelListGetItemAttribute(int index);

		[PreserveSig]
		private static extern int DLL_DuelListGetCardAttribute(int iLookPlayer, int wUniqueID);

		[PreserveSig]
		private static extern void DLL_DuelListSetIndex(int index);

		[PreserveSig]
		private static extern void DLL_DuelListSetCardExData(int index, int data);

		[PreserveSig]
		private static extern int DLL_DuelListGetItemTargetUniqueID(int index);

		public static bool ListIsMultiMode()
		{
			return false;
		}

		public static int ListGetSelectMax()
		{
			return 0;
		}

		public static int ListGetSelectMin()
		{
			return 0;
		}

		public static int ListGetItemMax()
		{
			return 0;
		}

		public static int ListGetItemID(int index)
		{
			return 0;
		}

		public static int ListGetItemTargetUniqueID(int index)
		{
			return 0;
		}

		public static int ListGetItemUniqueID(int index)
		{
			return 0;
		}

		public static int ListGetItemFrom(int index)
		{
			return 0;
		}

		public static int ListGetItemMsg(int listIdx)
		{
			return 0;
		}

		public static int ListGetItemMixNum(int listIdx)
		{
			return 0;
		}

		public static DialogMixTextType ListGetItemMixType(int listIdx, int mixIdx)
		{
			return default(DialogMixTextType);
		}

		public static int ListGetItemMixData(int listIdx, int mixIdx)
		{
			return 0;
		}

		public static int ListGetItemAttribute(int index)
		{
			return 0;
		}

		public static void ListSendBlindIndex(int index)
		{
		}

		public static void ListSendIndex(int index)
		{
		}

		public static int ListGetCardAttribute(int lookPlayer, int uniqueId)
		{
			return 0;
		}

		public static void ListSendSelectMulti(int num, List<int> selected)
		{
		}

		private static int _PosToIdx(int player, int position, int index)
		{
			return 0;
		}

		private static int _PosToUniqueId(int player, int position, int index)
		{
			return 0;
		}

		private static PvpUIDBase _PosToUIDBase(int player, int position, int index)
		{
			return null;
		}

		private static PvpUIDBase _UniqueIdToUIDBase(int uniqueId)
		{
			return null;
		}

		private static int PVP_DuelGetLP(int player)
		{
			return 0;
		}

		private static int PVP_DuelCanIDoPutMonster(int player)
		{
			return 0;
		}

		private static bool PVP_DuelCanIDoSummonMonster(int player)
		{
			return false;
		}

		private static bool PVP_DuelCanIDoSpecialSummon(int player)
		{
			return false;
		}

		private static int PVP_DuelWhichTurnNow()
		{
			return 0;
		}

		private static Phase PVP_DuelGetCurrentPhase()
		{
			return default(Phase);
		}

		private static StepType PVP_DuelGetCurrentStep()
		{
			return default(StepType);
		}

		private static DmgStepType PVP_DuelGetCurrentDmgStep()
		{
			return default(DmgStepType);
		}

		private static int PVP_DuelGetTurnNum()
		{
			return 0;
		}

		private static CardProp PVP_GetCardPropByUniqueID(int uniqueId)
		{
			return default(CardProp);
		}

		private static int PVP_DuelGetCardID(int player, int position, int index)
		{
			return 0;
		}

		private static int PVP_DuelGetCardUniqueID(int player, int position, int index)
		{
			return 0;
		}

		private static bool PVP_DuelGetCardTurn(int player, int position, int index)
		{
			return false;
		}

		private static bool PVP_DuelGetCardFace(int player, int position, int index)
		{
			return false;
		}

		private static int PVP_DuelGetCardNum(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetThisMonsterFightableOnEffect(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelIsThisEquipCard(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelIsThisContinuousCard(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelIsThisMagic(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelIsThisTrap(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetTopCardIndex(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelSearchCardByUniqueID(int uniqueId)
		{
			return 0;
		}

		private static uint PVP_DuelGetCardIDByUniqueID(int uniqueId)
		{
			return 0u;
		}

		private static void PVP_DuelGetCardBasicVal(int player, int position, int index, ref BasicVal val)
		{
		}

		private static bool PVP_DuelIsThisCardExist(int player, int locate)
		{
			return false;
		}

		private static int PVP_DuelGetThisCardEffectIDAtChain(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetAttackTargetMask(int player, int locate)
		{
			return 0;
		}

		private static AffectType[][] PVP_GetFieldAffectIcon(int player, int locate)
		{
			return null;
		}

		private static int PVP_DuelGetThisCardCounter(int player, int locate, CounterType type)
		{
			return 0;
		}

		private static int[] PVP_GetThisCardEffectList(int player, int locate)
		{
			return null;
		}

		private static uint PVP_DUELCOMGetPosMaskOfThisHand(int player, int index, int commandId)
		{
			return 0u;
		}

		private static int PVP_DuelGetThisCardTurnCounter(int player, int locate)
		{
			return 0;
		}

		private static bool PVP_DuelIsThisNormalMonster(int player, int locate)
		{
			return false;
		}

		private static bool PVP_DuelIsThisTrapMonster(int player, int locate)
		{
			return false;
		}

		private static bool PVP_DuelIsThisTunerMonster(int player, int locate)
		{
			return false;
		}

		private static int PVP_DuelGetThisCardEffectFlags(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetFldMonstOrgLevel(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetFldMonstOrgType(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetFldPendScale(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetFldPendOrgScale(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetFldMonstRank(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetFldMonstOrgRank(int player, int locate)
		{
			return 0;
		}

		private static int PVP_DuelGetThisCardOverlayNum(int player, int locate)
		{
			return 0;
		}

		private static bool PVP_DuelIsThisZoneAvailable(int player, int locate)
		{
			return false;
		}

		private static bool PVP_DuelIsThisZoneAvailable2(int player, int locate, bool visibleOnly)
		{
			return false;
		}

		private static ShowParam PVP_DuelGetThisCardShowParameter(int player, int locate)
		{
			return default(ShowParam);
		}

		private static uint PVP_DuelGetThisCardParameter(int player, int locate)
		{
			return 0u;
		}

		private static int PVP_DuelGetThisCardDirectFlag(int player, int locate)
		{
			return 0;
		}

		private static uint PVP_DuelComGetCommandMask(int player, int position, int index)
		{
			return 0u;
		}

		private static uint PVP_DuelComGettextIDOfThisCommand(int player, int position, int index)
		{
			return 0u;
		}

		private static void PVP_ComDoCommand(int player, int position, int index, CommandType commandId)
		{
		}

		private static uint PVP_DuelComGetMovablePhase()
		{
			return 0u;
		}

		private static int PVP_CardRareGetRareByUniqueID(int uniqueId)
		{
			return 0;
		}

		private static void PVP_DequeDlgMixData()
		{
		}

		private static int PVP_DuelDlgGetMixNum()
		{
			return 0;
		}

		private static DialogMixTextType PVP_DuelDlgGetMixType(int index)
		{
			return default(DialogMixTextType);
		}

		private static int PVP_DuelDlgGetMixData(int index)
		{
			return 0;
		}

		private static int PVP_DuelListGetItemMsg(int listIdx)
		{
			return 0;
		}

		private static int PVP_DuelListGetItemMixNum(int listIdx)
		{
			return 0;
		}

		private static DialogMixTextType PVP_DuelListGetItemMixType(int listIdx, int mixIdx)
		{
			return default(DialogMixTextType);
		}

		private static int PVP_DuelListGetItemMixData(int listIdx, int mixIdx)
		{
			return 0;
		}

		private static bool PVP_DuelDlgCanYesNoSkip()
		{
			return false;
		}

		private static uint PVP_DuelDlgGetPosMaskOfThisSummon()
		{
			return 0u;
		}

		private static int PVP_DuelDlgGetSelectItemNum()
		{
			return 0;
		}

		private static int PVP_DuelDlgGetSelectItemStr(int index)
		{
			return 0;
		}

		private static bool PVP_DuelDlgGetSelectItemEnable(int index)
		{
			return false;
		}

		private static int PVP_DlgProcGetSummoningMonsterUniqueID()
		{
			return 0;
		}

		private static bool PVP_DuelListIsMultiMode()
		{
			return false;
		}

		private static int PVP_DuelListGetSelectMax()
		{
			return 0;
		}

		private static int PVP_DuelListGetSelectMin()
		{
			return 0;
		}

		private static int PVP_DuelListGetItemMax()
		{
			return 0;
		}

		private static int PVP_DuelListGetItemID(int index)
		{
			return 0;
		}

		private static int PVP_DuelListGetItemUniqueID(int index)
		{
			return 0;
		}

		private static int PVP_DuelListGetItemAttribute(int index)
		{
			return 0;
		}

		private static int PVP_DuelListGetItemFrom(int index)
		{
			return 0;
		}

		private static int PVP_DuelListGetCardAttribute(int lookPlayer, int uniqueId)
		{
			return 0;
		}

		private static int PVP_DuelListGetItemTargetUniqueID(int index)
		{
			return 0;
		}

		private static int[] PVP_FusionGetMaterialList()
		{
			return null;
		}

		private static int PVP_FusionIsThisTunedMonsterInTuning()
		{
			return 0;
		}

		private static int PVP_FusionGetMonsterLevelInTuning()
		{
			return 0;
		}

		private static int PVP_DuelComGetCommandMask()
		{
			return 0;
		}

		private static bool PVP_DuelGetDuelFlagDeckReverse()
		{
			return false;
		}

		public static bool PVP_IsSysActLoopExecute()
		{
			return false;
		}

		private static uint PVP_DuelInfoTimeLeft()
		{
			return 0u;
		}

		private static uint PVP_DuelInfoTimeTotal()
		{
			return 0u;
		}

		public static bool PvpAct(bool init = false)
		{
			return false;
		}

		private static ViewType getBusyCheckType(ViewType id)
		{
			return default(ViewType);
		}

		private static bool checkFlag(BinaryReader br, List<byte> updateFlag, ref int count)
		{
			return false;
		}

		private static bool checkFlag(List<byte> flags, ref int count)
		{
			return false;
		}

		private static void PvpUpdateEngineData(PvpFieldType type, byte[] data, int n, int player)
		{
		}

		private static PvpDialogData PvpParseDialogData(BinaryReader br)
		{
			return null;
		}

		private static PvpListData PvpParseListData(BinaryReader br)
		{
			return null;
		}

		private static PvpFusionData PvpParseFusionData(BinaryReader br)
		{
			return null;
		}

		public static void PvpParseRecvData(byte[] recvData)
		{
		}

		private void PvpInit()
		{
		}

		private void PvpRelease()
		{
		}

		public static bool PvpIsQueued()
		{
			return false;
		}

		public static bool PvpInputGuard()
		{
			return false;
		}

		private static CardProp THREAD_ToCardPropNoSerial(CardPropSerial serialCard)
		{
			return default(CardProp);
		}

		private static BasicVal THREAD_ToBasicValNoSerial(BasicValSerial serialVal)
		{
			return default(BasicVal);
		}

		private static int THREAD_PosToIdx(int player, int position, int index)
		{
			return 0;
		}

		private static int THREAD_PosToUniqueId(int player, int position, int index)
		{
			return 0;
		}

		private static ThreadUIDBase THREAD_PosToUIDBase(int player, int position, int index)
		{
			return null;
		}

		private static ThreadUIDBase THREAD_UniqueIdToUIDBase(int uniqueId)
		{
			return null;
		}

		private static int THREAD_DuelWhichTurnNow()
		{
			return 0;
		}

		private static Phase THREAD_DuelGetCurrentPhase()
		{
			return default(Phase);
		}

		private static StepType THREAD_DuelGetCurrentStep()
		{
			return default(StepType);
		}

		private static DmgStepType THREAD_DuelGetCurrentDmgStep()
		{
			return default(DmgStepType);
		}

		private static int THREAD_DuelGetTurnNum()
		{
			return 0;
		}

		private static int THREAD_DuelGetLP(int player)
		{
			return 0;
		}

		private static int THREAD_DuelCanIDoPutMonster(int player)
		{
			return 0;
		}

		private static bool THREAD_DuelCanIDoSummonMonster(int player)
		{
			return false;
		}

		private static bool THREAD_DuelCanIDoSpecialSummon(int player)
		{
			return false;
		}

		private static CardProp THREAD_GetCardPropByUniqueID(int uniqueId)
		{
			return default(CardProp);
		}

		private static int THREAD_DuelGetCardID(int player, int position, int index)
		{
			return 0;
		}

		private static int THREAD_DuelGetCardUniqueID(int player, int position, int index)
		{
			return 0;
		}

		private static bool THREAD_DuelGetCardTurn(int player, int position, int index)
		{
			return false;
		}

		private static bool THREAD_DuelGetCardFace(int player, int position, int index)
		{
			return false;
		}

		private static int THREAD_DuelGetCardNum(int player, int locate)
		{
			return 0;
		}

		private static bool THREAD_DuelGetThisMonsterFightableOnEffect(int player, int locate)
		{
			return false;
		}

		private static int THREAD_DuelIsThisEquipCard(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelIsThisContinuousCard(int player, int locate)
		{
			return 0;
		}

		private static bool THREAD_DuelIsThisMagic(int player, int locate)
		{
			return false;
		}

		private static bool THREAD_DuelIsThisTrap(int player, int locate)
		{
			return false;
		}

		private static int THREAD_DuelGetTopCardIndex(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelSearchCardByUniqueID(int uniqueId)
		{
			return 0;
		}

		private static uint THREAD_DuelGetCardIDByUniqueID(int uniqueId)
		{
			return 0u;
		}

		private static void THREAD_DuelGetCardBasicVal(int player, int position, int index, ref BasicVal val)
		{
		}

		private static bool THREAD_DuelIsThisCardExist(int player, int locate)
		{
			return false;
		}

		private static int THREAD_DuelGetThisCardEffectIDAtChain(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetAttackTargetMask(int player, int locate)
		{
			return 0;
		}

		private static AffectType[][] THREAD_GetFieldAffectIcon(int player, int position)
		{
			return null;
		}

		private static void THREAD_SetFieldAffectIcon()
		{
		}

		private static int THREAD_DuelGetThisCardCounter(int player, int locate, CounterType type)
		{
			return 0;
		}

		private static int[] THREAD_GetThisCardEffectList(int player, int locate)
		{
			return null;
		}

		private static uint THREAD_DUELCOMGetPosMaskOfThisHand(int player, int index, int commandId)
		{
			return 0u;
		}

		private static int THREAD_DuelGetThisCardTurnCounter(int player, int locate)
		{
			return 0;
		}

		private static bool THREAD_DuelIsThisNormalMonster(int player, int locate)
		{
			return false;
		}

		private static bool THREAD_DuelIsThisTrapMonster(int player, int locate)
		{
			return false;
		}

		private static bool THREAD_DuelIsThisTunerMonster(int player, int locate)
		{
			return false;
		}

		private static int THREAD_DuelGetThisCardEffectFlags(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetFldMonstOrgLevel(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetFldMonstOrgType(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetFldPendScale(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetFldPendOrgScale(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetFldMonstRank(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetFldMonstOrgRank(int player, int locate)
		{
			return 0;
		}

		private static int THREAD_DuelGetThisCardOverlayNum(int player, int locate)
		{
			return 0;
		}

		private static bool THREAD_DuelIsThisZoneAvailable(int player, int locate, bool visibleOnly = false)
		{
			return false;
		}

		private static ShowParam THREAD_DuelGetThisCardShowParameter(int player, int locate)
		{
			return default(ShowParam);
		}

		private static uint THREAD_DuelGetThisCardParameter(int player, int locate)
		{
			return 0u;
		}

		private static int THREAD_DuelGetThisCardDirectFlag(int player, int locate)
		{
			return 0;
		}

		private static uint THREAD_DuelComGetCommandMask(int player, int position, int index)
		{
			return 0u;
		}

		private static uint THREAD_DuelComGetTextIDOfThisCommand(int player, int position, int index)
		{
			return 0u;
		}

		private static void THREAD_ComDoCommand(int player, int position, int index, int commandId)
		{
		}

		private static bool THREAD_ComCancelCommand(bool decide)
		{
			return false;
		}

		private static void THREAD_ComMovePhase(int phase)
		{
		}

		private static void THREAD_DuelComDebugCommand()
		{
		}

		private static void THREAD_DuelComDoDebugCommand(int player, int position, int index, int commandId)
		{
		}

		private static void THREAD_DuelComCheatCard(int player, int position, int index, int cardId, int face, int turn)
		{
		}

		private static uint THREAD_DuelComGetMovablePhase()
		{
			return 0u;
		}

		private static void THREAD_DuelDlgSetResult(uint result)
		{
		}

		private static int THREAD_DuelDlgGetMixNum()
		{
			return 0;
		}

		private static DialogMixTextType THREAD_DuelDlgGetMixType(int index)
		{
			return default(DialogMixTextType);
		}

		private static int THREAD_DuelDlgGetMixData(int index)
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemMsg(int listIdx)
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemMixNum(int listIdx)
		{
			return 0;
		}

		private static DialogMixTextType THREAD_DuelListGetItemMixType(int listIdx, int mixIdx)
		{
			return default(DialogMixTextType);
		}

		private static int THREAD_DuelListGetItemMixData(int listIdx, int mixIdx)
		{
			return 0;
		}

		private static int THREAD_DuelComGetRecommendSide()
		{
			return 0;
		}

		private static bool THREAD_DuelGetDuelFlagDeckReverse()
		{
			return false;
		}

		private static bool THREAD_DuelDlgCanYesNoSkip()
		{
			return false;
		}

		private static uint THREAD_DuelDlgGetPosMaskOfThisSummon()
		{
			return 0u;
		}

		private static int THREAD_DuelDlgGetSelectItemNum()
		{
			return 0;
		}

		private static int THREAD_DuelDlgGetSelectItemStr(int index)
		{
			return 0;
		}

		private static bool THREAD_DuelDlgGetSelectItemEnable(int index)
		{
			return false;
		}

		private static int THREAD_DlgProcGetSummoningMonsterUniqueID()
		{
			return 0;
		}

		private static bool THREAD_DuelListIsMultiMode()
		{
			return false;
		}

		private static int THREAD_DuelListGetSelectMax()
		{
			return 0;
		}

		private static int THREAD_DuelListGetSelectMin()
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemMax()
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemUniqueID(int index)
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemAttribute(int index)
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemFrom(int index)
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemID(int index)
		{
			return 0;
		}

		private static int THREAD_DuelListGetItemTargetUniqueID(int index)
		{
			return 0;
		}

		private static int THREAD_DuelListGetCardAttribute(int lookPlayer, int uniqueId)
		{
			return 0;
		}

		private static void THREAD_ListSendBlindIndex(int index)
		{
		}

		private static void THREAD_ListSendIndex(int index)
		{
		}

		private static void THREAD_ListSendSelectMulti(int num, List<int> selected)
		{
		}

		private static int[] THREAD_FusionGetMaterialList()
		{
			return null;
		}

		private static int THREAD_FusionIsThisTunedMonsterInTuning()
		{
			return 0;
		}

		private static int THREAD_FusionGetMonsterLevelInTuning()
		{
			return 0;
		}

		private static bool THREAD_DuelCpuSysCheckFinishAttack()
		{
			return false;
		}

		public static bool THREAD_IsSysActLoopExecute()
		{
			return false;
		}

		public static bool ThreadAct(bool init = false)
		{
			return false;
		}

		private static void ThreadActRunEffect(ToMainRunEffect runeffectData)
		{
		}

		private static ViewType THREAD_getBusyCheckType(ViewType id)
		{
			return default(ViewType);
		}

		private void ThreadInit()
		{
		}

		public static void ThreadStart()
		{
		}

		public static void ThreadJoin()
		{
		}

		public static void ThreadAbort()
		{
		}

		private void ThreadRelease()
		{
		}

		private static bool isThreadActive()
		{
			return false;
		}

		public static void SetCpuChangeTimeFool(float time)
		{
		}

		public static void SetCpuChangeTimeSimple(float time)
		{
		}

		private static void CpuThinkUpdate()
		{
		}

		private static void ThreadUpdate()
		{
		}

		private static void EngineCommandExecute()
		{
		}

		private static void SurrenderCPU()
		{
		}

		public static bool IsThreadRunEffectDuelEnd()
		{
			return false;
		}

		public static int ThreadRunEffect(int id, int param1, int param2, int param3)
		{
			return 0;
		}

		private int ThreadRunEffectImpl(int id, int param1, int param2, int param3)
		{
			return 0;
		}

		public static int ThreadIsBusyEffect(int id)
		{
			return 0;
		}

		private int ThreadIsBusyEffectImpl(int id)
		{
			return 0;
		}

		private ThreadMixTextData GetDlgMixVal()
		{
			return null;
		}

		private Dictionary<string, int> GetAttackFlags()
		{
			return null;
		}

		private ThreadIconBase[] GetAffectIcon()
		{
			return null;
		}

		private ThreadPosParam[][] GetCardParameter()
		{
			return null;
		}
	}
}
