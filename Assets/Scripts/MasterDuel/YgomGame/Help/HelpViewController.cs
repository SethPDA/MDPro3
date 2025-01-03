using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Help
{
	public class HelpViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		private class SectionContext
		{
			public string text;

			public string groupLabel;

			public string sectionLabel;
		}

		private class SectionWidget : ElementWidgetBase
		{
			private readonly string k_ELabelText;

			private readonly string k_ELabelButton;

			private readonly string k_ELabelOn;

			private readonly string k_ELabelOff;

			public readonly TextMeshProUGUI text;

			public readonly SelectionButton button;

			private readonly string k_ELabelOffText;

			public readonly TextMeshProUGUI textOff;

			public event Action<SectionWidget> onClickEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event Action<SectionWidget> onSelectedEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event Action<SectionWidget> onRightEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event Action<SectionWidget> onLeftEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public SectionWidget(ElementObjectManager eom)
				: base(null)
			{
			}

			public void SetIsOn(bool isOn)
			{
			}

			private void OnClick()
			{
			}

			private void OnSelected()
			{
			}

			private void OnRight()
			{
			}

			private void OnLeft()
			{
			}
		}

		private class RecordContext
		{
			public string text;

			public string path;
		}

		private class RecordWidget : SectionWidget
		{
			public RecordWidget(ElementObjectManager eom)
				: base(null)
			{
			}
		}

		private readonly string k_ELabelSectionList;

		private readonly string k_ELabelRecordList;

		private readonly string k_ElabelBackShortCutbutton;

		private bool m_nowRecordSelected;

		private readonly int k_SectionGroupTNo;

		private readonly int k_SectionButtonTNo;

		private readonly int k_SectionSpacerTNo;

		private HelpMappingData m_HelpMapping;

		private InfinityScrollView m_SectionScrollView;

		private Selector m_SectionSelector;

		private List<SectionContext> m_SectionContexts;

		private List<int> m_SectionTemplates;

		private Dictionary<GameObject, SectionWidget> m_SectionEntityMap;

		private InfinityScrollView m_RecordScrollView;

		private List<RecordContext> m_RecordContexts;

		private Dictionary<GameObject, RecordWidget> m_RecordEntityMap;

		private List<string> m_LoadedTextGroups;

		private int m_CurrentSectionIdx;

		protected override Type[] textIds => null;

		public static void Open()
		{
		}

		public static void OpenHelp(string labelPath, Action callback = null, bool isOverlay = true, Dictionary<string, object> args = null)
		{
		}

		public static void OpenHelp(string groupLabel, string sectionLabel, string recordLabel, Action callback = null, bool isOverlay = true, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void SelectSection(int sectionIdx)
		{
		}

		private string GetTextData(string sourceTextId)
		{
			return null;
		}

		private void OnCreatedSectionEntity(GameObject entity)
		{
		}

		private bool IsSelectableDataIndex(int dataindex)
		{
			return false;
		}

		private void OnUpdateSectionEntity(GameObject entity, int idx)
		{
		}

		private void OnClickSectionEntity(SectionWidget sectionWidget)
		{
		}

		private void OnSelectedSectionEntity(SectionWidget sectionWidget)
		{
		}

		private void OnCreatedRecordEntity(GameObject entity)
		{
		}

		private void OnUpdateRecordEntity(GameObject entity, int idx)
		{
		}

		private void OnClickRecordEntity(SectionWidget recordWidget)
		{
		}

		private void OnLeftRecordEntity(SectionWidget sectionWidget)
		{
		}
	}
}
