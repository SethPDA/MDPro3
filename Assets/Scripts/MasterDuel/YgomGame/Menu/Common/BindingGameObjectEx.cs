using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingGameObjectEx : BindingGameObject, IAsyncProgressContent, ILoadingIconHandler
	{
		public enum FitMode
		{
			NONE = 0,
			SIZE = 1,
			SCALE = 2,
			SCALE_FIT_LOWEST = 3,
			SCALE_FIT_HIGHEST = 4,
			SCALE_FIT_IN_PARENT = 5,
			SCALE_ENVELOPE_PARENT = 6
		}

		private List<IAsyncProgressContent> m_AsyncProgressContents;

		public bool visible => false;

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

		public static BindingGameObjectEx Binding(GameObject target, string prefabPath, bool fitParentSize = false, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		public static BindingGameObjectEx Binding(GameObject target, string prefabPath, FitMode fitMode = FitMode.NONE, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		private static BindingGameObjectEx BindingFitModeNone(GameObject target, string prefabPath, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		private static BindingGameObjectEx BindingFitModeSize(GameObject target, string prefabPath, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		private static BindingGameObjectEx BindingFitModeScale(GameObject target, string prefabPath, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		private static BindingGameObjectEx BindingFitModeScaleLowestOrHighest(GameObject target, string prefabPath, bool isHighest, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		private static BindingGameObjectEx BindingFitModeScaleByParent(GameObject target, string prefabPath, bool envelopeParent, bool async = true, bool rebind = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		public new bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		protected void ClearProgressContent()
		{
		}

		protected void AssignProgressContent(IAsyncProgressContent progressContent)
		{
		}

		public static Vector3 CalcFitScale(FitMode fitMode, Vector2 parentSize, Vector2 childSize)
		{
			return default(Vector3);
		}

		protected override void PostModifiyByArgs(GameObject go)
		{
		}
	}
}
