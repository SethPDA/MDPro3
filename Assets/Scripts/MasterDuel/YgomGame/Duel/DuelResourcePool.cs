using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Duel
{
	public class DuelResourcePool : MonoBehaviour
	{
		private const string shuffleDeckModelPath = "Duel/Models/DeckModelWrapper";

		private Dictionary<int, Texture2D> freeTextTurnChangeTexs;

		public SpriteContainer duelIcon
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

		public SpriteContainer counterIcon
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

		public bool isInitialized => false;

		public bool isTerminated
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

		public Dictionary<Engine.AffectType, Texture2D> affectIcons
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

		public GameObject shuffleDeckModel
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

		public static DuelResourcePool Create(DuelGameObjectManager goManager, GameObject root, string name)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Terminate()
		{
		}

		private void LoadDuelIconContainer()
		{
		}

		private void LoadCounterIconContainer()
		{
		}

		private void LoadShuffleDeckModel()
		{
		}

		public void GetFreeTextTurnChangeTex(int player, Action<Texture2D> onFinished)
		{
		}

		private IEnumerator GetFreeTextTurnChangeTexImpl(int player, Action<Texture2D> onFinished)
		{
			return null;
		}
	}
}
