using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

namespace MDPro3
{
    public class MaterialLoader : MonoBehaviour
    {
        private static readonly ConcurrentDictionary<string, Material> _loadedMaterials = new();
        private static readonly ConcurrentDictionary<string, IEnumerator<Material>> _loadingCoroutines = new();

        private static MaterialLoader instance;

        private void Awake()
        {
            instance = this;
        }
        private IEnumerator<Material> LoadMaterialCoroutine(string materialName)
        {
            var loadOperation = ABLoader.LoadMaterialAsync("MasterDuel/Material/" + materialName);
            while (loadOperation.MoveNext())
                yield return null;

            _loadedMaterials.TryAdd(materialName, loadOperation.Current);
            _loadingCoroutines.TryRemove(materialName, out _);
            yield return loadOperation.Current;
        }

        public static IEnumerator<Material> LoadMaterialByNameAsync(string materialName)
        {
            if (_loadedMaterials.TryGetValue(materialName, out var material))
            {
                yield return material;
                yield break;
            }

            IEnumerator<Material> coroutine;
            if (!_loadingCoroutines.ContainsKey(materialName))
            {
                coroutine = instance.LoadMaterialCoroutine(materialName);
                _loadingCoroutines.TryAdd(materialName, coroutine);
            }
            else
                _loadingCoroutines.TryGetValue(materialName, out coroutine);
            while (coroutine.MoveNext())
                yield return null;
            yield return coroutine.Current;
        }
    }
}
