using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

namespace Willow.InGameField
{
	[RequireDerived]
	public abstract class BaseFieldEvent : ScriptableObject
	{
		[NonSerialized]
		public BaseFieldEvent parent;

		[NonSerialized]
		public List<BaseFieldEvent> childEventList;

		public EventScope eventScope;
	}
}
