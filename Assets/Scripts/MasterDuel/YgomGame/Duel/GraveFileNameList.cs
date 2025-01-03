using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class GraveFileNameList : ScriptableObject
	{
		[Serializable]
		public class GraveFileNameInfoList
		{
			public int id;

			public string fileName;

			public GraveFileNameInfoList Copy()
			{
				return null;
			}
		}

		public List<GraveFileNameInfoList> graveInfoList;

		public List<string> getFileNameList()
		{
			return null;
		}
	}
}
