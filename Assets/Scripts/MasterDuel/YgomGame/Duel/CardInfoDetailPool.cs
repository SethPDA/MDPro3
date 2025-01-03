using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class CardInfoDetailPool : MonoBehaviour
	{
		public class RelativeList
		{
			private GenericCardListEx m_Widget;

			private GenericScrollView m_ScrollView;

			public Action<int> onClickCard;

			public GenericCardListEx widget => null;

			public bool isStandby => false;

			public static void Create(Transform parent, Action<RelativeList> finishedCallback)
			{
			}

			private void OnClickCard(int mrk)
			{
			}
		}

		private static CardInfoDetailPool s_Instance;

		private Stack<CardInfoDetail> m_CardDetailPool;

		private Stack<CardInfoDetail> m_DownloadCardDetailPool;

		private Stack<RelativeList> m_RelativeListPool;

		private static CardInfoDetailPool instance => null;

		public static int GetReusableCount(bool flag)
		{
			return 0;
		}

		private void OnDestroy()
		{
		}

		public static void CreateOrReuse(Transform parent, Action finishedCallback, bool flag = false)
		{
		}

		private void InnerCreateOrReuse(Transform parent, Action finishedCallback, bool flag = false)
		{
		}

		public static void ReserveToReuse(Action finishedCallback, bool flag = false)
		{
		}

		private void InnerReserveToReuse(Action finishedCallback, bool flag = false)
		{
		}

		public static void ReturnToReuse(CardInfoDetail cardInfoDetail, bool flag = false)
		{
		}

		private void InnerReturnToReuse(CardInfoDetail cardInfoDetail, bool flag = false)
		{
		}

		public static void CreateOrReuseRelativeList(Transform parent, Action<RelativeList> finishedCallback)
		{
		}

		public static void ReturnToReuseRelative(RelativeList relativeList)
		{
		}
	}
}
