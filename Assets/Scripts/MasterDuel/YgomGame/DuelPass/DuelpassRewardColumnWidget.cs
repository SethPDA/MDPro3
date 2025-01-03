using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duelpass
{
	public class DuelpassRewardColumnWidget
	{
		private TMP_Text gradeText;

		private DuelpassRewardButtonWidget normalRewardButton;

		private DuelpassRewardButtonWidget goldRewardButton;

		public int ScrollEntityIdx
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

		public int Grade
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

		public TweenColorTo GradeTextColor
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

		public TweenColorTo GradeTextBase
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

		public GameObject TextColor
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

		public GameObject BaseColor
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

		public DuelpassRewardColumnWidget(GameObject gob)
		{
		}

		public void SetDownTransition(SelectionItem item)
		{
		}

		public void Init(DuelpassRewardColumnContext context, int achievedGrade)
		{
		}

		public void SetSide(DuelpassRewardColumnWidget left, DuelpassRewardColumnWidget right)
		{
		}

		public void SetSide()
		{
		}

		public void ReceiveFunctionOff()
		{
		}

		public void SetAchievement(int achievedGrade)
		{
		}

		public void SetAchievementWithTween(int achievedGrade)
		{
		}

		public void Achieved()
		{
		}

		public void TweenToAchieved()
		{
		}

		private IEnumerator PlayGradeUpSe(int grade)
		{
			return null;
		}

		public void DeAchieved()
		{
		}

		public void SelectColumnButton(int row)
		{
		}

		public void SelectButton(int row, bool GoldGrade = false)
		{
		}

		public int CheckHasButton(SelectionButton button)
		{
			return 0;
		}
	}
}
