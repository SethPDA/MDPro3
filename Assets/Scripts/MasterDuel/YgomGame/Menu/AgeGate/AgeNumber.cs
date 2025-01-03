using System.Runtime.CompilerServices;
using TMPro;

namespace YgomGame.Menu.AgeGate
{
	internal abstract class AgeNumber
	{
		public string[] selectList;

		protected const int NullIndex = -1;

		protected TMP_Text buttonText;

		public int currentIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isSelected => false;

		public AgeNumber()
		{
		}

		protected abstract int indexToValue(int index);

		protected abstract string getUnselectText();

		protected void updateButtonText()
		{
		}

		public int GetCurrentValue()
		{
			return 0;
		}

		public void AttachButtonText(TMP_Text textUI)
		{
		}

		public void ChangeIndex(int index)
		{
		}
	}
}
