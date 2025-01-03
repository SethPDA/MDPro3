using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.CardPack.Open.Widget
{
	[ExecuteInEditMode]
	public class ChildrenSpriteColorSetter : MonoBehaviour
	{
		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private bool m_UpdateEveryFrame;

		private Color m_LastColor;

		private bool m_Dirty;

		private List<SpriteRenderer> m_Children;

		private int m_LastChildCount;

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		private void LateUpdate()
		{
		}

		public void UpdateColor()
		{
		}

		private void UpdateChildren()
		{
		}
	}
}
