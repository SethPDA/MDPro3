using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Utility;

namespace YgomSystem.Utility
{
	public static class StringUtil
	{
		public const string ColorTagRed = "<color=#F39700>";

		public const string ColorTagBlue = "<color=#00D2FF>";

		public const string ColorTagOrange = "<color=#FFC200>";

		public const string EFFECTSEPERATER_TAG = "\ufffd";

		public static string NumToCommaString(int number)
		{
			return null;
		}

		public static string NumToCommaString(long number)
		{
			return null;
		}

		public static string BinaryToString(byte[] src)
		{
			return null;
		}

		public static string CreateText(int textId)
		{
			return null;
		}

		public static string CreateTextFromListItems(int listIdx)
		{
			return null;
		}

		public static string CreateTextImpl(int textId, Func<int> mixNumFunc, Func<int, Engine.DialogMixTextType> mixTypeFunc, Func<int, int> mixDataFunc)
		{
			return null;
		}

		public static bool IsMixedTextContainsTextID(int textID)
		{
			return false;
		}

		public static string ChangeEffectColor(this string text, int eff)
		{
			return null;
		}

		public static string Coloring(this string str, string color)
		{
			return null;
		}

		public static string Resizing(this string str, int size)
		{
			return null;
		}

		public static string Scaling(this string str, float scale)
		{
			return null;
		}

		public static string Coloring(this string str, int color)
		{
			return null;
		}

		public static string Coloring(this string str, Color color)
		{
			return null;
		}

		public static string MergeTextWithSeparateline(this string orgstr, string targetstr)
		{
			return null;
		}

		public static string Italic(this string str)
		{
			return null;
		}

		public static string Bold(this string str)
		{
			return null;
		}

		public static string Bracket(this string str)
		{
			return null;
		}

		public static string LenticularBracket(this string str)
		{
			return null;
		}

		public static string GetCounterName(Engine.CounterType counter)
		{
			return null;
		}

		public static string WildCardToRegEx(string pattern, bool notMatch = false)
		{
			return null;
		}

		public static string MakeFormatedText(string baseText, TextGroupLoadHolder textGroupLoadHolder, List<object> args = null)
		{
			return null;
		}

		private static string InnerMakeFormatedText(string baseText, TextGroupLoadHolder textGroupLoadHolder, List<object> args)
		{
			return null;
		}

		private static string InnerMakeFormatedText(TextGroupLoadHolder textGroupLoadHolder, object source)
		{
			return null;
		}
	}
}
