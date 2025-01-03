using System;
using System.Collections.Generic;
using UnityEngine;

namespace Willow.InGameField
{
	[Serializable]
	[CreateAssetMenu]
	public class ParameterContainer : ParameterAsset
	{
		[SerializeField]
		private List<ParameterAsset> m_childParameterList;

		[NonSerialized]
		[HideInInspector]
		private List<ParameterAsset> m_cacheChildParameterList;

		[NonSerialized]
		[HideInInspector]
		private Dictionary<string, ParameterAsset> m_cachedChildParameterMap;

		private void __internalAwake()
		{
		}

		public List<ParameterAsset> GetRootParameters()
		{
			return m_childParameterList;
		}

		public Dictionary<string, ParameterAsset> GetRootParametersMap()
		{
			return m_cachedChildParameterMap;
        }

		private void UpdateRootParameterCache()
		{
		}

		private void UpdateRootParameterCacheMap()
		{
		}

		public void AddMonsterModelParameter()
		{
		}

		public void AddMonsterLocationParameter()
		{
		}

		public void AddMonsterLocationOffsetParameter()
		{
		}

		public void AddMonsterRootLocationParameter()
		{
		}

		public void AddMonsterSkillEffectParentParameter()
		{
		}

		private void CreateDummyAsset()
		{
		}

		private ParameterAsset CreateChildParameter(Type type, string assetName = "", ParameterContainer parent = null, Type supportType = null)
		{
			return null;
		}

		private string GetVariableAssetName(string assetName, Type type)
		{
			return null;
		}

		private ParameterAsset CreateParameterAssetInstance(string parameterAssetName, Type type, ParameterContainer parent = null, Type supportType = null)
		{
			return null;
		}

		private void SetParentContainer(ParameterAsset parameterAsset, ParameterContainer parent)
		{
		}

		private void AddParameterAsSubAsset(ParameterAsset parameterAsset)
		{
		}
	}
}
