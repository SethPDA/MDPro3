using System;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget
{
	public class ElementWidgetTemplatePool<T> : UIObjectPool<T> where T : ElementWidgetBase
	{
		private Func<ElementObjectManager, T> m_Factory;

		private readonly Transform m_Parent;

		private readonly ElementObjectManager m_Template;

		public ElementWidgetTemplatePool(Transform parent, ElementObjectManager template, Func<ElementObjectManager, T> factory)
		{
			//((UIObjectPool<>)(object)this)._002Ector();
		}

		protected override T Create()
		{
			return null;
		}

		protected override void OnAfterCreate(T obj)
		{
		}
	}
}
