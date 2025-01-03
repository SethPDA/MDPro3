using YgomSystem.UI;

namespace YgomGame.Shop
{
	public interface ISubTabListWidgetListener
	{
		bool OnInputDirectionSubCategory(PadInputDirection direction);

		void OnClickSubCategory(int dataIdx);

		void OnClickSubCategoryGroup(int dataIdx);

		void OnClickSubCategorySection(int dataIdx, int sectionIdx);
	}
}
