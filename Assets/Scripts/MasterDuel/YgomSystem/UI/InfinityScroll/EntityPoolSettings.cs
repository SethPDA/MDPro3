using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.InfinityScroll
{
	[Serializable]
	public class EntityPoolSettings
	{
		public enum Alignment
		{
			Begin = 0,
			Center = 1,
			End = 2
		}

		[SerializeField]
		private GridLayoutGroup.Axis m_ScrollAxis;

		[SerializeField]
		private Alignment m_Alignment;

		[SerializeField]
		private bool m_InstantiateAllTemplates;

		public GridLayoutGroup.Axis scrollAxis => default(GridLayoutGroup.Axis);

		public Alignment alignment => default(Alignment);

		public bool isInstaintiateAllTemplates
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
