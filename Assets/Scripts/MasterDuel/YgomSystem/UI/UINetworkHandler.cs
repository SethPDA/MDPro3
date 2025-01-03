using System.Collections.Generic;
using UnityEngine;
using YgomSystem.Network;

namespace YgomSystem.UI
{
	public class UINetworkHandler : MonoBehaviour
	{
		private List<Handle> m_NetworkProgressDispOwners;

		private int m_ResourceNetworkProgressCnt;

		private bool m_Retry;

		private int m_SkipHandleSectionMainteCnt;

		private List<Handle> m_RetryHandles;

		private static bool isIgnoreNetworkProgressCommand(string command)
		{
			return false;
		}

		public void SetSkipHandleSectionMainteEnabled(bool enabled)
		{
		}

		public void SetSystemHandler()
		{
		}

		public void ClearOnReboot()
		{
		}

		private void networkStartHandle(Handle handle)
		{
		}

		private void networkCompleteHandle(Handle handle)
		{
		}

		private void networkErrorHandle(Handle handle)
		{
		}

		public void networkDisconnectErrorDialog()
		{
		}

		private void resourceProgressHandle(bool isshow)
		{
		}

		private bool? resourceRetryHandle(bool firstcall)
		{
			return null;
		}

		private void resourceErrorHandle(string path)
		{
		}

		public void OpenNetworkErrorDialog(Handle handle)
		{
		}
	}
}
