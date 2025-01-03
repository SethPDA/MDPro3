using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Solo
{
	//[CreateAssetMenu]
	public class SoloFlyingCardSettings : ScriptableObject
	{
		[Serializable]
		public class MrkList
		{
			[SerializeField]
			private List<int> mrkList;

			private bool Contains(int mrk)
			{
				return false;
			}

			public void Add(int mrk)
			{
			}

			public List<int> GetListCopy()
			{
				return null;
			}

			public IEnumerable<int> GetRandomMrkFromList(int quantity = 10)
			{
				return null;
			}

			public void ClearAll()
			{
			}
		}

		public enum Format
		{
			SOLO_TUTORIAL = 0,
			SOLO_NORMAL = 1
		}

		[SerializeField]
		private MrkList soloTutorialMrkList;

		[SerializeField]
		private MrkList soloNormalMrkList;

		public MrkList GetMrkList(Format format)
		{
			return null;
		}
	}
}
