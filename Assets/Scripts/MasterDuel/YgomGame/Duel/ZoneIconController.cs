using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public abstract class ZoneIconController
	{
		protected class IconInfo
		{
			public bool available;

			public DuelEffectPool.Type effectTypeIcon;

			public SimpleEffect effect;

			public Material rollover;

			public Material rolloverCard;
		}

		protected Dictionary<int, Dictionary<int, IconInfo>> availableList;

		protected RunEffectWorker worker;

		protected virtual bool useCardEffect => false;

		public void Initialize()
		{
		}

		public void Terminate()
		{
		}

		public bool Activate(int player, int position, bool ignoreCard = false)
		{
			return false;
		}

		protected IconInfo CreateEffect(int player, int position, bool ignoreCard)
		{
			return null;
		}

		public void Show(int player, int position)
		{
		}

		public void ShowAvailableZone()
		{
		}

		public void Hide(int player, int position)
		{
		}

		public void DeactivateAll()
		{
		}

		public bool IsActivated(int player, int position, bool transEx = false)
		{
			return false;
		}

		public void SetStatus(int player, int position, bool selected)
		{
		}

		private void SetStatus(IconInfo info, bool selected)
		{
		}

		public void SetStatusAll(bool selected)
		{
		}

		public (int, int) GetHighPriorityAvailableZone()
		{
			return default((int, int));
		}
	}
}
