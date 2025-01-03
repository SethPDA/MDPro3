using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.InteropServices;
using YgomGame.Duel;

namespace YgomGame.Card
{
	public sealed class Content
	{
		public struct Property
		{
			private ushort mrk;

			private BitVector32.Section kind;

			private BitVector32.Section attr;

			private BitVector32.Section level;

			private BitVector32.Section lvtype;

			private BitVector32.Section attack;

			private BitVector32.Section defence;

			private BitVector32.Section icon;

			private BitVector32.Section type;

			private BitVector32.Section scaleL;

			private BitVector32.Section exist;

			private BitVector32 bit1;

			private BitVector32 bit2;

			public int MRK => 0;

			public Kind Kind => default(Kind);

			public Attribute Attr => default(Attribute);

			public int Level => 0;

			public LvType LvType => default(LvType);

			public int Atk => 0;

			public int Def => 0;

			public Icon Icon => default(Icon);

			public Type Type => default(Type);

			public int ScaleL => 0;

			public bool Exist => false;

			//public Property(int param1, int param2)
			//{
			//}
		}

		public enum Rarity
		{
			None = 0,
			Normal = 1,
			Rare = 2,
			SuperRare = 3,
			UltraRare = 4
		}

		public enum Kirarity
		{
			None = 0,
			Normal = 1,
			Gold = 2,
			Kira = 3,
			Holo = 4
		}

		public enum Attribute
		{
			Null = 0,
			Light = 1,
			Dark = 2,
			Water = 3,
			Fire = 4,
			Earth = 5,
			Wind = 6,
			God = 7,
			Magic = 8,
			Trap = 9
		}

		public enum Type
		{
			Null = 0,
			Dragon = 1,
			Undead = 2,
			Devil = 3,
			Flame = 4,
			Poseidon = 5,
			Sandrock = 6,
			Machine = 7,
			Fish = 8,
			Dinosaurs = 9,
			Insect = 10,
			Beast = 11,
			BeastBtl = 12,
			Botanical = 13,
			Aquarius = 14,
			Soldier = 15,
			Bird = 16,
			Angel = 17,
			Wizard = 18,
			Thunder = 19,
			Reptiles = 20,
			Psychic = 21,
			Mystdragon = 22,
			Cyverse = 23,
			God = 24,
			Illusioner = 25,
			Creator = 26,
			Magic = 0,
			Trap = 0
		}

		public enum Icon
		{
			Null = 0,
			Counter = 1,
			Field = 2,
			Equip = 3,
			Continuous = 4,
			QuickPlay = 5,
			Ritual = 6
		}

		public enum Frame
		{
			Normal = 0,
			Effect = 1,
			Ritual = 2,
			Fusion = 3,
			Oberisk = 4,
			Osiris = 5,
			Ra = 6,
			Magic = 7,
			Trap = 8,
			Token = 9,
			Sync = 10,
			Dsync = 11,
			Xyz = 12,
			Pend = 13,
			PendFx = 14,
			XyzPend = 15,
			SyncPend = 16,
			FusionPend = 17,
			Link = 18,
			RitualPend = 19
		}

		public enum Kind
		{
			Normal = 0,
			Effect = 1,
			Fusion = 2,
			FusionFx = 3,
			Ritual = 4,
			RitualFx = 5,
			Toon = 6,
			Spirit = 7,
			Union = 8,
			Dual = 9,
			Token = 10,
			God = 11,
			Dummy = 12,
			Magic = 13,
			Trap = 14,
			Tuner = 15,
			TunerFx = 16,
			Sync = 17,
			SyncFx = 18,
			SyncTuner = 19,
			Dtuner = 20,
			Dsync = 21,
			Xyz = 22,
			XyzFx = 23,
			Flip = 24,
			Pend = 25,
			PendFx = 26,
			SpEffect = 27,
			SpToon = 28,
			SpSpirit = 29,
			SpTuner = 30,
			SpDtuner = 31,
			FlipTuner = 32,
			PendTuner = 33,
			XyzPend = 34,
			PendFlip = 35,
			SyncPend = 36,
			UnionTuner = 37,
			RitualSpirit = 38,
			FusionTuner = 39,
			SpPend = 40,
			FusionPend = 41,
			Link = 42,
			LinkFx = 43,
			PendNTuner = 44,
			PendSpirit = 45,
			Maximum = 46,
			RirualTunerFX = 47,
			FusionTunerFX = 48,
			TokenTuner = 49,
			R_Fusion = 50,
			R_FusionFX = 51,
			RitualPend = 52,
			RitualFlip = 53
		}

		public enum SubKind
		{
			Null = 0,
			NoFx = 1,
			Normal = 2,
			Effect = 3,
			Flip = 4,
			Toon = 5,
			Spirit = 6,
			Union = 7,
			Dual = 8,
			Maximum = 9
		}

		public enum LvType
		{
			Null = 0,
			Level = 1,
			Rank = 2,
			Link = 3,
			LvMax = 12,
			LvMask = 8190,
			RankMax = 13,
			RankMask = 16382,
			LinkMax = 8
		}

		public enum LinkMarker
		{
			UpLeft = 0,
			Up = 1,
			UpRight = 2,
			Left = 3,
			Right = 4,
			DownLeft = 5,
			Down = 6,
			DownRight = 7
		}

		[Flags]
		public enum LinkMarkerBit
		{
			UpLeft = 1,
			Up = 2,
			UpRight = 4,
			Left = 8,
			Right = 0x10,
			DownLeft = 0x20,
			Down = 0x40,
			DownRight = 0x80
		}

		public enum Genre
		{
			LpUp = 0,
			LpDown = 1,
			Draw = 2,
			SpSummon = 3,
			Disable = 4,
			DeckSearch = 5,
			UseGrave = 6,
			Power = 7,
			Position = 8,
			Control = 9,
			BreakMonst = 10,
			BreakMagic = 11,
			HandDes = 12,
			DeckDes = 13,
			RemoveCard = 14,
			CardBack = 15,
			Spear = 16,
			DirectAtk = 17,
			ManyAtk = 18,
			Unbreak = 19,
			LimitAtk = 20,
			CantSummon = 21,
			Reverse = 22,
			Toon = 23,
			Spirit = 24,
			Union = 25,
			Dual = 26,
			LevelUp = 27,
			Original = 28,
			Fusion = 29,
			Ritual = 30,
			Token = 31,
			Counter = 32,
			Gamble = 33,
			Attribute = 34,
			Type = 35,
			Tuner = 36,
			Sync = 37,
			DropGrave = 38,
			Normal = 39,
			AttrLight = 40,
			AttrDark = 41,
			AttrEarth = 42,
			AttrWater = 43,
			AttrFire = 44,
			AttrWind = 45,
			Xyz = 46,
			LvUpDown = 47,
			Pendulum = 48,
			Link = 49,
			HalfDamage = 50
		}

		public enum NameType
		{
			Null = 0,
			Toon = 1,
			Demon = 2,
			GraveKeeper = 3,
			Guardian = 4,
			DarkScorpion = 5,
			Amazoness = 6,
			Ninja = 7,
			Level = 8,
			EHero = 9,
			DHero = 10,
			NeosMaterial = 11,
			NeosFusion = 12,
			Neos = 13,
			Ojama = 14,
			Battery = 15,
			DarkWorld = 16,
			BES = 17,
			Antique = 18,
			Sphinx = 19,
			Machiners = 20,
			Harpie = 21,
			Roid = 22,
			Vehicloid = 23,
			NeoSpacian = 24,
			Cocoon = 25,
			Alien = 26,
			MythicalBeast = 27,
			Hero = 28,
			AllureQueen = 29,
			Gadget = 30,
			SixSamurai = 31,
			Jewel = 32,
			Volcanic = 33,
			BlazeCanon = 34,
			Venom = 35,
			Cloudian = 36,
			Gladial = 37,
			Weapon = 38,
			Takemitsu = 39,
			EvHero = 40,
			Drunk = 41,
			Arcana = 42,
			Fossil = 43,
			Gunner = 44,
			Forbidden = 45,
			Rainbow = 46,
			CyberFusion = 47,
			IceBarrier = 48,
			AOJ = 49,
			Saber = 50,
			Worm = 51,
			LightLord = 52,
			Frog = 53,
			Nitro = 54,
			Genex = 55,
			MistValley = 56,
			Flamebell = 57,
			NeosNHero = 58,
			Deformer = 59,
			Chain = 60,
			Natul = 61,
			Clear = 62,
			RedEyes = 63,
			BlackFeather = 64,
			SlashBuster = 65,
			Roaring = 66,
			Jurac = 67,
			RealGenex = 68,
			EarthBindGod = 69,
			Koakimail = 70,
			Infernity = 71,
			XSaber = 72,
			FortuneLady = 73,
			Dragnity = 74,
			FortuneWitch = 75,
			Synchron = 76,
			Saviour = 77,
			Reptiles = 78,
			Shien = 79,
			Junk = 80,
			Tomabo = 81,
			Sin = 82,
			Gem = 83,
			GemKnight = 84,
			Laval = 85,
			Vailon = 86,
			Scrap = 87,
			Eleki = 88,
			Fusion = 89,
			Infinity = 90,
			Wisel = 91,
			TG = 92,
			Karakuri = 93,
			Ritua = 94,
			Gusta = 95,
			Invelds = 96,
			Reactor = 97,
			Agent = 98,
			PoleStar = 99,
			PoleStarBeast = 100,
			PoleStarGhost = 101,
			PoleStarAngel = 102,
			PoleStarItem = 103,
			PoleGod = 104,
			SoundWarrior = 105,
			Resonator = 106,
			MHero = 107,
			VHero = 108,
			MeklordEmperor = 109,
			MeklordSoldier = 110,
			Meklord = 111,
			Zenmai = 112,
			Penguin = 113,
			Evold = 114,
			Evolder = 115,
			TrapHole = 116,
			TimeGod = 117,
			Sacred = 118,
			Velds = 119,
			Numbers = 120,
			Gagaga = 121,
			Gogogo = 122,
			Photon = 123,
			Ninjutsu = 124,
			Inzector = 125,
			Invasion = 126,
			Bouncer = 127,
			Butterfly = 128,
			HolySeal = 129,
			Majin = 130,
			Heroic = 131,
			Ooparts = 132,
			SpellBook = 133,
			MaDolce = 134,
			GearGear = 135,
			Xyz = 136,
			Poseidon = 137,
			Mermail = 138,
			Abyss = 139,
			Magical = 140,
			Nimble = 141,
			Duston = 142,
			Medallion = 143,
			NobleKnight = 144,
			FireKing = 145,
			Galaxy = 146,
			HolySword = 147,
			FireStar = 148,
			FireDance = 149,
			HazeBeast = 150,
			Haze = 151,
			ZexalWeapon = 152,
			Hope = 153,
			GimmickPuppet = 154,
			Dododo = 155,
			BK = 156,
			PhantomMek = 157,
			FireKingBeast = 158,
			ChaosNumbers = 159,
			ChaosXyz = 160,
			GearGearno = 161,
			SDRobo = 162,
			SDRobo2 = 163,
			Umbral = 164,
			HolyLightning = 165,
			Bujin = 166,
			Kowakuma = 167,
			Hole = 168,
			CNo39 = 169,
			HChallenger = 170,
			MaliceBolus = 171,
			Ghostrick = 172,
			Vampire = 173,
			Cat = 174,
			CyberDragon = 175,
			Cybernetic = 176,
			Shinra = 177,
			Necrovalley = 178,
			Zubaba = 179,
			Fishborg = 180,
			RUM = 181,
			Medallion2 = 182,
			Artifact = 183,
			EvolKaiser = 184,
			GalaxyEyes = 185,
			Tachyon = 186,
			Over100 = 187,
			Wizard = 188,
			OddEyes = 189,
			LegendDragon = 190,
			LegendKnight = 191,
			WingedKuriboh = 192,
			Stardust = 193,
			Sprout = 194,
			Artorius = 195,
			Lancelot = 196,
			SuperHeavy = 197,
			Genso = 198,
			TellarKnight = 199,
			Shadoll = 200,
			DragonStar = 201,
			EM = 202,
			Change = 203,
			Higan = 204,
			UA = 205,
			DD = 206,
			DDD = 207,
			Furnimal = 208,
			DeathToy = 209,
			Qliphot = 210,
			Bunborg = 211,
			Goblin = 212,
			Cthulhu = 213,
			Contract = 214,
			Gottoms = 215,
			Yosen = 216,
			Necroth = 217,
			SpiritAll = 218,
			SpiritTamer = 219,
			SpiritBeast = 220,
			RR = 221,
			Infernoid = 222,
			Jinzo = 223,
			Gaia = 224,
			Monarch = 225,
			Charmer = 226,
			Possessed = 227,
			Crystal = 228,
			Warrior = 229,
			PowerTool = 230,
			BMG = 231,
			EdgeImp = 232,
			Sephira = 233,
			GensoPrincess = 234,
			SpiritRider = 235,
			StellarKnight = 236,
			Void = 237,
			Em = 238,
			DragonSword = 239,
			IgKnight = 240,
			Aroma = 241,
			Empowered = 242,
			AetherWeapon = 243,
			FortunePrincess = 244,
			AquaActress = 245,
			Aquarium = 246,
			ChaosSoldier = 247,
			Majespecter = 248,
			Gradle = 249,
			Kozmo = 250,
			Kaiju = 251,
			SR = 252,
			PsyFrame = 253,
			RedDemon = 254,
			Burgestoma = 255,
			Dante = 256,
			BusterBlader = 257,
			BusterSword = 258,
			Dynamist = 259,
			Shiranui = 260,
			DragonDevil = 261,
			Exodia = 262,
			PhantomKnight = 263,
			Phantom = 264,
			Super = 265,
			SuperQuantum = 266,
			SuperMachine = 267,
			BlueEyes = 268,
			HopeX = 269,
			Moonlight = 270,
			Amorphage = 271,
			ElfSwordsman = 272,
			MagicianGirl = 273,
			BlackMagic = 274,
			Metalphose = 275,
			Tramid = 276,
			ABF = 277,
			Houkai = 278,
			Chaos = 279,
			CyberAngel = 280,
			Cypher = 281,
			Cardian = 282,
			SilentSword = 283,
			SilentMagic = 284,
			MagnetWarrior = 285,
			BlackMagic2 = 286,
			Kuriboh = 287,
			Crystron = 288,
			Kagoju = 289,
			ApoQliphot = 290,
			SubTerror = 291,
			SubTerrorMalice = 292,
			Spyral = 293,
			SpyralGear = 294,
			MakaiGekidan = 295,
			MakaiDaihon = 296,
			FallenAngel = 297,
			WW = 298,
			Beast12 = 299,
			PendDragon = 300,
			SpyralMission = 301,
			Predator = 302,
			PredatorPlants = 303,
			SuperHeavySoul = 304,
			SummonBeast = 305,
			XyzDragon = 306,
			SyncDragon = 307,
			FusionDragon = 308,
			PendulumGraph = 309,
			SkyScraper = 310,
			WizardSpell = 311,
			LL = 312,
			HaohGate = 313,
			HaohKenRyu = 314,
			TrueDragon = 315,
			GenOhRyu = 316,
			Pendulum = 317,
			Gandra = 318,
			TrickStar = 319,
			Gouki = 320,
			Chalice = 321,
			Relics = 322,
			ClearWing = 323,
			StarveVenom = 324,
			CyberDark = 325,
			Bonding = 326,
			CodeTalker = 327,
			Bullet = 328,
			AlterGeist = 329,
			Crawler = 330,
			Metaphys = 331,
			VenDead = 332,
			FA = 333,
			Madan = 334,
			Weather = 335,
			Parshath = 336,
			ShadowSix = 337,
			Tindangle = 338,
			JackKnights = 339,
			MagicBeast = 340,
			EvolutionPill = 341,
			Barrel = 342,
			EyesSacrifice = 343,
			ArmedDragon = 344,
			GearMagic = 345,
			Troymare = 346,
			ElementSaber = 347,
			ElementLord = 348,
			KugaDan = 349,
			SentouKi = 350,
			Sentou = 351,
			Paradion = 352,
			DeviRitual = 353,
			BlueEyesMagic = 354,
			GoldenCastle = 355,
			CyberNet = 356,
			SalamanGreat = 357,
			DinoWrestler = 358,
			Orphgoal = 359,
			ThunderDragon = 360,
			ForbiddenMagic = 361,
			Danger = 362,
			PhotonGalaxy = 363,
			Nephthys = 364,
			PlanKids = 365,
			Mayakashi = 366,
			Valkyrie = 367,
			Youtou = 368,
			NeosMagic = 369,
			HarpieMagic = 370,
			MachineAngel = 371,
			RoseDragon = 372,
			Sanctuary = 373,
			Bushido = 374,
			Smile = 375,
			BusterMode = 376,
			ChronoDiver = 377,
			MugenKidou = 378,
			WitchCraft = 379,
			EvilEye = 380,
			Endymion = 381,
			Marincess = 382,
			TenI = 383,
			Simorgh = 384,
			BeeForce = 385,
			Message = 386,
			DarkFusion = 387,
			Destroy = 388,
			DestroyGod = 389,
			DreamMirror = 390,
			Zanki = 391,
			DragonMaid = 392,
			Generade = 393,
			Ignister = 394,
			Ai = 395,
			SenKa = 396,
			Megalith = 397,
			Oracle = 398,
			Onomato = 399,
			Future = 400,
			Rose = 401,
			Rebellion = 402,
			CodeBreaker = 403,
			Nemesis = 404,
			Barbaros = 405,
			Pirates = 406,
			Adamassiah = 407,
			Rikka = 408,
			Eldlich = 409,
			Eldlixir = 410,
			GoldenLand = 411,
			Phantasm = 412,
			PhantasmCard = 413,
			GaiaCard = 414,
			Dragma = 415,
			Melfy = 416,
			Potan = 417,
			Roland = 418,
			KoakimailCard = 419,
			RaCard = 420,
			MeklordGod = 421,
			JinzoCard = 422,
			FossilCard = 423,
			Numeron = 424,
			GateOfNumeron = 425,
			Kikai = 426,
			Hyoui = 427,
			SpiritEarth = 428,
			SpiritWater = 429,
			SpiritFire = 430,
			SpiritWind = 431,
			ToonCard = 432,
			TriBrigade = 433,
			DennoKai = 434,
			DennoKaiMon = 435,
			SouTen = 436,
			Magistus = 437,
			KissKill = 438,
			LeeLa = 439,
			LiveTwin = 440,
			EvilTwin = 441,
			Drytron = 442,
			Myutant = 443,
			Spriggans = 444,
			SForce = 445,
			WightCard = 446,
			Sacrifice = 447,
			CypherDragon = 448,
			SaintAvalon = 449,
			SaintVine = 450,
			HolyKnights = 451,
			Amazement = 452,
			Attraction = 453,
			Brand = 454,
			ZexalServus = 455,
			Zexal = 456,
			RDM = 457,
			WarCry = 458,
			Matereactor = 459,
			DollMonster = 460,
			BlackRoseCard = 461,
			Underworld = 462,
			DoReMiCode = 463,
			Bearkuty = 464,
			Despear = 465,
			ForestSpirit = 466,
			MagicKey = 467,
			StardustCard = 468,
			GunKan = 469,
			Cyber = 470,
			Kragen = 471,
			Numeronius = 472,
			ArcanaCard = 473,
			ACounter = 474,
			KuribohMagic = 475,
			NumbersCard = 476,
			SouKen = 477,
			HiSui = 478,
			Fuwandaries = 479,
			Topologic = 480,
			AlbazCard = 481,
			DHeroMagic = 482,
			DualMagic = 483,
			SaintSeed = 484,
			BeeTrooper = 485,
			Hyperion = 486,
			PUNK = 487,
			ExoSister = 488,
			BraveToken = 489,
			Dinorfear = 490,
			DevilLady = 491,
			BlueEyesCard = 492,
			Seventh = 493,
			Barians = 494,
			Leviathan = 495,
			SeaStealth = 496,
			Umi = 497,
			Puppet = 498,
			Libromancer = 499,
			Serions = 500,
			Scarecrow = 501,
			Barbarian = 502,
			Variants = 503,
			Labryrinth = 504,
			Welcome = 505,
			Rune = 506,
			EHeroMagic = 507,
			Sprite = 508,
			Tiaraments = 509,
			HaruKeSho = 510,
			Wingman = 511,
			MokeyMokey = 512,
			ExchangeCard = 513,
			AJewel = 514,
			DoodleBeast = 515,
			DoodleBook = 516,
			GGolem = 517,
			Bridge = 518,
			Ghotis = 519,
			Beasted = 520,
			Ksatrira = 521,
			BFDCard = 522,
			RAce = 523,
			Purely = 524,
			Mikanko = 525,
			ChaosSync = 526,
			AquaMirror = 527,
			InferNobleKnight = 528,
			VisasCard = 529,
			LabyrinthWall = 530,
			MashinCard = 531,
			GateGuardian = 532,
			GP = 533,
			FireWall = 534,
			ManaDoom = 535,
			Nemreria = 536,
			GranDoReMiCode = 537,
			Favorite = 538,
			VS = 539,
			Nouvellez = 540,
			Recipe = 541,
			Visas = 542,
			InferHolySword = 543,
			Sync = 544,
			RedDragonCard = 545,
			ChimeraCard = 546,
			CharlesCard = 547,
			Max = 548
		}

		private static Content s_instance;

		private const int Streams_CardIndex = 0;

		private const int Streams_CardName = 1;

		private const int Streams_CardDesc = 2;

		private const int Streams_WordIndex = 3;

		private const int Streams_WordText = 4;

		private const int Streams_DialogIndex = 5;

		private const int Streams_DialogText = 6;

		private const int Streams_CardPidx = 7;

		private const int Streams_CardPart = 8;

		private const int Streams_RubyIndex = 9;

		private const int Streams_RubyName = 10;

		private const int Streams_Length = 11;

		private readonly string[] DataPathForStream;

		private Stream[] cardStreams;

		private const string IntIdPath = "Card/Data/b0ea6a33a5e8917c/#/CARD_IntID";

		private const string PropPath = "Card/Data/b0ea6a33a5e8917c/#/CARD_Prop";

		private const string SamePath = "Card/Data/b0ea6a33a5e8917c/MD/CARD_Same";

		private const string GenrePath = "Card/Data/b0ea6a33a5e8917c/#/CARD_Genre";

		private const string NamedPath = "Card/Data/b0ea6a33a5e8917c/#/CARD_Named";

		private const string LinkPath = "Card/Data/b0ea6a33a5e8917c/MD/CARD_Link";

		private const string SearchNamePath = "Card/Data/b0ea6a33a5e8917c/MD/CARD_SearchName";

		public const string NEWLINE_TAG = "\n";

		private byte[] cardIntIds;

		private byte[] cardProps;

		private byte[] cardSame;

		private byte[] cardNamed;

		private byte[] cardLink;

		private byte[] cardGenre;

		private const string BuiltinCardData = "Card/Data/b0ea6a33a5e8917c/MD/builtin_card";

		public const string DeclaraCardAllPath = "Card/Data/b0ea6a33a5e8917c/MD/cards_all";

		public const string DeclaraCardDeckPath = "Card/Data/b0ea6a33a5e8917c/MD/cards_in_maindeck";

		public const string DeclaraCardMonstPath = "Card/Data/b0ea6a33a5e8917c/MD/monsters_in_maindeck";

		public const string DeclaraCardMonst2Path = "Card/Data/b0ea6a33a5e8917c/MD/all_monsters";

		public const string DeclaraCardGadgetPath = "Card/Data/b0ea6a33a5e8917c/MD/all_gadget_monsters";

		private Dictionary<string, int[]> dicDeclaraCard;

		private Dictionary<int, string> dicSearchName;

		private int cardNum;

		private bool isReady;

		private bool isLoadSuccess;

		private bool m_AdditionalChangeLineTag;

		private const string dclsymbol = "\n\n";

		private const string clsymbol = "\n";

		private const string periodsymbol = "\ufffd";

		private const string periodclsymbol = "\ufffd";

		private const string periodclsymbolblacket = "。";

		private const string periodblacket = "\ufffd";

		private static string[] spiltTags;

		private static string[] spiltTags_Korean;

		private List<int> allCardList;

		private Dictionary<int, int> sortIdx;

		private int m_iCryptoKey;

		public const float Witdh = 5.9f;

		public const float Height = 8.6f;

		public const float Aspect = 0.6860465f;

		public const int AttributeWordStart = 10;

		public const int TypeWordStart = 100;

		public const int IconWordStart = 50;

		public const int FrameNum = 20;

		public const int KindWordStart = 200;

		public const int GenreMax = 49;

		private const string LIBNAME = "duel";

		private List<int> noStarCardID;

		public static Content Instance => null;

		public static bool IsReady => false;

		public static bool IsLoadSuccess => false;

		public static void Create()
		{
		}

		public static void Destroy()
		{
		}

		public void Init()
		{
		}

		private IEnumerator LoadBinaryAsync()
		{
			return null;
		}

		public void LoadTutorialBinary()
		{
		}

		private IEnumerator LoadTutorialBinaryAsync()
		{
			return null;
		}

		public static void DeclaraCardCheckOpenCard(Dictionary<string, object> dicOpenCard)
		{
		}

		public void Release()
		{
		}

		public void Reload()
		{
		}

		private byte[] GetBytesDecryptionData(string path)
		{
			return null;
		}

		private IEnumerator GetBytesDecryptionDataAsync(string path, Action<byte[]> resultCallback)
		{
			return null;
		}

		private byte[] GetBytesDecryptionDataCore(byte[] outData)
		{
			return null;
		}

		public string GetName(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		public string GetRubyName(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		public string GetDesc(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		public string GetRawDesc(int cardId)
		{
			return null;
		}

		public string GetDescWithoutPendulum(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		public string GetDescOfPendulum(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		public string GetDescWithoutPendulumForCardInfo(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		public string GetDescOfPendulumForCardInfo(int cardId, bool replaceAlnum = true)
		{
			return null;
		}

		private void AddChangeLineTag(ref string str)
		{
		}

		private string getString(int id, Stream indexStream, Stream textStream)
		{
			return null;
		}

		public static string ReplaceAlnum(string str)
		{
			return null;
		}

		public string GetDialogText(int dlgtextId)
		{
			return null;
		}

		public string GetWordText(int wordId)
		{
			return null;
		}

		private string getDescActiveEffect(int cardId, int numOfEfx)
		{
			return null;
		}

		public int GetTextIDOfActiveEffect(int cardId, int numOfEfx)
		{
			return 0;
		}

		public (int, int) GetActiveEffectPosInText(int textId)
		{
			return default((int, int));
		}

		public int GetCardIdFromTextId(int textId)
		{
			return 0;
		}

		public string GetPendulumTag()
		{
			return null;
		}

		public string GetAttributeText(Attribute attr)
		{
			return null;
		}

		public string GetAttributeRuby(Attribute attr)
		{
			return null;
		}

		public string GetTypeText(Type type)
		{
			return null;
		}

		public string GetIconText(Icon icon)
		{
			return null;
		}

		public string GetIconFullText(int cardId)
		{
			return null;
		}

		public string GetMagicFullText(Icon icon)
		{
			return null;
		}

		public string GetTrapFullText(Icon icon)
		{
			return null;
		}

		public string GetKindText(Kind kind)
		{
			return null;
		}

		public string GetSortName(int mrk)
		{
			return null;
		}

		public List<int> GetAllCardList()
		{
			return null;
		}

		public bool IsExists(int cardid)
		{
			return false;
		}

		public bool IsValid(int cardid)
		{
			return false;
		}

		private IEnumerator coCreateCardList()
		{
			return null;
		}

		private void releaseAllCardList()
		{
		}

		public long GetCardGenre(int mrk)
		{
			return 0L;
		}

		private int readInt8(byte[] bytes, int pos)
		{
			return 0;
		}

		private int readInt16(byte[] bytes, int pos)
		{
			return 0;
		}

		private int readInt32(byte[] bytes, int pos)
		{
			return 0;
		}

		private long readInt64(byte[] bytes, int pos)
		{
			return 0L;
		}

		private void SetSearchName(byte[] data)
		{
		}

		private int[] createDeclarationCard(byte[] bytes)
		{
			return null;
		}

		public List<int> GetDeclarationCard(string path)
		{
			return null;
		}

		public void ReleaseDeclarationCard()
		{
		}

		private void createSortIdxList(byte[] bin)
		{
		}

		private void releaseSortIdxList()
		{
		}

		public int GetSortIndexFromMRK(int mrk)
		{
			return 0;
		}

		public bool IsExtraDeckCard(int mrk)
		{
			return false;
		}

		public bool IsMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsNormalMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsEffectMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsTokenCard(int cardId)
		{
			return false;
		}

		public bool IsRitualMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsLinkMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsPendulumMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsXyzMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsSyncMonsterCard(int cardId)
		{
			return false;
		}

		public bool IsFusionMonsterCard(int cardId)
		{
			return false;
		}

		[PreserveSig]
		private static extern int DLL_SetCardProperty(byte[] data, int size);

		[PreserveSig]
		private static extern void DLL_SetInternalID(byte[] data);

		[PreserveSig]
		private static extern void DLL_SetCardSame(byte[] data, int size);

		[PreserveSig]
		private static extern void DLL_SetCardNamed(byte[] data);

		[PreserveSig]
		private static extern void DLL_SetCardLink(byte[] data, int size);

		[PreserveSig]
		private static extern void DLL_SetCardGenre(byte[] data);

		[PreserveSig]
		private static extern int DLL_CardGetInternalID(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetType(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetAttr(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetStar(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetLevel(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetRank(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetScaleL(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetScaleR(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetLinkNum(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetLinkMask(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetIcon(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetFrame(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetKind(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetAtk(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetDef(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetAtk2(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetDef2(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetLimitation(int cardId);

		[PreserveSig]
		private static extern int DLL_CardIsThisCardGenre(int cardId, int genreId);

		[PreserveSig]
		private static extern int DLL_CardIsThisSameCard(int cardA, int cardB);

		[PreserveSig]
		private static extern int DLL_CardGetOriginalID(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetOriginalID2(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetAlterID(int cardId);

		[PreserveSig]
		private static extern int DLL_CardGetAltCardID(int cardId, int alterID);

		[PreserveSig]
		private static extern int DLL_CardCheckName(int cardId, int nameType);

		[PreserveSig]
		private static extern int DLL_CardGetLinkCards(int cardId, IntPtr pLinkID);

		[PreserveSig]
		private static extern int DLL_CardGetBasicVal(int cardId, ref Engine.BasicVal pVal);

		[PreserveSig]
		private static extern int DLL_CardIsThisTunerMonster(int cardId);

		private int setCardProperty(byte[] data)
		{
			return 0;
		}

		private void setInternalID(byte[] data)
		{
		}

		private int getInternalID(int cardId)
		{
			return 0;
		}

		private void setCardSame(byte[] data)
		{
		}

		private void setCardNamed(byte[] data)
		{
		}

		private void setCardLink(byte[] data)
		{
		}

		private void setCardGenre(byte[] data)
		{
		}

		public Type GetType(int cardId)
		{
			return default(Type);
		}

		public Attribute GetAttr(int cardId)
		{
			return default(Attribute);
		}

		public int GetStar(int cardId)
		{
			return 0;
		}

		public int GetCardStar(int cardId)
		{
			return 0;
		}

		public bool IsNoStarCard(int cardId)
		{
			return false;
		}

		public int GetLevel(int cardId)
		{
			return 0;
		}

		public int GetRank(int cardId)
		{
			return 0;
		}

		public int GetScaleL(int cardId)
		{
			return 0;
		}

		public int GetScaleR(int cardId)
		{
			return 0;
		}

		public int GetLinkNum(int cardId)
		{
			return 0;
		}

		public int GetLinkMask(int cardId)
		{
			return 0;
		}

		public Icon GetIcon(int cardId)
		{
			return default(Icon);
		}

		public Frame GetFrame(int cardId)
		{
			return default(Frame);
		}

		public Kind GetKind(int cardId)
		{
			return default(Kind);
		}

		public int GetAtk(int cardId)
		{
			return 0;
		}

		public int GetDef(int cardId)
		{
			return 0;
		}

		public int GetAtk2(int cardId)
		{
			return 0;
		}

		public int GetDef2(int cardId)
		{
			return 0;
		}

		public bool IsThisCardGenre(int cardId, Genre genre)
		{
			return false;
		}

		public bool IsThisSameCard(int cardA, int cardB)
		{
			return false;
		}

		public bool IsThisTunerMonster(int cardId)
		{
			return false;
		}

		public int GetOriginalID(int cardId)
		{
			return 0;
		}

		public int GetOriginalID2(int cardId)
		{
			return 0;
		}

		public int GetAlterID(int cardId)
		{
			return 0;
		}

		public int GetAltCardID(int cardId, int altId)
		{
			return 0;
		}

		public bool CheckCardName(int cardId, NameType type)
		{
			return false;
		}

		public List<int> GetLinkCards(int cardId)
		{
			return null;
		}

		public List<int> GetLinkCardsOfAvailable(int cardId)
		{
			return null;
		}

		public static void GetBasicVal(int cardId, ref Engine.BasicVal val)
		{
		}
	}
}
