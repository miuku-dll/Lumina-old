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
                if (Settings.Default.Resolution == "1080x1920")
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
            if (Settings.Default.Resolution == "1920x1080")
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, 960, 540);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb(
                    (byte)(pixel & 0x000000FF),
                    (byte)((pixel & 0x0000FF00) >> 8),
                    (byte)((pixel & 0x00FF0000) >> 16));

                bool exists;
                string firstMatch;
                IEnumerable<string> matchingList;

                var Colors = new List<string>() { "Color [A=255, R=75, G=138, B=255]", "Color [A=255, R=81, G=99, B=255]", "Color [A=255, R=255, G=127, B=127]", "Color [A=255, R=111, G=150, B=255]", "Color [A=255, R=41, G=22, B=147]", "Color [A=255, R=81, G=64, B=255]", "Color [A=255, R=81, G=66, B=255]", "Color [A=255, R=151, G=162, B=255]", "Color [A=255, R=37, G=86, B=255]", "Color [A=255, R=9, G=104, B=55]", "Color [A=255, R=163, G=34, B=72]", "Color [A=255, R=56, G=201, B=216]", "Color [A=255, R=84, G=96, B=255]", "Color [A=255, R=119, G=91, B=255]", "Color [A=255, R=7, G=142, B=0]", "Color [A=255, R=190, G=210, B=255]", "Color [A=255, R=255, G=66, B=69]", "Color [A=255, R=125, G=255, B=223", "Color [A=255, R=136, G=136, B=136]", "Color [A=255, R=76, G=133, B=255]" };

                exists = Colors.Any(x => x.Contains($"{color}"));
                if (exists)
                { }
                else
                { }
            // exists => true

            loop:
                if ($"{color}".StartsWith("Color [A=255, R=7, G=142, B=0]"))
                {
                    Webhooks.WebhookUndead();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=190, G=210, B=255]"))
                {
                    Webhooks.WebhookComet();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=255, G=66, B=69]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=125, G=255, B=223]"))
                {
                    Webhooks.WebhookPermaFrost();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=136, G=136, B=136]"))
                {
                    Webhooks.WebhookStormal();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=76, G=133, B=255]"))
                {
                    Webhooks.WebhookAquatic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=119, G=91, B=255]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=169, B=0]"))
                {
                    Webhooks.WebhookFlushed();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=85, G=98, B=255]"))
                {
                    Webhooks.WebhookNautilus();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=56, G=201, B=216]"))
                {
                    Webhooks.WebhookExotic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=163, G=34, B=72]"))
                {


                }

                else if ($"{color}".StartsWith("Color [A=255, R=9, G=104, B=55]"))
                {
                    Webhooks.WebhookJade();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=151, G=162, B=255]"))
                {
                    Webhooks.WebhookCelestial();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=37, G=86, B=255]"))
                {
                    Webhooks.WebhookBounded();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=66, B=255]"))
                {
                    Webhooks.WebhookGalaxy();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=64, B=255]"))
                {
                    Webhooks.WebhookTwilight();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=41, G=22, B=147]"))
                {
                    Webhooks.WebhookKyawthuite();
                }

                // Over 1mil

                else if ($"{color}".StartsWith("Color [A=255, R=111, G=150, B=255]"))
                {
                    Webhooks.WebhookArcane();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=127, B=127]"))
                {
                    Webhooks.WebhookStarscourge();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=99, B=255]"))
                {
                    Webhooks.WebhookGravitational();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=75, G=138, B=255]"))
                {
                    Webhooks.WebhookVirtual();
                }

                else
                {

                }
            }
            else if (Settings.Default.Resolution == "3440x1440")
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, 1720, 712);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb(
                    (byte)(pixel & 0x000000FF),
                    (byte)((pixel & 0x0000FF00) >> 8),
                    (byte)((pixel & 0x00FF0000) >> 16));

                bool exists;
                string firstMatch;
                IEnumerable<string> matchingList;

                var Colors = new List<string>() { "Color [A=255, R=75, G=138, B=255]", "Color [A=255, R=81, G=99, B=255]", "Color [A=255, R=255, G=127, B=127]", "Color [A=255, R=111, G=150, B=255]", "Color [A=255, R=41, G=22, B=147]", "Color [A=255, R=81, G=64, B=255]", "Color [A=255, R=81, G=66, B=255]", "Color [A=255, R=151, G=162, B=255]", "Color [A=255, R=37, G=86, B=255]", "Color [A=255, R=9, G=104, B=55]", "Color [A=255, R=163, G=34, B=72]", "Color [A=255, R=56, G=201, B=216]", "Color [A=255, R=84, G=96, B=255]", "Color [A=255, R=119, G=91, B=255]", "Color [A=255, R=7, G=142, B=0]", "Color [A=255, R=190, G=210, B=255]", "Color [A=255, R=255, G=66, B=69]", "Color [A=255, R=125, G=255, B=223", "Color [A=255, R=136, G=136, B=136]", "Color [A=255, R=76, G=133, B=255]" };

                exists = Colors.Any(x => x.Contains($"{color}"));
                if (exists)
                { }
                else
                { }
            // exists => true

            loop:
                if ($"{color}".StartsWith("Color [A=255, R=7, G=142, B=0]"))
                {
                    Webhooks.WebhookUndead();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=190, G=210, B=255]"))
                {
                    Webhooks.WebhookComet();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=255, G=66, B=69]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=125, G=255, B=223]"))
                {
                    Webhooks.WebhookPermaFrost();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=136, G=136, B=136]"))
                {
                    Webhooks.WebhookStormal();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=76, G=133, B=255]"))
                {
                    Webhooks.WebhookAquatic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=119, G=91, B=255]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=169, B=0]"))
                {
                    Webhooks.WebhookFlushed();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=85, G=98, B=255]"))
                {
                    Webhooks.WebhookNautilus();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=56, G=201, B=216]"))
                {
                    Webhooks.WebhookExotic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=163, G=34, B=72]"))
                {


                }

                else if ($"{color}".StartsWith("Color [A=255, R=9, G=104, B=55]"))
                {
                    Webhooks.WebhookJade();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=151, G=162, B=255]"))
                {
                    Webhooks.WebhookCelestial();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=37, G=86, B=255]"))
                {
                    Webhooks.WebhookBounded();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=66, B=255]"))
                {
                    Webhooks.WebhookGalaxy();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=64, B=255]"))
                {
                    Webhooks.WebhookTwilight();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=41, G=22, B=147]"))
                {
                    Webhooks.WebhookKyawthuite();
                }

                // Over 1mil

                else if ($"{color}".StartsWith("Color [A=255, R=111, G=150, B=255]"))
                {
                    Webhooks.WebhookArcane();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=127, B=127]"))
                {
                    Webhooks.WebhookStarscourge();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=99, B=255]"))
                {
                    Webhooks.WebhookGravitational();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=75, G=138, B=255]"))
                {
                    Webhooks.WebhookVirtual();
                }

                else
                {

                }
            }
            else if (Settings.Default.Resolution == "1680x1050")
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, 841, 522);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb(
                    (byte)(pixel & 0x000000FF),
                    (byte)((pixel & 0x0000FF00) >> 8),
                    (byte)((pixel & 0x00FF0000) >> 16));

                bool exists;
                string firstMatch;
                IEnumerable<string> matchingList;

                var Colors = new List<string>() { "Color [A=255, R=75, G=138, B=255]", "Color [A=255, R=81, G=99, B=255]", "Color [A=255, R=255, G=127, B=127]", "Color [A=255, R=111, G=150, B=255]", "Color [A=255, R=41, G=22, B=147]", "Color [A=255, R=81, G=64, B=255]", "Color [A=255, R=81, G=66, B=255]", "Color [A=255, R=151, G=162, B=255]", "Color [A=255, R=37, G=86, B=255]", "Color [A=255, R=9, G=104, B=55]", "Color [A=255, R=163, G=34, B=72]", "Color [A=255, R=56, G=201, B=216]", "Color [A=255, R=84, G=96, B=255]", "Color [A=255, R=119, G=91, B=255]", "Color [A=255, R=7, G=142, B=0]", "Color [A=255, R=190, G=210, B=255]", "Color [A=255, R=255, G=66, B=69]", "Color [A=255, R=125, G=255, B=223", "Color [A=255, R=136, G=136, B=136]", "Color [A=255, R=76, G=133, B=255]" };

                exists = Colors.Any(x => x.Contains($"{color}"));
                if (exists)
                { }
                else
                { }
            // exists => true

            loop:
                if ($"{color}".StartsWith("Color [A=255, R=7, G=142, B=0]"))
                {
                    Webhooks.WebhookUndead();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=190, G=210, B=255]"))
                {
                    Webhooks.WebhookComet();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=255, G=66, B=69]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=125, G=255, B=223]"))
                {
                    Webhooks.WebhookPermaFrost();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=136, G=136, B=136]"))
                {
                    Webhooks.WebhookStormal();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=76, G=133, B=255]"))
                {
                    Webhooks.WebhookAquatic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=119, G=91, B=255]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=169, B=0]"))
                {
                    Webhooks.WebhookFlushed();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=85, G=98, B=255]"))
                {
                    Webhooks.WebhookNautilus();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=56, G=201, B=216]"))
                {
                    Webhooks.WebhookExotic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=163, G=34, B=72]"))
                {


                }

                else if ($"{color}".StartsWith("Color [A=255, R=9, G=104, B=55]"))
                {
                    Webhooks.WebhookJade();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=151, G=162, B=255]"))
                {
                    Webhooks.WebhookCelestial();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=37, G=86, B=255]"))
                {
                    Webhooks.WebhookBounded();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=66, B=255]"))
                {
                    Webhooks.WebhookGalaxy();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=64, B=255]"))
                {
                    Webhooks.WebhookTwilight();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=41, G=22, B=147]"))
                {
                    Webhooks.WebhookKyawthuite();
                }

                // Over 1mil

                else if ($"{color}".StartsWith("Color [A=255, R=111, G=150, B=255]"))
                {
                    Webhooks.WebhookArcane();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=127, B=127]"))
                {
                    Webhooks.WebhookStarscourge();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=99, B=255]"))
                {
                    Webhooks.WebhookGravitational();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=75, G=138, B=255]"))
                {
                    Webhooks.WebhookVirtual();
                }

                else
                {

                }
            }
            else if (Settings.Default.Resolution == "1360x786")
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, 678, 380);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb(
                    (byte)(pixel & 0x000000FF),
                    (byte)((pixel & 0x0000FF00) >> 8),
                    (byte)((pixel & 0x00FF0000) >> 16));

                bool exists;
                string firstMatch;
                IEnumerable<string> matchingList;

                var Colors = new List<string>() { "Color [A=255, R=75, G=138, B=255]", "Color [A=255, R=81, G=99, B=255]", "Color [A=255, R=255, G=127, B=127]", "Color [A=255, R=111, G=150, B=255]", "Color [A=255, R=41, G=22, B=147]", "Color [A=255, R=81, G=64, B=255]", "Color [A=255, R=81, G=66, B=255]", "Color [A=255, R=151, G=162, B=255]", "Color [A=255, R=37, G=86, B=255]", "Color [A=255, R=9, G=104, B=55]", "Color [A=255, R=163, G=34, B=72]", "Color [A=255, R=56, G=201, B=216]", "Color [A=255, R=84, G=96, B=255]", "Color [A=255, R=119, G=91, B=255]", "Color [A=255, R=7, G=142, B=0]", "Color [A=255, R=190, G=210, B=255]", "Color [A=255, R=255, G=66, B=69]", "Color [A=255, R=125, G=255, B=223", "Color [A=255, R=136, G=136, B=136]", "Color [A=255, R=76, G=133, B=255]" };

                exists = Colors.Any(x => x.Contains($"{color}"));
                if (exists)
                { }
                else
                { }
            // exists => true

            loop:
                if ($"{color}".StartsWith("Color [A=255, R=7, G=142, B=0]"))
                {
                    Webhooks.WebhookUndead();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=190, G=210, B=255]"))
                {
                    Webhooks.WebhookComet();

                }
                else if ($"{color}".StartsWith("Color [A=255, R=255, G=66, B=69]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=125, G=255, B=223]"))
                {
                    Webhooks.WebhookPermaFrost();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=136, G=136, B=136]"))
                {
                    Webhooks.WebhookStormal();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=76, G=133, B=255]"))
                {
                    Webhooks.WebhookAquatic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=119, G=91, B=255]"))
                {

                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=169, B=0]"))
                {
                    Webhooks.WebhookFlushed();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=85, G=98, B=255]"))
                {
                    Webhooks.WebhookNautilus();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=56, G=201, B=216]"))
                {
                    Webhooks.WebhookExotic();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=163, G=34, B=72]"))
                {


                }

                else if ($"{color}".StartsWith("Color [A=255, R=9, G=104, B=55]"))
                {
                    Webhooks.WebhookJade();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=151, G=162, B=255]"))
                {
                    Webhooks.WebhookCelestial();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=37, G=86, B=255]"))
                {
                    Webhooks.WebhookBounded();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=66, B=255]"))
                {
                    Webhooks.WebhookGalaxy();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=64, B=255]"))
                {
                    Webhooks.WebhookTwilight();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=41, G=22, B=147]"))
                {
                    Webhooks.WebhookKyawthuite();
                }

                // Over 1mil

                else if ($"{color}".StartsWith("Color [A=255, R=111, G=150, B=255]"))
                {
                    Webhooks.WebhookArcane();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=127, B=127]"))
                {
                    Webhooks.WebhookStarscourge();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=99, B=255]"))
                {
                    Webhooks.WebhookGravitational();
                }

                else if ($"{color}".StartsWith("Color [A=255, R=75, G=138, B=255]"))
                {
                    Webhooks.WebhookVirtual();
                }

                else
                {

                }
            }
        }

    }

}

