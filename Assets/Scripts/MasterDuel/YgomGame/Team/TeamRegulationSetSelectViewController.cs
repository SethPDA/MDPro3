using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team
{
	public class TeamRegulationSetSelectViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
	{
		public class Param
		{
			public List<TeamUtil.RegulationSet> regulationSetList
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int selectedIndex
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Action<int> onResult
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private class TabButton
		{
			private string _title;

			internal ElementObjectManager tabTop
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal SelectionButton button
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal GameObject imageOn
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal GameObject imageOff
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal string[] itemStrings
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal int index
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

			internal bool active => false;

			internal string title
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal event Action<int, string[]> onSelected
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

			internal event Action onOkGoing
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

			internal TabButton(ElementObjectManager tabTop, int index, string buttonTitle, string[] values)
			{
			}

			internal void SetSelected(bool active)
			{
			}

			internal void Focus()
			{
			}
		}

		private const int SELECT_MAX = 3;

		private const int REGULATIONSET_MAX = 5;

		internal const string VC_PATH = "Team/TeamRegulationSetSelect";

		private Param _param;

		private int _prevSelectedIndex;

		private TabButton[] _tabButtons;

		private ExtendedTextMeshProUGUI _title;

		private ExtendedTextMeshProUGUI[] _reguHeadTxts;

		private ExtendedTextMeshProUGUI[] _reguValueTxts;

		private SelectionButton _decideBtn;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnTabSelected(int tabIndex, string[] values)
		{
		}

		private void SetupTabShortcut(GameObject target, UnityAction action)
		{
		}
	}
}
