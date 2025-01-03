using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common
{
	[DisallowMultipleComponent]
	public class BindingMateRenderTexture : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
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

		[SerializeField]
		private AvatarMotionSetting.MotionID m_BeginMotion;

		private GameObject m_RenderTextureTarget;

		private int m_RenderTextureTargetId;

		private uint m_CharacterPrefCrc;

		private Character m_Character;

		private uint m_SettingCrc;

		private RawImage m_RawImage;

		private bool m_Visible;

		private IEnumerator m_OnBindingRoutine;

		public string mateTransformSettingPath => null;

		public int mateId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool validMateId => false;

		public Character character => null;

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
