using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DuelCursorJump : MonoBehaviour
	{
		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private DuelGameObjectManager goManager;

		private Selector selector;

		private SelectionButton openButton;

		private Image upIcon;

		private Image downIcon;

		private Image rightIcon;

		private Image leftIcon;

		private Image northIcon;

		private Image eastIcon;

		private Image southIcon;

		private Image westIcon;

		private Image profileNearIcon;

		private Image profileFarIcon;

		private Image mateNearIcon;

		private Image mateFarIcon;

		private bool isPlayableBgEffectNear;

		private bool isPlayableBgEffectFar;

		private bool reqOpen;

		private Func<bool> isOpenActive;

		private bool initialized;

		private const string prefabPath = "Prefabs/Duel/DuelCursorJump";

		public bool opening
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

		public static void Create(DuelGameObjectManager goManager, Func<bool> isOpenActiveFunc, Transform parent, Action<DuelCursorJump> finishCallback)
		{
		}

		private void Initialize(DuelGameObjectManager goManager)
		{
		}

		private void SelectItem(SharedDefinition.Location location, int position)
		{
		}

		public void Open()
		{
		}

		public void Close(bool force)
		{
		}

		private Vector2 GetPlaceScreenPoint(SharedDefinition.Location location, int position)
		{
			return default(Vector2);
		}

		private Vector2 GetMateScreenPoint(SharedDefinition.Location location)
		{
			return default(Vector2);
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetActive(bool active)
		{
		}
	}
}
