using System;
using System.IO;
using UnityEngine;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace MDPro3
{
    public class Boot : MonoBehaviour
    {
        public Slider progressBar;
        public Text text;

        string title;
        string dots;
        float time;
        bool extracting;
        int totalNum;
        int nowNum;

        List<string> zips = new List<string>();

        void Start()
        {
            Application.targetFrameRate = 0;

#if !UNITY_EDITOR && UNITY_ANDROID
            Environment.CurrentDirectory = Application.persistentDataPath;
            Directory.SetCurrentDirectory(Application.persistentDataPath);
            if (VersionCheck())
            {
                BetterStreamingAssets.Initialize();
                var paths = BetterStreamingAssets.GetFiles("\\", "*.zip");
                foreach (var zip in paths)
                    zips.Add(Path.GetFileName(zip).Replace(".zip", ""));

                StartCoroutine(CheckFile());
            }
#else
            InitializeLanguage();
            StartCoroutine(LoadMainSceneAsync());
#endif
        }

        void Update()
        {
            time += Time.deltaTime;
            if (time > 0.33f)
            {
                time = 0;
                dots += ".";
                if (dots == "....")
                    dots = "";
            }
            if (extracting && totalNum != 0)
            {
                float progress = (float)nowNum / totalNum;
                progressBar.value = progress;
            }
            if (totalNum == 0)
                text.text = title + dots;
            else
                text.text = title + "(" + nowNum + Program.slash + totalNum + ")";
        }

        bool InitializeLanguage()
        {
            if (!Directory.Exists(Program.dataPath))
            {
                Directory.CreateDirectory(Program.dataPath);
                Config.Initialize(Program.configPath);
                return true;
            }
            else
            {
                Config.Initialize(Program.configPath);
                if(Config.Get("Version", "Version") == "Version")
                    return true;
                InterString.Initialize();
                return false;
            }
        }

        IEnumerator CheckFile()
        {
            //V1.2.0 Delete Folder MonsterCutin
            if(Application.version == "1.2.0.0")
            {
                if(Config.Get("Android-V1.2.0.0_install", "0") == "0")
                {
                    //Program.ClearDirectoryRecursively(new DirectoryInfo("Android/MonsterCutin"));
                    //Program.ClearDirectoryRecursively(new DirectoryInfo("Android/MasterDuel/Mate"));
                    Directory.Delete("Android/MonsterCutin", true);
                    Directory.Delete("Android/MasterDuel/Mate", true);
                }
            }

            IEnumerator enumerator;
            foreach (string zip in zips)
            {
                if (Config.Get(zip + "_install", "0") == "0")
                {
                    enumerator = Check(zip);
                    StartCoroutine(enumerator);
                    while (enumerator.MoveNext())
                        yield return enumerator.Current;
                    Config.Set(zip + "_install", "1");
                    Config.Save();
                    GC.Collect();
                }
            }
            yield return null;
            StartCoroutine(LoadMainSceneAsync());
        }

        IEnumerator Check(string type)
        {
            title = InterString.Get("正在读取[?]", type + ".zip");
            nowNum = 0;
            totalNum = 0;

            string filePath = Application.streamingAssetsPath + Program.slash + type + ".zip";
            var www = new WWW(filePath);
            while (!www.isDone)
            {
                float progress = Mathf.Clamp01(www.progress / 0.9f);
                progressBar.value = progress;
                yield return null;
            }
            title = InterString.Get("正在解压[?]", type + ".zip");
            byte[] bytes = www.bytes;
            var outPath = "";
            if (type.Contains("_"))
                outPath = type.Split('_')[0];
            if (outPath.Length > 0 && !Directory.Exists(outPath))
                Directory.CreateDirectory(outPath);
            IEnumerator enumerator = ExtractZipFile(bytes, outPath);
            StartCoroutine(enumerator);
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        IEnumerator LoadMainSceneAsync()
        {
            nowNum = 0;
            totalNum = 0;
            progressBar.value = 0;

            Config.Initialize(Program.configPath);
            Config.Set("Version", Application.version[..5]);
            Config.Save();

            title = InterString.Get("正在初始化");
            var ini = Addressables.InitializeAsync();
            while (!ini.IsDone)
            {
                progressBar.value = ini.PercentComplete;
                yield return null;
            }

            title = InterString.Get("正在读取数据");
            var handle = Addressables.LoadAssetAsync<Items>("Items");
            while (!handle.IsDone)
            {
                progressBar.value = handle.PercentComplete;
                yield return null;
            }
            Program.items = handle.Result;

            title = InterString.Get("正在进入游戏");
            var load = Addressables.LoadSceneAsync("SceneMain");
            while (!load.IsDone)
            {
                yield return null;
                progressBar.value = load.PercentComplete;
            }
        }

        public static void FastExtractZipFile(string file, string dir, string password = "")
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            FastZip zip = new FastZip();
            zip.Password = password;
            zip.ExtractZip(file, dir, "");
        }

        IEnumerator ExtractZipFile(byte[] data, string outFolder)
        {
            ZipFile zf = null;
            using (MemoryStream mstrm = new MemoryStream(data))
            {
                zf = new ZipFile(mstrm);
                int count = 0;
                foreach (ZipEntry zipEntry in zf)
                    count++;
                totalNum = count;
                nowNum = 0;
                extracting = true;
                foreach (ZipEntry zipEntry in zf)
                {
                    nowNum++;
                    if (!zipEntry.IsFile)
                    {
                        continue;
                    }
                    string entryFileName = zipEntry.Name;
                    byte[] buffer = new byte[4096];
                    Stream zipStream = zf.GetInputStream(zipEntry);
                    string fullZipToPath = Path.Combine(outFolder, entryFileName);
                    string directoryName = Path.GetDirectoryName(fullZipToPath);
                    if (directoryName.Length > 0)
                        Directory.CreateDirectory(directoryName);
                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                    yield return null;
                }
                if (zf != null)
                {
                    zf.IsStreamOwner = true;
                    zf.Close();
                }
            }
        }

        bool VersionCheck()
        {
            var firstInstall = InitializeLanguage();

            var installVersion = Application.version;
            var installedVersion = Config.Get("Version", "Version");
            if (installedVersion == "Version")
                firstInstall = true;

            if(firstInstall)
            {
                if(installVersion.Length > 5 || !installVersion.EndsWith("0"))
                {
                    title = "不能直接安装更新包。Can not install update apk directly.";
                    Directory.Delete(Program.dataPath);
                    return false;
                }
                else
                    return true;
            }
            else //firstInstall
            {
                if(installVersion == installedVersion)
                    return true;

                if (installVersion.Length > 5)
                {
                    if(installVersion.EndsWith("0"))
                    {
                        if (InstallNext(installedVersion, installVersion))
                            return true;
                        else if (installVersion[..5] == installedVersion)
                            return true;
                        else
                        {
                            title = InterString.Get("当前更新包需要的版本：「[?]」。", VersionPre(installVersion));
                            title += InterString.Get("已安装版本：「[?]」。", installedVersion);
                            return false;
                        }
                    }
                    else
                    {
                        if (installVersion.Substring(0, 5) == installedVersion)
                            return true;
                        else
                        {
                            title = InterString.Get("当前更新包需要的版本：「[?]」。", installVersion.Substring(0, 5));
                            title += InterString.Get("已安装版本：「[?]」。", installedVersion);
                            return false;
                        }
                    }
                }
                else
                {
                    if (installVersion.EndsWith("0"))
                        return true;
                    else
                    {
                        if(VersionPre(installVersion) == installedVersion.Substring(0, 5))
                            return true;
                        else
                        {
                            title = InterString.Get("当前更新包需要的版本：「[?]」。", VersionPre(installVersion));
                            title += InterString.Get("已安装版本：「[?]」。", installedVersion);
                            return false;
                        }
                    }
                }
            }
        }

        bool InstallNext(string installedVersion, string installVersion)
        {
            var installedInt = GetVersionInt(installedVersion);
            var installInt = GetVersionInt(installVersion);
            if(installInt -  installedInt == 1)
                return true;
            else
                return false;
        }

        string VersionPre(string version)
        {
            var versionInt = GetVersionInt(version);
            string returnValue = (versionInt - 1).ToString("D3");
            return returnValue.Substring(0, 1) + "." + returnValue.Substring(1, 1) + "." + returnValue.Substring(2, 1);
        }

        int GetVersionInt(string version)
        {
            string textInt = version.Substring(0, 1) + version.Substring(2, 1) + version.Substring(4, 1);
            return int.Parse(textInt);
        }
    }
}
