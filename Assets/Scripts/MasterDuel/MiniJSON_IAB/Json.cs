using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MiniJSON_IAB
{
	public static class Json
	{
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

			public static object Parse(string jsonString)
			{
				return null;
			}

			public void Dispose()
			{
			}

			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			private List<object> ParseArray()
			{
				return null;
			}

			private object ParseValue()
			{
				return null;
			}

			private object ParseByToken(TOKEN token)
			{
				return null;
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

		private sealed class Serializer
		{
			private StringBuilder builder;

			private Serializer()
			{
			}

			public static string Serialize(object obj)
			{
				return null;
			}

			private void SerializeValue(object value)
			{
			}

			private void SerializeObject(IDictionary obj)
			{
			}

			private void SerializeArray(IList anArray)
			{
			}

			private void SerializeString(string str)
			{
			}

			private void SerializeOther(object value)
			{
			}
		}

		public static object Deserialize(string json)
		{
			return null;
		}

		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
