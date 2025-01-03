using System;
using System.IO;
using System.Threading;
using System.Net;
using WindBot.Game;
using WindBot.Game.AI;
using YGOSharp.OCGWrapper;
using System.Collections.Specialized;
using System.Collections.Generic;
using MDPro3;

namespace WindBot
{
    public class Program
    {
        internal static Random Rand;

        internal static void Main(string[] args)
        {
            Logger.WriteLine("WindBot starting...");

            Config.Load(args);

            string databasePath = Config.GetString("DbPath", "cards.cdb");

            InitDatas(databasePath);

            bool serverMode = Config.GetBool("ServerMode", false);

            if (serverMode)
            {
                // Run in server mode, provide a http interface to create bot.
                int serverPort = Config.GetInt("ServerPort", 2399);
                RunAsServer(serverPort);
            }
            else
            {
                // Join the host specified on the command line.
                if (args.Length == 0)
                {
                    Logger.WriteErrorLine("=== WARN ===");
                    Logger.WriteLine("No input found, tring to connect to localhost YGOPro host.");
                    Logger.WriteLine("If it fail, the program will quit sliently.");
                }
                RunFromArgs();
            }
        }

        public static void InitDatas(string databasePath)
        {
            Rand = new Random();
            DecksManager.Init();
            string absolutePath = Path.GetFullPath(databasePath);
            //if (!File.Exists(absolutePath))
            //    // In case windbot is placed in a folder under ygopro folder
            //    absolutePath = Path.GetFullPath("../" + databasePath);
            //if (!File.Exists(absolutePath))
            //    // In case windbot is placed in a folder under ygopro2 folder
            //    absolutePath = Path.GetFullPath("../cdb/" + databasePath);
            absolutePath = Path.GetFullPath("Data/locales/" + MDPro3.Utility.Language.GetConfig() + "/" + databasePath);
            if (!File.Exists(absolutePath))
            {
                Logger.WriteErrorLine("Can't find cards database file.");
                Logger.WriteErrorLine("Please place cards.cdb next to WindBot.exe or Bot.exe .");
                Logger.WriteLine("Press any key to quit...");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            var paths = ZipHelper.GetAllCdbTempPath();
            paths.Add(absolutePath);
            foreach(var cdb in Directory.GetFiles(MDPro3.Program.expansionsPath, "*.cdb"))
                paths.Add(cdb);
            NamedCardsManager.InitForMulti(paths);
        }

        private static void RunFromArgs()
        {
            WindBotInfo Info = new WindBotInfo();
            Info.Name = Config.GetString("Name", Info.Name);
            Info.Deck = Config.GetString("Deck", Info.Deck);
            Info.DeckFile = Config.GetString("DeckFile", Info.DeckFile);
            Info.Dialog = Config.GetString("Dialog", Info.Dialog);
            Info.Host = Config.GetString("Host", Info.Host);
            Info.Port = Config.GetInt("Port", Info.Port);
            Info.HostInfo = Config.GetString("HostInfo", Info.HostInfo);
            Info.Version = Config.GetInt("Version", Info.Version);
            Info.Hand = Config.GetInt("Hand", Info.Hand);
            Info.Debug = Config.GetBool("Debug", Info.Debug);
            Info.Chat = Config.GetBool("Chat", Info.Chat);
            Run(Info);
        }

        private static void RunAsServer(int ServerPort)
        {
            using (HttpListener MainServer = new HttpListener())
            {
                MainServer.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
                MainServer.Prefixes.Add("http://+:" + ServerPort + "/");
                MainServer.Start();
                Logger.WriteLine("WindBot server start successed.");
                Logger.WriteLine("HTTP GET http://127.0.0.1:" + ServerPort + "/?name=WindBot&host=127.0.0.1&port=7911 to call the bot.");
                while (true)
                {
#if !DEBUG
    try
    {
#endif
                    HttpListenerContext ctx = MainServer.GetContext();

                    WindBotInfo Info = new WindBotInfo();
                    string RawUrl = Path.GetFileName(ctx.Request.RawUrl);
                    var queryStringParser = QueryStringParser.ParseQueryString(RawUrl);
                    Info.Name = queryStringParser["name"];
                    Info.Deck = queryStringParser["deck"];
                    Info.Host = queryStringParser["host"];
                    string port = queryStringParser["port"];
                    if (port != null)
                        Info.Port = Int32.Parse(port);
                    string deckfile = queryStringParser["deckfile"];
                    if (deckfile != null)
                        Info.DeckFile = deckfile;
                    string dialog = queryStringParser["dialog"];
                    if (dialog != null)
                        Info.Dialog = dialog;
                    string version = queryStringParser["version"];
                    if (version != null)
                        Info.Version = Int16.Parse(version);
                    string password = queryStringParser["password"];
                    if (password != null)
                        Info.HostInfo = password;
                    string hand = queryStringParser["hand"];
                    if (hand != null)
                        Info.Hand = Int32.Parse(hand);
                    string debug = queryStringParser["debug"];
                    if (debug != null)
                        Info.Debug= bool.Parse(debug);
                    string chat = queryStringParser["chat"];
                    if (chat != null)
                        Info.Chat = bool.Parse(chat);

                    if (Info.Name == null || Info.Host == null || port == null)
                    {
                        ctx.Response.StatusCode = 400;
                        ctx.Response.Close();
                    }
                    else
                    {
#if !DEBUG
        try
        {
#endif
                        Thread workThread = new Thread(new ParameterizedThreadStart(Run));
                        workThread.Start(Info);
#if !DEBUG
        }
        catch (Exception ex)
        {
            Logger.WriteErrorLine("Start Thread Error: " + ex);
        }
#endif
                        ctx.Response.StatusCode = 200;
                        ctx.Response.Close();
                    }
#if !DEBUG
    }
    catch (Exception ex)
    {
        Logger.WriteErrorLine("Parse Http Request Error: " + ex);
    }
#endif
                }
            }
        }

        private static void Run(object o)
        {
#if !DEBUG
    try
    {
    //all errors will be catched instead of causing the program to crash.
#endif
            WindBotInfo Info = (WindBotInfo)o;
            GameClient client = new GameClient(Info);
            client.Start();
            Logger.DebugWriteLine(client.Username + " started.");
            while (client.Connection.IsConnected)
            {
#if !DEBUG
        try
        {
#endif
                client.Tick();
                Thread.Sleep(30);
#if !DEBUG
        }
        catch (Exception ex)
        {
            Logger.WriteErrorLine("Tick Error: " + ex);
        }
#endif
            }
            Logger.DebugWriteLine(client.Username + " end.");
#if !DEBUG
    }
    catch (Exception ex)
    {
        Logger.WriteErrorLine("Run Error: " + ex);
    }
#endif
        }

        public static FileStream ReadFile(string directory, string filename, string extension)
        {
            string tryfilename = filename + "." + extension;
            string fullpath = Path.Combine(directory, tryfilename);
            if (!File.Exists(fullpath))
                fullpath = filename;
            if (!File.Exists(fullpath))
                fullpath = Path.Combine("../", filename);
            if (!File.Exists(fullpath))
                fullpath = Path.Combine("../deck/", filename);
            if (!File.Exists(fullpath))
                fullpath = Path.Combine("../", tryfilename);
            if (!File.Exists(fullpath))
                fullpath = Path.Combine("../deck/", tryfilename);
            if (!File.Exists(fullpath))
                fullpath = Path.Combine("Data/Windbot/" + directory, tryfilename);
            if (!File.Exists(fullpath))
                fullpath = Path.Combine("Deck/", tryfilename);
            return new FileStream(fullpath, FileMode.Open, FileAccess.Read);
        }
    }

    public static class QueryStringParser
    {
        public static NameValueCollection ParseQueryString(string query)
        {
            var result = new NameValueCollection();
            if (!string.IsNullOrEmpty(query))
            {
                var pairs = query.Split('&');
                foreach (var pair in pairs)
                {
                    if (pair.Contains("="))
                    {
                        var parts = pair.Split('=');
                        var key = Uri.UnescapeDataString(parts[0]);
                        var value = parts.Length > 1 ? Uri.UnescapeDataString(parts[1]) : string.Empty;
                        result[key] = value;
                    }
                }
            }
            return result;
        }
    }
}
