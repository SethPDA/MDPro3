using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace WindBot
{
    public class BotWrapper
    {
        const int MB_ICONERRPR = 0x00000010;

        public static void Main(string[] args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
        }


        public class BotInfo
        {
            public string name;
            public string command;
            public string desc;
            public string[] flags;
        }

        static public IList<BotInfo> Bots = new List<BotInfo>();

        static void ReadBots()
        {
            using (StreamReader reader = new StreamReader("bot.conf"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine().Trim();
                    if (line.Length > 0 && line[0] == '!')
                    {
                        BotInfo newBot = new BotInfo();
                        newBot.name = line;
                        newBot.command = reader.ReadLine().Trim();
                        newBot.desc = reader.ReadLine().Trim();
                        line = reader.ReadLine().Trim();
                        newBot.flags = line.Split(' ');
                        Bots.Add(newBot);
                    }
                }
            }
        }

        static string GetRandomBot(string flag)
        {
            IList<BotInfo> foundBots = Bots.Where(bot => bot.flags.Contains(flag)).ToList();
            if (foundBots.Count > 0)
            {
                Random rand = new Random();
                BotInfo bot = foundBots[rand.Next(foundBots.Count)];
                return bot.command;
            }
            return "";
        }
    }
}
