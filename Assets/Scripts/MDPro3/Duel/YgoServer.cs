using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace MDPro3.Net
{
    internal static unsafe class Dll
    {
        [DllImport("ygoserver", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int start_server([MarshalAs(UnmanagedType.LPStr)] string args);
        [DllImport("ygoserver", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void stop_server();
    }

    public class YgoServer
    {
        public static Thread serverThread;
        public static void StartServer(string args)
        {
            if(ServerRunning())
                StopServer();

            serverThread = new Thread(() =>
            {
                Dll.start_server(args);
            });
            serverThread.Start();
        }

        public static void StopServer()
        {
            Dll.stop_server();
            serverThread?.Abort();
        }

        public static bool ServerRunning()
        {
            return serverThread != null && serverThread.IsAlive;
        }
    }
}
