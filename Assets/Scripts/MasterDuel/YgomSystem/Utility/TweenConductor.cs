using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	internal class TweenConductor : MonoBehaviour
	{
		public bool playOnStart;

		public bool destroyOnFinished;

		[SerializeField]
		private GameObject target;

		[SerializeField]
		private List<string> labelList;

		[SerializeField]
		private UnityEvent<string> onStarted;

		[SerializeField]
		private UnityEvent<string> onFinished;

		[SerializeField]
		private UnityEvent onCompleted;

		private bool playing;

		private int currentLabelIndex;

		private string currentLabel;

		private List<Tween> tweens;

		public static TweenConductor Create(GameObject addComponentTarget, GameObject target, List<string> labelList, UnityAction<string> onStarted, UnityAction<string> onFinished, UnityAction onCompleted)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void PlayStart()
		{
		}

		private void Update()
		{
		}

		private bool IsPlaying(string label)
		{
			return false;
		}

		private void Play(string label)
		{
		}
	}
}
