using UnityEngine.EventSystems;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget
{
	public class ElementWidgetUIBehaviourBase<T> : UIBehaviour where T : ElementWidgetUIBehaviourBase<T>
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
