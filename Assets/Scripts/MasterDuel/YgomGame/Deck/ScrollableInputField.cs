using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class ScrollableInputField : MonoBehaviour
	{
		public ExtendedInputField targetInputField;

		public MDText cardNameText;

		[SerializeField]
		private Button _maskButton;

		public UnityEvent OnFocus;

		private void Start()
		{
		}
	}
}
