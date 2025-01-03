using System;
using TMPro;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	public class CountdownTimeText : MonoBehaviour
	{
		private TMP_Text m_TargetText;

		private long m_LimitUnixTime;

		private long m_LastUpdatedUnixTime;

		private Action<TMP_Text, long> m_TextUpdateCallback;

		public static CountdownTimeText Attach(TMP_Text target, long limitUnixTime, Action<TMP_Text, long> textUpdateCallback)
		{
			return null;
		}

		public static void Detach(TMP_Text target, bool isDestroy = true)
		{
		}

		public TimeSpan GetTimeSpan()
		{
			return default(TimeSpan);
		}

		private void LateUpdate()
		{
		}

		public static void SetClampedMinutesRemainText(TMP_Text targetText, long remainSec)
		{
		}

		public static void SetClampedDaysRemainText(TMP_Text targetText, long remainSec)
		{
		}

		public static string GetClampedDaysRemainText(long remainSec)
		{
			return null;
		}
	}
}
