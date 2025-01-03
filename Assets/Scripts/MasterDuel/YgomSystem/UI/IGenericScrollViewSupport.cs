using UnityEngine;

namespace YgomSystem.UI
{
	public interface IGenericScrollViewSupport
	{
		void OnItemSetData(GameObject gob, int dataindex);

		void OnItemExit(GameObject gob, int dataindex);

		void OnItemInitialize(GameObject gob);

		void OnGsvStanby();
	}
}
