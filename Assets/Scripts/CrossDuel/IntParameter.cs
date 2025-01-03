using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Willow.InGameField
{
	[Serializable]
	[CreateAssetMenu]
	public class IntParameter : ParameterAsset//, IParameter<int>, IParameter, ISerializationCallbackReceiver
	{
		[SerializeField]
		private int m_value;

		[NonSerialized]
		private int m_runtimeValue;

		public int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int runtimeValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<int> onValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnDisable()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}
	}
}
