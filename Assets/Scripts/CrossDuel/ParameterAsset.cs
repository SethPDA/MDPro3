using System;
using UnityEngine;

namespace Willow.InGameField
{
	[Serializable]
	public class ParameterAsset : ScriptableObject
	{
		[SerializeField]
		protected ParameterContainer m_parentContainer;

		[SerializeField]
		protected string m_type;

		public string type
		{
			get
			{
				return m_type;
			}
			set
			{
				if (m_type != value)
					m_type = value;
			}
		}

		public ParameterContainer parent
		{
			get
			{
				return m_parentContainer;
			}
			set
			{
			}
		}
	}
}
