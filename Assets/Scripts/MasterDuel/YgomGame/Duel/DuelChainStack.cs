using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class DuelChainStack : MonoBehaviour
	{
		private const string LABEL_EO_CHAINSET = "ChainCardSet";

		private const string LABEL_EO_OFFSET = "Offset";

		private const string LABEL_EO_STRIPE = "ChainStraight";

		private const string LABEL_EO_CHAINCARDEOM = "DummyChainCard";

		private const string LABEL_EO_CHAINCARD = "DummyCardModel_front";

		private const string LABEL_EO_CHAINNUM = "ChainNum";

		private const string LABEL_EO_DIGITAL = "_Digit";

		private const string LABEL_EO_TEN = "_Tens";

		private const string LABEL_EO_ONE = "_Ones";

		private const string LABEL_EO_RESOLVETEXT = "ResolveTextSet";

		private const string LABEL_EO_CHAINEFFECT = "_Chain";

		private const string LABEL_EO_CHAINSCALE = "CardLightSetScaleC";

		private static Dictionary<bool, string>[] m_LabelTable;

		private List<DuelChainManager.ChainSpotData> m_ChaindataList;

		private ElementObjectManager m_Eom => null;

		private PlayableDirector m_Pd => null;

		private GameObject GetChainSet(int layer, bool pos)
		{
			return null;
		}

		private GameObject GetChainStripe(int layer0, bool pos0, int layer1, bool pos1)
		{
			return null;
		}

		private MeshRenderer GetChainCard(int layer, bool pos)
		{
			return null;
		}

		private void SetChainStripe(int layer0, bool pos0, bool pos1)
		{
		}

		private void HideChainStripeInLayer(int layer0)
		{
		}

		private void HideChainSetInLayer(int layer)
		{
		}

		private void SetChainCard(int layer, bool isleft, int cardid, int styleid, bool isresolve)
		{
		}

		private (bool, int, int) GetDataFromLayer(int layer)
		{
			return default((bool, int, int));
		}

		private void SetChainNum(int layer, bool pos, int num)
		{
		}

		private (SpriteRenderer, SpriteRenderer, SpriteRenderer) GetChainNumSR(int layer, bool pos)
		{
			return default((SpriteRenderer, SpriteRenderer, SpriteRenderer));
		}

		private void SetSpriteNum(SpriteRenderer sprite, int digit)
		{
		}

		public void SetChainStack1(List<DuelChainManager.ChainSpotData> chainstack)
		{
		}

		public void SetChainStack2(List<DuelChainManager.ChainSpotData> chainstack)
		{
		}

		public void SetChainResolve1(List<DuelChainManager.ChainSpotData> chainstack)
		{
		}

		public void SetChainResolve2(List<DuelChainManager.ChainSpotData> chainstack, bool isFirst)
		{
		}
	}
}
