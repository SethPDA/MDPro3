using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class FaceDownCardEffectPool : MonoBehaviour
	{
		private enum Step
		{
			WaitPrefabLoad = 0,
			WaitInstantiate = 1,
			Idle = 2,
			Terminating = 3
		}

		private const string PREFABPATH = "Duel/Effects/Buff/fxp_bff_disquiet/fxp_bff_disquiet_001";

		private List<Dictionary<int, GameObject>> m_EffectList;

		private List<Dictionary<int, bool>> m_EffectVisibleList;

		private Step m_Step;

		private bool isInstantiated;

		private GameObject m_Prefab;

		public bool isInitialized
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

		public DuelGameObjectManager goManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static FaceDownCardEffectPool Create(DuelGameObjectManager goManager, GameObject root, string name)
		{
			return null;
		}

		protected void Initialize()
		{
		}

		private void Update()
		{
		}

		protected void WaitPrefabLoad()
		{
		}

		private IEnumerator InstantiateProcess()
		{
			return null;
		}

		protected void WaitInstantiateStep()
		{
		}

		protected void IdleStep()
		{
		}

		protected void TerminateStep()
		{
		}

		private void UpdateEffect(int player, int position)
		{
		}

		private void UpdateAllEffect(bool forcehide = false)
		{
		}

		private void SetEffectVisible(int player, int position, bool visible)
		{
		}

		public void RemoveFaceDownCardEffect(int player, int position, bool temporary = false)
		{
		}

		public void UpdateFaceDownCardEffect(int player, int position)
		{
		}

		public void UpdateFaceDownEffectTable(bool forcehide = false)
		{
		}

		public void Terminate()
		{
		}
	}
}
