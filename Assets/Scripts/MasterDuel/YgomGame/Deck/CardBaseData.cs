using System;
using System.Runtime.CompilerServices;

namespace YgomGame.Deck
{
	[Serializable]
	public struct CardBaseData : IEquatable<CardBaseData>
	{
		public int CardID
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

		public int PremiumID
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

		public bool IsOwned
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Obtained
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

		public int Inventory
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

		public int Rarity
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

		public bool IsRental
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CardBaseData(int c_id = 0, int p_id = 0, bool owned = true, bool rental = false)
		{
		}

		public static bool operator ==(CardBaseData a, CardBaseData b)
		{
			return false;
		}

		public static bool operator !=(CardBaseData a, CardBaseData b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(CardBaseData data)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
