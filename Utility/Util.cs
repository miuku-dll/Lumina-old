using CSInputs.Enums;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

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
            catch { }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        public static void CheckChat()
        {
            try
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, 79, 19);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb(
                    (byte)(pixel & 0x000000FF),
                    (byte)((pixel & 0x0000FF00) >> 8),
                    (byte)((pixel & 0x00FF0000) >> 16));
                try
                {
                    bool exists;
                    string firstMatch;
                    IEnumerable<string> matchingList;

                    var Colors = new List<string>() { "Color [A=255, R=255, G=255, B=255]" };

                    if ($"{color}".StartsWith("Color [A=255, R=255, G=255, B=255]"))
                    {
                        Webhooks.WebhookUndead();
                        Thread.Sleep(100);
                        CShauto.Mouse.Move(79, 19);
                        Thread.Sleep(50);
                        CShauto.Mouse.Move(81, 20);
                        Thread.Sleep(50);
                        CShauto.Mouse.Click();
                    }
                    else
                    {
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to check chat");
                }

            }
            catch { }
        }

        public static void SaveConfig()
        {
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        public static void CheckObby()
        {

        }
        public static void ResetChar()
        {
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
            Thread.Sleep(3500);
        }
        public static void ResetKeys()
        {
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
        }

        public static void StartPrivateServer()
        {
            string PrivateServer = Settings.Default.PrivateServer;

            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(PrivateServer);
                Thread.Sleep(10000);
            }
            catch { }
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
                StartPrivateServer();
            }
        }
    }
}
