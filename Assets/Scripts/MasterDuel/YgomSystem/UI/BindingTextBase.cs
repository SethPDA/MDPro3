using UnityEngine;

namespace YgomSystem.UI
{
	public abstract class BindingTextBase<BINDING_TEXT, TARGET> : Binding where BINDING_TEXT : BindingTextBase<BINDING_TEXT, TARGET> where TARGET : MonoBehaviour
	{
		[SerializeField]
		private string textId;

		[SerializeField]
		private bool richText;

		[SerializeField]
		private bool replaceNbsp;

		private object[] m_formatArg;

		[SerializeField]
		public string TextId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool RichText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ReplaceNbsp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void ForceRebindAllText()
		{
		}

		public static void ForceRebindAllTextInChildren(GameObject parent, bool includeInactive)
		{
		}

		public static void SetText(BINDING_TEXT bindingText, string id, object[] formatArg = null)
		{
		}

		public override void OnRebind()
		{
		}

		public override bool OnBinding()
		{
			return false;
		}

		protected abstract void SetText(TARGET target, string text);

		protected abstract string GetText(TARGET target);

		public void SetFromatArg(object[] arg)
		{
		}

		private static object[] AdjustFormatArg(string str, object[] formatArg)
		{
			return null;
		}
	}
}
