using CSInputs.Enums;

namespace Lumina
{
    internal class MovementUtil
    {

        public static void ResetChar()
        {

            // Reset Char
            if (Settings.Default.Resolution == "1080x1920")
            {
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
                Thread.Sleep(3500);

                CShauto.Mouse.Move(37, 372);
                Thread.Sleep(50);
                CShauto.Mouse.Move(35, 370);
                Thread.Sleep(200);
                CShauto.Mouse.Click();

                Thread.Sleep(500);
                CShauto.Mouse.Move(436, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(435, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(434, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(433, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(432, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(431, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(430, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Move(429, 99);
                Thread.Sleep(50);
                CShauto.Mouse.Click();
                Thread.Sleep(500);
            }
            else if (Settings.Default.Resolution == "1360x768")
            {
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
                Thread.Sleep(3500);

                CShauto.Mouse.Move(31, 258);
                Thread.Sleep(50);
                CShauto.Mouse.Move(35, 260);
                Thread.Sleep(200);
                CShauto.Mouse.Click();

                Thread.Sleep(500);
                CShauto.Mouse.Move(309, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Move(308, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Move(307, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Move(306, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Move(305, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Move(304, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Move(303, 83);
                Thread.Sleep(50);
                CShauto.Mouse.Click();
                Thread.Sleep(500);
            }
            else if (Settings.Default.Resolution == "1680x1050")
            {
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
                Thread.Sleep(3500);

                CShauto.Mouse.Move(70, 370);
                Thread.Sleep(50);
                CShauto.Mouse.Move(46, 370);
                Thread.Sleep(200);
                CShauto.Mouse.Click();

                Thread.Sleep(500);
                CShauto.Mouse.Move(379, 106);
                Thread.Sleep(50);
                CShauto.Mouse.Move(378, 106);
                Thread.Sleep(50);
                CShauto.Mouse.Move(377, 106);
                Thread.Sleep(50);
                CShauto.Mouse.Click();
                Thread.Sleep(500);
            }
            else if (Settings.Default.Resolution == "3440x1440")
            {
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
                Thread.Sleep(3500);

                CShauto.Mouse.Move(62, 489);
                Thread.Sleep(50);
                CShauto.Mouse.Move(62, 496);
                Thread.Sleep(200);
                CShauto.Mouse.Click();

                Thread.Sleep(500);
                CShauto.Mouse.Move(775, 137);
                Thread.Sleep(50);
                CShauto.Mouse.Move(774, 137);
                Thread.Sleep(50);
                CShauto.Mouse.Move(773, 137);
                Thread.Sleep(50);
                CShauto.Mouse.Click();
                Thread.Sleep(500);
            }
        }
    }
}
