using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public static class CardRunEffect
	{
		private static string settingPath;

		public static CardRunEffectSetting setting;

		private static DuelGameObjectManager goManager;

		private static CardRunEffectSetting.CardRunEffectInfo reservedEffect;

		public static bool isReady
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

		public static bool isReserved => false;

		public static void LoadSetting(Action loaded_callback, DuelGameObjectManager go_manager)
		{
		}

		public static void LoadEffect(int mrk, CardRunEffectSetting.Player player, Action<CardRunEffectSetting.CardRunEffectInfo> onLoaded)
		{
		}

		public static bool ReserveEffect(int mrk, CardRunEffectSetting.Player player, Vector3 position)
		{
			return false;
		}

		public static bool PlayOnChainRun(CardRunEffectSetting.Player player, Vector3 position, Action on_stop = null)
		{
			return false;
		}

		public static bool PlayOnCardBreak(CardRunEffectSetting.Player player, Vector3 position, Action on_stop = null)
		{
			return false;
		}

		public static bool PlayOnCardMove(CardRunEffectSetting.Player player, Vector3 position, Action on_stop = null)
		{
			return false;
		}

		public static CardRunEffectSetting.CardRunEffectInfo GetOnSpecialFxInfo()
		{
			return null;
		}

		public static bool PlayOnCardDisable(CardRunEffectSetting.Player player, Vector3 position, Action on_stop = null)
		{
			return false;
		}

		public static void OnChainEnd()
		{
		}

		public static int GetRerservedEffectCardID()
		{
			return 0;
		}

		public static CardRunEffectSetting.RunTiming GerReservedEffectPlayTiming()
		{
			return default(CardRunEffectSetting.RunTiming);
		}

		private static bool Play(CardRunEffectSetting.Player player, CardRunEffectSetting.CardRunEffectInfo info, Vector3 position, Action on_stop)
		{
			return false;
		}

		public static bool PlayEffect(CardRunEffectSetting.Player player, CardRunEffectSetting.PlayType playType, string effectPath, int effectType, float delay, CardRunEffectSetting.RotationType rotationType, Vector3 pivot, CardRunEffectSetting.ExtraSetting extraSetting, Vector3 position, Action onStop, CardRoot targetCard = null)
		{
			return false;
		}

		private static void OnStop(CardRunEffectSetting.Player player, CardRunEffectSetting.ExtraSetting extraSetting)
		{
		}

		public static void PlaySE(string seLabel, bool is3D, Vector3 position)
		{
		}

		private static void ApplyExtraSettingPositionActivation(Transform effect, CardRunEffectSetting.Player player)
		{
		}

		private static void ApplyExtraSettingCardAttackPosition(Transform effect, bool isAttack)
		{
		}

		private static void ApplyChangeLayerMagic(CardRunEffectSetting.Player player, bool onStart)
		{
		}

		private static void ApplyChangeLayerDuelOver3D(GameObject effect)
		{
		}

		public static bool IsExist(int cardID, CardRunEffectSetting.Player player)
		{
			return false;
		}

		public static bool IsExist(int cardID)
		{
			return false;
		}

		public static bool IsEssential(int cardID, CardRunEffectSetting.Player player)
		{
			return false;
		}

		public static bool IsEssential(int cardID)
		{
			return false;
		}
	}
}
