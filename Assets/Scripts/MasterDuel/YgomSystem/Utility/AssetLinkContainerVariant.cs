using UnityEngine;

namespace YgomSystem.Utility
{
	//[CreateAssetMenu]
	public class AssetLinkContainerVariant : AssetLinkContainer
	{
		public AssetLinkContainer baseContainer;

		public override Container GetContainer(string label)
		{
			return null;
		}
	}
}
