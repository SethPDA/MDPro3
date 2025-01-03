using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	[Serializable]
	public class CardLocator
	{
		private int m_index;

		private int m_viewIndex;

		private Vector3 _pos;

		private Quaternion _rot;

		public bool removed
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

		public int index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int viewIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector3 pos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rot
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 scale
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CardPlace cardPlace
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int refCounter
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

		public Vector3 posOffsetORU
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion rotOffsetORU
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 posOffsetHand
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void ResetOffset()
		{
		}
	}
}
