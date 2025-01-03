using System;
using System.Collections.Generic;
using YgomGame.Card;
using YgomGame.Deck;

public class SortComparer
{
	public enum METHOD
	{
		Default = 0,
		Obtained = 1,
		Inventory = 2,
		Rarity = 3,
		StarsAndLink = 4,
		Atk = 5,
		Def = 6,
		Name = 7,
		Premium = 8,
		Shop = 9,
		None = 10
	}

	public enum ORDER
	{
		Asc = 0,
		Desc = 1
	}

	public struct Sorter
	{
		public METHOD Method;

		public ORDER Order;

		//public Sorter(METHOD m, ORDER o)
		//{
		//}
	}

	private const int MAX_DEF = 9999999;

	private const int MAX_ATK = 9999999;

	private const int MAX_STAR = 9999999;

	private Sorter sorter;

	private static Dictionary<METHOD, Func<int, int, ORDER, int>> comparers;

	private static Dictionary<METHOD, Func<CardBaseData, CardBaseData, ORDER, int>> comparers2;

	private const int FRAMESORTORDER_RITUAL = 30;

	private const int FRAMESORTORDER_RITUALPEND = 31;

	private const int FRAMESORTORDER_EFFECT = 20;

	private const int FRAMESORTORDER_PENDFX = 21;

	private const int FRAMESORTORDER_NORMAL = 10;

	private const int FRAMESORTORDER_PEND = 11;

	private const int FRAMESORTORDER_FUSION = 100;

	private const int FRAMESORTORDER_FUSIONPEND = 110;

	private const int FRAMESORTORDER_SYNC = 120;

	private const int FRAMESORTORDER_DSYNC = 130;

	private const int FRAMESORTORDER_SYNCPEND = 140;

	private const int FRAMESORTORDER_XYZ = 150;

	private const int FRAMESORTORDER_XYZPEND = 160;

	private const int FRAMESORTORDER_LINK = 170;

	private const int FRAMESORTORDER_MAGIC = 200;

	private const int FRAMESORTORDER_TRAP = 210;

	private const int FRAMESORTORDER_TOKEN = 220;

	private const int FRAMESORTORDER_RA = 230;

	private const int FRAMESORTORDER_OSIRIS = 240;

	private const int FRAMESORTORDER_OBERISK = 250;

	private static Dictionary<Content.Frame, int> frameOrder;

	private static Dictionary<Content.Frame, int> shopFrameOrder;

	private const int ICONSORTORDER_NONE = 1;

	private const int ICONSORTORDER_COUNTER = 2;

	private const int ICONSORTORDER_FIELD = 4;

	private const int ICONSORTORDER_EQUIP = 3;

	private const int ICONSORTORDER_CONTINUOUS = 6;

	private const int ICONSORTORDER_QUICKPLAY = 7;

	private const int ICONSORTORDER_RITUAL = 5;

	private static Dictionary<Content.Icon, int> iconOrder;

	private static Content m_cci => null;

	public SortComparer(Sorter s)
	{
	}

	public int Compare(int a, int b)
	{
		return 0;
	}

	public int Compare(CardBaseData a, CardBaseData b)
	{
		return 0;
	}

	public static int Compare(int a, int b, Sorter sorter)
	{
		return 0;
	}

	public static int Compare(CardBaseData a, CardBaseData b, Sorter sorter)
	{
		return 0;
	}

	public static bool isDesc(ORDER o)
	{
		return false;
	}

	private static int DefaultComparer(int a, int b, ORDER o = ORDER.Desc)
	{
		return 0;
	}

	private static int DefaultComparer(CardBaseData a, CardBaseData b, ORDER o = ORDER.Desc)
	{
		return 0;
	}

	private static int ObtainedDateComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int ObtainedDateComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int InventoryComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int InventoryComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int RarityComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int RarityComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int StarsComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int StarsComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int AtkComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int AtkComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int DefComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int DefComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int NameComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int NameComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int PremiumComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int PremiumComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int ShopComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return 0;
	}

	private static int ShopComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int baseComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int frameComparer(Content.Frame fa, Content.Frame fb, ORDER o)
	{
		return 0;
	}

	private static int shopFrameComparer(Content.Frame fa, Content.Frame fb, ORDER o)
	{
		return 0;
	}

	private static int iconComparer(Content.Icon ia, Content.Icon ib, ORDER o)
	{
		return 0;
	}

	private static int obtainedDateComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int starComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int linkComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int inventoryComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int rarityComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int atkComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int nameComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int defComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int premiumIDComparer(int a, int b, ORDER o)
	{
		return 0;
	}

	private static int ownedComparer(bool a, bool b, ORDER o)
	{
		return 0;
	}

	private static int rentaledComparer(bool a, bool b, ORDER o)
	{
		return 0;
	}

	private static int starsandlinkConverter(int a, ORDER o)
	{
		return 0;
	}
}
