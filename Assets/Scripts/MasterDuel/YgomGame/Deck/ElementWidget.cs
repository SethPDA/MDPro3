using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Deck
{
	public abstract class ElementWidget : MonoBehaviour
	{
		protected ElementObjectManager m_Eom;

		protected bool isInitialized;

		public bool isIni => false;

		public void Initialize()
		{
		}

		private void Awake()
		{
		}

		protected abstract void InitializeElements();
	}
}
