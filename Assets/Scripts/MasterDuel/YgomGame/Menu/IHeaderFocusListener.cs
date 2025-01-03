using YgomSystem.UI;

namespace YgomGame.Menu
{
	public interface IHeaderFocusListener
	{
		void OnHeaderFocusChanged(bool setfocus, ViewController focusVc, ViewController prevVc);
	}
}
