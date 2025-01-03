using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Download
{
	//[CreateAssetMenu]
	public class DontOpenCardList : ScriptableObject
	{
		[Serializable]
		public class DontOpenInfoList
		{
			public int id;

			public string Mrk;

			public DontOpenInfoList Copy()
			{
				return null;
			}
		}

		private static DontOpenCardList m_Instance;

		private const string path = "Download/ScriptableObject/DontOpenCardList";

		public List<DontOpenInfoList> dontOpenInfoList;

		public List<int> m_avoidList;

		public List<int> GetCardList()
		{
			return null;
		}
	}
}
