using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TextHyphenation : MonoBehaviour
	{
		private bool doCallbackProc;

		private bool doFirstWrap;

		private MDText _Text;

		private string proctext;

		private string orgtext;

		private static SortedDictionary<char, bool> frontmap;

		private static SortedDictionary<char, bool> backmap;

		private static readonly string RITCH_TEXT_REPLACE;

		private static readonly char[] HYP_FRONT;

		private static readonly char[] HYP_BACK;

		private void DirtyLayoutCallback()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private List<string> SplitWrap(string txt)
		{
			return null;
		}

		private string WrapText(float rectwidth)
		{
			return null;
		}
	}
}
