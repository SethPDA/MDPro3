using System;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI
{
	[Serializable]
	public class ViewCreater
	{
		public enum CreateType
		{
			None = 0,
			PrefRef = 1,
			PrefPath = 2,
			PrefLinker = 4,
			ManualInstance = 3
		}

		[SerializeField]
		private CreateType m_CreateType;

		[SerializeField]
		private ElementObjectManager m_PrefRef;

		[SerializeField]
		private string m_PrefPath;

		[SerializeField]
		private string m_PrefLinkerLabel;

		private ElementObjectManager m_ManualInstance;

		private Transform m_Parent;

		private bool m_IsManualParent;

		public CreateType createType
		{
			get
			{
				return default(CreateType);
			}
			set
			{
			}
		}

		public ElementObjectManager prefRef
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string prefPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string prefLinkerLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ElementObjectManager manualInstance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isManualParent => false;

		public void Create(GameObject woner, Action<ElementObjectManager> onComplete)
		{
		}
	}
}
