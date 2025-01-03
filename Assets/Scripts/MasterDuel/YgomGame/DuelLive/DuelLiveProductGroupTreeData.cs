using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.DuelLive
{
	[Serializable]
	public class DuelLiveProductGroupTreeData<T> : DuelLiveProductGroupData where T : class, IDuelLiveProductGruopData
	{
		[SerializeField]
		private T[] m_Children;

		private Dictionary<int, T> m_ChildrenMap;

		public T[] GetChildren()
		{
			return null;
		}

		public T GetGroupData(int groupId)
		{
			return null;
		}

		public void AddChildrenData(T data)
		{
		}
	}
}
