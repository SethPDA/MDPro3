using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget
{
	public class ElementWidgetBase : IAsyncProgressContainer
	{
		private List<IAsyncProgressContent> m_AsyncProgressContents;

		public readonly ElementObjectManager eom;

		public IReadOnlyList<IAsyncProgressContent> asyncProgressContents => null;

		public GameObject gameObject => null;

		public Transform transform => null;

		public virtual bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ElementWidgetBase(ElementObjectManager eom)
		{
		}

		public virtual void Clear()
		{
		}

		protected void AssignProgressContent(IAsyncProgressContent progressContent)
		{
		}

		public static implicit operator bool(ElementWidgetBase exists)
		{
			return false;
		}
	}
}
