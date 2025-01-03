using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Duel
{
	public class SummonInfoViewer : MonoBehaviour
	{
		private class Info
		{
			public GameObject root;

			public GameObject spSummonNG;

			public GameObject summonNG;

			public GameObject spSummonNGIcon;

			public GameObject summonNGIcon;

			public TMP_Text textSummonNum;

			public TMP_Text textTotalAtk;

			public bool isSpSummonNG;

			public bool isSummonNG;

			public int summonNum;

			public int totalAtk;
		}

		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private Dictionary<SharedDefinition.Location, Info> infoList;

		private Dictionary<SharedDefinition.Location, bool> dispDict;

		private Dictionary<SharedDefinition.Location, int> hideLockCounterDict;

		private const string prefabPath = "Prefabs/Duel/SummonInfoViewer";

		private Dictionary<GameObject, Queue<TweenConductor>> tweenConductors;

		public static void Create(Transform parent, Action<SummonInfoViewer> onLoaded)
		{
		}

		private void Initialize()
		{
		}

		private void SetupInfo(SharedDefinition.Location location, ElementObjectManager root)
		{
		}

		public void SetDisp(bool disp)
		{
		}

		private void SetDisp(SharedDefinition.Location location, bool disp)
		{
		}

		private bool IsHideLock(SharedDefinition.Location location)
		{
			return false;
		}

		public void SetInitializeParams(SharedDefinition.Location location, bool spSummonNG, bool summonNG, int summonNum)
		{
		}

		public void SetDispSPSummonNG(SharedDefinition.Location location, bool disp)
		{
		}

		public void SetDispSummonNG(SharedDefinition.Location location, bool disp)
		{
		}

		public void SetSummonNum(SharedDefinition.Location location, int num, bool showIfChanged)
		{
		}

		public void SetTotalAtk(SharedDefinition.Location location, int totalAtk)
		{
		}

		private void EnqueueTweenConductor(GameObject gameObject, TweenConductor tweenConductor)
		{
		}

		private void PlayQueuedTweenConductor(GameObject gameObject)
		{
		}
	}
}
