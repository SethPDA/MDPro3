using System;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public abstract class MDMarkupContentBase : IMDMarkupContent, ISerializationCallbackReceiver
	{
		public abstract MDMarkupDef.MarkupType markupType { get; }

		public abstract int contentIndent { get; }

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}

		public virtual void OnBeforeSerialize()
		{
		}

		protected abstract object OnExportJsonObj(object jsonObj);

		protected abstract void OnImportJsonObj(object jsonObj);

		public string ToJson()
		{
			return null;
		}
	}
}
