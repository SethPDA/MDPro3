using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Scenario
{
	//[CreateAssetMenu]
	public class ScenarioAsset : ScriptableObject, ISerializationCallbackReceiver
	{
		private List<object> m_CommandList;

		[SerializeField]
		private string[] m_CommandJsons;

		public List<object> commandList => null;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public static object CreateCommand()
		{
			return null;
		}

		public static string GetCommandKey(object commandData)
		{
			return null;
		}

		public static void SetCommandKey(object commandData, string key)
		{
		}

		public static ScenarioDef.BehaviourAsyncMode GetAsyncMode(object commandData)
		{
			return default(ScenarioDef.BehaviourAsyncMode);
		}

		public static void SetAsyncMode(object commandData, ScenarioDef.BehaviourAsyncMode value)
		{
		}

		public static Dictionary<string, object> GetArgs(object commandData)
		{
			return null;
		}

		public string GetCommandKeyByIdx(int index)
		{
			return null;
		}

		public void SetCommandKeyByIdx(int index, string commandKey)
		{
		}

		public bool IsSupportedAsyncByIdx(int index)
		{
			return false;
		}

		public ScenarioDef.BehaviourAsyncMode GetAsyncModeByIdx(int index)
		{
			return default(ScenarioDef.BehaviourAsyncMode);
		}

		public void SetAsyncModeByIdx(int index, ScenarioDef.BehaviourAsyncMode value)
		{
		}

		public Dictionary<string, object> GetArgsByIdx(int index)
		{
			return null;
		}
	}
}
