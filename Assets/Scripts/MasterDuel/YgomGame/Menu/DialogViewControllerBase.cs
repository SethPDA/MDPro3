using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu
{
	public abstract class DialogViewControllerBase : BaseMenuViewController
	{
		[SerializeField]
		private ElementObjectManager m_UIPrefab;

		protected ElementObjectManager m_UI;

		protected virtual int selectorPriority => 0;

		protected virtual void Awake()
		{
		}
	}
}
