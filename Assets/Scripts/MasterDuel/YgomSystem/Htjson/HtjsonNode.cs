using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Htjson
{
	public class HtjsonNode : MonoBehaviour, HtjsonContext
	{
		private bool getColor;

		private bool parentGet;

		private bool replaceGet;

		private Color textColor;

		private Dictionary<string, object> replaceParam;

		private HtjsonContext parentContext;

		private Dictionary<string, object> styles;

		public virtual void SetTextColor(Color col)
		{
		}

		public virtual void AddReplaceParam(Dictionary<string, object> param)
		{
		}

		private bool StandbyParentContext()
		{
			return false;
		}

		public virtual Color GetTextColor()
		{
			return default(Color);
		}

		public virtual Dictionary<string, object> GetReplaceParam()
		{
			return null;
		}

		public HtjsonReceiver GetReceiver()
		{
			return null;
		}

		public string ProcPath(string path)
		{
			return null;
		}

		public void LoadStyle(string path)
		{
		}

		public void SetStyle(string id, object dic)
		{
		}

		public Dictionary<string, object> GetStyle(string id)
		{
			return null;
		}

		public virtual void InsertItem(Transform item)
		{
		}

		public virtual void InsertItemList(List<object> list)
		{
		}

		public void InsertItemHtjson(object obj)
		{
		}

		public virtual void Clear()
		{
		}

		public void SetBgEnable(bool enable)
		{
		}

		public void SetNodeParam(Dictionary<string, object> dic)
		{
		}
	}
}
