using CSInputs.Enums;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Lumina
{
    partial class Movement
    {
        public static async Task Run()
        {
            await Task.Delay(1000);

            Util.Focus();
            Thread.Sleep(1000);

            while (Settings.Default.ison == true)
            {
                if (Settings.Default.ison == false)
                {
                    break;
                }
                Util.ResetKeys();

                if (Settings.Default.FishingStatus == true)
                {
                    CheckStatus();

                    [DllImport("user32.dll")]
                    static extern IntPtr GetDC(IntPtr hwnd);
                    [DllImport("user32.dll")]
                    static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
                    [DllImport("gdi32.dll")]
                    static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

                    IntPtr hdc = GetDC(IntPtr.Zero);
                    uint pixel = GetPixel(hdc, 835, 821);
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

                        var Colors = new List<string>() { "Color [A=255, R=255, G=255, B=255]", "Color [A=255, R=251, G=98, B=76]" };

                        if ($"{color}".StartsWith("Color [A=255, R=255, G=255, B=255]"))
                        {
                            CShauto.Mouse.Move(835, 821);
                            Thread.Sleep(50);
                            CShauto.Mouse.Click();
                        }
                    }
                    catch
                    {

                    }

                }
                else
                {

                }
            }
        }

        public static void CheckStatus()
        {
            [DllImport("user32.dll")]
            static extern IntPtr GetDC(IntPtr hwnd);
            [DllImport("user32.dll")]
            static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
            [DllImport("gdi32.dll")]
            static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, 796, 831);
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

                var Colors = new List<string>() { "Color [A=255, R=251, G=98, B=76]" };

                if ($"{color}".StartsWith("Color [A=255, R=251, G=98, B=76]"))
                {

                }
                else
                {
                    string numberString = Settings.Default.SleepTime;
                    int a = int.Parse(numberString);

                    CShauto.Mouse.Move(973, 233);
                    Thread.Sleep(50);
                    CShauto.Mouse.Click();
                    Thread.Sleep(a);
                    CShauto.Mouse.Click();
                }
            }
            catch
            {

            }
        }


        public static void Obby()
        {
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(531);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(1188);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(1328);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(766);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1265);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(1688);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(859);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(641);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(230);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(5015);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(625);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(32);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(313);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(312);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(859);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(47);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(78);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(234);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(313);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(281);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(297);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(31);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(563);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(187);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(282);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(343);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(1594);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(266);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(31);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(687);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(140);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(766);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(219);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(218);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(204);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(250);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(31);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(688);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(656);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(172);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(813);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(781);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(16);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(750);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(609);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(3000);

        }
    }
}
