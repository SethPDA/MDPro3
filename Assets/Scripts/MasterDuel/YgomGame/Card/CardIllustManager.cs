using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public class CardIllustManager
	{
		private class TexInfo
		{
			public Texture2D tex;

			public int refCount;

			public IllustLoadStep step;

			public int cardid;

			public List<UnityAction<Texture2D>> handlerList;

			public TexInfo(Texture2D texture = null)
			{
			}

			public void ChangeStep(IllustLoadStep step)
			{
			}
		}

		private class CallBackInfo
		{
			public UnityAction<Texture2D> callback;

			public Texture2D tex;

			public int cardid;

			public CallBackInfo(int cardid, UnityAction<Texture2D> callback, Texture2D tex)
			{
			}
		}

		private enum IllustLoadStep
		{
			WAIT = 0,
			LOADING = 1,
			END = 2
		}

		private const string BASEPATH = "Card/Images/";

		private const string DUMMYILLUSTPATH = "Card/dummyCard";

		private const string MrkZero = "0000";

		private Dictionary<uint, TexInfo> pathToTexDictionary;

		private Queue<CallBackInfo> loadCompleteCallBackQueue;

		private StringBuilder stringBuilder;

		private List<int> m_AsyncLoadQueue;

		public int CardIllustCount => 0;

		public static CardIllustManager Create()
		{
			return null;
		}

		public static void SetRichTextCardPath()
		{
		}

		public string GetPathByCardId(int mrk)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public bool UpdateIllustLoadProcess()
		{
			return false;
		}

		private bool AsyncLoadImpl()
		{
			return false;
		}

		private bool AsyncLoadComplete()
		{
			return false;
		}

		private void releaseAll()
		{
		}

		private void requestCompleteHandler(string path)
		{
		}

		public bool Release(int mrk)
		{
			return false;
		}

		public void ReleaseAll()
		{
		}

		public void Destroy()
		{
		}

		public void GetIllustAsync(UnityAction<Texture2D> handler, int cardid, bool immediateOnReuse = false)
		{
		}

		protected void RemoveCompleteCallbackByCardid(int cardid)
		{
		}

		protected void CardIllustDebugMessage(int cardid, bool isrelease)
		{
		}
	}
}
