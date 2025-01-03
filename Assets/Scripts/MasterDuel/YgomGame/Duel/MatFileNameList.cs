using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class MatFileNameList : ScriptableObject
	{
		[Serializable]
		public class MatFileNameInfoList
		{
			public int id;

			public string fileName;

			public MatFileNameInfoList Copy()
			{
				return null;
			}
		}

		public List<MatFileNameInfoList> matInfoList;

		public List<string> getFileNameList()
		{
			return null;
		}
	}
}
