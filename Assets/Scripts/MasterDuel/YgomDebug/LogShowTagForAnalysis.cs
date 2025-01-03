using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class LogShowTagForAnalysis : LogItemBaseForAnalysis
	{
		[SerializeField]
		protected string m_Label_TagName;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowTagTypeForAnalysis type)
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
