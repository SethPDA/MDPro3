using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class OutgameBackBGController : MonoBehaviour
	{
		private static OutgameBackBGController k_Instance;

		private Dictionary<ViewController, int> m_Owners;

		private string m_RecoveryBgPath;

		private static OutgameBackBGController GetOrCreateInstance()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void Regist(ViewController vc)
		{
		}

		public static void Unregist(ViewController vc)
		{
		}

		public static void Set(ViewController vc, int bgId)
		{
		}

		private void ApplyBg(ViewController vc)
		{
		}

		public void RecoveryBg()
		{
		}

		public void OnTransitionStart(ViewController.TransitionType type, ViewController vc, ViewController preVc)
		{
		}
	}
}
