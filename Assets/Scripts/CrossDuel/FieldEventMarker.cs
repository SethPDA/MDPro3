using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Timeline;

namespace Willow.InGameField
{
	[Serializable]
	[DisplayName]
	[Preserve]
	public class FieldEventMarker : Marker, INotification
	{
		public TriggerFieldEventCommandSet triggerFieldEventCommandSet;

		public PropertyName id => default(PropertyName);
	}
}
