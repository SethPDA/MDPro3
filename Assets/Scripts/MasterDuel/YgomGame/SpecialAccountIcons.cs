using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame
{
	public class SpecialAccountIcons : MonoBehaviour
	{
		public enum TEAMTYPE
		{
			Team0 = 0,
			Team1 = 1
		}

		[SerializeField]
		private TEAMTYPE teamtype;

		private ElementObjectManager m_Eom;

		private void Awake()
		{
		}

		public int GetPlayeridByTeam(TEAMTYPE team)
		{
			return 0;
		}

		private void SetSpIconByPlayerid(int playerid)
		{
		}
	}
}
