using UnityEngine;

namespace YgomGame.MDMarkup
{
	public class MDMarkupIndentFactory
	{
		internal const int k_EmptyIndent = -2;

		private readonly Transform[] m_IndentTemplates;

		public MDMarkupIndentFactory(Transform[] indentTemplates)
		{
		}

		public MDMarkupIndentWidget Create(int indent)
		{
			return null;
		}

		public MDMarkupIndentWidget Create(int indent, MDMarkupIndentWidget parent)
		{
			return null;
		}

		public MDMarkupIndentWidget Create(int indent, Transform parent)
		{
			return null;
		}
	}
}
