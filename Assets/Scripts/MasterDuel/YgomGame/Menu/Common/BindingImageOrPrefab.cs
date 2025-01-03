using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingImageOrPrefab : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private string m_Path;

		[SerializeField]
		private AspectRatioFitter.AspectMode m_ImageAspectMode;

		[SerializeField]
		private BindingGameObjectEx.FitMode m_PrefabFitMode;

		private uint m_Crc;

		private IEnumerator m_SequenceRoutine;

		private Action<BindingImageOrPrefab> m_HandleOnFailedCallback;

		public string path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AspectRatioFitter.AspectMode imageAspectMode
		{
			get
			{
				return default(AspectRatioFitter.AspectMode);
			}
			set
			{
			}
		}

		public BindingGameObjectEx.FitMode prefabFitMode
		{
			get
			{
				return default(BindingGameObjectEx.FitMode);
			}
			set
			{
			}
		}

		public bool visible => false;

		public bool handleOnFailed => false;

		public Action<BindingImageOrPrefab> handleOnFailedCallback
		{
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

		private void Update()
		{
		}

		public void ProgressUpdate()
		{
		}

		private IEnumerator ySequence()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void SwitchTargetActivate(bool isPref)
		{
		}

		private void SourceChange()
		{
		}
	}
}
