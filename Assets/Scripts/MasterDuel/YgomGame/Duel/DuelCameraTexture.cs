using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelCameraTexture : MonoBehaviour
	{
		private const string BLURMATERIALPATH = "Duel/Models/Materials/UIBlur";

		private const string BLURMATERIALPATH2 = "Duel/Timeline/Materials/UIBlur00";

		public static RenderTexture renderTexture;

		private static int m_RefCounrt;

		public static void Initialize(Camera camera)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
