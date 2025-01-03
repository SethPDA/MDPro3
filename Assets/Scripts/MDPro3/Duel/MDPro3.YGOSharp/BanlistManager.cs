using Ionic.Zip;
using System.Collections.Generic;
using System.IO;

namespace MDPro3.YGOSharp
{
    public static class BanlistManager
    {
        public static List<Banlist> Banlists { get; private set; }
        public static string EmptyBanlistName = "N/A";

        public static void Initialize()
        {
            Banlists = new List<Banlist>();
            StreamReader reader = null;
            if (Config.GetBool("Expansions", true))
            {
                var confPath = Program.expansionsPath + "lflist.conf";
                if(File.Exists(confPath))
                {
                    reader = new StreamReader(confPath);
                    InitializeFromReader(reader);
                    reader.Close();
                }
                foreach (var zip in ZipHelper.zips)
                {
                    if (zip.Name.ToLower().EndsWith("script.zip"))
                        continue;
                    foreach (var file in zip.EntryFileNames)
                    {
                        if (file.ToLower().EndsWith("lflist.conf"))
                        {
                            var e = zip[file];
                            if (!Directory.Exists(Program.tempFolder))
                                Directory.CreateDirectory(Program.tempFolder);
                            var tempFile = Path.Combine(Path.GetFullPath(Program.tempFolder), file);
                            e.Extract(Path.GetFullPath(Program.tempFolder), ExtractExistingFileAction.OverwriteSilently);
                            reader = new StreamReader(tempFile);
                            InitializeFromReader(reader);
                            reader.Close();
                            File.Delete(tempFile);
                        }
                    }
                }
            }

            Banlist current = null;
            reader = new StreamReader(Program.lflistPath);
            InitializeFromReader(reader);
            reader.Close();
            current = new();
            current.Name = EmptyBanlistName;
            Banlists.Add(current);

            Program.instance.editDeck.banlist = Banlists[0];
            Program.instance.editDeck.SetBanlistName(Program.instance.editDeck.banlist.Name);
        }

        public static void InitializeFromReader(StreamReader reader)
        {
            Banlist current = null;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                try
                {
                    if (line == null)
                        continue;
                    if (line.StartsWith("#"))
                        continue;
                    if (line.StartsWith("!"))
                    {
                        current = new Banlist();
                        current.Name = line.Substring(1, line.Length - 1);
                        Banlists.Add(current);
                        continue;
                    }
                    if (!line.Contains(" "))
                        continue;
                    if (current == null)
                        continue;
                    string[] data = line.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                    int id = int.Parse(data[0]);
                    int count = int.Parse(data[1]);
                    current.Add(id, count);
                }
                catch (System.Exception e)
                {
                    UnityEngine.Debug.Log(line);
                    UnityEngine.Debug.Log(e);
                }
            }
        }

        public static int GetIndex(uint hash)
        {
            for (int i = 0; i < Banlists.Count; i++)
                if (Banlists[i].Hash == hash)
                    return i;
            return 0;
        }
        public static int GetIndexByName(string name)
        {
            for (int i = 0; i < Banlists.Count; i++)
                if (Banlists[i].Name == name)
                    return i;
            return 0;
        }

        public static string GetName(uint hash)    
        {
            for (int i = 0; i < Banlists.Count; i++)
                if (Banlists[i].Hash == hash)
                    return Banlists[i].Name;
            return InterString.Get("未知卡表");
        }

        public static List<string> GetAllName()
        {
            List<string> returnValue = new List<string>();
            foreach (var item in Banlists)
            {
                returnValue.Add(item.Name);
            }
            return returnValue;
        }

        public static Banlist GetByName(string name)
        {
            Banlist returnValue = Banlists[Banlists.Count - 1];
            foreach (var item in Banlists)
            {
                if (item.Name == name)
                {
                    returnValue = item;
                }
            }
            return returnValue;
        }

        public static Banlist GetByHash(uint hash)
        {
            Banlist returnValue = Banlists[Banlists.Count - 1];
            foreach (var item in Banlists)
            {
                if (item.Hash == hash)
                {
                    returnValue = item;
                }
            }
            return returnValue;
        }
    }
}