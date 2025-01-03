using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common
{
	public class BindingMateCapture : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private int m_MateId;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_Rotation;

		[SerializeField]
		private Vector3 m_Scale;

		[SerializeField]
		[AssetPath]
		private string m_MateTransformSettingPath;

		[SerializeField]
		private bool m_UseTransformSetting;

		[SerializeField]
		private GameObject m_Locater;

		private RawImage m_RawImageCache;

		private bool m_Visible;

		private IEnumerator m_OnBindingRoutine;

		public string mateTransformSettingPath => null;

		public bool validSource => false;

		public RawImage rawImage => null;

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action onReloadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool IsDone()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void VisibleRefresh()
		{
		}

		public void SourceChanged()
		{
		}

		public void OnRebind()
		{
		}

		public void ProgressUpdate()
		{
		}

		private IEnumerator yOnBindingRoutine()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
