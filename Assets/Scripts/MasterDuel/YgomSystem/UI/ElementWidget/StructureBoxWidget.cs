using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomSystem.UI.ElementWidget
{
	public class StructureBoxWidget : ElementWidgetBase
	{
		public readonly Image deckImage;

		public readonly Image deckOpenedImage;

		public readonly RawImage[] cardImages;

		public readonly ExtendedTextMeshProUGUI nameText;

		public readonly SelectionButton button;

		private Image[] _monsterImages;

		public Action<StructureBoxWidget> onClickEvent;

		private bool _useNewDeckImage;

		private bool _useNewOpenedDeckImage;

		public int structureId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StructureBoxWidget(ElementObjectManager eom, Sprite deckSprite, Sprite openedDeckSprite, Sprite[] monsterSprites)
			: base(null)
		{
		}

		public StructureBoxWidget Binding(int structureId)
		{
			return null;
		}
	}
}
