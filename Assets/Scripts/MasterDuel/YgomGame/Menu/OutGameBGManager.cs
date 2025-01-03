using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class OutGameBGManager : MonoBehaviour
	{
		private class BGInfo
		{
			private int refCount;

			internal GameObject target;

			public BGInfo(GameObject target)
			{
			}

			public void AddCount()
			{
			}

			public void DecCount()
			{
			}

			public int GetCount()
			{
				return 0;
			}

			public void Disp(bool isDisp)
			{
			}

			public void EndTween()
			{
			}

			public void Remove()
			{
			}

			public BindingGameObjectEx GetBGOEX()
			{
				return null;
			}
		}

		private Dictionary<string, BGInfo> m_FrontBGInfoDic;

		private Dictionary<string, BGInfo> m_BackBGInfoDic;

		public Stack<string> m_FrontPathStack;

		public Stack<string> m_BackPathStack;

		internal GameObject m_Root;

		private GameObject m_FrontRoot;

		private GameObject m_BackRoot;

		private const string k_BGINIT = "BgInit";

		private const string k_BGIN = "BgIn";

		private const string k_BGOUT = "BgOut";

		private const int k_ORDER_LAYER1 = -990;

		private const int k_ORDER_LAYER2 = -970;

		public const int ID_BASE = 1;

		public const int ID_DUELPASS_GOLD = 2;

		public const int ID_DUELISTCUP = 4;

		public const int ID_WCS = 7;

		private static OutGameBGManager instance;

		public static OutGameBGManager Instance => null;

		public bool BGExist
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

		public bool IsCheckingBGExistance
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

		private void Initialize()
		{
		}

		public void SetOnTransitionStart(GameObject parent, ViewController.TransitionType type, int backBgID, bool async = true, float duration = 0.5f)
		{
		}

		public BindingGameObjectEx PushFrontBG(int frontID, bool async = true)
		{
			return null;
		}

		public BindingGameObjectEx PushFrontBG(string pathName, bool async = true)
		{
			return null;
		}

		public BindingGameObjectEx PushBackBG(int backID, bool async = true, float duration = 0.5f)
		{
			return null;
		}

		public BindingGameObjectEx PushBackBG(string pathName, bool async = true, float duration = 0.5f)
		{
			return null;
		}

		private void AddTweenInOut(string label, GameObject target, Color from, Color to, UnityAction onFinished = null, float duration = 0.5f)
		{
		}

		private void PlayTweenInOut(GameObject target, string label, float duration, bool wakeup = false)
		{
		}

		private void AddParticleTween(string label, GameObject target, float from, float to, float duration = 0.5f)
		{
		}

		private static void SetSortingOrder(GameObject target, int sortingBase)
		{
		}

		public void PopFrontBG()
		{
		}

		public void PopBackBG(float duration = 0.5f)
		{
		}

		public void PopAll()
		{
		}

		public bool isExistBackBG(string path)
		{
			return false;
		}

		public void DispRoot(bool activeSelf)
		{
		}

		public GameObject GetTopFrontBG()
		{
			return null;
		}

		public GameObject GetTopBackBG()
		{
			return null;
		}

		public string GetTopFrontBGPath(string defaultPath = "")
		{
			return null;
		}

		public string GetTopBackBGPath(string defaultPath = "")
		{
			return null;
		}

		public bool EqualTopBGPath(string backBGPath, string frontBGPath)
		{
			return false;
		}

		public int GetBackBGCount(int bgId)
		{
			return 0;
		}

		public static void PlayTweenShow(GameObject target, bool immediate = false)
		{
		}

		public static void PlayTweenHide(GameObject target, bool immediate = false)
		{
		}

		private static void PlayTween(GameObject target, string playLabel, bool immediate = false)
		{
		}

		public static bool IsPlayingShowHideTween(GameObject target)
		{
			return false;
		}

		public void CheckBGExistence()
		{
		}

		private IEnumerator CheckBGExistenceRoutine()
		{
			return null;
		}
	}
}
