using System;
using UnityEngine;

namespace YgomGame.Duel
{
	public class ManaSetManager : MonoBehaviour
	{
		private ManaSet prefab;

		private const string prefabPath = "Prefabs/Duel/ManaSet";

		public static ManaSetManager Create(Transform parent, Action<ManaSetManager> initializedCallback)
		{
			return null;
		}

		private void Initialize(Action onFinished)
		{
		}

		private ManaSet CreateManaSet()
		{
			return null;
		}

		public ManaSet GetManaSet()
		{
			return null;
		}

		public void ShowAll()
		{
		}

		public void HideAll()
		{
		}
	}
}
