using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.ElementSystem
{
	[DisallowMultipleComponent]
	public class ElementObjectManager : MonoBehaviour
	{
		public SortedDictionary<string, ElementObject> elements;

		[NonSerialized]
		public List<ElementObject> tempElements;

		public Dictionary<string, int> labelCounter;

		public ElementObject[] serializedElements;

		private bool applied;

		public bool error
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public void SetElement(ElementObject element)
		{
		}

		private void ArrangementElements()
		{
		}

		private void SetupChildrenElements()
		{
		}

		private void SetupSerializedElements()
		{
		}

		private void Reset()
		{
		}

		public void SetupElements()
		{
		}

		public void ApplySerializedElements()
		{
		}

		private void CheckSameLabel()
		{
		}

		public int GetElementsCount()
		{
			int count = 0;
			foreach(var element in serializedElements)
				count++;
			return count;
		}

		public bool IsExistsLabel(string label)
		{
			bool exist = false;
            foreach (var element in serializedElements)
				if(element.label == label)
				{
					exist = true;
					break;
				}
			return exist;
        }

		public SortedDictionary<string, ElementObject>.KeyCollection GetLabels()
		{
			return null;
		}

		public GameObject GetElement(string label)
		{
            foreach (var element in serializedElements)
                if (element.label == label)
					return element.gameObject;
			return null;
        }

        public GameObject GetNestedElement(string label)
		{
			var paths = label.Split('/');
			var manager = this;
			for (int i = 0; i < paths.Length - 1; i++)
				manager = manager.GetElement<ElementObjectManager>(paths[i]);
			return manager.GetElement(paths[^1]);
		}

		public T GetElement<T>(string label) where T : UnityEngine.Object
		{
            foreach (var element in serializedElements)
                if (element.label == label)
                    return element.GetComponent<T>();
            return null;
        }

        public T GetNestedElement<T>(string label) where T : UnityEngine.Object
		{
            var paths = label.Split('/');
            var manager = this;
            for (int i = 0; i < paths.Length - 1; i++)
                manager = manager.GetElement<ElementObjectManager>(paths[i]);
            return manager.GetElement<T>(paths[^1]);
        }

        public void SetCallback(string label, UnityAction callback)
		{
		}

		public void SetNestedCallback(string label, UnityAction callback)
		{
		}

		public void SetCallbackInt(string label, UnityAction<int> callback)
		{
		}

		public void SetCallbackFloat(string label, UnityAction<float> callback)
		{
		}

		public void SetCallbackVector2(string label, UnityAction<Vector2> callback)
		{
		}

		public void SetCallbackBool(string label, UnityAction<bool> callback)
		{
		}

		public void SetCallbackString(string label, UnityAction<string> callback)
		{
		}
	}
}
