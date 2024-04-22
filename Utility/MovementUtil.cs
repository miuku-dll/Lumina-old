using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSInputs.Enums;
using Lumina;

namespace Lumina
{
    internal class MovementUtil
    {

        public static void ResetChar()
        {

            // Reset Char

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
            Thread.Sleep(3500);

            // Reset View
            CShauto.Mouse.Move(37, 372);
            Thread.Sleep(50);
            CShauto.Mouse.Move(35, 370);
            Thread.Sleep(200);
            CShauto.Mouse.Click();

            Thread.Sleep(500);

            CShauto.Mouse.Move(397, 90);
            Thread.Sleep(50);
            CShauto.Mouse.Move(400, 95);
            Thread.Sleep(50);
            CShauto.Mouse.Click();
            Thread.Sleep(500);
        }
    }
}
