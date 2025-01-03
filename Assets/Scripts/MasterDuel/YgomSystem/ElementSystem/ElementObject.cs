using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.ElementSystem
{
	public class ElementObject : MonoBehaviour
	{
		public string label;

		public UnityAction callbackVoid;

		public UnityAction<int> callbackInt;

		public UnityAction<float> callbackFloat;

		public UnityAction<Vector2> callbackVector2;

		public UnityAction<string> callbackString;

		public UnityAction<bool> callbackBool;

		public ElementObjectManager parentManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void OnValidate()
		{
		}

		public void Setup()
		{
		}

		public void ElementCallback()
		{
		}

		public void ElementCallback(float value)
		{
		}

		public void ElementCallback(int value)
		{
		}

		public void ElementCallback(Vector2 value)
		{
		}

		public void ElementCallback(string value)
		{
		}

		public void ElementCallback(bool value)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
