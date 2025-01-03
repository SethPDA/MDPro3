using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomGame.Card
{
	public class CardMaterialManager
	{
		private const int MAXMATPOOLCOUNT = 64;

		private const int MAXRARENUM = 4;

		private const string MASKTEX = "MaskTex";

		private CardPictureManager m_CardPictureManager;

		private CardMaskManager m_CardMaskManager;

		private Dictionary<Material, int> m_MatInstanceTable;

		private Dictionary<Material, int> m_CardPictureTaskTable;

		private Dictionary<Material, int> m_CardMaskTaskTable;

		private Dictionary<CardFinishSetting.FinishType, int> m_MatcountStyleidTable;

		private Dictionary<CardFinishSetting.FinishType, Stack<Material>> m_CardMaterialStack;

		private Dictionary<string, CardFinishSetting.FinishType> m_FinishTypeNameTable;

		public Dictionary<CardFinishSetting.FinishType, int> matcountStyleidTable => null;

		public static CardMaterialManager Create(CardPictureManager cardPictureManager, CardMaskManager cardMaskManager)
		{
			return null;
		}

		public void GetCardMaterialForMeshRendererAsync(MeshRenderer meshRenderer, int cardId, int styleId, UnityAction onFinished)
		{
		}

		public void GetCardMaterialForRawImageAsync(RawImage rawImage, int cardId, int styleId, UnityAction onFinished)
		{
		}

		public int Release(Material mat)
		{
			return 0;
		}

		private void Initialize()
		{
		}

		private bool SetMaskTex(int cardid, int styleId, Material mat)
		{
			return false;
		}

		private void SetFrameMask(int cardid, ref Material mat)
		{
		}

		private void SetCardNameMask(int cardid, Material mat)
		{
		}

		private void SetParameterMask(int cardid, ref Material mat)
		{
		}

		private void SetStarColorMask(int cardid, int styleid, ref Material mat)
		{
		}

		private void SetCardNameColorMask(int cardid, int styleid, ref Material mat)
		{
		}

		private void ReturnCardMaterial(Material mat)
		{
		}

		private Material GetCardMaterial(int cardid, int finishid, bool isforui)
		{
			return null;
		}
	}
}
