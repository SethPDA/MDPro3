using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Htjson
{
	public interface HtjsonReceiver
	{
		void HtjsonLink(object path);

		void SetOption(string key, object value);

		object GetOption(string key);

		Dictionary<string, object> GetOptions();

		void RegisterId(string id, GameObject entry);

		List<GameObject> GetIdObjects(string id);

		string GetIdObjectName(GameObject go);
	}
}
