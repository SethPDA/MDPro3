using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

namespace YgomGame.Duel
{
	public class WorldDragController
	{
		public enum State
		{
			Idle = 0,
			BeginDrag = 1,
			Dragging = 2,
			EndDrag = 3
		}

		private ITranslateScreenToWorld scrToWorld;

		private Queue<Vector3> dragHistory;

		private float currentTime;

		private Vector3 move;

		private bool draggingOnThisFrame;

		private State state;

		private static readonly int numDragSpeedHistories;

		public bool dragging => false;

		public static WorldDragController Create(ITranslateScreenToWorld scrToWorld)
		{
			return null;
		}

		public State Update(out Vector3 move, out Vector3 average)
		{
			move = default(Vector3);
			average = default(Vector3);
			return default(State);
		}

		//public void OnBeginDrag(PointerEventData eventData)
		//{
		//}

		//public void OnDrag(PointerEventData eventData)
		//{
		//}

		//public void OnEndDrag(PointerEventData eventData)
		//{
		//}

		private void EnqueueDragHistory(Vector3 deltaMove)
		{
		}

		private Vector3 GetDirection(Vector2 s0, Vector2 s1)
		{
			return default(Vector3);
		}
	}
}
