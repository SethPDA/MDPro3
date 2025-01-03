using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	public class MateTransformSetting : ScriptableObject
	{
		[Serializable]
		public class Data
		{
			public int mateId;

			public Vector3 position;

			[SerializeField]
			public Vector3 rotation;

			public Vector3 scale;

			public Data()
			{
			}

			public Data(int mateId, Vector3 position, Vector3 rotation, Vector3 scale)
			{
			}

			public void CopyTo(Data target)
			{
			}

			public void ImportTransform(Transform transform)
			{
			}

			public void ExportLocate(Transform transform)
			{
			}
		}

		[SerializeField]
		private List<Data> m_Datas;

		[SerializeField]
		private List<MateTransformSetting> m_Fallbacks;

		public Data FindByMateId(int mateId)
		{
			return null;
		}

		public bool TryApplyTransform(int mateId, Transform target)
		{
			return false;
		}

		public void SubmitData(Data from)
		{
		}

		public void SetSetting(Data mateSetting)
		{
		}
	}
}
