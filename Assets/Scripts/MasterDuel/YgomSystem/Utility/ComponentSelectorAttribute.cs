using UnityEngine;

namespace YgomSystem.Utility
{
	public class ComponentSelectorAttribute : PropertyAttribute
	{
		public readonly bool useAlias;

		public ComponentSelectorAttribute(bool useAlias)
		{
		}
	}
}
