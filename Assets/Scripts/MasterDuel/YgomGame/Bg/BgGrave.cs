using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Bg
{
	public class BgGrave : MonoBehaviour
	{
		public enum GraveType
		{
			None = 0,
			Common = 1,
			Unique = 2
		}

		private enum ParticleEffectIdx
		{
			GraveIn = 0,
			GraveInend = 1,
			GraveOut = 2,
			GraveOutend = 3,
			ExcludeIn = 4,
			ExcludeInend = 5,
			ExcludeOut = 6,
			ExcludeOutend = 7,
			GraveIdleS1 = 8,
			GraveIdleS2 = 9,
			GraveIdleS3 = 10,
			ExcludeIdleS1 = 11,
			ExcludeIdleS2 = 12,
			ExcludeIdleS3 = 13,
			Max = 14
		}

		private class GraveParticle
		{
			public ParticleSystem effect;

			public BgEffectSettingInner setting;
		}

		private class GraveEffect
		{
			private Action start;

			private Action<float> update;

			private Action end;

			private float targetTime;

			private float time;

			public string name;

			public bool remove;

			public GraveEffect(Action startFunc, Action<float> updateFunc, Action endFunc, float target)
			{
			}

			public void Update()
			{
			}
		}

		private const string posGraveLabel = "POS_Grave";

		private const string posExclueLabel = "POS_Exclude";

		private const string meshElementLabel01 = "Material01";

		private const string graveHighlightAnimatorLabelBase = "GraveHighlight";

		private const string excludeHighlightAnimatorLabelBase = "ExcludeHighlight";

		private const string highlightTriggerName = "On";

		private const string graveMouseOverPropertyName = "_GraveMouseOver";

		private const string excludeMouseOverPropertyName = "_ExcludeMouseOver";

		private const string gravePressButtonPropertyName = "_GravePressButton";

		private const string excludePressButtonPropertyName = "_ExcludePressButton";

		private const string graveExistPropertyName = "_GraveCardExist";

		private const string excludeExistPropertyName = "_ExcludeCardExist";

		private const string graveInElementLabel = "GraveIn";

		private const string graveInendElementLabel = "GraveInend";

		private const string graveOutElementLabel = "GraveOut";

		private const string graveOutendElementLabel = "GraveOutend";

		private const string excludeInElementLabel = "ExcludeIn";

		private const string excludeInendElementLabel = "ExcludeInend";

		private const string excludeOutElementLabel = "ExcludeOut";

		private const string excludeOutendElementLabel = "ExcludeOutend";

		private const string graveIdleS1ElementLabel = "GraveIdleS1";

		private const string graveIdleS2ElementLabel = "GraveIdleS2";

		private const string graveIdleS3ElementLabel = "GraveIdleS3";

		private const string excludeIdleS1ElementLabel = "ExcludeIdleS1";

		private const string excludeIdleS2ElementLabel = "ExcludeIdleS2";

		private const string excludeIdleS3ElementLabel = "ExcludeIdleS3";

		private const float particleEffectWait = 0.5f;

		private const float materialUpdateWait = 0.05f;

		private const float cardExistMaterialUpdateWait = 0.5f;

		private Dictionary<string, Renderer> renderers;

		private Animator excludeHighlightAnimator;

		private Animator graveHighlightAnimator;

		public GameObject posGrave;

		public GameObject posExclude;

		private GraveParticle[] particleEffect;

		private List<GraveEffect> effectUpdateList;

		private List<GraveEffect> removeEffectUpdateList;

		private void SetParticleEffect(ParticleEffectIdx startIdx, ParticleEffectIdx endIdx)
		{
		}

		private void ChangeMaterialProperty(string meshLabel, string propertyName, float start, float end, float target)
		{
		}

		private void SetAnimaterTrigger(Animator animator, string start, string end, float target = 0.5f)
		{
		}

		public static BgGrave Create(GameObject res, Transform root, BgUnit.Side side)
		{
			return null;
		}

		private void Initialize(BgUnit.Side side)
		{
		}

		private void Update()
		{
		}

		private void EffectUpdate()
		{
		}

		public void SetBgGrave(int player, int position, bool cardIn)
		{
		}

		private void SetBgGraveInner(int position, int num, bool cardIn)
		{
		}

		public void SetBgGraveHighlight(bool flg)
		{
		}

		public void OnCursorEnterGrave()
		{
		}

		public void OnCursorExitGrave()
		{
		}

		public void OnSelectPressedGrave()
		{
		}

		public void OnSelectReleasedGrave()
		{
		}

		public void OnCardIntoGrave()
		{
		}

		public void OnCardInGrave(bool flg)
		{
		}

		public void OnCardOutGrave(int num)
		{
		}

		public void OnCursorEnterExclude()
		{
		}

		public void OnCursorExitExclude()
		{
		}

		public void OnSelectPressedExclude()
		{
		}

		public void OnSelectReleasedExclude()
		{
		}

		public void OnCardIntoExclude()
		{
		}

		public void OnCardInExclude(bool flg)
		{
		}

		public void OnCardOutExclude(int num)
		{
		}
	}
}
