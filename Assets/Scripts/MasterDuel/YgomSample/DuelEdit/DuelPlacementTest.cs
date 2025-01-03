using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSample.DuelEdit
{
	public class DuelPlacementTest : MonoBehaviour
	{
		[SerializeField]
		private CameraViewSetting cameraViewSetting;

		[SerializeField]
		private Transform objectsParent;

		[SerializeField]
		private GameObject cardPrefab;

		[SerializeField]
		private GameObject nearFieldPrefab;

		[SerializeField]
		private GameObject farFieldPrefab;

		[SerializeField]
		private float matOffset;

		private GameObject nearMat;

		private GameObject farMat;

		public List<GameObject> cards
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

		public void SetupObjects()
		{
		}

		public void ClearObjects()
		{
		}
	}
}
