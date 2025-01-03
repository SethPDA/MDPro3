using System;
using UnityEngine;

namespace YgomGame.DuelLive
{
	[Serializable]
	public class DuelLiveProductGroupData : IDuelLiveProductGruopData
	{
		[SerializeField]
		private int m_GroupId;

		[SerializeField]
		private string m_LabelTextId;

		[SerializeField]
		private string m_Param;

		public int groupId => 0;

		public string labelTextId => null;

		public virtual string labelText => null;

		public string param => null;

		public void SetGroupId(int id)
		{
		}

		public void SetLabelTextId(string id)
		{
		}

		public void SetParam(string para)
		{
		}

		public virtual bool IsMatchProduct(IProductContext product)
		{
			return false;
		}
	}
}
