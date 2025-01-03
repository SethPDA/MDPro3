using MDPro3;
using System;
using UnityEngine;

namespace Willow
{
	public class SoundEffectFromName : MonoBehaviour
	{
		private float m_timeScale;

		private int[] m_soundIds;

		[SerializeField]
		private bool m_playOneTime;

		[SerializeField]
		private bool m_donePlay;

		[SerializeField]
		private bool m_useCustomTarget;

		[SerializeField]
		private GameObject m_customTarget;

		private string m_targetName;

		private string m_prevTargetName;

		public string targetName
		{
			private get
			{
				return "SE_" + gameObject.name.Replace("(Clone)", "");
			}
			set
			{
			}
		}

		public bool playOneTime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool donePlay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
			AudioManager.PlaySE(targetName.ToUpper());
		}

		private void OnDisable()
		{
		}

		private void PlayEffect(Action<int[]> callback)
		{
		}

		private void OnPlayEffect(int[] ids)
		{
		}
	}
}
