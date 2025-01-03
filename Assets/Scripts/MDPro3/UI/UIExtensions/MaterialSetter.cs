using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class MaterialSetter : MonoBehaviour
    {
        public string materialName;
        public bool needInstantiate;
        public bool moveImageSpriteToMaterial;
        private bool setted;

        private void Awake()
        {
            StartCoroutine(SetMaterialAsync());
        }

        private IEnumerator SetMaterialAsync()
        {
            var ie = MaterialLoader.LoadMaterialByNameAsync(materialName);
            while (ie.MoveNext())
                yield return null;
            var returnValue = ie.Current;
            if (needInstantiate)
                returnValue = Instantiate(returnValue);

            if (TryGetComponent<Image>(out var image))
            {
                image.material = returnValue;
                if(moveImageSpriteToMaterial)
                {
                    image.material.mainTexture = image.sprite.texture;
                    image.sprite = null;
                }
            }
            else if (TryGetComponent<RawImage>(out var rawImage))
                rawImage.material = returnValue;
            else if (TryGetComponent<Renderer>(out var renderer))
                renderer.material = returnValue;

            setted = true;
        }

        public void SetMaterialAction(Action<Material> action)
        {
            StartCoroutine(SetMaterialActionAsync(action));
        }

        private IEnumerator SetMaterialActionAsync(Action<Material> action)
        {
            while(!setted)
                yield return null;
            Material mat;
            if (TryGetComponent<Image>(out var image))
                mat = image.material;
            else if (TryGetComponent<RawImage>(out var rawImage))
                mat = rawImage.material;
            else
                mat = GetComponent<Renderer>().material;
            action.Invoke(mat);
        }
    }
}
