using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu
{
	public class Inform : MonoBehaviour
	{
		public enum PrefType
		{
			Toast = 0
		}

		private static Inform s_Instance;

		[SerializeField]
		private ToastMessageInform m_ToastPref;

		private List<InformContentBase> m_SearchContentList;

		public static Inform Instance => null;

		private InformContentBase GetPref(PrefType prefType)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void Push(PrefType prefType, Dictionary<string, object> args)
		{
		}

		public static IReadOnlyList<InformContentBase> SearchContents()
		{
			return null;
		}
	}
}
