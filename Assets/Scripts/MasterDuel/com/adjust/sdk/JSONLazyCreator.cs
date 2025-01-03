namespace com.adjust.sdk
{
	internal class JSONLazyCreator : JSONNode
	{
		private JSONNode m_Node;

		private string m_Key;

		public override JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		//public override JSONNode Item
		//{
		//	get
		//	{
		//		return null;
		//	}
		//	set
		//	{
		//	}
		//}

		public override int AsInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override float AsFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public override bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override JSONArray AsArray => null;

		public override JSONClass AsObject => null;

		public JSONLazyCreator(JSONNode aNode)
		{
		}

		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		private void Set(JSONNode aVal)
		{
		}

		public override void Add(JSONNode aItem)
		{
		}

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return false;
		}

		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}
