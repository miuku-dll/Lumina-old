using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CSInputs;
using CSInputs.Enums;
using SharpHook;
using SharpHook.Native;


namespace Lumina
{
    partial class Movement
    {

        public async static void CollectAll()
        {
            // Leaderboard Spots
            Thread.Sleep(1000);
            MovementUtil.ResetChar();
            Util.ResetKeys();

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(93);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(1234);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(1672);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(2891);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(312);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(4778);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(453);

            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(1172);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(5216);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);

            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);

            // House spots
            MovementUtil.ResetChar();
            Util.ResetKeys();

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(93);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(1234);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(1672);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(313);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(62);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(344);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(78);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(281);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(204);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(187);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(94);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(375);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(187);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(110);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(62);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(297);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(735);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(78);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(312);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);

            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(1844);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(25);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(1200);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(22);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1200);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);

            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);

            // House spots
            MovementUtil.ResetChar();
            Util.ResetKeys();

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(93);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(1234);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(1672);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(484);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(4250);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(391);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);

            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(31);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(250);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(16);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(5062);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(235);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(546);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);

            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(50);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(500);

            // Addint mountain top later, I wrote it like 5 times and it was always off i wanna kms rn
        }
        public static void AutoObb()
        {
            Util.Focus();
            Thread.Sleep(1000);
            Util.ResetKeys();
            Util.ResetChar();

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1034);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(375);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(250);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(282);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(1265);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(625);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(3281);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(594);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(63);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(4906);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(100);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(172);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(406);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(250);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(157);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(750);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(171);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(204);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(515);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(94);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(421);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(297);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(63);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(15);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(219);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(735);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(672);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(78);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(1500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(234);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(63);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(172);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(578);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(125);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(218);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(110);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(578);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(93);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(219);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(781);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(703);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(110);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(844);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(687);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(141);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(109);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(16);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(156);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(344);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            Thread.Sleep(3000);
        }
    }
}
