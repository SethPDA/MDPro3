using System.IO;

namespace com.adjust.sdk
{
	public class JSONData : JSONNode
	{
		private string m_Data;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JSONData(string aData)
		{
		}

		public JSONData(float aData)
		{
		}

		public JSONData(double aData)
		{
		}

		public JSONData(bool aData)
		{
		}

		public JSONData(int aData)
		{
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
