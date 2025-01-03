using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.UI
{
	public class BindingTextLoader : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private Binding[] m_BindingTexts;

		private List<string> m_LoadTextGroups;

		private IEnumerator m_Routine;

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

		public void ProgressUpdate()
		{
		}

		private IEnumerator yRoutine()
		{
			return null;
		}

		private string GetGroupId(Binding target)
		{
			return null;
		}

		private string GetGroupId(BindingTextMeshProUGUI target)
		{
			return null;
		}

		private string GetGroupId(BindingTextMeshPro target)
		{
			return null;
		}

		private string GetGruopId(Binding binding, string textId)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
