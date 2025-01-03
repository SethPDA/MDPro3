using UnityEngine;
using UnityEngine.UI;

public class RadarChart// : Graphic
{
	private byte vertexNum;

	private float maxLength;

	private float deltaTheta;

	private float yRate;

	private float yOffset;

	[HideInInspector]
	public float[] rates;

	//protected override void Awake()
	//{
	//}

	public void Initialize(byte _vertexNum = 5)
	{
	}

	//protected override void OnPopulateMesh(VertexHelper vh)
	//{
	//}
}
