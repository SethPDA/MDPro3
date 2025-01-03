using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using static AssetBundleRobber;

public class DuelLinksRobber : MonoBehaviour
{
    public Text text;

    AssetStudio.AssetsManager assetManager;

    bool fullCopy;
    bool noSave = false;
    string duelLinksStreamingAssetsPath = "../../../Game/Steam/steamapps/common/Yu-Gi-Oh! Duel Links/dlpc_Data/StreamingAssets/";
    string duelLinksLocalDataPath = "../../../Game/Steam/steamapps/common/Yu-Gi-Oh! Duel Links/LocalData/92a05e34/";
    string workingPlace = "Sound/";
    string fileList = "FileList.txt";
    readonly object _lock = new object();
    ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();

    public static List<AssetbundleInfo> files = new List<AssetbundleInfo>();
    public static List<AssetbundleInfo> newFiles = new List<AssetbundleInfo>();
    int count = 0;
    int threads = 32;


    private void Start()
    {
        assetManager = GetComponent<AssetStudio.AssetsManager>();
        Application.targetFrameRate = 0;

        //fullCopy = true;
        fullCopy = false;

        Initialize();
        StartCoroutine(RefreshFileResources());
    }

    void Initialize()
    {
        if (!Directory.Exists(workingPlace))
            Directory.CreateDirectory(workingPlace);

        var fullText = "";
        if (File.Exists(workingPlace + fileList))
            fullText = File.ReadAllText(workingPlace + fileList);
        else
            noSave = true;

        var lines = fullText.Replace("\r", "").Split('\n');
        AssetbundleInfo file = new AssetbundleInfo();
        file.dependencies = new List<string>();
        foreach (var line in lines)
        {
            if (!line.StartsWith("-"))
            {
                if (file.name != null)
                {
                    files.Add(file);
                    file = new AssetbundleInfo
                    {
                        dependencies = new List<string>(),
                        path = line
                    };
                }
                else
                    file.path = line;
            }
            else if (line.StartsWith("--"))
                file.dependencies.Add(line.Substring(2));
            else
                file.name = line.Substring(1);
        }

        if (!noSave)
        {
            Debug.Log("Preloged£º" + files.Count);
        }
        else
        {
            Debug.Log("No FileList to load.");
        }
    }

    void AddLog(int i)
    {
        var file = assetManager.assetsFileList[i];
        count++;
        string filePath = file.originalPath.Substring(file.originalPath.Length - 8);

        string fileName = "";
        foreach (var obj in file.Objects)
            if (obj is AssetStudio.AssetBundle assetBundle)
                foreach (var pair in assetBundle.m_Container)
                {
                    fileName = pair.Key;
                    break;
                }

        var filestruct = new AssetbundleInfo();
        filestruct.path = filePath;
        filestruct.name = fileName;
        filestruct.dependencies = new List<string>();
        lock (_lock)
        {
            files.Add(filestruct);
            newFiles.Add(filestruct);
        }

        var content = string.Empty;
        content += filestruct.path + "\r\n";
        content += "-" + filestruct.name + "\r\n";
        foreach (var depend in filestruct.dependencies)
            content += "--" + depend + "\r\n";

        logQueue.Enqueue(content);
    }

    IEnumerator RefreshFileResources()
    {
        var ie = assetManager.LoadFolderAsync(duelLinksStreamingAssetsPath);
        while (ie.MoveNext())
            yield return null;
        ie = assetManager.LoadFolderAsync(duelLinksLocalDataPath);
        while (ie.MoveNext())
            yield return null;

        Debug.Log("new files: " + assetManager.assetsFileList.Count);

        indexQueue = new ConcurrentQueue<int>();
        workerThreads = new List<Thread> { };
        isProcessing = true;

        for (int i = 0; i < threads; i++)
        {
            Thread workerThread = new Thread(ProcessLogs);
            workerThreads.Add(workerThread);
            workerThread.Start();
        }

        ie = EnqueueLogs(assetManager.assetsFileList.Count);
        while (ie.MoveNext())
        {
            text.text = "Logging: " + count + "/" + assetManager.assetsFileList.Count;
            if (logQueue.TryDequeue(out var log))
                File.AppendAllText(workingPlace + fileList, log);
            yield return null;
        }

        while (logQueue.TryDequeue(out var log))
        {
            File.AppendAllText(workingPlace + fileList, log);
            text.text = "Writing Left: " + logQueue.Count;
            yield return null;
        }

        StartCoroutine(CopyBundles());
    }

    private ConcurrentQueue<int> indexQueue;
    private List<Thread> workerThreads;
    private bool isProcessing;


    public void StopProcessingLogs()
    {
        isProcessing = false;

        foreach (Thread workerThread in workerThreads)
        {
            workerThread.Join();
        }

        workerThreads.Clear();
    }

    private IEnumerator EnqueueLogs(int count)
    {
        int processedIndexCount = 0;
        int indexesPerFrame = 32;

        for (int i = 0; i < count; i++)
        {
            indexQueue.Enqueue(i);
            processedIndexCount++;

            if (processedIndexCount >= indexesPerFrame)
            {
                processedIndexCount = 0;
                yield return null;
            }
        }

        while (!indexQueue.IsEmpty)
        {
            yield return null;
        }

        StopProcessingLogs();
    }

    private void ProcessLogs()
    {
        while (isProcessing)
        {
            if (indexQueue.TryDequeue(out int index))
            {
                AddLog(index);
            }
            else
            {
                Thread.Sleep(10);
            }
        }
    }

    public void OnApplicationQuit()
    {
        StopProcessingLogs();
    }

    IEnumerator CopyBundles()
    {

        fileCount = files.Count;
        currentFileCount = 0;
        Debug.Log(fileCount);
        List<AssetbundleInfo> targetFiles;
        if (fullCopy)
            targetFiles = files;
        else
            targetFiles = newFiles;

        var storePath = workingPlace + "VoiceAB/";

        if (!Directory.Exists(storePath))
            Directory.CreateDirectory(storePath);

        foreach (var file in targetFiles)
        {
            yield return null;

            currentFileCount++;
            text.text = "Copy: " + currentFileCount + "/" + fileCount;

            if (file.name.Contains("ja-jp") && file.name.EndsWith(".wav"))
            {
                var filePath = duelLinksStreamingAssetsPath + file.path.Substring(0, 2) + "/" + file.path;
                if (!File.Exists(filePath))
                    filePath = duelLinksLocalDataPath + file.path.Substring(0, 2) + "/" + file.path;
                if (!File.Exists(filePath))
                {
                    Debug.Log("File not found: " + file.path);
                    continue;
                }

                if (File.Exists(storePath + file.path))
                    File.Delete(storePath + file.path);
                File.Copy(filePath, storePath + file.path);
            }
        }
        text.text = "Copy done. ";

    }
}
