using System;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class ProfileIconFrameFileNameList : ScriptableObject
{
	[Serializable]
	public class ProfileIconFrameFileNameInfoList
	{
		public int id;

		public string fileName;

		public ProfileIconFrameFileNameInfoList Copy()
		{
			return null;
		}
	}

	public List<ProfileIconFrameFileNameInfoList> profileIconFrameFileNameInfoList;

	public List<string> getFileNameList()
	{
		return null;
	}
}
