using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelCountDown : MonoBehaviour
	{
		private static DuelCountDown m_Instance;

		private static Queue<int> m_TaskQueue;

		[SerializeField]
		private int m_FontSize_Text;

		[SerializeField]
		private int m_FontSize_Number;

		[SerializeField]
		private Color m_FontColor;

		[SerializeField]
		private int m_CountDownStartLine;

		[SerializeField]
		private int[] m_CountDownShowUpTime;

		private ElementObjectManager m_Eom;

		private ExtendedTextMeshProUGUI m_CountDownText;

		private string m_Str_RestTime;

		private string m_Str_Seconds;

		public static void Create(Transform parent)
		{
		}

		public static void AddCountDownCmd(int number)
		{
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		private void ShowCountDownImpl(int number)
		{
		}
	}
}
