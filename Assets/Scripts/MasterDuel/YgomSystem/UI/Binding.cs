using UnityEngine;

namespace YgomSystem.UI
{
	public abstract class Binding : MonoBehaviour
	{
		public enum Mode
		{
			OneTime = 0,
			OneWay = 1,
			OneWayToSource = 2,
			TwoWay = 3
		}

		[SerializeField]
		public Mode mode;

		public abstract void OnRebind();

		public abstract bool OnBinding();

		public virtual void Start()
		{
		}

		private void Update()
		{
		}

		public void SourceChanged()
		{
		}

		public void TargetChanged()
		{
		}

		public void UpdateBinding()
		{
		}
	}
}
