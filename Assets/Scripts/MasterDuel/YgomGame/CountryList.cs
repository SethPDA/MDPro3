using System.Collections.Generic;

namespace YgomGame
{
	public class CountryList
	{
		private List<CountryData> m_list;

		private CountryData m_otherData;

		private CountryData m_defaultData;

		private CountryList()
		{
		}

		private void initialize(string lang)
		{
		}

		public CountryData GetDefault()
		{
			return null;
		}

		public CountryData GetDataByNumeric(int numeric)
		{
			return null;
		}

		public CountryData GetDataByAlpha2(string alpha2)
		{
			return null;
		}

		public int[] GetNumericList()
		{
			return null;
		}

		public string[] GetAlpha2List()
		{
			return null;
		}

		public string[] GetDisplayList()
		{
			return null;
		}

		public static CountryList Create(string lang)
		{
			return null;
		}
	}
}
