using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using MDPro3.Utility;

namespace MDPro3
{
    public static class InterString
    {
        private static readonly Dictionary<string, string> translations = new Dictionary<string, string>();
        private static readonly Dictionary<string, string> translationsForRender = new Dictionary<string, string>();

        private static string path;
        private static string pathForRender;
        public static void Initialize()
        {
            translations.Clear();
            path = Program.localesPath + Language.GetConfig() + "/translation.conf";
            if (!File.Exists(path))
                File.Create(path).Close();

            var txtString = File.ReadAllText(path);
            var lines = txtString.Replace("\r", "").Split('\n');
            for (var i = 0; i < lines.Length; i++)
            {
                var mats = Regex.Split(lines[i], "->");
                if (mats.Length == 2)
                    if (!translations.ContainsKey(mats[0]))
                        translations.Add(mats[0], mats[1]);
            }

            translationsForRender.Clear();
            pathForRender = Program.localesPath + Language.GetCardConfig() + "/translation.conf";
            if (!File.Exists(pathForRender))
                File.Create(pathForRender).Close();
            txtString = File.ReadAllText(pathForRender);
            lines = txtString.Replace("\r", "").Split('\n');
            for (var i = 0; i < lines.Length; i++)
            {
                var mats = Regex.Split(lines[i], "->");
                if (mats.Length == 2)
                    if (!translationsForRender.ContainsKey(mats[0]))
                        translationsForRender.Add(mats[0], mats[1]);
            }
        }

        public static string Get(string original, bool render = false)
        {
            var returnValue = original;
            var targetTranslations = render ? translationsForRender : translations;
            if (targetTranslations.TryGetValue(original, out returnValue))
                return returnValue.Replace("@n", "\r\n").Replace("@ui", "");

            if (original != "")
            {
                try
                {
                    File.AppendAllText(render ? pathForRender : path, original + "->" + original + "\r\n");
                }
                catch
                {
                    Program.noAccess = true;
                }

                targetTranslations.Add(original, original);
                return original.Replace("@n", "\r\n").Replace("@ui", "");
            }
            return original;
        }

        public static string Get(string original, string replace, bool render = false)
        {
            return Get(original, render).Replace("[?]", replace);
        }
        public static string GetOriginal(string value)
        {
            var returnValue = value;
            foreach (var translation in translations)
            {
                if (translation.Value == value)
                {
                    returnValue = translation.Key;
                    break;
                }
            }
            return returnValue;
        }
    }
}
