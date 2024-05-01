using CSInputs.Enums;

namespace Lumina
{
    partial class Movement
    {
        public static async Task Run()
        {
            await Task.Delay(1000);

            while (Settings.Default.ison == true)
            {
                if (Settings.Default.ison == false)
                {
                    break;
                }

                Util.Focus();
                Thread.Sleep(1000);
                MovementUtil.ResetChar();
                Util.ResetKeys();

                if (Settings.Default.CollectStatus == true)
                {
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
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
                    Thread.Sleep(1891);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
                    Thread.Sleep(31);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
                    Thread.Sleep(297);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
                    Thread.Sleep(156);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
                    Thread.Sleep(234);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
                    Thread.Sleep(297);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
                    Thread.Sleep(391);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
                    Thread.Sleep(297);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
                    Thread.Sleep(437);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
                    Thread.Sleep(1250);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
                    Thread.Sleep(110);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
                    Thread.Sleep(453);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
                    Thread.Sleep(300);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
                    Thread.Sleep(100);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
                    Thread.Sleep(906);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
                    Thread.Sleep(16);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
                    Thread.Sleep(359);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
                    Thread.Sleep(500);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
                    Thread.Sleep(50);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
                    Thread.Sleep(50);
                    CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
                    Thread.Sleep(500);
                }
                else
                {

                }

                if (Settings.Default.ObbyStatus == true)
                {
                    Util.Focus();
                    Thread.Sleep(1000);
                    Util.ResetChar();
                    Util.ResetKeys();

                    Util.CheckObby();
                }
                else { }
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
