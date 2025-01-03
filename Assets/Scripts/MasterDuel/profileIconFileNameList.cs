using System;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class profileIconFileNameList : ScriptableObject
{
	[Serializable]
	public class ProfileIconFileNameInfoList
	{
		public int id;

		public string fileName;

		public ProfileIconFileNameInfoList Copy()
		{
			return null;
		}
	}

	public List<ProfileIconFileNameInfoList> profileIconFileNameInfoList;

	public List<string> getFileNameList()
	{
		return null;
	}
}
