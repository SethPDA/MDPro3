using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public class AutoReleaseCardMaterial : MonoBehaviour
	{
		public enum InstanceType
		{
			None = 0,
			RawImage = 1,
			MeshRenderer = 2
		}

		public Func<bool> IdleWhenInvisible;

		private CardMaterialManager cardMaterialManager;

		private int m_Cardid;

		private int m_Finishid;

		private bool m_ResetMatWhenVisible;

		private InstanceType m_Type;

		private float m_FakeBlendCache;

		private UnityAction m_OnFinish;

		public bool Initialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private bool m_IsVisible => false;

		private Material m_Material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Initialize(CardMaterialManager cardMaterialManager, bool isResetParent)
		{
		}

		public void UpdateMateriaInfo(int cardid, int finishid, InstanceType type, UnityAction onFinish)
		{
		}

		private void OnBecameVisible()
		{
		}

		private void OnBecameInvisible()
		{
		}

		private void SetCardPicture()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
