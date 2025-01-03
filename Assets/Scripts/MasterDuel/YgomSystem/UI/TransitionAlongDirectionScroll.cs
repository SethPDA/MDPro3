using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TransitionAlongDirectionScroll : MonoBehaviour
	{
		[SerializeField]
		private List<TransitionAlongDirection> m_TransitionAlongDirections;

		private void Start()
		{
		}

		private bool OnEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}
	}
}
