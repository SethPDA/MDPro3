using System;
using System.Collections.Generic;
using UnityEngine;

namespace Willow.InGameField
{
	[Serializable]
	[CreateAssetMenu]
	public class EventRecipe : ScriptableObject
	{
		public List<IntFieldEvent> intFieldEventList;

		public List<BoolFieldEvent> boolFieldEventList;
	}
}
