using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Review
{
	public class ReviewSequencer : MonoBehaviour
	{
		private readonly string k_ReviewEntryDialogUIPrefPath;

		private readonly string k_SelectEnqueteOrSuportPrefPath;

		private IReadOnlyDictionary<string, object> m_ReviewData;

		private int m_EnqueteId;

		private string m_ReviewURL;

		private Action m_Callback;

		private ViewController m_RootContent;

		private ViewController m_RootDialog;

		public static void Launch(IReadOnlyDictionary<string, object> reviewData, Action callback)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void ToReview()
		{
		}

		private void ToSelectEnqueteOrSupport()
		{
		}

		private void ToEnquete()
		{
		}

		private void ToSupport()
		{
		}

		private void ToCompleteAnswer()
		{
		}

		private void ToFinish()
		{
		}
	}
}
