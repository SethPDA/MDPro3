using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class GraveCardPlace : CardPlace
	{
		private GameObject anchor;

		private SharedDefinition.Location location;

		private PlaceStatusLabel statusLabel;

		private int localCardNum;

		private bool showDetailStatus;

		private GhostCard topCardGhost;

		private bool effectActivation;

		private int topCardID;

		private int topCardUniqueID;

		private bool topCardFace;

		public GraveCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor, SharedDefinition.Location location)
			: base(null, 0, 0)
		{
		}

		protected override void OnPrepareToDuel(bool startAtZero, Action onFinished)
		{
		}

		protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return null;
		}

		protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return false;
		}

		protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		private void UpdatePopUpText()
		{
		}

		private void UpdateTopCardInfo()
		{
		}

		protected override void OnUnregister(CardRoot cardRoot, int index)
		{
		}

		public override void Terminate()
		{
		}

		public override void OnUpdate()
		{
		}

		public void SyncToEngine(Dictionary<string, object> savedEngineParams, Action onFinished, int num = 0)
		{
		}

		protected override void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
		{
		}

		protected override void ReqDecideEffectImpl(int index, Action onFinished)
		{
		}

		public void ShowStatusLabel(bool immediate, bool showDetail)
		{
		}

		public void HideStatusLabel(bool immediate, bool finishDetail = false)
		{
		}

		protected override void SetupCardLocator(CardLocator cardLocator)
		{
		}

		public override void OnSelected()
		{
		}

		public override void OnDeselected()
		{
		}
	}
}
