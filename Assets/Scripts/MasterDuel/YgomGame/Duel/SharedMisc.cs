using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class SharedMisc
	{
		public static CardRoot GetCardRoot(DuelGameObjectManager goManager, int team, int position, int index)
		{
			return null;
		}

		public static Vector3 Bezier(Vector3 P0, Vector3 P1, Vector3 P2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 BezierVec(Vector3 P0, Vector3 P1, Vector3 P2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 BezierVec2(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, float t)
		{
			return default(Vector3);
		}

		public static float Bezier2(float P1, float P2, float t)
		{
			return 0f;
		}

		public static float Bezier3(float P1, float P2, float P3, float t)
		{
			return 0f;
		}

		public static Quaternion QuatBezier(Quaternion P0, Quaternion P1, Quaternion P2, float t)
		{
			return default(Quaternion);
		}

		public static Vector3 PerlinShake(float cycle, Vector3 pow)
		{
			return default(Vector3);
		}

		public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
		{
			intersection = default(Vector3);
			return false;
		}

		public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
		{
			intersection = default(Vector3);
			return false;
		}

		public static Vector3 SetVectorLength(Vector3 vector, float size)
		{
			return default(Vector3);
		}

		public static Vector3 GetIntersectionZXPlane(Ray ray)
		{
			return default(Vector3);
		}

		public static string GetBillboardTexPath(int cardId)
		{
			return null;
		}

		public static void SetMeshColor(MeshFilter meshFilter, Color col)
		{
		}

		public static Color GetMeshColor(MeshFilter meshFilter)
		{
			return default(Color);
		}

		public static Dictionary<CardPlace, Engine.AffectType> GetAffectCardPlaces(DuelFieldBase duelField, int team, int position)
		{
			return null;
		}

		public static string DebugGetCallMethod(int numFrames = 1)
		{
			return null;
		}

		public static void DebugPrintCallStack(string message, uint numStacks = 3u)
		{
		}

		public static void DelayedFunction(float delay, Action func)
		{
		}

		private static IEnumerator DelayedFunctionImpl(float delay, Action func)
		{
			return null;
		}

		public static int BinarySearch<T>(List<T> list, Func<T, int> comparer)
		{
			return 0;
		}

		public static TweenSet ApplyTweenTR(GameObject go, Vector3 srcPos, Quaternion srcRot, Vector3 dstPos, Quaternion dstRot, float duration, Tween.Easing easing, UnityAction onFinished)
		{
			return null;
		}

		public static void PlayTween(GameObject target, string label, Action onFinished)
		{
		}

		public static IEnumerator WaitLimitedTime(float timeLimit, Func<bool> isFinishedFunc)
		{
			return null;
		}

		public static bool IsDistanceLength(Vector2 screenPointA, Vector2 screenPointB, float screenRatio)
		{
			return false;
		}
	}
}
