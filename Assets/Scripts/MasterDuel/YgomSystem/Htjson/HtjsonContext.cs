using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Htjson
{
	public interface HtjsonContext
	{
		void SetTextColor(Color col);

		Color GetTextColor();

		void InsertItem(Transform item);

		void SetStyle(string id, object dic);

		Dictionary<string, object> GetStyle(string id);

		HtjsonReceiver GetReceiver();

		string ProcPath(string path);

		void AddReplaceParam(Dictionary<string, object> param);

		Dictionary<string, object> GetReplaceParam();
	}
}
