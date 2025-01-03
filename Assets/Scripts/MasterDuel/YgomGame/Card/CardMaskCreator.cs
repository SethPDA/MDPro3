namespace YgomGame.Card
{
	public class CardMaskCreator : CardTextureCreatorBase
	{
		private CardPictureTop m_CardPictureTopBase;

		public static CardMaskCreator CreateCardMaskCreator()
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
	}
}
