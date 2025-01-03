using System;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class EnumStringAttribute : PropertyAttribute
	{
		public readonly Type enumType;

		public EnumStringAttribute(Type enumType)
		{
		}
	}
}
