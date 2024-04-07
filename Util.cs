using CSInputs.Enums;
using Lumina.Views.Pages;
using SharpHook;
using SharpHook.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Lumina
{
    class Util
    {

        public static void sendDiscordWebhook(string URL, string escapedjson)
        {
            try
            {
                var wr = WebRequest.Create(URL);
                wr.ContentType = "application/json";
                wr.Method = "POST";
                using (var sw = new StreamWriter(wr.GetRequestStream()))
                    sw.Write(escapedjson);
                wr.GetResponse();
            }
            catch
            {

            }
        }

        public static void ResetKeys()
        {
            var simulator = new EventSimulator(); // For mouse hooks
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            simulator.SimulateMouseRelease(MouseButton.Button1);
        }

        public static void StartPrivateServer()
        {
            string PrivateServer = File.ReadAllText(@"./Config/PrivateServer.txt");

            try
            {
                try
                {
                    Process.Start(
                        new ProcessStartInfo()
                        {
                            UseShellExecute = true,
                            FileName = "vivaldi",
                            Arguments = PrivateServer
                        }
                    );
                }
                catch
                {
                    MessageBox.Show("vivaldi Not Found");
                    Thread.Sleep(1000);
                    try
                    {
                        Process.Start(
                            new ProcessStartInfo()
                            {
                                UseShellExecute = true,
                                FileName = "chrome",
                                Arguments = PrivateServer
                            }
                        );
                    }
                    catch
                    {
                        MessageBox.Show("chrome Not Found");
                        Thread.Sleep(1000);
                        try
                        {
                            Process.Start(
                                new ProcessStartInfo()
                                {
                                    UseShellExecute = true,
                                    FileName = "edge",
                                    Arguments = PrivateServer
                                }
                            );
                        }
                        catch
                        {
                            MessageBox.Show("Edge not found, Make sure you have a compatible browser installed.");
                        }
                    }
                }

                int i = 1;
                for (; ; )
                {
                    i++;
                    if (i > 4)
                        break;
                }

                for (; ; )
                {
                    i++;
                    if (i > 4)
                        break;
                }
            }
            catch
            {
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void Focus()
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
                SetForegroundWindow(processes[0].MainWindowHandle);
            }
            catch
            {
                MessageBox.Show("Roblox is not running...");
            }
        }

        public static void RobloxRunning()
        {
            var robloxRunning = Process.GetProcessesByName("RobloxPlayerBeta").Any();
            if (robloxRunning)
            {

            }
            else
            {
                StartPrivateServer();

            }
        }



        public static void AutoCraft()
        {
            Focus();
            RobloxRunning();
        }

        public static void AutoCollect()
        {
            Focus();
            Movement.CollectAll();
            RobloxRunning();
        }
    }
}
