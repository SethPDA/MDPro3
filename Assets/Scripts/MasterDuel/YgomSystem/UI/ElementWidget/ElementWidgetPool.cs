using System;

namespace YgomSystem.UI.ElementWidget
{
	public class ElementWidgetPool<T> : UIObjectPool<T> where T : ElementWidgetBase
	{
		private readonly Func<T> m_Factory;

		public ElementWidgetPool(Func<T> factory)
		{
			//((UIObjectPool<>)(object)this)._002Ector();
		}

		protected override T Create()
		{
			return null;
		}

		protected override void OnBeforeRent(T obj)
		{
		}

		protected override void OnBeforeReturn(T obj)
		{
		}
	}
}
