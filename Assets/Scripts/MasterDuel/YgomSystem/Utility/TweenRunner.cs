using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	public class TweenRunner : MonoBehaviour
	{
		[Serializable]
		public class TweenGroup
		{
			[SerializeField]
			private string m_Label;

			[SerializeField]
			private List<Tween> m_Tweens;

			public string label
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public List<Tween> tweens => null;
		}

		[SerializeField]
		private List<TweenGroup> m_TweenGroups;

		[SerializeField]
		private string m_PlayLabel;

		public void TweenCollect(bool includeChildren = false)
		{
		}

		public List<Tween> TryGetTweens(string label)
		{
			return null;
		}

		public void Evaluate(string playLabel)
		{
		}

		public void PlayOverride(string playLabel)
		{
		}
	}
}
