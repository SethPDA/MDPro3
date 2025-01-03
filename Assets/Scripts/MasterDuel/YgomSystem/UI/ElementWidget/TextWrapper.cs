using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget
{
	public class TextWrapper
	{
		private enum Mode
		{
			uGUI = 0,
			TMP = 1
		}

		private Mode mode;

		private MDText textComponent;

		private TMP_Text tmpTextComponent;

		public GameObject gameObject => null;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TextWrapper(MDText text)
		{
		}

		public TextWrapper(TMP_Text text)
		{
		}
	}
}
