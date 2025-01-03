using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingCardMaterial : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private int m_CardId;

		[SerializeField]
		private int m_RareId;

		private bool m_IsMonochrome;

		private RawImage m_TargetCache;

		private bool m_LoadOnStart;

		public int cardId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int pRareType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isMonochrome
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private RawImage target => null;

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

		private void SetMatMonochrome(bool isMonochrome)
		{
		}

		public static BindingCardMaterial Binding(RawImage target, int cardId, int pRareType = 1)
		{
			return null;
		}

		private void Start()
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		public void ExecuteBinding()
		{
		}
	}
}
