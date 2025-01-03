using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class ManaSet : MonoBehaviour
	{
		private enum Step
		{
			None = 0,
			BeforeNum = 1,
			ChangeNum = 2,
			AfterNum = 3,
			Out = 4
		}

		private ElementObjectManager ui;

		private Image counterIcon;

		private TextMeshProUGUI text;

		private Vector3 targetAnchor;

		private int afterNum;

		private int currentNum;

		private int deltaNum;

		private float timer;

		private const float timeCounterChange = 1f;

		private const float timeAfter = 0.3f;

		private Step step;

		public void Initialize()
		{
		}

		public void Play(Engine.CounterType type, int beforeNum, int afterNum, Vector3 targetAnchor)
		{
		}

		private void Update()
		{
		}

		private void UpdatePosition()
		{
		}
	}
}
