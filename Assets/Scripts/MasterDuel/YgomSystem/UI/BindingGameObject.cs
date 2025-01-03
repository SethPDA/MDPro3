using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class BindingGameObject : MonoBehaviour
	{
		[SerializeField]
		protected string prefabPath;

		[HideInInspector]
		public bool IsDone;

		[SerializeField]
		private bool immediate;

		[SerializeField]
		public bool StartOnAwake;

		protected bool IsSetParent;

		protected string basePath;

		protected Dictionary<string, object> pathArgs;

		private Action<GameObject> onCreated;

		public string PrefabPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Rebind(bool force = false)
		{
		}

		private void Awake()
		{
		}

		protected void SetOnCreated(Action<GameObject> act)
		{
		}

		public void SetImmediate(bool immediate)
		{
		}

		public void LoadGameObject()
		{
		}

		protected void SplitPath()
		{
		}

		protected virtual void PostModifiyByArgs(GameObject go)
		{
		}
	}
}
