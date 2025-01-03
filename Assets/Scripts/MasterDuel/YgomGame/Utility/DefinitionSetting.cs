using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Utility
{
	//[CreateAssetMenu]
	public class DefinitionSetting : ScriptableObject
	{
		public enum ValueType
		{
			Int = 0,
			Float = 1,
			Vector2 = 2,
			Vector3 = 3,
			Quaternion = 4,
			String = 5,
			Color = 6,
			Bool = 7,
			IntList = 8,
			FloatList = 9
		}

		[Serializable]
		public class ValueContainer
		{
			public string label;

			public List<float> floatValues;

			public string stringValue;

			public ValueType valueType;

			public ValueContainer Copy()
			{
				return null;
			}
		}

		public List<ValueContainer> list;

		public IEnumerable<string> SelectLabels()
		{
			return null;
		}

		public ValueContainer Get(string label, int index = 0)
		{
			return null;
		}

		public bool Get(string label, out int res)
		{
			res = default(int);
			return false;
		}

		public bool Get(string label, out float res)
		{
			res = default(float);
			return false;
		}

		public bool Get(string label, out Vector2 res)
		{
			res = default(Vector2);
			return false;
		}

		public bool Get(string label, out Vector3 res)
		{
			res = default(Vector3);
			return false;
		}

		public bool Get(string label, out Quaternion res)
		{
			res = default(Quaternion);
			return false;
		}

		public bool Get(string label, out string res)
		{
			res = null;
			return false;
		}

		public bool Get(string label, out Color res)
		{
			res = default(Color);
			return false;
		}

		public bool Get(string label, out bool res)
		{
			res = default(bool);
			return false;
		}

		public bool Get(string label, out List<int> res)
		{
			res = null;
			return false;
		}

		public bool Get(string label, out List<float> res)
		{
			res = null;
			return false;
		}

		public bool GetAsValueType(string label, out object res)
		{
			res = null;
			return false;
		}
	}
}
