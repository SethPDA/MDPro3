using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelTurnCount : MonoBehaviour
	{
		private ElementObjectManager eom;

		private ExtendedTextMeshProUGUI count;

		private RawImage cardImg;

		private GameObject clockObj;

		private int targetNum;

		private int cardId;

		public bool Finished
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public void Set(int mrk, int num)
		{
		}

		public void OnFinishCard()
		{
		}

		public void OnFinishAnim()
		{
		}
	}
}
