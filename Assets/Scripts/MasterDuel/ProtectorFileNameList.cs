using System;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class ProtectorFileNameList : ScriptableObject
{
	[Serializable]
	public class ProtectorFileNameInfoList
	{
		public int id;

		public string fileName;

		public ProtectorFileNameInfoList Copy()
		{
			return null;
		}
	}

	public List<ProtectorFileNameInfoList> protectorInfoList;

	public List<string> getFileNameList()
	{
		return null;
	}
}
