using System;
using UnityEngine;

namespace YgomSystem.UI
{
	public class BindingImage : Binding
	{
		[SerializeField]
		private string spritePath;

		[SerializeField]
		public bool immediate;

		[SerializeField]
		public bool showloading;

		private string materialPath;

		private uint crc;

		private uint usingCrc;

		private string loadPath;

		private uint materialCrc;

		private uint materialUsingCrc;

		private bool isDoneMaterial;

		private string assetContainerLabel;

		private Type assetType;

		[SerializeField]
		public string SpritePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MaterialPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnRebind()
		{
		}

		public override bool OnBinding()
		{
			return false;
		}

		private bool OnBindingMaterial()
		{
			return false;
		}

		private void SetMaterial(Material material)
		{
		}
	}
}
