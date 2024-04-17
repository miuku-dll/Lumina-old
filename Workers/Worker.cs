using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumina.Workers
{
    partial class Worker
    {

        public static async Task Run()
        {
            await TaskScheduler.Default;

            while (Settings.Default.ison == true)
            {
                Util.Focus();
                await Task.Delay(1000);
                Util.CheckChat();
            loop:
                int i = 1;
                if (Settings.Default.Status1 == false)
                {
                    return;
                }

                else if (Settings.Default.Status1 == true)
                {
                    await Task.Delay(1000);
                    Util.Focus();
                    Task.Factory.StartNew(() => Movement.CollectAll());

                    goto AfterLoop;

                }
            AfterLoop:
                if (Settings.Default.Status2 == true)
                {
                    Task.Factory.StartNew(() => Movement.AutoObb());
                    Util.ResetChar();
                }
                else
                {
                    goto loop;
                }
            }
        }
    }
}

