using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class BindingEventLogo : MonoBehaviour//, IAsyncProgressContainer, ILoadingIconHandler
	{
		public enum PrefabType
		{
			NONE = 0,
			TYPE = 1,
			ATTRIBUTE = 2
		}

		[Serializable]
		public class Context
		{
			public PrefabType prefabType;

			public int logoId;

			public List<int> subIds;

			public bool isLarge;

			public bool IsEqualSubIds(Context other)
			{
				return false;
			}

			public void Import(Context other)
			{
			}
		}

		[SerializeField]
		private Context eventLogoContext;

		private bool onLoadStart;

		private GameObject bindChild;

		private ElementObjectManager bindEom;

		private bool m_Visible;

		private List<IAsyncProgressContent> m_AsyncProgressContents;

		public Context EventLogoContext => null;

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

		private IReadOnlyList<IAsyncProgressContent> YgomGame_002EMenu_002ECommon_002EIAsyncProgressContainer_002EasyncProgressContents => null;

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

		public static BindingEventLogo Binding(GameObject target, Context context)
		{
			return null;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateData(Context context)
		{
		}

		public void Load(bool isEqualPrefab, bool isEqualLogo, bool isEqualSubIds, bool isEqualIsLarge)
		{
		}

		private void BindEventLogoMonster(GameObject parent, Context context)
		{
		}

		public bool IsDone()
		{
			return false;
		}

		private void RefreshVisible()
		{
		}

		private void ClearProgressContents()
		{
		}

		private void AssignProgressContent(IAsyncProgressContent progressContent)
		{
		}
	}
}
