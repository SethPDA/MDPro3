using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class BindingText : BindingTextBase<BindingText, MDText>
	{
		protected override string GetText(MDText target)
		{
			return null;
		}

		protected override void SetText(MDText target, string text)
		{
		}

		public BindingText()
		{
			//((BindingTextBase<, >)(object)this)._002Ector();
		}
	}
}
