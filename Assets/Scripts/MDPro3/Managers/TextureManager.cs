using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using YgomSystem.ElementSystem;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using DG.Tweening;
using UnityEngine.UI;
using MDPro3.Utility;
using System.Collections.Concurrent;

namespace MDPro3
{
    public class TextureManager : Manager
    {
        public static TextureManager instance;
        public static TextureContainer container;

        static ConcurrentDictionary<int, Texture2D> cachedArts = new();
        static ConcurrentDictionary<int, Texture2D> cachedCards = new();
        static ConcurrentDictionary<int, Texture2D> cachedMasks = new();

        public static Material cardMatNormal;
        public static Material cardMatShine;
        public static Material cardMatShineRD;
        public static Material cardMatRoyal;
        public static Material cardMatRoyalRD;
        public static Material cardMatGold;
        public static Material cardMatGoldRD;
        public static Material cardMatMillennium;
        public static Material cardMatMillenniumRD;
        public static Material cardMatSide;

        private Material commonShopButtonMat;
        private Material commonShopButtonOverMat;


        static int cardLoadCount;
        const int cardLoadMax = 100;

        public static bool lastCardFoundArt;
        public static bool lastCardRenderSucceed;
        public override void Initialize()
        {
            instance = this;
            base.Initialize();
            var handle = Addressables.LoadAssetAsync<TextureContainer>("TextureContainer");
            handle.Completed += (result) =>
            {
                container = result.Result;
            };
            StartCoroutine(LoadMaterials());
        }

        private IEnumerator LoadMaterials()
        {
            while(container == null)
                yield return null;

            var ie = ABLoader.LoadFromFileAsync("MasterDuel/Timeline/summon/summonsynchro/summonsynchro01", true);
            while (ie.MoveNext())
                yield return null;
            var manager = ie.Current.GetComponent<ElementObjectManager>();
            manager.gameObject.SetActive(false);
            Destroy(manager.gameObject);
            manager = manager.GetElement<ElementObjectManager>("SummonSynchroPostSynchro");
            manager = manager.GetElement<ElementObjectManager>("DummyCardSynchro");
            cardMatNormal = Instantiate(manager.GetElement<Renderer>("DummyCardModel_front").material);
            var handle = Addressables.LoadAssetAsync<Material>("MaterialCardModelSide");
            handle.Completed += (result) =>
            {
                cardMatSide = result.Result;
            };

            ie = ABLoader.LoadFromFileAsync("MasterDuel/Timeline/summon/summonsynchro/summonsynchro01_royalstyle");
            while (ie.MoveNext())
                yield return null;
            manager = ie.Current.GetComponent<ElementObjectManager>();
            manager.gameObject.SetActive(false);
            Destroy(manager.gameObject);
            manager = manager.GetElement<ElementObjectManager>("SummonSynchroPostSynchro");
            manager = manager.GetElement<ElementObjectManager>("DummyCardSynchro");
            cardMatRoyal = Instantiate(manager.GetElement<Renderer>("DummyCardModel_front").material);

            ie = ABLoader.LoadFromFileAsync("MasterDuel/Timeline/summon/summonsynchro/summonsynchro01_shinestyle");
            while (ie.MoveNext())
                yield return null;
            manager = ie.Current.GetComponent<ElementObjectManager>();
            manager.gameObject.SetActive(false);
            Destroy(manager.gameObject);
            manager = manager.GetElement<ElementObjectManager>("SummonSynchroPostSynchro");
            manager = manager.GetElement<ElementObjectManager>("DummyCardSynchro");
            cardMatShine = Instantiate(manager.GetElement<Renderer>("DummyCardModel_front").material);

            cardMatNormal.SetFloat("_FakeBlend", 1);
            cardMatNormal.SetColor("_AmbientColor", new Color(0.0588f, 0.0588f, 0.0588f, 1f));
            cardMatShine.SetFloat("_FakeBlend", 1);
            cardMatRoyal.SetFloat("_FakeBlend", 1);

            cardMatShine.SetVector("_AttributeSize_Pos", new Vector4(9.82f, 13.84f, -3.7f, -5.81f));
            cardMatRoyal.SetVector("_AttributeSize_Pos", new Vector4(9.82f, 13.84f, -3.7f, -5.81f));

            while (container == null)
                yield return null;
            cardMatShine.SetTexture("_KiraMask", container.cardKiraMask);
            cardMatRoyal.SetTexture("_KiraMask", container.cardKiraMask);
            var tempTex = cardMatRoyal.GetTexture("_Texture2DAsset_90c6e35ef4304f289c279037152a03b7_Out_0");
            cardMatNormal.SetTexture("_Texture2DAsset_90c6e35ef4304f289c279037152a03b7_Out_0", tempTex);
            tempTex = cardMatRoyal.GetTexture("_HighlightNormal");
            cardMatRoyal.SetTexture("_Texture2DAsset_3e204bf62e854283be7482d92655b24f_Out_0", tempTex);

            cardMatNormal.enableInstancing = true;
            cardMatShine.enableInstancing = true;
            cardMatRoyal.enableInstancing = true;
            //cardMatNormal.DisableKeyword("_ALPHATEST_ON");
            //cardMatShine.DisableKeyword("_ALPHATEST_ON");
            //cardMatRoyal.DisableKeyword("_ALPHATEST_ON");

            cardMatGold = Instantiate(cardMatRoyal);
            cardMatGold.SetFloat("_CardDistortion01", 1.2f);
            cardMatGold.SetFloat("_Kira01_01Tile", 0.25f);
            cardMatGold.SetFloat("_Kira01_01Power", 3f);
            cardMatGold.SetColor("_KiraColor02", new Color(0.5f, 0.5f, 0f, 0f));
            cardMatGold.SetColor("_CubemapColor", new Color(0.7f, 0.7f, 0f, 0f));

            cardMatMillennium = Instantiate(cardMatRoyal);
            cardMatMillennium.SetTexture("_HighlightNormal", container.CardKiraNormal03_Millennium);
            cardMatMillennium.SetTexture("_Texture2DAsset_3e204bf62e854283be7482d92655b24f_Out_0", container.CardKiraNormal03_Millennium);
            cardMatMillennium.SetColor("_CubemapColor", new Color(0.898f, 0.3245f, 0.7723f, 0f));
            cardMatMillennium.SetColor("_KiraColor02", new Color(0.3099f, 0.1633f, 0.2753f, 0f));
            cardMatMillennium.SetFloat("_Kira01_01Tile", 0.25f);
            cardMatMillennium.SetFloat("_Kira01_02Tile", 0f);
            cardMatMillennium.SetFloat("_RanbowPower", 0.5f);
            //cardMatMillennium.SetFloat("_IlluustRanbowPower", 1.5f);

            cardMatShineRD = Instantiate(cardMatShine);
            MaterialToRD(cardMatShineRD);

            cardMatRoyalRD = Instantiate(cardMatRoyal);
            MaterialToRD(cardMatRoyalRD);

            cardMatGoldRD = Instantiate(cardMatGold);
            MaterialToRD(cardMatGoldRD);

            cardMatMillenniumRD = Instantiate(cardMatMillennium);
            MaterialToRD(cardMatMillenniumRD);

            var mie = ABLoader.LoadMaterialAsync("MasterDuel/Material/GUI_CommonShopButton_N");
            while (mie.MoveNext())
                yield return null;
            commonShopButtonMat = mie.Current;
            SetCommonShopButtonMaterial(commonShopButtonMat);

            mie = ABLoader.LoadMaterialAsync("MasterDuel/Material/GUI_CommonShopButton_N_Over");
            while (mie.MoveNext())
                yield return null;
            commonShopButtonOverMat = mie.Current;
            SetCommonShopButtonMaterial(commonShopButtonOverMat);

#if UNITY_ANDROID
            var depens = Directory.GetFiles(Program.root + "CrossDuel/Dependency", "*.bundle");
            foreach (var depen in depens)
            {
                var cache = ABLoader.CacheFromFileAsync(Program.root + "CrossDuel/Dependency/" + Path.GetFileName(depen));
                StartCoroutine(cache);
                while (cache.MoveNext())
                    yield return null;
            }
#endif
        }

        private void MaterialToRD(Material material)
        {
            material.SetTexture("_FrameMask", container.rd_Mask);
            material.SetTexture("_KiraMask", container.rd_KiraMask);
            material.SetTexture("_MainNormal", container.rd_CardNormal);
            material.SetTexture("_AttributeTex", container.rd_CardAttributeSet);
            material.SetVector("_AttributeSize_Pos", new Vector4(8.31f, 12.26f, -3.19f, -5.13f));
        }

        public static async Task<Texture2D> LoadPicFromFileAsync(string path)
        {
            if (!File.Exists(path))
                return null;
            string fullPath;
#if !UNITY_EDITOR && UNITY_ANDROID
            fullPath = "file://" + Application.persistentDataPath + Program.slash + path;
#else
            fullPath = Environment.CurrentDirectory + Program.slash + path;
#endif
            using var request = UnityWebRequestTexture.GetTexture(fullPath);
            var send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if(!Application.isPlaying)
                return null;

            if (request.result == UnityWebRequest.Result.Success)
                return DownloadHandlerTexture.GetContent(request);
            else
            {
                Debug.LogWarningFormat("Pic File [{0}] not fount.", path);
                return null;
            }
        }

        public static async Task<Texture2D> LoadArtAsync(int code, bool cache = false)
        {
            Texture2D returnValue = null;
            var path = Program.altArtPath + code;
            if (!Directory.Exists(Program.artPath))
                Directory.CreateDirectory(Program.artPath);
            if (!Directory.Exists(Program.altArtPath))
                Directory.CreateDirectory(Program.altArtPath);

            lock (cachedArts)
            {
                if(cachedArts.TryGetValue(code, out returnValue))
                    return returnValue;
            }

            if (File.Exists(path + Program.jpgExpansion))
                path += Program.jpgExpansion;
            else if (File.Exists(path + Program.pngExpansion))
                path += Program.pngExpansion;
            else if (File.Exists(Program.artPath + code.ToString() + Program.jpgExpansion))
                path = Program.artPath + Program.slash + code.ToString() + Program.jpgExpansion;
            else
            {
                //Load From YPK art Folder
                foreach (var zip in ZipHelper.zips)
                {
                    if (zip.Name.ToLower().EndsWith("script.zip"))
                        continue;
                    foreach (var file in zip.EntryFileNames)
                    {
                        foreach (var extName in new[] { Program.pngExpansion, Program.jpgExpansion })
                        {
                            var picPath = $"art/{code}{extName}";
                            if (file.ToLower() == picPath)
                            {
                                returnValue = new Texture2D(0, 0);
                                MemoryStream stream = new MemoryStream();
                                var entry = zip[picPath];
                                entry.Extract(stream);
                                returnValue.LoadImage(stream.ToArray());
                            }
                        }
                    }
                }
                //Load From YPK pics Folder
                if (returnValue == null)
                {
                    foreach (var zip in ZipHelper.zips)
                    {
                        if (zip.Name.ToLower().EndsWith("script.zip"))
                            continue;
                        foreach (var file in zip.EntryFileNames)
                        {
                            foreach (var extName in new[] { Program.pngExpansion, Program.jpgExpansion })
                            {
                                var picPath = $"pics/{code}{extName}";
                                if (file.ToLower() == picPath)
                                {
                                    returnValue = new Texture2D(0, 0);
                                    MemoryStream stream = new MemoryStream();
                                    var entry = zip[picPath];
                                    entry.Extract(stream);
                                    returnValue.LoadImage(stream.ToArray());
                                    var card = CardsManager.Get(code);
                                    if (code >= 120000000 && code < 130000000)
                                    {
                                        if (card.HasType(CardType.Monster))
                                            returnValue = GetArtFromRushDuelMonsterCard(returnValue);
                                        else
                                            returnValue = GetArtFromRushDuelSpellCard(returnValue);
                                    }
                                    else if (card.HasType(CardType.Pendulum))
                                        returnValue = GetArtFromPendulumCard(returnValue);
                                    else
                                        returnValue = GetArtFromCard(returnValue);
                                }
                            }
                        }
                    }
                }
            }

            if (returnValue == null)
            {
                var task = LoadPicFromFileAsync(path);
                await TaskUtility.WaitUntil(() => task.IsCompleted);
                if (!Application.isPlaying)
                    return null;

                returnValue = task.Result;
            }

            if (returnValue == null)
            {
                lastCardFoundArt = false;
                return container.unknownArt.texture;
            }
            else
            {
                lastCardFoundArt = true;

                if (Program.instance.ocgcore.showing)
                    cache = true;

                if (cache)
                {
                    lock (cachedArts)
                    {
                        if (!cachedArts.ContainsKey(code))
                            cachedArts[code] = returnValue;
                        else
                        {
                            Destroy(returnValue);
                            returnValue = cachedArts[code];
                        }
                    }
                }
                return returnValue;
            }
        }

        public static async Task<Texture2D> LoadCardAsync(int code, bool cache = false)
        {
            if (cachedCards.TryGetValue(code, out var returnValue))
                return returnValue;

            lastCardRenderSucceed = true;

            while (container == null)
                await Task.Delay(100);
            if(!Application.isPlaying)
                return null;

            var data = CardsManager.Get(code, true);
            if (data.Id == 0)
            {
                lastCardRenderSucceed = false;
                return container.unknownCard.texture;
            }

            var task = LoadArtAsync(code, false);
            await TaskUtility.WaitUntil(() => task.IsCompleted);
            if(!Application.isPlaying)
                return null;

            if (Program.instance.ocgcore.showing)
                cache = true;

            lock (cachedCards)
            {
                if (!Program.instance.cardRenderer.RenderCard(code, task.Result))
                {
                    if (cache)
                        if (!cachedCards.ContainsKey(code))
                            cachedCards.TryAdd(code, container.unknownCard.texture);
                    lastCardRenderSucceed = false;
                    return container.unknownCard.texture;
                }

                returnValue = new Texture2D(RenderTexture.active.width, RenderTexture.active.height, TextureFormat.RGB24, true);
                returnValue.ReadPixels(new Rect(0, 0, RenderTexture.active.width, RenderTexture.active.height), 0, 0);
                returnValue.Apply();
                returnValue.name = "Card_" + code;

                if (cache)
                {
                    if (!cachedCards.ContainsKey(code))
                        cachedCards.TryAdd(code, returnValue);
                    else
                    {
                        Destroy(returnValue);
                        returnValue = cachedCards[code];
                    }
                }
            }

            cardLoadCount++;
            if(cardLoadCount >= cardLoadMax)
            {
                cardLoadCount = 0;
                Program.instance.UnloadUnusedAssets();
            }

            return returnValue;

        }

        public IEnumerator LoadCardToRawImageWithoutMaterialAsync(RawImage rawImage, int code, bool cache = true)
        {
            var task = LoadCardAsync(code, cache);
            while (!task.IsCompleted)
                yield return null;

            if (rawImage == null)
                yield break;

            rawImage.texture = task.Result;
        }

        public IEnumerator LoadCardToRendererWithMaterialAsync(Renderer renderer, int code, bool cache = true)
        {
            var task = LoadCardAsync(code, cache);
            while (!task.IsCompleted)
                yield return null;

            if (renderer == null)
                yield break;

            var mat = GetCardMaterial(code, cache);
            mat.mainTexture = task.Result;
            renderer.material = mat;
        }
        public IEnumerator LoadDummyCard(ElementObjectManager manager, int code, uint player, bool active = false)
        {
            if (active)
                manager.gameObject.SetActive(false);
            manager.GetElement<Renderer>("DummyCardModel_side").material = cardMatSide;
            manager.GetElement<Renderer>("DummyCardModel_back").material = player == 0 ? Program.instance.ocgcore.myProtector : Program.instance.ocgcore.opProtector;

            var task = LoadCardAsync(code, false);
            while (!task.IsCompleted)
                yield return null;

            var mat = GetCardMaterial(code);
            manager.GetElement<Renderer>("DummyCardModel_front").material = mat;
            manager.GetElement<Renderer>("DummyCardModel_front").material.mainTexture = task.Result;
            if (active)
                manager.gameObject.SetActive(true);
        }
        public static void ClearCache()
        {
            foreach (var card in cachedCards.Values)
                Destroy(card);
            cachedCards.Clear();
            foreach (var mask in cachedMasks.Values)
                Destroy(mask);
            cachedMasks.Clear();
        }

        private void SetCommonShopButtonMaterial(Material mat)
        {
            mat.SetFloat("_NoiseSize", 500f);
            mat.SetFloat("_NoiseSpeed", 0.5f);
            mat.SetVector("_TilingOffset", new Vector4(1f, 1f, 0f, 0f));
            mat.SetVector("_MainTexMinMax", new Vector4(-0.5f, 1f, -0.5f, 1f));
        }
        public IEnumerator SetCommonShopButtonMaterial(Image image, bool hover)
        {
            if (hover)
            {
                while(commonShopButtonOverMat == null)
                    yield return null;
                image.material = commonShopButtonOverMat;
            }
            else
            {
                while (commonShopButtonMat == null)
                    yield return null;
                image.material = commonShopButtonMat;
            }
        }

        #region Closeup
        static Dictionary<int, Texture2D> cachedCloseups = new Dictionary<int, Texture2D>();
        public IEnumerator<Texture2D> LoadCloseupAsync(int code, MeshRenderer renderer = null)
        {
            if(renderer != null)
                renderer.gameObject.SetActive(false);
            if (cachedCloseups.TryGetValue(code, out var returenValue))
            {
                if (renderer != null)
                    ResizeCloseup(renderer, returenValue);
                yield return returenValue;
                yield break;
            }
            if (!Directory.Exists(Program.closeupPath))
                Directory.CreateDirectory(Program.closeupPath);
            var path = Program.closeupPath + code + Program.pngExpansion;
            if (!File.Exists(path))
                yield break;

            var task = LoadPicFromFileAsync(path);
            while(!task.IsCompleted)
                yield return null;
            returenValue = task.Result;

            returenValue.name = "Closeup_" + code;
            if (cachedCloseups.ContainsKey(code))
            {
                Destroy(returenValue);
                returenValue = cachedCloseups[code];
            }
            else
                cachedCloseups.Add(code, returenValue);
            if (renderer != null)
                ResizeCloseup(renderer, returenValue);
            yield return returenValue;
        }
        void ResizeCloseup(MeshRenderer renderer, Texture2D tex)
        {
            renderer.material.mainTexture = tex;
            var aspect = (float)tex.width / tex.height;
            renderer.transform.localScale = new Vector3 (8f * aspect, 8f, 1f);
            renderer.gameObject.SetActive(true);
            DOTween.To(() => 0f, x =>
            {
                renderer.transform.localScale = new Vector3(x * aspect, x, 1f);
            }, 8f, 0.3f);
        }
        #endregion

        #region Card Render
        public Texture2D GetNameMask(int code, bool cache = false)
        {
            if (cachedMasks.ContainsKey(code))
                return cachedMasks[code];
            Texture2D returnValue;
            RenderTexture.active = Program.instance.cardRenderer.renderTexture;
            Program.instance.cardRenderer.RenderName(code);
            returnValue = new Texture2D(RenderTexture.active.width, 203, TextureFormat.RGBA32, false);
            var rect = new Rect(0, Program.instance.cardRenderer.renderTexture.height - 203, Program.instance.cardRenderer.renderTexture.width, 203);
            //if (SystemInfo.graphicsUVStartsAtTop)
            //    rect = new Rect(0, 0, Program.instance.cardRenderer.renderTexture.width, 203); 
            returnValue.ReadPixels(rect, 0, 0);
            returnValue.Apply();
            returnValue.wrapMode = TextureWrapMode.Clamp;
            if (cache)
                cachedMasks.TryAdd(code, returnValue);
            return returnValue;
        }
        public static Material GetCardMaterial(int code, bool cache = false)
        {
            if (code < 0)
                return Instantiate(cardMatNormal);

            bool rushDuel = CardRenderer.NeedRushDuelStyle(code);
            var rarity = CardRarity.GetRarity(code);

            Material mat = null;
            bool needChange = false;
            switch (rarity)
            {
                case CardRarity.Rarity.Normal:
                    mat = Instantiate(cardMatNormal);
                    break;
                case CardRarity.Rarity.Shine:
                    mat = Instantiate(rushDuel ? cardMatShineRD : cardMatShine);
                    needChange = true;
                    break;
                case CardRarity.Rarity.Royal:
                    mat = Instantiate(rushDuel ? cardMatRoyalRD : cardMatRoyal);
                    needChange = true;
                    break;
                case CardRarity.Rarity.Gold:
                    mat = Instantiate(rushDuel ? cardMatGoldRD : cardMatGold);
                    needChange = true;
                    break;
                case CardRarity.Rarity.Millennium:
                    mat = Instantiate(rushDuel ? cardMatMillenniumRD : cardMatMillennium);
                    needChange = true;
                    break;
            }
            if (needChange)
            {
                var data = CardsManager.Get(code);
                if (data.HasType(CardType.Spell))
                    mat.SetFloat("_AttributeTile", 7);
                else if (data.HasType(CardType.Trap))
                    mat.SetFloat("_AttributeTile", 8);
                else if ((data.Attribute & (uint)CardAttribute.Light) > 0)
                    mat.SetFloat("_AttributeTile", 0);
                else if ((data.Attribute & (uint)CardAttribute.Dark) > 0)
                    mat.SetFloat("_AttributeTile", 1);
                else if ((data.Attribute & (uint)CardAttribute.Water) > 0)
                    mat.SetFloat("_AttributeTile", 2);
                else if ((data.Attribute & (uint)CardAttribute.Fire) > 0)
                    mat.SetFloat("_AttributeTile", 3);
                else if ((data.Attribute & (uint)CardAttribute.Earth) > 0)
                    mat.SetFloat("_AttributeTile", 4);
                else if ((data.Attribute & (uint)CardAttribute.Wind) > 0)
                    mat.SetFloat("_AttributeTile", 5);
                else if ((data.Attribute & (uint)CardAttribute.Divine) > 0)
                    mat.SetFloat("_AttributeTile", 6);
                var mask = Program.instance.texture_.GetNameMask(code, cache);
                mat.SetTexture("_MonsterNameTex", mask);
                if (rushDuel)
                {
                    if (data.HasType(CardType.Pendulum))
                    {
                        mat.SetTexture("_KiraMask", container.rd_KiraMaskPendulum);
                    }
                }
                else
                {
                    if (data.HasType(CardType.Link))
                    {
                        mat.SetTexture("_FrameMask", container.cardFrameMaskLink);
                        mat.SetTexture("_KiraMask", container.cardKiraMaskLink);
                        mat.SetTexture("_MainNormal", container.cardNormalLink);
                        if (rarity == CardRarity.Rarity.Shine)
                            mat.SetFloat("_LinkOn_Off", 1f);
                    }
                    else if (data.HasType(CardType.Pendulum))
                    {
                        mat.SetTexture("_FrameMask", container.cardFrameMaskPendulum);
                        mat.SetTexture("_KiraMask", container.cardKiraMaskPendulum);
                        mat.SetTexture("_MainNormal", container.cardNormalPendulum);
                    }
                }
                if(rarity == CardRarity.Rarity.Millennium)
                {
                    mat.SetColor("_KiraColor02", GetMillenniumFrameColor(data));
                    mat.SetColor("_CubemapColor", GetMillenniumNameColor(data));
                }
            }
            return mat;
        }

        static Color GetMillenniumFrameColor(Card data)
        {
            var color = new Color(0.3099f, 0.1633f, 0.2753f, 0f);
            if (data.HasType(CardType.Pendulum))
                color = new Color(0.3099f, 0.1633f, 0.2753f, 0f);
            else if (data.HasType(CardType.Spell))
                color = new Color(0f, 0.8867f, 1f, 0f);
            else if (data.HasType(CardType.Trap))
                color = new Color(1f, 0f, 1f, 0f);
            else if (data.HasType(CardType.Normal))
                color = new Color(1f, 0.6f, 0f, 0f);
            else if (data.HasType(CardType.Fusion))
                color = new Color(1f, 0f, 1f, 0f);
            else if (data.HasType(CardType.Ritual))
                color = new Color(0f, 0.2f, 1f, 0f);
            else if (data.HasType(CardType.Synchro))
                color = new Color(0.4f, 0.4f, 0.4f, 0f);
            else if (data.HasType(CardType.Xyz))
                color = new Color(0.1f, 0.1f, 0.1f, 0f);
            else if (data.HasType(CardType.Link))
                color = new Color(0f, 0.4f, 1f, 0f);
            else
                color = new Color(1f, 0.2357f, 0f, 0f);
            return color;
        }
        static Color GetMillenniumNameColor(Card data)
        {
            if (data.HasType(CardType.Spell))
                return new Color(0f, 1f, 1f, 1f);
            else if (data.HasType(CardType.Trap))
                return new Color(1f, 0f, 0.5f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Light) > 0)
                return new Color(1f, 1f, 0f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Divine) > 0)
                return new Color(1f, 1f, 0f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Dark) > 0)
                return new Color(1f, 0f, 1f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Water) > 0)
                return new Color(0f, 1f, 1f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Fire) > 0)
                return new Color(1f, 0f, 0f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Earth) > 0)
                return new Color(0.2f, 0.2f, 0.2f, 1f);
            else if ((data.Attribute & (uint)CardAttribute.Wind) > 0)
                return new Color(0f, 1f, 0f, 1f);
            else
                return new Color(1f, 1f, 0f, 1f);
        }

        #endregion

        #region Card UI
        public static Sprite GetCardLocationIcon(GPS p)
        {
            if ((p.location & (uint)CardLocation.Hand) > 0)
                return container.locationHand;
            else if ((p.location & (uint)CardLocation.Deck) > 0)
                return container.locationDeck;
            else if ((p.location & (uint)CardLocation.Extra) > 0)
                return container.locationExtra;
            else if ((p.location & (uint)CardLocation.Grave) > 0)
                return container.locationGrave;
            else if ((p.location & (uint)CardLocation.Removed) > 0)
                return container.locationRemoved;
            else if ((p.location & (uint)CardLocation.Overlay) > 0)
                return container.locationOverlay;
            else if ((p.location & (uint)CardLocation.Onfield) > 0)
            {
                if(p.controller == 0)
                    return container.locationMyField;
                else
                    return container.locationOpField;
            }
            else if ((p.location & (uint)CardLocation.Search) > 0)
                return container.locationSearch;
            else
                return container.typeNone;
        }
        public static Sprite GetCardAttributeIcon(int attribute, int code, bool render = false)
        {
            bool rushDuel = CardRenderer.NeedRushDuelStyle(code);
            if ((attribute & (uint)CardAttribute.Light) > 0)
                return rushDuel && render ? container.rd_Attribute_Light : container.attributeLight;
            else if ((attribute & (uint)CardAttribute.Dark) > 0)
                return rushDuel && render ? container.rd_Attribute_Dark : container.attributeDark;
            else if ((attribute & (uint)CardAttribute.Water) > 0)
                return rushDuel && render ? container.rd_Attribute_Water : container.attributeWater;
            else if ((attribute & (uint)CardAttribute.Fire) > 0)
                return rushDuel && render ? container.rd_Attribute_Fire : container.attributeFire;
            else if ((attribute & (uint)CardAttribute.Earth) > 0)
                return rushDuel && render ? container.rd_Attribute_Earth : container.attributeEarth;
            else if ((attribute & (uint)CardAttribute.Wind) > 0)
                return rushDuel && render ? container.rd_Attribute_Wind : container.attributeWind;
            else
                return rushDuel && render ? container.rd_Attribute_Divine : container.attributeDivine;
        }
        public static Sprite GetCardRaceIcon(int race)
        {
            if ((race & (uint)CardRace.Warrior) > 0)
                return container.raceWarrior;
            else if ((race & (uint)CardRace.SpellCaster) > 0)
                return container.raceSpellCaster;
            else if ((race & (uint)CardRace.Fairy) > 0)
                return container.raceFairy;
            else if ((race & (uint)CardRace.Fiend) > 0)
                return container.raceFiend;
            else if ((race & (uint)CardRace.Zombie) > 0)
                return container.raceZombie;
            else if ((race & (uint)CardRace.Machine) > 0)
                return container.raceMachine;
            else if ((race & (uint)CardRace.Aqua) > 0)
                return container.raceAqua;
            else if ((race & (uint)CardRace.Pyro) > 0)
                return container.racePyro;
            else if ((race & (uint)CardRace.Rock) > 0)
                return container.raceRock;
            else if ((race & (uint)CardRace.WindBeast) > 0)
                return container.raceWindBeast;
            else if ((race & (uint)CardRace.Plant) > 0)
                return container.racePlant;
            else if ((race & (uint)CardRace.Insect) > 0)
                return container.raceInsect;
            else if ((race & (uint)CardRace.Thunder) > 0)
                return container.raceThunder;
            else if ((race & (uint)CardRace.Dragon) > 0)
                return container.raceDragon;
            else if ((race & (uint)CardRace.Beast) > 0)
                return container.raceBeast;
            else if ((race & (uint)CardRace.BeastWarrior) > 0)
                return container.raceBeastWarrior;
            else if ((race & (uint)CardRace.Dinosaur) > 0)
                return container.raceDinosaur;
            else if ((race & (uint)CardRace.Fish) > 0)
                return container.raceFish;
            else if ((race & (uint)CardRace.SeaSerpent) > 0)
                return container.raceSeaSerpent;
            else if ((race & (uint)CardRace.Reptile) > 0)
                return container.raceReptile;
            else if ((race & (uint)CardRace.Psycho) > 0)
                return container.racePsycho;
            else if ((race & (uint)CardRace.DivineBeast) > 0)
                return container.raceDivineBeast;
            else if ((race & (uint)CardRace.CreatorGod) > 0)
                return container.raceCreatorGod;
            else if ((race & (uint)CardRace.Wyrm) > 0)
                return container.raceWyrm;
            else if ((race & (uint)CardRace.Cyberse) > 0)
                return container.raceCyberse;
            else if ((race & (uint)CardRace.Illustion) > 0)
                return container.raceIllustion;
            else
                return container.typeNone;
        }
        public static Sprite GetSpellTrapTypeIcon(Card data)
        {
            if (data.HasType(CardType.Counter))
                return container.typeCounter;
            else if (data.HasType(CardType.Field))
                return container.typeField;
            else if (data.HasType(CardType.Equip))
                return container.typeEquip;
            else if (data.HasType(CardType.Continuous))
                return container.typeContinuous;
            else if (data.HasType(CardType.QuickPlay))
                return container.typeQuickPlay;
            else if (data.HasType(CardType.Ritual))
                return container.typeRitual;
            else
                return container.typeNone;
        }
        public static Sprite GetCardLevelIcon(Card data)
        {
            if (data.HasType(CardType.Link))
                return container.typeLink;
            else if (data.HasType(CardType.Xyz))
                return container.typeRank;
            else
                return container.typeLevel;
        }
        public static Sprite GetCardCounterIcon(int counter)
        {
            return counter switch
            {
                0x1 => container.counterMagic,
                0x1002 => container.counterWedge,
                0x3 => container.counterBushido,
                0x4 => container.counterPsycho,
                0x5 => container.counterShine,
                0x6 => container.counterGem,
                0x8 => container.counterDeformer,
                0x1009 => container.counterVenom,
                0xA => container.counterGenex,
                0xC => container.counterThunder,
                0xD => container.counterGreed,
                0x100E => container.counterAlien,
                0xF => container.counterWorm,
                0x10 => container.counterBF,
                0x11 => container.counterHyper,
                0x12 => container.counterKarakuri,
                0x13 => container.counterChaos,
                0x1015 => container.counterIce,
                0x16 => container.counterStone,
                0x17 => container.counterDonguri,
                0x18 => container.counterFlower,
                0x1019 => container.counterFog,
                0x1A => container.counterDouble,
                0x1B => container.counterClock,
                0x1C => container.counterD,
                0x1D => container.counterJunk,
                0x1E => container.counterGate,
                0x20 => container.counterPlant,
                0x1021 => container.counterGuard2,
                0x22 => container.counterDragonic,
                0x23 => container.counterOcean,
                0x1024 => container.counterString,
                0x25 => container.counterChronicle,
                0x2B => container.counterDestiny,
                0x2C => container.counterOrbital,
                0x2E => container.counterShark,
                0x2F => container.counterPumpkin,
                0x30 => container.counterKattobing,
                0x31 => container.counterHopeSlash,
                0x32 => container.counterBalloon,
                0x33 => container.counterYosen,
                0x35 => container.counterSound,
                0x36 => container.counterEM,
                0x37 => container.counterKaiju,
                0x1038 => container.counterHoukai,
                0x1039 => container.counterZushin,
                0x1041 => container.counterPredator,
                0x43 => container.counterDefect,
                0x1045 => container.counterScales,
                0x1049 => container.counterPolice,
                0x4A => container.counterAthlete,
                0x4B => container.counterBarrel,
                0x4C => container.counterSummon,
                0x104D => container.counterSignal,
                0x104F => container.counterVenemy,
                0x56 => container.counterFireStar,
                0x57 => container.counterPhantasm,
                0x59 => container.counterOtoshidama,
                0x105C => container.counterBurn,
                0x5E => container.counterOunokagi,
                0x5F => container.counterPiece,
                0x1063 => container.counterIllusion,
                0x64 => container.counterGG,
                0x1065 => container.counterRabbit,
                0x6A => container.counterKyoumei,
                0x102A => container.counterGardna,
                _ => container.counterNormal,
            };
        }
        #endregion

        #region Crop Texture
        public static Texture2D GetArtFromCard(Texture2D cardPic)
        {
            var startX = Mathf.CeilToInt(cardPic.width * 0.13f);
            var startY = Mathf.CeilToInt(cardPic.height * 0.3f);
            var width = Mathf.CeilToInt(cardPic.width * 0.87f);
            var height = Mathf.CeilToInt(cardPic.height * 0.81f);
            return GetCroppingTex(cardPic, startX, startY, width, height);
        }
        public static Texture2D GetArtFromPendulumCard(Texture2D cardPic)
        {
            var startX = Mathf.CeilToInt(cardPic.width * 0.067f);
            var startY = Mathf.CeilToInt(cardPic.height * 0.38f);
            var width = Mathf.CeilToInt(cardPic.width * 0.933f);
            var height = Mathf.CeilToInt(cardPic.height * 0.81f);
            return GetCroppingTex(cardPic, startX, startY, width, height);
        }
        public static Texture2D GetArtFromRushDuelMonsterCard(Texture2D cardPic)
        {
            var startX = Mathf.CeilToInt(cardPic.width * 0.067f);
            var startY = Mathf.CeilToInt(cardPic.height * 0.29f);
            var width = Mathf.CeilToInt(cardPic.width * 0.933f);
            var height = Mathf.CeilToInt(cardPic.height * 0.90f);
            return GetCroppingTex(cardPic, startX, startY, width, height);
        }
        public static Texture2D GetArtFromRushDuelSpellCard(Texture2D cardPic)
        {
            var startX = Mathf.CeilToInt(cardPic.width * 0.067f);
            var startY = Mathf.CeilToInt(cardPic.height * 0.29f);
            var width = Mathf.CeilToInt(cardPic.width * 0.933f);
            var height = Mathf.CeilToInt(cardPic.height * 0.90f);
            return GetCroppingTex(cardPic, startX, startY, width, height);
        }
        public static Texture2D GetCroppingTex(Texture2D texture, int startX, int startY, int width, int height)
        {
            var returnValue = new Texture2D(width - startX, height - startY);
            var pix = new Color[returnValue.width * returnValue.height];
            var index = 0;
            for (var y = startY; y < height; y++)
                for (var x = startX; x < width; x++)
                    pix[index++] = texture.GetPixel(x, y);
            returnValue.SetPixels(pix);
            returnValue.Apply();
            return returnValue;
        }
        #endregion

        #region Public Static Functions

        public static Texture2D ResizeTexture2D(Texture2D texture, int newWidth, int newHeight)
        {
            var returnValue = new Texture2D(newWidth, newHeight);
            var resizePixels = ResizePixelsBilinear(texture.GetPixels(), texture.width, texture.height, newWidth, newHeight);
            returnValue.SetPixels(resizePixels);
            returnValue.Apply();
            Destroy(texture);
            return returnValue;
        }

        public static Color[] ResizePixelsNearest(Color[] originalPixels, int originalWidth, int originalHeight, int newWidth, int newHeight)
        {
            Color[] newPixels = new Color[newWidth * newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int origX = (int)((float)x / newWidth * originalWidth);
                    int origY = (int)((float)y / newHeight * originalHeight);

                    newPixels[y * newWidth + x] = originalPixels[origY * originalWidth + origX];
                }
            }

            return newPixels;
        }

        public static Color BilinearInterpolation(Color c1, Color c2, Color c3, Color c4, float u, float v)
        {
            // Perform linear interpolation in the horizontal direction.
            Color c12 = new Color(
                c1.r * (1 - u) + c2.r * u,
                c1.g * (1 - u) + c2.g * u,
                c1.b * (1 - u) + c2.b * u,
                c1.a * (1 - u) + c2.a * u);

            Color c34 = new Color(
                c3.r * (1 - u) + c4.r * u,
                c3.g * (1 - u) + c4.g * u,
                c3.b * (1 - u) + c4.b * u,
                c3.a * (1 - u) + c4.a * u);

            // Then perform linear interpolation in the vertical direction.
            return new Color(
                c12.r * (1 - v) + c34.r * v,
                c12.g * (1 - v) + c34.g * v,
                c12.b * (1 - v) + c34.b * v,
                c12.a * (1 - v) + c34.a * v);
        }

        public static Color[] ResizePixelsBilinear(Color[] originalPixels, int originalWidth, int originalHeight, int newWidth, int newHeight)
        {
            Color[] newPixels = new Color[newWidth * newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    float origX = ((float)x / newWidth) * originalWidth;
                    float origY = ((float)y / newHeight) * originalHeight;

                    int floorX = (int)Math.Floor(origX);
                    int floorY = (int)Math.Floor(origY);
                    int ceilX = Math.Min(floorX + 1, originalWidth - 1); // Ensure not to go out of bounds
                    int ceilY = Math.Min(floorY + 1, originalHeight - 1); // Ensure not to go out of bounds

                    if (floorX == ceilX || floorY == ceilY)
                    {
                        // Avoid division by zero and handle edge cases.
                        newPixels[y * newWidth + x] = originalPixels[floorY * originalWidth + floorX];
                        continue;
                    }

                    Color c1 = originalPixels[floorY * originalWidth + floorX];
                    Color c2 = originalPixels[floorY * originalWidth + ceilX];
                    Color c3 = originalPixels[ceilY * originalWidth + floorX];
                    Color c4 = originalPixels[ceilY * originalWidth + ceilX];

                    float u = origX - floorX;
                    float v = origY - floorY;

                    newPixels[y * newWidth + x] = BilinearInterpolation(c1, c2, c3, c4, u, v);
                }
            }

            return newPixels;
        }

        public static Color BicubicInterpolation(Color c00, Color c01, Color c02, Color c03,
                                                Color c10, Color c11, Color c12, Color c13,
                                                Color c20, Color c21, Color c22, Color c23,
                                                Color c30, Color c31, Color c32, Color c33,
                                                float u, float v)
        {
            // Implement Catmull-Rom spline kernel.
            float b = -0.5f;
            float c = 1.5f;
            float d = -1.5f;
            float e = 1.0f;
            float f = -0.5f;
            float g = 0.5f;
            float h = -0.5f;

            // Construct the cubic basis matrix.
            float[] m = new float[] { b, c, d, e, f, g, h, 0.0f };
            float[] uMat = new float[] { u * u * u, u * u, u, 1.0f };
            float[] vMat = new float[] { v * v * v, v * v, v, 1.0f };

            // Interpolate horizontally.
            Color c0 = new Color(
                Clamp(uMat[0] * m[0] * c00.r + uMat[1] * m[1] * c00.r + uMat[2] * m[2] * c00.r + uMat[3] * m[3] * c00.r, 0, 1),
                Clamp(uMat[0] * m[0] * c00.g + uMat[1] * m[1] * c00.g + uMat[2] * m[2] * c00.g + uMat[3] * m[3] * c00.g, 0, 1),
                Clamp(uMat[0] * m[0] * c00.b + uMat[1] * m[1] * c00.b + uMat[2] * m[2] * c00.b + uMat[3] * m[3] * c00.b, 0, 1),
                Clamp(uMat[0] * m[0] * c00.a + uMat[1] * m[1] * c00.a + uMat[2] * m[2] * c00.a + uMat[3] * m[3] * c00.a, 0, 1));

            Color c1 = new Color(
                Clamp(uMat[0] * m[0] * c10.r + uMat[1] * m[1] * c10.r + uMat[2] * m[2] * c10.r + uMat[3] * m[3] * c10.r, 0, 1),
                Clamp(uMat[0] * m[0] * c10.g + uMat[1] * m[1] * c10.g + uMat[2] * m[2] * c10.g + uMat[3] * m[3] * c10.g, 0, 1),
                Clamp(uMat[0] * m[0] * c10.b + uMat[1] * m[1] * c10.b + uMat[2] * m[2] * c10.b + uMat[3] * m[3] * c10.b, 0, 1),
                Clamp(uMat[0] * m[0] * c10.a + uMat[1] * m[1] * c10.a + uMat[2] * m[2] * c10.a + uMat[3] * m[3] * c10.a, 0, 1));

            Color c2 = new Color(
                Clamp(uMat[0] * m[0] * c20.r + uMat[1] * m[1] * c20.r + uMat[2] * m[2] * c20.r + uMat[3] * m[3] * c20.r, 0, 1),
                Clamp(uMat[0] * m[0] * c20.g + uMat[1] * m[1] * c20.g + uMat[2] * m[2] * c20.g + uMat[3] * m[3] * c20.g, 0, 1),
                Clamp(uMat[0] * m[0] * c20.b + uMat[1] * m[1] * c20.b + uMat[2] * m[2] * c20.b + uMat[3] * m[3] * c20.b, 0, 1),
                Clamp(uMat[0] * m[0] * c20.a + uMat[1] * m[1] * c20.a + uMat[2] * m[2] * c20.a + uMat[3] * m[3] * c20.a, 0, 1));

            Color c3 = new Color(
                Clamp(uMat[0] * m[0] * c30.r + uMat[1] * m[1] * c30.r + uMat[2] * m[2] * c30.r + uMat[3] * m[3] * c30.r, 0, 1),
                Clamp(uMat[0] * m[0] * c30.g + uMat[1] * m[1] * c30.g + uMat[2] * m[2] * c30.g + uMat[3] * m[3] * c30.g, 0, 1),
                Clamp(uMat[0] * m[0] * c30.b + uMat[1] * m[1] * c30.b + uMat[2] * m[2] * c30.b + uMat[3] * m[3] * c30.b, 0, 1),
                Clamp(uMat[0] * m[0] * c30.a + uMat[1] * m[1] * c30.a + uMat[2] * m[2] * c30.a + uMat[3] * m[3] * c30.a, 0, 1));

            // Interpolate vertically.
            return new Color(
                Clamp(vMat[0] * m[0] * c0.r + vMat[1] * m[1] * c0.r + vMat[2] * m[2] * c0.r + vMat[3] * m[3] * c0.r, 0, 1),
                Clamp(vMat[0] * m[0] * c0.g + vMat[1] * m[1] * c0.g + vMat[2] * m[2] * c0.g + vMat[3] * m[3] * c0.g, 0, 1),
                Clamp(vMat[0] * m[0] * c0.b + vMat[1] * m[1] * c0.b + vMat[2] * m[2] * c0.b + vMat[3] * m[3] * c0.b, 0, 1),
                Clamp(vMat[0] * m[0] * c0.a + vMat[1] * m[1] * c0.a + vMat[2] * m[2] * c0.a + vMat[3] * m[3] * c0.a, 0, 1));
        }

        public static float Clamp(float value, float min, float max)
        {
            return value < min ? min : (value > max ? max : value);
        }

        public static Color[] ResizePixelsBicubic(Color[] originalPixels, int originalWidth, int originalHeight, int newWidth, int newHeight)
        {
            Color[] newPixels = new Color[newWidth * newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    float origX = ((float)x / newWidth) * originalWidth;
                    float origY = ((float)y / newHeight) * originalHeight;

                    int floorX = (int)Math.Floor(origX);
                    int floorY = (int)Math.Floor(origY);
                    int ceilX = Math.Min(floorX + 3, originalWidth - 1); // Ensure not to go out of bounds
                    int ceilY = Math.Min(floorY + 3, originalHeight - 1); // Ensure not to go out of bounds

                    if (floorX >= ceilX - 1 || floorY >= ceilY - 1)
                    {
                        newPixels[y * newWidth + x] = originalPixels[floorY * originalWidth + floorX];
                        continue;
                    }

                    // Fetch the 4x4 neighborhood around the pixel.
                    Color[,] colors = new Color[4, 4];
                    for (int row = 0; row < 4; row++)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            colors[row, col] = originalPixels[(floorY + row) * originalWidth + floorX + col];
                        }
                    }

                    // Pass the 4x4 neighborhood to the bicubic interpolation function.
                    float u = origX - floorX;
                    float v = origY - floorY;

                    newPixels[y * newWidth + x] = BicubicInterpolation(colors[0, 0], colors[0, 1], colors[0, 2], colors[0, 3],
                                                                       colors[1, 0], colors[1, 1], colors[1, 2], colors[1, 3],
                                                                       colors[2, 0], colors[2, 1], colors[2, 2], colors[2, 3],
                                                                       colors[3, 0], colors[3, 1], colors[3, 2], colors[3, 3],
                                                                       u, v);
                }
            }

            return newPixels;
        }
        public static Sprite Texture2Sprite(Texture2D texture)
        {
            if (texture == null)
                return null;
            var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            return sprite;
        }

        public static void ReplaceTransparentPixelsWithColor(Texture2D texture, Color replacementColor)
        {
            var pixels = texture.GetPixels32();

            for(int i = 0; i < pixels.Length; i++)
                if (pixels[i].a == 0)
                    pixels[i] = replacementColor;

            texture.SetPixels32(pixels);
            texture.Apply();
        }

        /// <summary>
        /// Creates a new Texture2D with the original texture centered and allows for vertical and horizontal offsets.
        /// </summary>
        /// <param name="originalTexture">The original Texture2D.</param>
        /// <param name="newSize">The size of the new Texture2D.</param>
        /// <param name="offsetX">Horizontal offset in pixels.</param>
        /// <param name="offsetY">Vertical offset in pixels.</param>
        /// <returns>A new Texture2D with the original texture centered and offset.</returns>
        public static Texture2D CreateCenteredTexture(Texture2D originalTexture, int newSize, int offsetX, int offsetY)
        {
            if (originalTexture == null)
                throw new System.ArgumentNullException("originalTexture", "Original texture cannot be null.");

            Texture2D newTexture = new(newSize, newSize, originalTexture.format, false);

            for (int y = 0; y < newSize; y++)
                for (int x = 0; x < newSize; x++)
                    newTexture.SetPixel(x, y, Color.clear);
            newTexture.Apply();

            int centerX = newSize / 2;
            int centerY = newSize / 2;

            int startX = centerX - originalTexture.width / 2 + offsetX;
            int startY = centerY - originalTexture.height / 2 + offsetY;

            for (int y = 0; y < originalTexture.height; y++)
            {
                for (int x = 0; x < originalTexture.width; x++)
                {
                    Color pixelColor = originalTexture.GetPixel(x, y);
                    int newX = startX + x;
                    int newY = startY + y;

                    if (newX >= 0 && newX < newSize && newY >= 0 && newY < newSize)
                        newTexture.SetPixel(newX, newY, pixelColor);
                }
            }

            newTexture.Apply();

            return newTexture;
        }

        public static void ChangeProfileFrameMaterialWrapMode(Material mat)
        {
#if !UNITY_ANDROID
            return;
#endif

            if (mat == null)
                return;

            for(int i = 0; i < mat.shader.GetPropertyCount(); i++)
            {
                if(mat.shader.GetPropertyType(i) == UnityEngine.Rendering.ShaderPropertyType.Texture)
                {
                    var propName = mat.shader.GetPropertyName(i);
                    if (propName != "_ProfileFrameTex" && propName != "_MainTex")
                    {
                        var tex = mat.GetTexture(propName);
                        if (tex != null)
                            tex.wrapMode = TextureWrapMode.Repeat;
                    }
                }
            }
        }

        #endregion
    }
}
