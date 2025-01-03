using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Download;
using YgomGame.Menu;

namespace YgomSample.Download
{
	public class DownloadTest : BaseMenuViewController
	{
		[Serializable]
		public struct DownloadData
		{
			public string m_path;

			public string m_index;
		}

		[SerializeField]
		private List<DownloadData> m_dataList;

		[SerializeField]
		private MDText m_text;

		[SerializeField]
		private Button m_button;

		[SerializeField]
		private Button m_resetButton;

		[SerializeField]
		private Button m_cancelButton;

		private DLCList m_compList;

		private long m_nowSize;

		private long m_totalSize;

		private int m_compNum;

		private int m_totalNum;

		private List<DLCList> m_targets;

		private Coroutine loadRequestCoroutine;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnClick()
		{
		}

		public void OnCancelClick()
		{
		}

		public void OnResetClick()
		{
		}

		private IEnumerator yLoadRequset()
		{
			return null;
		}
	}
}
