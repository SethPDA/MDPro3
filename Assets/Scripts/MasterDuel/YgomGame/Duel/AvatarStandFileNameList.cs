using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class AvatarStandFileNameList : ScriptableObject
	{
		[Serializable]
		public class AvatarStandFileNameInfoList
		{
			public int id;

			public string fileName;

			public AvatarStandFileNameInfoList Copy()
			{
				return null;
			}
		}

		public List<AvatarStandFileNameInfoList> avatarStandInfoList;

		public List<string> getFileNameList()
		{
			return null;
		}
	}
}
