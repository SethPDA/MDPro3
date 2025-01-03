using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class LogShowTag : LogItemBase
	{
		[SerializeField]
		protected string m_Label_TagName;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowTagType type)
		{
		}

		protected void SetTargetTag()
		{
		}

		protected void SetCostTag()
		{
		}
	}
}
