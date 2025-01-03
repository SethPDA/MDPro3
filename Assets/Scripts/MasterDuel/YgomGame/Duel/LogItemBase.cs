using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class LogItemBase : MonoBehaviour
	{
		protected DuelClient m_Host;

		public SelectionItem selectionItemL
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public SelectionItem selectionItemR
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual void OnCreated(DuelClient host)
		{
		}

		public virtual void OnAdded()
		{
		}

		public virtual void OnRemoved()
		{
		}
	}
}
