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
            catch
            { MessageBox.Show("Fatal error occurred while checking chat status."); }
        }

        public static void SaveConfig()
        {
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        public static void CheckObby()
        {
            try
            {
                if (Settings.Default.Resolution == "1920x1080")
                {
                    bool exists;
                    string firstMatch;
                    IEnumerable<string> matchingList;
                    var Colors = new List<string>() { "Color [A=255, R=153, G=250, B=169]" };

                    if (Settings.Default.GloveCount == "0")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1887, 1053);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby();
                        }
                    }
                    else if (Settings.Default.GloveCount == "1")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1829, 1053);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                    else if (Settings.Default.GloveCount == "2")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1770, 1053);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                }
                else if (Settings.Default.Resolution == "1360x768")
                {
                    bool exists;
                    string firstMatch;
                    IEnumerable<string> matchingList;
                    var Colors = new List<string>() { "Color [A=255, R=153, G=250, B=169]" };

                    if (Settings.Default.GloveCount == "0")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1341, 750);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby();
                        }
                    }
                    else if (Settings.Default.GloveCount == "1")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1296, 750);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                    else if (Settings.Default.GloveCount == "2")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1251, 750);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                }

                else if (Settings.Default.Resolution == "3440x1440")
                {
                    bool exists;
                    string firstMatch;
                    IEnumerable<string> matchingList;
                    var Colors = new List<string>() { "Color [A=255, R=153, G=250, B=169]" };

                    if (Settings.Default.GloveCount == "0")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 3402, 1407);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby();
                        }
                    }
                    else if (Settings.Default.GloveCount == "1")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 3329, 1407);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                    else if (Settings.Default.GloveCount == "2")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 3248, 1406);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                }

                else if (Settings.Default.Resolution == "1680x1050")
                {
                    bool exists;
                    string firstMatch;
                    IEnumerable<string> matchingList;
                    var Colors = new List<string>() { "Color [A=255, R=153, G=250, B=169]" };

                    if (Settings.Default.GloveCount == "0")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1654, 1023);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby();
                        }
                    }
                    else if (Settings.Default.GloveCount == "1")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 1527, 1019);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                    else if (Settings.Default.GloveCount == "2")
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        uint pixel = GetPixel(hdc, 3248, 1406);
                        ReleaseDC(IntPtr.Zero, hdc);
                        Color color = Color.FromArgb(
                            (byte)(pixel & 0x000000FF),
                            (byte)((pixel & 0x0000FF00) >> 8),
                            (byte)((pixel & 0x00FF0000) >> 16));

                        if ($"{color}".StartsWith("Color [A=255, R=153, G=250, B=169]"))
                        { }
                        else
                        {
                            Movement.Obby(); // Doesnt really work, since if you have any extra effects on it wont read shit, could just add a setting for how many gloves u have enabled etc (too much work)
                        }
                    }
                }

            }
            catch { }
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

        public static void StarDetection()
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            Color color = GetScreenPixelColor(hdc, Settings.Default.Resolution);
            ReleaseDC(IntPtr.Zero, hdc);

            var colorActions = new Dictionary<string, Action>
    {
        { "Color [A=255, R=7, G=142, B=0]", Webhooks.WebhookUndead },
        { "Color [A=255, R=190, G=210, B=255]", Webhooks.WebhookComet },
        { "Color [A=255, R=125, G=255, B=223]", Webhooks.WebhookPermaFrost },
        { "Color [A=255, R=136, G=136, B=136]", Webhooks.WebhookStormal },
        { "Color [A=255, R=76, G=133, B=255]", Webhooks.WebhookAquatic },
        { "Color [A=255, R=255, G=169, B=0]", Webhooks.WebhookFlushed },
        { "Color [A=255, R=85, G=98, B=255]", Webhooks.WebhookNautilus },
        { "Color [A=255, R=56, G=201, B=216]", Webhooks.WebhookExotic },
        { "Color [A=255, R=9, G=104, B=55]", Webhooks.WebhookJade },
        { "Color [A=255, R=151, G=162, B=255]", Webhooks.WebhookCelestial },
        { "Color [A=255, R=37, G=86, B=255]", Webhooks.WebhookBounded },
        { "Color [A=255, R=81, G=66, B=255]", Webhooks.WebhookGalaxy },
        { "Color [A=255, R=81, G=64, B=255]", Webhooks.WebhookTwilight },
        { "Color [A=255, R=41, G=22, B=147]", Webhooks.WebhookKyawthuite },
        { "Color [A=255, R=111, G=150, B=255]", Webhooks.WebhookArcane },
        { "Color [A=255, R=255, G=127, B=127]", Webhooks.WebhookStarscourge },
        { "Color [A=255, R=81, G=99, B=255]", Webhooks.WebhookGravitational },
        { "Color [A=255, R=75, G=138, B=255]", Webhooks.WebhookVirtual }
    };

            string colorString = color.ToString();
            if (colorActions.TryGetValue(colorString, out Action action))
            {
                action();
            }
        }

        private static Color GetScreenPixelColor(IntPtr hdc, string resolution)
        {
            (int x, int y) = resolution switch
            {
                "1920x1080" => (960, 540),
                "3440x1440" => (1720, 712),
                "1680x1050" => (841, 522),
                "1360x786" => (678, 380),
                _ => throw new ArgumentException("Unsupported resolution")
            };

            uint pixel = GetPixel(hdc, x, y);
            return Color.FromArgb(
                (byte)(pixel & 0x000000FF),
                (byte)((pixel & 0x0000FF00) >> 8),
                (byte)((pixel & 0x00FF0000) >> 16));
        }

    }

}

