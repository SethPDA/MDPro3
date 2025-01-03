using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace com.adjust.sdk
{
	public class JSONClass : JSONNode, IEnumerable
	{
		private Dictionary<string, JSONNode> m_Dict;

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

		public override int Count => 0;

		public override IEnumerable<JSONNode> Childs => null;

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override string ToString(string aPrefix)
		{
			return null;
		}

		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
