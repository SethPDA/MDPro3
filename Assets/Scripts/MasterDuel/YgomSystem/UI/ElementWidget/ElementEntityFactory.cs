using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI.ElementWidget
{
	public class ElementEntityFactory : MonoBehaviour
	{
		[SerializeField]
		private string m_ELabelTemplate;

		[SerializeField]
		private string[] m_ELabelAdditionalTemplates;

		[SerializeField]
		private Transform m_WidgetRoot;

		[SerializeField]
		private bool m_UseTemplateRoot;

		private List<GameObject> m_Templates;

		private Dictionary<GameObject, int> m_EntityToDataIndexTable;

		private Dictionary<int, GameObject> m_DataIndexToEntityTable;

		private List<Stack<GameObject>> m_FreeEntityStack;

		private List<GameObject> m_ActiveEntityList;

		private int m_DataCount;

		private List<int> m_TemplateIdxList;

		public Action<GameObject, int> onCreatedEntityCallback;

		public Action<GameObject> onActivateEntityCallback;

		public Action<GameObject, int> onUpdateEntityCallback;

		public Action<GameObject> onDeactivateEntityCallback;

		public Transform widgetRoot => null;

		public int dataCount => 0;

		public GameObject GetEntityByDataIndex(int dataindex)
		{
			return null;
		}

		public int GetDataIndexByEntity(GameObject entity)
		{
			return 0;
		}

		public void Initialize()
		{
		}

		public void UpdateDataCount(int dataCount, List<int> templateIdxList = null)
		{
		}

		public void UpdateData()
		{
		}

		private GameObject CreateItem(int templateIdx)
		{
			return null;
		}

		private GameObject AddItem(int templateIdx, int dataIndex)
		{
			return null;
		}

		private void RemoveItem(int dataIndex)
		{
		}
	}
}
