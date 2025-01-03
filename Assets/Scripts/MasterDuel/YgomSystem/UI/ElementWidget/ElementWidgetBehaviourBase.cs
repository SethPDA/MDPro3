using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget
{
	public class ElementWidgetBehaviourBase<T> : MonoBehaviour where T : ElementWidgetBehaviourBase<T>
	{
		private ElementObjectManager m_EomCache;

		public ElementObjectManager eom => null;

		protected static T InnerCreate(ElementObjectManager eom)
		{
			return null;
		}

		protected virtual void CollectComponents()
		{
		}
	}
}
