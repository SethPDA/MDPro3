
using System.Collections.Generic;
using System.IO;
using System.Linq;

#if SUPPORT_WINDOWS_PORT
using SFB;
#endif

namespace MDPro3
{
    public class PortHelper
    {
        static List<string> filesToDelete = new List<string>();
        static string[] pictureFormat = new string[] { "image/png", "image/jpeg" };
        const string bgPath = Program.diyPath + "Background.png";
        public static void ImportFiles()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            NativeFilePicker.PickMultipleFiles(MoveFilesToGame, null);
#else
            ChooseFiles();
#endif
        }

        public static void ImportBG()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            NativeFilePicker.PickFile(MovePictureToGameBG, pictureFormat);
#else
            ChooseBGPicture();
#endif
        }

        private static void ChooseFiles()
        {
#if SUPPORT_WINDOWS_PORT
            var extensions = new[]
            {
                new ExtensionFilter(InterString.Get("所有文件"), "*"),
                new ExtensionFilter(InterString.Get("卡组码文件"), "ydk"),
                new ExtensionFilter(InterString.Get("回放文件"), "yrp", "yrp3d"),
                new ExtensionFilter(InterString.Get("扩展卡文件"), "ypk"),
                new ExtensionFilter(InterString.Get("数据库文件"), "cdb"),
                new ExtensionFilter(InterString.Get("字段文件"), "conf"),
                new ExtensionFilter(InterString.Get("图片文件"), "png", "jpg")
            };
            StandaloneFileBrowser.OpenFilePanelAsync(InterString.Get("请选择需要导入的文件"), "", extensions, true, (string[] paths) =>
            {
                CopyFilesToGame(paths);
            });
#endif
        }

        private static void ChooseBGPicture()
        {
#if SUPPORT_WINDOWS_PORT

            var extensions = new[]
            {
                new ExtensionFilter(InterString.Get("图片文件"), "png", "jpg")
            };
            StandaloneFileBrowser.OpenFilePanelAsync(InterString.Get("请选择需要导入的文件"), "", extensions, false, (string[] paths) =>
            {
                CopyBGToGame(paths);
            });
#endif
        }

        private static void CopyBGToGame(IEnumerable<string> files)
        {
            foreach (string path in files)
            {
                if(File.Exists(bgPath))
                    File.Delete(bgPath);
                File.Copy(path, bgPath);
                MessageManager.Cast(InterString.Get("导入背景图成功。"));
                Program.instance.background_.Refresh();
            }
        }
        private static void MovePictureToGameBG(string file)
        {
            CopyBGToGame(new List<string> { file });
        }

        private static void CopyFilesToGame(IEnumerable<string> files)
        {
            bool newDataAdded = false;
            foreach (string path in files)
            {
                var fileName = Path.GetFileName(path);
                try
                {
                    if (path.ToLower().EndsWith(Program.ydkExpansion))
                    {
                        File.Copy(path, Program.deckPath + fileName, true);
                        MessageManager.Cast(InterString.Get("导入卡组「[?]」成功。", fileName.Replace(Program.ydkExpansion, string.Empty)));
                    }
                    else if (path.ToLower().EndsWith(Program.yrpExpansion) || path.ToLower().EndsWith(Program.yrp3dExpansion))
                    {
                        File.Copy(path, Program.replayPath + fileName, true);
                        MessageManager.Cast(InterString.Get("导入回放「[?]」成功。", fileName));
                    }
                    else if (path.ToLower().EndsWith(".ypk") || path.ToLower().EndsWith(".zip") || path.ToLower().EndsWith(".cdb") || path.ToLower().EndsWith(".conf"))
                    {
                        File.Copy(path, Program.expansionsPath + fileName, true);
                        newDataAdded = true;
                        if (fileName.ToLower().EndsWith(".ypk") || fileName.ToLower().EndsWith(".zip"))
                            MessageManager.Cast(InterString.Get("导入扩展卡文件「[?]」成功。", fileName));
                        else if (fileName.ToLower().EndsWith(".cdb"))
                            MessageManager.Cast(InterString.Get("导入卡片数据库「[?]」成功。", fileName));
                        else if (fileName.ToLower().EndsWith(".conf"))
                            MessageManager.Cast(InterString.Get("导入字段文件「[?]」成功。", fileName));
                    }
                    else if (path.ToLower().EndsWith(Program.pngExpansion) || path.ToLower().EndsWith(Program.jpgExpansion))
                    {
                        File.Copy(path, Program.altArtPath + Path.GetFileName(path), true);
                        MessageManager.Cast(InterString.Get("导入自定义卡图「[?]」成功。", fileName));
                    }
                }
                catch { }
            }
            if (newDataAdded)
                Program.instance.InitializeForDataChange();
        }

        private static void MoveFilesToGame(string[] files)
        {
            bool newDataAdded = false;
            foreach (string path in files)
            {
                try
                {
                    if (path.ToLower().EndsWith(Program.ydkExpansion))
                        File.Move(path, Program.deckPath + Path.GetFileName(path));
                    if (path.ToLower().EndsWith(Program.yrpExpansion) || path.ToLower().EndsWith(Program.yrp3dExpansion))
                        File.Move(path, Program.replayPath + Path.GetFileName(path));
                    if (path.ToLower().EndsWith(".ypk") || path.ToLower().EndsWith(".zip") || path.ToLower().EndsWith(".cdb") || path.ToLower().EndsWith(".conf"))
                    {
                        File.Move(path, Program.expansionsPath + Path.GetFileName(path));
                        newDataAdded = true;
                    }
                    if (path.ToLower().EndsWith(Program.pngExpansion) || path.ToLower().EndsWith(Program.jpgExpansion) || path.ToLower().EndsWith(".jpeg"))
                        File.Move(path, Program.altArtPath + Path.GetFileName(path));
                }
                catch { }
            }
            if (newDataAdded)
                Program.instance.InitializeForDataChange();
        }

        private static void ExportResult(bool sucess)
        {
            if (sucess)
            {
                MessageManager.Cast(InterString.Get("导出成功。"));
                foreach(var file in filesToDelete)
                    File.Delete(file);
                filesToDelete.Clear();
            }
            else
                MessageManager.Cast(InterString.Get("导出失败。"));
        }

        public static void ExportAllDecks()
        {
            if (!Directory.Exists(Program.deckPath))
                Directory.CreateDirectory(Program.deckPath);
            var filePaths = Directory.GetFiles(Program.deckPath);
            Export(filePaths);
        }
        public static void ExportAllReplays()
        {
            if (!Directory.Exists(Program.replayPath))
                Directory.CreateDirectory(Program.replayPath);
            var filePaths = Directory.GetFiles(Program.replayPath);
            Export(filePaths);
        }
        public static void ExportAllPictures()
        {
            if (!Directory.Exists(Program.cardPicPath))
                Directory.CreateDirectory(Program.cardPicPath);
            var filePaths = Directory.GetFiles(Program.cardPicPath);
            Export(filePaths, false);
        }

        private static void Export(string[] filePaths, bool copy = true)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            NativeFilePicker.ExportMultipleFiles(filePaths, ExportResult);
            if(!copy)
                filesToDelete = filePaths.ToList();
#elif SUPPORT_WINDOWS_PORT
            StandaloneFileBrowser.OpenFolderPanelAsync(InterString.Get("请选择导出目录"), "", false, (string[] paths) =>
            {
                ExportFiles(paths, filePaths, copy);
            });
#endif
        }

        private static void ExportFiles(string[] result, string[] filePaths, bool copy = true)
        {
            try
            {
                foreach (var file in filePaths)
                {
                    if (copy)
                        File.Copy(file, Path.Combine(result.FirstOrDefault(), Path.GetFileName(file)));
                    else
                        File.Move(file, Path.Combine(result.FirstOrDefault(), Path.GetFileName(file)));
                }
                ExportResult(true);
            }
            catch
            {
                ExportResult(false);
            }
        }

    }

}
