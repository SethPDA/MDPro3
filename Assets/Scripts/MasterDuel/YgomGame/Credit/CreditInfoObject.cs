using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Credit
{
	//[CreateAssetMenu]
	public class CreditInfoObject : ScriptableObject
	{
		[SerializeField]
		public float scrollSpeed;

		[SerializeField]
		public List<CreditInfo> creditInfoList;
	}
}
