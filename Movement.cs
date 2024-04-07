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
    internal class Movement
    {

        public static void ResetCam()
        {
            Util.Focus();
            Thread.Sleep(1000);
            CShauto.Mouse.Move(965, 583);
            CShauto.Mouse.Click();

            int i = 1;
            for (; ; )
            {
                CShauto.Mouse.Scroll(150);
                Thread.Sleep(10);
                i++;
                if (i > 30)
                    break;
            }

            for (; ; )
            {
                CShauto.Mouse.Scroll(-35);
                Thread.Sleep(10);
                i++;
                if (i > 31)
                    break;
            }
        }
        public static void CollectAll()
        {
            Util.Focus(); // Focus on Roblox process
            Util.ResetKeys();

            Console.WriteLine("Resetting camera...");
            CShauto.Mouse.Move(962, 598);
            Thread.Sleep(500);

            int i = 1;
            for (; ; )
            {
                CShauto.Mouse.Scroll(150);
                Thread.Sleep(10);
                i++;
                if (i > 30)
                    break;
            }

            for (; ; )
            {
                CShauto.Mouse.Scroll(-35);
                Thread.Sleep(10);
                i++;
                if (i > 31)
                    break;
            }
            Thread.Sleep(1000);
            // Resetting location
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(1000);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(2600);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(5000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(100);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(100);

            // Moving to corner
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(5300);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(300);

            // Resetting character
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(2500);

            // Resetting location
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(100);

            // Moving to house's tree
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(1300);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1200);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down); // Eio toimi
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down); // Eio toimi
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(600);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(1400);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(300);

            // Moving into house
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1900);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(100);
            ResetCam();

            Util.ResetKeys();

            // Resetting character
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(1600);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            Thread.Sleep(10);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(5000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);


            Console.WriteLine("Reset character");
            Webhooks.WebhookReset();
            Thread.Sleep(500);

            // Resetting location
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(1000);


            // Moving to tree
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(200);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(4300);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(100);

            // Moving to the other tree

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(200);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(5500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(400);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(100);

            // Moving to the mountain
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(1400);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            Thread.Sleep(800);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(2300);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(200);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);

            // Collecting items
            Thread.Sleep(100);
            Console.WriteLine("Collecting Items");
            Webhooks.WebhookCollecting();
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Thread.Sleep(100);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Done collecting items");
            Thread.Sleep(100);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(1000);

        }

        public static bool crafting = false;

        public static void GildedCraft()
        {
            Util.Focus();
            Thread.Sleep(1000);

        startcraft:
            if (crafting)
            {

                Console.WriteLine("Resetting store position");
                CShauto.Mouse.Move(380, 717);
                Thread.Sleep(50);
                CShauto.Mouse.Move(327, 678);
                Thread.Sleep(50);
                CShauto.Mouse.Click();
                Thread.Sleep(1200);

                var simulator = new EventSimulator();

                int i = 1;
                for (; ; )
                {
                    CShauto.Mouse.Scroll(200);
                    Thread.Sleep(10);
                    i++;
                    if (i > 30)
                        break;
                }

                for (; ; )
                {
                    CShauto.Mouse.Scroll(-200);
                    Thread.Sleep(10);
                    i++;
                    if (i > 33)
                        break;
                }

                Thread.Sleep(200);

                i = 1;
            ContinueCrafting:
                Console.WriteLine("Starting Gilded coin crafting...");
                for (; ; )
                {


                    CShauto.Mouse.Move(364, 902);
                    Thread.Sleep(50);
                    CShauto.Mouse.Move(280, 901);
                    Thread.Sleep(50);
                    CShauto.Mouse.Click();

                    Thread.Sleep(150);
                    CShauto.Mouse.Move(1240, 453);
                    Thread.Sleep(50);
                    CShauto.Mouse.Move(1263, 445);
                    Thread.Sleep(50);
                    CShauto.Mouse.Click();

                    Thread.Sleep(150);
                    CShauto.Mouse.Move(1031, 701);
                    Thread.Sleep(50);
                    CShauto.Mouse.Move(999, 683);
                    Thread.Sleep(50);
                    CShauto.Mouse.Click();

                    Thread.Sleep(100);
                    Console.WriteLine("Crafted " + i);
                    i++;
                    if (i > 5)
                        break;
                }
                Console.WriteLine("Done crafting Gilded coins");
                Thread.Sleep(2000);

                string CheckPath = File.ReadAllText(@".\Config\Status1.txt");
                if (CheckPath.Contains("On", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Closing store...");
                    CShauto.Mouse.Move(338, 61);
                    Thread.Sleep(50);
                    CShauto.Mouse.Move(287, 58);
                    Thread.Sleep(50);
                    CShauto.Mouse.Click();
                    Thread.Sleep(50);
                }
                else
                {
                    goto ContinueCrafting;
                }
            }
            else
            {
                Console.WriteLine("Resetting postion for crafting.");


                ResetCam();

                // Resetting character
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R);
                Thread.Sleep(500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return);
                Console.WriteLine("Reset character");
                Webhooks.WebhookReset();
                Thread.Sleep(2500);

                // Resetting location
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
                Thread.Sleep(1500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
                Thread.Sleep(1000);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
                Thread.Sleep(1000);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
                Thread.Sleep(10);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
                Thread.Sleep(100);

                Console.WriteLine("Done.");
                Thread.Sleep(500);
                Webhooks.WebhookJack();
                Console.WriteLine("Moving to Jake's Workshop.");

                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
                Thread.Sleep(2000);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
                Thread.Sleep(1500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
                Thread.Sleep(1500);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
                CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
                Thread.Sleep(4000);
                CShauto.Mouse.Move(627, 907);
                Thread.Sleep(50);
                CShauto.Mouse.Click();

                CShauto.Mouse.Move(592, 910);
                Thread.Sleep(50);
                CShauto.Mouse.Click();
                Console.WriteLine("Crafting...");

                crafting = true;
                goto startcraft;
            }
        }

        public static void MoveToStella()
        {
            Console.WriteLine("Focusing on Roblox process...");
            Util.Focus();
            Thread.Sleep(1000);
            Util.ResetKeys();

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Shift, KeyFlags.Down);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Shift, KeyFlags.Up);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape, KeyFlags.Down);
            Thread.Sleep(400);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R, KeyFlags.Down);
            Thread.Sleep(400);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.R, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return, KeyFlags.Down);
            Thread.Sleep(400);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Return, KeyFlags.Up);

            Console.WriteLine("Resetting X axis...");
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Thread.Sleep(10);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);
            Thread.Sleep(100);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(5000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);

            Console.WriteLine("Moving to stellas dungeon...");
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(9000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(1450);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Down);
            Thread.Sleep(3700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Space, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(3500);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Down);
            Thread.Sleep(1000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.S, KeyFlags.Up);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(2000);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Down);
            Thread.Sleep(700);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.A, KeyFlags.Up);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Down);
            Thread.Sleep(150);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.W, KeyFlags.Up);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Down);
            Thread.Sleep(150);
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.D, KeyFlags.Up);
            Console.WriteLine("Entering crafting menu...");

            var simulator = new EventSimulator();

            int i = 1;
            for (; ; )
            {
                CShauto.Mouse.Scroll(150);
                Thread.Sleep(10);
                i++;
                if (i > 30)
                    break;
            }

            CShauto.Mouse.Scroll(-5);
            Thread.Sleep(200);

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.F);
            Console.WriteLine("Arrived at Stellas crafting menu...");

            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Shift);
            Console.WriteLine("Starting crafting process...");

            Thread.Sleep(50);

            Thread.Sleep(150);
            CShauto.Mouse.Move(369, 437);
            Thread.Sleep(50);
            CShauto.Mouse.Move(371, 439);
            Thread.Sleep(50);
            CShauto.Mouse.Click();


            Thread.Sleep(100);
            CShauto.Mouse.Move(702, 379);
            CShauto.Mouse.Move(704, 377);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1281, 449);
            CShauto.Mouse.Move(1274, 449);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1296, 492);
            CShauto.Mouse.Move(1299, 496);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1293, 530);
            CShauto.Mouse.Move(1297, 534);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1267, 578);
            CShauto.Mouse.Move(1269, 575);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1112, 682);
            CShauto.Mouse.Move(1110, 686);
            CShauto.Mouse.Click();
            Thread.Sleep(1200);

            Thread.Sleep(50);
            CShauto.Mouse.Move(1283, 447);

            CShauto.Mouse.Move(1283, 447);
            CShauto.Mouse.Move(1281, 444);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1276, 491);
            CShauto.Mouse.Move(1272, 490);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1289, 537);
            CShauto.Mouse.Move(1287, 533);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1296, 576);
            CShauto.Mouse.Move(1293, 573);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1293, 614);
            CShauto.Mouse.Move(1290, 617);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(1267, 677);
            CShauto.Mouse.Move(1269, 675);
            CShauto.Mouse.Click();
            Thread.Sleep(100);
            CShauto.Mouse.Move(396, 65);
            CShauto.Mouse.Move(398, 63);
            CShauto.Mouse.Click();
            Thread.Sleep(1200);
        }
    }
}
