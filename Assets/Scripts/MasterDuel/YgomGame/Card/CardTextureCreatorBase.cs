using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public abstract class CardTextureCreatorBase : MonoBehaviour
	{
		public struct TaskDesc
		{
			public int cardid;

			public Texture2D tex;

			//public TaskDesc(int cardid, Texture2D tex)
			//{
			//}
		}

		protected const int MAXCARDPICTUREHEIGHT = 1054;

		protected const int MAXCARDPICTUREWIDTH = 723;

		public const int LAYER_CARDCREATOR = 9;

		public const int CARDWIDTH = 59;

		public const int CARDHEIGHT = 86;

		protected const float TARGETFRAME = 40f;

		public UnityAction<TaskDesc> onCancelTask;

		public UnityAction<TaskDesc> onReturnInstance;

		protected Dictionary<int, UnityAction<Texture2D>> m_CardidCallbackTable;

		protected Queue<TaskDesc> m_TaskQueue;

		protected TaskDesc m_StandByTask;

		protected Canvas m_CPCanvas;

		protected Camera m_CPCamera;

		protected RenderTexture m_RenderTexture;

		protected bool m_IsStandby;

		public RenderTexture renderTexture => null;

		protected float m_Compression => 0f;

		public CardQuality quality
		{
			[CompilerGenerated]
			get
			{
				return default(CardQuality);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetCardQuality(CardQuality quality)
		{
		}

		public void CreateTextureAsync(UnityAction<Texture2D> onfinished, int cardid, Texture2D tex)
		{
		}

		public void CancelAllTask()
		{
		}

		public void Initialize()
		{
		}

		public abstract void CancelCardPictureTask(int cardid);

		protected abstract void InitComponent();

		protected abstract void SetCanvas();

		protected abstract void SetCPRenderTexture();

		protected abstract bool CreateTaskImpl(TaskDesc desc);

		protected void SetCamera()
		{
		}

		protected void SetStandByTask(TaskDesc task)
		{
		}

		protected void CopyTexPixel()
		{
		}

		protected bool RemoveTaskFromQueueByCardid(int cardid)
		{
			return false;
		}
	}
}
