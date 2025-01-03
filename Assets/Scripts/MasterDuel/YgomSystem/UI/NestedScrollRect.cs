using UnityEngine.EventSystems;

namespace YgomSystem.UI
{
	public class NestedScrollRect : ExtendedScrollRect
	{
		public bool alwaysRouteToParent;

		private bool routeToParent;

		public override void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public override void OnScroll(PointerEventData eventData)
		{
		}
	}
}
