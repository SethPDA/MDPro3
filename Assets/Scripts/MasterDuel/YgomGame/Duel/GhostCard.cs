using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Card;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class GhostCard : MonoBehaviour
	{
		private int cardID;

		private int sleeveID;

		private int rareID;

		private bool cardCreated;

		private GameObject cardParent;

		private CardModel card;

		private Vector3 targetPosition;

		private Quaternion targetCardRotation;

		private Color cardColor;

		private const float moveFactor = 0.8f;

		private const float rotFactor = 0.5f;

		private const float turnFactor = 0.8f;

		private const float powerFactor = 10f;

		private const float powerRotLimit = 30f;

		public bool isShowing
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

		public bool isActivate
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

		private Quaternion parentRotation => default(Quaternion);

		public static GhostCard Create(Transform parent)
		{
			return null;
		}

		public void Initialize()
		{
		}

		public void Setup(int cardID, int sleeveID, int rareID, Action onCreated = null)
		{
		}

		public void Terminate()
		{
		}

		private void TerminateCard()
		{
		}

		public void SetTargetPosition(Vector3 position, bool immediate)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetDisp(bool disp)
		{
		}

		public void SetActive(bool active)
		{
		}

		public void SetCardTargetRotation(Quaternion rotation, bool immediate)
		{
		}

		public SelectionButton SetupSelectionButton()
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
