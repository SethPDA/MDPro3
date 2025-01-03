using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class PlaceStatusManager
	{
		private GameObject root;

		private Object labelPrefab;

		private Object handLabelPrefab;

		public bool visibleAll
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

		public void Initialize(GameObject parent, GameObject labelPrefab, GameObject handLabelPrefab, GameObject rootPrefab)
		{
		}

		private PlaceStatusLabel Create()
		{
			return null;
		}

		private PlaceStatusLabel CreateHand()
		{
			return null;
		}

		public PlaceStatusLabel Use(SharedDefinition.Location location, bool lieDown, bool hand)
		{
			return null;
		}

		public void Unuse(PlaceStatusLabel instance)
		{
		}

		public void ShowAll()
		{
		}

		public void HideAll()
		{
		}

		public void Terminate()
		{
		}
	}
}
