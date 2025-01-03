using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ara
{
	[ExecuteInEditMode]
	public class AraTrail : MonoBehaviour
	{
		public enum TrailAlignment
		{
			View = 0,
			Velocity = 1,
			Local = 2
		}

		public enum TrailSorting
		{
			OlderOnTop = 0,
			NewerOnTop = 1
		}

		public enum Timescale
		{
			Normal = 0,
			Unscaled = 1
		}

		public enum TextureMode
		{
			Stretch = 0,
			Tile = 1
		}

		public struct CurveFrame
		{
			public Vector3 position;

			public Vector3 normal;

			public Vector3 bitangent;

			public Vector3 tangent;

			//public CurveFrame(Vector3 position, Vector3 normal, Vector3 bitangent, Vector3 tangent)
			//{
			//}

			public Vector3 Transport(Vector3 newTangent, Vector3 newPosition)
			{
				return default(Vector3);
			}
		}

		public struct Point
		{
			public Vector3 position;

			public Vector3 velocity;

			public Vector3 tangent;

			public Vector3 normal;

			public Color color;

			public float thickness;

			public float life;

			public bool discontinuous;

			//public Point(Vector3 position, Vector3 velocity, Vector3 tangent, Vector3 normal, Color color, float thickness, float lifetime)
			//{
			//}

			private static float CatmullRom(float p0, float p1, float p2, float p3, float t)
			{
				return 0f;
			}

			private static Color CatmullRomColor(Color p0, Color p1, Color p2, Color p3, float t)
			{
				return default(Color);
			}

			private static Vector3 CatmullRom3D(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
			{
				return default(Vector3);
			}

			public static Point Interpolate(Point a, Point b, Point c, Point d, float t)
			{
				return default(Point);
			}

			public static Point operator +(Point p1, Point p2)
			{
				return default(Point);
			}

			public static Point operator -(Point p1, Point p2)
			{
				return default(Point);
			}
		}

		public const float epsilon = 1E-05f;

		//public TrailSection section;

		public Space space;

		public Timescale timescale;

		public TrailAlignment alignment;

		public TrailSorting sorting;

		public float thickness;

		public int smoothness;

		public bool highQualityCorners;

		public int cornerRoundness;

		public AnimationCurve thicknessOverLenght;

		public Gradient colorOverLenght;

		public AnimationCurve thicknessOverTime;

		public Gradient colorOverTime;

		public bool emit;

		public float initialThickness;

		public Color initialColor;

		public Vector3 initialVelocity;

		public float timeInterval;

		public float minDistance;

		public float time;

		public bool enablePhysics;

		public float warmup;

		public Vector3 gravity;

		public float inertia;

		public float velocitySmoothing;

		public float damping;

		public Material[] materials;

		public ShadowCastingMode castShadows;

		public bool receiveShadows;

		public bool useLightProbes;

		public bool quadMapping;

		public TextureMode textureMode;

		public float uvFactor;

		public float uvWidthFactor;

		public float tileAnchor;

		[HideInInspector]
		public List<Point> points;

		private List<Point> renderablePoints;

		private List<int> discontinuities;

		private Mesh mesh_;

		private Vector3 velocity;

		private Vector3 prevPosition;

		private float accumTime;

		private List<Vector3> vertices;

		private List<Vector3> normals;

		private List<Vector4> tangents;

		private List<Vector4> uvs;

		private List<Color> vertColors;

		private List<int> tris;

		private Action<ScriptableRenderContext, Camera> renderCallback;

		public Vector3 Velocity => default(Vector3);

		private float DeltaTime => 0f;

		private float FixedDeltaTime => 0f;

		public Mesh mesh => null;

		public event Action onUpdatePoints
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnValidate()
		{
		}

		public void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void AttachToCameraRendering()
		{
		}

		private void DetachFromCameraRendering()
		{
		}

		public void Clear()
		{
		}

		private void UpdateVelocity()
		{
		}

		private void LateUpdate()
		{
		}

		private void EmissionStep(float time)
		{
		}

		private void Warmup()
		{
		}

		private void PhysicsStep(float timestep)
		{
		}

		private void FixedUpdate()
		{
		}

		public void EmitPoint(Vector3 position)
		{
		}

		private void SnapLastPointToTransform()
		{
		}

		private void UpdatePointsLifecycle()
		{
		}

		private void ClearMeshData()
		{
		}

		private void CommitMeshData()
		{
		}

		private void RenderMesh(Camera cam)
		{
		}

		public float GetLenght(List<Point> input)
		{
			return 0f;
		}

		private List<Point> GetRenderablePoints(int start, int end)
		{
			return null;
		}

		private CurveFrame InitializeCurveFrame(Vector3 point, Vector3 nextPoint)
		{
			return default(CurveFrame);
		}

		private void UpdateTrailMesh(Camera cam)
		{
		}

		private void UpdateSegmentMesh(int start, int end, Vector3 localCamPosition)
		{
		}
	}
}
