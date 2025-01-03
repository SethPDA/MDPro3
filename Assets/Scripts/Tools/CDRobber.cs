using AssetsTools.NET;
using AssetsTools.NET.Extra;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Extension;

public class CDRobber : MonoBehaviour
{
    string path = "StreamingAssets/CrossDuel/";
    public Text text;
    public struct AssetbundleInfo
    {
        public string path;
        public string cab;
        public List<string> dependencies;
    }
    public static List<AssetbundleInfo> files = new List<AssetbundleInfo>();


    private void Start()
    {
        Application.targetFrameRate = 0;

        LoadList();
        Copy();
    }

    void Copy()
    {
        Directory.CreateDirectory(path + "Copy");
        foreach(var file in files)
        {
            if(file.dependencies.Count == 0)
            {
                File.Copy(path + "CrossDuelAddressables/" + file.path, path + "Copy/" + file.path);
            }
        }
    }

    void LoadList()
    {
        var content = File.ReadAllText(path + "FileList.txt");
        var lines = content.Replace("\r", "").Split('\n');
        var file = new AssetbundleInfo();
        file.path = "";
        file.cab = "";
        file.dependencies = new List<string>();
        foreach (var line in lines)
        {
            if (!line.StartsWith("-") && !line.StartsWith("*"))
            {
                if (file.path.Length > 0)
                {
                    files.Add(file);
                    file = new AssetbundleInfo();
                    file.path = line;
                    file.cab = "";
                    file.dependencies = new List<string>();
                }
                else
                    file.path = line;
            }
            else if (line.StartsWith("-"))
                file.cab = line.Replace("-", "");
            else if (line.StartsWith("*"))
                file.dependencies.Add(line.Replace("*", ""));
        }
    }

    IEnumerator RefreshList()
    {
        string[] fileInfos = Directory.GetFiles(path);
        List<string> fileNames = new List<string>();
        foreach (string fileInfo in fileInfos)
            fileNames.Add(Path.GetFileName(fileInfo));
        var manager = new AssetsManager();
        
        for (int i = 0; i < fileNames.Count; i++)
        {
            BundleFileInstance bundleInst = manager.LoadBundleFile(fileInfos[i], false);
            AssetBundleFile bundle = bundleInst.file;
            MemoryStream bundleStream = new MemoryStream();
            bundle.Unpack(new AssetsFileWriter(bundleStream));
            var info = new AssetbundleInfo();
            info.path = fileNames[i];
            info.cab = bundle.GetAllFileNames()[0].Replace(".resource", string.Empty).Replace(".resS", "").Replace(".sharedAssets", "");
            info.dependencies = GetDependencise(info.path, bundleStream.GetBuffer());
            files.Add(info);
            text.text = i + "/" + fileNames.Count;
            yield return null;
        }

        var all = "";
        foreach (var file in files)
        {
            all += file.path + "\r\n";
            all += "-" + file.cab + "\r\n";
            foreach (var depend in file.dependencies)
                all += "--" + depend + "\r\n";
        }
        File.WriteAllText(path + "../FileList.txt", all);
    }

    List<string> GetDependencise(string name, byte[] bytes)
    {
        var returnValue = new List<string>();
        byte[] nameData = new byte[20]
        { 
        0x2E, 0x62, 0x75, 0x6E, 0x64, 0x6C, 0x65, 0x00, 0x05, 0x00, 0x00, 0x00, 0x24,  0x00, 0x00, 0x00, 0x63, 0x61, 0x62, 0x2D
        };
        List<int> point = new List<int>();
        for (int i = 0; i < bytes.Length; i++)
        {
            bool yes = true;
            if(i + nameData.Length < bytes.Length)
            {
                for (int j = 0; j < nameData.Length; j++)
                {
                    if (bytes[i + j] != nameData[j])
                    {
                        if(j != 12 &&  j != 16)
                        {
                            yes = false;
                            break;
                        }
                    }
                }
                if (yes)
                {
                    point.Add(i + 16);
                    Debug.Log(name + "-" + i);
                }
            }
        }
        if(point.Count == 0)
            Debug.Log("没找到: " +  name);
        else if(point.Count > 1)
            Debug.Log("找到多个: " + name);
        else
        {
            bool still = true;
            while (still)
            {
                var bs = new List<byte>();
                for (int i = point[0]; i < point[0] + 36; i++)
                    bs.Add(bytes[i]);
                var ab = bs.ToArray();
                returnValue.Add(Encoding.UTF8.GetString(ab));
                if (bytes[point[0] + 36] == 0x24 && bytes[point[0] + 37] == 0x0 && bytes[point[0] + 38] == 0x0 && bytes[point[0] + 39] == 0x0)
                    point[0] += 40;
                else
                    still = false;
            }
        }
        return returnValue;
    }
}
