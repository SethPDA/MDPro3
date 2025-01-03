using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public abstract class CardTextureManagerBase
	{
		protected class TexInfo
		{
			public Texture2D tex;

			public int refCount;

			public TexInfo(Texture2D tex)
			{
			}
		}

		protected static Texture2D m_DummyCard;

		protected const int CARD_INSTANCE_NUM_BASE = 128;

		protected const int CARD_INSTANCE_NUM_BASE_MOBILE = 128;

		protected const string DUMMYCARDPATH = "Card/dummyCard";

		protected CardTextureCreatorBase m_CardCreator;

		protected List<int> m_NoReferenceCardIdList;

		protected Queue<Texture2D> m_FreeTexInstances;

		protected Dictionary<int, TexInfo> m_CardIdTextureTable;

		protected Dictionary<int, Dictionary<int, UnityAction<Texture2D, bool>>> m_CallbackTable;

		protected bool m_EnableCache;

		protected int m_TaskIndex;

		protected string m_Tag;

		protected int m_CardInstanceNumBsae;

		protected int m_AddCardInstanceNum;

		public static Texture2D DUMMYCARD => null;

		protected int m_CardInstanceNum => 0;

		public int RefedTextureCount => 0;

		public int NoRefTextureCount => 0;

		public int TaskCount => 0;

		public int UsedInstanceCount => 0;

		public int FreeInstanceCount => 0;

		public int AllInstanceCount => 0;

		public int AddInstanceCount => 0;

		protected void Initialize()
		{
		}

		protected bool ExecuteCallback(int cardid, Texture2D cardpicture)
		{
			return false;
		}

		protected void ReduceNoReferenceData()
		{
		}

		public void SetCacheActive(bool enable)
		{
		}

		public void ClearCache()
		{
		}

		public void Release(int cardid, int taskid = 0)
		{
		}

		public void ReleaseAll()
		{
		}

		public void Destroy()
		{
		}

		public int GetCardTextureAsync(UnityAction<Texture2D, bool> onFinished, int cardid)
		{
			return 0;
		}

		public void SetCardQuality(CardQuality quality)
		{
		}

		public bool PreLoadCardPictureAsync(int cardid, bool force)
		{
			return false;
		}

		protected Texture2D GetTexInstance(int cardid, bool force = true)
		{
			return null;
		}

		protected void ResetTexInstance()
		{
		}

		protected void CreateTextureImpl(int cardid)
		{
		}

		protected void CancelTaskImpl(int cardid)
		{
		}

		protected void CardPictureDebugMessage(int cardid, bool isrelease)
		{
		}
	}
}
