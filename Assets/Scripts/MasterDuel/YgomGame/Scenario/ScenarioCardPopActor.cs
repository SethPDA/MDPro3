using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario
{
	public class ScenarioCardPopActor : ElementWidgetBase
	{
		private readonly string k_ELabelSprite;

		private readonly string k_ELabelSubSprite;

		private const string k_PopResourceFormat = "Scenarios/CardPop/<_CARD_ILLUST_>/CardPop{0:D4}";

		public readonly SpriteRenderer spriteRenderer;

		public readonly SpriteRenderer subSpriteRenderer;

		private int m_LoadingCnt;

		public int mrk
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

		public int subMrk
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

		public bool ready => false;

		public ScenarioCardPopActor(ElementObjectManager eom)
			: base(null)
		{
		}

		public static string GetCardPopPath(int mrk)
		{
			return null;
		}

		public override void Clear()
		{
		}

		public void ClearSub()
		{
		}

		public void CaptureSub()
		{
		}

		public void Binding(int mrk)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void HideFront()
		{
		}
	}
}
