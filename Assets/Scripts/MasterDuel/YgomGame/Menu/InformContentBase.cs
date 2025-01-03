using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu
{
	public abstract class InformContentBase : MonoBehaviour
	{
		public Dictionary<string, object> Args;

		public virtual void OnPush()
		{
		}
	}
}
