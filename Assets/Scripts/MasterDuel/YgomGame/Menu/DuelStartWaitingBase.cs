using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.Network;

namespace YgomGame.Menu
{
	public abstract class DuelStartWaitingBase : MonoBehaviour
	{
		private bool m_bComplete;

		private int m_ErrorCode;

		protected Handle m_Handle;

		protected Dictionary<string, object> m_Result;

		protected Dictionary<string, object> m_Param;

		public bool IsComplete => false;

		public int ErrorCode
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public Dictionary<string, object> Result => null;

		public virtual IEnumerator yWaitPrevious(float time)
		{
			return null;
		}

		public virtual void StartWaiting()
		{
		}

		public virtual bool DispProgress()
		{
			return false;
		}

		public virtual int ProgressCount()
		{
			return 0;
		}

		public virtual IEnumerator yWaitWaiting(Action callback)
		{
			return null;
		}

		protected void OnCompleteWaiting(Handle e)
		{
		}

		protected void OnErrorWaiting(Handle e)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
