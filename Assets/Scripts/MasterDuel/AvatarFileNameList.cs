using System;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class AvatarFileNameList : ScriptableObject
{
	[Serializable]
	public class AvatarFileNameInfoList
	{
		public int id;

		public string fileName;

		public AvatarFileNameInfoList Copy()
		{
			return null;
		}
	}

	public List<AvatarFileNameInfoList> avatarInfoList;

	public List<string> getFileNameList()
	{
		return null;
	}
}
