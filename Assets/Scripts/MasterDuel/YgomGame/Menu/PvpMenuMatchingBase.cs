using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.Network;

namespace YgomGame.Menu
{
	public abstract class PvpMenuMatchingBase : MonoBehaviour
	{
		private bool m_bCompleteMatching;

		private bool m_bRequestCancel;

		private bool m_bStartMatching;

		private int m_ErrorCode;

		private int m_CancelErrorCode;

		protected Handle m_Handle;

		protected Dictionary<string, object> m_MatchParam;

		public bool IsComplete
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public bool IsRequestCancel => false;

		public bool IsStartMatching
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

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

		public int CancelErrorCode
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public Handle Handle => null;

		public virtual IEnumerator yWaitPrevious(float time)
		{
			return null;
		}

		public virtual void StartMatching(Dictionary<string, object> param)
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

		public virtual IEnumerator yWaitMatching(Action callback)
		{
			return null;
		}

		public virtual IEnumerator yCancelMatching()
		{
			return null;
		}

		public virtual void SetBootDuelParam(ref Dictionary<string, object> param)
		{
		}

		public virtual void AbortMatching()
		{
		}

		protected virtual Handle CallAPIMatching(Dictionary<string, object> matchParam)
		{
			return null;
		}

		protected void OnCompleteMatching(Handle e)
		{
		}

		protected virtual void OnCompleteMatchingHandle(Handle e)
		{
		}

		protected void OnErrorMatching(Handle e)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
