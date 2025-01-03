using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class AsyncMiniJSON : MonoBehaviour
	{
		private struct ParseParam
		{
			public string json
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Action<object> onfinish
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public ParseParam(string arg_json, Action<object> arg_onfinish)
			{
			}
		}

		private sealed class Parser : IDisposable
		{
			private enum TOKEN
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}

			private const string WORD_BREAK = "{}[],:\"";

			private StringReader json;

			private TaskManager parserTaskManager;

			private char PeekChar => '\0';

			private char NextChar => '\0';

			private string NextWord => null;

			private TOKEN NextToken => default(TOKEN);

			public static bool IsWordBreak(char c)
			{
				return false;
			}

			private Parser(string jsonString)
			{
			}

			public static Parser Parse(string jsonString, Action<object> onfinish)
			{
				return null;
			}

			public void Update()
			{
			}

			public bool IsDone()
			{
				return false;
			}

			public void Dispose()
			{
			}

			private bool Task_ParseObject(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
			{
				return false;
			}

			private bool Task_ParseArray(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
			{
				return false;
			}

			private void ParseValue(Action<object> onfinish)
			{
			}

			private void ParseByToken(TOKEN token, Action<object> onfinish)
			{
			}

			private bool Task_ParseString(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
			{
				return false;
			}

			private bool Task_ParseNumber(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
			{
				return false;
			}

			private string ParseString()
			{
				return null;
			}

			private object ParseNumber()
			{
				return null;
			}

			private void EatWhitespace()
			{
			}
		}

		private const float EXECUTE_TASK_LIMIT_TIME = 0.03f;

		private const string DEFAULT_GAMEOBJECT_NAME = "AsyncMiniJSON";

		private TaskManager jsonTaskManager;

		public static void Deserialize(string json, GameObject owner, Action<object> onfinish)
		{
		}

		public static bool IsJsonAsyncParse()
		{
			return false;
		}

		public void Parse(string json, Action<object> onfinish)
		{
		}

		private bool Task_StartParse(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
		{
			return false;
		}

		private void Update()
		{
		}
	}
}
