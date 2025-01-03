using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Card
{
	public class CardPictureCreator : CardTextureCreatorBase
	{
		private const int MAXRETRYCOUNT = 10;

		private CardIllustManager m_CardIllustManager;

		protected CardPicture m_CardPictureBase;

		protected Dictionary<int, Texture2D> m_TaskQueue_WaitStandby;

		protected Dictionary<int, int> m_RetryCountTable;

		protected bool m_NoneCallBackStandbyFlag;

		public bool m_IgnoreIllsut;

		public static CardPictureCreator CreateCardPictureCreator(CardIllustManager cardIllustManager)
		{
			return null;
		}

		protected override bool CreateTaskImpl(TaskDesc desc)
		{
			return false;
		}

		protected override void InitComponent()
		{
		}

		protected override void SetCanvas()
		{
		}

		protected override void SetCPRenderTexture()
		{
		}

		private void Update()
		{
		}

		public override void CancelCardPictureTask(int cardid)
		{
		}

		private void SetupCardAsyncCallback(TaskDesc desc)
		{
		}
	}
}
