using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class SelectingCursorManager : MonoBehaviour
	{
		private RunEffectWorker worker;

		private SimpleEffect effArrow;

		private SimpleEffect highlightEff;

		private int currentCursorPlayer;

		private int currentCursorPosition;

		private int currentCursorViewIndex;

		private List<GameObject> cursorEffect;

		private int cursorEffectPlayer;

		private int cursorEffectPosition;

		private int cursorEffectViewIndex;

		private bool cursorEffectPhaseButton;

		private Dictionary<string, Queue<GameObject>> cursorEffectPool;

		private Transform poolParent;

		private const string prefabPathBase = "Duel/Models/FieldPadCursor/FieldPadCursor";

		private const string prefabPathCursorExclude = "Duel/Models/FieldPadCursor/FieldPadCursorExclude";

		private const string prefabPathCursorField = "Duel/Models/FieldPadCursor/FieldPadCursorField";

		private const string prefabPathCursorGrave = "Duel/Models/FieldPadCursor/FieldPadCursorGrave";

		private const string prefabPathCursorMagic = "Duel/Models/FieldPadCursor/FieldPadCursorMagic";

		private const string prefabPathCursorMonster = "Duel/Models/FieldPadCursor/FieldPadCursorMonster";

		private const string prefabPathCursorPhase = "Duel/Models/FieldPadCursor/FieldPadCursorPhase";

		private const string prefabPathCursorCard = "Duel/Models/FieldPadCursor/FieldPadCursorCard";

		private GameObject prefabCursorExclude;

		private GameObject prefabCursorField;

		private GameObject prefabCursorGrave;

		private GameObject prefabCursorMagic;

		private GameObject prefabCursorMonster;

		private GameObject prefabCursorPhase;

		private GameObject prefabCursorCard;

		private Vector3 curPos;

		private int setPlayer;

		private int setPosition;

		private int setViewIndex;

		public bool isReady => false;

		public static SelectingCursorManager Create(RunEffectWorker worker)
		{
			return null;
		}

		private void LoadCursorPrefab()
		{
		}

		private void LoadAsset(string path, Action<GameObject> loadedCallback)
		{
		}

		public void StartDisp(int team, int position, int index)
		{
		}

		private void StartDispImpl(Vector3 pos, bool isForce)
		{
		}

		public void EndDisp()
		{
		}

		public void RefreshDisp()
		{
		}

		public void Terminate()
		{
		}

		public void SetFocusHighlight(int team, int position, int viewIndex)
		{
		}

		private void ShowHighlightEffect(int team, int position, int viewIndex)
		{
		}

		private void ShowHighlightEffect(Vector3 pos, Quaternion rot, DuelEffectPool.Type effectType)
		{
		}

		public void HideHighlightEffect()
		{
		}

		public void SelectCurrentTarget()
		{
		}

		public bool Select(int player, int position, int viewIndex)
		{
			return false;
		}

		public void ShowPositionPadCursor(int player, int position, int viewIndex)
		{
		}

		public void ShowPhasePadCursor()
		{
		}

		private void ShowPadCursor(GameObject cursorObject)
		{
		}

		private GameObject CreatePositionPadCursor(int position, Transform parent)
		{
			return null;
		}

		private GameObject CreatePhasePadCursor()
		{
			return null;
		}

		private GameObject CreatePadCursor(GameObject prefab, Transform parent)
		{
			return null;
		}

		private GameObject GetPadCursorPrefab(int position)
		{
			return null;
		}

		public void HidePadCursor(bool resetInfo = true)
		{
		}

		public void ReshowPadCursor()
		{
		}

		public void UpdatePadCursor()
		{
		}
	}
}
