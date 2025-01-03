namespace YgomGame.Shop
{
	public interface IMainTabListWidgetListener
	{
		void OnInputLeftMainTab();

		void OnInputRightMainTab();

		void OnInputUpMainTab();

		void OnInputDownMainTab();

		void OnClickMainTab(int idx);
	}
}
